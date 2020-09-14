using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class WorkflowDependency : DynamicsModel
    {
        [JsonProperty("parametername")]
        public string ParameterName { get; set; }

        [JsonProperty("relatedentityname")]
        public string RelatedEntityName { get; set; }

        [JsonProperty("relatedattributename")]
        public string RelatedAttributeName { get; set; }

        [JsonProperty("workflowid")]
        public string WorkflowId { get; set; }

        [JsonProperty("sdkmessageid")]
        public string SdkMessageId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("entityattributes")]
        public string EntityAttributes { get; set; }

        [JsonProperty("customentityname")]
        public string CustomEntityName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("dependententityname")]
        public string DependentEntityName { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("dependentattributename")]
        public string DependentAttributeName { get; set; }

        [JsonProperty("workflowdependencyid")]
        public Guid? WorkflowDependencyId { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("parametertype")]
        public string ParameterType { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }


    }
}

