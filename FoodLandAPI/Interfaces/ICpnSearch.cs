using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLandAPI.Interfaces
{
    public interface ICpnSearch
    {
        DataTable C_GEToDataCpnCode(cmlCouponCode poCouponCode);
        DataTable C_GEToDataCpnByGroup(cmlCpnSearchReq poCpnSearchReq);
        DataTable C_GEToDataCpnStatusAll();
    }
}
