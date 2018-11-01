using ManagementAPI.From;
using ManagementAPI.Modale;
using ManagementAPI.ST_Class;
using ManagementAPI.X_Class;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ManagementAPI.From
{
    public partial class wMain : MetroFramework.Forms.MetroForm
    {
        private cFoodLandCallAPI oFoodLandCallAPI;
        private wProgressDlg oW_ProgressDlg;
        private DataTable oCpnData;
        public string tC_Url;
        private string tEventForBackgroundWorker;
        private string tSearchCpnSta;
        public string tSearchBtnSta;

        public wMain()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                cSetting oConfigDB = new cSetting();
                tC_Url = oConfigDB.C_GEToSetting().tCML_Url;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private void ocmLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var oLogin = new wLogin(this);
                oLogin.ShowDialog();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmLogin_Click ///" + oEx.Message);
            }
        }
        private void ocmSetting_Click(object sender, EventArgs e)
        {
            try
            {
                wSetting oSetting = new wSetting(this);
                oSetting.ShowDialog();
            }
            catch { }
        }
        private void ocmSearchCpnCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (otbSearchCpnCode.Text == "")
                {
                    ogdDataCoupon.DataSource = null;
                    return;
                }
                //  cCNVB.tC_ButtonSearchSta = "ButtonSearchCpnCode";

                tEventForBackgroundWorker = "SearchCpnCode";
                tSearchBtnSta = "SearchCpnCode";
                W_SETxBackgroundWorker();
                W_CHKxAlertByDataNull();
                ogdDataCoupon.DataSource = oCpnData;
                W_SETxDataGridView();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSearchCpnCode_Click //" + oEx.Message);
            }
            finally
            {
                tEventForBackgroundWorker = string.Empty;
                oCpnData = null;
            }
        }
        private void ocmSearchCpnGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (otbSearchStmCode.Text == "" && ocbSearchCpnSta.Text == "")
                {
                    return;
                }
                //  cCNVB.tC_ButtonSearchSta = "ButtonSearchCpnGroup";
                tSearchCpnSta = ocbSearchCpnSta.Text;
                tEventForBackgroundWorker = "SearchCpnGroup";
                tSearchBtnSta = "SearchCpnGroup";
                W_SETxBackgroundWorker();
                W_CHKxAlertByDataNull();
                ogdDataCoupon.DataSource = oCpnData;
                W_SETxDataGridView();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSearchCpnGroup_Click //" + oEx.Message);
            }
            finally
            {
                tEventForBackgroundWorker = string.Empty;
                oCpnData = null;
            }
        }
        private void ocmClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }  
        private void otbSearchStmCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AcceptButton = ocmSearchCpnGroup;
            if (otbSearchStmCode.Text != "")
            {
                ocbSearchCpnSta.Text = "NULL";
            }
        }
        private void ocbSearchCpnSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = ocmSearchCpnGroup;
            if (ocbSearchCpnSta.Text == "ทั้งหมด")
            {
                otbSearchStmCode.Text = "";
            }
        }
        private void otbSearchCpnCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AcceptButton = ocmSearchCpnCode;
        }
        private void ogdDataCoupon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               // otbSearchCpnCode.Text = ogdDataCoupon.CurrentRow.Cells["FTCpnCode"].Value.ToString();
                var oCpnData = new cmlCpnData
                {
                    tCML_StmCode = ogdDataCoupon.CurrentRow.Cells["FTStmCode"].Value.ToString(),
                    tCML_TmnNum = ogdDataCoupon.CurrentRow.Cells["FTTmnNum"].Value.ToString(),
                    tCML_DateIns = ogdDataCoupon.CurrentRow.Cells["FDDateIns"].Value.ToString(),
                    tCML_CpnCode = ogdDataCoupon.CurrentRow.Cells["FTCpnCode"].Value.ToString(),
                    tCML_CpnAmt = ogdDataCoupon.CurrentRow.Cells["FCCpnAmt"].Value.ToString(),
                    tCML_CpnExp = ogdDataCoupon.CurrentRow.Cells["FDCpnExp"].Value.ToString(),
                    tCML_CpnUseSta = ogdDataCoupon.CurrentRow.Cells["FTCpnUseSta"].Value.ToString(),
                    tCML_WhoIns = ogdDataCoupon.CurrentRow.Cells["FTWhoIns"].Value.ToString()
                };
                var oDetailCoupon = new wDetailCoupon(this, oCpnData);
                oDetailCoupon.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
        private void oBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var oWorker = sender as BackgroundWorker;
                for (int nI = 1; nI <= 100; nI++)
                {
                    switch (nI)
                    {
                        case 100: W_SETxProgressBar(tEventForBackgroundWorker); break;//มีงานเดียว ใช้ 100ไปเลย 
                    }
                    // Perform a time consuming operation and report progress.
                    //  Thread.Sleep(); // ปรับตัวเลขให้สอดคล้องกับ Loop ที่จะทำงาน
                    oWorker.ReportProgress(nI);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : BackgroundWorker_DoWork // " + oEx.Message);
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
                MessageBox.Show("wMain : BackgroundWorker_ProgressChanged // " + oEx.Message);
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
                MessageBox.Show("wMain : BackgroundWorker_RunWorkerCompleted // " + oEx.Message);
            }
        }
        private void W_SETxDataGridView()
        {
            try
            {
                ogdDataCoupon.Columns["FTStmCode"].HeaderText = "สาขา";
                ogdDataCoupon.Columns["FTStmCode"].Width = 50;
                ogdDataCoupon.Columns["FTTmnNum"].HeaderText = "หมายเลขเครื่อง";
                ogdDataCoupon.Columns["FTTmnNum"].Width = 110;
                ogdDataCoupon.Columns["FDDateIns"].HeaderText = "วันที่ออกคูปอง";
                ogdDataCoupon.Columns["FDDateIns"].Width = 100;
                ogdDataCoupon.Columns["FTCpnCode"].HeaderText = "หมายเลขคูปอง";
                ogdDataCoupon.Columns["FTCpnCode"].Width = 160;
                ogdDataCoupon.Columns["FCCpnAmt"].HeaderText = "มูลค่าคูปอง";
                ogdDataCoupon.Columns["FCCpnAmt"].Width = 120;
                ogdDataCoupon.Columns["FCCpnAmt"].DefaultCellStyle.Format = ("#,##0.00");
                ogdDataCoupon.Columns["FDCpnExp"].HeaderText = "วันที่หมดอายุ";
                ogdDataCoupon.Columns["FDCpnExp"].Width = 100;
                ogdDataCoupon.Columns["FTCpnUseSta"].HeaderText = "สถานะคูปอง";
                ogdDataCoupon.Columns["FTCpnUseSta"].Width = 90;
                ogdDataCoupon.Columns["FTWhoIns"].HeaderText = "ชื่อแคชเชียร์";
                ogdDataCoupon.Columns["FTWhoIns"].Width = 100;
            }
            catch { }
        }
        private void W_SETxProgressBar(string ptPara)
        {
            try
            {
                switch (ptPara)
                {
                    case "SearchCpnCode": W_GETxSearchCpnByCode(); break;
                    case "SearchCpnGroup": W_GETxSearchCpnGroup(); break;
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_SETxProgressBar ///" + oEx.Message);
            }
        }
        private void W_GETxSearchCpnByCode()
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                var tUrl = tC_Url + "CpnSearchByCpnCode";
                var oCouponCode = new cmlCouponCode
                {
                    tCML_CpnCode = otbSearchCpnCode.Text
                };
                oCpnData = oFoodLandCallAPI.C_GEToDataCpnByCode(tUrl.Trim(), oCouponCode);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_GETxSearchCpnByCode ///" + oEx.Message);
            }
        }
        private void W_GETxSearchCpnGroup()
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                var oCouponReq = new cmlCpnSearchReq
                {
                    tCML_StmCode = otbSearchStmCode.Text,
                    tCML_CpnUseSta = tSearchCpnSta
                };
                if (oCouponReq.tCML_CpnUseSta.Equals("ทั้งหมด"))
                {
                    string tUrl = tC_Url + "CpnStatusAll";
                    oCpnData = oFoodLandCallAPI.C_GEToDataCpnStatusAll(tUrl.Trim());
                }
                else if (oCouponReq.tCML_CpnUseSta.Equals("NULL"))
                {
                    oCouponReq.tCML_CpnUseSta = "";
                    string tUrl = tC_Url + "CpnSearchByGroup";
                    oCpnData = oFoodLandCallAPI.C_GEToDataCpnByGroup(tUrl.Trim(), oCouponReq);
                }
                else
                {
                    string tUrl = tC_Url + "CpnSearchByGroup";
                    oCpnData = oFoodLandCallAPI.C_GEToDataCpnByGroup(tUrl.Trim(), oCouponReq);
                }
            }
            catch (WebException oEx)
            {
                int nResCode = (int)oEx.Status;

                if (oEx.Status == WebExceptionStatus.ProtocolError || oEx.Status == WebExceptionStatus.ConnectFailure || oEx.Status == WebExceptionStatus.KeepAliveFailure)
                {
                    var response = oEx.Response as HttpWebResponse;
                    if (response != null)
                    {
                        nResCode = (int)response.StatusCode;
                        if (nResCode == 500)
                        {
                            MessageBox.Show("wMain : W_GETxSearchCpnGroup ///" + oEx.Message + "ไม่สามารถติดต่อฐานข้อมูลได้ หรือฐานข้อมูลไม่ถูกต้อง กรุณาตรวจสอบการตั้งค่า");
                        }
                    }                 
                }
                else
                {
                    MessageBox.Show("wMain : W_GETxSearchCpnGroup ///" + oEx.Message);
                }            
            }
        }
        private void W_SETxBackgroundWorker()
        {
            try
            {
                if (oBackgroundWorker.IsBusy != true)
                {
                    oBackgroundWorker.RunWorkerAsync();
                    oW_ProgressDlg = new wProgressDlg();
                    oW_ProgressDlg.ShowDialog();
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : W_SETxBackgroundWorker ///" + oEx.Message);
            }

        }
        private void W_CHKxAlertByDataNull()
        {
            try
            {
                if (oCpnData.Rows.Count <= 0)
                {
                    MessageBox.Show("ไม่พบข้อมูล", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception oEx)
            {
                // MessageBox.Show("wMain : W_CHKxAlietByDataNull ///" + oEx.Message);
            }
        }
       
    }
}
