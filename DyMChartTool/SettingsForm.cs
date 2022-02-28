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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            closeAfterApplyCheckBox.Checked = !Settings.KeepOpenAfterApply;
            singleEditModeCheckBox.Checked = Settings.SingleEditMode;
            illegalOperationCheckBox.Checked = Settings.IllegalOperations;
            switch (Settings.SortBy)
            {
                case Settings.SortByValue.None:
                    sortByNoneRadioButton.Checked = true;
                    break;
                case Settings.SortByValue.Type:
                    sortByTypeRadioButton.Checked = true;
                    break;
                case Settings.SortByValue.Time:
                    sortByTimeRadioButton.Checked = true;
                    break;
                case Settings.SortByValue.ID:
                    sortByIDRadioButton.Checked = true;
                    break;
            }
            groupHoldAndSubCheckBox.Checked = Settings.GroupHoldAndSub;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.KeepOpenAfterApply = !closeAfterApplyCheckBox.Checked;
            Settings.SingleEditMode = singleEditModeCheckBox.Checked;
            Settings.IllegalOperations = illegalOperationCheckBox.Checked;
            
            Settings.SortByValue sortBy = Settings.SortByValue.None;
            if (sortByTimeRadioButton.Checked)
                sortBy = Settings.SortByValue.Time;
            else if (sortByTypeRadioButton.Checked)
                sortBy = Settings.SortByValue.Type;
            else if (sortByIDRadioButton.Checked)
                sortBy = Settings.SortByValue.ID;
            Settings.SortBy = sortBy;

            Settings.GroupHoldAndSub = groupHoldAndSubCheckBox.Checked;
            Close();
        }
    }
}
