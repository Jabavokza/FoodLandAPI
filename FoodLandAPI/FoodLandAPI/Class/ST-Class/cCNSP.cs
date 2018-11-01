using FoodLandAPI.Models;
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

namespace FoodLandAPI.Class.ST_Class
{
    public static class cCNSP
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCNSP));
        // private static string tSP_StrCon = "Data Source=MR-A5UB4SUMEGT0\\SQLEXPRESS;Initial Catalog=MEMBERHQ;Integrated Security=True";
        // private static string tSP_StrCon = "Data Source = JABAVOKZA\\SQLEXPRESS;Initial Catalog = MEMBERHQ;User ID = sa;Password = P@ssw0rd";
        // private static string tSP_StrCon = "Data Source=172.16.30.151;Initial Catalog=MEMBERHQFL;Connection Timeout=30;Connection Lifetime=0;Min Pool Size=0;Max Pool Size=15;Pooling=true;User ID=sa;Password = P@ssw0rd";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptSql"></param>
        /// <returns></returns>
        public static DataTable SP_GEToDbTbl(string ptSql)
        {
            SqlConnection oDbCon = new SqlConnection();
            DataTable oDbTbl = new DataTable();
            SqlDataAdapter oDbAdt;
            try
            {
                oDbCon.ConnectionString = SP_GETtStrCon();
                oDbCon.Open();
                oDbAdt = new SqlDataAdapter(ptSql, oDbCon);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
            finally
            {
                oDbCon = null;
                oDbAdt = null;
            }
        }




        /// <summary>
        /// ConnectDataBase
        /// </summary>
        /// <param name="ptSql"></param>
        /// <returns></returns>
        public static int SP_SETnDbTbl(string ptSql)
        {
            SqlConnection oDbCon = new SqlConnection();
            SqlCommand oDbCmd = new SqlCommand();
            DataTable oDbTbl = new DataTable();
            try
            {
                oDbCon.ConnectionString = SP_GETtStrCon();
                oDbCon.Open();
                oDbCmd.Connection = oDbCon;
                oDbCmd.CommandText = ptSql;
                var nResult = oDbCmd.ExecuteNonQuery();
                oDbCon.Close();
                return nResult;
            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
            finally
            {
                oDbCon = null;

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string SP_GETtStrCon()
        {
            string tCon = string.Empty;
            string tXMLPath = string.Empty;
            try
            {
                var oConBD = new cmlConnectDB();
                tXMLPath = HttpContext.Current.Server.MapPath("~/Config/Setting.xml");
                var oXElement = XElement.Load(tXMLPath);

                oConBD.tCML_Server = oXElement.Element("DbLocation").Value;

                oConBD.tCML_Database = oXElement.Element("DbName").Value;

                oConBD.tCML_Username = oXElement.Element("User").Value;

                oConBD.tCML_Password = oXElement.Element("Password").Value;

                tCon = "Data Source = " + oConBD.tCML_Server
                    + "; Initial Catalog = " + oConBD.tCML_Database
                    + ";Connection Timeout=30;Connection Lifetime=0;Min Pool Size=0;Max Pool Size=30;Pooling=true "
                    + "; User ID = " + oConBD.tCML_Username
                    + "; Password = " + oConBD.tCML_Password + ";";

                return tCon;
            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                return oEx.Message;
            }
            finally
            {

            }
        }


    }
}

