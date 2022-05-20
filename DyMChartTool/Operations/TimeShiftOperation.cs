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
        /// The start point of the paste
        /// </summary>
        public float destination_time { get; private set; }

        /// <summary>
        /// If true, destination_time will be treated as if it were the start_time of the destination.<br />
        /// If false, destination_time will be treated as the time of the first note of the destination.
        /// </summary>
        public bool start_from_start { get; private set; }

        public TimeShiftOperation(float destination_time, bool start_from_start, bool main_track, bool left_track, bool right_track)
        {
            entire_chart = true;
            this.destination_time = destination_time;
            this.start_from_start = start_from_start;
            setTrackFlags(main_track, left_track, right_track);
        }

        public TimeShiftOperation(float start_time, float end_time, float destination_time, bool start_from_start, bool main_track, bool left_track, bool right_track)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.destination_time = destination_time;
            this.start_from_start = start_from_start;
            setTrackFlags(main_track, left_track, right_track);
        }

        public override CMap apply(CMap chart)
        {
            float anchor = start_from_start ? destination_time : -1f;
            List<Note>[] notes = new List<Note>[3];
            List<int>[] apply_ranges = new List<int>[3];

            if ((track_flags & MainTrackFlag) > 0)
                notes[0] = NoteCollectionToNoteList(chart.m_notes);
            if ((track_flags & LeftTrackFlag) > 0)
                notes[1] = NoteCollectionToNoteList(chart.m_notesLeft);
            if ((track_flags & RightTrackFlag) > 0)
                notes[2] = NoteCollectionToNoteList(chart.m_notesRight);

            for (int i = 0; i < notes.Length; i++)
                if (notes[i] != null)
                {
                    apply_ranges[i] = getApplyRange(notes[i]);
                    if (!start_from_start)
                        foreach (int ni in apply_ranges[i])
                            if (anchor == -1f || anchor > notes[i][ni].time)
                                anchor = notes[i][ni].time;
                }

            for (int i = 0; i < notes.Length; i++)
                if (notes[i] != null)
                    foreach (int ni in apply_ranges[i])
                        notes[i][ni].time = notes[i][ni].time - anchor + destination_time;

            if ((track_flags & MainTrackFlag) > 0)
                chart.m_notes = NoteListToNoteCollection(notes[0]);
            if ((track_flags & LeftTrackFlag) > 0)
                chart.m_notesLeft = NoteListToNoteCollection(notes[1]);
            if ((track_flags & RightTrackFlag) > 0)
                chart.m_notesRight = NoteListToNoteCollection(notes[2]);
            return chart;
        }

        public override string ToString()
        {
            return $"Move {durationToString()} to {destination_time}";
        }
    }
}
