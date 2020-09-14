using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ServiceEndpoint : DynamicsModel
    {
        [JsonProperty("serviceendpointid")]
        public Guid? ServiceEndpointId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("solutionnamespace")]
        public string SolutionNamespace { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("contractname")]
        public string ContractName { get; set; }

        [JsonProperty("connectionmode")]
        public string ConnectionMode { get; set; }

        [JsonProperty("connectionmodename")]
        public string ConnectionModeName { get; set; }

        [JsonProperty("userclaim")]
        public string UserClaim { get; set; }

        [JsonProperty("userclaimname")]
        public string UserClaimName { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

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

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("serviceendpointidunique")]
        public Guid? ServiceEndpointIdUnique { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("authtype")]
        public string AuthType { get; set; }

        [JsonProperty("authtypename")]
        public string AuthTypeName { get; set; }

        [JsonProperty("messageformat")]
        public string MessageFormat { get; set; }

        [JsonProperty("saskey")]
        public string SASKey { get; set; }

        [JsonProperty("saskeyname")]
        public string SASKeyName { get; set; }

        [JsonProperty("messageformatname")]
        public string MessageFormatName { get; set; }

        [JsonProperty("sastoken")]
        public string SASToken { get; set; }

        [JsonProperty("namespaceformat")]
        public string NamespaceFormat { get; set; }

        [JsonProperty("namespaceformatname")]
        public string NamespaceFormatName { get; set; }

        [JsonProperty("namespaceaddress")]
        public string NamespaceAddress { get; set; }

        [JsonProperty("issastokenset")]
        public bool? IsSASTokenSet { get; set; }

        [JsonProperty("issaskeyset")]
        public bool? IsSASKeySet { get; set; }

        [JsonProperty("authvalue")]
        public string AuthValue { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isauthvalueset")]
        public bool? IsAuthValueSet { get; set; }


    }
}

