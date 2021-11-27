using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DyMChartTool.Operations;

namespace DyMChartTool
{
    public partial class MainForm : Form
    {
        private List<ChartOperation> operations;
        private CMap chart;

        public MainForm()
        {
            operations = new List<ChartOperation>();
            chart = null;
            InitializeComponent();
            editOperation.OperationMade += editOperation_OperationMade;
            Update_UI();
        }

        private void Update_UI()
        {
            editOperation.Update_UI();
        }

        private void fileInBrowseButton_Click(object sender, EventArgs e)
        {
            if (fileInBrowseDialog.ShowDialog() == DialogResult.OK)
                fileInTextBox.Text = fileInBrowseDialog.FileName;
        }

        private void fileOutBrowseButton_Click(object sender, EventArgs e)
        {
            if (fileOutBrowseDialog.ShowDialog() == DialogResult.OK)
                fileOutTextBox.Text = fileOutBrowseDialog.FileName;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            fileInTextBox.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void editOperation_OperationMade(EditOperationControl sender, ChartOperation e)
        {
            if (!hasErrors(e))
            {
                operations.Add(e);
                editAddedLabel.Visible = true;
                hideEditAddedTimer.Start();
                applyButton.Enabled = true;
            }
        }

        private bool hasErrors(ChartOperation op)
        {
            if (op is MirrorOperation)
            {
                MirrorOperation e = (MirrorOperation)op;
                if (e.operation == MirrorOperation.Operation.SwapLeftAndRight && !e.entire_chart && !Settings.IllegalOperations)
                {
                    if (!Deserialise_Chart())
                        return true;
                    if (chart.m_leftRegion != chart.m_rightRegion)
                    {
                        MessageBox.Show("A side track swap can only be done on a time range if both sides are the same type.\nIf you wish to do this anyway, please enable 'Allow illegal operations' in Settings.");
                        return true;
                    }
                }
            }
            return false;
        }

        private void hideEditAddedTimer_Tick(object sender, EventArgs e)
        {
            editAddedLabel.Visible = false;
            hideEditAddedTimer.Stop();
        }

        public static bool ValidPath(string path)
        {
            foreach (char invalid_char in Path.GetInvalidPathChars())
                if (path.Contains(invalid_char))
                    return false;
            try
            {
                return Directory.Exists(Path.GetDirectoryName(path));
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        private bool Deserialise_Chart()
        {
            if (chart == null)
            {
                try
                {
                    chart = CMap.Deserialise(fileInTextBox.Text);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("The file provided is not a valid chart file", "Chart parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chart = null;
                    return false;
                }
                catch (LoadFailedException)
                {
                    MessageBox.Show("The chart file could not be found", "Chart loading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (!Deserialise_Chart())
                return;

            if (ValidPath(fileOutTextBox.Text) || MessageBox.Show("The output file is invalid or has not been set. Please set one before applying edits.", "Invalid output path", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ReviewOperationsForm reviewOperationsForm = new ReviewOperationsForm(chart, operations, fileOutTextBox.Text);
                if (reviewOperationsForm.ShowDialog() == DialogResult.OK)
                    Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            Update_UI();
        }

        private void fileInTextBox_TextChanged(object sender, EventArgs e)
        {
            chart = null;
        }
    }
}
