using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FoodLandAPI.Class.X_Class
{
    public class cBasicAccessToken : IAccessToKen
    {
        //ไม่ได้ใช้
        public string C_GETtGennerateAccessToken(string ptCpnCode, int nMinute)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Check BasicToken
        /// </summary>
        /// <param name="ptAccessToken"></param>
        /// <returns></returns>
        public string C_GETtVerifyAccessToken(string ptAccessToken)
        {

            //string tUsernamePassword;
            //string tUsername;
            //string tPassword;
            //int nSeperatorIndex;
            //StringBuilder oSql;

            try
            {
                var oEncoding = Encoding.GetEncoding("iso-8859-1");
                var tUsernamePassword = oEncoding.GetString(Convert.FromBase64String(ptAccessToken));
                var nSeperatorIndex = tUsernamePassword.IndexOf(':');
                var tUsername = tUsernamePassword.Substring(0, nSeperatorIndex);
                var tPassword = tUsernamePassword.Substring(nSeperatorIndex + 1);

                if (tUsername.Equals("PA") && tPassword.Equals("001"))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
                //oSql = new StringBuilder();
                //oSql.AppendLine("SELECT * FROM TCNMEmpMtn ");
                //oSql.AppendLine("WHERE FTEmpFName = '" + tUsername + "'");
                //oSql.AppendLine("AND FTEmpPW = '" + tPassword + "'");

                //if (cCNSP.SP_GEToDbTbl(oSql.ToString()).Rows.Count > 0)
                //{
                //    return "true";
                //}
                //else
                //{  
                //    return "false";
                //}
            }
            catch (Exception oEx)
            {
                throw cExtensionMessageError.C_GEToErrorException(oEx);
            }
        }
    }
}