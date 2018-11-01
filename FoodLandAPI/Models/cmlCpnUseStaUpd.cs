using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    public class cmlCpnUseStaUpd
    {
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
        [JsonProperty("CpnUseSta")]
        public string tCML_CpnUseSta { get; set; }
    }
}