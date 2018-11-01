
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace ManagementAPI.ST_Class
{

    public static class cCNSP
    {


        /// <summary>
        /// ConnectDataBase
        /// </summary>
        /// <param name="ptSql"></param>
        /// <returns></returns>
        public static DataTable SP_GEToDbName(string ptServerName, string ptUserName, string ptUserPwd)
        {
            SqlConnection oDbCon;
            DataTable oDbTbl;
            SqlDataAdapter oDbAdt;
            StringBuilder oStrCon;
            StringBuilder oStrSql;
            try
            {
                oStrCon = new StringBuilder();
                oStrSql = new StringBuilder();
                oDbTbl = new DataTable();
                oDbCon = new SqlConnection();
                oStrCon.AppendLine("Data Source = '" + ptServerName + "';");
                oStrCon.AppendLine("User ID = '" + ptUserName + "';");
                oStrCon.AppendLine("Password = '" + ptUserPwd + "'");
                oStrSql.AppendLine("SELECT NAME");
                oStrSql.AppendLine("FROM sys.databases");
                oDbCon.ConnectionString = oStrCon.ToString();
                oDbCon.Open();
                oDbAdt = new SqlDataAdapter(oStrSql.ToString(), oDbCon);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
            finally
            {
                oDbCon = null;
                oDbAdt = null;

            }

        }



    }
}

