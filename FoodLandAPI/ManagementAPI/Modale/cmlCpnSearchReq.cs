using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagementAPI.Modale
{
    public class cmlCpnSearchReq
    {
        [JsonProperty("StmCode")]
        public string tCML_StmCode { get; set; }
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
        [JsonProperty("CpnUseSta")]
        public string tCML_CpnUseSta { get; set; }
    }
}