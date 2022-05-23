using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyMChartTool
{
    public partial class ApplyRangeControl : UserControl
    {
        internal ApplyRange applyRange;

        /// <summary>
        /// applyRange, but with all values set by the user retained (any control forced restrictions are not written to this)
        /// </summary>
        private ApplyRange unforced_applyRange;

        public ApplyRangeControl()
        {
            applyRange = ApplyRange.GetDefault();
            unforced_applyRange = ApplyRange.GetDefault();
            InitializeComponent();
        }

        #region applyRange hooks
        private void entireChartRadoButton_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.EntireChart = entireChartRadoButton.Checked;
            if (entireChartRadoButton.Enabled)
                unforced_applyRange.EntireChart = entireChartRadoButton.Checked;

            timeRangeStartNumericUpDown.Enabled = timeRangeEndNumericUpDown.Enabled = !entireChartRadoButton.Checked;
        }

        private void timeRangeStartNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            applyRange.StartTime = (float)timeRangeStartNumericUpDown.Value;
            if (timeRangeStartNumericUpDown.Enabled)
                unforced_applyRange.StartTime = (float)timeRangeStartNumericUpDown.Value;
        }

        private void timeRangeEndNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            applyRange.EndTime = (float)timeRangeEndNumericUpDown.Value;
            if (timeRangeEndNumericUpDown.Enabled)
                unforced_applyRange.EndTime = (float)timeRangeEndNumericUpDown.Value;
        }

        private void mainTrackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.MainTrack = mainTrackCheckBox.Checked;
            if (mainTrackCheckBox.Enabled)
                unforced_applyRange.MainTrack = mainTrackCheckBox.Checked;
        }

        private void leftTrackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.LeftTrack = leftTrackCheckBox.Checked;
            if (leftTrackCheckBox.Enabled)
                unforced_applyRange.LeftTrack = leftTrackCheckBox.Checked;
        }

        private void rightTrackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.RightTrack = rightTrackCheckBox.Checked;
            if (rightTrackCheckBox.Enabled)
                unforced_applyRange.RightTrack = rightTrackCheckBox.Checked;
        }

        private void normalNoteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.NormalNotes = normalNoteCheckBox.Checked;
            if (normalNoteCheckBox.Enabled)
                unforced_applyRange.NormalNotes = normalNoteCheckBox.Checked;
        }

        private void holdNoteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.HoldNotes = holdNoteCheckBox.Checked;
            if (holdNoteCheckBox.Enabled)
                unforced_applyRange.HoldNotes = holdNoteCheckBox.Checked;
        }

        private void chainNoteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applyRange.ChainNotes = chainNoteCheckBox.Checked;
            if (chainNoteCheckBox.Enabled)
                unforced_applyRange.ChainNotes = chainNoteCheckBox.Checked;
        }
        #endregion

        public bool? forceEntireChart;
        public float? forceStartTime;
        public float? forceEndTime;

        public bool? forceMainTrack;
        public bool? forceLeftTrack;
        public bool? forceRightTrack;

        public bool? forceNormalNotes;
        public bool? forceHoldNotes;
        public bool? forceChainNotes;

        /// <summary>
        /// Update the enabledness and values of the buttons in correspondance with the force parameters
        /// </summary>
        public void UpdateControlState()
        {
            #region Time controls
            if (forceEntireChart.HasValue)
            {
                entireChartRadoButton.Enabled = false;
                timeRangeRadioButton.Enabled = false;
                if (forceEntireChart == true)
                    entireChartRadoButton.Checked = true;
                else
                {
                    timeRangeRadioButton.Checked = true;
                    if (forceStartTime.HasValue)
                    {
                        timeRangeStartNumericUpDown.Enabled = false;
                        timeRangeStartNumericUpDown.Value = (decimal)forceStartTime;
                    }
                    else
                    {
                        timeRangeStartNumericUpDown.Enabled = true;
                        timeRangeStartNumericUpDown.Value = (decimal)unforced_applyRange.StartTime;
                    }

                    if (forceEndTime.HasValue)
                    {
                        timeRangeEndNumericUpDown.Enabled = false;
                        timeRangeEndNumericUpDown.Value = (decimal)forceEndTime;
                    }
                    else
                    {
                        timeRangeEndNumericUpDown.Enabled = true;
                        timeRangeEndNumericUpDown.Value = (decimal)unforced_applyRange.EndTime;
                    }
                }
            }
            else
            {
                if (unforced_applyRange.EntireChart)
                    entireChartRadoButton.Checked = true;
                else
                    timeRangeRadioButton.Checked = true;
                timeRangeStartNumericUpDown.Value = (decimal)unforced_applyRange.StartTime;
                timeRangeEndNumericUpDown.Value = (decimal)unforced_applyRange.EndTime;
                entireChartRadoButton.Enabled = timeRangeRadioButton.Enabled = true;
            }
            #endregion

            mainTrackCheckBox.Enabled = !forceMainTrack.HasValue;
            if (forceMainTrack.HasValue)
                mainTrackCheckBox.Checked = forceMainTrack.Value;
            else
                mainTrackCheckBox.Checked = unforced_applyRange.MainTrack;

            leftTrackCheckBox.Enabled = !forceLeftTrack.HasValue;
            if (forceLeftTrack.HasValue)
                leftTrackCheckBox.Checked = forceLeftTrack.Value;
            else
                leftTrackCheckBox.Checked = unforced_applyRange.LeftTrack;

            rightTrackCheckBox.Enabled = !forceRightTrack.HasValue;
            if (forceRightTrack.HasValue)
                rightTrackCheckBox.Checked = forceRightTrack.Value;
            else
                rightTrackCheckBox.Checked = unforced_applyRange.RightTrack;

            normalNoteCheckBox.Enabled = !forceNormalNotes.HasValue;
            if (forceNormalNotes.HasValue)
                normalNoteCheckBox.Checked = forceNormalNotes.Value;
            else
                normalNoteCheckBox.Checked = unforced_applyRange.NormalNotes;

            holdNoteCheckBox.Enabled = !forceHoldNotes.HasValue;
            if (forceHoldNotes.HasValue)
                holdNoteCheckBox.Checked = forceHoldNotes.Value;
            else
                holdNoteCheckBox.Checked = unforced_applyRange.HoldNotes;

            chainNoteCheckBox.Enabled = !forceChainNotes.HasValue;
            if (forceChainNotes.HasValue)
                chainNoteCheckBox.Checked = forceChainNotes.Value;
            else
                chainNoteCheckBox.Checked = unforced_applyRange.ChainNotes;
        }
    }
}
