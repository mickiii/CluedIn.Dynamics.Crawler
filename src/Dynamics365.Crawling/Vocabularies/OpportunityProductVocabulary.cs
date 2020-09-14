using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OpportunityProductVocabulary : SimpleVocabulary
    {
        public OpportunityProductVocabulary()
        {
            VocabularyName = "Dynamics365 OpportunityProduct";
            KeyPrefix = "dynamics365.opportunityproduct";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("OpportunityProduct", group =>
            {
                this.ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the Product SKU alt. Product Family to include on the opportunity")
                    .WithDisplayName("Existing Product")
                    .ModelProperty("productid", typeof(string)));

                this.OpportunityProductId = group.Add(new VocabularyKey("OpportunityProductId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the opportunity product.")
                    .WithDisplayName("Opportunity Product")
                    .ModelProperty("opportunityproductid", typeof(Guid)));

                this.PricingErrorCode = group.Add(new VocabularyKey("PricingErrorCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the pricing error for the opportunity product.")
                    .WithDisplayName("Pricing Error ")
                    .ModelProperty("pricingerrorcode", typeof(string)));

                this.IsProductOverridden = group.Add(new VocabularyKey("IsProductOverridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Select Product")
                    .ModelProperty("isproductoverridden", typeof(bool)));

                this.IsPriceOverridden = group.Add(new VocabularyKey("IsPriceOverridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the pricing on the opportunity product reflects an override of the product catalog pricing.")
                    .WithDisplayName("Price Overridden")
                    .ModelProperty("ispriceoverridden", typeof(bool)));

                this.PricePerUnit = group.Add(new VocabularyKey("PricePerUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the price per unit of the opportunity product, based on the price list specified on the parent opportunity.")
                    .WithDisplayName("Price Per Unit")
                    .ModelProperty("priceperunit", typeof(string)));

                this.OpportunityId = group.Add(new VocabularyKey("OpportunityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the opportunity with which the opportunity product is associated.")
                    .WithDisplayName("Opportunity")
                    .ModelProperty("opportunityid", typeof(string)));

                this.BaseAmount = group.Add(new VocabularyKey("BaseAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total price of the opportunity product, based on the price per unit, volume discount, and quantity.")
                    .WithDisplayName("Amount")
                    .ModelProperty("baseamount", typeof(string)));

                this.ExtendedAmount = group.Add(new VocabularyKey("ExtendedAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total amount due for the opportunity product, calculated on the Amount value minus the Manual Discount amount.")
                    .WithDisplayName("Extended Amount")
                    .ModelProperty("extendedamount", typeof(string)));

                this.UoMId = group.Add(new VocabularyKey("UoMId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.")
                    .WithDisplayName("Unit")
                    .ModelProperty("uomid", typeof(string)));

                this.ManualDiscountAmount = group.Add(new VocabularyKey("ManualDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the manual discount amount for the opportunity product to deduct any negotiated or other savings from the product total.")
                    .WithDisplayName("Manual Discount Amount")
                    .ModelProperty("manualdiscountamount", typeof(string)));

                this.Quantity = group.Add(new VocabularyKey("Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the amount or quantity of the product the customer would like to purchase.")
                    .WithDisplayName("Quantity")
                    .ModelProperty("quantity", typeof(decimal)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.VolumeDiscountAmount = group.Add(new VocabularyKey("VolumeDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.")
                    .WithDisplayName("Volume Discount")
                    .ModelProperty("volumediscountamount", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.Tax = group.Add(new VocabularyKey("Tax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the tax amount to be applied on the opportunity product.")
                    .WithDisplayName("Tax")
                    .ModelProperty("tax", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ProductDescription = group.Add(new VocabularyKey("ProductDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Type a detailed product description or additional notes about the opportunity product, such as talking points or product updates, that will assist the sales team when they discuss the product with the customer.")
                    .WithDisplayName("Write-In Product")
                    .ModelProperty("productdescription", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the opportunity product, such as manufacturing details.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ProductIdName = group.Add(new VocabularyKey("ProductIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ProductIdName")
                    .ModelProperty("productidname", typeof(string)));

                this.UoMIdName = group.Add(new VocabularyKey("UoMIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("UoMIdName")
                    .ModelProperty("uomidname", typeof(string)));

                this.OpportunityIdName = group.Add(new VocabularyKey("OpportunityIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OpportunityIdName")
                    .ModelProperty("opportunityidname", typeof(string)));

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

                this.IsPriceOverriddenName = group.Add(new VocabularyKey("IsPriceOverriddenName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPriceOverriddenName")
                    .ModelProperty("ispriceoverriddenname", typeof(string)));

                this.IsProductOverriddenName = group.Add(new VocabularyKey("IsProductOverriddenName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsProductOverriddenName")
                    .ModelProperty("isproductoverriddenname", typeof(string)));

                this.PricingErrorCodeName = group.Add(new VocabularyKey("PricingErrorCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PricingErrorCodeName")
                    .ModelProperty("pricingerrorcodename", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the opportunity product.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.OpportunityStateCode = group.Add(new VocabularyKey("OpportunityStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the status of the opportunity product.")
                    .WithDisplayName("Opportunity Status")
                    .ModelProperty("opportunitystatecode", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the opportunity product.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the opportunity product.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.OpportunityStateCodeName = group.Add(new VocabularyKey("OpportunityStateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OpportunityStateCodeName")
                    .ModelProperty("opportunitystatecodename", typeof(string)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.BaseAmount_Base = group.Add(new VocabularyKey("BaseAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Amount (Base)")
                    .ModelProperty("baseamount_base", typeof(string)));

                this.ManualDiscountAmount_Base = group.Add(new VocabularyKey("ManualDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Manual Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Manual Discount Amount (Base)")
                    .ModelProperty("manualdiscountamount_base", typeof(string)));

                this.VolumeDiscountAmount_Base = group.Add(new VocabularyKey("VolumeDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Volume Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Volume Discount (Base)")
                    .ModelProperty("volumediscountamount_base", typeof(string)));

                this.PricePerUnit_Base = group.Add(new VocabularyKey("PricePerUnit_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Price Per Unit field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Price Per Unit (Base)")
                    .ModelProperty("priceperunit_base", typeof(string)));

                this.Tax_Base = group.Add(new VocabularyKey("Tax_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Tax (Base)")
                    .ModelProperty("tax_base", typeof(string)));

                this.ExtendedAmount_Base = group.Add(new VocabularyKey("ExtendedAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Extended Amount (Base)")
                    .ModelProperty("extendedamount_base", typeof(string)));

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

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.LineItemNumber = group.Add(new VocabularyKey("LineItemNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the line item number for the opportunity product to easily identify the product in the opportunity documents and make sure it's listed in the correct order.")
                    .WithDisplayName("Line Item Number")
                    .ModelProperty("lineitemnumber", typeof(long)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the opportunity product.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the opportunityproduct.")
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

                this.SequenceNumber = group.Add(new VocabularyKey("SequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the data that maintains the sequence.")
                    .WithDisplayName("Sequence Number")
                    .ModelProperty("sequencenumber", typeof(long)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The default image for the entity.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.ParentBundleId = group.Add(new VocabularyKey("ParentBundleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"opportunityproduct_parent_opportunityproduct")
                    .WithDisplayName("Parent Bundle")
                    .ModelProperty("parentbundleid", typeof(Guid)));

                this.ProductTypeCode = group.Add(new VocabularyKey("ProductTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Product Type")
                    .WithDisplayName("Product type")
                    .ModelProperty("producttypecode", typeof(string)));

                this.ProductTypeCodeName = group.Add(new VocabularyKey("ProductTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ProductTypeCodeName")
                    .ModelProperty("producttypecodename", typeof(string)));

                this.PropertyConfigurationStatus = group.Add(new VocabularyKey("PropertyConfigurationStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the property configuration.")
                    .WithDisplayName("Property Configuration")
                    .ModelProperty("propertyconfigurationstatus", typeof(string)));

                this.PropertyConfigurationStatusName = group.Add(new VocabularyKey("PropertyConfigurationStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PropertyConfigurationStatusName")
                    .ModelProperty("propertyconfigurationstatusname", typeof(string)));

                this.ProductAssociationId = group.Add(new VocabularyKey("ProductAssociationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"productAssociation_opportunity_product")
                    .WithDisplayName("Bundle Item Association")
                    .ModelProperty("productassociationid", typeof(Guid)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the owner")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Yomi name of the owner")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.ProductName = group.Add(new VocabularyKey("ProductName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"Calculated field that will be populated by name and description of the product.")
                    .WithDisplayName("Product Name")
                    .ModelProperty("productname", typeof(string)));

                this.OpportunityProductName = group.Add(new VocabularyKey("OpportunityProductName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Opportunity Product Name. Added for 1:n referential relationship (internal purposes only)")
                    .WithDisplayName("Name")
                    .ModelProperty("opportunityproductname", typeof(string)));

                this.ParentBundleIdRef = group.Add(new VocabularyKey("ParentBundleIdRef", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the parent bundle associated with this product")
                    .WithDisplayName("Parent bundle product")
                    .ModelProperty("parentbundleidref", typeof(string)));

                this.SkipPriceCalculation = group.Add(new VocabularyKey("SkipPriceCalculation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Skip price calculation")
                    .WithDisplayName("Skip Price Calculation")
                    .ModelProperty("skippricecalculation", typeof(string)));

                this.skippricecalculationName = group.Add(new VocabularyKey("skippricecalculationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("skippricecalculationName")
                    .ModelProperty("skippricecalculationname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ProductId { get; private set; }

        public VocabularyKey OpportunityProductId { get; private set; }

        public VocabularyKey PricingErrorCode { get; private set; }

        public VocabularyKey IsProductOverridden { get; private set; }

        public VocabularyKey IsPriceOverridden { get; private set; }

        public VocabularyKey PricePerUnit { get; private set; }

        public VocabularyKey OpportunityId { get; private set; }

        public VocabularyKey BaseAmount { get; private set; }

        public VocabularyKey ExtendedAmount { get; private set; }

        public VocabularyKey UoMId { get; private set; }

        public VocabularyKey ManualDiscountAmount { get; private set; }

        public VocabularyKey Quantity { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey VolumeDiscountAmount { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey Tax { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ProductDescription { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ProductIdName { get; private set; }

        public VocabularyKey UoMIdName { get; private set; }

        public VocabularyKey OpportunityIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey IsPriceOverriddenName { get; private set; }

        public VocabularyKey IsProductOverriddenName { get; private set; }

        public VocabularyKey PricingErrorCodeName { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OpportunityStateCode { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OpportunityStateCodeName { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey BaseAmount_Base { get; private set; }

        public VocabularyKey ManualDiscountAmount_Base { get; private set; }

        public VocabularyKey VolumeDiscountAmount_Base { get; private set; }

        public VocabularyKey PricePerUnit_Base { get; private set; }

        public VocabularyKey Tax_Base { get; private set; }

        public VocabularyKey ExtendedAmount_Base { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey LineItemNumber { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey SequenceNumber { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey ParentBundleId { get; private set; }

        public VocabularyKey ProductTypeCode { get; private set; }

        public VocabularyKey ProductTypeCodeName { get; private set; }

        public VocabularyKey PropertyConfigurationStatus { get; private set; }

        public VocabularyKey PropertyConfigurationStatusName { get; private set; }

        public VocabularyKey ProductAssociationId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey ProductName { get; private set; }

        public VocabularyKey OpportunityProductName { get; private set; }

        public VocabularyKey ParentBundleIdRef { get; private set; }

        public VocabularyKey SkipPriceCalculation { get; private set; }

        public VocabularyKey skippricecalculationName { get; private set; }


    }
}

