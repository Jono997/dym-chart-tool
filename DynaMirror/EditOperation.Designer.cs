
namespace DynaMirror
{
    partial class EditOperation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.durationGroupBox = new System.Windows.Forms.GroupBox();
            this.timeRangeDividerLabel = new System.Windows.Forms.Label();
            this.timeRangeEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeRangeStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.durationTimeRangeRadioButton = new System.Windows.Forms.RadioButton();
            this.durationEntireChartRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mirrorBottomButton = new System.Windows.Forms.Button();
            this.mirrorLeftButton = new System.Windows.Forms.Button();
            this.mirrorRightButton = new System.Windows.Forms.Button();
            this.swapSidesButton = new System.Windows.Forms.Button();
            this.durationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeEndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeStartNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // durationGroupBox
            // 
            this.durationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durationGroupBox.Controls.Add(this.timeRangeDividerLabel);
            this.durationGroupBox.Controls.Add(this.timeRangeEndNumericUpDown);
            this.durationGroupBox.Controls.Add(this.timeRangeStartNumericUpDown);
            this.durationGroupBox.Controls.Add(this.durationTimeRangeRadioButton);
            this.durationGroupBox.Controls.Add(this.durationEntireChartRadioButton);
            this.durationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.durationGroupBox.Name = "durationGroupBox";
            this.durationGroupBox.Size = new System.Drawing.Size(776, 80);
            this.durationGroupBox.TabIndex = 0;
            this.durationGroupBox.TabStop = false;
            this.durationGroupBox.Text = "Apply to";
            // 
            // timeRangeDividerLabel
            // 
            this.timeRangeDividerLabel.AutoSize = true;
            this.timeRangeDividerLabel.Location = new System.Drawing.Point(163, 44);
            this.timeRangeDividerLabel.Name = "timeRangeDividerLabel";
            this.timeRangeDividerLabel.Size = new System.Drawing.Size(10, 13);
            this.timeRangeDividerLabel.TabIndex = 4;
            this.timeRangeDividerLabel.Text = "-";
            // 
            // timeRangeEndNumericUpDown
            // 
            this.timeRangeEndNumericUpDown.Location = new System.Drawing.Point(179, 42);
            this.timeRangeEndNumericUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.timeRangeEndNumericUpDown.Name = "timeRangeEndNumericUpDown";
            this.timeRangeEndNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.timeRangeEndNumericUpDown.TabIndex = 3;
            // 
            // timeRangeStartNumericUpDown
            // 
            this.timeRangeStartNumericUpDown.Location = new System.Drawing.Point(90, 42);
            this.timeRangeStartNumericUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.timeRangeStartNumericUpDown.Name = "timeRangeStartNumericUpDown";
            this.timeRangeStartNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.timeRangeStartNumericUpDown.TabIndex = 2;
            // 
            // durationTimeRangeRadioButton
            // 
            this.durationTimeRangeRadioButton.AutoSize = true;
            this.durationTimeRangeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.durationTimeRangeRadioButton.Name = "durationTimeRangeRadioButton";
            this.durationTimeRangeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.durationTimeRangeRadioButton.TabIndex = 1;
            this.durationTimeRangeRadioButton.Text = "Time range";
            this.durationTimeRangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // durationEntireChartRadioButton
            // 
            this.durationEntireChartRadioButton.AutoSize = true;
            this.durationEntireChartRadioButton.Checked = true;
            this.durationEntireChartRadioButton.Location = new System.Drawing.Point(6, 19);
            this.durationEntireChartRadioButton.Name = "durationEntireChartRadioButton";
            this.durationEntireChartRadioButton.Size = new System.Drawing.Size(79, 17);
            this.durationEntireChartRadioButton.TabIndex = 0;
            this.durationEntireChartRadioButton.TabStop = true;
            this.durationEntireChartRadioButton.Text = "Entire chart";
            this.durationEntireChartRadioButton.UseVisualStyleBackColor = true;
            this.durationEntireChartRadioButton.CheckedChanged += new System.EventHandler(this.durationEntireChartRadioButton_CheckedChanged);
            // 
            // mirrorBottomButton
            // 
            this.mirrorBottomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorBottomButton.Location = new System.Drawing.Point(0, 290);
            this.mirrorBottomButton.Name = "mirrorBottomButton";
            this.mirrorBottomButton.Size = new System.Drawing.Size(776, 33);
            this.mirrorBottomButton.TabIndex = 1;
            this.mirrorBottomButton.Text = "Mirror main track";
            this.mirrorBottomButton.UseVisualStyleBackColor = true;
            this.mirrorBottomButton.Click += new System.EventHandler(this.mirrorBottomButton_Click);
            // 
            // mirrorLeftButton
            // 
            this.mirrorLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mirrorLeftButton.Location = new System.Drawing.Point(0, 86);
            this.mirrorLeftButton.Name = "mirrorLeftButton";
            this.mirrorLeftButton.Size = new System.Drawing.Size(91, 198);
            this.mirrorLeftButton.TabIndex = 2;
            this.mirrorLeftButton.Text = "Mirror left track";
            this.mirrorLeftButton.UseVisualStyleBackColor = true;
            this.mirrorLeftButton.Click += new System.EventHandler(this.mirrorLeftButton_Click);
            // 
            // mirrorRightButton
            // 
            this.mirrorRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorRightButton.Location = new System.Drawing.Point(685, 86);
            this.mirrorRightButton.Name = "mirrorRightButton";
            this.mirrorRightButton.Size = new System.Drawing.Size(91, 198);
            this.mirrorRightButton.TabIndex = 3;
            this.mirrorRightButton.Text = "Mirror right track";
            this.mirrorRightButton.UseVisualStyleBackColor = true;
            this.mirrorRightButton.Click += new System.EventHandler(this.mirrorRightButton_Click);
            // 
            // swapSidesButton
            // 
            this.swapSidesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.swapSidesButton.Location = new System.Drawing.Point(97, 170);
            this.swapSidesButton.Name = "swapSidesButton";
            this.swapSidesButton.Size = new System.Drawing.Size(582, 31);
            this.swapSidesButton.TabIndex = 4;
            this.swapSidesButton.Text = "<-- Switch tracks -->";
            this.swapSidesButton.UseVisualStyleBackColor = true;
            this.swapSidesButton.Click += new System.EventHandler(this.swapSidesButton_Click);
            // 
            // EditOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.swapSidesButton);
            this.Controls.Add(this.mirrorRightButton);
            this.Controls.Add(this.mirrorLeftButton);
            this.Controls.Add(this.mirrorBottomButton);
            this.Controls.Add(this.durationGroupBox);
            this.Name = "EditOperation";
            this.Size = new System.Drawing.Size(776, 324);
            this.durationGroupBox.ResumeLayout(false);
            this.durationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeEndNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeStartNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox durationGroupBox;
        private System.Windows.Forms.Label timeRangeDividerLabel;
        private System.Windows.Forms.NumericUpDown timeRangeEndNumericUpDown;
        private System.Windows.Forms.NumericUpDown timeRangeStartNumericUpDown;
        private System.Windows.Forms.RadioButton durationTimeRangeRadioButton;
        private System.Windows.Forms.RadioButton durationEntireChartRadioButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button mirrorBottomButton;
        private System.Windows.Forms.Button mirrorLeftButton;
        private System.Windows.Forms.Button mirrorRightButton;
        private System.Windows.Forms.Button swapSidesButton;
    }
}
