using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class DeleteOperation : ChartOperation
    {
        public bool main;
        public bool left;
        public bool right;
        public bool normal;
        public bool hold;
        public bool chain;

        public DeleteOperation(bool main, bool left, bool right, bool normal, bool hold, bool chain)
        {
            entire_chart = true;
            this.main = main;
            this.left = left;
            this.right = right;
            this.normal = normal;
            this.hold = hold;
            this.chain = chain;
        }

        public DeleteOperation(float start_time, float end_time, bool main, bool left, bool right, bool normal, bool hold, bool chain)
        {
            entire_chart = false;
            this.start_time = start_time;
            this.end_time = end_time;
            this.main = main;
            this.left = left;
            this.right = right;
            this.normal = normal;
            this.hold = hold;
            this.chain = chain;
        }

        public override CMap apply(CMap chart)
        {
            if (main)
                chart.m_notes = delete(chart.m_notes);
            if (left)
                chart.m_notesLeft = delete(chart.m_notesLeft);
            if (right)
                chart.m_notesRight = delete(chart.m_notesRight);
            return chart;
        }

        private NoteCollection delete(NoteCollection m_notes)
        {
            List<int> apply_range = getApplyRange(m_notes);
            List<CMapNoteAsset> notes = m_notes.m_notes.ToList();
            for (int _i = apply_range.Count - 1; _i >= 0; _i--)
            {
                int i = apply_range[_i];
                CMapNoteAsset note = notes[i];
                switch (note.m_type)
                {
                    case CMapNoteAsset.Type.NORMAL:
                        if (normal)
                            notes.RemoveAt(i);
                        break;
                    case CMapNoteAsset.Type.HOLD:
                        if (hold)
                            notes.RemoveAt(i);
                        break;
                    case CMapNoteAsset.Type.SUB:
                        if (hold)
                            notes.RemoveAt(i);
                        break;
                    case CMapNoteAsset.Type.CHAIN:
                        if (chain)
                            notes.RemoveAt(i);
                        break;
                }
            }
            return new NoteCollection()
            {
                m_notes = notes.ToArray()
            };
        }

        public override string ToString()
        {
            string retVal = $"Delete {durationToString()}";
            if (main)
                retVal += 'M';
            if (left)
                retVal += 'L';
            if (right)
                retVal += 'R';
            retVal += " - ";
            if (normal)
                retVal += 'N';
            if (hold)
                retVal += 'H';
            if (chain)
                retVal += 'C';
            return retVal;
        }
    }
}
