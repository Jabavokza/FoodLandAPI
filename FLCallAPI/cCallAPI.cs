using FLCallAPI.Modale;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace FLCallAPI
{
    [Guid("5E8ABD28-6A46-429B-83A9-616D4A1B9D5D")]
    public interface ComClass1Interface
    {
    }

    [Guid("477A2506-2AEC-4B63-8F44-1B35745F5993"),
        InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ComClass1Events
    {
    }

    [Guid("7B51434D-DF2D-4E65-9B02-7404ED3F4FD8"),
        ClassInterface(ClassInterfaceType.None),
        ComSourceInterfaces(typeof(ComClass1Events))]

    public class cCallAPI
    {
        //ใช้ String(S ตัวใหญ่)เพื่อแก้ปันหาการ ส่งค่า ระหว่าง .Net กับ vb6 
        public int nW_TimeOut = 15;
        cmlCouponReq oCouponReq;
        cmlCouponRes oCouponRes;
        cmlCouponCode oCouponCode;
        //ฟังก์ชัน OverLoad
        /// <summary>
        /// รับข้อมูลในการสร้างคูปองจาก Post แล้วแปลงข้อมูลเป็นJson
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="poCouponReq"></param>
        /// <param name="pnTimeOut"></param>
        /// <returns></returns>
        //public String C_SETtCreateCoupon(string ptUrl, cmlCouponReq poCouponReq, int pnTimeOut)
        //{
        //    try
        //    {
        //        oCouponRes = new cmlCouponRes();
        //        nW_TimeOut = pnTimeOut;
        //        oCouponRes = C_GEToMSgReqCreate(ptUrl, poCouponReq);
        //        switch (oCouponRes.tCML_CpnMSg)
        //        {
        //            case "Add Data Successful": oCouponRes.tCML_CpnMSg = "1"; break;
        //            case "หมายเลขคูปองซ้ำ": oCouponRes.tCML_CpnMSg = "2"; break;
        //        }
        //        return oCouponRes.tCML_CpnMSg;
        //    }
        //    catch (Exception oEx)
        //    {
        //        throw oEx;
        //    }
        //}
        public String C_SETtCreateCoupon(string ptUrl, string ptWhoUpd, string ptWhoIns, string ptStmCode, string ptTmnNum, string ptCpnCode, string ptCpnExp, string ptCpnAmt, int pnTimeOut)
        {
            try
            {
                oCouponReq = new cmlCouponReq();
                oCouponRes = new cmlCouponRes();
                oCouponReq.tCML_WhoUpd = ptWhoUpd;
                oCouponReq.tCML_WhoIns = ptWhoIns;
                oCouponReq.tCML_StmCode = ptStmCode;
                oCouponReq.tCML_TmnNum = ptTmnNum;
                oCouponReq.tCML_CpnCode = ptCpnCode;
                oCouponReq.tCML_CpnExp = ptCpnExp;
                oCouponReq.tCML_CpnAmt = ptCpnAmt;
                nW_TimeOut = pnTimeOut;
                oCouponRes = C_GEToMSgReqCreate(ptUrl, oCouponReq);
                switch (oCouponRes.tCML_CpnMSg)
                {
                    case "Add Data Successful": oCouponRes.tCML_CpnMSg = "1"; break;
                    case "หมายเลขคูปองซ้ำ": oCouponRes.tCML_CpnMSg = "2"; break;
                }
                return oCouponRes.tCML_CpnMSg;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        /// <summary>
        /// ขาใช้คูปอง Sale /Refund /Void
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="ptCpnCode"></param>
        /// <param name="pnTimeOut"></param>
        /// <returns></returns>
        public String C_SETtUseCoupon(string ptUrl, string ptCpnCode, int pnTimeOut)
        {
          //  String[] aCouponRes;
            try
            {
                nW_TimeOut = pnTimeOut;
                oCouponRes = new cmlCouponRes();
                oCouponCode = new cmlCouponCode
                {
                    tCML_CpnCode = ptCpnCode
                };
                oCouponRes = C_GEToMSgReq(ptUrl, oCouponCode);
                //aCouponRes = new String[] { oCouponRes.tCML_StatusCode , oCouponRes.tCML_StatusDescTH
                //    , oCouponRes.tCML_StatusDescEN , oCouponRes.tCML_PrintDesc
                //    , oCouponRes.tCML_RefCode , oCouponRes.tCML_TranDateTime , oCouponRes.tCML_CpnAmt ,oCouponRes.tCML_CpnMSg};
                //return aCouponRes; // Arrey
                var tResult = oCouponRes.tCML_StatusCode + ";" + oCouponRes.tCML_StatusDescTH + ";" + oCouponRes.tCML_StatusDescEN + ";"
                + oCouponRes.tCML_PrintDesc + ";" + oCouponRes.tCML_RefCode + ";" + oCouponRes.tCML_TranDateTime + ";" + oCouponRes.tCML_CpnAmt + ";"
                + oCouponRes.tCML_CpnMSg;
                return tResult; // String
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="poCouponReq"></param>
        /// <returns></returns>
        private cmlCouponRes C_GEToMSgReqCreate(string ptUrl, cmlCouponReq poCouponReq)
        {
            try
            {
                oCouponRes = new cmlCouponRes();
                var tJsonCouponReq = JsonConvert.SerializeObject(poCouponReq, Formatting.Indented);
                var aJsonCouponReq = Encoding.UTF8.GetBytes(tJsonCouponReq);
                var oHttpWebREQ = C_SEToHttpWebRequest(ptUrl, "POST", aJsonCouponReq);
                oCouponRes = C_GEToHttpWebResponse(oHttpWebREQ);
                return oCouponRes;
            }
            catch (WebException oEx)
            {
                oCouponRes.tCML_CpnMSg = "404";
                return oCouponRes;
            }
        }
        /// <summary>
        /// ส่งข้อมูลที่เป็นJson แล้วรับค่า Respond กลับมา
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="tJsonContent"></param>
        /// <returns></returns>
        private cmlCouponRes C_GEToMSgReq(string ptUrl, cmlCouponCode poCouponCode)
        {
            try
            {
                oCouponRes = new cmlCouponRes();
                var tJsonCouponReq = JsonConvert.SerializeObject(poCouponCode, Formatting.Indented);
                var aJsonCouponReq = Encoding.UTF8.GetBytes(tJsonCouponReq);

                var oHttpWebREQ = C_SEToHttpWebRequest(ptUrl, "POST", aJsonCouponReq);
                oCouponRes = C_GEToHttpWebResponse(oHttpWebREQ);
                return oCouponRes;
            }
            catch (WebException oEx)
            {
                oCouponRes.tCML_CpnMSg = "404";
                return oCouponRes;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="ptMedthod"></param>
        /// <returns></returns>
        private HttpWebRequest C_SEToHttpWebRequest(string ptUrl, string ptMedthod, byte[] paJsonCouponReq)
        {
            string tUserName = "PA";
            string tUserPwd = "001";
            try
            {
                var aUsernamePassword = Encoding.UTF8.GetBytes(tUserName + ":" + tUserPwd);
                var tResult = Convert.ToBase64String(aUsernamePassword);
                var oRequest = (HttpWebRequest)WebRequest.Create(ptUrl);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                oRequest.Method = ptMedthod;//POST /GET /PUT /DELETE
                oRequest.Headers.Add("Authorization", "Basic " + tResult);
                oRequest.ContentType = "application/json";
                oRequest.ContentLength = paJsonCouponReq.Length;
                using (var oSw = oRequest.GetRequestStream()) oSw.Write(paJsonCouponReq, 0, paJsonCouponReq.Length);
                return oRequest;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poHttpWebRequest"></param>
        /// <param name="paJsonCouponReq"></param>
        /// <returns></returns>
        private cmlCouponRes C_GEToHttpWebResponse(HttpWebRequest poHttpWebRequest)
        {
            try
            {
                var oResponse = (HttpWebResponse)poHttpWebRequest.GetResponse();
                var oResponseData = new StreamReader(oResponse.GetResponseStream(), Encoding.UTF8).ReadToEnd();
                var oCouponRes = JsonConvert.DeserializeObject<cmlCouponRes>(oResponseData);
                return oCouponRes;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        #region QRCode
        public byte[] C_GEToQRPic(string ptQR, int pnQRHeight, int pnQRWidth)
        {
            try
            {
                Bitmap oBitmap = new Bitmap(C_GEToQRBmp(ptQR, pnQRHeight, pnQRWidth));
                MemoryStream oStream = new MemoryStream();
                oBitmap.Save(oStream, ImageFormat.Jpeg);
                Image oPic = Image.FromStream(oStream);
                byte[] oaImgByte = C_GETaImageToByteArray(oPic);
                return oaImgByte;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private byte[] C_GETaImageToByteArray(Image oPic)
        {
            ImageConverter oImageConverter = new ImageConverter();
            byte[] xByte = (byte[])oImageConverter.ConvertTo(oPic, typeof(byte[]));
            return xByte;
        }

        public Bitmap C_GEToQRBmp(string ptQR, int pnQRHeight, int pnQRWidth)
        {
            //tag assign
            StringBuilder oStrData = new StringBuilder();
            oStrData.Append(ptQR);
            string tQRCode = oStrData.ToString();

            ZXing.BarcodeWriter oQr = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE
            };

            if (pnQRHeight <= 0)
            {
                pnQRHeight = 200;
            }

            if (pnQRWidth <= 0)
            {
                pnQRWidth = 200;
            }

            int nMargin = 28;
            if (pnQRWidth >= 0 && pnQRWidth <= 100)
            {
                nMargin = 12;
            }
            if (pnQRWidth > 100 && pnQRWidth <= 120)
            {
                nMargin = 30;
            }
            if (pnQRWidth > 120 && pnQRWidth <= 160)
            {
                nMargin = 20;
            }
            if (pnQRWidth > 160 && pnQRWidth <= 180)
            {
                nMargin = 14;
            }
            if (pnQRWidth > 180 && pnQRWidth <= 200)
            {
                nMargin = 28;
            }
            if (pnQRWidth > 200 && pnQRWidth <= 220)
            {
                nMargin = 44;
            }
            if (pnQRWidth > 220 && pnQRWidth <= 240)
            {
                nMargin = 26;
            }
            if (pnQRWidth > 240 && pnQRWidth <= 260)
            {
                nMargin = 42;
            }
            if (pnQRWidth > 260 && pnQRWidth <= 280)
            {
                nMargin = 30;
            }
            if (pnQRWidth > 280 && pnQRWidth <= 300)
            {
                nMargin = 40;
            }
            if (pnQRWidth > 300 && pnQRWidth <= 320)
            {
                nMargin = 28;
            }
            if (pnQRWidth > 320 && pnQRWidth <= 340)
            {
                nMargin = 40;
            }
            if (pnQRWidth > 340 && pnQRWidth <= 360)
            {
                nMargin = 30;
            }
            int nCrop = nMargin * 2;
            oQr.Options.Height = pnQRHeight;
            oQr.Options.Width = pnQRWidth;
            Bitmap oBitmap = new Bitmap(oQr.Write(tQRCode), new Size(oQr.Options.Width, oQr.Options.Height));
            return oBitmap;
        }
        //private Image C_GEToByteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    Image returnImage = Image.FromStream(ms);
        //    return returnImage;
        //}
        #endregion

        ///F\Funtion Prototype
        //private String W_SETtCreateCoupon(string ptUrl, cmlCouponReq poCouponReq)
        //{
        //    string tUserName = "PA";
        //    string tUserPwd = "001";
        //    try
        //    {
        //        var tJsonCouponReq = JsonConvert.SerializeObject(poCouponReq, Formatting.Indented);
        //        var aJsonCouponReq = Encoding.UTF8.GetBytes(tJsonCouponReq);

        //        var aUsernamePassword = Encoding.UTF8.GetBytes(tUserName + ":" + tUserPwd);
        //        var tResult = Convert.ToBase64String(aUsernamePassword);
        //        var oRequest = (HttpWebRequest)WebRequest.Create(ptUrl);
        //        oRequest.Method = "POST";//POST /GET /PUT /DELETE
        //        oRequest.Headers.Add("Authorization", "Basic " + tResult);
        //        oRequest.ContentType = "application/json";
        //        oRequest.ContentLength = aJsonCouponReq.Length;
        //        using (var stream = oRequest.GetRequestStream()) stream.Write(aJsonCouponReq, 0, aJsonCouponReq.Length);

        //        var oResponse = (HttpWebResponse)oRequest.GetResponse();
        //        var oResponseData = new StreamReader(oResponse.GetResponseStream(), Encoding.UTF8).ReadToEnd();
        //        var oCouponRes = JsonConvert.DeserializeObject<cmlCouponRes>(oResponseData);
        //        return oCouponRes.tcml_CpnMSg;
        //    }
        //    catch (Exception oEx)
        //    {
        //        throw oEx;
        //    }

        //}
    }


}
