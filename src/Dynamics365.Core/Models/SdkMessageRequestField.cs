using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SdkMessageRequestField : DynamicsModel
    {
        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("sdkmessagerequestfieldidunique")]
        public Guid? SdkMessageRequestFieldIdUnique { get; set; }

        [JsonProperty("optional")]
        public bool? Optional { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("position")]
        public long? Position { get; set; }

        [JsonProperty("clrparser")]
        public string ClrParser { get; set; }

        [JsonProperty("publicname")]
        public string PublicName { get; set; }

        [JsonProperty("sdkmessagerequestid")]
        public string SdkMessageRequestId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("parser")]
        public string Parser { get; set; }

        [JsonProperty("customizationlevel")]
        public long? CustomizationLevel { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("sdkmessagerequestfieldid")]
        public Guid? SdkMessageRequestFieldId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("fieldmask")]
        public long? FieldMask { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("parameterbindinginformation")]
        public string ParameterBindingInformation { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }


    }
}

