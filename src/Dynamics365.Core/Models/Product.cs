using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Product : DynamicsModel
    {
        [JsonProperty("productid")]
        public Guid? ProductId { get; set; }

        [JsonProperty("defaultuomscheduleid")]
        public string DefaultUoMScheduleId { get; set; }

        [JsonProperty("subjectid")]
        public string SubjectId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("defaultuomid")]
        public string DefaultUoMId { get; set; }

        [JsonProperty("pricelevelid")]
        public string PriceLevelId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("producttypecode")]
        public string ProductTypeCode { get; set; }

        [JsonProperty("producturl")]
        public string ProductUrl { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("iskit")]
        public bool? IsKit { get; set; }

        [JsonProperty("productnumber")]
        public string ProductNumber { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("currentcost")]
        public string CurrentCost { get; set; }

        [JsonProperty("stockvolume")]
        public decimal? StockVolume { get; set; }

        [JsonProperty("standardcost")]
        public string StandardCost { get; set; }

        [JsonProperty("stockweight")]
        public decimal? StockWeight { get; set; }

        [JsonProperty("quantitydecimal")]
        public long? QuantityDecimal { get; set; }

        [JsonProperty("quantityonhand")]
        public decimal? QuantityOnHand { get; set; }

        [JsonProperty("isstockitem")]
        public bool? IsStockItem { get; set; }

        [JsonProperty("suppliername")]
        public string SupplierName { get; set; }

        [JsonProperty("vendorname")]
        public string VendorName { get; set; }

        [JsonProperty("vendorpartnumber")]
        public string VendorPartNumber { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("defaultuomidname")]
        public string DefaultUoMIdName { get; set; }

        [JsonProperty("defaultuomscheduleidname")]
        public string DefaultUoMScheduleIdName { get; set; }

        [JsonProperty("pricelevelidname")]
        public string PriceLevelIdName { get; set; }

        [JsonProperty("subjectidname")]
        public string SubjectIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("isstockitemname")]
        public string IsStockItemName { get; set; }

        [JsonProperty("iskitname")]
        public string IsKitName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("producttypecodename")]
        public string ProductTypeCodeName { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("currentcost_base")]
        public string CurrentCost_Base { get; set; }

        [JsonProperty("price_base")]
        public string Price_Base { get; set; }

        [JsonProperty("standardcost_base")]
        public string StandardCost_Base { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

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

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("parentproductid")]
        public string ParentProductId { get; set; }

        [JsonProperty("parentproductidname")]
        public string ParentProductIdName { get; set; }

        [JsonProperty("productstructure")]
        public string ProductStructure { get; set; }

        [JsonProperty("productstructurename")]
        public string ProductStructureName { get; set; }

        [JsonProperty("vendorid")]
        public string VendorID { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("validfromdate")]
        public DateTimeOffset? ValidFromDate { get; set; }

        [JsonProperty("validtodate")]
        public DateTimeOffset? ValidToDate { get; set; }

        [JsonProperty("hierarchypath")]
        public string HierarchyPath { get; set; }

        [JsonProperty("dmtimportstate")]
        public long? DMTImportState { get; set; }

        [JsonProperty("createdbyexternalparty")]
        public string CreatedByExternalParty { get; set; }

        [JsonProperty("createdbyexternalpartyname")]
        public string CreatedByExternalPartyName { get; set; }

        [JsonProperty("createdbyexternalpartyyominame")]
        public string CreatedByExternalPartyYomiName { get; set; }

        [JsonProperty("modifiedbyexternalparty")]
        public string ModifiedByExternalParty { get; set; }

        [JsonProperty("modifiedbyexternalpartyname")]
        public string ModifiedByExternalPartyName { get; set; }

        [JsonProperty("modifiedbyexternalpartyyominame")]
        public string ModifiedByExternalPartyYomiName { get; set; }

        [JsonProperty("isreparented")]
        public bool? IsReparented { get; set; }

        [JsonProperty("isreparentedname")]
        public string isreparentedName { get; set; }


    }
}

