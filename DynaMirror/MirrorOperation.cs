using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaMirror
{
    class MirrorOperation : ChartOperation
    {
        /// <summary>
        /// If true, this operation applies to the entire chart.<br />
        /// If false, this operation applies to notes in-between range_start and range_end
        /// </summary>
        public bool entire_chart { get; private set; }

        public float start_time { get; private set; }

        public float end_time { get; private set; }

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
            string retVal = "Mirror ";
            retVal += (entire_chart ? "Whole chart" : start_time.ToString() + " to " + end_time.ToString());
            retVal += ": ";
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
            // Side:   -0.2 - 6.1 Pivot point: 2.95?
            switch (operation)
            {
                case Operation.MirrorBottom:
                    chart.m_notes = mirrorNotes(chart.m_notes, 2f);
                    break;
                case Operation.MirrorLeft:
                    chart.m_notesLeft = mirrorNotes(chart.m_notesLeft, 2.5f);
                    break;
                case Operation.MirrorRight:
                    chart.m_notesRight = mirrorNotes(chart.m_notesRight, 2.5f);
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
                        List<int> left_notes = getApplyRange(chart.m_notesLeft);
                        List<int> right_notes = getApplyRange(chart.m_notesRight);

                    }
                    break;
            }
            return chart;
        }

        private List<int> getApplyRange(NoteCollection notes)
        {
            List<int> applyTo = new List<int>();
            if (entire_chart)
                for (int i = 0; i < notes.m_notes.Length; i++)
                    applyTo.Add(i);
            else
                for (int i = 0; i < notes.m_notes.Length; i++)
                {
                    float time = notes.m_notes[i].m_time;
                    if (time >= start_time && time <= end_time)
                        applyTo.Add(i);
                }
            return applyTo;
        }

        private NoteCollection mirrorNotes(NoteCollection notes, float mirror_point)
        {
            List<int> applyTo = getApplyRange(notes);
            foreach (int i in applyTo)
                notes.m_notes[i].m_position = ((notes.m_notes[i].m_position - mirror_point) * -1) + mirror_point;
            return notes;
        }
    }
}
