using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TeamTemplate : DynamicsModel
    {
        [JsonProperty("defaultaccessrightsmask")]
        public long? DefaultAccessRightsMask { get; set; }

        [JsonProperty("teamtemplatename")]
        public string TeamTemplateName { get; set; }

        [JsonProperty("teamtemplateid")]
        public Guid? TeamTemplateId { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("issystem")]
        public bool? IsSystem { get; set; }

        [JsonProperty("issystemname")]
        public string IsSystemName { get; set; }


    }
}

