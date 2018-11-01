using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Class.X_Class;
using FoodLandAPI.Interfaces;
using FoodLandAPI.Models;
using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FoodLandAPI.Class
{
    public class cJWTAccessToKen : IAccessToKen

    {
        cAuthenticationHandler oC_AuthenticationHandler = new cAuthenticationHandler();
        private byte[] bC_SecretKey = Encoding.UTF8.GetBytes("Foodland PostCenter");

        /// <summary>
        /// สร้าง JWTAccessToKen
        /// </summary>
        /// <param name="ptCpnCode"></param>
        /// <param name="nMinute"></param>
        /// <returns></returns>
        public string C_GETtGennerateAccessToken(string ptToken, int nMinute)
        {
            try
            {
                cmlJWTPlayload oJWTPlayload = new cmlJWTPlayload
                {
                    tCJ_Token = ptToken,
                    dCJ_Exp = DateTime.UtcNow.AddMinutes(nMinute)
                };

                return JWT.Encode(oJWTPlayload, bC_SecretKey, JwsAlgorithm.HS256);
            }
            catch (Exception oEx)
            {
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }

        }

        /// <summary>
        /// ตรวจสอบ JWTAccessToKen
        /// </summary>
        /// <param name="ptAccessToken"></param>
        /// <returns></returns>
        public string C_GETtVerifyAccessToken(string ptAccessToken)
        {

            try
            {
                var oJWTPlayload = JWT.Decode<cmlJWTPlayload>(ptAccessToken, bC_SecretKey);
                if (oJWTPlayload.tCJ_Token.Equals("User001"))
                {
                    if (oJWTPlayload.dCJ_Exp < DateTime.Now)
                    {
                        // return oC_AuthenticationHandler.c_SETxAuthHandlerRes("", "Secction หมดอายุ", "An error has occurred.");
                    }
                    return null;
                }
                else
                {
                    // return oC_AuthenticationHandler.c_SETxAuthHandlerRes("", "Tokenไม่ถูกต้อง", "An error has occurred."); 
                    return null;
                }

            }
            catch (Exception oEx)
            {
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }


        }
    }
}