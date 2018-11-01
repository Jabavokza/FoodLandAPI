using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagementAPI.Modale
{
    public class cmlCpnUseStaUpd
    {
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
        [JsonProperty("CpnUseSta")]
        public string tCML_CpnUseSta { get; set; }
    }
}