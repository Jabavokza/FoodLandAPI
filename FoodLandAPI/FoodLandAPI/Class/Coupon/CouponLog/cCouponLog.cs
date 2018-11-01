using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace FoodLandAPI.Class.Coupon.CouponLog
{
    public class cCouponLog
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCouponLog));
        public void CL_SETxCouponLog(cmlCouponReq poCouponReq, cmlCouponCode poCouponCode, cmlCouponRes poCouponRes,string ptMessage)
        {
            StringBuilder oSql;
            string tCouponReq;
            string tCouponRes;
           
            try
            {
                if (poCouponReq ==null)
                {
                    tCouponReq = new JavaScriptSerializer().Serialize(poCouponCode);
                }
                else
                {
                    tCouponReq = new JavaScriptSerializer().Serialize(poCouponReq);

                }
               
                if (ptMessage == null)
                {
                    tCouponRes = new JavaScriptSerializer().Serialize(poCouponRes);
                    
                }
                else
                {
                    tCouponRes = new JavaScriptSerializer().Serialize(ptMessage);
                }

                oSql = new StringBuilder();
                oSql.AppendLine("INSERT INTO TPSTLogPromoCpn");
                oSql.AppendLine("(");
                oSql.AppendLine("FDDateIns");
                oSql.AppendLine(",FTTimeIns");
                oSql.AppendLine(",FTWhoIns");
                oSql.AppendLine(",FTRemark");
                oSql.AppendLine(",FTStmCode");
                oSql.AppendLine(",FTTmnNum");
                oSql.AppendLine(",FTLogCode");
                oSql.AppendLine(",FTShdTransNo");
                oSql.AppendLine(",FTShdTransType");
                oSql.AppendLine(",FTServiceName");
                oSql.AppendLine(",FTReqPara");
                oSql.AppendLine(",FTResPara");
                oSql.AppendLine(",FTStatusCode");
                oSql.AppendLine(",FTStatusDescTH");
                oSql.AppendLine(",FTStatusDescEN");
                oSql.AppendLine(",FTPrintDesc");
                oSql.AppendLine(",FTRefCode");
                oSql.AppendLine(",FTTranDateTime");
                oSql.AppendLine(")");
                oSql.AppendLine("VALUES");
                oSql.AppendLine("(");
                oSql.AppendLine("CONVERT([VARCHAR](10),GETDATE(),(121))");
                oSql.AppendLine(",CONVERT(VARCHAR(8),GETDATE(),108)");
                oSql.AppendLine(",'admin'");
                oSql.AppendLine(",''");
                oSql.AppendLine(",'0300'");
                oSql.AppendLine(",'" + poCouponReq.tCML_TmnNum + "'");
                oSql.AppendLine(",'20170512170500'");
                oSql.AppendLine(",'00332'");
                oSql.AppendLine(",'01'");
                oSql.AppendLine(",'ServiceName'");
                oSql.AppendLine(",'" + tCouponReq + "'");
                oSql.AppendLine(",'" + tCouponRes + "'");
                oSql.AppendLine(",'" + poCouponRes.tCML_StatusCode + "'");
                oSql.AppendLine(",'" + poCouponRes.tCML_StatusDescTH + "'");
                oSql.AppendLine(",'" + poCouponRes.tCML_StatusDescEN + "'");
                oSql.AppendLine(",'" + poCouponRes.tCML_PrintDesc + "'");
                oSql.AppendLine(",'" + poCouponRes.tCML_RefCode + "'");
                oSql.AppendLine(",'" + poCouponRes.tCML_TranDateTime + "'");
                oSql.AppendLine(")");
                cCNSP.SP_GEToDbTbl(oSql.ToString());
            }
            catch (SqlException oEx)
            {
                log.Error(oEx.Message);
            }
        }

    }
}