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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void visitSite(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            visitSite("https://github.com/jono997/dym-chart-tool");
        }

        private void kofiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            visitSite("https://ko-fi.com/jono99");
        }
    }
}
