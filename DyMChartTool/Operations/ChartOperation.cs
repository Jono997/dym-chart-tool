using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class ChartOperation
    {

        /// <summary>
        /// If true, this operation applies to the entire chart.<br />
        /// If false, this operation applies to notes in-between range_start and range_end
        /// </summary>
        public bool entire_chart { get; private protected set; }

        public float start_time { get; private protected set; }

        public float end_time { get; private protected set; }

        public const byte MainTrackFlag = 0x01;

        public const byte LeftTrackFlag = 0x02;

        public const byte RightTrackFlag = 0x04;

        public byte track_flags { get; private protected set; }

        /// <summary>
        /// Destructively applies this operation to the chart and returns it.
        /// </summary>
        /// <param name="chart">The chart to apply the operation to</param>
        /// <returns>The chart passed in</returns>
        public virtual CMap apply(CMap chart)
        {
            return chart;
        }

        #region getApplyRange
        /// <summary>
        /// Get the indexes of the notes to modify in the operation
        /// </summary>
        /// <param name="notes">The note collection to scan</param>
        /// <param name="include_inflowing_holds">If true, hold notes that start before start_time, but end within range are included</param>
        /// <param name="include_outflowing_holds">If true, hold notes that start within range, but end after end_time are included</param>
        /// <returns>An int list of all the indexes of the notes to modify</returns>
        private protected List<int> getApplyRange(NoteCollection notes, bool include_inflowing_holds, bool include_outflowing_holds)
        {
            List<int> applyTo = new List<int>();
            if (entire_chart)
                for (int i = 0; i < notes.m_notes.Length; i++)
                    applyTo.Add(i);
            else
            {
                Dictionary<int, int[]> sub_pairs = new Dictionary<int, int[]>();
                for (int i = 0; i < notes.m_notes.Length; i++)
                {
                    CMapNoteAsset note = notes.m_notes[i];
                    switch (note.m_type)
                    {
                        case CMapNoteAsset.Type.HOLD:
                            if (!sub_pairs.ContainsKey(note.m_subId))
                                sub_pairs.Add(note.m_subId, new int[] { -1, -1 });
                            sub_pairs[note.m_subId][0] = i;
                            break;
                        case CMapNoteAsset.Type.SUB:
                            if (!sub_pairs.ContainsKey(note.m_id))
                                sub_pairs.Add(note.m_id, new int[] { -1, -1 });
                            sub_pairs[note.m_id][1] = i;
                            break;
                        default:
                            if (note.m_time >= start_time && note.m_time <= end_time)
                                applyTo.Add(i);
                            break;
                    }
                }
                foreach (int[] hs in sub_pairs.Values)
                {
                    float start = notes.m_notes[hs[0]].m_time;
                    float end = notes.m_notes[hs[1]].m_time;
                    if (
                            (include_inflowing_holds || start >= start_time) && start <= end_time &&
                            (include_outflowing_holds || end <= end_time) && end >= start_time
                       )
                        applyTo.AddRange(hs);
                }
            }
            return applyTo;
        }

        /// <summary>
        /// Get the indexes of the notes to modify in the operation
        /// </summary>
        /// <param name="notes">The List of Note objects to scan</param>
        /// <param name="include_inflowing_holds">If true, hold notes that start before start_time, but end within range are included</param>
        /// <param name="include_outflowing_holds">If true, hold notes that start within range, but end after end_time are included</param>
        /// <returns>An int list of all the indexes of the notes to modify</returns>
        private protected List<int> getApplyRange(List<Note> notes, bool include_inflowing_holds, bool include_outflowing_holds)
        {
            List<int> applyTo = new List<int>();
            if (entire_chart)
                for (int i = 0; i < notes.Count; i++)
                    applyTo.Add(i);
            else
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    Note note = notes[i];
                    float end = note.time + note.length;
                    if (
                            (include_inflowing_holds || note.time >= start_time) && note.time <= end_time &&
                            (include_outflowing_holds || end <= end_time) && end >= start_time
                       )
                        applyTo.Add(i);
                }
            }
            return applyTo;
        }

        /// <summary>
        /// Get the indexes of the notes to modify in the operation
        /// </summary>
        /// <param name="notes">The note collection to scan</param>
        /// <returns>An int list of all the indexes of the notes to modify</returns>
        /// </summary>
        private protected List<int> getApplyRange(NoteCollection notes)
        {
            return getApplyRange(notes, true, true);
        }

        /// <summary>
        /// Get the indexes of the notes to modify in the operation
        /// </summary>
        /// <param name="notes">The List of Note objects to scan</param>
        /// <returns>An int list of all the indexes of the notes to modify</returns>
        /// </summary>
        private protected List<int> getApplyRange(List<Note> notes)
        {
            return getApplyRange(notes, true, true);
        }
        #endregion

        /// <summary>
        /// Converts a NoteCollection into a List of Note objects and returns it
        /// </summary>
        /// <param name="m_notes">The NoteCollection to convert</param>
        /// <returns>The List of converted Note objects</returns>
        /// <exception cref="OrphanSubException">m_notes contained a SUB note with no corresponding HOLD object or vice-versa</exception>
        private protected List<Note> NoteCollectionToNoteList(NoteCollection m_notes)
        {
            List<Note> retVal = new List<Note>();
            Dictionary<int, CMapNoteAsset> pending_subs = new Dictionary<int, CMapNoteAsset>();

            for (int i = 0; i < m_notes.m_notes.Length; i++)
            {
                CMapNoteAsset note = m_notes.m_notes[i];
                switch (note.m_type)
                {
                    case CMapNoteAsset.Type.HOLD:
                        if (pending_subs.ContainsKey(note.m_subId))
                        {
                            retVal.Add(note.toNote(pending_subs[note.m_subId]));
                            pending_subs.Remove(note.m_subId);
                        }
                        else
                            pending_subs.Add(note.m_subId, note);
                        break;
                    case CMapNoteAsset.Type.SUB:
                        if (pending_subs.ContainsKey(note.m_id))
                        {
                            retVal.Add(pending_subs[note.m_id].toNote(note));
                            pending_subs.Remove(note.m_id);
                        }
                        else
                            pending_subs.Add(note.m_id, note);
                        break;
                    default:
                        retVal.Add(note.toNote(null));
                        break;
                }
            }

            if (pending_subs.Count > 0)
            {
                string orphan_subs = "";
                foreach (int sub in pending_subs.Keys)
                    orphan_subs += $" {sub}";
                throw new OrphanSubException($"Incomplete hold/sub pairs:{orphan_subs}");
            }
            return retVal;
        }

        /// <summary>
        /// Converts a List of Note objects to a NoteCollection and returns it
        /// </summary>
        /// <param name="notes">The List of Notes to convert</param>
        /// <returns>The resulting NoteCollection</returns>
        private protected NoteCollection NoteListToNoteCollection(List<Note> notes)
        {
            List<CMapNoteAsset> retVal = new List<CMapNoteAsset>();

            int current_id = 1;
            foreach (Note note in notes)
            {
                CMapNoteAsset[] c_note = note.toCMapNoteAsset(current_id);
                retVal.Add(c_note[0]);
                if (c_note[1] != null)
                {
                    retVal.Add(c_note[1]);
                    current_id++;
                }
                current_id++;
            }

            return new NoteCollection()
            {
                m_notes = retVal.ToArray()
            };
        }

        /// <summary>
        /// Gets the string representation of the time this operation applies to. Meant to be used in toString()
        /// </summary>
        /// <returns>"Whole chart" if entire_chart is true<br />
        /// "[start_time] to [end_time]" if entire_chart if false</returns>
        private protected string durationToString()
        {
            return entire_chart ? "Whole chart" : $"{start_time} to {end_time}";
        }
    }


    [Serializable]
    public class OrphanSubException : Exception
    {
        public OrphanSubException() { }
        public OrphanSubException(string message) : base(message) { }
        public OrphanSubException(string message, Exception inner) : base(message, inner) { }
        protected OrphanSubException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
