using FoodLandAPI.Class.ST_Class;
using FoodLandAPI.Interfaces;
using FoodLandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FoodLandAPI.Class.CouponSearch
{
    public class CpnSearchByGroup : ICpnSearch
    {
        public DataTable C_GEToDataCpnByGroup(cmlCpnSearchReq poCpnSearchReq)
        {
           
        }

        public DataTable C_GEToDataCpnCode(cmlCpnSearchReq poCpnSearchReq)
        {
            throw new NotImplementedException();
        }

        public DataTable C_GEToDataCpnStatusAll(cmlCpnSearchReq poCpnSearchReq)
        {
            throw new NotImplementedException();
        }
    }
}