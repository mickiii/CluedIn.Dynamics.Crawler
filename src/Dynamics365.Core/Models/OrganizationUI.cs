using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class OrganizationUI : DynamicsModel
    {
        [JsonProperty("formid")]
        public Guid? FormId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("formxml")]
        public string FormXml { get; set; }

        [JsonProperty("fieldxml")]
        public string FieldXml { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("previewxml")]
        public string PreviewXml { get; set; }

        [JsonProperty("previewcolumnsetxml")]
        public string PreviewColumnsetXml { get; set; }

        [JsonProperty("version")]
        public long? Version { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("objecttypecodename")]
        public string ObjectTypeCodeName { get; set; }

        [JsonProperty("outlookshortcuticon")]
        public string OutlookShortcutIcon { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("gridicon")]
        public string GridIcon { get; set; }

        [JsonProperty("formidunique")]
        public Guid? FormIdUnique { get; set; }

        [JsonProperty("largeentityicon")]
        public string LargeEntityIcon { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }


    }
}

