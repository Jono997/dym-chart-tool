using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class ReplaceOperation : ChartOperation
    {
        public CMapNoteAsset.Type type { get; private set; }

        public ReplaceOperation(CMapNoteAsset.Type type, bool main, bool left, bool right)
        {
            entire_chart = true;
            this.type = type;
            setTrackFlags(main, left, right);
        }

        public ReplaceOperation(CMapNoteAsset.Type type) : this(type, true, false, false) { }

        public ReplaceOperation(float start_time, float end_time, CMapNoteAsset.Type type, bool main, bool left, bool right)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.type = type;
            setTrackFlags(main, left, right);
        }

        public ReplaceOperation(float start_time, float end_time, CMapNoteAsset.Type type) : this(start_time, end_time, type, true, false, false) { }

        public override CMap apply(CMap chart)
        {
            if ((track_flags & MainTrackFlag) > 0)
                chart.m_notes = applyOnTrack(chart.m_notes);
            if ((track_flags & LeftTrackFlag) > 0)
                chart.m_notes = applyOnTrack(chart.m_notesLeft);
            if ((track_flags & RightTrackFlag) > 0)
                chart.m_notes = applyOnTrack(chart.m_notesRight);
            return chart;
        }

        private NoteCollection applyOnTrack(NoteCollection notes)
        {
            List<int> apply_to = getApplyRange(notes);
            foreach (int i in apply_to)
            {
                CMapNoteAsset note = notes.m_notes[i];
                if (note.m_type == CMapNoteAsset.Type.NORMAL || note.m_type == CMapNoteAsset.Type.CHAIN)
                    note.m_type = type;
            }
            return notes;
        }

        public override string ToString()
        {
            return $"Replace {durationToString()} to {(type == CMapNoteAsset.Type.NORMAL ? "Normal" : "Chain")}";
        }
    }
}
