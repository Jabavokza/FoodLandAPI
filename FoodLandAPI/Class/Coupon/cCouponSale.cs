using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FoodLandAPI.Class
{
    public class cCouponSale
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCouponSale));
        /// <summary>
        /// ตรวจสอบสถานะ Coupon
        /// </summary>
        /// <param name="poPara"></param>
        /// <returns></returns>
        public cmlCouponRes c_CHKoCouponSale(cmlCouponCode poPara)
        {
            cmlCouponCode oCouponCode = new cmlCouponCode();
            cmlCouponRes oCouponRes = new cmlCouponRes();
            oCouponCode = poPara;
            DateTime oCoupondate;
            StringBuilder oSql,oSQL;

            try
            {
                oSQL = new StringBuilder();
                oSQL.AppendLine("SELECT FTCpnCode,FCCpnAmt");
                oSQL.AppendLine("FROM TPSTCpnStatus WITH(noLOCK)");
                oSQL.AppendLine("WHERE FTCpnCode ='" + oCouponCode.tCML_CpnCode + "'");

                if (cCNSP.SP_GEToDbTbl(oSQL.ToString()).Rows.Count == 0)
                {
                    log.Info(cCNMS.tMS_NotfoundStatusDescENSale);
                    oCouponRes.tCML_StatusCode = cCNMS.tMS_NotfoundStatusCodeSale;
                    oCouponRes.tCML_StatusDescTH = cCNMS.tMS_NotfoundStatusDescTHSale;
                    oCouponRes.tCML_StatusDescEN = cCNMS.tMS_NotfoundStatusDescENSale;
                    oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy ");
                    return oCouponRes;
                }
                else
                {
                    oSql = new StringBuilder();
                    oSql.AppendLine("SELECT FTCpnUseSta");
                    oSql.AppendLine("FROM TPSTCpnStatus WITH(noLOCK)");
                    oSql.AppendLine("WHERE FTCpnCode ='" + oCouponCode.tCML_CpnCode + "'");
                    switch (cCNSP.SP_GEToDbTbl(oSql.ToString()).Rows[0]["FTCpnUseSta"].ToString())
                    {
                        case "0":
                            oSql = new StringBuilder();
                            oSql.AppendLine("SELECT FDCpnExp");
                            oSql.AppendLine("FROM TPSTCpnStatus WITH(noLOCK)");
                            oSql.AppendLine("WHERE FTCpnCode ='" + oCouponCode.tCML_CpnCode + "'");
                            oCoupondate = DateTime.Parse(cCNSP.SP_GEToDbTbl(oSql.ToString()).Rows[0]["FDCpnExp"].ToString());

                            if (oCoupondate > DateTime.Now)
                            {
                                log.Info(cCNMS.tMS_ValidStatusDescENSale);
                                oCouponRes.tCML_StatusCode = cCNMS.tMS_ValidStatusCodeSale;
                                oCouponRes.tCML_StatusDescTH = cCNMS.tMS_ValidStatusDescTHSale;
                                oCouponRes.tCML_StatusDescEN = cCNMS.tMS_ValidStatusDescENSale;
                                oCouponRes.tCML_CpnAmt = cCNSP.SP_GEToDbTbl(oSQL.ToString()).Rows[0]["FCCpnAmt"].ToString();
                                oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                                log.Info("UPDATE TPSTCpnStatus = 1");
                                oSql = new StringBuilder();
                                oSql.AppendLine("UPDATE TPSTCpnStatus WITH(ROWLOCK)");
                                oSql.AppendLine("SET FTCpnUseSta ='1'");
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
                                    oCouponRes.tCML_StatusDescTH = "ปรับสถานะการใช้คูปองไม่สำเร็จ";
                                    oCouponRes.tCML_StatusDescEN = "Update Failed";
                                    oCouponRes.tCML_CpnAmt = null;
                                    oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                    return oCouponRes;
                                }
                               
                            }
                            else
                            {
                                log.Info(cCNMS.tMS_ExpiredStatusDescENSale);
                                oCouponRes.tCML_StatusCode = cCNMS.tMS_ExpiredStatusCodeSale;
                                oCouponRes.tCML_StatusDescTH = cCNMS.tMS_ExpiredStatusDescTHSale;
                                oCouponRes.tCML_StatusDescEN = cCNMS.tMS_ExpiredStatusDescENSale;
                                oCouponRes.tCML_CpnAmt = cCNSP.SP_GEToDbTbl(oSQL.ToString()).Rows[0]["FCCpnAmt"].ToString();
                                oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                return oCouponRes;
                            }

                        case "1":
                            log.Info(cCNMS.tMS_UsedStatusDescENSale);
                            oCouponRes.tCML_StatusCode = cCNMS.tMS_UsedStatusCodeSale;
                            oCouponRes.tCML_StatusDescTH = cCNMS.tMS_UsedStatusDescTHSale;
                            oCouponRes.tCML_StatusDescEN = cCNMS.tMS_UsedStatusDescENSale;
                            oCouponRes.tCML_CpnAmt = cCNSP.SP_GEToDbTbl(oSQL.ToString()).Rows[0]["FCCpnAmt"].ToString();
                            oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            return oCouponRes;
                        case "2":
                            log.Info(cCNMS.tMS_UsedStatusDescENSale);
                            oCouponRes.tCML_StatusCode = cCNMS.tMS_VoidStatusCodeSale;
                            oCouponRes.tCML_StatusDescTH = cCNMS.tMS_VoidStatusDescTHSale;
                            oCouponRes.tCML_StatusDescEN = cCNMS.tMS_VoidStatusDescENSale;
                            oCouponRes.tCML_CpnAmt = cCNSP.SP_GEToDbTbl(oSQL.ToString()).Rows[0]["FCCpnAmt"].ToString();
                            oCouponRes.tCML_TranDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            return oCouponRes;
                    }
                }
                return oCouponRes;
            }
            catch (SqlException oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
    }
}