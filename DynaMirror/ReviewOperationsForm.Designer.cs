
namespace DynaMirror
{
    partial class ReviewOperationsForm
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
            this.operationsListBox = new System.Windows.Forms.ListBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operationsListBox
            // 
            this.operationsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsListBox.FormattingEnabled = true;
            this.operationsListBox.Location = new System.Drawing.Point(12, 12);
            this.operationsListBox.Name = "operationsListBox";
            this.operationsListBox.Size = new System.Drawing.Size(291, 381);
            this.operationsListBox.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(12, 399);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(291, 39);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply edits";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // ReviewOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.operationsListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewOperationsForm";
            this.Text = "Queued edits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox operationsListBox;
        private System.Windows.Forms.Button applyButton;
    }
}