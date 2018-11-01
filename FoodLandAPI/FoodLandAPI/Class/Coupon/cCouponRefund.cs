using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FoodLandAPI.Class
{
    public class cCouponRefund
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCouponRefund));
        /// <summary>
        /// คืนค่า CouponCode
        /// </summary>
        /// <param name="poPara"></param>
        /// <returns></returns>
        public cmlCouponRes c_SEToCouponRefund(cmlCouponCode poPara)
        {
            cmlCouponCode oCouponCode = new cmlCouponCode();
            cmlCouponRes oCouponRes = new cmlCouponRes();
            oCouponCode = poPara;
            StringBuilder oSql;
            string tCpnAmt;
            try
            {
                oSql = new StringBuilder();
                oSql.AppendLine("SELECT FTCpnCode,FCCpnAmt");
                oSql.AppendLine("FROM TPSTCpnStatus WITH(noLOCK)");
                oSql.AppendLine("WHERE FTCpnCode = '" + oCouponCode.tCML_CpnCode + "'");
                oSql.AppendLine("AND FTCpnUseSta ='1'");

                if (cCNSP.SP_GEToDbTbl(oSql.ToString()).Rows.Count > 0)
                {

                    log.Info(cCNMS.tMS_SuccessStatusDescENRefun + " And FTCpnUseSta ='0'");
                    oCouponRes.tCML_StatusCode = cCNMS.tMS_SuccessStatusCodeRefun;
                    oCouponRes.tCML_StatusDescTH = cCNMS.tMS_SuccessStatusDescTHRefun;
                    oCouponRes.tCML_StatusDescEN = cCNMS.tMS_SuccessStatusDescENRefun;
                    oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    tCpnAmt = cCNSP.SP_GEToDbTbl(oSql.ToString()).Rows[0]["FCCpnAmt"].ToString();
                    oCouponRes.tCML_CpnAmt = tCpnAmt;

                    oSql = new StringBuilder();
                    oSql.AppendLine("UPDATE TPSTCpnStatus WITH(ROWLOCK)");
                    oSql.AppendLine("SET FTCpnUseSta ='0'");
                    oSql.AppendLine("WHERE FTCpnCode ='" + oCouponCode.tCML_CpnCode + "'");
                    var nResult = cCNSP.SP_SETnDbTbl(oSql.ToString());
                    if (nResult > 0)
                    {
                        return oCouponRes;
                    }
                    else
                    {
                        log.Info(cCNMS.tMS_ValidStatusDescENSale);
                        oCouponRes.tCML_StatusCode = "505";
                        oCouponRes.tCML_StatusDescTH = "คืนสถานะการใช้คูปองไม่สำเร็จ";
                        oCouponRes.tCML_StatusDescEN = "Update Failed";
                        oCouponRes.tCML_CpnAmt = null;
                        oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        return oCouponRes;
                    }
                }
                else
                {
                    log.Info(cCNMS.tMS_NotfoundStatusDescENRefun);
                    oCouponRes.tCML_StatusCode = cCNMS.tMS_NotfoundStatusCodeRefun;
                    oCouponRes.tCML_StatusDescTH = cCNMS.tMS_NotfoundStatusDescTHRefun;
                    oCouponRes.tCML_StatusDescEN = cCNMS.tMS_NotfoundStatusDescENRefun;
                    oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    return oCouponRes;
                }
            }
            catch (SqlException oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
    }
}