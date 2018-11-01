using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    /// <summary>
    /// Models หมายเลขโทเคน แบบ JWT
    /// </summary>
    public class cmlJWTPlayload
    {
        [JsonProperty("Token")]
        public string tCJ_Token { get; set; }
        [JsonProperty("Exp")]
        public DateTime dCJ_Exp { get; set; }
    }
}