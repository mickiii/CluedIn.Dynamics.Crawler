using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ProductPriceLevelVocabulary : SimpleVocabulary
    {
        public ProductPriceLevelVocabulary()
        {
            VocabularyName = "Dynamics365 ProductPriceLevel";
            KeyPrefix = "dynamics365.productpricelevel";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ProductPriceLevel", group =>
            {
                this.PriceLevelId = group.Add(new VocabularyKey("PriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"price_level_product_price_levels")
                    .WithDisplayName("Price List")
                    .ModelProperty("pricelevelid", typeof(string)));

                this.ProductPriceLevelId = group.Add(new VocabularyKey("ProductPriceLevelId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the price list.")
                    .WithDisplayName("Product Price List")
                    .ModelProperty("productpricelevelid", typeof(Guid)));

                this.UoMId = group.Add(new VocabularyKey("UoMId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"unit_of_measurement_product_price_levels")
                    .WithDisplayName("Unit")
                    .ModelProperty("uomid", typeof(string)));

                this.UoMScheduleId = group.Add(new VocabularyKey("UoMScheduleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"unit_of_measure_schedule_product_price_level")
                    .WithDisplayName("Unit Schedule ID")
                    .ModelProperty("uomscheduleid", typeof(string)));

                this.DiscountTypeId = group.Add(new VocabularyKey("DiscountTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"discount_type_product_price_levels")
                    .WithDisplayName("Discount List")
                    .ModelProperty("discounttypeid", typeof(string)));

                this.ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"product_price_levels")
                    .WithDisplayName("Product")
                    .ModelProperty("productid", typeof(string)));

                this.Percentage = group.Add(new VocabularyKey("Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Percentage for the price list.")
                    .WithDisplayName("Percentage")
                    .ModelProperty("percentage", typeof(decimal)));

                this.Amount = group.Add(new VocabularyKey("Amount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Monetary amount for the price list.")
                    .WithDisplayName("Amount")
                    .ModelProperty("amount", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the price list was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.QuantitySellingCode = group.Add(new VocabularyKey("QuantitySellingCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Quantity of the product that must be sold for a given price level.")
                    .WithDisplayName("Quantity Selling Option")
                    .ModelProperty("quantitysellingcode", typeof(string)));

                this.RoundingPolicyCode = group.Add(new VocabularyKey("RoundingPolicyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Policy for rounding the price list.")
                    .WithDisplayName("Rounding Policy")
                    .ModelProperty("roundingpolicycode", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the price list was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.PricingMethodCode = group.Add(new VocabularyKey("PricingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Pricing method applied to the price list.")
                    .WithDisplayName("Pricing Method")
                    .ModelProperty("pricingmethodcode", typeof(string)));

                this.RoundingOptionCode = group.Add(new VocabularyKey("RoundingOptionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Option for rounding the price list.")
                    .WithDisplayName("Rounding Option")
                    .ModelProperty("roundingoptioncode", typeof(string)));

                this.RoundingOptionAmount = group.Add(new VocabularyKey("RoundingOptionAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Rounding option amount for the price list.")
                    .WithDisplayName("Rounding Amount")
                    .ModelProperty("roundingoptionamount", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the price list.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_productpricelevelbase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_productpricelevelbase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.DiscountTypeIdName = group.Add(new VocabularyKey("DiscountTypeIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("DiscountTypeIdName")
                    .ModelProperty("discounttypeidname", typeof(string)));

                this.ProductIdName = group.Add(new VocabularyKey("ProductIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ProductIdName")
                    .ModelProperty("productidname", typeof(string)));

                this.PriceLevelIdName = group.Add(new VocabularyKey("PriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PriceLevelIdName")
                    .ModelProperty("pricelevelidname", typeof(string)));

                this.UoMIdName = group.Add(new VocabularyKey("UoMIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("UoMIdName")
                    .ModelProperty("uomidname", typeof(string)));

                this.UoMScheduleIdName = group.Add(new VocabularyKey("UoMScheduleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("UoMScheduleIdName")
                    .ModelProperty("uomscheduleidname", typeof(string)));

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

                this.RoundingPolicyCodeName = group.Add(new VocabularyKey("RoundingPolicyCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RoundingPolicyCodeName")
                    .ModelProperty("roundingpolicycodename", typeof(string)));

                this.QuantitySellingCodeName = group.Add(new VocabularyKey("QuantitySellingCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("QuantitySellingCodeName")
                    .ModelProperty("quantitysellingcodename", typeof(string)));

                this.PricingMethodCodeName = group.Add(new VocabularyKey("PricingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PricingMethodCodeName")
                    .ModelProperty("pricingmethodcodename", typeof(string)));

                this.RoundingOptionCodeName = group.Add(new VocabularyKey("RoundingOptionCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RoundingOptionCodeName")
                    .ModelProperty("roundingoptioncodename", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the price list.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"transactioncurrency_productpricelevel")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.Amount_Base = group.Add(new VocabularyKey("Amount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Amount field converted to the system's default base currency, if specified as a fixed amount. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Amount (Base)")
                    .ModelProperty("amount_base", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.RoundingOptionAmount_Base = group.Add(new VocabularyKey("RoundingOptionAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Rounding Amount field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Rounding Amount (Base)")
                    .ModelProperty("roundingoptionamount_base", typeof(string)));

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
                    .WithDescription(@"lk_productpricelevelbase_createdonbehalfby")
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
                    .WithDescription(@"lk_productpricelevelbase_modifiedonbehalfby")
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

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_productpricelevels")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ProductNumber = group.Add(new VocabularyKey("ProductNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"User-defined product number.")
                    .WithDisplayName("Product ID")
                    .ModelProperty("productnumber", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey PriceLevelId { get; private set; }

        public VocabularyKey ProductPriceLevelId { get; private set; }

        public VocabularyKey UoMId { get; private set; }

        public VocabularyKey UoMScheduleId { get; private set; }

        public VocabularyKey DiscountTypeId { get; private set; }

        public VocabularyKey ProductId { get; private set; }

        public VocabularyKey Percentage { get; private set; }

        public VocabularyKey Amount { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey QuantitySellingCode { get; private set; }

        public VocabularyKey RoundingPolicyCode { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey PricingMethodCode { get; private set; }

        public VocabularyKey RoundingOptionCode { get; private set; }

        public VocabularyKey RoundingOptionAmount { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey DiscountTypeIdName { get; private set; }

        public VocabularyKey ProductIdName { get; private set; }

        public VocabularyKey PriceLevelIdName { get; private set; }

        public VocabularyKey UoMIdName { get; private set; }

        public VocabularyKey UoMScheduleIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey RoundingPolicyCodeName { get; private set; }

        public VocabularyKey QuantitySellingCodeName { get; private set; }

        public VocabularyKey PricingMethodCodeName { get; private set; }

        public VocabularyKey RoundingOptionCodeName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey Amount_Base { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey RoundingOptionAmount_Base { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProductNumber { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}

