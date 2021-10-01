using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaMirror
{
    class ChartOperation
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

        public ChartOperation(Operation operation)
        {
            entire_chart = true;
            start_time = end_time = 0;
            this.operation = operation;
        }

        public ChartOperation(float start_time, float end_time, Operation operation)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.operation = operation;
        }

        public override string ToString()
        {
            string retVal = (entire_chart ? "Whole chart" : start_time.ToString() + " to " + end_time.ToString());
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
    }
}
