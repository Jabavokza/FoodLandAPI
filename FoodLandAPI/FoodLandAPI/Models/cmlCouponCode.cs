using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    /// <summary>
    /// Models หมายเลขคูปอง
    /// </summary>
    public class cmlCouponCode
    {
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
    }
}