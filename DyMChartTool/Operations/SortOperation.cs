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
            if (group_holds)
            {
                if (sort_by != Settings.SortByValue.None)
                {
                    SortNoteCollection(chart.m_notes, sort_by);
                    SortNoteCollection(chart.m_notesLeft, sort_by);
                    SortNoteCollection(chart.m_notesRight, sort_by);
                }
            }
            else
            {
                // Due to how NoteListToNoteCollection works, the output will automatically group HOLD and SUB notes together
                chart.m_notes = NoteListToNoteCollection(SortNoteList(NoteCollectionToNoteList(chart.m_notes), sort_by));
                chart.m_notesLeft = NoteListToNoteCollection(SortNoteList(NoteCollectionToNoteList(chart.m_notesLeft), sort_by));
                chart.m_notesRight = NoteListToNoteCollection(SortNoteList(NoteCollectionToNoteList(chart.m_notesRight), sort_by));
            }
            return chart;
        }

        private void SortNoteCollection(NoteCollection notes, Settings.SortByValue sort_by)
        {
            Array.Sort(notes.m_notes, delegate (CMapNoteAsset a, CMapNoteAsset b)
            {
                switch (sort_by)
                {
                    case Settings.SortByValue.ID:
                        return a.m_id.CompareTo(b.m_id);
                    case Settings.SortByValue.Time:
                        return a.m_time.CompareTo(b.m_time);
                    case Settings.SortByValue.Type:
                        return a.m_type.CompareTo(b.m_type);
                }
                return 0;
            });
        }

        private List<Note> SortNoteList(List<Note> notes, Settings.SortByValue sort_by)
        {
            notes.Sort(delegate (Note a, Note b)
            {
                switch (sort_by)
                {
                    case Settings.SortByValue.Time:
                        return a.time.CompareTo(b.time);
                    case Settings.SortByValue.Type:
                        return a.type.CompareTo(b.type);
                }
                return 0;
            });
            return notes;
        }
    }
}
