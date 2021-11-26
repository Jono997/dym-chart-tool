using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class MirrorOperation : ChartOperation
    {

        /// <summary>
        /// The operations that can be done to the chart.<br />
        /// MirrorBottom: Mirrors notes on the bottom track<br />
        /// MirrorLeft: Mirrors notes on the left track<br />
        /// MirrorRight: Mirrors notes on the right track<br />
        /// SwapLeftAndRight: Switches the left and right tracks. Can only be done if entire_chart is true or both charts are the same type.
        /// </summary>
        public enum Operation
        {
            MirrorBottom,
            MirrorLeft,
            MirrorRight,
            SwapLeftAndRight
        }

        public Operation operation { get; private set; }

        public MirrorOperation(Operation operation)
        {
            entire_chart = true;
            start_time = end_time = 0;
            this.operation = operation;
        }

        public MirrorOperation(float start_time, float end_time, Operation operation)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.operation = operation;
        }

        public override string ToString()
        {
            string retVal = $"Mirror {durationToString()}: ";
            switch (operation)
            {
                case Operation.MirrorBottom:
                    retVal += "Mirror bottom track";
                    break;
                case Operation.MirrorLeft:
                    retVal += "Mirror left track";
                    break;
                case Operation.MirrorRight:
                    retVal += "Mirror right track";
                    break;
                case Operation.SwapLeftAndRight:
                    retVal += "Swap side tracks";
                    break;
            }
            return retVal;
        }

        public override CMap apply(CMap chart)
        {
            // Bottom: -0.3 - 5.3 Pivot point: 2.5
            // Side:   -0.2 - 6.1 Pivot point: 2.95
            switch (operation)
            {
                case Operation.MirrorBottom:
                    chart.m_notes = mirrorNotes(chart.m_notes, 2.5f);
                    break;
                case Operation.MirrorLeft:
                    chart.m_notesLeft = mirrorNotes(chart.m_notesLeft, 2.95f);
                    break;
                case Operation.MirrorRight:
                    chart.m_notesRight = mirrorNotes(chart.m_notesRight, 2.95f);
                    break;
                case Operation.SwapLeftAndRight:
                    if (entire_chart)
                    {
                        CMap.RegionType left_region_type = chart.m_leftRegion;
                        NoteCollection left_region_notes = chart.m_notesLeft;
                        chart.m_leftRegion = chart.m_rightRegion;
                        chart.m_notesLeft = chart.m_notesRight;
                        chart.m_rightRegion = left_region_type;
                        chart.m_notesRight = left_region_notes;
                    }
                    else
                    {
                        swapTracks(chart);
                    }
                    break;
            }
            return chart;
        }

        private NoteCollection mirrorNotes(NoteCollection notes, float mirror_point)
        {
            List<int> applyTo = getApplyRange(notes);
            foreach (int i in applyTo)
            {
                float half_width = notes.m_notes[i].m_width / 2;
                notes.m_notes[i].m_position = ((notes.m_notes[i].m_position - mirror_point + half_width) * -1) + mirror_point - half_width;
            }
            return notes;
        }

        private void swapTracks(CMap chart)
        {
            #region Old version
            //List<CMapNoteAsset> left = chart.m_notesLeft.m_notes.ToList();
            //List<CMapNoteAsset> right = chart.m_notesRight.m_notes.ToList();
            //List<int> apply_left = getApplyRange(chart.m_notesLeft);
            //List<int> apply_right = getApplyRange(chart.m_notesRight);

            //int id_left = 0;
            //int id_right = 0;
            //foreach (CMapNoteAsset note in left)
            //    if (id_left < note.m_id)
            //        id_left = note.m_id;
            //foreach (CMapNoteAsset note in right)
            //    if (id_right < note.m_id)
            //        id_right = note.m_id;

            //List<CMapNoteAsset> left_reserve = new List<CMapNoteAsset>();
            //for (int _i = apply_left.Count - 1; _i >= 0; _i--)
            //{
            //    int i = apply_left[_i];
            //    left_reserve.Add(left[i]);
            //    left.RemoveAt(i);
            //}

            //for (int _i = apply_right.Count - 1; _i >= 0; _i--)
            //{
            //    int i = apply_right[_i];
            //    CMapNoteAsset note = right[i];
            //    right.RemoveAt(i);
            //    note.m_id = ++id_left;
            //    left.Add(note);
            //}
            //foreach (CMapNoteAsset note in left_reserve)
            //{
            //    note.m_id = ++id_right;
            //    right.Add(note);
            //}

            //chart.m_notesLeft.m_notes = left.ToArray();
            //chart.m_notesRight.m_notes = right.ToArray();
            #endregion

            List<Note> left = NoteCollectionToNoteList(chart.m_notesLeft);
            List<Note> right = NoteCollectionToNoteList(chart.m_notesRight);
            List<int> apply_left = getApplyRange(left);
            List<int> apply_right = getApplyRange(right);

            List<Note> holding = new List<Note>();
            for (int _ = apply_left.Count - 1; _ >= 0; _--)
            {
                int i = apply_left[_];
                holding.Add(left[i]);
                left.RemoveAt(i);
            }
            for (int _ = apply_right.Count - 1; _ >= 0; _--)
            {
                int i = apply_right[_];
                left.Add(right[i]);
                right.RemoveAt(i);
            }
            foreach (Note note in holding)
                right.Add(note);

            chart.m_notesLeft = NoteListToNoteCollection(left);
            chart.m_notesRight = NoteListToNoteCollection(right);
        }
    }
}
