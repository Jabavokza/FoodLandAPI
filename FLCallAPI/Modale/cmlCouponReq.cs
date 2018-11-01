using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Text;

namespace FLCallAPI.Modale
{
    public class cmlCouponReq
    {

        [JsonProperty("WhoUpd")]
        public string tCML_WhoUpd { get; set; }
       
        [JsonProperty("WhoIns")]
        public string tCML_WhoIns { get; set; }
       
        [JsonProperty("StmCode")]
        public string tCML_StmCode { get; set; }
      
        [JsonProperty("TmnNum")]
        public string tCML_TmnNum { get; set; }
        
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
        [JsonProperty("CpnExp")]
        public string tCML_CpnExp { get; set; }
       
        [JsonProperty("CpnAmt")]
        public string tCML_CpnAmt { get; set; }
    }
}
