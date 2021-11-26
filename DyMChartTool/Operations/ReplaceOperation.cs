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

        public ReplaceOperation(CMapNoteAsset.Type type)
        {
            entire_chart = true;
            this.type = type;
        }

        public ReplaceOperation(float start_time, float end_time, CMapNoteAsset.Type type)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.type = type;
        }

        public override CMap apply(CMap chart)
        {
            List<int> apply_to = getApplyRange(chart.m_notes);
            foreach (int i in apply_to)
            {
                CMapNoteAsset note = chart.m_notes.m_notes[i];
                if (note.m_type == CMapNoteAsset.Type.NORMAL || note.m_type == CMapNoteAsset.Type.CHAIN)
                    note.m_type = type;
            }
            return chart;
        }

        public override string ToString()
        {
            return $"Replace {durationToString()} to {(type == CMapNoteAsset.Type.NORMAL ? "Normal" : "Chain")}";
        }
    }
}
