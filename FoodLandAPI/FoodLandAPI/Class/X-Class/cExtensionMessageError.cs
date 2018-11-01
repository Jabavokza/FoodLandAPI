
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace FoodLandAPI.Class
{
    public static class cExtensionMessageError
    {
        
        /// <summary>
        /// ปรับแต่ง Messagerror
        /// </summary>
        /// <param name="poModelSta"></param>
        /// <returns></returns>
        public static string C_GETtErrorModaleSta(this ModelStateDictionary poModelSta)
        {

            var modelerror = poModelSta.Values.Select(value => value.Errors).FirstOrDefault();
            if (modelerror == null)
            {
                return null;
            }
            return modelerror[0].ErrorMessage;
        }

        /// <summary>
        /// แสดงค่าError ในสุด
        /// </summary>
        /// <param name="oException"></param>
        /// <returns></returns>
        public static Exception C_GEToErrorException(this Exception oException)
        {
            if (oException.InnerException != null)
            {
                return oException.InnerException.C_GEToErrorException();
            }
            return oException;
        }

        /// <summary>
        /// แสดงค่าError ในสุด
        /// </summary>
        /// <param name="oException"></param>
        /// <returns></returns>
        public static Exception C_GEToErrorExceptionAccessToken(this Exception oException)
        {
            if (oException.InnerException != null)
            {
                return oException.InnerException.C_GEToErrorExceptionAccessToken();
            }
            return oException;
        }
    }
}