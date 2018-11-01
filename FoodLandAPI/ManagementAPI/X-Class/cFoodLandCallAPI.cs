
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.ComponentModel;
using ManagementAPI.Modale;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace ManagementAPI.X_Class
{
    public class cFoodLandCallAPI
    {

        /// <summary>
        /// รับข้อมูลในการสร้างคูปองจาก Post แล้วแปลงข้อมูลเป็นJson
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="poCouponReq"></param>
        /// <returns></returns>
        public cmlCouponRes C_SEToCreateCoupon(string ptUrl, cmlCouponReq poCouponReq)
        {
            try
            {
                var oJsonContent = JsonConvert.SerializeObject(poCouponReq, Formatting.Indented);
                return C_GETtMSgReq(ptUrl, oJsonContent);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        public cmlCouponRes C_SEToCouponSta(string ptUrl, string ptCpnCode)
        {
            var oCouponCode = new cmlCouponCode();
            try
            {
                oCouponCode.tCML_CpnCode = ptCpnCode;
                var oJsonContent = JsonConvert.SerializeObject(oCouponCode, Formatting.Indented);
                return C_GETtMSgReq(ptUrl, oJsonContent);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private cmlCouponRes C_GETtMSgReq(string ptUrl, string ptJsonContent)
        {
            try
            {
                var tResult = C_ContWebApi(ptUrl, "POST", ptJsonContent);
                var oCouponRes = JsonConvert.DeserializeObject<cmlCouponRes>(tResult);
                return oCouponRes;
            }
            catch (WebException oExWeb)
            {
                throw oExWeb;
            }
        }
        /// <summary>
        /// อ่านการตั้งค่า DataBase จากไฟล์ Config/Setting.xml
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <returns></returns>
        public cmlConnectDB C_GETxConfigDB(string ptUrl)
        {
            try
            {
                var tResult = C_ContWebApi(ptUrl, "GET", "");
                var oConnectDB = JsonConvert.DeserializeObject<cmlConnectDB>(tResult);
                return oConnectDB;
            }
            catch (WebException oExWeb)
            {
                throw oExWeb;
            }
        }
        /// <summary>
        /// เขียนการตั้งค่า DataBase ไปที่ไฟล์ Config/Connection.xml
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="poConnectDB"></param>
        public void C_SETxConfigDB(string ptUrl, cmlConnectDB poConnectDB)
        {
            try
            {
                var tJsonContent = JsonConvert.SerializeObject(poConnectDB, Formatting.Indented);
                var tResult = C_ContWebApi(ptUrl, "POST", tJsonContent);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        public DataTable C_GEToDataCpnStatusAll(string ptUrl)
        {
            try
            {
                var tResult = C_ContWebApi(ptUrl, "GET", "");
                return JsonConvert.DeserializeObject<DataTable>(tResult);

            }
            catch (Exception oEx)
            {
                throw oEx;
            }

        }
        public DataTable C_GEToDataCpnByGroup(string ptUrl, cmlCpnSearchReq poCpnSearchReq)
        {
            try
            {
                switch (poCpnSearchReq.tCML_CpnUseSta)
                {
                    case "": poCpnSearchReq.tCML_CpnUseSta = ""; break;
                    case "ใช้งานได้": poCpnSearchReq.tCML_CpnUseSta = "0"; break;
                    case "ใช้งานไปแล้ว": poCpnSearchReq.tCML_CpnUseSta = "1"; break;
                    case "ยกเลิก": poCpnSearchReq.tCML_CpnUseSta = "2"; break;
                    case "หมดอายุ": poCpnSearchReq.tCML_CpnUseSta = "Exp"; break;
                }
                var tJsonContent = JsonConvert.SerializeObject(poCpnSearchReq, Formatting.Indented);
                var tResult = C_ContWebApi(ptUrl, "POST", tJsonContent);
                return JsonConvert.DeserializeObject<DataTable>(tResult);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        public DataTable C_GEToDataCpnByCode(string ptUrl, cmlCouponCode poCouponCode)
        {
            try
            {
                var tJsonContent = JsonConvert.SerializeObject(poCouponCode, Formatting.Indented);
                var tResult = C_ContWebApi(ptUrl, "POST", tJsonContent);
                return JsonConvert.DeserializeObject<DataTable>(tResult);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        public string C_SETxCpnUseStaUpd(string ptUrl, cmlCpnUseStaUpd poCpnUseStaUpd)
        {
            try
            {
                var tJsonContent = JsonConvert.SerializeObject(poCpnUseStaUpd, Formatting.Indented);
                var tResult = C_ContWebApi(ptUrl, "POST", tJsonContent);
                return tResult;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        /// <summary>
        /// ตั้งค่า HttpWebRequest รับค่า Url และ POST /GET /PUT /DELETE
        /// </summary>
        /// <param name="ptUrl"></param>
        /// <param name="ptMedthod"></param>
        /// <param name="paJsonContent"></param>
        /// <returns></returns>
        private string C_ContWebApi(string ptUrl, string ptMedthod, string ptJsonContent)
        {
            string tUserName = "PA";
            string tUserPwd = "001";
            int nW_TimeOut = 25;
            try
            {
                var aJsonContent = Encoding.UTF8.GetBytes(ptJsonContent);
                var aUsernamePassword = Encoding.UTF8.GetBytes(tUserName + ":" + tUserPwd);
                var tResult = Convert.ToBase64String(aUsernamePassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                var oHttpWebREQ = (HttpWebRequest)WebRequest.Create(ptUrl);
                oHttpWebREQ.KeepAlive = false;
                oHttpWebREQ.ProtocolVersion = HttpVersion.Version10;
                oHttpWebREQ.Method = ptMedthod;//POST /GET /PUT /DELETE
                oHttpWebREQ.Headers["Authorization"] = "Basic " + tResult.ToString();
                oHttpWebREQ.ContentType = "application/json";
                oHttpWebREQ.Timeout = (nW_TimeOut * 1000);
                oHttpWebREQ.ContentLength = aJsonContent.Length;
                if (ptJsonContent != "")
                {
                    using (var oSw = oHttpWebREQ.GetRequestStream()) oSw.Write(aJsonContent, 0, aJsonContent.Length);
                }
                var oHttpRES = (HttpWebResponse)oHttpWebREQ.GetResponse();
                using (var oSr = new StreamReader(oHttpRES.GetResponseStream()))
                {
                    var oResult = oSr.ReadToEnd();
                    return oResult;
                }
            }
            catch (WebException oExWeb)
            {
                throw oExWeb;
            }
        }
    }

}

