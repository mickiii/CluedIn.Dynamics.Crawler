using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SystemForm : DynamicsModel
    {
        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("formid")]
        public Guid? FormId { get; set; }

        [JsonProperty("formidunique")]
        public Guid? FormIdUnique { get; set; }

        [JsonProperty("formxml")]
        public string FormXml { get; set; }

        [JsonProperty("isdefault")]
        public bool? IsDefault { get; set; }

        [JsonProperty("isdefaultname")]
        public string IsDefaultName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("objecttypecodename")]
        public string ObjectTypeCodeName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("version")]
        public long? Version { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("publishedon")]
        public DateTimeOffset? PublishedOn { get; set; }

        [JsonProperty("ancestorformid")]
        public string AncestorFormId { get; set; }

        [JsonProperty("ancestorformidname")]
        public string AncestorFormIdName { get; set; }

        [JsonProperty("formxmlmanaged")]
        public string FormXmlManaged { get; set; }

        [JsonProperty("canbedeleted")]
        public string CanBeDeleted { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("isairmerged")]
        public bool? IsAIRMerged { get; set; }

        [JsonProperty("formpresentation")]
        public string FormPresentation { get; set; }

        [JsonProperty("formactivationstate")]
        public string FormActivationState { get; set; }

        [JsonProperty("formactivationstatename")]
        public string FormActivationStateName { get; set; }

        [JsonProperty("formpresentationname")]
        public string FormPresentationName { get; set; }

        [JsonProperty("istabletenabled")]
        public bool? IsTabletEnabled { get; set; }

        [JsonProperty("uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("isdesktopenabled")]
        public bool? IsDesktopEnabled { get; set; }

        [JsonProperty("formjson")]
        public string FormJson { get; set; }


    }
}

