using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace FoodLandAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ViewResult ConfigDbs(cmlConnectDB poConnectDB)
        {
            //string tSQL = "Insert Into TCNMDBs(FTServer,FTDbName,FTUrsName,FTPwd)" +
            //    "Values('"+poConnectDB.tcml_Server+ "','" + poConnectDB.tcml_Database + "'," +
            //    "'" + poConnectDB.tcml_Username + "','" + poConnectDB.tcml_Password + "') ";

            //cCNSP.SP_GEToDbTbl(tSQL);

            string tXMLPath = Server.MapPath("~/Config/Setting.xml");
            //create 
            XElement oResult = new XElement("ConfigDB",
                                     new XElement("DbLocation", poConnectDB.tCML_Server),
                                     new XElement("DbName", poConnectDB.tCML_Database),
                                     new XElement("User", poConnectDB.tCML_Username),
                                     new XElement("Password", poConnectDB.tCML_Password)
                                     );
            oResult.Save(tXMLPath);

            return View();
        }
    }
}
