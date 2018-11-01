using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web;

 namespace ManagementAPI.Modale

{
    /// <summary>
    /// Models เชื่อมต่อ ดาต้าเบส
    /// </summary>
    public class cmlConnectDB
    {
        [JsonProperty("Server")]
        public string tCML_Server { get; set; }
        [JsonProperty("Database")]
        public string tCML_Database { get; set; }
        [JsonProperty("Username")]
        public string tCML_Username { get; set; }
        [JsonProperty("Password")]
        public string tCML_Password { get; set; }
        public string tCML_Url { get; set; }

    }
}