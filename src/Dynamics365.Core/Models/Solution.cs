using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Solution : DynamicsModel
    {
        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("installedon")]
        public DateTimeOffset? InstalledOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("publisherid")]
        public string PublisherId { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("isvisible")]
        public bool? IsVisible { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("uniquename")]
        public string UniqueName { get; set; }

        [JsonProperty("friendlyname")]
        public string FriendlyName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("publisheridname")]
        public string PublisherIdName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("publisheridprefix")]
        public string PublisherIdPrefix { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("publisheridoptionvalueprefix")]
        public long? PublisherIdOptionValuePrefix { get; set; }

        [JsonProperty("pinpointsolutionid")]
        public int? PinpointSolutionId { get; set; }

        [JsonProperty("pinpointsolutiondefaultlocale")]
        public string PinpointSolutionDefaultLocale { get; set; }

        [JsonProperty("pinpointpublisherid")]
        public int? PinpointPublisherId { get; set; }

        [JsonProperty("configurationpageid")]
        public string ConfigurationPageId { get; set; }

        [JsonProperty("configurationpageidname")]
        public string ConfigurationPageIdName { get; set; }

        [JsonProperty("pinpointassetid")]
        public string PinpointAssetId { get; set; }

        [JsonProperty("solutionpackageversion")]
        public string SolutionPackageVersion { get; set; }

        [JsonProperty("parentsolutionid")]
        public string ParentSolutionId { get; set; }

        [JsonProperty("parentsolutionidname")]
        public string ParentSolutionIdName { get; set; }

        [JsonProperty("isinternal")]
        public bool? IsInternal { get; set; }

        [JsonProperty("solutiontype")]
        public string SolutionType { get; set; }

        [JsonProperty("updatedon")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("isapimanaged")]
        public bool? IsApiManaged { get; set; }


    }
}

