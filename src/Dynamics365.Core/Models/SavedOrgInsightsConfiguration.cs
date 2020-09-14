using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SavedOrgInsightsConfiguration : DynamicsModel
    {
        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("savedorginsightsconfigurationid")]
        public Guid? SavedOrgInsightsConfigurationId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("plotoption")]
        public string PlotOption { get; set; }

        [JsonProperty("plotoptionname")]
        public string PlotOptionName { get; set; }

        [JsonProperty("lookback")]
        public string Lookback { get; set; }

        [JsonProperty("lookbackname")]
        public string LookbackName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isdefault")]
        public bool? IsDefault { get; set; }

        [JsonProperty("isdefaultname")]
        public string IsDefaultName { get; set; }

        [JsonProperty("parameters")]
        public string Parameters { get; set; }

        [JsonProperty("metrictype")]
        public string MetricType { get; set; }

        [JsonProperty("metrictypename")]
        public string MetricTypeName { get; set; }

        [JsonProperty("jsondata")]
        public string JsonData { get; set; }

        [JsonProperty("isdrilldown")]
        public bool? IsDrilldown { get; set; }

        [JsonProperty("isdrilldownname")]
        public string IsDrilldownName { get; set; }

        [JsonProperty("jsondatastarttime")]
        public DateTimeOffset? JsonDataStartTime { get; set; }

        [JsonProperty("jsondataendtime")]
        public DateTimeOffset? JsonDataEndTime { get; set; }


    }
}

