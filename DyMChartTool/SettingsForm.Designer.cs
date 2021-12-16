
namespace DyMChartTool
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.closeAfterApplyCheckBox = new System.Windows.Forms.CheckBox();
            this.illegalOperationCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sortByTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByIDRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.groupHoldAndSubCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortByTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeAfterApplyCheckBox
            // 
            this.closeAfterApplyCheckBox.AutoSize = true;
            this.closeAfterApplyCheckBox.Location = new System.Drawing.Point(12, 12);
            this.closeAfterApplyCheckBox.Name = "closeAfterApplyCheckBox";
            this.closeAfterApplyCheckBox.Size = new System.Drawing.Size(220, 17);
            this.closeAfterApplyCheckBox.TabIndex = 1;
            this.closeAfterApplyCheckBox.Text = "Close DyM Chart Tool after applying edits";
            this.toolTip1.SetToolTip(this.closeAfterApplyCheckBox, "Closes the DyM Chart Tool application once the edits in the queue have been appli" +
        "ed");
            this.closeAfterApplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // illegalOperationCheckBox
            // 
            this.illegalOperationCheckBox.AutoSize = true;
            this.illegalOperationCheckBox.Location = new System.Drawing.Point(12, 35);
            this.illegalOperationCheckBox.Name = "illegalOperationCheckBox";
            this.illegalOperationCheckBox.Size = new System.Drawing.Size(132, 17);
            this.illegalOperationCheckBox.TabIndex = 2;
            this.illegalOperationCheckBox.Text = "Allow illegal operations";
            this.toolTip1.SetToolTip(this.illegalOperationCheckBox, "Allow for DyM Chart Tool to put the chart in a state that wouldn\'t be allowed in " +
        "Dynamix\r\n(CHAIN notes on PAD tracks or NORMAL/HOLD notes on MIXER tracks)");
            this.illegalOperationCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortByTimeRadioButton
            // 
            this.sortByTimeRadioButton.AutoSize = true;
            this.sortByTimeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.sortByTimeRadioButton.Name = "sortByTimeRadioButton";
            this.sortByTimeRadioButton.Size = new System.Drawing.Size(48, 17);
            this.sortByTimeRadioButton.TabIndex = 0;
            this.sortByTimeRadioButton.TabStop = true;
            this.sortByTimeRadioButton.Text = "Time";
            this.toolTip1.SetToolTip(this.sortByTimeRadioButton, "Sort notes in the exported chart by time");
            this.sortByTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByIDRadioButton
            // 
            this.sortByIDRadioButton.AutoSize = true;
            this.sortByIDRadioButton.Location = new System.Drawing.Point(6, 65);
            this.sortByIDRadioButton.Name = "sortByIDRadioButton";
            this.sortByIDRadioButton.Size = new System.Drawing.Size(36, 17);
            this.sortByIDRadioButton.TabIndex = 1;
            this.sortByIDRadioButton.TabStop = true;
            this.sortByIDRadioButton.Text = "ID";
            this.toolTip1.SetToolTip(this.sortByIDRadioButton, "Sort notes in the exported chart by their internal IDs");
            this.sortByIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByNoneRadioButton
            // 
            this.sortByNoneRadioButton.AutoSize = true;
            this.sortByNoneRadioButton.Location = new System.Drawing.Point(6, 88);
            this.sortByNoneRadioButton.Name = "sortByNoneRadioButton";
            this.sortByNoneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.sortByNoneRadioButton.TabIndex = 2;
            this.sortByNoneRadioButton.TabStop = true;
            this.sortByNoneRadioButton.Text = "None";
            this.toolTip1.SetToolTip(this.sortByNoneRadioButton, "Don\'t sort notes before exporting the chart");
            this.sortByNoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupHoldAndSubCheckBox
            // 
            this.groupHoldAndSubCheckBox.AutoSize = true;
            this.groupHoldAndSubCheckBox.Location = new System.Drawing.Point(12, 180);
            this.groupHoldAndSubCheckBox.Name = "groupHoldAndSubCheckBox";
            this.groupHoldAndSubCheckBox.Size = new System.Drawing.Size(177, 17);
            this.groupHoldAndSubCheckBox.TabIndex = 4;
            this.groupHoldAndSubCheckBox.Text = "Group HOLD and SUB in export";
            this.toolTip1.SetToolTip(this.groupHoldAndSubCheckBox, "Always place a hold end note immediately after its respective hold in the chart f" +
        "ile, regardless of sort setting.");
            this.groupHoldAndSubCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sortByTypeRadioButton);
            this.groupBox1.Controls.Add(this.sortByNoneRadioButton);
            this.groupBox1.Controls.Add(this.sortByIDRadioButton);
            this.groupBox1.Controls.Add(this.sortByTimeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort notes by:";
            // 
            // sortByTypeRadioButton
            // 
            this.sortByTypeRadioButton.AutoSize = true;
            this.sortByTypeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.sortByTypeRadioButton.Name = "sortByTypeRadioButton";
            this.sortByTypeRadioButton.Size = new System.Drawing.Size(49, 17);
            this.sortByTypeRadioButton.TabIndex = 3;
            this.sortByTypeRadioButton.TabStop = true;
            this.sortByTypeRadioButton.Text = "Type";
            this.toolTip1.SetToolTip(this.sortByTypeRadioButton, "Sort notes in the exported chart by note type");
            this.sortByTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 259);
            this.Controls.Add(this.groupHoldAndSubCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.illegalOperationCheckBox);
            this.Controls.Add(this.closeAfterApplyCheckBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "DyM Chart Tool Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox closeAfterApplyCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox illegalOperationCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sortByNoneRadioButton;
        private System.Windows.Forms.RadioButton sortByIDRadioButton;
        private System.Windows.Forms.RadioButton sortByTimeRadioButton;
        private System.Windows.Forms.CheckBox groupHoldAndSubCheckBox;
        private System.Windows.Forms.RadioButton sortByTypeRadioButton;
    }
}