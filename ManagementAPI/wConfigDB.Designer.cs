namespace ManagementAPI
{
    partial class wConfigDB
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
            this.otbServerName = new System.Windows.Forms.TextBox();
            this.otbDbName = new System.Windows.Forms.TextBox();
            this.otbUserName = new System.Windows.Forms.TextBox();
            this.otbUserPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ocmSaveConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.otbCancel = new System.Windows.Forms.Button();
            this.olaUrl = new System.Windows.Forms.Label();
            this.otbUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // otbServerName
            // 
            this.otbServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbServerName.Location = new System.Drawing.Point(120, 24);
            this.otbServerName.Name = "otbServerName";
            this.otbServerName.Size = new System.Drawing.Size(280, 26);
            this.otbServerName.TabIndex = 0;
            // 
            // otbDbName
            // 
            this.otbDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbDbName.Location = new System.Drawing.Point(120, 61);
            this.otbDbName.Name = "otbDbName";
            this.otbDbName.Size = new System.Drawing.Size(280, 26);
            this.otbDbName.TabIndex = 1;
            // 
            // otbUserName
            // 
            this.otbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUserName.Location = new System.Drawing.Point(120, 103);
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(280, 26);
            this.otbUserName.TabIndex = 2;
            // 
            // otbUserPwd
            // 
            this.otbUserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUserPwd.Location = new System.Drawing.Point(120, 146);
            this.otbUserPwd.Name = "otbUserPwd";
            this.otbUserPwd.Size = new System.Drawing.Size(280, 26);
            this.otbUserPwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ServerName";
            // 
            // ocmSaveConfig
            // 
            this.ocmSaveConfig.Location = new System.Drawing.Point(91, 257);
            this.ocmSaveConfig.Name = "ocmSaveConfig";
            this.ocmSaveConfig.Size = new System.Drawing.Size(94, 43);
            this.ocmSaveConfig.TabIndex = 5;
            this.ocmSaveConfig.Text = "SAVE";
            this.ocmSaveConfig.UseVisualStyleBackColor = true;
            this.ocmSaveConfig.Click += new System.EventHandler(this.ocmSaveConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "DbName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "UserPwd";
            // 
            // otbCancel
            // 
            this.otbCancel.Location = new System.Drawing.Point(258, 257);
            this.otbCancel.Name = "otbCancel";
            this.otbCancel.Size = new System.Drawing.Size(94, 43);
            this.otbCancel.TabIndex = 10;
            this.otbCancel.Text = "CENCEL";
            this.otbCancel.UseVisualStyleBackColor = true;
            this.otbCancel.Click += new System.EventHandler(this.otbCancel_Click);
            // 
            // olaUrl
            // 
            this.olaUrl.AutoSize = true;
            this.olaUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUrl.Location = new System.Drawing.Point(12, 193);
            this.olaUrl.Name = "olaUrl";
            this.olaUrl.Size = new System.Drawing.Size(42, 20);
            this.olaUrl.TabIndex = 11;
            this.olaUrl.Text = "URL";
            // 
            // otbUrl
            // 
            this.otbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbUrl.Location = new System.Drawing.Point(60, 190);
            this.otbUrl.Name = "otbUrl";
            this.otbUrl.Size = new System.Drawing.Size(340, 26);
            this.otbUrl.TabIndex = 12;
            this.otbUrl.Text = "http://localhost:8000/api/coupon/";
            // 
            // wConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(412, 334);
            this.Controls.Add(this.otbUrl);
            this.Controls.Add(this.olaUrl);
            this.Controls.Add(this.otbCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ocmSaveConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otbUserPwd);
            this.Controls.Add(this.otbUserName);
            this.Controls.Add(this.otbDbName);
            this.Controls.Add(this.otbServerName);
            this.Name = "wConfigDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wConfigDB";
            this.Load += new System.EventHandler(this.wConfigDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox otbServerName;
        private System.Windows.Forms.TextBox otbDbName;
        private System.Windows.Forms.TextBox otbUserName;
        private System.Windows.Forms.TextBox otbUserPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ocmSaveConfig;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button otbCancel;
        private System.Windows.Forms.Label olaUrl;
        private System.Windows.Forms.TextBox otbUrl;
    }
}