
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DyMChartTool.Operations;

namespace DyMChartTool
{
    public partial class EditOperationControl : UserControl
    {
        internal ChartOperation operation;

        internal event OperationMadeEventHandler OperationMade;

        public EditOperationControl()
        {
            operation = null;
            InitializeComponent();
            
            // Setup UI
            EditOperationControl_Resize(null, null);
            replaceTab.Controls.Remove(ReplaceTimePlaceholderGroupBox);
            deleteTab.Controls.Remove(deleteTimePlaceholderGroupBox);
            Update_UI();
        }

        internal void Init(ChartOperation operation)
        {
            this.operation = operation;
            #region Setup UI
            if (operation != null)
            {
                Type op_type = operation.GetType();
                if (op_type == typeof(MirrorOperation))
                {
                    MirrorOperation op = (MirrorOperation)operation;
                    if (!op.entire_chart)
                    {
                        durationEntireChartRadioButton.Checked = false;
                        durationTimeRangeRadioButton.Checked = true;
                        timeRangeStartNumericUpDown.Value = Convert.ToDecimal(op.start_time);
                        timeRangeEndNumericUpDown.Value = Convert.ToDecimal(op.end_time);
                    }
                }
                else if (op_type == typeof(CopyOperation))
                {
                    CopyOperation op = (CopyOperation)operation;
                    tabControl.SelectedIndex = 1;
                    copyRangeStartNumericUpDown.Value = Convert.ToDecimal(op.start_time);
                    copyRangeEndNumericUpDown.Value = Convert.ToDecimal(op.end_time);
                    copyMainTrackCheckBox.Checked = (op.track_flags & CopyOperation.MainTrackFlag) > 0;
                    copyLeftTrackCheckBox.Checked = (op.track_flags & CopyOperation.LeftTrackFlag) > 0;
                    copyRightTrackCheckBox.Checked = (op.track_flags & CopyOperation.RightTrackFlag) > 0;
                    copyDestinationTimeNumericUpDown.Value = Convert.ToDecimal(op.destination_time);
                    copyFromOtherFileRadioButton.Checked = op.source_path != null;
                    otherFileTextBox.Text = op.source_path;
                }
                else if (op_type == typeof(ReplaceOperation))
                {
                    ReplaceOperation op = (ReplaceOperation)operation;
                    tabControl.SelectedIndex = 2;
                    replaceSlideRadioButton.Checked = op.type == CMapNoteAsset.Type.CHAIN;
                    replaceOnMainCheckBox.Checked = (op.track_flags & ChartOperation.MainTrackFlag) > 0;
                    replaceOnLeftCheckBox.Checked = (op.track_flags & ChartOperation.LeftTrackFlag) > 0;
                    replaceOnRightCheckBox.Checked = (op.track_flags & ChartOperation.RightTrackFlag) > 0;
                }
            }
            #endregion
        }

        public void Update_UI()
        {
            replaceOnLeftCheckBox.Enabled = replaceOnRightCheckBox.Enabled = Settings.IllegalOperations;
        }

        public void Clear_TimeRange()
        {
            timeRangeStartNumericUpDown.Value = timeRangeEndNumericUpDown.Value = copyRangeStartNumericUpDown.Value = copyRangeEndNumericUpDown.Value = copyDestinationTimeNumericUpDown.Value = 0;
        }

        private void buildMirrorOperation(MirrorOperation.Operation operation)
        {
            if (durationEntireChartRadioButton.Checked)
                this.operation = new MirrorOperation(operation);
            else
                this.operation = new MirrorOperation((float)timeRangeStartNumericUpDown.Value, (float)timeRangeEndNumericUpDown.Value, operation);
            OperationMadeEventHandler handler = OperationMade;
            if (handler != null)
                handler(this, this.operation);
        }

        internal delegate void OperationMadeEventHandler(EditOperationControl sender, ChartOperation operation);

        private void mirrorBottomButton_Click(object sender, EventArgs e)
        {
            buildMirrorOperation(MirrorOperation.Operation.MirrorBottom);
        }

        private void mirrorLeftButton_Click(object sender, EventArgs e)
        {
            buildMirrorOperation(MirrorOperation.Operation.MirrorLeft);
        }

        private void mirrorRightButton_Click(object sender, EventArgs e)
        {
            buildMirrorOperation(MirrorOperation.Operation.MirrorRight);
        }

        private void swapSidesButton_Click(object sender, EventArgs e)
        {
            buildMirrorOperation(MirrorOperation.Operation.SwapLeftAndRight);
        }

        private void durationEntireChartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            swapSidesButton.Enabled = true;// durationEntireChartRadioButton.Checked;
        }

        private void EditOperationControl_Resize(object sender, EventArgs e)
        {
            #region Resize copy groupboxes
            int groupbox_width = (CopyTab.Width - 24) / 2;
            copySourceGroupBox.Width = copyDestinationGroupBox.Width = groupbox_width;
            copyDestinationGroupBox.Left = groupbox_width + 12;
            #endregion
        }

        private void applyCopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                operation = new CopyOperation((float)copyRangeStartNumericUpDown.Value, (float)copyRangeEndNumericUpDown.Value, (float)copyDestinationTimeNumericUpDown.Value,
                                              copyMainTrackCheckBox.Checked, copyLeftTrackCheckBox.Checked, copyRightTrackCheckBox.Checked, CopyDestinationAsStartTimeRadioButton.Checked,
                                              copyFromOtherFileRadioButton.Checked ? otherFileTextBox.Text : null);
                OperationMadeEventHandler handler = OperationMade;
                if (handler != null)
                    handler(this, this.operation);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("The file provided is not a valid chart file", "Chart parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (LoadFailedException)
            {
                MessageBox.Show("The chart file could not be found", "Chart loading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void otherFileBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                otherFileTextBox.Text = openFileDialog1.FileName;
        }

        private void copyFromOtherFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            otherFileTextBox.Enabled = otherFileBrowseButton.Enabled = copyFromOtherFileRadioButton.Checked;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1)
                tabControl.SelectedTab.Controls.Add(durationGroupBox);
        }

        private void applyReplaceButton_Click(object sender, EventArgs e)
        {
            CMapNoteAsset.Type type = replaceTapRadioButton.Checked ? CMapNoteAsset.Type.NORMAL : CMapNoteAsset.Type.CHAIN;
            if (durationEntireChartRadioButton.Checked)
                operation = new ReplaceOperation(type, replaceOnMainCheckBox.Checked, replaceOnLeftCheckBox.Checked, replaceOnRightCheckBox.Checked);
            else
                operation = new ReplaceOperation((float)timeRangeStartNumericUpDown.Value, (float)timeRangeEndNumericUpDown.Value, type, replaceOnMainCheckBox.Checked, replaceOnLeftCheckBox.Checked, replaceOnRightCheckBox.Checked);
            OperationMadeEventHandler handler = OperationMade;
            if (handler != null)
                handler(this, operation);
        }

        private void durationTimeRangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            timeRangeStartNumericUpDown.Enabled = timeRangeEndNumericUpDown.Enabled = durationTimeRangeRadioButton.Checked;
        }
    }
}
