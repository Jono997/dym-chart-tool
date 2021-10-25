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
    public partial class EditOperationForm : Form
    {
        internal ChartOperation operation;

        internal EditOperationForm(ChartOperation operation)
        {
            this.operation = null;
            InitializeComponent();
            editOperationControl.Init(operation);
            editOperationControl.OperationMade += EditOperationControl_OperationMade;
        }

        private void EditOperationControl_OperationMade(EditOperationControl sender, ChartOperation operation)
        {
            this.operation = operation;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
