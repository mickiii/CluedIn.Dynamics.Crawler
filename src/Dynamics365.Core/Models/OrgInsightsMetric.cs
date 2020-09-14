using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class OrgInsightsMetric : DynamicsModel
    {
        [JsonProperty("orginsightsmetricid")]
        public Guid? OrgInsightsMetricId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("internalname")]
        public string InternalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metrictype")]
        public string MetricType { get; set; }

        [JsonProperty("metrictypename")]
        public string MetricTypeName { get; set; }


    }
}

