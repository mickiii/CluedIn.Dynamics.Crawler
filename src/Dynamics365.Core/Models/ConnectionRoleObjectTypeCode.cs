using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ConnectionRoleObjectTypeCode : DynamicsModel
    {
        [JsonProperty("connectionroleid")]
        public string ConnectionRoleId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("connectionroleobjecttypecodeid")]
        public Guid? ConnectionRoleObjectTypeCodeId { get; set; }

        [JsonProperty("associatedobjecttypecode")]
        public string AssociatedObjectTypeCode { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("connectionroleidname")]
        public string ConnectionRoleIdName { get; set; }


    }
}

