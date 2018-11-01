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
    public class cCouponCreate
    {
        /// <summary>
        /// เขียน File Log
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCouponCreate));

        /// <summary>
        /// สร้าง Coupon
        /// </summary>
        /// <param name="poPara"></param>
        /// <returns></returns>
        public string c_SETtCouponCreate(cmlCouponReq poPara)
        {
            cmlCouponReq oCouponReq = new cmlCouponReq();
            cmlCouponCode coCouponCode = new cmlCouponCode();
            StringBuilder oSql;
            string tCpnExp;
            string CpnUseSta = "0";
            DateTime dCpnExp;
            try
            {
                oCouponReq = poPara;

                //tDateUpd = DateTime.Now.ToString("yyyy/MM/dd");
                //tDateIns = DateTime.Now.ToString("yyyy/MM/dd");
                //tTimeUpd = DateTime.Now.ToLongTimeString();
                //tTimeIns = DateTime.Now.ToLongTimeString();
                dCpnExp = DateTime.Parse(oCouponReq.tCML_CpnExp.ToString());
                tCpnExp = dCpnExp.ToString("yyyy/MM/dd");
                oSql = new StringBuilder();
                oSql.AppendLine("INSERT INTO TPSTCpnStatus ");
                oSql.AppendLine("(");
                oSql.AppendLine("FDDateUpd");
                oSql.AppendLine(",FTTimeUpd");
                oSql.AppendLine(",FTWhoUpd");
                oSql.AppendLine(",FDDateIns");
                oSql.AppendLine(",FTTimeIns");
                oSql.AppendLine(",FTWhoIns");
                oSql.AppendLine(",FTRemark");
                oSql.AppendLine(",FTStmCode");
                oSql.AppendLine(",FTTmnNum");
                oSql.AppendLine(",FTCpnCode");
                oSql.AppendLine(",FTCpnUseSta");
                oSql.AppendLine(",FDCpnExp");
                oSql.AppendLine(",FCCpnAmt");
                oSql.AppendLine(")");
                oSql.AppendLine("VALUES");
                oSql.AppendLine("(");
                oSql.AppendLine("CONVERT([VARCHAR](10),GETDATE(),(121))");
                oSql.AppendLine(",CONVERT(VARCHAR(8),GETDATE(),108)");
                oSql.AppendLine(",'" + oCouponReq.tCML_WhoUpd + "'");
                oSql.AppendLine(",CONVERT([VARCHAR](10),GETDATE(),(121))");
                oSql.AppendLine(",CONVERT(VARCHAR(8),GETDATE(),108)");
                oSql.AppendLine(",'" + oCouponReq.tCML_WhoIns + "'");
                oSql.AppendLine(",''");
                oSql.AppendLine(",'" + oCouponReq.tCML_StmCode + "'");
                oSql.AppendLine(",'" + oCouponReq.tCML_TmnNum + "'");
                oSql.AppendLine(",'" + oCouponReq.tCML_CpnCode + "'");
                oSql.AppendLine(",'" + CpnUseSta + "'");
                oSql.AppendLine(",'" + tCpnExp + "'");
                oSql.AppendLine(",'" + oCouponReq.tCML_CpnAmt + "'");
                oSql.AppendLine(")");
                var nResult = cCNSP.SP_SETnDbTbl(oSql.ToString());
                if (nResult > 0)
                {
                    log.Info(cCNMS.tMS_LogCreateSuccessful);
                    return cCNMS.tMS_LogCreateSuccessful;
                }
                else
                {
                    log.Info(cCNMS.tMS_LogCreateFalse);
                    return cCNMS.tMS_LogCreateFalse;
                }
            }
            catch (SqlException oEx)
            {
                switch (oEx.Number)
                {
                    case 2627:
                        return cCNMS.tMS_LogCreateFalse;
                }
                log.Error(cCNMS.tMS_LogCreateFalse);
                return cExtensionMessageError.C_GEToErrorException(oEx).ToString();
            }
            finally
            {

            }
        }
    }
}
