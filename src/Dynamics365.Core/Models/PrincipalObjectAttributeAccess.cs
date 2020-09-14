using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PrincipalObjectAttributeAccess : DynamicsModel
    {
        [JsonProperty("principalobjectattributeaccessid")]
        public Guid? PrincipalObjectAttributeAccessId { get; set; }

        [JsonProperty("principalid")]
        public string PrincipalId { get; set; }

        [JsonProperty("attributeid")]
        public Guid? AttributeId { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("readaccess")]
        public bool? ReadAccess { get; set; }

        [JsonProperty("updateaccess")]
        public bool? UpdateAccess { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("principalidtype")]
        public string PrincipalIdType { get; set; }

        [JsonProperty("principalidname")]
        public string PrincipalIdName { get; set; }


    }
}

