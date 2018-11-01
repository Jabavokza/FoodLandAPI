using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoodLandAPI.Interfaces
{
    /// <summary>
    /// เป็น Interfaces ของ Class cAccessToKen
    /// </summary> 
   public interface IAccessToKen
    {
        string C_GETtGennerateAccessToken(string ptCpnCode,int nMinute );
        string C_GETtVerifyAccessToken(string ptAccessToken);

    }
}
