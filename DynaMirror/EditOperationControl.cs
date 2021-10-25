
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynaMirror
{
    public partial class EditOperationControl : UserControl
    {
        internal ChartOperation operation;

        internal event OperationMadeEventHandler OperationMade;

        public EditOperationControl()
        {
            operation = null;
            InitializeComponent();
            EditOperationControl_Resize(null, null);
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
                }
            }
            #endregion
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
            swapSidesButton.Enabled = durationEntireChartRadioButton.Checked;
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
            operation = new CopyOperation((float)copyRangeStartNumericUpDown.Value, (float)copyRangeEndNumericUpDown.Value, (float)copyDestinationTimeNumericUpDown.Value,
                                          copyMainTrackCheckBox.Checked, copyLeftTrackCheckBox.Checked, copyRightTrackCheckBox.Checked, CopyDestinationAsStartTimeRadioButton.Checked);
            OperationMadeEventHandler handler = OperationMade;
            if (handler != null)
                handler(this, this.operation);
        }
    }
}
