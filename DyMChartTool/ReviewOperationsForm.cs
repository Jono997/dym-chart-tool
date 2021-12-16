using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using DyMChartTool.Operations;

namespace DyMChartTool
{
    internal partial class ReviewOperationsForm : Form
    {
        CMap chart;
        List<ChartOperation> operations;
        string output_file;

        internal ReviewOperationsForm(CMap chart, List<ChartOperation> operations, string output_file)
        {
            InitializeComponent();
            this.chart = chart;
            this.operations = operations;
            this.output_file = output_file;
            refreshListBox();
            applyButton.Enabled = MainForm.ValidPath(output_file);
        }

        private void refreshListBox()
        {
            operationsListBox.Items.Clear();
            operationsListBox.Items.AddRange(operations.ToArray());
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            foreach (ChartOperation op in operations)
            {
                chart = op.apply(chart);
            }

            #region Sort notes
            if (Settings.SortBy != Settings.SortByValue.None || Settings.GroupHoldAndSub)
            {
                Settings.SortByValue sort_by = Settings.SortBy;
                bool group_holds = Settings.GroupHoldAndSub;
                SortNoteCollection(chart.m_notes, sort_by, group_holds);
                SortNoteCollection(chart.m_notesLeft, sort_by, group_holds);
                SortNoteCollection(chart.m_notesRight, sort_by, group_holds);
            }
            #endregion

            chart.Serialise(output_file);
            if (Settings.KeepOpenAfterApply)
                operations.Clear();
            else
                DialogResult = DialogResult.OK;
            Close();
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

        private void editSelectedOperation(object sender, EventArgs e)
        {
            int current_operation = operationsListBox.SelectedIndex;
            if (current_operation >= 0 && current_operation < operations.Count)
            {
                EditOperationForm editOperationForm = new EditOperationForm(operations[current_operation]);
                if (editOperationForm.ShowDialog() == DialogResult.OK)
                {
                    operations[current_operation] = editOperationForm.operation;
                    refreshListBox();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int current_operation = operationsListBox.SelectedIndex;
            if (current_operation >= 0 && current_operation < operations.Count)
            {
                operations.RemoveAt(current_operation);
                refreshListBox();
            }
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int current_operation = operationsListBox.SelectedIndex;
            if (current_operation > 0 && current_operation < operations.Count)
            {
                ChartOperation operation = operations[current_operation];
                operations.RemoveAt(current_operation);
                operations.Insert(current_operation - 1, operation);
                refreshListBox();
                operationsListBox.SelectedIndex = current_operation - 1;
            }
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int current_operation = operationsListBox.SelectedIndex;
            if (current_operation >= 0 && current_operation < operations.Count - 1)
            {
                ChartOperation operation = operations[current_operation];
                operations.RemoveAt(current_operation);
                operations.Insert(current_operation + 1, operation);
                refreshListBox();
                operationsListBox.SelectedIndex = current_operation + 1;
            }
        }
    }
}
