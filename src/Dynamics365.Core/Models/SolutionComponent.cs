using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SolutionComponent : DynamicsModel
    {
        [JsonProperty("solutioncomponentid")]
        public Guid? SolutionComponentId { get; set; }

        [JsonProperty("componenttype")]
        public string ComponentType { get; set; }

        [JsonProperty("solutionid")]
        public string SolutionId { get; set; }

        [JsonProperty("ismetadata")]
        public bool? IsMetadata { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("solutionidname")]
        public string SolutionIdName { get; set; }

        [JsonProperty("componenttypename")]
        public string ComponentTypeName { get; set; }

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

        [JsonProperty("rootcomponentbehavior")]
        public string RootComponentBehavior { get; set; }

        [JsonProperty("rootsolutioncomponentid")]
        public Guid? RootSolutionComponentId { get; set; }


    }
}

