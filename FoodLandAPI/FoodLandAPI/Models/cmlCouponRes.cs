﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    /// <summary>
    /// Models ค่าที่ส่งออกไป
    /// </summary>
    public class cmlCouponRes
    {
        [JsonProperty("StatusCode")]
        public string tCML_StatusCode { get; set; }
        [JsonProperty("StatusDescTH")]
        public string tCML_StatusDescTH { get; set; }
        [JsonProperty("StatusDescEN")]
        public string tCML_StatusDescEN { get; set; }
        [JsonProperty("PrintDesc")]
        public string tCML_PrintDesc { get; set; }
        [JsonProperty("RefCode")]
        public string tCML_RefCode { get; set; }
        [JsonProperty("TranDateTime")]
        public string tCML_TranDateTime { get; set; }
        [JsonProperty("CpnAmt")]
        public string tCML_CpnAmt { get; set; }
    }
}