using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class TimeShiftOperation : ChartOperation
    {
        /// <summary>
        /// The amount of time to shift the notes by
        /// </summary>
        public float shift_duration { get; private set; }

        public TimeShiftOperation(float shift_duration, bool main_track, bool left_track, bool right_track)
        {
            entire_chart = true;
            this.shift_duration = shift_duration;
            setTrackFlags(main_track, left_track, right_track);
        }

        public TimeShiftOperation(float start_time, float end_time, float shift_duration, bool main_track, bool left_track, bool right_track)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            setTrackFlags(main_track, left_track, right_track);
        }

        public override CMap apply(CMap chart)
        {
            if ((track_flags & MainTrackFlag) > 0)
                chart.m_notes = shiftNotes(chart.m_notes);
            if ((track_flags & LeftTrackFlag) > 0)
                chart.m_notesLeft = shiftNotes(chart.m_notesLeft);
            if ((track_flags & RightTrackFlag) > 0)
                chart.m_notesRight = shiftNotes(chart.m_notesRight);
            return chart;
        }

        private NoteCollection shiftNotes(NoteCollection notes)
        {
            foreach (int i in getApplyRange(notes, false, false))
                notes.m_notes[i].m_time += shift_duration;
            return notes;
        }

        public override string ToString()
        {
            return $"Move {durationToString()} {shift_duration} beats";
        }
    }
}
