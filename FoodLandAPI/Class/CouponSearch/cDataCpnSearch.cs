using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Interfaces;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FoodLandAPI.Class.CouponSearch
{
    public class cDataCpnSearch : ICpnSearch
    {
        public DataTable C_GEToDataCpnByGroup(cmlCpnSearchReq poCpnSearchReq)
        {
            StringBuilder oSql;
            try
            {
                oSql = new StringBuilder();
                if (poCpnSearchReq.tCML_CpnUseSta.Equals("Exp") && poCpnSearchReq.tCML_StmCode != "")
                {
                    oSql.AppendLine("SELECT FTStmCode");
                    oSql.AppendLine(",FTTmnNum");
                    oSql.AppendLine(",FDDateIns");
                    oSql.AppendLine(",FTCpnCode");
                    oSql.AppendLine(",FCCpnAmt");
                    oSql.AppendLine(",FDCpnExp");
                    oSql.AppendLine(",FTCpnUseSta");
                    oSql.AppendLine(",FTWhoIns");
                    oSql.AppendLine("FROM TPSTCpnStatus ");
                    oSql.AppendLine("WHERE FTStmCode = '" + poCpnSearchReq.tCML_StmCode + "' ");
                    oSql.AppendLine("AND Getdate() > FDCpnExp");
                    oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                    var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                    return oDataCpn;
                }
                else if (poCpnSearchReq.tCML_CpnUseSta.Equals("Exp"))
                {
                    oSql.AppendLine("SELECT FTStmCode");
                    oSql.AppendLine(",FTTmnNum");
                    oSql.AppendLine(",FDDateIns");
                    oSql.AppendLine(",FTCpnCode");
                    oSql.AppendLine(",FCCpnAmt");
                    oSql.AppendLine(",FDCpnExp");
                    oSql.AppendLine(",FTCpnUseSta");
                    oSql.AppendLine(",FTWhoIns");
                    oSql.AppendLine("FROM TPSTCpnStatus ");
                    oSql.AppendLine("WHERE Getdate() > FDCpnExp");
                    oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                    var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                    return oDataCpn;
                }

                if (poCpnSearchReq.tCML_StmCode != "" && poCpnSearchReq.tCML_CpnUseSta != "")
                {
                    if (poCpnSearchReq.tCML_CpnUseSta == "0")
                    {
                        oSql.AppendLine("SELECT FTStmCode");
                        oSql.AppendLine(",FTTmnNum");
                        oSql.AppendLine(",FDDateIns");
                        oSql.AppendLine(",FTCpnCode");
                        oSql.AppendLine(",FCCpnAmt");
                        oSql.AppendLine(",FDCpnExp");
                        oSql.AppendLine(",FTCpnUseSta");
                        oSql.AppendLine(",FTWhoIns");
                        oSql.AppendLine("FROM TPSTCpnStatus ");
                        oSql.AppendLine("WHERE FTStmCode = '" + poCpnSearchReq.tCML_StmCode + "' ");
                        oSql.AppendLine("AND FTCpnUseSta = '" + poCpnSearchReq.tCML_CpnUseSta + "'");
                        oSql.AppendLine("AND Getdate() < FDCpnExp");
                        oSql.AppendLine("ORDER BY FDDateUpd DESC");
                        var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                        return oDataCpn;
                    }
                    else
                    {
                        oSql.AppendLine("SELECT FTStmCode");
                        oSql.AppendLine(",FTTmnNum");
                        oSql.AppendLine(",FDDateIns");
                        oSql.AppendLine(",FTCpnCode");
                        oSql.AppendLine(",FCCpnAmt");
                        oSql.AppendLine(",FDCpnExp");
                        oSql.AppendLine(",FTCpnUseSta");
                        oSql.AppendLine(",FTWhoIns");
                        oSql.AppendLine("FROM TPSTCpnStatus ");
                        oSql.AppendLine("WHERE FTStmCode = '" + poCpnSearchReq.tCML_StmCode + "' ");
                        oSql.AppendLine("AND FTCpnUseSta = '" + poCpnSearchReq.tCML_CpnUseSta + "'");
                        oSql.AppendLine("ORDER BY FDDateUpd DESC");
                        var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                        return oDataCpn;
                    }
                }
                else if (poCpnSearchReq.tCML_StmCode == "")
                {
                    if (poCpnSearchReq.tCML_CpnUseSta == "0")
                    {
                        oSql.AppendLine("SELECT FTStmCode");
                        oSql.AppendLine(",FTTmnNum");
                        oSql.AppendLine(",FDDateIns");
                        oSql.AppendLine(",FTCpnCode");
                        oSql.AppendLine(",FCCpnAmt");
                        oSql.AppendLine(",FDCpnExp");
                        oSql.AppendLine(",FTCpnUseSta");
                        oSql.AppendLine(",FTWhoIns");
                        oSql.AppendLine("FROM TPSTCpnStatus ");
                        oSql.AppendLine("WHERE FTCpnUseSta = '" + poCpnSearchReq.tCML_CpnUseSta + "' ");
                        oSql.AppendLine("AND Getdate() < FDCpnExp");
                        oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                        var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                        return oDataCpn;
                    }
                    else
                    {
                        oSql.AppendLine("SELECT FTStmCode");
                        oSql.AppendLine(",FTTmnNum");
                        oSql.AppendLine(",FDDateIns");
                        oSql.AppendLine(",FTCpnCode");
                        oSql.AppendLine(",FCCpnAmt");
                        oSql.AppendLine(",FDCpnExp");
                        oSql.AppendLine(",FTCpnUseSta");
                        oSql.AppendLine(",FTWhoIns");
                        oSql.AppendLine("FROM TPSTCpnStatus ");
                        oSql.AppendLine("WHERE FTCpnUseSta = '" + poCpnSearchReq.tCML_CpnUseSta + "' ");
                        oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                        var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                        return oDataCpn;
                    }
                }
                else
                {
                    oSql.AppendLine("SELECT FTStmCode");
                    oSql.AppendLine(",FTTmnNum");
                    oSql.AppendLine(",FDDateIns");
                    oSql.AppendLine(",FTCpnCode");
                    oSql.AppendLine(",FCCpnAmt");
                    oSql.AppendLine(",FDCpnExp");
                    oSql.AppendLine(",FTCpnUseSta");
                    oSql.AppendLine(",FTWhoIns");
                    oSql.AppendLine("FROM TPSTCpnStatus ");
                    oSql.AppendLine("WHERE FTStmCode = '" + poCpnSearchReq.tCML_StmCode + "' ");
                    oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                    var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                    return oDataCpn;
                }
            }
            catch (SqlException oEx)
            {
                throw oEx;
            }
        }

        public DataTable C_GEToDataCpnCode(cmlCouponCode poCouponCode)
        {
            StringBuilder oSql;
            try
            {
                oSql = new StringBuilder();
                if (poCouponCode.tCML_CpnCode != "")
                {
                    oSql.AppendLine("SELECT FTStmCode");
                    oSql.AppendLine(",FTTmnNum");
                    oSql.AppendLine(",FDDateIns");
                    oSql.AppendLine(",FTCpnCode");
                    oSql.AppendLine(",FCCpnAmt");
                    oSql.AppendLine(",FDCpnExp");
                    oSql.AppendLine(",FTCpnUseSta");
                    oSql.AppendLine(",FTWhoIns");
                    oSql.AppendLine("FROM TPSTCpnStatus ");
                    oSql.AppendLine("WHERE FTCpnCode = '" + poCouponCode.tCML_CpnCode + "'");
                    oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                    var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                    return oDataCpn;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException oEx)
            {
                throw oEx;
            }
        }
        public DataTable C_GEToDataCpnStatusAll()
        {
            StringBuilder oSql;
            try
            {
                oSql = new StringBuilder();
                oSql.AppendLine("SELECT FTStmCode");
                oSql.AppendLine(",FTTmnNum");
                oSql.AppendLine(",FDDateIns");
                oSql.AppendLine(",FTCpnCode");
                oSql.AppendLine(",FCCpnAmt");
                oSql.AppendLine(",FDCpnExp");
                oSql.AppendLine(",FTCpnUseSta");
                oSql.AppendLine(",FTWhoIns");
                oSql.AppendLine("FROM TPSTCpnStatus ");
                oSql.AppendLine("ORDER BY FDDateUpd DESC ");
                var oDataCpn = cCNSP.SP_GEToDbTbl(oSql.ToString());
                return oDataCpn;
            }
            catch (SqlException oEx)
            {
                throw oEx;
            }
        }
    }
}