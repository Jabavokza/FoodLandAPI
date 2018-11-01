
using FLCallAPI;
using FLCallAPI.Modale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POSTClient
{
    public partial class wMain : Form
    {
        public cCallAPI oCallAPI;
        private String[] aCouponRes;
        public int nW_TimeOut = 15;

        public wMain()
        {
            InitializeComponent();
        }

        private void wMain_Load(object sender, EventArgs e)
        {

        }

        private void ocmCreate_Click(object sender, EventArgs e)
        {
            oCallAPI = new cCallAPI();

            try
            {
                cmlCouponRes oCouponRes = new cmlCouponRes();
                cmlCouponReq oCouponReq = new cmlCouponReq();

                oCouponReq.tCML_WhoUpd = otbWhoUpd.Text;
                oCouponReq.tCML_WhoIns = otbWhoIns.Text;
                oCouponReq.tCML_StmCode = otbStmCode.Text;
                oCouponReq.tCML_TmnNum = otbTmnNum.Text;
                oCouponReq.tCML_CpnCode = otbCpnCode.Text;
                oCouponReq.tCML_CpnExp = otbCpnExp.Text;
                oCouponReq.tCML_CpnAmt = otbCpnAmt.Text;
               // otbUrl.Text = "http://172.16.30.151:9000/api/coupon/Create";
                 otbUrl.Text = "http://172.16.30.188:90/api/coupon/Create";
               // otbResult.Text = oCallAPI.C_SETtCreateCoupon(otbUrl.Text, oCouponReq, nW_TimeOut);
                otbResult.Text = oCallAPI.C_SETtCreateCoupon(otbUrl.Text, otbWhoIns.Text, otbWhoIns.Text, otbStmCode.Text, otbTmnNum.Text, otbCpnCode.Text, otbCpnExp.Text, otbCpnAmt.Text, nW_TimeOut);



            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmCreate_Click//" + oEx.Message);
            }
        }

        private void ocmSale_Click(object sender, EventArgs e)
        {
            oCallAPI = new cCallAPI();

            try
            {
                // cmlCouponRes oCouponRes = new cmlCouponRes();
                cmlCouponCode oCouponCode = new cmlCouponCode();
               // otbUrl.Text = "http://172.16.30.151:9000/api/coupon/Sale";
                 otbUrl.Text = "http://172.16.30.188:90/api/coupon/Sale";
                oCouponCode.tCML_CpnCode = otbSendCoupon.Text;
                  otbMsgError.Text = oCallAPI.C_SETtUseCoupon(otbUrl.Text, oCouponCode.tCML_CpnCode, nW_TimeOut);
                //aCouponRes = oCallAPI.C_SETaUseCoupon(otbUrl.Text, oCouponCode.tCML_CpnCode, nW_TimeOut);
                //otbStatusCode.Text = aCouponRes[0];
                //otbStatusDescTH.Text = aCouponRes[1];
                //otbStatusDescEN.Text = aCouponRes[2];
                //otbPrintDesc.Text = aCouponRes[3];
                //otbRefCode.Text = aCouponRes[4];
                //otbTranDateTime.Text = aCouponRes[5];
                //otbCpnAmtRes.Text = aCouponRes[6];
                //otbMsgError.Text = aCouponRes[7];
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSale_Click//" + oEx.Message);
            }
        }

        private void ocmRefund_Click(object sender, EventArgs e)
        {
            oCallAPI = new cCallAPI();

            try
            {

                cmlCouponCode oCouponCode = new cmlCouponCode();
                otbUrl.Text = "http://172.16.30.188:90/api/coupon/Refund";
                oCouponCode.tCML_CpnCode = otbSendCoupon.Text;
                 otbMsgError.Text = oCallAPI.C_SETtUseCoupon(otbUrl.Text, oCouponCode.tCML_CpnCode, nW_TimeOut);
               // aCouponRes = oCallAPI.C_SETaUseCoupon(otbUrl.Text, oCouponCode.tCML_CpnCode, nW_TimeOut);
                //otbStatusCode.Text = aCouponRes[0];
                //otbStatusDescTH.Text = aCouponRes[1];
                //otbStatusDescEN.Text = aCouponRes[2];
                //otbPrintDesc.Text = aCouponRes[3];
                //otbRefCode.Text = aCouponRes[4];
                //otbTranDateTime.Text = aCouponRes[5];
                //otbCpnAmtRes.Text = aCouponRes[6];
                //otbMsgError.Text = aCouponRes[7];
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmRefund_Click//" + oEx.Message);
            }
        }

        private void ocmVoid_Click(object sender, EventArgs e)
        {
            oCallAPI = new cCallAPI();

            try
            {

                cmlCouponCode oCouponCode = new cmlCouponCode();
                otbUrl.Text = "http://172.16.30.188:90/api/coupon/Void";
                oCouponCode.tCML_CpnCode = otbSendCoupon.Text;
                otbMsgError.Text = oCallAPI.C_SETtUseCoupon(otbUrl.Text, oCouponCode.tCML_CpnCode, nW_TimeOut);
                //aCouponRes = oCallAPI.C_SETaUseCoupon(otbUrl.Text, oCouponCode.tCML_CpnCode, nW_TimeOut);
                //otbStatusCode.Text = aCouponRes[0];
                //otbStatusDescTH.Text = aCouponRes[1];
                //otbStatusDescEN.Text = aCouponRes[2];
                //otbPrintDesc.Text = aCouponRes[3];
                //otbRefCode.Text = aCouponRes[4];
                //otbTranDateTime.Text = aCouponRes[5];
                //otbCpnAmtRes.Text = aCouponRes[6];
                //otbMsgError.Text = aCouponRes[7];
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmVoid_Click//" + oEx.Message);
            }
        }

        private void ocmSend_Click(object sender, EventArgs e)
        {
            oCallAPI = new cCallAPI();

            string CouponCode = "5555555555555555555";
            int W = 50;
            int H = 50;
            byte[] xxx = oCallAPI.C_GEToQRPic(CouponCode, W, H);
            opicQR.Image = oCallAPI.C_GEToQRBmp(CouponCode, W, H);


        }
    }
}
