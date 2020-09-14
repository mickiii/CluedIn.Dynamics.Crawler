using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class UserSearchFacet : DynamicsModel
    {
        [JsonProperty("usersearchfacetid")]
        public Guid? UserSearchFacetId { get; set; }

        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("attributename")]
        public string AttributeName { get; set; }

        [JsonProperty("facetorder")]
        public long? FacetOrder { get; set; }


    }
}

