using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    public class cmlCpnSearchRes
    {

        [JsonProperty("DateIns")]
        public string tCML_DateIns { get; set; }
        [JsonProperty("WhoIns")]
        public string tCML_WhoIns { get; set; }
        [JsonProperty("StmCode")]
        public string tCML_StmCode { get; set; }
        [JsonProperty("TmnNum")]
        public string tCML_TmnNum { get; set; }
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
        [JsonProperty("CpnUseSta")]
        public string tCML_CpnUseSta { get; set; }
        [JsonProperty("CpnExp")]
        public string tCML_CpnExp { get; set; }
        [JsonProperty("CpnAmt")]
        public string tCML_CpnAmt { get; set; }


    }
}