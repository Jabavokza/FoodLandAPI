using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    /// <summary>
    /// Models ข้อมูลคูปองที่รับเข้ามา
    /// </summary>
    public class cmlCouponReq
    {
        [Required]
        [JsonProperty("WhoUpd")]
        public string tCML_WhoUpd { get; set; }
        [Required]
        [JsonProperty("WhoIns")]
        public string tCML_WhoIns { get; set; }
        [Required]
        [JsonProperty("StmCode")]
        public string tCML_StmCode { get; set; }
        [Required]
        [JsonProperty("TmnNum")]
        public string tCML_TmnNum { get; set; }
        [Required]
        [JsonProperty("CpnCode")]
        public string tCML_CpnCode { get; set; }
        [JsonProperty("CpnExp")]
        public string tCML_CpnExp { get; set; }
        [Required]
        [JsonProperty("CpnAmt")]
        public string tCML_CpnAmt { get; set; }
    }
}