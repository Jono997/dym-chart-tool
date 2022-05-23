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
    public partial class ARCTest : Form
    {
        public ARCTest()
        {
            InitializeComponent();
        }

        private void ForceChanged(object sender, EventArgs e)
        {
            if (entireChartUnforced.Checked)
                arc.forceEntireChart = null;
            else if (entireChartTrue.Checked)
                arc.forceEntireChart = true;
            else
                arc.forceEntireChart = false;

            if (mainUnforced.Checked)
                arc.forceMainTrack = null;
            else if (mainTrue.Checked)
                arc.forceMainTrack = true;
            else
                arc.forceMainTrack = false;

            if (leftUnforced.Checked)
                arc.forceLeftTrack = null;
            else if (leftTrue.Checked)
                arc.forceLeftTrack = true;
            else
                arc.forceLeftTrack = false;

            if (rightUnforced.Checked)
                arc.forceRightTrack = null;
            else if (rightTrue.Checked)
                arc.forceRightTrack = true;
            else
                arc.forceRightTrack = false;

            if (normalUnforced.Checked)
                arc.forceNormalNotes = null;
            else if (normalTrue.Checked)
                arc.forceNormalNotes = true;
            else
                arc.forceNormalNotes = false;

            if (holdUnforced.Checked)
                arc.forceHoldNotes = null;
            else if (holdTrue.Checked)
                arc.forceHoldNotes = true;
            else
                arc.forceHoldNotes = false;

            if (chainUnforced.Checked)
                arc.forceChainNotes = null;
            else if (chainTrue.Checked)
                arc.forceChainNotes = true;
            else
                arc.forceChainNotes = false;

            if (forceStart.Checked)
                arc.forceStartTime = (float)startTime.Value;
            else
                arc.forceStartTime = null;

            if (forceEnd.Checked)
                arc.forceEndTime = (float)endTime.Value;
            else
                arc.forceEndTime = null;

            arc.UpdateControlState();
        }
    }
}
