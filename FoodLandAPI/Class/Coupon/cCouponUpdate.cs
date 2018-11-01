using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FoodLandAPI.Class.Coupon
{
    public class cCouponUpdate : ICoupon
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCouponUpdate));

        public string C_SETxCpnUseStaUpd(string ptCpnCode, string ptCpnUseSta)
        {
            StringBuilder oSql;
            try
            {
                oSql = new StringBuilder();
                oSql.AppendLine("UPDATE TPSTCpnStatus WITH(ROWLOCK)");
                oSql.AppendLine("SET FTCpnUseSta = '" + ptCpnUseSta + "'");
                oSql.AppendLine("WHERE FTCpnCode = '" + ptCpnCode + "'");
                var nResult = cCNSP.SP_SETnDbTbl(oSql.ToString());
                if (nResult > 0)
                {
                    return "Update SuccessFul";
                }
                else
                {
                    return "Update Failed";
                }
                
            }
            catch (SqlException oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                return cExtensionMessageError.C_GEToErrorException(oEx).Message;
            }
        }
    }
}