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
    public partial class EditOperation : UserControl
    {
        internal ChartOperation operation;

        internal event OperationMadeEventHandler OperationMade;

        public EditOperation()
        {
            operation = null;
            InitializeComponent();
        }

        private void buildOperation(ChartOperation.Operation operation)
        {
            if (durationEntireChartRadioButton.Checked)
                this.operation = new ChartOperation(operation);
            else
                this.operation = new ChartOperation((float)timeRangeStartNumericUpDown.Value, (float)timeRangeEndNumericUpDown.Value, operation);
            OperationMadeEventHandler handler = OperationMade;
            if (handler != null)
                handler(this, this.operation);
        }

        internal delegate void OperationMadeEventHandler(EditOperation sender, ChartOperation operation);

        private void mirrorBottomButton_Click(object sender, EventArgs e)
        {
            buildOperation(ChartOperation.Operation.MirrorBottom);
        }

        private void mirrorLeftButton_Click(object sender, EventArgs e)
        {
            buildOperation(ChartOperation.Operation.MirrorLeft);
        }

        private void mirrorRightButton_Click(object sender, EventArgs e)
        {
            buildOperation(ChartOperation.Operation.MirrorRight);
        }

        private void swapSidesButton_Click(object sender, EventArgs e)
        {
            buildOperation(ChartOperation.Operation.SwapLeftAndRight);
        }

        private void durationEntireChartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            swapSidesButton.Enabled = durationEntireChartRadioButton.Checked;
        }
    }
}
