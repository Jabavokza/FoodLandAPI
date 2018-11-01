namespace ManagementAPI.From
{
    partial class wSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wSetting));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ocbDbName = new System.Windows.Forms.ComboBox();
            this.ocmRefresh = new System.Windows.Forms.Button();
            this.otbUrl = new MetroFramework.Controls.MetroTextBox();
            this.olaUrl = new MetroFramework.Controls.MetroLabel();
            this.olaDbName = new MetroFramework.Controls.MetroLabel();
            this.otbUserPwd = new MetroFramework.Controls.MetroTextBox();
            this.olaUserPwd = new MetroFramework.Controls.MetroLabel();
            this.otbUserName = new MetroFramework.Controls.MetroTextBox();
            this.olaUserName = new MetroFramework.Controls.MetroLabel();
            this.otbServerName = new MetroFramework.Controls.MetroTextBox();
            this.olaServerName = new MetroFramework.Controls.MetroLabel();
            this.ocmSave = new MetroFramework.Controls.MetroButton();
            this.ocmCancel = new MetroFramework.Controls.MetroButton();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ocbDbName);
            this.metroPanel1.Controls.Add(this.ocmRefresh);
            this.metroPanel1.Controls.Add(this.otbUrl);
            this.metroPanel1.Controls.Add(this.olaUrl);
            this.metroPanel1.Controls.Add(this.olaDbName);
            this.metroPanel1.Controls.Add(this.otbUserPwd);
            this.metroPanel1.Controls.Add(this.olaUserPwd);
            this.metroPanel1.Controls.Add(this.otbUserName);
            this.metroPanel1.Controls.Add(this.olaUserName);
            this.metroPanel1.Controls.Add(this.otbServerName);
            this.metroPanel1.Controls.Add(this.olaServerName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(423, 205);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ocbDbName
            // 
            this.ocbDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocbDbName.FormattingEnabled = true;
            this.ocbDbName.Location = new System.Drawing.Point(95, 157);
            this.ocbDbName.Name = "ocbDbName";
            this.ocbDbName.Size = new System.Drawing.Size(228, 28);
            this.ocbDbName.TabIndex = 14;
            // 
            // ocmRefresh
            // 
            this.ocmRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ocmRefresh.BackgroundImage")));
            this.ocmRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ocmRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmRefresh.Location = new System.Drawing.Point(329, 156);
            this.ocmRefresh.Name = "ocmRefresh";
            this.ocmRefresh.Size = new System.Drawing.Size(75, 31);
            this.ocmRefresh.TabIndex = 13;
            this.ocmRefresh.Text = "Refresh";
            this.ocmRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmRefresh.UseVisualStyleBackColor = true;
            this.ocmRefresh.Click += new System.EventHandler(this.ocmRefresh_Click);
            // 
            // otbUrl
            // 
            this.otbUrl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.otbUrl.Location = new System.Drawing.Point(95, 16);
            this.otbUrl.Name = "otbUrl";
            this.otbUrl.Size = new System.Drawing.Size(325, 29);
            this.otbUrl.TabIndex = 12;
            // 
            // olaUrl
            // 
            this.olaUrl.AutoSize = true;
            this.olaUrl.Location = new System.Drawing.Point(4, 20);
            this.olaUrl.Name = "olaUrl";
            this.olaUrl.Size = new System.Drawing.Size(32, 19);
            this.olaUrl.TabIndex = 11;
            this.olaUrl.Text = "URL";
            // 
            // olaDbName
            // 
            this.olaDbName.AutoSize = true;
            this.olaDbName.Location = new System.Drawing.Point(4, 160);
            this.olaDbName.Name = "olaDbName";
            this.olaDbName.Size = new System.Drawing.Size(62, 19);
            this.olaDbName.TabIndex = 9;
            this.olaDbName.Text = "DBName";
            // 
            // otbUserPwd
            // 
            this.otbUserPwd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.otbUserPwd.Location = new System.Drawing.Point(95, 121);
            this.otbUserPwd.Name = "otbUserPwd";
            this.otbUserPwd.PasswordChar = '*';
            this.otbUserPwd.Size = new System.Drawing.Size(228, 29);
            this.otbUserPwd.TabIndex = 8;
            // 
            // olaUserPwd
            // 
            this.olaUserPwd.AutoSize = true;
            this.olaUserPwd.Location = new System.Drawing.Point(4, 125);
            this.olaUserPwd.Name = "olaUserPwd";
            this.olaUserPwd.Size = new System.Drawing.Size(92, 19);
            this.olaUserPwd.TabIndex = 7;
            this.olaUserPwd.Text = "UserPassWord";
            // 
            // otbUserName
            // 
            this.otbUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.otbUserName.Location = new System.Drawing.Point(95, 86);
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(228, 29);
            this.otbUserName.TabIndex = 6;
            // 
            // olaUserName
            // 
            this.olaUserName.AutoSize = true;
            this.olaUserName.Location = new System.Drawing.Point(4, 90);
            this.olaUserName.Name = "olaUserName";
            this.olaUserName.Size = new System.Drawing.Size(71, 19);
            this.olaUserName.TabIndex = 5;
            this.olaUserName.Text = "UserName";
            // 
            // otbServerName
            // 
            this.otbServerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.otbServerName.Location = new System.Drawing.Point(95, 51);
            this.otbServerName.Name = "otbServerName";
            this.otbServerName.Size = new System.Drawing.Size(228, 29);
            this.otbServerName.TabIndex = 3;
            // 
            // olaServerName
            // 
            this.olaServerName.AutoSize = true;
            this.olaServerName.Location = new System.Drawing.Point(4, 55);
            this.olaServerName.Name = "olaServerName";
            this.olaServerName.Size = new System.Drawing.Size(83, 19);
            this.olaServerName.TabIndex = 2;
            this.olaServerName.Text = "ServerName";
            // 
            // ocmSave
            // 
            this.ocmSave.Location = new System.Drawing.Point(103, 274);
            this.ocmSave.Name = "ocmSave";
            this.ocmSave.Size = new System.Drawing.Size(95, 35);
            this.ocmSave.TabIndex = 4;
            this.ocmSave.Text = "SAVE";
            this.ocmSave.Click += new System.EventHandler(this.ocmSave_Click);
            // 
            // ocmCancel
            // 
            this.ocmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmCancel.Location = new System.Drawing.Point(243, 274);
            this.ocmCancel.Name = "ocmCancel";
            this.ocmCancel.Size = new System.Drawing.Size(95, 35);
            this.ocmCancel.TabIndex = 6;
            this.ocmCancel.Text = "CANCEL";
            this.ocmCancel.Click += new System.EventHandler(this.ocmCancel_Click);
            // 
            // oBackgroundWorker
            // 
            this.oBackgroundWorker.WorkerReportsProgress = true;
            this.oBackgroundWorker.WorkerSupportsCancellation = true;
            this.oBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.oBackgroundWorker_DoWork);
            this.oBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.oBackgroundWorker_ProgressChanged);
            this.oBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.oBackgroundWorker_RunWorkerCompleted);
            // 
            // wSetting
            // 
            this.AcceptButton = this.ocmSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ocmCancel;
            this.ClientSize = new System.Drawing.Size(445, 330);
            this.ControlBox = false;
            this.Controls.Add(this.ocmCancel);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.ocmSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wSetting";
            this.Resizable = false;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.wSetting_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox otbUrl;
        private MetroFramework.Controls.MetroLabel olaUrl;
        private MetroFramework.Controls.MetroLabel olaDbName;
        private MetroFramework.Controls.MetroTextBox otbUserPwd;
        private MetroFramework.Controls.MetroLabel olaUserPwd;
        private MetroFramework.Controls.MetroTextBox otbUserName;
        private MetroFramework.Controls.MetroLabel olaUserName;
        private MetroFramework.Controls.MetroTextBox otbServerName;
        private MetroFramework.Controls.MetroLabel olaServerName;
        private MetroFramework.Controls.MetroButton ocmSave;
        private MetroFramework.Controls.MetroButton ocmCancel;
        private System.Windows.Forms.Button ocmRefresh;
        private System.Windows.Forms.ComboBox ocbDbName;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
    }
}