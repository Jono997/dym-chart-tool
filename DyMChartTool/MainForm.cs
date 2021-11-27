﻿using System;
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
            #region Deserialise chart
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
                    return;
                }
                catch (LoadFailedException)
                {
                    MessageBox.Show("The chart file could not be found", "Chart loading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;                 
                }
            }
            #endregion

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
                if (e.operation == MirrorOperation.Operation.SwapLeftAndRight && !e.entire_chart && chart.m_leftRegion != chart.m_rightRegion)
                {
                    MessageBox.Show("A side track swap can only be done on a time range if both sides are the same type");
                    return true;
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

        private void applyButton_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("This feature is not yet available. Please check back in a later version.");
        }
    }
}