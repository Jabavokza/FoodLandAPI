using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodLandAPI.Models
{
    public class cmlLoginForConfigDBs
    {
        [JsonProperty("UserName")]
        public string tCML_UserName { get; set; }
        [JsonProperty("UserPws")]
        public string tCML_UserPws { get; set; }
    }
}