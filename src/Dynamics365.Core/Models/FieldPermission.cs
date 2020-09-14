using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class FieldPermission : DynamicsModel
    {
        [JsonProperty("canread")]
        public string CanRead { get; set; }

        [JsonProperty("canreadname")]
        public string CanReadName { get; set; }

        [JsonProperty("canupdate")]
        public string CanUpdate { get; set; }

        [JsonProperty("canupdatename")]
        public string CanUpdateName { get; set; }

        [JsonProperty("cancreate")]
        public string CanCreate { get; set; }

        [JsonProperty("cancreatename")]
        public string CanCreateName { get; set; }

        [JsonProperty("fieldsecurityprofileid")]
        public string FieldSecurityProfileId { get; set; }

        [JsonProperty("fieldpermissionid")]
        public Guid? FieldPermissionId { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("attributelogicalname")]
        public string AttributeLogicalName { get; set; }

        [JsonProperty("fieldpermissionidunique")]
        public Guid? FieldPermissionIdUnique { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }


    }
}

