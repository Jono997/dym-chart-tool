using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyMChartTool.Operations
{
    class SortOperation : ChartOperation
    {
        public override CMap apply(CMap chart)
        {
            Settings.SortByValue sort_by = Settings.SortBy;
            bool group_holds = Settings.GroupHoldAndSub;
            if (sort_by != Settings.SortByValue.None || group_holds)
            {
                SortNoteCollection(chart.m_notes, sort_by, group_holds);
                SortNoteCollection(chart.m_notesLeft, sort_by, group_holds);
                SortNoteCollection(chart.m_notesRight, sort_by, group_holds);
            }
            return chart;
        }

        private void SortNoteCollection(NoteCollection notes, Settings.SortByValue sort_by, bool group_holds)
        {
            Array.Sort(notes.m_notes, delegate (CMapNoteAsset a, CMapNoteAsset b)
            {
                switch (sort_by)
                {
                    case Settings.SortByValue.ID:
                        return a.m_id.CompareTo(b.m_id);
                    case Settings.SortByValue.Time:
                        return a.m_time.CompareTo(b.m_time);
                }
                return 0;
            });
        }
    }
}
