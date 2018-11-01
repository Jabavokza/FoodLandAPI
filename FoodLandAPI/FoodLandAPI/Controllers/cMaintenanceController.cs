using FoodLandAPI.Class;
using FoodLandAPI.Class.Coupon;
using FoodLandAPI.Class.CouponSearch;
using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Class.X_Class;
using FoodLandAPI.Interfaces;
using FoodLandAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace FoodLandAPI.Controllers
{
    [RoutePrefix("api")]
    public class cMaintenanceController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cMaintenanceController));

        private ICpnSearch oC_DataCpnSearch;
        private ICoupon oCouponUpdate;

        public cMaintenanceController()
        {
            this.oC_DataCpnSearch = new cDataCpnSearch();
            this.oCouponUpdate = new cCouponUpdate();
        }

        [Route("coupon/SETConfigDB")]
        [HttpPost]
        public void POSToConfigDB([FromBody] cmlConnectDB poConnectDB)
        {
            try
            {
                var oConfigDB = new cConfigDB();
                oConfigDB.C_SETxConfigDB(poConnectDB);
            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
        [Route("coupon/GETConfigDB")]
        [HttpGet]
        public cmlConnectDB GEToConfigDB()
        {
            try
            {
                var oConfigDB = new cConfigDB();
                var oConnectDB = oConfigDB.C_GEToConfigDB();
                return oConnectDB;
            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }

        [Route("coupon/CpnStatusAll")]
        [HttpGet]
        public HttpResponseMessage GEToDataCpnStatusAll()
        {
            try
            {
                var oDataCpn = oC_DataCpnSearch.C_GEToDataCpnStatusAll();
                return SEToDataTableToJson(oDataCpn);
            }
            catch (WebException oEx)
            {
                throw oEx;
            }
        }

        [Route("coupon/CpnSearchByCpnCode")]
        [HttpPost]
        public HttpResponseMessage GEToDataCpnCode([FromBody] cmlCouponCode poCouponCode)
        {
            try
            {
                var oDataCpn = oC_DataCpnSearch.C_GEToDataCpnCode(poCouponCode);
                return SEToDataTableToJson(oDataCpn);
            }
            catch (WebException oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx); 
            }
        }

        [Route("coupon/CpnSearchByGroup")]
        [HttpPost]
        public HttpResponseMessage GEToDataCpnByGroup([FromBody] cmlCpnSearchReq poCpnSearchReq)
        {
            try
            {
                var oDataCpn = oC_DataCpnSearch.C_GEToDataCpnByGroup(poCpnSearchReq);
                return SEToDataTableToJson(oDataCpn);
            }
            catch (WebException oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }

        [Route("coupon/CpnUseStaUpd")]
        [HttpPost]
        public string PUToDataCpnByGroup( [FromBody] cmlCpnUseStaUpd poCpnUseStaUpd)
        {
            try
            {
                var oDataCpn = oCouponUpdate.C_SETxCpnUseStaUpd(poCpnUseStaUpd.tCML_CpnCode, poCpnUseStaUpd.tCML_CpnUseSta);
                return oDataCpn;
            }
            catch (WebException oEx)
            {
                return oEx.Message;
            }
        }
        private HttpResponseMessage SEToDataTableToJson(DataTable poResult)
        {
            try
            {
                var oResponse = this.Request.CreateResponse(HttpStatusCode.OK);
                var tJStr = JsonConvert.SerializeObject(poResult, Formatting.Indented);
                oResponse.Content = new StringContent(tJStr, Encoding.UTF8, "application/json");
                return oResponse;
            }
            catch (WebException oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
    }
}
