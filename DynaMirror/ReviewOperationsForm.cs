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

namespace DynaMirror
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
            operationsListBox.Items.AddRange(operations.ToArray());
            applyButton.Enabled = MainForm.ValidPath(output_file);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            // Bottom: -0.3 - 5.3 Pivot point: 2.5
            // Side:   -0.2 - 6.1 Pivot point: 2.95?
            foreach (ChartOperation op in operations)
            {
                switch (op.operation)
                {
                    case ChartOperation.Operation.MirrorBottom:
                        List<int> applyTo = getApplyRange(chart.m_notes, op);
                        foreach (int i in applyTo)
                            chart.m_notes.m_notes[i].m_position = (chart.m_notes.m_notes[i].m_position - 2.5f) * -1 + 2.5f;
                        break;
                    case ChartOperation.Operation.MirrorLeft:
                        chart.m_notes = mirrorSideNotes(chart.m_notesLeft, op);
                        break;
                    case ChartOperation.Operation.MirrorRight:
                        chart.m_notes = mirrorSideNotes(chart.m_notesRight, op);
                        break;
                    case ChartOperation.Operation.SwapLeftAndRight:
                        if (op.entire_chart)
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
                            List<int> left_notes = getApplyRange(chart.m_notesLeft, op);
                            List<int> right_notes = getApplyRange(chart.m_notesRight, op);

                        }
                        break;
                }
            }

            XmlSerializer serialiser = new XmlSerializer(chart.GetType());
            FileStream output_stream = new FileStream(output_file, FileMode.Create);
            serialiser.Serialize(output_stream, chart);
            output_stream.Close();
            DialogResult = DialogResult.OK;
            Close();
        }

        private List<int> getApplyRange(NoteCollection notes, ChartOperation op)
        {
            List<int> applyTo = new List<int>();
            if (op.entire_chart)
                for (int i = 0; i < notes.m_notes.Length; i++)
                    applyTo.Add(i);
            else
                for (int i = 0; i < notes.m_notes.Length; i++)
                {
                    float time = notes.m_notes[i].m_time;
                    if (time >= op.start_time && time <= op.end_time)
                        applyTo.Add(i);
                }
            return applyTo;
        }

        private NoteCollection mirrorSideNotes(NoteCollection notes, ChartOperation op)
        {
            List<int> applyTo = getApplyRange(notes, op);
            foreach (int i in applyTo)
                notes.m_notes[i].m_position = (notes.m_notes[i].m_position - 3f) * -1 + 3f;
            return notes;
        }
    }
}
