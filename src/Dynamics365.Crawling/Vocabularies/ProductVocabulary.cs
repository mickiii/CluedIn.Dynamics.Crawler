using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ProductVocabulary : SimpleVocabulary
    {
        public ProductVocabulary()
        {
            VocabularyName = "Dynamics365 Product";
            KeyPrefix = "dynamics365.product";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Product", group =>
            {
                this.ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the product.")
                    .WithDisplayName("Product")
                    .ModelProperty("productid", typeof(Guid)));

                this.DefaultUoMScheduleId = group.Add(new VocabularyKey("DefaultUoMScheduleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"unit_of_measurement_schedule_products")
                    .WithDisplayName("Unit Group")
                    .ModelProperty("defaultuomscheduleid", typeof(string)));

                this.SubjectId = group.Add(new VocabularyKey("SubjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"subject_products")
                    .WithDisplayName("Subject")
                    .ModelProperty("subjectid", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"organization_products")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the product.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.DefaultUoMId = group.Add(new VocabularyKey("DefaultUoMId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"unit_of_measurement_products")
                    .WithDisplayName("Default Unit")
                    .ModelProperty("defaultuomid", typeof(string)));

                this.PriceLevelId = group.Add(new VocabularyKey("PriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"price_level_products")
                    .WithDisplayName("Default Price List")
                    .ModelProperty("pricelevelid", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the product.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ProductTypeCode = group.Add(new VocabularyKey("ProductTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of product.")
                    .WithDisplayName("Product Type")
                    .ModelProperty("producttypecode", typeof(string)));

                this.ProductUrl = group.Add(new VocabularyKey("ProductUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"URL for the Website associated with the product.")
                    .WithDisplayName("URL")
                    .ModelProperty("producturl", typeof(string)));

                this.Price = group.Add(new VocabularyKey("Price", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"List price of the product.")
                    .WithDisplayName("List Price")
                    .ModelProperty("price", typeof(string)));

                this.IsKit = group.Add(new VocabularyKey("IsKit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the product is a kit.")
                    .WithDisplayName("Is Kit")
                    .ModelProperty("iskit", typeof(bool)));

                this.ProductNumber = group.Add(new VocabularyKey("ProductNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"User-defined product ID.")
                    .WithDisplayName("Product ID")
                    .ModelProperty("productnumber", typeof(string)));

                this.Size = group.Add(new VocabularyKey("Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Product size.")
                    .WithDisplayName("Size")
                    .ModelProperty("size", typeof(string)));

                this.CurrentCost = group.Add(new VocabularyKey("CurrentCost", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Current cost for the product item. Used in price calculations.")
                    .WithDisplayName("Current Cost")
                    .ModelProperty("currentcost", typeof(string)));

                this.StockVolume = group.Add(new VocabularyKey("StockVolume", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Stock volume of the product.")
                    .WithDisplayName("Stock Volume")
                    .ModelProperty("stockvolume", typeof(decimal)));

                this.StandardCost = group.Add(new VocabularyKey("StandardCost", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Standard cost of the product.")
                    .WithDisplayName("Standard Cost")
                    .ModelProperty("standardcost", typeof(string)));

                this.StockWeight = group.Add(new VocabularyKey("StockWeight", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Stock weight of the product.")
                    .WithDisplayName("Stock Weight")
                    .ModelProperty("stockweight", typeof(decimal)));

                this.QuantityDecimal = group.Add(new VocabularyKey("QuantityDecimal", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of decimal places that can be used in monetary amounts for the product.")
                    .WithDisplayName("Decimals Supported")
                    .ModelProperty("quantitydecimal", typeof(long)));

                this.QuantityOnHand = group.Add(new VocabularyKey("QuantityOnHand", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Quantity of the product in stock.")
                    .WithDisplayName("Quantity On Hand")
                    .ModelProperty("quantityonhand", typeof(decimal)));

                this.IsStockItem = group.Add(new VocabularyKey("IsStockItem", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the product is a stock item.")
                    .WithDisplayName("Stock Item")
                    .ModelProperty("isstockitem", typeof(bool)));

                this.SupplierName = group.Add(new VocabularyKey("SupplierName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the product's supplier.")
                    .WithDisplayName("Supplier Name")
                    .ModelProperty("suppliername", typeof(string)));

                this.VendorName = group.Add(new VocabularyKey("VendorName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the product vendor.")
                    .WithDisplayName("Vendor")
                    .ModelProperty("vendorname", typeof(string)));

                this.VendorPartNumber = group.Add(new VocabularyKey("VendorPartNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Unique part identifier in vendor catalog of this product.")
                    .WithDisplayName("Vendor Name")
                    .ModelProperty("vendorpartnumber", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the product was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the product was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the product.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the product.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the product.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the product.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the product.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.DefaultUoMIdName = group.Add(new VocabularyKey("DefaultUoMIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("DefaultUoMIdName")
                    .ModelProperty("defaultuomidname", typeof(string)));

                this.DefaultUoMScheduleIdName = group.Add(new VocabularyKey("DefaultUoMScheduleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("DefaultUoMScheduleIdName")
                    .ModelProperty("defaultuomscheduleidname", typeof(string)));

                this.PriceLevelIdName = group.Add(new VocabularyKey("PriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PriceLevelIdName")
                    .ModelProperty("pricelevelidname", typeof(string)));

                this.SubjectIdName = group.Add(new VocabularyKey("SubjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SubjectIdName")
                    .ModelProperty("subjectidname", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.IsStockItemName = group.Add(new VocabularyKey("IsStockItemName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsStockItemName")
                    .ModelProperty("isstockitemname", typeof(string)));

                this.IsKitName = group.Add(new VocabularyKey("IsKitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsKitName")
                    .ModelProperty("iskitname", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.ProductTypeCodeName = group.Add(new VocabularyKey("ProductTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ProductTypeCodeName")
                    .ModelProperty("producttypecodename", typeof(string)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"transactioncurrency_product")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the product with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.CurrentCost_Base = group.Add(new VocabularyKey("CurrentCost_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the current cost for the product item.")
                    .WithDisplayName("Current Cost (Base)")
                    .ModelProperty("currentcost_base", typeof(string)));

                this.Price_Base = group.Add(new VocabularyKey("Price_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the list price of the product")
                    .WithDisplayName("List Price (Base)")
                    .ModelProperty("price_base", typeof(string)));

                this.StandardCost_Base = group.Add(new VocabularyKey("StandardCost_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the standard cost of the product.")
                    .WithDisplayName("Standard Cost (Base)")
                    .ModelProperty("standardcost_base", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the product.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the product.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default image for the record.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_products")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.ParentProductId = group.Add(new VocabularyKey("ParentProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the parent product family hierarchy.")
                    .WithDisplayName("Parent")
                    .ModelProperty("parentproductid", typeof(string)));

                this.ParentProductIdName = group.Add(new VocabularyKey("ParentProductIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentProductIdName")
                    .ModelProperty("parentproductidname", typeof(string)));

                this.ProductStructure = group.Add(new VocabularyKey("ProductStructure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Product Structure.")
                    .WithDisplayName("Product Structure")
                    .ModelProperty("productstructure", typeof(string)));

                this.ProductStructureName = group.Add(new VocabularyKey("ProductStructureName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ProductStructureName")
                    .ModelProperty("productstructurename", typeof(string)));

                this.VendorID = group.Add(new VocabularyKey("VendorID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Unique identifier of vendor supplying the product.")
                    .WithDisplayName("Vendor ID")
                    .ModelProperty("vendorid", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.ValidFromDate = group.Add(new VocabularyKey("ValidFromDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date from which this product is valid.")
                    .WithDisplayName("Valid From")
                    .ModelProperty("validfromdate", typeof(DateTime)));

                this.ValidToDate = group.Add(new VocabularyKey("ValidToDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date to which this product is valid.")
                    .WithDisplayName("Valid To")
                    .ModelProperty("validtodate", typeof(DateTime)));

                this.HierarchyPath = group.Add(new VocabularyKey("HierarchyPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"Hierarchy path of the product.")
                    .WithDisplayName("Hierarchy Path")
                    .ModelProperty("hierarchypath", typeof(string)));

                this.DMTImportState = group.Add(new VocabularyKey("DMTImportState", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Internal Use Only")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("dmtimportstate", typeof(long)));

                this.CreatedByExternalParty = group.Add(new VocabularyKey("CreatedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the external party who created the record.")
                    .WithDisplayName("Created By (External Party)")
                    .ModelProperty("createdbyexternalparty", typeof(string)));

                this.CreatedByExternalPartyName = group.Add(new VocabularyKey("CreatedByExternalPartyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByExternalPartyName")
                    .ModelProperty("createdbyexternalpartyname", typeof(string)));

                this.CreatedByExternalPartyYomiName = group.Add(new VocabularyKey("CreatedByExternalPartyYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByExternalPartyYomiName")
                    .ModelProperty("createdbyexternalpartyyominame", typeof(string)));

                this.ModifiedByExternalParty = group.Add(new VocabularyKey("ModifiedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the external party who modified the record.")
                    .WithDisplayName("Modified By (External Party)")
                    .ModelProperty("modifiedbyexternalparty", typeof(string)));

                this.ModifiedByExternalPartyName = group.Add(new VocabularyKey("ModifiedByExternalPartyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByExternalPartyName")
                    .ModelProperty("modifiedbyexternalpartyname", typeof(string)));

                this.ModifiedByExternalPartyYomiName = group.Add(new VocabularyKey("ModifiedByExternalPartyYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByExternalPartyYomiName")
                    .ModelProperty("modifiedbyexternalpartyyominame", typeof(string)));

                this.IsReparented = group.Add(new VocabularyKey("IsReparented", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Is Reparented")
                    .ModelProperty("isreparented", typeof(bool)));

                this.isreparentedName = group.Add(new VocabularyKey("isreparentedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isreparentedName")
                    .ModelProperty("isreparentedname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ProductId { get; private set; }

        public VocabularyKey DefaultUoMScheduleId { get; private set; }

        public VocabularyKey SubjectId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey DefaultUoMId { get; private set; }

        public VocabularyKey PriceLevelId { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ProductTypeCode { get; private set; }

        public VocabularyKey ProductUrl { get; private set; }

        public VocabularyKey Price { get; private set; }

        public VocabularyKey IsKit { get; private set; }

        public VocabularyKey ProductNumber { get; private set; }

        public VocabularyKey Size { get; private set; }

        public VocabularyKey CurrentCost { get; private set; }

        public VocabularyKey StockVolume { get; private set; }

        public VocabularyKey StandardCost { get; private set; }

        public VocabularyKey StockWeight { get; private set; }

        public VocabularyKey QuantityDecimal { get; private set; }

        public VocabularyKey QuantityOnHand { get; private set; }

        public VocabularyKey IsStockItem { get; private set; }

        public VocabularyKey SupplierName { get; private set; }

        public VocabularyKey VendorName { get; private set; }

        public VocabularyKey VendorPartNumber { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey DefaultUoMIdName { get; private set; }

        public VocabularyKey DefaultUoMScheduleIdName { get; private set; }

        public VocabularyKey PriceLevelIdName { get; private set; }

        public VocabularyKey SubjectIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey IsStockItemName { get; private set; }

        public VocabularyKey IsKitName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ProductTypeCodeName { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey CurrentCost_Base { get; private set; }

        public VocabularyKey Price_Base { get; private set; }

        public VocabularyKey StandardCost_Base { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey ParentProductId { get; private set; }

        public VocabularyKey ParentProductIdName { get; private set; }

        public VocabularyKey ProductStructure { get; private set; }

        public VocabularyKey ProductStructureName { get; private set; }

        public VocabularyKey VendorID { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey ValidFromDate { get; private set; }

        public VocabularyKey ValidToDate { get; private set; }

        public VocabularyKey HierarchyPath { get; private set; }

        public VocabularyKey DMTImportState { get; private set; }

        public VocabularyKey CreatedByExternalParty { get; private set; }

        public VocabularyKey CreatedByExternalPartyName { get; private set; }

        public VocabularyKey CreatedByExternalPartyYomiName { get; private set; }

        public VocabularyKey ModifiedByExternalParty { get; private set; }

        public VocabularyKey ModifiedByExternalPartyName { get; private set; }

        public VocabularyKey ModifiedByExternalPartyYomiName { get; private set; }

        public VocabularyKey IsReparented { get; private set; }

        public VocabularyKey isreparentedName { get; private set; }


    }
}

