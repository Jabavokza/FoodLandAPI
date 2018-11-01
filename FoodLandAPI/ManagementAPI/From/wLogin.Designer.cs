namespace ManagementAPI.From
{
    partial class wLogin
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
            this.olaUserName = new MetroFramework.Controls.MetroLabel();
            this.ocmOK = new MetroFramework.Controls.MetroButton();
            this.otbUserName = new MetroFramework.Controls.MetroTextBox();
            this.otbUserPwd = new MetroFramework.Controls.MetroTextBox();
            this.olaUserPwd = new MetroFramework.Controls.MetroLabel();
            this.ocmCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // olaUserName
            // 
            this.olaUserName.AutoSize = true;
            this.olaUserName.Location = new System.Drawing.Point(107, 51);
            this.olaUserName.Name = "olaUserName";
            this.olaUserName.Size = new System.Drawing.Size(71, 19);
            this.olaUserName.TabIndex = 6;
            this.olaUserName.Text = "UserName";
            // 
            // ocmOK
            // 
            this.ocmOK.Location = new System.Drawing.Point(99, 131);
            this.ocmOK.Name = "ocmOK";
            this.ocmOK.Size = new System.Drawing.Size(75, 23);
            this.ocmOK.TabIndex = 1;
            this.ocmOK.Text = "ตกลง";
            this.ocmOK.Click += new System.EventHandler(this.ocmOK_Click);
            // 
            // otbUserName
            // 
            this.otbUserName.Location = new System.Drawing.Point(202, 51);
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(138, 23);
            this.otbUserName.TabIndex = 0;
            // 
            // otbUserPwd
            // 
            this.otbUserPwd.Location = new System.Drawing.Point(202, 80);
            this.otbUserPwd.Name = "otbUserPwd";
            this.otbUserPwd.PasswordChar = '*';
            this.otbUserPwd.Size = new System.Drawing.Size(138, 23);
            this.otbUserPwd.TabIndex = 1;
            // 
            // olaUserPwd
            // 
            this.olaUserPwd.AutoSize = true;
            this.olaUserPwd.Location = new System.Drawing.Point(107, 80);
            this.olaUserPwd.Name = "olaUserPwd";
            this.olaUserPwd.Size = new System.Drawing.Size(89, 19);
            this.olaUserPwd.TabIndex = 3;
            this.olaUserPwd.Text = "UserPassword";
            // 
            // ocmCancel
            // 
            this.ocmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmCancel.Location = new System.Drawing.Point(202, 131);
            this.ocmCancel.Name = "ocmCancel";
            this.ocmCancel.Size = new System.Drawing.Size(75, 23);
            this.ocmCancel.TabIndex = 5;
            this.ocmCancel.Text = "ยกเลิก";
            this.ocmCancel.Click += new System.EventHandler(this.ocmCancel_Click);
            // 
            // wLogin
            // 
            this.AcceptButton = this.ocmOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ocmCancel;
            this.ClientSize = new System.Drawing.Size(366, 170);
            this.ControlBox = false;
            this.Controls.Add(this.ocmCancel);
            this.Controls.Add(this.otbUserPwd);
            this.Controls.Add(this.olaUserPwd);
            this.Controls.Add(this.otbUserName);
            this.Controls.Add(this.ocmOK);
            this.Controls.Add(this.olaUserName);
            this.Movable = false;
            this.Name = "wLogin";
            this.Resizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.wLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel olaUserName;
        private MetroFramework.Controls.MetroButton ocmOK;
        private MetroFramework.Controls.MetroTextBox otbUserName;
        private MetroFramework.Controls.MetroTextBox otbUserPwd;
        private MetroFramework.Controls.MetroLabel olaUserPwd;
        private MetroFramework.Controls.MetroButton ocmCancel;
    }
}