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
    public class cCouponVoid
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCouponVoid));
        /// <summary>
        /// ยกเลิกหมายเลขคูปอง
        /// </summary>
        /// <param name="poPara"></param>
        /// <returns></returns>
        public cmlCouponRes c_SEToCouponVoid(cmlCouponCode poPara)
        {

            cmlCouponCode oCouponCode = new cmlCouponCode();
            cmlCouponRes oCouponRes = new cmlCouponRes();
            oCouponCode = poPara;
            StringBuilder oSql;

            try
            {
                oSql = new StringBuilder();
                oSql.AppendLine("SELECT FTCpnCode");
                oSql.AppendLine("FROM TPSTCpnStatus WITH(noLOCK)");
                oSql.AppendLine("WHERE FTCpnCode = '" + oCouponCode.tCML_CpnCode + "'");
                oSql.AppendLine("AND FTCpnUseSta ='0'");
                if (cCNSP.SP_GEToDbTbl(oSql.ToString()).Rows.Count == 0)
                {
                    log.Info(cCNMS.tMS_NotfoundStatusDescENVoid);
                    oCouponRes.tCML_StatusCode = cCNMS.tMS_NotfoundStatusCodeVoid;
                    oCouponRes.tCML_StatusDescTH = cCNMS.tMS_NotfoundStatusDescTHVoid;
                    oCouponRes.tCML_StatusDescEN = cCNMS.tMS_NotfoundStatusDescENVoid;
                    oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    return oCouponRes;
                }
                else
                {
                    log.Info(cCNMS.tMS_SuccessStatusDescENVoid);
                    oCouponRes.tCML_StatusCode = cCNMS.tMS_SuccessStatusCodeVoid;
                    oCouponRes.tCML_StatusDescTH = cCNMS.tMS_SuccessStatusDescTHVoid;
                    oCouponRes.tCML_StatusDescEN = cCNMS.tMS_SuccessStatusDescENVoid;
                    oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    oSql = new StringBuilder();
                    oSql.AppendLine("UPDATE TPSTCpnStatus WITH(ROWLOCK)");
                    oSql.AppendLine("SET FTCpnUseSta ='2'");
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
                        oCouponRes.tCML_StatusDescTH = "ยกเลิกสถานะคูปองไม่สำเร็จ";
                        oCouponRes.tCML_StatusDescEN = "Update Failed";
                        oCouponRes.tCML_CpnAmt = null;
                        oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        return oCouponRes;
                    }
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