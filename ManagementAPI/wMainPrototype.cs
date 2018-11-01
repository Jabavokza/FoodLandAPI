
using ManagementAPI.Modale;
using ManagementAPI.ST_Class;
using ManagementAPI.X_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementAPI
{
    public partial class wMainPrototype : Form
    {

        private cFoodLandCallAPI oFoodLandCallAPI;
        public string tC_Url;
       
        public wMainPrototype()
        {
            InitializeComponent();
        }
        private void wMain_Load(object sender, EventArgs e)
        {
            try
            {

                var oConfigDB = new cSetting();
                otbUrl.Text = oConfigDB.C_GEToSetting().tCML_Url;
                tC_Url = oConfigDB.C_GEToSetting().tCML_Url;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

        private void ocmCreate_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                cmlCouponRes oCouponRes = new cmlCouponRes();
                cmlCouponReq oCouponReq = new cmlCouponReq();
                otbUrl.Text = tC_Url + "Create";
                oCouponReq.tCML_WhoUpd = otbWhoUpd.Text;
                oCouponReq.tCML_WhoIns = otbWhoIns.Text;
                oCouponReq.tCML_StmCode = otbStmCode.Text;
                oCouponReq.tCML_TmnNum = otbTmnNum.Text;
                oCouponReq.tCML_CpnCode = otbCpnCode.Text;
                oCouponReq.tCML_CpnExp = otbCpnExp.Text;
                oCouponReq.tCML_CpnAmt = otbCpnAmt.Text;

                oCouponRes = oFoodLandCallAPI.C_SEToCreateCoupon(otbUrl.Text.Trim(), oCouponReq);
                otbResult.Text = oCouponRes.tCML_CpnMSg;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmCreate_Click//" + oEx.Message);
            }
        }
        private void ocmSale_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                cmlCouponRes oCouponRes = new cmlCouponRes();
                otbUrl.Text = otbUrl.Text = tC_Url + "Sale";
                oCouponRes = oFoodLandCallAPI.C_SEToCouponSta(otbUrl.Text.Trim(), otbSendCoupon.Text);
                otbStatusCode.Text = oCouponRes.tCML_StatusCode;
                otbStatusDescTH.Text = oCouponRes.tCML_StatusDescTH;
                otbStatusDescEN.Text = oCouponRes.tCML_StatusDescEN;
                otbPrintDesc.Text = oCouponRes.tCML_PrintDesc;
                otbRefCode.Text = oCouponRes.tCML_RefCode;
                otbTranDateTime.Text = oCouponRes.tCML_TranDateTime;
                otbCpnAmtRes.Text = oCouponRes.tCML_CpnAmt;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSale_Click//" + oEx.Message);
            }
        }

        private void ocmRefund_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                cmlCouponRes oCouponRes = new cmlCouponRes();
                otbUrl.Text = otbUrl.Text = tC_Url + "Refund";
                oCouponRes = oFoodLandCallAPI.C_SEToCouponSta(otbUrl.Text.Trim(), otbSendCoupon.Text);
                otbStatusCode.Text = oCouponRes.tCML_StatusCode;
                otbStatusDescTH.Text = oCouponRes.tCML_StatusDescTH;
                otbStatusDescEN.Text = oCouponRes.tCML_StatusDescEN;
                otbPrintDesc.Text = oCouponRes.tCML_PrintDesc;
                otbRefCode.Text = oCouponRes.tCML_RefCode;
                otbTranDateTime.Text = oCouponRes.tCML_TranDateTime;
                otbCpnAmtRes.Text = oCouponRes.tCML_CpnAmt;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmRefund_Click//" + oEx.Message);
            }
        }

        private void ocmVoid_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                cmlCouponRes oCouponRes = new cmlCouponRes();
                otbUrl.Text = otbUrl.Text = tC_Url + "Void".Trim();
                oCouponRes = oFoodLandCallAPI.C_SEToCouponSta(otbUrl.Text, otbSendCoupon.Text);
                otbStatusCode.Text = oCouponRes.tCML_StatusCode;
                otbStatusDescTH.Text = oCouponRes.tCML_StatusDescTH;
                otbStatusDescEN.Text = oCouponRes.tCML_StatusDescEN;
                otbPrintDesc.Text = oCouponRes.tCML_PrintDesc;
                otbRefCode.Text = oCouponRes.tCML_RefCode;
                otbTranDateTime.Text = oCouponRes.tCML_TranDateTime;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmVoid_Click//" + oEx.Message);
            }
        }

        private void ocmGetAllCoupon_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                var tUrl = otbUrl.Text = tC_Url + "CpnStatusAll";
                var oCpnStatusAll = oFoodLandCallAPI.C_GEToDataCpnStatusAll(tUrl.Trim());
                ogdDataCoupon.DataSource = oCpnStatusAll;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmGetAllCoupon_Click//" + oEx.Message);
            }
        }

        private void ocmSetting_Click(object sender, EventArgs e)
        {
            try
            {
                //wSetting oSetting = new wSetting();
                //oSetting.Show();
            }
            catch
            {

            }
           
        }

        private void ogdDataCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                otbSendCoupon.Text = ogdDataCoupon.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {

            }
        }

        private void ocmSearchCpnCode_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                var tUrl = otbUrl.Text = tC_Url + "CpnSearchByCpnCode";
                var oCouponCode = new cmlCouponCode();
                oCouponCode.tCML_CpnCode = otbSearchCpnCode.Text;
                var oCpnStatusAll = oFoodLandCallAPI.C_GEToDataCpnByCode(tUrl.Trim(), oCouponCode);
                ogdDataCoupon.DataSource = oCpnStatusAll;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }
        private void ocmSearchCpnGroup_Click(object sender, EventArgs e)
        {
            try
            {
                oFoodLandCallAPI = new cFoodLandCallAPI();
                var tUrl = otbUrl.Text = tC_Url + "CpnSearchByGroup";

                var oCouponReq = new cmlCpnSearchReq();
                oCouponReq.tCML_StmCode = otbSearchStmCode.Text;
                oCouponReq.tCML_CpnUseSta = ocbSearchCpnSta.Text;
                var oCpnStatusAll = oFoodLandCallAPI.C_GEToDataCpnByGroup(tUrl.Trim(), oCouponReq);
                ogdDataCoupon.DataSource = oCpnStatusAll;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }

    }
}
