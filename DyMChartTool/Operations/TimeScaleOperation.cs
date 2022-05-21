using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class TimeScaleOperation : ChartOperation
    {
        /// <summary>
        /// The amount to multiply note time by
        /// </summary>
        public float scale { get; private set; }

        /// <summary>
        /// Whether or not the length of hold notes should be scaled as well
        /// </summary>
        public bool scale_hold_lengths { get; private set; }

        public TimeScaleOperation(float scale, bool scale_hold_lengths, bool main_track, bool left_track, bool right_track)
        {
            entire_chart = true;
            this.scale = scale;
            this.scale_hold_lengths = scale_hold_lengths;
            setTrackFlags(main_track, left_track, right_track);
        }

        public TimeScaleOperation(float start_time, float end_time, float scale, bool scale_hold_lengths, bool main_track, bool left_track, bool right_track)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.scale = scale;
            this.scale_hold_lengths = scale_hold_lengths;
            setTrackFlags(main_track, left_track, right_track);
        }

        public override CMap apply(CMap chart)
        {
            if ((track_flags & MainTrackFlag) > 0)
                chart.m_notes = scaleNotes(chart.m_notes);
            if ((track_flags & LeftTrackFlag) > 0)
                chart.m_notesLeft = scaleNotes(chart.m_notesLeft);
            if ((track_flags & RightTrackFlag) > 0)
                chart.m_notesRight = scaleNotes(chart.m_notesRight);
            return chart;
        }

        private NoteCollection scaleNotes(NoteCollection m_notes)
        {
            List<Note> notes = NoteCollectionToNoteList(m_notes);
            float anchor = entire_chart ? 0f : start_time;
            foreach (int i in getApplyRange(notes, false, false))
            {
                notes[i].time = (notes[i].time - anchor) * scale + anchor;
                if (scale_hold_lengths)
                    notes[i].length *= scale;
            }
            return NoteListToNoteCollection(notes);
        }

        public override string ToString()
        {
            return $"Stretch {durationToString()} by {scale}x" + (scale_hold_lengths ? " with hold stretching" : "");
        }
    }
}
