using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementAPI.Modale
{
   public class cmlCouponCode
    {
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }

    }
}
