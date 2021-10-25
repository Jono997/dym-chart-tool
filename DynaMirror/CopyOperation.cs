using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaMirror
{
    class CopyOperation: ChartOperation
    {
        /// <summary>
        /// The start time of the copy range
        /// </summary>
        public float start_time { get; private set; }

        /// <summary>
        /// The end tie of the copy range
        /// </summary>
        public float end_time { get; private set; }

        /// <summary>
        /// The start point of the paste
        /// </summary>
        public float destination_time { get; private set; }

        public const byte MainTrackFlag = 0x01;

        public const byte LeftTrackFlag = 0x02;

        public const byte RightTrackFlag = 0x04;

        public byte track_flags { get; private set; }

        /// <summary>
        /// If true, destination_time will be treated as if it were the start_time of the destination.<br />
        /// If false, destination_time will be treated as the time of the first note of the destination.
        /// </summary>
        public bool start_from_start { get; private set; }

        public CopyOperation(float start_time, float end_time, float destination_time, byte track_flags, bool start_from_start)
        {
            this.start_time = start_time;
            this.end_time = end_time;
            this.destination_time = destination_time;
            this.track_flags = track_flags;
            this.start_from_start = start_from_start;
        }

        public CopyOperation(float start_time, float end_time, float destination_time, bool main_track, bool left_track, bool right_track, bool start_from_start)
        {
            this.start_time = start_time;
            this.end_time = end_time;
            this.destination_time = destination_time;
            track_flags = 0x00;
            if (main_track)
                track_flags = (byte)(track_flags | MainTrackFlag);
            if (left_track)
                track_flags = (byte)(track_flags | LeftTrackFlag);
            if (right_track)
                track_flags = (byte)(track_flags | RightTrackFlag);
            this.start_from_start = start_from_start;
        }

        public override string ToString()
        {
            string retVal = "Copy ";
            retVal += start_time.ToString() + " to " + end_time.ToString();
            retVal += ": ";
            if ((track_flags & MainTrackFlag) > 0)
                retVal += 'M';
            if ((track_flags & LeftTrackFlag) > 0)
                retVal += 'L';
            if ((track_flags & RightTrackFlag) > 0)
                retVal += 'R';
            retVal += " at " + destination_time.ToString();
            return retVal;
        }

        private float anchor;
        private int lowest_available_id;

        public override CMap apply(CMap chart)
        {
            List<CMapNoteAsset>[] tracks = new List<CMapNoteAsset>[] { null, null, null };
            bool copy_main  = (track_flags & MainTrackFlag)  > 0;
            bool copy_left  = (track_flags & LeftTrackFlag)  > 0;
            bool copy_right = (track_flags & RightTrackFlag) > 0;

            #region Get notes and other data
            anchor = start_from_start ? start_time : end_time;
            lowest_available_id = 0;
            Dictionary<int, int[]> subs = new Dictionary<int, int[]>();
            Dictionary<int, int> orphan_subs = new Dictionary<int, int>();
            apply_getNotes(tracks, subs, orphan_subs, chart.m_notes, 0, copy_main);
            apply_getNotes(tracks, subs, orphan_subs, chart.m_notesLeft, 1, copy_left);
            apply_getNotes(tracks, subs, orphan_subs, chart.m_notesRight, 2, copy_right);
            //if (copy_main)
            //    tracks[0] = new List<CMapNoteAsset>();
            //foreach (CMapNoteAsset note in chart.m_notes.m_notes)
            //{
            //    if (copy_main && ((note.m_time >= start_time && note.m_time < end_time) || (note.m_type == CMapNoteAsset.Type.SUB && subs.ContainsKey(note.m_id))))
            //    {
            //        tracks[0].Add(note.Copy());
            //        if (!start_from_start && anchor > note.m_time)
            //            anchor = note.m_time;
            //        if (note.m_type == CMapNoteAsset.Type.HOLD)
            //        {
            //            if (!subs.ContainsKey(note.m_subId))
            //                subs.Add(note.m_subId, new int[] { 0, note.m_subId, 0 });
            //            else
            //            {
            //                subs[note.m_subId][1] = note.m_subId;
            //                if (orphan_subs.ContainsKey(note.m_subId))
            //                    orphan_subs.Remove(note.m_subId);
            //            }
            //        }
            //        else if (note.m_type == CMapNoteAsset.Type.SUB)
            //        {
            //            if (!subs.ContainsKey(note.m_id))
            //            {
            //                subs.Add(note.m_id, new int[] { 0, 0, note.m_id });
            //                orphan_subs.Add(note.m_id, 0);
            //            }
            //            else
            //                subs[note.m_subId][2] = note.m_id;
            //        }
            //    }
            //    if (lowest_available_id < note.m_id)
            //        lowest_available_id = note.m_id;
            //}
            #endregion

            #region Copy notes
            if (copy_main)
            {
                //List<CMapNoteAsset> notes = chart.m_notes.m_notes.ToList();
                //foreach (CMapNoteAsset note in tracks[0])
                //    if (!(note.m_type == CMapNoteAsset.Type.SUB && orphan_subs.ContainsKey(note.m_id)))
                //    {
                //        note.m_id = ++lowest_available_id;
                //        note.m_time -= anchor;
                //        note.m_time += destination_time;
                //        notes.Add(note);
                //    }
                //chart.m_notes.m_notes = notes.ToArray();
                apply_setNotes(orphan_subs, chart.m_notes, tracks[0]);
            }
            if (copy_left)
                apply_setNotes(orphan_subs, chart.m_notesLeft, tracks[1]);
            if (copy_right)
                apply_setNotes(orphan_subs, chart.m_notesRight, tracks[2]);
            #endregion
            return chart;
        }

        private void apply_getNotes(List<CMapNoteAsset>[] tracks, Dictionary<int, int[]> subs, Dictionary<int, int> orphan_subs, NoteCollection m_notes, int track, bool copy_track)
        {
            if (copy_track)
                tracks[track] = new List<CMapNoteAsset>();
            foreach (CMapNoteAsset note in m_notes.m_notes)
            {
                if (copy_track && ((note.m_time >= start_time && note.m_time < end_time) || (note.m_type == CMapNoteAsset.Type.SUB && subs.ContainsKey(note.m_id))))
                {
                    tracks[0].Add(note.Copy());
                    if (!start_from_start && anchor > note.m_time)
                        anchor = note.m_time;
                    if (note.m_type == CMapNoteAsset.Type.HOLD)
                    {
                        if (!subs.ContainsKey(note.m_subId))
                            subs.Add(note.m_subId, new int[] { track, note.m_subId, 0 });
                        else
                        {
                            subs[note.m_subId][1] = note.m_subId;
                            if (orphan_subs.ContainsKey(note.m_subId))
                                orphan_subs.Remove(note.m_subId);
                        }
                    }
                    else if (note.m_type == CMapNoteAsset.Type.SUB)
                    {
                        if (!subs.ContainsKey(note.m_id))
                        {
                            subs.Add(note.m_id, new int[] { track, 0, note.m_id });
                            orphan_subs.Add(note.m_id, 0);
                        }
                        else
                            subs[note.m_id][2] = note.m_id;
                    }
                }
                if (lowest_available_id < note.m_id)
                    lowest_available_id = note.m_id;
            }
        }
    
        private void apply_setNotes(Dictionary<int, int> orphan_subs, NoteCollection m_notes, List<CMapNoteAsset> copy_notes)
        {
            List<CMapNoteAsset> notes = m_notes.m_notes.ToList();
            Dictionary<int, int> new_sub_ids = new Dictionary<int, int>();

            #region Update note IDs
            foreach (CMapNoteAsset note in copy_notes)
            {
                if (!(note.m_type == CMapNoteAsset.Type.SUB && orphan_subs.ContainsKey(note.m_id)))
                {
                    switch (note.m_type)
                    {
                        case CMapNoteAsset.Type.HOLD:
                            note.m_id = ++lowest_available_id;
                            if (!new_sub_ids.ContainsKey(note.m_subId))
                                new_sub_ids.Add(note.m_subId, ++lowest_available_id);
                            note.m_subId = new_sub_ids[note.m_subId];
                            break;
                        case CMapNoteAsset.Type.SUB:
                            if (!new_sub_ids.ContainsKey(note.m_id))
                                new_sub_ids.Add(note.m_id, ++lowest_available_id);
                            note.m_id = new_sub_ids[note.m_id];
                            break;
                        default:
                            note.m_id = ++lowest_available_id;
                            break;
                    }
                }
            }
            #endregion

            #region Populate m_notes
            foreach (CMapNoteAsset note in copy_notes)
                if (!(note.m_type == CMapNoteAsset.Type.SUB && orphan_subs.ContainsKey(note.m_id)))
                {
                    note.m_time -= anchor;
                    note.m_time += destination_time;
                    notes.Add(note);
                }
            m_notes.m_notes = notes.ToArray();
            #endregion
        }
    }
}
