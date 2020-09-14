using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class DynamicProperty : DynamicsModel
    {
        [JsonProperty("dynamicpropertyid")]
        public Guid? DynamicPropertyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("datatype")]
        public string DataType { get; set; }

        [JsonProperty("defaultvalueinteger")]
        public long? DefaultValueInteger { get; set; }

        [JsonProperty("defaultvaluestring")]
        public string DefaultValueString { get; set; }

        [JsonProperty("defaultvaluedecimal")]
        public decimal? DefaultValueDecimal { get; set; }

        [JsonProperty("basedynamicpropertyid")]
        public string BaseDynamicPropertyId { get; set; }

        [JsonProperty("basedynamicpropertyidname")]
        public string BaseDynamicPropertyIdName { get; set; }

        [JsonProperty("minvaluedecimal")]
        public decimal? MinValueDecimal { get; set; }

        [JsonProperty("maxvaluedecimal")]
        public decimal? MaxValueDecimal { get; set; }

        [JsonProperty("precision")]
        public long? Precision { get; set; }

        [JsonProperty("statecode")]
        public string statecode { get; set; }

        [JsonProperty("statuscode")]
        public string statuscode { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("defaultvaluedouble")]
        public double? DefaultValueDouble { get; set; }

        [JsonProperty("minvaluedouble")]
        public double? MinValueDouble { get; set; }

        [JsonProperty("maxvaluedouble")]
        public double? MaxValueDouble { get; set; }

        [JsonProperty("minvalueinteger")]
        public long? MinValueInteger { get; set; }

        [JsonProperty("maxvalueinteger")]
        public long? MaxValueInteger { get; set; }

        [JsonProperty("isreadonly")]
        public bool? IsReadOnly { get; set; }

        [JsonProperty("ishidden")]
        public bool? IsHidden { get; set; }

        [JsonProperty("isrequired")]
        public bool? IsRequired { get; set; }

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

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

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

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("overwrittendynamicpropertyid")]
        public Guid? OverwrittenDynamicPropertyId { get; set; }

        [JsonProperty("rootdynamicpropertyid")]
        public Guid? RootDynamicPropertyId { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("maxlengthstring")]
        public long? MaxLengthString { get; set; }

        [JsonProperty("defaultvalueoptionset")]
        public string DefaultValueOptionSet { get; set; }

        [JsonProperty("defaultvalueoptionsetname")]
        public string DefaultValueOptionSetName { get; set; }

        [JsonProperty("statecodename")]
        public string statecodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string statuscodeName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("dmtimportstate")]
        public long? DMTImportState { get; set; }

        [JsonProperty("isreadonlyname")]
        public string IsReadOnlyName { get; set; }

        [JsonProperty("ishiddenname")]
        public string IsHiddenName { get; set; }

        [JsonProperty("isrequiredname")]
        public string IsRequiredName { get; set; }

        [JsonProperty("datatypename")]
        public string DataTypeName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }


    }
}

