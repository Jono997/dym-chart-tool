
namespace DyMChartTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileInLabel = new System.Windows.Forms.Label();
            this.fileInTextBox = new System.Windows.Forms.TextBox();
            this.fileInBrowseButton = new System.Windows.Forms.Button();
            this.fileOutBrowseButton = new System.Windows.Forms.Button();
            this.fileOutTextBox = new System.Windows.Forms.TextBox();
            this.fileOutLabel = new System.Windows.Forms.Label();
            this.fileInBrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileOutBrowseDialog = new System.Windows.Forms.SaveFileDialog();
            this.applyButton = new System.Windows.Forms.Button();
            this.editAddedLabel = new System.Windows.Forms.Label();
            this.hideEditAddedTimer = new System.Windows.Forms.Timer(this.components);
            this.editOperation = new DyMChartTool.EditOperationControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileInLabel
            // 
            this.fileInLabel.AutoSize = true;
            this.fileInLabel.Location = new System.Drawing.Point(13, 32);
            this.fileInLabel.Name = "fileInLabel";
            this.fileInLabel.Size = new System.Drawing.Size(16, 13);
            this.fileInLabel.TabIndex = 0;
            this.fileInLabel.Text = "In";
            // 
            // fileInTextBox
            // 
            this.fileInTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInTextBox.Location = new System.Drawing.Point(43, 29);
            this.fileInTextBox.Name = "fileInTextBox";
            this.fileInTextBox.Size = new System.Drawing.Size(714, 20);
            this.fileInTextBox.TabIndex = 1;
            this.fileInTextBox.TextChanged += new System.EventHandler(this.fileInTextBox_TextChanged);
            // 
            // fileInBrowseButton
            // 
            this.fileInBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInBrowseButton.Location = new System.Drawing.Point(763, 27);
            this.fileInBrowseButton.Name = "fileInBrowseButton";
            this.fileInBrowseButton.Size = new System.Drawing.Size(25, 23);
            this.fileInBrowseButton.TabIndex = 2;
            this.fileInBrowseButton.Text = "...";
            this.fileInBrowseButton.UseVisualStyleBackColor = true;
            this.fileInBrowseButton.Click += new System.EventHandler(this.fileInBrowseButton_Click);
            // 
            // fileOutBrowseButton
            // 
            this.fileOutBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileOutBrowseButton.Location = new System.Drawing.Point(763, 53);
            this.fileOutBrowseButton.Name = "fileOutBrowseButton";
            this.fileOutBrowseButton.Size = new System.Drawing.Size(25, 23);
            this.fileOutBrowseButton.TabIndex = 5;
            this.fileOutBrowseButton.Text = "...";
            this.fileOutBrowseButton.UseVisualStyleBackColor = true;
            this.fileOutBrowseButton.Click += new System.EventHandler(this.fileOutBrowseButton_Click);
            // 
            // fileOutTextBox
            // 
            this.fileOutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileOutTextBox.Location = new System.Drawing.Point(43, 55);
            this.fileOutTextBox.Name = "fileOutTextBox";
            this.fileOutTextBox.Size = new System.Drawing.Size(714, 20);
            this.fileOutTextBox.TabIndex = 4;
            // 
            // fileOutLabel
            // 
            this.fileOutLabel.AutoSize = true;
            this.fileOutLabel.Location = new System.Drawing.Point(13, 58);
            this.fileOutLabel.Name = "fileOutLabel";
            this.fileOutLabel.Size = new System.Drawing.Size(24, 13);
            this.fileOutLabel.TabIndex = 3;
            this.fileOutLabel.Text = "Out";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(12, 485);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(776, 46);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "Check edit queue";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // editAddedLabel
            // 
            this.editAddedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editAddedLabel.AutoSize = true;
            this.editAddedLabel.Location = new System.Drawing.Point(13, 469);
            this.editAddedLabel.Name = "editAddedLabel";
            this.editAddedLabel.Size = new System.Drawing.Size(205, 13);
            this.editAddedLabel.TabIndex = 8;
            this.editAddedLabel.Text = "Edit added to queue!|Edit applied to chart!";
            this.editAddedLabel.Visible = false;
            // 
            // hideEditAddedTimer
            // 
            this.hideEditAddedTimer.Interval = 1000;
            this.hideEditAddedTimer.Tick += new System.EventHandler(this.hideEditAddedTimer_Tick);
            // 
            // editOperation
            // 
            this.editOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editOperation.Location = new System.Drawing.Point(12, 83);
            this.editOperation.Name = "editOperation";
            this.editOperation.Size = new System.Drawing.Size(776, 378);
            this.editOperation.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.clearInOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearInOutToolStripMenuItem
            // 
            this.clearInOutToolStripMenuItem.Name = "clearInOutToolStripMenuItem";
            this.clearInOutToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.clearInOutToolStripMenuItem.Text = "Clear In/Out/Time";
            this.clearInOutToolStripMenuItem.Click += new System.EventHandler(this.clearInOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.editAddedLabel);
            this.Controls.Add(this.editOperation);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.fileOutBrowseButton);
            this.Controls.Add(this.fileOutTextBox);
            this.Controls.Add(this.fileOutLabel);
            this.Controls.Add(this.fileInBrowseButton);
            this.Controls.Add(this.fileInTextBox);
            this.Controls.Add(this.fileInLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DyM Chart Tool";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileInLabel;
        private System.Windows.Forms.TextBox fileInTextBox;
        private System.Windows.Forms.Button fileInBrowseButton;
        private System.Windows.Forms.Button fileOutBrowseButton;
        private System.Windows.Forms.TextBox fileOutTextBox;
        private System.Windows.Forms.Label fileOutLabel;
        private System.Windows.Forms.OpenFileDialog fileInBrowseDialog;
        private System.Windows.Forms.SaveFileDialog fileOutBrowseDialog;
        private System.Windows.Forms.Button applyButton;
        private EditOperationControl editOperation;
        private System.Windows.Forms.Label editAddedLabel;
        private System.Windows.Forms.Timer hideEditAddedTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearInOutToolStripMenuItem;
    }
}

