
namespace DynaMirror
{
    partial class EditOperationControl
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MirrorTab = new System.Windows.Forms.TabPage();
            this.CopyTab = new System.Windows.Forms.TabPage();
            this.copyDestinationGroupBox = new System.Windows.Forms.GroupBox();
            this.applyCopyButton = new System.Windows.Forms.Button();
            this.copyDestinationTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.copySourceGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyRightTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.copyTracksLabel = new System.Windows.Forms.Label();
            this.copyMainTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.copyLeftTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copyRangeLabel = new System.Windows.Forms.Label();
            this.copyRangeStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.copyRangeEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.copyRangeDividerLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CopyDestinationAsStartTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.durationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeEndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeStartNumericUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.MirrorTab.SuspendLayout();
            this.CopyTab.SuspendLayout();
            this.copyDestinationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyDestinationTimeNumericUpDown)).BeginInit();
            this.copySourceGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyRangeStartNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyRangeEndNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.durationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.durationGroupBox.Name = "durationGroupBox";
            this.durationGroupBox.Size = new System.Drawing.Size(756, 80);
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
            this.timeRangeEndNumericUpDown.DecimalPlaces = 3;
            this.timeRangeEndNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.timeRangeEndNumericUpDown.Location = new System.Drawing.Point(179, 42);
            this.timeRangeEndNumericUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.timeRangeEndNumericUpDown.Name = "timeRangeEndNumericUpDown";
            this.timeRangeEndNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.timeRangeEndNumericUpDown.TabIndex = 3;
            this.toolTip.SetToolTip(this.timeRangeEndNumericUpDown, "When to stop applying the effect (milliseconds)");
            // 
            // timeRangeStartNumericUpDown
            // 
            this.timeRangeStartNumericUpDown.DecimalPlaces = 3;
            this.timeRangeStartNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.timeRangeStartNumericUpDown.Location = new System.Drawing.Point(90, 42);
            this.timeRangeStartNumericUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.timeRangeStartNumericUpDown.Name = "timeRangeStartNumericUpDown";
            this.timeRangeStartNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.timeRangeStartNumericUpDown.TabIndex = 2;
            this.toolTip.SetToolTip(this.timeRangeStartNumericUpDown, "When to start applying the effect (milliseconds)");
            // 
            // durationTimeRangeRadioButton
            // 
            this.durationTimeRangeRadioButton.AutoSize = true;
            this.durationTimeRangeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.durationTimeRangeRadioButton.Name = "durationTimeRangeRadioButton";
            this.durationTimeRangeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.durationTimeRangeRadioButton.TabIndex = 1;
            this.durationTimeRangeRadioButton.Text = "Time range";
            this.toolTip.SetToolTip(this.durationTimeRangeRadioButton, "Applies this effect to all notes inbetween the times specified");
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
            this.toolTip.SetToolTip(this.durationEntireChartRadioButton, "Applies this effect to all notes in the chart");
            this.durationEntireChartRadioButton.UseVisualStyleBackColor = true;
            this.durationEntireChartRadioButton.CheckedChanged += new System.EventHandler(this.durationEntireChartRadioButton_CheckedChanged);
            // 
            // mirrorBottomButton
            // 
            this.mirrorBottomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorBottomButton.Location = new System.Drawing.Point(3, 396);
            this.mirrorBottomButton.Name = "mirrorBottomButton";
            this.mirrorBottomButton.Size = new System.Drawing.Size(765, 33);
            this.mirrorBottomButton.TabIndex = 1;
            this.mirrorBottomButton.Text = "Mirror main track";
            this.toolTip.SetToolTip(this.mirrorBottomButton, "Mirror notes on the main track");
            this.mirrorBottomButton.UseVisualStyleBackColor = true;
            this.mirrorBottomButton.Click += new System.EventHandler(this.mirrorBottomButton_Click);
            // 
            // mirrorLeftButton
            // 
            this.mirrorLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mirrorLeftButton.Location = new System.Drawing.Point(3, 92);
            this.mirrorLeftButton.Name = "mirrorLeftButton";
            this.mirrorLeftButton.Size = new System.Drawing.Size(91, 298);
            this.mirrorLeftButton.TabIndex = 2;
            this.mirrorLeftButton.Text = "Mirror left track";
            this.toolTip.SetToolTip(this.mirrorLeftButton, "Mirror notes on the left hand track");
            this.mirrorLeftButton.UseVisualStyleBackColor = true;
            this.mirrorLeftButton.Click += new System.EventHandler(this.mirrorLeftButton_Click);
            // 
            // mirrorRightButton
            // 
            this.mirrorRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorRightButton.Location = new System.Drawing.Point(677, 92);
            this.mirrorRightButton.Name = "mirrorRightButton";
            this.mirrorRightButton.Size = new System.Drawing.Size(91, 298);
            this.mirrorRightButton.TabIndex = 3;
            this.mirrorRightButton.Text = "Mirror right track";
            this.toolTip.SetToolTip(this.mirrorRightButton, "Mirror notes on the right hand track");
            this.mirrorRightButton.UseVisualStyleBackColor = true;
            this.mirrorRightButton.Click += new System.EventHandler(this.mirrorRightButton_Click);
            // 
            // swapSidesButton
            // 
            this.swapSidesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.swapSidesButton.Location = new System.Drawing.Point(100, 226);
            this.swapSidesButton.Name = "swapSidesButton";
            this.swapSidesButton.Size = new System.Drawing.Size(571, 31);
            this.swapSidesButton.TabIndex = 4;
            this.swapSidesButton.Text = "<-- Switch tracks -->";
            this.toolTip.SetToolTip(this.swapSidesButton, "Switch the left and right tracks around");
            this.swapSidesButton.UseVisualStyleBackColor = true;
            this.swapSidesButton.Click += new System.EventHandler(this.swapSidesButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MirrorTab);
            this.tabControl.Controls.Add(this.CopyTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 461);
            this.tabControl.TabIndex = 5;
            // 
            // MirrorTab
            // 
            this.MirrorTab.Controls.Add(this.durationGroupBox);
            this.MirrorTab.Controls.Add(this.mirrorBottomButton);
            this.MirrorTab.Controls.Add(this.swapSidesButton);
            this.MirrorTab.Controls.Add(this.mirrorLeftButton);
            this.MirrorTab.Controls.Add(this.mirrorRightButton);
            this.MirrorTab.Location = new System.Drawing.Point(4, 22);
            this.MirrorTab.Name = "MirrorTab";
            this.MirrorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MirrorTab.Size = new System.Drawing.Size(768, 435);
            this.MirrorTab.TabIndex = 0;
            this.MirrorTab.Text = "Mirror";
            this.MirrorTab.UseVisualStyleBackColor = true;
            // 
            // CopyTab
            // 
            this.CopyTab.Controls.Add(this.copyDestinationGroupBox);
            this.CopyTab.Controls.Add(this.copySourceGroupBox);
            this.CopyTab.Location = new System.Drawing.Point(4, 22);
            this.CopyTab.Name = "CopyTab";
            this.CopyTab.Padding = new System.Windows.Forms.Padding(3);
            this.CopyTab.Size = new System.Drawing.Size(768, 435);
            this.CopyTab.TabIndex = 1;
            this.CopyTab.Text = "Copy";
            this.CopyTab.UseVisualStyleBackColor = true;
            // 
            // copyDestinationGroupBox
            // 
            this.copyDestinationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.copyDestinationGroupBox.Controls.Add(this.groupBox3);
            this.copyDestinationGroupBox.Controls.Add(this.applyCopyButton);
            this.copyDestinationGroupBox.Controls.Add(this.copyDestinationTimeNumericUpDown);
            this.copyDestinationGroupBox.Controls.Add(this.label1);
            this.copyDestinationGroupBox.Location = new System.Drawing.Point(373, 6);
            this.copyDestinationGroupBox.Name = "copyDestinationGroupBox";
            this.copyDestinationGroupBox.Size = new System.Drawing.Size(389, 423);
            this.copyDestinationGroupBox.TabIndex = 1;
            this.copyDestinationGroupBox.TabStop = false;
            this.copyDestinationGroupBox.Text = "Destination";
            // 
            // applyCopyButton
            // 
            this.applyCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyCopyButton.Location = new System.Drawing.Point(6, 379);
            this.applyCopyButton.Name = "applyCopyButton";
            this.applyCopyButton.Size = new System.Drawing.Size(377, 38);
            this.applyCopyButton.TabIndex = 2;
            this.applyCopyButton.Text = "Apply";
            this.applyCopyButton.UseVisualStyleBackColor = true;
            this.applyCopyButton.Click += new System.EventHandler(this.applyCopyButton_Click);
            // 
            // copyDestinationTimeNumericUpDown
            // 
            this.copyDestinationTimeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyDestinationTimeNumericUpDown.DecimalPlaces = 3;
            this.copyDestinationTimeNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.copyDestinationTimeNumericUpDown.Location = new System.Drawing.Point(263, 19);
            this.copyDestinationTimeNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.copyDestinationTimeNumericUpDown.Name = "copyDestinationTimeNumericUpDown";
            this.copyDestinationTimeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.copyDestinationTimeNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time:";
            // 
            // copySourceGroupBox
            // 
            this.copySourceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.copySourceGroupBox.Controls.Add(this.groupBox2);
            this.copySourceGroupBox.Controls.Add(this.groupBox1);
            this.copySourceGroupBox.Location = new System.Drawing.Point(6, 6);
            this.copySourceGroupBox.Name = "copySourceGroupBox";
            this.copySourceGroupBox.Size = new System.Drawing.Size(361, 423);
            this.copySourceGroupBox.TabIndex = 0;
            this.copySourceGroupBox.TabStop = false;
            this.copySourceGroupBox.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.copyRightTrackCheckBox);
            this.groupBox2.Controls.Add(this.copyTracksLabel);
            this.groupBox2.Controls.Add(this.copyMainTrackCheckBox);
            this.groupBox2.Controls.Add(this.copyLeftTrackCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 93);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // copyRightTrackCheckBox
            // 
            this.copyRightTrackCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRightTrackCheckBox.AutoSize = true;
            this.copyRightTrackCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyRightTrackCheckBox.Checked = true;
            this.copyRightTrackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyRightTrackCheckBox.Location = new System.Drawing.Point(292, 65);
            this.copyRightTrackCheckBox.Name = "copyRightTrackCheckBox";
            this.copyRightTrackCheckBox.Size = new System.Drawing.Size(51, 17);
            this.copyRightTrackCheckBox.TabIndex = 7;
            this.copyRightTrackCheckBox.Text = "Right";
            this.copyRightTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyTracksLabel
            // 
            this.copyTracksLabel.AutoSize = true;
            this.copyTracksLabel.Location = new System.Drawing.Point(6, 20);
            this.copyTracksLabel.Name = "copyTracksLabel";
            this.copyTracksLabel.Size = new System.Drawing.Size(81, 13);
            this.copyTracksLabel.TabIndex = 4;
            this.copyTracksLabel.Text = "Tracks to copy:";
            // 
            // copyMainTrackCheckBox
            // 
            this.copyMainTrackCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyMainTrackCheckBox.AutoSize = true;
            this.copyMainTrackCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyMainTrackCheckBox.Checked = true;
            this.copyMainTrackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyMainTrackCheckBox.Location = new System.Drawing.Point(294, 19);
            this.copyMainTrackCheckBox.Name = "copyMainTrackCheckBox";
            this.copyMainTrackCheckBox.Size = new System.Drawing.Size(49, 17);
            this.copyMainTrackCheckBox.TabIndex = 5;
            this.copyMainTrackCheckBox.Text = "Main";
            this.copyMainTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyLeftTrackCheckBox
            // 
            this.copyLeftTrackCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyLeftTrackCheckBox.AutoSize = true;
            this.copyLeftTrackCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyLeftTrackCheckBox.Checked = true;
            this.copyLeftTrackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyLeftTrackCheckBox.Location = new System.Drawing.Point(299, 42);
            this.copyLeftTrackCheckBox.Name = "copyLeftTrackCheckBox";
            this.copyLeftTrackCheckBox.Size = new System.Drawing.Size(44, 17);
            this.copyLeftTrackCheckBox.TabIndex = 6;
            this.copyLeftTrackCheckBox.Text = "Left";
            this.copyLeftTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.copyRangeLabel);
            this.groupBox1.Controls.Add(this.copyRangeStartNumericUpDown);
            this.groupBox1.Controls.Add(this.copyRangeEndNumericUpDown);
            this.groupBox1.Controls.Add(this.copyRangeDividerLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // copyRangeLabel
            // 
            this.copyRangeLabel.AutoSize = true;
            this.copyRangeLabel.Location = new System.Drawing.Point(6, 21);
            this.copyRangeLabel.Name = "copyRangeLabel";
            this.copyRangeLabel.Size = new System.Drawing.Size(63, 13);
            this.copyRangeLabel.TabIndex = 3;
            this.copyRangeLabel.Text = "Time range:";
            // 
            // copyRangeStartNumericUpDown
            // 
            this.copyRangeStartNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRangeStartNumericUpDown.DecimalPlaces = 3;
            this.copyRangeStartNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.copyRangeStartNumericUpDown.Location = new System.Drawing.Point(187, 19);
            this.copyRangeStartNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.copyRangeStartNumericUpDown.Name = "copyRangeStartNumericUpDown";
            this.copyRangeStartNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.copyRangeStartNumericUpDown.TabIndex = 0;
            // 
            // copyRangeEndNumericUpDown
            // 
            this.copyRangeEndNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRangeEndNumericUpDown.DecimalPlaces = 3;
            this.copyRangeEndNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.copyRangeEndNumericUpDown.Location = new System.Drawing.Point(276, 19);
            this.copyRangeEndNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.copyRangeEndNumericUpDown.Name = "copyRangeEndNumericUpDown";
            this.copyRangeEndNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.copyRangeEndNumericUpDown.TabIndex = 1;
            // 
            // copyRangeDividerLabel
            // 
            this.copyRangeDividerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRangeDividerLabel.AutoSize = true;
            this.copyRangeDividerLabel.Location = new System.Drawing.Point(260, 21);
            this.copyRangeDividerLabel.Name = "copyRangeDividerLabel";
            this.copyRangeDividerLabel.Size = new System.Drawing.Size(10, 13);
            this.copyRangeDividerLabel.TabIndex = 2;
            this.copyRangeDividerLabel.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.CopyDestinationAsStartTimeRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(9, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time equivalent to...";
            // 
            // CopyDestinationAsStartTimeRadioButton
            // 
            this.CopyDestinationAsStartTimeRadioButton.AutoSize = true;
            this.CopyDestinationAsStartTimeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.CopyDestinationAsStartTimeRadioButton.Name = "CopyDestinationAsStartTimeRadioButton";
            this.CopyDestinationAsStartTimeRadioButton.Size = new System.Drawing.Size(69, 17);
            this.CopyDestinationAsStartTimeRadioButton.TabIndex = 0;
            this.CopyDestinationAsStartTimeRadioButton.Text = "Start time";
            this.toolTip.SetToolTip(this.CopyDestinationAsStartTimeRadioButton, "The first note will be as far from the destination time as it is the source start" +
        " time");
            this.CopyDestinationAsStartTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Frist note";
            this.toolTip.SetToolTip(this.radioButton2, "The first note will be exactly at the destination time");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EditOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "EditOperationControl";
            this.Size = new System.Drawing.Size(776, 461);
            this.Resize += new System.EventHandler(this.EditOperationControl_Resize);
            this.durationGroupBox.ResumeLayout(false);
            this.durationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeEndNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRangeStartNumericUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.MirrorTab.ResumeLayout(false);
            this.CopyTab.ResumeLayout(false);
            this.copyDestinationGroupBox.ResumeLayout(false);
            this.copyDestinationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyDestinationTimeNumericUpDown)).EndInit();
            this.copySourceGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyRangeStartNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyRangeEndNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MirrorTab;
        private System.Windows.Forms.TabPage CopyTab;
        private System.Windows.Forms.GroupBox copyDestinationGroupBox;
        private System.Windows.Forms.GroupBox copySourceGroupBox;
        private System.Windows.Forms.NumericUpDown copyRangeStartNumericUpDown;
        private System.Windows.Forms.Label copyRangeLabel;
        private System.Windows.Forms.Label copyRangeDividerLabel;
        private System.Windows.Forms.NumericUpDown copyRangeEndNumericUpDown;
        private System.Windows.Forms.NumericUpDown copyDestinationTimeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox copyRightTrackCheckBox;
        private System.Windows.Forms.Label copyTracksLabel;
        private System.Windows.Forms.CheckBox copyMainTrackCheckBox;
        private System.Windows.Forms.CheckBox copyLeftTrackCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button applyCopyButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton CopyDestinationAsStartTimeRadioButton;
    }
}
