namespace ManagementAPI.From
{
    partial class wProgressDlg
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
            this.opgStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // opgStatus
            // 
            this.opgStatus.Location = new System.Drawing.Point(5, 9);
            this.opgStatus.Name = "opgStatus";
            this.opgStatus.Size = new System.Drawing.Size(192, 26);
            this.opgStatus.TabIndex = 4;
            // 
            // wProgressDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 36);
            this.ControlBox = false;
            this.Controls.Add(this.opgStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "wProgressDlg";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar opgStatus;
    }
}