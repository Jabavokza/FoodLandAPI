using ManagementAPI.Modale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace ManagementAPI.X_Class
{
   public class cSetting
    {
        public void C_SETxSetting(cmlConnectDB poConnectDB)
        {
            try
            {
                string tXMLPath = "Setting.xml";

                var oResult = new XElement("Setting",
                                         new XElement("DbLocation", poConnectDB.tCML_Server),
                                         new XElement("DbName", poConnectDB.tCML_Database),
                                         new XElement("User", poConnectDB.tCML_Username),
                                         new XElement("Password", poConnectDB.tCML_Password),
                                         new XElement("URL", poConnectDB.tCML_Url),
                                         new XElement("UserName", "009"),
                                         new XElement("UserPwd", "009")
                                         
                                         );
                oResult.Save(tXMLPath);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        public cmlConnectDB C_GEToSetting()
        {
            string tXMLPath = string.Empty;
            try
            {
                tXMLPath = "Setting.xml";
                var oConBD = new cmlConnectDB();
                var oXElement = XElement.Load(tXMLPath);

                oConBD.tCML_Server = oXElement.Element("DbLocation").Value;

                oConBD.tCML_Database = oXElement.Element("DbName").Value;

                oConBD.tCML_Username = oXElement.Element("User").Value;

                oConBD.tCML_Password = oXElement.Element("Password").Value;

                oConBD.tCML_Url = oXElement.Element("URL").Value;

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
