using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;


namespace FoodLandAPI.Class.X_Class
{
    public class cConfigDB
    {
        public void C_SETxConfigDB(cmlConnectDB poConnectDB)
        {
            try
            {
                string tXMLPath = HttpContext.Current.Server.MapPath("~/Config/Setting.xml");

                XElement oResult = new XElement("ConfigDB",
                                         new XElement("DbLocation", poConnectDB.tCML_Server),
                                         new XElement("DbName", poConnectDB.tCML_Database),
                                         new XElement("User", poConnectDB.tCML_Username),
                                         new XElement("Password", poConnectDB.tCML_Password)
                                         );
                oResult.Save(tXMLPath);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        public cmlConnectDB C_GEToConfigDB()
        {
            string tCon = string.Empty;
            string tXMLPath = string.Empty;
            try
            {
                var oConBD = new cmlConnectDB();
                tXMLPath = HttpContext.Current.Server.MapPath("~/Config/Setting.xml");
                var oXElemente = XElement.Load(tXMLPath);

                oConBD.tCML_Server = oXElemente.Element("DbLocation").Value;

                oConBD.tCML_Database = oXElemente.Element("DbName").Value;

                oConBD.tCML_Username = oXElemente.Element("User").Value;

                oConBD.tCML_Password = oXElemente.Element("Password").Value;

                return oConBD;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
            finally
            {

            }
        }
    }
}