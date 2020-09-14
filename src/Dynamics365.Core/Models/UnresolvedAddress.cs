using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class UnresolvedAddress : DynamicsModel
    {
        [JsonProperty("unresolvedaddressid")]
        public Guid? UnresolvedAddressId { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("emailaddress")]
        public string EMailAddress { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

