using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool
{
    /// <summary>
    /// A set of conditions determining what notes in a chart a ChartOperation will apply to
    /// </summary>
    struct ApplyRange
    {
        public bool EntireChart;
        public float StartTime;
        public float EndTime;
        
        public bool MainTrack;
        public bool LeftTrack;
        public bool RightTrack;

        public bool NormalNotes;
        public bool ChainNotes;
        public bool HoldNotes;

        public ApplyRange GetDefault()
        {
            return new ApplyRange()
            {
                EntireChart = MainTrack = LeftTrack = RightTrack = NormalNotes = ChainNotes = HoldNotes = true
            };
        }
    }
}
