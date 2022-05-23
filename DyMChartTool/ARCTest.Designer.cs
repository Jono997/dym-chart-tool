
namespace DyMChartTool
{
    partial class ARCTest
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
            this.arc = new DyMChartTool.ApplyRangeControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entireChartFalse = new System.Windows.Forms.RadioButton();
            this.entireChartTrue = new System.Windows.Forms.RadioButton();
            this.entireChartUnforced = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainFalse = new System.Windows.Forms.RadioButton();
            this.mainTrue = new System.Windows.Forms.RadioButton();
            this.mainUnforced = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.leftFalse = new System.Windows.Forms.RadioButton();
            this.leftTrue = new System.Windows.Forms.RadioButton();
            this.leftUnforced = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rightFalse = new System.Windows.Forms.RadioButton();
            this.rightTrue = new System.Windows.Forms.RadioButton();
            this.rightUnforced = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.normalFalse = new System.Windows.Forms.RadioButton();
            this.normalTrue = new System.Windows.Forms.RadioButton();
            this.normalUnforced = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.holdFalse = new System.Windows.Forms.RadioButton();
            this.holdTrue = new System.Windows.Forms.RadioButton();
            this.holdUnforced = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chainFalse = new System.Windows.Forms.RadioButton();
            this.chainTrue = new System.Windows.Forms.RadioButton();
            this.chainUnforced = new System.Windows.Forms.RadioButton();
            this.forceStart = new System.Windows.Forms.CheckBox();
            this.startTime = new System.Windows.Forms.NumericUpDown();
            this.endTime = new System.Windows.Forms.NumericUpDown();
            this.forceEnd = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTime)).BeginInit();
            this.SuspendLayout();
            // 
            // arc
            // 
            this.arc.Location = new System.Drawing.Point(12, 12);
            this.arc.Name = "arc";
            this.arc.Size = new System.Drawing.Size(756, 99);
            this.arc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entireChartFalse);
            this.groupBox1.Controls.Add(this.entireChartTrue);
            this.groupBox1.Controls.Add(this.entireChartUnforced);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entire chart";
            // 
            // entireChartFalse
            // 
            this.entireChartFalse.AutoSize = true;
            this.entireChartFalse.Location = new System.Drawing.Point(6, 65);
            this.entireChartFalse.Name = "entireChartFalse";
            this.entireChartFalse.Size = new System.Drawing.Size(83, 17);
            this.entireChartFalse.TabIndex = 2;
            this.entireChartFalse.TabStop = true;
            this.entireChartFalse.Text = "Forced false";
            this.entireChartFalse.UseVisualStyleBackColor = true;
            // 
            // entireChartTrue
            // 
            this.entireChartTrue.AutoSize = true;
            this.entireChartTrue.Location = new System.Drawing.Point(6, 42);
            this.entireChartTrue.Name = "entireChartTrue";
            this.entireChartTrue.Size = new System.Drawing.Size(79, 17);
            this.entireChartTrue.TabIndex = 1;
            this.entireChartTrue.TabStop = true;
            this.entireChartTrue.Text = "Forced true";
            this.entireChartTrue.UseVisualStyleBackColor = true;
            this.entireChartTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // entireChartUnforced
            // 
            this.entireChartUnforced.AutoSize = true;
            this.entireChartUnforced.Checked = true;
            this.entireChartUnforced.Location = new System.Drawing.Point(6, 19);
            this.entireChartUnforced.Name = "entireChartUnforced";
            this.entireChartUnforced.Size = new System.Drawing.Size(69, 17);
            this.entireChartUnforced.TabIndex = 0;
            this.entireChartUnforced.TabStop = true;
            this.entireChartUnforced.Text = "Unforced";
            this.entireChartUnforced.UseVisualStyleBackColor = true;
            this.entireChartUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainFalse);
            this.groupBox2.Controls.Add(this.mainTrue);
            this.groupBox2.Controls.Add(this.mainUnforced);
            this.groupBox2.Location = new System.Drawing.Point(111, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main track";
            // 
            // mainFalse
            // 
            this.mainFalse.AutoSize = true;
            this.mainFalse.Location = new System.Drawing.Point(6, 65);
            this.mainFalse.Name = "mainFalse";
            this.mainFalse.Size = new System.Drawing.Size(83, 17);
            this.mainFalse.TabIndex = 2;
            this.mainFalse.TabStop = true;
            this.mainFalse.Text = "Forced false";
            this.mainFalse.UseVisualStyleBackColor = true;
            // 
            // mainTrue
            // 
            this.mainTrue.AutoSize = true;
            this.mainTrue.Location = new System.Drawing.Point(6, 42);
            this.mainTrue.Name = "mainTrue";
            this.mainTrue.Size = new System.Drawing.Size(79, 17);
            this.mainTrue.TabIndex = 1;
            this.mainTrue.TabStop = true;
            this.mainTrue.Text = "Forced true";
            this.mainTrue.UseVisualStyleBackColor = true;
            this.mainTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // mainUnforced
            // 
            this.mainUnforced.AutoSize = true;
            this.mainUnforced.Checked = true;
            this.mainUnforced.Location = new System.Drawing.Point(6, 19);
            this.mainUnforced.Name = "mainUnforced";
            this.mainUnforced.Size = new System.Drawing.Size(69, 17);
            this.mainUnforced.TabIndex = 0;
            this.mainUnforced.TabStop = true;
            this.mainUnforced.Text = "Unforced";
            this.mainUnforced.UseVisualStyleBackColor = true;
            this.mainUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.leftFalse);
            this.groupBox3.Controls.Add(this.leftTrue);
            this.groupBox3.Controls.Add(this.leftUnforced);
            this.groupBox3.Location = new System.Drawing.Point(210, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 92);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Left track";
            // 
            // leftFalse
            // 
            this.leftFalse.AutoSize = true;
            this.leftFalse.Location = new System.Drawing.Point(6, 65);
            this.leftFalse.Name = "leftFalse";
            this.leftFalse.Size = new System.Drawing.Size(83, 17);
            this.leftFalse.TabIndex = 2;
            this.leftFalse.TabStop = true;
            this.leftFalse.Text = "Forced false";
            this.leftFalse.UseVisualStyleBackColor = true;
            // 
            // leftTrue
            // 
            this.leftTrue.AutoSize = true;
            this.leftTrue.Location = new System.Drawing.Point(6, 42);
            this.leftTrue.Name = "leftTrue";
            this.leftTrue.Size = new System.Drawing.Size(79, 17);
            this.leftTrue.TabIndex = 1;
            this.leftTrue.TabStop = true;
            this.leftTrue.Text = "Forced true";
            this.leftTrue.UseVisualStyleBackColor = true;
            this.leftTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // leftUnforced
            // 
            this.leftUnforced.AutoSize = true;
            this.leftUnforced.Checked = true;
            this.leftUnforced.Location = new System.Drawing.Point(6, 19);
            this.leftUnforced.Name = "leftUnforced";
            this.leftUnforced.Size = new System.Drawing.Size(69, 17);
            this.leftUnforced.TabIndex = 0;
            this.leftUnforced.TabStop = true;
            this.leftUnforced.Text = "Unforced";
            this.leftUnforced.UseVisualStyleBackColor = true;
            this.leftUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rightFalse);
            this.groupBox4.Controls.Add(this.rightTrue);
            this.groupBox4.Controls.Add(this.rightUnforced);
            this.groupBox4.Location = new System.Drawing.Point(309, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 92);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right track";
            // 
            // rightFalse
            // 
            this.rightFalse.AutoSize = true;
            this.rightFalse.Location = new System.Drawing.Point(6, 65);
            this.rightFalse.Name = "rightFalse";
            this.rightFalse.Size = new System.Drawing.Size(83, 17);
            this.rightFalse.TabIndex = 2;
            this.rightFalse.TabStop = true;
            this.rightFalse.Text = "Forced false";
            this.rightFalse.UseVisualStyleBackColor = true;
            // 
            // rightTrue
            // 
            this.rightTrue.AutoSize = true;
            this.rightTrue.Location = new System.Drawing.Point(6, 42);
            this.rightTrue.Name = "rightTrue";
            this.rightTrue.Size = new System.Drawing.Size(79, 17);
            this.rightTrue.TabIndex = 1;
            this.rightTrue.TabStop = true;
            this.rightTrue.Text = "Forced true";
            this.rightTrue.UseVisualStyleBackColor = true;
            this.rightTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // rightUnforced
            // 
            this.rightUnforced.AutoSize = true;
            this.rightUnforced.Checked = true;
            this.rightUnforced.Location = new System.Drawing.Point(6, 19);
            this.rightUnforced.Name = "rightUnforced";
            this.rightUnforced.Size = new System.Drawing.Size(69, 17);
            this.rightUnforced.TabIndex = 0;
            this.rightUnforced.TabStop = true;
            this.rightUnforced.Text = "Unforced";
            this.rightUnforced.UseVisualStyleBackColor = true;
            this.rightUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.normalFalse);
            this.groupBox5.Controls.Add(this.normalTrue);
            this.groupBox5.Controls.Add(this.normalUnforced);
            this.groupBox5.Location = new System.Drawing.Point(408, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(93, 92);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Normal notes";
            // 
            // normalFalse
            // 
            this.normalFalse.AutoSize = true;
            this.normalFalse.Location = new System.Drawing.Point(6, 65);
            this.normalFalse.Name = "normalFalse";
            this.normalFalse.Size = new System.Drawing.Size(83, 17);
            this.normalFalse.TabIndex = 2;
            this.normalFalse.TabStop = true;
            this.normalFalse.Text = "Forced false";
            this.normalFalse.UseVisualStyleBackColor = true;
            // 
            // normalTrue
            // 
            this.normalTrue.AutoSize = true;
            this.normalTrue.Location = new System.Drawing.Point(6, 42);
            this.normalTrue.Name = "normalTrue";
            this.normalTrue.Size = new System.Drawing.Size(79, 17);
            this.normalTrue.TabIndex = 1;
            this.normalTrue.TabStop = true;
            this.normalTrue.Text = "Forced true";
            this.normalTrue.UseVisualStyleBackColor = true;
            this.normalTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // normalUnforced
            // 
            this.normalUnforced.AutoSize = true;
            this.normalUnforced.Checked = true;
            this.normalUnforced.Location = new System.Drawing.Point(6, 19);
            this.normalUnforced.Name = "normalUnforced";
            this.normalUnforced.Size = new System.Drawing.Size(69, 17);
            this.normalUnforced.TabIndex = 0;
            this.normalUnforced.TabStop = true;
            this.normalUnforced.Text = "Unforced";
            this.normalUnforced.UseVisualStyleBackColor = true;
            this.normalUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.holdFalse);
            this.groupBox6.Controls.Add(this.holdTrue);
            this.groupBox6.Controls.Add(this.holdUnforced);
            this.groupBox6.Location = new System.Drawing.Point(507, 117);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(93, 92);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hold notes";
            // 
            // holdFalse
            // 
            this.holdFalse.AutoSize = true;
            this.holdFalse.Location = new System.Drawing.Point(6, 65);
            this.holdFalse.Name = "holdFalse";
            this.holdFalse.Size = new System.Drawing.Size(83, 17);
            this.holdFalse.TabIndex = 2;
            this.holdFalse.TabStop = true;
            this.holdFalse.Text = "Forced false";
            this.holdFalse.UseVisualStyleBackColor = true;
            // 
            // holdTrue
            // 
            this.holdTrue.AutoSize = true;
            this.holdTrue.Location = new System.Drawing.Point(6, 42);
            this.holdTrue.Name = "holdTrue";
            this.holdTrue.Size = new System.Drawing.Size(79, 17);
            this.holdTrue.TabIndex = 1;
            this.holdTrue.TabStop = true;
            this.holdTrue.Text = "Forced true";
            this.holdTrue.UseVisualStyleBackColor = true;
            this.holdTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // holdUnforced
            // 
            this.holdUnforced.AutoSize = true;
            this.holdUnforced.Checked = true;
            this.holdUnforced.Location = new System.Drawing.Point(6, 19);
            this.holdUnforced.Name = "holdUnforced";
            this.holdUnforced.Size = new System.Drawing.Size(69, 17);
            this.holdUnforced.TabIndex = 0;
            this.holdUnforced.TabStop = true;
            this.holdUnforced.Text = "Unforced";
            this.holdUnforced.UseVisualStyleBackColor = true;
            this.holdUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chainFalse);
            this.groupBox7.Controls.Add(this.chainTrue);
            this.groupBox7.Controls.Add(this.chainUnforced);
            this.groupBox7.Location = new System.Drawing.Point(606, 117);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(93, 92);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chain notes";
            // 
            // chainFalse
            // 
            this.chainFalse.AutoSize = true;
            this.chainFalse.Location = new System.Drawing.Point(6, 65);
            this.chainFalse.Name = "chainFalse";
            this.chainFalse.Size = new System.Drawing.Size(83, 17);
            this.chainFalse.TabIndex = 2;
            this.chainFalse.TabStop = true;
            this.chainFalse.Text = "Forced false";
            this.chainFalse.UseVisualStyleBackColor = true;
            // 
            // chainTrue
            // 
            this.chainTrue.AutoSize = true;
            this.chainTrue.Location = new System.Drawing.Point(6, 42);
            this.chainTrue.Name = "chainTrue";
            this.chainTrue.Size = new System.Drawing.Size(79, 17);
            this.chainTrue.TabIndex = 1;
            this.chainTrue.TabStop = true;
            this.chainTrue.Text = "Forced true";
            this.chainTrue.UseVisualStyleBackColor = true;
            this.chainTrue.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // chainUnforced
            // 
            this.chainUnforced.AutoSize = true;
            this.chainUnforced.Checked = true;
            this.chainUnforced.Location = new System.Drawing.Point(6, 19);
            this.chainUnforced.Name = "chainUnforced";
            this.chainUnforced.Size = new System.Drawing.Size(69, 17);
            this.chainUnforced.TabIndex = 0;
            this.chainUnforced.TabStop = true;
            this.chainUnforced.Text = "Unforced";
            this.chainUnforced.UseVisualStyleBackColor = true;
            this.chainUnforced.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // forceStart
            // 
            this.forceStart.AutoSize = true;
            this.forceStart.Location = new System.Drawing.Point(12, 216);
            this.forceStart.Name = "forceStart";
            this.forceStart.Size = new System.Drawing.Size(70, 17);
            this.forceStart.TabIndex = 9;
            this.forceStart.Text = "Start time";
            this.forceStart.UseVisualStyleBackColor = true;
            this.forceStart.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // startTime
            // 
            this.startTime.DecimalPlaces = 5;
            this.startTime.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.startTime.Location = new System.Drawing.Point(88, 215);
            this.startTime.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(67, 20);
            this.startTime.TabIndex = 10;
            this.startTime.ValueChanged += new System.EventHandler(this.ForceChanged);
            // 
            // endTime
            // 
            this.endTime.DecimalPlaces = 5;
            this.endTime.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.endTime.Location = new System.Drawing.Point(234, 216);
            this.endTime.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(67, 20);
            this.endTime.TabIndex = 12;
            this.endTime.ValueChanged += new System.EventHandler(this.ForceChanged);
            // 
            // forceEnd
            // 
            this.forceEnd.AutoSize = true;
            this.forceEnd.Location = new System.Drawing.Point(161, 216);
            this.forceEnd.Name = "forceEnd";
            this.forceEnd.Size = new System.Drawing.Size(67, 17);
            this.forceEnd.TabIndex = 11;
            this.forceEnd.Text = "End time";
            this.forceEnd.UseVisualStyleBackColor = true;
            this.forceEnd.CheckedChanged += new System.EventHandler(this.ForceChanged);
            // 
            // ARCTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.forceEnd);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.forceStart);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.arc);
            this.Name = "ARCTest";
            this.Text = "ARCTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplyRangeControl arc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton entireChartFalse;
        private System.Windows.Forms.RadioButton entireChartTrue;
        private System.Windows.Forms.RadioButton entireChartUnforced;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton mainFalse;
        private System.Windows.Forms.RadioButton mainTrue;
        private System.Windows.Forms.RadioButton mainUnforced;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton leftFalse;
        private System.Windows.Forms.RadioButton leftTrue;
        private System.Windows.Forms.RadioButton leftUnforced;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rightFalse;
        private System.Windows.Forms.RadioButton rightTrue;
        private System.Windows.Forms.RadioButton rightUnforced;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton normalFalse;
        private System.Windows.Forms.RadioButton normalTrue;
        private System.Windows.Forms.RadioButton normalUnforced;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton holdFalse;
        private System.Windows.Forms.RadioButton holdTrue;
        private System.Windows.Forms.RadioButton holdUnforced;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton chainFalse;
        private System.Windows.Forms.RadioButton chainTrue;
        private System.Windows.Forms.RadioButton chainUnforced;
        private System.Windows.Forms.CheckBox forceStart;
        private System.Windows.Forms.NumericUpDown startTime;
        private System.Windows.Forms.NumericUpDown endTime;
        private System.Windows.Forms.CheckBox forceEnd;
    }
}