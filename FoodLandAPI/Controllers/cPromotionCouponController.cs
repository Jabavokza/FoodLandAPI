using FoodLandAPI.Class;
using FoodLandAPI.Class.Coupon.CouponLog;
using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Interfaces;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodLandAPI.Controllers
{
    [RoutePrefix("api")]
    public class cPromotionCouponController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cPromotionCouponController));
        private IAccessToKen oC_AccessToKen;
        public cCouponLog oC_CouponLog;
        private cmlCouponRes oC_CouponRes;
        private cCouponCreate oC_CouponCreate;
        private cmlCouponReq oC_CouponReq;
        private cCouponSale oC_CouponSale;
        private cCouponRefund oC_CouponRefund;
        private cCouponVoid oC_CouponVoid;
        private string tC_Message;

        protected cPromotionCouponController()
        {
            this.oC_AccessToKen = new cJWTAccessToKen();
        }


        [Route("coupon/Create")]
        [HttpPost]
        public IHttpActionResult POSToCreate([FromBody] cmlCouponReq poPara)
        {
            try
            {
                oC_CouponLog = new cCouponLog();
                oC_CouponRes = new cmlCouponRes();
                oC_CouponCreate = new cCouponCreate();
                if (ModelState.IsValid)
                {
                    tC_Message = oC_CouponCreate.c_SETtCouponCreate(poPara);

                    return Json(new { tcml_CpnMSg = tC_Message });
                    //  return Json(new { Message = tMessage, AccessToken = this.oAccessToKen.C_GETtGennerateAccessToken(poPara.tcml_WhoIns,5) });
                }
                else
                {
                    log.Warn(ModelState.C_GETtErrorModaleSta());

                    return Json(ModelState.C_GETtErrorModaleSta());
                }
            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx) + ModelState.C_GETtErrorModaleSta());

                return Json(new { ModelState = ModelState.C_GETtErrorModaleSta(), Exception = cExtensionMessageError.C_GEToErrorException(oEx) });
            }
            finally
            {
                oC_CouponLog.CL_SETxCouponLog(poPara, null, oC_CouponRes, tC_Message);
            }
        }

        [Route("coupon/Sale")]
        [HttpPost]
        public IHttpActionResult POSToSale([FromBody] cmlCouponCode poPara)
        {

            try
            {
                oC_CouponRes = new cmlCouponRes();
                oC_CouponReq = new cmlCouponReq();
                oC_CouponSale = new cCouponSale();
                oC_CouponLog = new cCouponLog();
                if (ModelState.IsValid)
                {
                    oC_CouponRes = oC_CouponSale.c_CHKoCouponSale(poPara);
                    return Json(oC_CouponRes);
                }
                else
                {
                    return Json(oC_CouponRes);
                }

            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                return Json(new { ModelState = ModelState.C_GETtErrorModaleSta(), Exception = cExtensionMessageError.C_GEToErrorException(oEx) });
            }

            finally
            {
                oC_CouponLog.CL_SETxCouponLog(oC_CouponReq, poPara, oC_CouponRes, null);
            }
        }

        [Route("coupon/Refund")]
        [HttpPost]
        public IHttpActionResult POSToRefund([FromBody] cmlCouponCode poPara)
        {

            oC_CouponLog = new cCouponLog();
            try
            {
                oC_CouponRes = new cmlCouponRes();
                oC_CouponRefund = new cCouponRefund();
                oC_CouponReq = new cmlCouponReq();
                if (ModelState.IsValid)
                {
                    oC_CouponRes = oC_CouponRefund.c_SEToCouponRefund(poPara);
                    return Json(oC_CouponRes);
                }
                else
                {
                    return Json(oC_CouponRes);
                }

            }
            catch (Exception oEx)
            {
                return Json(new { ModelState = ModelState.C_GETtErrorModaleSta(), Exception = cExtensionMessageError.C_GEToErrorException(oEx) });
            }

            finally
            {
                oC_CouponLog.CL_SETxCouponLog(oC_CouponReq, poPara, oC_CouponRes, null);
            }
        }
        [Route("coupon/Void")]
        [HttpPost]
        public IHttpActionResult POSToVoid([FromBody] cmlCouponCode poPara)
        {
            try
            {
                oC_CouponRes = new cmlCouponRes();
                oC_CouponReq = new cmlCouponReq();
                oC_CouponVoid = new cCouponVoid();
                oC_CouponLog = new cCouponLog();
                if (ModelState.IsValid)
                {
                    oC_CouponRes = oC_CouponVoid.c_SEToCouponVoid(poPara);
                    return Json(oC_CouponRes);
                }
                else
                {
                    return Json(oC_CouponRes);
                }

            }
            catch (Exception oEx)
            {
                log.Error(cExtensionMessageError.C_GEToErrorException(oEx));
                return Json(new { ModelState = ModelState.C_GETtErrorModaleSta(), Exception = cExtensionMessageError.C_GEToErrorException(oEx) });
            }
            finally
            {
                oC_CouponLog.CL_SETxCouponLog(oC_CouponReq, poPara, oC_CouponRes, null);
            }
        }
    }
}
