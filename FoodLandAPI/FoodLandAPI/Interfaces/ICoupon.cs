using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLandAPI.Interfaces
{
   public interface ICoupon
    {
        string C_SETxCpnUseStaUpd(string ptCpnCode, string ptCpnUseSta);
    }
}
