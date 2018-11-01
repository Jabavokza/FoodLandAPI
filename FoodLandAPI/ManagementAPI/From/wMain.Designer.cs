namespace ManagementAPI.From
{
    partial class wMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wMain));
            this.olaSearchStmCode = new MetroFramework.Controls.MetroLabel();
            this.otbSearchStmCode = new MetroFramework.Controls.MetroTextBox();
            this.opnSearchGroup = new MetroFramework.Controls.MetroPanel();
            this.ocmSearchCpnGroup = new System.Windows.Forms.Button();
            this.ocbSearchCpnSta = new MetroFramework.Controls.MetroComboBox();
            this.olaCpnSta = new MetroFramework.Controls.MetroLabel();
            this.otaTabControl = new MetroFramework.Controls.MetroTabControl();
            this.otaTebMain = new MetroFramework.Controls.MetroTabPage();
            this.ogdDataCoupon = new System.Windows.Forms.DataGridView();
            this.opnSearchCpnCode = new MetroFramework.Controls.MetroPanel();
            this.ocmSearchCpnCode = new System.Windows.Forms.Button();
            this.otbSearchCpnCode = new MetroFramework.Controls.MetroTextBox();
            this.olaSearchCpnCode = new MetroFramework.Controls.MetroLabel();
            this.ocmSetting = new System.Windows.Forms.Button();
            this.ocmClose = new System.Windows.Forms.Button();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ocmLogin = new System.Windows.Forms.Button();
            this.opnSearchGroup.SuspendLayout();
            this.otaTabControl.SuspendLayout();
            this.otaTebMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataCoupon)).BeginInit();
            this.opnSearchCpnCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // olaSearchStmCode
            // 
            this.olaSearchStmCode.AutoSize = true;
            this.olaSearchStmCode.Location = new System.Drawing.Point(3, 12);
            this.olaSearchStmCode.Name = "olaSearchStmCode";
            this.olaSearchStmCode.Size = new System.Drawing.Size(59, 19);
            this.olaSearchStmCode.TabIndex = 41;
            this.olaSearchStmCode.Text = "รหัสสาขา";
            // 
            // otbSearchStmCode
            // 
            this.otbSearchStmCode.Enabled = false;
            this.otbSearchStmCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.otbSearchStmCode.Location = new System.Drawing.Point(63, 7);
            this.otbSearchStmCode.MaxLength = 6;
            this.otbSearchStmCode.Name = "otbSearchStmCode";
            this.otbSearchStmCode.Size = new System.Drawing.Size(86, 29);
            this.otbSearchStmCode.TabIndex = 42;
            this.otbSearchStmCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otbSearchStmCode_KeyPress);
            // 
            // opnSearchGroup
            // 
            this.opnSearchGroup.BackColor = System.Drawing.SystemColors.Control;
            this.opnSearchGroup.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.opnSearchGroup.Controls.Add(this.ocmSearchCpnGroup);
            this.opnSearchGroup.Controls.Add(this.ocbSearchCpnSta);
            this.opnSearchGroup.Controls.Add(this.olaCpnSta);
            this.opnSearchGroup.Controls.Add(this.otbSearchStmCode);
            this.opnSearchGroup.Controls.Add(this.olaSearchStmCode);
            this.opnSearchGroup.HorizontalScrollbarBarColor = true;
            this.opnSearchGroup.HorizontalScrollbarHighlightOnWheel = false;
            this.opnSearchGroup.HorizontalScrollbarSize = 10;
            this.opnSearchGroup.Location = new System.Drawing.Point(4, 19);
            this.opnSearchGroup.Name = "opnSearchGroup";
            this.opnSearchGroup.Size = new System.Drawing.Size(427, 44);
            this.opnSearchGroup.Style = MetroFramework.MetroColorStyle.Black;
            this.opnSearchGroup.TabIndex = 43;
            this.opnSearchGroup.Theme = MetroFramework.MetroThemeStyle.Light;
            this.opnSearchGroup.VerticalScrollbarBarColor = true;
            this.opnSearchGroup.VerticalScrollbarHighlightOnWheel = false;
            this.opnSearchGroup.VerticalScrollbarSize = 10;
            // 
            // ocmSearchCpnGroup
            // 
            this.ocmSearchCpnGroup.BackColor = System.Drawing.Color.Transparent;
            this.ocmSearchCpnGroup.Enabled = false;
            this.ocmSearchCpnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSearchCpnGroup.Image = ((System.Drawing.Image)(resources.GetObject("ocmSearchCpnGroup.Image")));
            this.ocmSearchCpnGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmSearchCpnGroup.Location = new System.Drawing.Point(343, 6);
            this.ocmSearchCpnGroup.Name = "ocmSearchCpnGroup";
            this.ocmSearchCpnGroup.Size = new System.Drawing.Size(75, 31);
            this.ocmSearchCpnGroup.TabIndex = 48;
            this.ocmSearchCpnGroup.Text = "ค้นหา";
            this.ocmSearchCpnGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmSearchCpnGroup.UseVisualStyleBackColor = false;
            this.ocmSearchCpnGroup.Click += new System.EventHandler(this.ocmSearchCpnGroup_Click);
            // 
            // ocbSearchCpnSta
            // 
            this.ocbSearchCpnSta.AccessibleName = "";
            this.ocbSearchCpnSta.Enabled = false;
            this.ocbSearchCpnSta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ocbSearchCpnSta.FormattingEnabled = true;
            this.ocbSearchCpnSta.ItemHeight = 23;
            this.ocbSearchCpnSta.Items.AddRange(new object[] {
            "NULL",
            "ใช้งานได้",
            "ใช้งานไปแล้ว",
            "ยกเลิก",
            "หมดอายุ",
            "ทั้งหมด"});
            this.ocbSearchCpnSta.Location = new System.Drawing.Point(231, 7);
            this.ocbSearchCpnSta.Name = "ocbSearchCpnSta";
            this.ocbSearchCpnSta.Size = new System.Drawing.Size(106, 29);
            this.ocbSearchCpnSta.TabIndex = 44;
            this.ocbSearchCpnSta.SelectedIndexChanged += new System.EventHandler(this.ocbSearchCpnSta_SelectedIndexChanged);
            // 
            // olaCpnSta
            // 
            this.olaCpnSta.AutoSize = true;
            this.olaCpnSta.Location = new System.Drawing.Point(157, 12);
            this.olaCpnSta.Name = "olaCpnSta";
            this.olaCpnSta.Size = new System.Drawing.Size(72, 19);
            this.olaCpnSta.TabIndex = 43;
            this.olaCpnSta.Text = "สถานะคูปอง";
            // 
            // otaTabControl
            // 
            this.otaTabControl.Controls.Add(this.otaTebMain);
            this.otaTabControl.Location = new System.Drawing.Point(112, 52);
            this.otaTabControl.Name = "otaTabControl";
            this.otaTabControl.SelectedIndex = 0;
            this.otaTabControl.Size = new System.Drawing.Size(896, 503);
            this.otaTabControl.TabIndex = 44;
            // 
            // otaTebMain
            // 
            this.otaTebMain.BackColor = System.Drawing.SystemColors.Control;
            this.otaTebMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otaTebMain.Controls.Add(this.ogdDataCoupon);
            this.otaTebMain.Controls.Add(this.opnSearchCpnCode);
            this.otaTebMain.Controls.Add(this.opnSearchGroup);
            this.otaTebMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otaTebMain.HorizontalScrollbarBarColor = true;
            this.otaTebMain.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.otaTebMain.Location = new System.Drawing.Point(4, 35);
            this.otaTebMain.Name = "otaTebMain";
            this.otaTebMain.Size = new System.Drawing.Size(888, 464);
            this.otaTebMain.TabIndex = 0;
            this.otaTebMain.Text = "หน้าหลัก";
            this.otaTebMain.VerticalScrollbarBarColor = true;
            // 
            // ogdDataCoupon
            // 
            this.ogdDataCoupon.AllowUserToAddRows = false;
            this.ogdDataCoupon.AllowUserToDeleteRows = false;
            this.ogdDataCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdDataCoupon.Enabled = false;
            this.ogdDataCoupon.Location = new System.Drawing.Point(3, 69);
            this.ogdDataCoupon.Name = "ogdDataCoupon";
            this.ogdDataCoupon.ReadOnly = true;
            this.ogdDataCoupon.Size = new System.Drawing.Size(878, 389);
            this.ogdDataCoupon.TabIndex = 48;
            this.ogdDataCoupon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogdDataCoupon_CellDoubleClick);
            // 
            // opnSearchCpnCode
            // 
            this.opnSearchCpnCode.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.opnSearchCpnCode.Controls.Add(this.ocmSearchCpnCode);
            this.opnSearchCpnCode.Controls.Add(this.otbSearchCpnCode);
            this.opnSearchCpnCode.Controls.Add(this.olaSearchCpnCode);
            this.opnSearchCpnCode.HorizontalScrollbarBarColor = true;
            this.opnSearchCpnCode.HorizontalScrollbarHighlightOnWheel = false;
            this.opnSearchCpnCode.HorizontalScrollbarSize = 10;
            this.opnSearchCpnCode.Location = new System.Drawing.Point(463, 19);
            this.opnSearchCpnCode.Name = "opnSearchCpnCode";
            this.opnSearchCpnCode.Size = new System.Drawing.Size(414, 44);
            this.opnSearchCpnCode.Style = MetroFramework.MetroColorStyle.Blue;
            this.opnSearchCpnCode.TabIndex = 46;
            this.opnSearchCpnCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.opnSearchCpnCode.VerticalScrollbarBarColor = true;
            this.opnSearchCpnCode.VerticalScrollbarHighlightOnWheel = false;
            this.opnSearchCpnCode.VerticalScrollbarSize = 10;
            // 
            // ocmSearchCpnCode
            // 
            this.ocmSearchCpnCode.BackColor = System.Drawing.Color.Transparent;
            this.ocmSearchCpnCode.Enabled = false;
            this.ocmSearchCpnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSearchCpnCode.Image = ((System.Drawing.Image)(resources.GetObject("ocmSearchCpnCode.Image")));
            this.ocmSearchCpnCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmSearchCpnCode.Location = new System.Drawing.Point(326, 7);
            this.ocmSearchCpnCode.Name = "ocmSearchCpnCode";
            this.ocmSearchCpnCode.Size = new System.Drawing.Size(75, 31);
            this.ocmSearchCpnCode.TabIndex = 49;
            this.ocmSearchCpnCode.Text = "ค้นหา";
            this.ocmSearchCpnCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmSearchCpnCode.UseVisualStyleBackColor = false;
            this.ocmSearchCpnCode.Click += new System.EventHandler(this.ocmSearchCpnCode_Click);
            // 
            // otbSearchCpnCode
            // 
            this.otbSearchCpnCode.Enabled = false;
            this.otbSearchCpnCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.otbSearchCpnCode.Location = new System.Drawing.Point(113, 8);
            this.otbSearchCpnCode.MaxLength = 24;
            this.otbSearchCpnCode.Name = "otbSearchCpnCode";
            this.otbSearchCpnCode.Size = new System.Drawing.Size(203, 29);
            this.otbSearchCpnCode.TabIndex = 45;
            this.otbSearchCpnCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otbSearchCpnCode_KeyPress);
            // 
            // olaSearchCpnCode
            // 
            this.olaSearchCpnCode.AutoSize = true;
            this.olaSearchCpnCode.Location = new System.Drawing.Point(5, 11);
            this.olaSearchCpnCode.Name = "olaSearchCpnCode";
            this.olaSearchCpnCode.Size = new System.Drawing.Size(108, 19);
            this.olaSearchCpnCode.TabIndex = 44;
            this.olaSearchCpnCode.Text = "รหัสหมายเลขคูปอง";
            // 
            // ocmSetting
            // 
            this.ocmSetting.Enabled = false;
            this.ocmSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSetting.Image = ((System.Drawing.Image)(resources.GetObject("ocmSetting.Image")));
            this.ocmSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmSetting.Location = new System.Drawing.Point(9, 127);
            this.ocmSetting.Name = "ocmSetting";
            this.ocmSetting.Size = new System.Drawing.Size(101, 38);
            this.ocmSetting.TabIndex = 47;
            this.ocmSetting.Text = "ตั้งค่า";
            this.ocmSetting.UseVisualStyleBackColor = true;
            this.ocmSetting.Click += new System.EventHandler(this.ocmSetting_Click);
            // 
            // ocmClose
            // 
            this.ocmClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmClose.Image = ((System.Drawing.Image)(resources.GetObject("ocmClose.Image")));
            this.ocmClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmClose.Location = new System.Drawing.Point(9, 171);
            this.ocmClose.Name = "ocmClose";
            this.ocmClose.Size = new System.Drawing.Size(101, 38);
            this.ocmClose.TabIndex = 48;
            this.ocmClose.Text = "ปิดโปรแกรม";
            this.ocmClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmClose.UseVisualStyleBackColor = true;
            this.ocmClose.Click += new System.EventHandler(this.ocmClose_Click);
            // 
            // oBackgroundWorker
            // 
            this.oBackgroundWorker.WorkerReportsProgress = true;
            this.oBackgroundWorker.WorkerSupportsCancellation = true;
            this.oBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.oBackgroundWorker_DoWork);
            this.oBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.oBackgroundWorker_ProgressChanged);
            this.oBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.oBackgroundWorker_RunWorkerCompleted);
            // 
            // ocmLogin
            // 
            this.ocmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmLogin.Image = ((System.Drawing.Image)(resources.GetObject("ocmLogin.Image")));
            this.ocmLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ocmLogin.Location = new System.Drawing.Point(9, 83);
            this.ocmLogin.Name = "ocmLogin";
            this.ocmLogin.Size = new System.Drawing.Size(101, 38);
            this.ocmLogin.TabIndex = 49;
            this.ocmLogin.Text = "เข้าระบบ";
            this.ocmLogin.UseVisualStyleBackColor = true;
            this.ocmLogin.Click += new System.EventHandler(this.ocmLogin_Click);
            // 
            // wMain
            // 
            this.AcceptButton = this.ocmLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ocmClose;
            this.ClientSize = new System.Drawing.Size(1015, 558);
            this.Controls.Add(this.ocmLogin);
            this.Controls.Add(this.ocmClose);
            this.Controls.Add(this.ocmSetting);
            this.Controls.Add(this.otaTabControl);
            this.MaximizeBox = false;
            this.Name = "wMain";
            this.Resizable = false;
            this.Text = "Management API";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Main_Load);
            this.opnSearchGroup.ResumeLayout(false);
            this.opnSearchGroup.PerformLayout();
            this.otaTabControl.ResumeLayout(false);
            this.otaTebMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataCoupon)).EndInit();
            this.opnSearchCpnCode.ResumeLayout(false);
            this.opnSearchCpnCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel olaSearchStmCode;
        private MetroFramework.Controls.MetroPanel opnSearchGroup;
        private MetroFramework.Controls.MetroTabControl otaTabControl;
        private MetroFramework.Controls.MetroTabPage otaTebMain;
        private MetroFramework.Controls.MetroLabel olaCpnSta;
        private MetroFramework.Controls.MetroPanel opnSearchCpnCode;
        private MetroFramework.Controls.MetroLabel olaSearchCpnCode;
        public System.Windows.Forms.Button ocmSetting;
        public System.Windows.Forms.Button ocmClose;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
        public System.Windows.Forms.Button ocmLogin;
        public MetroFramework.Controls.MetroTextBox otbSearchStmCode;
        public MetroFramework.Controls.MetroComboBox ocbSearchCpnSta;
        public MetroFramework.Controls.MetroTextBox otbSearchCpnCode;
        public System.Windows.Forms.DataGridView ogdDataCoupon;
        public System.Windows.Forms.Button ocmSearchCpnGroup;
        public System.Windows.Forms.Button ocmSearchCpnCode;
    }
}