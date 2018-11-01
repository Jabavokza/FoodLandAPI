using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementAPI.From
{
    public partial class wLogin : MetroFramework.Forms.MetroForm
    {
        private wMain oMain;
        public wLogin(wMain poMain)
        {
            oMain = poMain;
            InitializeComponent();
        }
        private void wLogin_Load(object sender, EventArgs e)
        {
           
        }
        private void ocmOK_Click(object sender, EventArgs e)
        {
            string tUser, tPwd;
            string tXMLPath = string.Empty;
            try
            {
                if (otbUserName.Text == string.Empty)
                {
                    otbUserName.Focus();
                    return;

                }
                if (otbUserPwd.Text == string.Empty)
                {
                    otbUserPwd.Focus();
                    return;
                }

                tXMLPath = "Setting.xml";

                var oXElement = XElement.Load(tXMLPath);

                tUser = oXElement.Element("UserName").Value;

                tPwd = oXElement.Element("UserPwd").Value;


                if (tUser == otbUserName.Text && tPwd == otbUserPwd.Text)
                {
                    Hide();
                    oMain.ocmLogin.Enabled = false;
                    oMain.ocmSetting.Enabled = true;
                    oMain.otbSearchStmCode.Enabled = true;
                    oMain.ocbSearchCpnSta.Enabled = true;
                    oMain.ocmSearchCpnGroup.Enabled = true;
                    oMain.otbSearchCpnCode.Enabled = true;
                    oMain.ocmSearchCpnCode.Enabled = true;
                    oMain.ogdDataCoupon.Enabled = true;
                    oMain.ocmSearchCpnCode.BackColor = ColorTranslator.FromHtml("#66CCFF");
                    oMain.ocmSearchCpnGroup.BackColor = ColorTranslator.FromHtml("#66CCFF");
                }
                else
                {
                    MessageBox.Show("User หรือ Password ผิด", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wLogin : ocmOK_Click ///"+oEx.Message);
            }
        }

        private void ocmCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch {}
        }
        //private void otbUserName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        otbUserPwd.Focus();
        //    }
        //}
    }
}
