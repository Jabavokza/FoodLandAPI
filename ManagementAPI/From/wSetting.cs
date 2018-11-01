using ManagementAPI.Modale;
using ManagementAPI.ST_Class;
using ManagementAPI.X_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementAPI.From
{
    public partial class wSetting : MetroFramework.Forms.MetroForm
    {

        private wMain oW_Main;
        private wProgressDlg oW_ProgressDlg;
        private string tDbName;
        private string tEventForBackgroundWorker;
        public wSetting(wMain poMain)
        {
            oW_Main = poMain;
            InitializeComponent();

        }
        private void wSetting_Load(object sender, EventArgs e)
        {
            W_GETxConfigDB();
        }
        private void ocmSave_Click(object sender, EventArgs e)
        {
            try
            {
                tDbName = ocbDbName.Text;//สร้างตัวแปรมารับค่าจาก Combobox (ไม่งั้นThread จะชนกับ BackgroundWorker)
                tEventForBackgroundWorker = "SeveUpdate";
                W_SETxBackgroundWorker();//เรียก BackgroundWorker ทำงาน
                oW_Main.tC_Url = otbUrl.Text;
                Close();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
            finally
            {
                tEventForBackgroundWorker = string.Empty;
            }
        }
        private void ocmRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                tEventForBackgroundWorker = "Refresh";
                W_SETxBackgroundWorker();//เรียก BackgroundWorker ทำงาน 
                ocbDbName.DisplayMember = "NAME";
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
            finally
            {
                tEventForBackgroundWorker = string.Empty;
            }
        }
        private void ocmCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private void oBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker oWorker = sender as BackgroundWorker;
            try
            {
                for (int nI = 1; nI <= 100; nI++)
                {
                    switch (nI)
                    {
                        case 100: W_SETxProgressBar(tEventForBackgroundWorker); break;
                    }
                    // Perform a time consuming operation and report progress.
                    //  Thread.Sleep(); // ปรับตัวเลขให้สอดคล้องกับ Loop ที่จะทำงาน
                    oWorker.ReportProgress(nI);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : BackgroundWorker_DoWork // " + oEx.Message);
            }
        }

        private void oBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                oW_ProgressDlg.W_SETnProgressValue = e.ProgressPercentage;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : oBackgroundWorker_ProgressChanged // " + oEx.Message);
            }
        }

        private void oBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                oW_ProgressDlg.Close();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : BackgroundWorker_RunWorkerCompleted // " + oEx.Message);
            }
        }

        private void W_SETxProgressBar(string ptPara)
        {
            try
            {
                switch (ptPara)
                {
                    case "Refresh": W_GETxDbName(); break;
                    case "SeveUpdate": W_SETxConfigDB(); break;
                }
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private void W_GETxDbName()
        {
            try
            {
                ocbDbName.DataSource = cCNSP.SP_GEToDbName(otbServerName.Text, otbUserName.Text, otbUserPwd.Text);
                //ocbDbName.DisplayMember = "NAME";
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private void W_SETxConfigDB()
        {
            cFoodLandCallAPI oFoodLandCallAPI;
            cmlConnectDB oConnectDB;
            string tUrl;
            try
            {
                var oConfigDB = new cSetting();
                tUrl = otbUrl.Text + "SETConfigDB";
                oFoodLandCallAPI = new cFoodLandCallAPI();
                oConnectDB = new cmlConnectDB();
                oConnectDB.tCML_Server = otbServerName.Text;
                oConnectDB.tCML_Database = tDbName;
                oConnectDB.tCML_Username = otbUserName.Text;
                oConnectDB.tCML_Password = otbUserPwd.Text;
                oConnectDB.tCML_Url = otbUrl.Text;
                oFoodLandCallAPI.C_SETxConfigDB(tUrl.Trim(), oConnectDB);
                oConfigDB.C_SETxSetting(oConnectDB);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private void W_SETxBackgroundWorker()
        {
            if (oBackgroundWorker.IsBusy != true)
            {
                oBackgroundWorker.RunWorkerAsync();
                oW_ProgressDlg = new wProgressDlg();
                oW_ProgressDlg.ShowDialog();
            }
        }
        private void W_GETxConfigDB()
        {
            try
            {
                var oConfigDB = new cSetting();
                var oConnectDB = new cmlConnectDB();
                oConnectDB = oConfigDB.C_GEToSetting();
                otbServerName.Text = oConnectDB.tCML_Server;
                ocbDbName.Text = oConnectDB.tCML_Database;
                otbUserName.Text = oConnectDB.tCML_Username;
                otbUserPwd.Text = oConnectDB.tCML_Password;
                otbUrl.Text = oConnectDB.tCML_Url;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wSetting : W_GETxConfigDB  //" + oEx.Message);
            }
        }
    }
}
