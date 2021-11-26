
namespace DyMChartTool
{
    partial class EditOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOperationForm));
            this.editOperationControl = new DyMChartTool.EditOperationControl();
            this.SuspendLayout();
            // 
            // editOperationControl
            // 
            this.editOperationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editOperationControl.Location = new System.Drawing.Point(0, 0);
            this.editOperationControl.Name = "editOperationControl";
            this.editOperationControl.Size = new System.Drawing.Size(778, 460);
            this.editOperationControl.TabIndex = 0;
            // 
            // EditOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 460);
            this.Controls.Add(this.editOperationControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditOperationForm";
            this.Text = "Modify edit";
            this.ResumeLayout(false);

        }

        #endregion

        private EditOperationControl editOperationControl;
    }
}