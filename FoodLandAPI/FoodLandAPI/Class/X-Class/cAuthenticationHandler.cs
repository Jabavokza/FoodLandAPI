using FoodLandAPI.Interfaces;
using FoodLandAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace FoodLandAPI.Class.X_Class
{
    public class cAuthenticationHandler : DelegatingHandler
    {
        private IAccessToKen oC_AccessToKen;

        public cAuthenticationHandler()
        {
            this.oC_AccessToKen = new cBasicAccessToken();
        }
        /// <summary>
        /// ตรวจสอบ AccessToken
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                var oAuthorization = request.Headers.Authorization;
                if (oAuthorization != null)
                {
                    var tAccessToken = oAuthorization.Parameter;
                    var tAccessTokenType = oAuthorization.Scheme;
                    if (tAccessTokenType.Equals("Basic"))
                    {

                        if (this.oC_AccessToKen.C_GETtVerifyAccessToken(tAccessToken).Equals("false"))
                        {
                            return c_SETxAuthHandlerRes("001", "Token ไม่ถูกต้อง", "An error has occurred.");
                        }
                    }
                    else
                    {
                        return c_SETxAuthHandlerRes("002", "ชนิด Token ไม่ถูกต้อง", "An error has occurred.");
                    }
                }
                else
                {
                    return c_SETxAuthHandlerRes("003", "ไม่พบ Token ", "An error has occurred.");
                }
                return base.SendAsync(request, cancellationToken);
            }
            catch (Exception oEx)
            {
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
        /// <summary>
        /// Respond Message AuthenticationHandler
        /// </summary>
        /// <param name="ptCodeSta"></param>
        /// <param name="ptMessageTH"></param>
        /// <param name="ptMessageEN"></param>
        /// <returns></returns>
        public Task<HttpResponseMessage> c_SETxAuthHandlerRes(string ptCodeSta, string ptMessageTH, string ptMessageEN)
        {
            try
            {
                cAuthHandlerRes oC_AuthHandlerRes = new cAuthHandlerRes();
                oC_AuthHandlerRes.Code = ptCodeSta;
                oC_AuthHandlerRes.MessageTH = ptMessageTH;
                oC_AuthHandlerRes.MessageEN = ptMessageEN;
                var oC_HttpRespMssg = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(JToken.FromObject(oC_AuthHandlerRes).ToString(), System.Text.Encoding.UTF8, "application/json"),
                    StatusCode = HttpStatusCode.BadRequest
                };
                var oTsc = new TaskCompletionSource<HttpResponseMessage>();
                oTsc.SetResult(oC_HttpRespMssg);
                return oTsc.Task;
            }

            catch (Exception oEx)
            {
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
    }
}