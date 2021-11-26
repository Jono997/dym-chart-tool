
namespace DyMChartTool
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.kofiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DyM Chart Tool v0.10.0\r\nProgram by Jono99 with direction from Jmak and TehLightni" +
    "ngChicken";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(13, 54);
            this.githubLinkLabel.Location = new System.Drawing.Point(13, 39);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(284, 17);
            this.githubLinkLabel.TabIndex = 1;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "Github page: https://github.com/Jono997/dym-chart-tool";
            this.githubLinkLabel.UseCompatibleTextRendering = true;
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLinkLabel_LinkClicked);
            // 
            // kofiLinkLabel
            // 
            this.kofiLinkLabel.AutoSize = true;
            this.kofiLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(30, 54);
            this.kofiLinkLabel.Location = new System.Drawing.Point(12, 56);
            this.kofiLinkLabel.Name = "kofiLinkLabel";
            this.kofiLinkLabel.Size = new System.Drawing.Size(277, 17);
            this.kofiLinkLabel.TabIndex = 2;
            this.kofiLinkLabel.TabStop = true;
            this.kofiLinkLabel.Text = "Jono99 donation page (Ko-Fi): https://ko-fi.com/jono99";
            this.kofiLinkLabel.UseCompatibleTextRendering = true;
            this.kofiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kofiLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 85);
            this.Controls.Add(this.kofiLinkLabel);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About DyM Chart Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.LinkLabel kofiLinkLabel;
    }
}