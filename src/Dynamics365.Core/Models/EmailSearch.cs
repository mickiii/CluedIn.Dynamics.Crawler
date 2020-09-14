using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EmailSearch : DynamicsModel
    {
        [JsonProperty("emailsearchid")]
        public Guid? EmailSearchId { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("emailcolumnnumber")]
        public long? EmailColumnNumber { get; set; }

        [JsonProperty("parentobjectid")]
        public string ParentObjectId { get; set; }

        [JsonProperty("parentobjecttypecode")]
        public string ParentObjectTypeCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

