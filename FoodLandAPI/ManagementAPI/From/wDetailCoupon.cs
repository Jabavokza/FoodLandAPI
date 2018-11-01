
using ManagementAPI.Modale;
using ManagementAPI.X_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementAPI.From
{
    public partial class wDetailCoupon : MetroFramework.Forms.MetroForm
    {
        private wMain oMain;
        private cmlCpnData oCpnData;
        private cSetting oConfigDB;
        private cFoodLandCallAPI oFoodLandCallAPI;
        private cmlCpnUseStaUpd oCpnUseStaUpd;
        private wProgressDlg oW_ProgressDlg;
        public string tC_Url;
        string tCpnUseSta;
        public wDetailCoupon(wMain poMain, cmlCpnData poCpnData)
        {
            oMain = poMain;
            oCpnData = poCpnData;
            InitializeComponent();
        }

        private void wDetailCoupon_Load(object sender, EventArgs e)
        {
            W_SETxCpnData();
            if (ocbCpnUseSta.Text.Equals("หมดอายุ"))
            {
                ocbCpnUseSta.Enabled = false;
                ocmUpdate.Enabled = false;
            }
        }

        private void ocmUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                tCpnUseSta = ocbCpnUseSta.Text;
                W_SETxBackgroundWorker();
                if (oMain.tSearchBtnSta == "SearchCpnCode")
                {
                    oMain.ocmSearchCpnCode.PerformClick(); //เมื่ออัพเดตเสร็จ ทำการอัพเดตข้อมูลดาต้ากริดใหม่ด้วยการคลิกปุ่มSearchCpnCode อัตโนมัติ
                } else if (oMain.tSearchBtnSta == "SearchCpnGroup")
                {
                    oMain.ocmSearchCpnGroup.PerformClick();//เมื่ออัพเดตเสร็จ ทำการอัพเดตข้อมูลดาต้ากริดใหม่ด้วยการคลิกปุ่มSearchCpnGroup อัตโนมัติ
                } 
                Close();
                // MessageBox.Show(tResult.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wDetailCoupon : ocmUpdate_Click ///" + oEx.Message);
            }

        }

        private void ocmCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void W_SETxCpnData()
        {
            DateTime oCpnExp;
            try
            {
                otbStmCode.Text = oCpnData.tCML_StmCode;
                otbTmnNum.Text = oCpnData.tCML_TmnNum;
                otbDateIns.Text = oCpnData.tCML_DateIns;
                otbCpnCode.Text = oCpnData.tCML_CpnCode;
                otbCpnAmt.Text = oCpnData.tCML_CpnAmt;
                otbCpnExp.Text = oCpnData.tCML_CpnExp;
                oCpnExp = DateTime.Parse(oCpnData.tCML_CpnExp);
                if (oCpnExp < DateTime.Now)
                {
                    ocbCpnUseSta.Text = "หมดอายุ";
                }
                else
                {
                    switch (oCpnData.tCML_CpnUseSta.ToString())
                    {
                        case "0": ocbCpnUseSta.Text = "ใช้งานได้"; break;
                        case "1": ocbCpnUseSta.Text = "ใช้งานไปแล้ว"; break;
                        case "2": ocbCpnUseSta.Text = "ยกเลิก"; break;
                    }
                }
                otbWhoIns.Text = oCpnData.tCML_WhoIns;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wDetailCoupon : W_SETxCpnData ///" + oEx.Message);
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
                        case 100: W_GETxUpdate(); break;
                    }
                    // Perform a time consuming operation and report progress.
                    //  Thread.Sleep(); // ปรับตัวเลขให้สอดคล้องกับ Loop ที่จะทำงาน
                    oWorker.ReportProgress(nI);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wDetailCoupon : BackgroundWorker_DoWork // " + oEx.Message);
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
                MessageBox.Show("wDetailCoupon : oBackgroundWorker_ProgressChanged // " + oEx.Message);
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
                MessageBox.Show("wDetailCoupon : BackgroundWorker_RunWorkerCompleted // " + oEx.Message);
            }
        }

        private void W_GETxUpdate()
        {
            try
            {
                oConfigDB = new cSetting();
                oFoodLandCallAPI = new cFoodLandCallAPI();

                tC_Url = oConfigDB.C_GEToSetting().tCML_Url;
                string tUrl = tC_Url + "CpnUseStaUpd";
                switch (tCpnUseSta)
                {
                    case "ใช้งานได้": tCpnUseSta = "0"; break;
                    case "ใช้งานไปแล้ว": tCpnUseSta = "1"; break;
                    case "ยกเลิก": tCpnUseSta = "2"; break;
                    case "หมดอายุ": return;
                }
                oCpnUseStaUpd = new cmlCpnUseStaUpd
                {
                    tCML_CpnCode = otbCpnCode.Text,
                    tCML_CpnUseSta = tCpnUseSta
                };
                var tResult = oFoodLandCallAPI.C_SETxCpnUseStaUpd(tUrl, oCpnUseStaUpd);
            }
            catch (Exception)
            {

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
    }
}
