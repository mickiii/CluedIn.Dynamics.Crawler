using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class InvoiceDetailVocabulary : SimpleVocabulary
    {
        public InvoiceDetailVocabulary()
        {
            VocabularyName = "Dynamics365 InvoiceDetail";
            KeyPrefix = "dynamics365.invoicedetail";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("InvoiceDetail", group =>
            {
                this.InvoiceDetailId = group.Add(new VocabularyKey("InvoiceDetailId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the invoice product line item.")
                    .WithDisplayName("Invoice Product")
                    .ModelProperty("invoicedetailid", typeof(Guid)));

                this.SalesRepId = group.Add(new VocabularyKey("SalesRepId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"system_user_invoicedetail")
                    .WithDisplayName("Salesperson")
                    .ModelProperty("salesrepid", typeof(string)));

                this.IsProductOverridden = group.Add(new VocabularyKey("IsProductOverridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select whether the product exists in the Microsoft Dynamics 365 product catalog or is a write-in product specific to the parent invoice.")
                    .WithDisplayName("Select Product")
                    .ModelProperty("isproductoverridden", typeof(bool)));

                this.LineItemNumber = group.Add(new VocabularyKey("LineItemNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the line item number for the invoice product to easily identify the product in the invoice and make sure it's listed in the correct order.")
                    .WithDisplayName("Line Item Number")
                    .ModelProperty("lineitemnumber", typeof(long)));

                this.IsCopied = group.Add(new VocabularyKey("IsCopied", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the invoice product is copied from another item or data source.")
                    .WithDisplayName("Copied")
                    .ModelProperty("iscopied", typeof(bool)));

                this.InvoiceId = group.Add(new VocabularyKey("InvoiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"invoice_details")
                    .WithDisplayName("Invoice ID")
                    .ModelProperty("invoiceid", typeof(string)));

                this.QuantityBackordered = group.Add(new VocabularyKey("QuantityBackordered", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the amount or quantity of the product that is back ordered for the invoice.")
                    .WithDisplayName("Quantity Back Ordered")
                    .ModelProperty("quantitybackordered", typeof(decimal)));

                this.UoMId = group.Add(new VocabularyKey("UoMId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"unit_of_measurement_invoice_details")
                    .WithDisplayName("Unit")
                    .ModelProperty("uomid", typeof(string)));

                this.ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"product_invoice_details")
                    .WithDisplayName("Existing Product")
                    .ModelProperty("productid", typeof(string)));

                this.ActualDeliveryOn = group.Add(new VocabularyKey("ActualDeliveryOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the invoiced product was delivered to the customer.")
                    .WithDisplayName("Delivered On")
                    .ModelProperty("actualdeliveryon", typeof(DateTime)));

                this.Quantity = group.Add(new VocabularyKey("Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the amount or quantity of the product included in the invoice's total amount due.")
                    .WithDisplayName("Quantity")
                    .ModelProperty("quantity", typeof(decimal)));

                this.ManualDiscountAmount = group.Add(new VocabularyKey("ManualDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the manual discount amount for the invoice product to deduct any negotiated or other savings from the product total.")
                    .WithDisplayName("Manual Discount")
                    .ModelProperty("manualdiscountamount", typeof(string)));

                this.ProductDescription = group.Add(new VocabularyKey("ProductDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Type a name or description to identify the type of write-in product included in the invoice.")
                    .WithDisplayName("Write-In Product")
                    .ModelProperty("productdescription", typeof(string)));

                this.VolumeDiscountAmount = group.Add(new VocabularyKey("VolumeDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.")
                    .WithDisplayName("Volume Discount")
                    .ModelProperty("volumediscountamount", typeof(string)));

                this.PricePerUnit = group.Add(new VocabularyKey("PricePerUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the price per unit of the invoice product. The default is the value in the price list specified on the parent invoice for existing products.")
                    .WithDisplayName("Price Per Unit")
                    .ModelProperty("priceperunit", typeof(string)));

                this.BaseAmount = group.Add(new VocabularyKey("BaseAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total price of the invoice product, based on the price per unit, volume discount, and quantity.")
                    .WithDisplayName("Amount")
                    .ModelProperty("baseamount", typeof(string)));

                this.QuantityCancelled = group.Add(new VocabularyKey("QuantityCancelled", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the amount or quantity of the product that was canceled for the invoice line item.")
                    .WithDisplayName("Quantity Canceled")
                    .ModelProperty("quantitycancelled", typeof(decimal)));

                this.ShippingTrackingNumber = group.Add(new VocabularyKey("ShippingTrackingNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a tracking number for shipment of the invoiced product.")
                    .WithDisplayName("Shipment Tracking Number")
                    .ModelProperty("shippingtrackingnumber", typeof(string)));

                this.ExtendedAmount = group.Add(new VocabularyKey("ExtendedAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total amount due for the invoice product, based on the sum of the unit price, quantity, discounts, and tax.")
                    .WithDisplayName("Extended Amount")
                    .ModelProperty("extendedamount", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the product line item of the invoice.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.IsPriceOverridden = group.Add(new VocabularyKey("IsPriceOverridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the invoice product.")
                    .WithDisplayName("Pricing")
                    .ModelProperty("ispriceoverridden", typeof(bool)));

                this.ShipTo_Name = group.Add(new VocabularyKey("ShipTo_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription("Type a name for the customer's shipping address, such as \"Headquarters\" or \"Field office\",  to identify the address.")
                    .WithDisplayName("Ship To Name")
                    .ModelProperty("shipto_name", typeof(string)));

                this.PricingErrorCode = group.Add(new VocabularyKey("PricingErrorCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Pricing error for the invoice product line item.")
                    .WithDisplayName("Pricing Error ")
                    .ModelProperty("pricingerrorcode", typeof(string)));

                this.Tax = group.Add(new VocabularyKey("Tax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the tax amount for the invoice product.")
                    .WithDisplayName("Tax")
                    .ModelProperty("tax", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ShipTo_Line1 = group.Add(new VocabularyKey("ShipTo_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the customer's shipping address.")
                    .WithDisplayName("Ship To Street 1")
                    .ModelProperty("shipto_line1", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_invoicedetailbase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_invoicedetailbase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ShipTo_Line2 = group.Add(new VocabularyKey("ShipTo_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the second line of the customer's shipping address.")
                    .WithDisplayName("Ship To Street 2")
                    .ModelProperty("shipto_line2", typeof(string)));

                this.ShipTo_Line3 = group.Add(new VocabularyKey("ShipTo_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the third line of the shipping address.")
                    .WithDisplayName("Ship To Street 3")
                    .ModelProperty("shipto_line3", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ShipTo_City = group.Add(new VocabularyKey("ShipTo_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the customer's shipping address.")
                    .WithDisplayName("Ship To City")
                    .ModelProperty("shipto_city", typeof(string)));

                this.ShipTo_StateOrProvince = group.Add(new VocabularyKey("ShipTo_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the state or province for the shipping address.")
                    .WithDisplayName("Ship To State/Province")
                    .ModelProperty("shipto_stateorprovince", typeof(string)));

                this.ShipTo_Country = group.Add(new VocabularyKey("ShipTo_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the country or region for the customer's shipping address.")
                    .WithDisplayName("Ship To Country/Region")
                    .ModelProperty("shipto_country", typeof(string)));

                this.ShipTo_PostalCode = group.Add(new VocabularyKey("ShipTo_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the ZIP Code or postal code for the shipping address.")
                    .WithDisplayName("Ship To ZIP/Postal Code")
                    .ModelProperty("shipto_postalcode", typeof(string)));

                this.WillCall = group.Add(new VocabularyKey("WillCall", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the invoice product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.")
                    .WithDisplayName("Ship To")
                    .ModelProperty("willcall", typeof(bool)));

                this.ShipTo_Telephone = group.Add(new VocabularyKey("ShipTo_Telephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the phone number for the customer's shipping address.")
                    .WithDisplayName("Ship To Phone")
                    .ModelProperty("shipto_telephone", typeof(string)));

                this.ShipTo_Fax = group.Add(new VocabularyKey("ShipTo_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number for the customer's shipping address.")
                    .WithDisplayName("Ship To Fax")
                    .ModelProperty("shipto_fax", typeof(string)));

                this.ShipTo_FreightTermsCode = group.Add(new VocabularyKey("ShipTo_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Freight Terms")
                    .ModelProperty("shipto_freighttermscode", typeof(string)));

                this.QuantityShipped = group.Add(new VocabularyKey("QuantityShipped", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the amount or quantity of the product that was shipped.")
                    .WithDisplayName("Quantity Shipped")
                    .ModelProperty("quantityshipped", typeof(decimal)));

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

                this.SalesRepIdName = group.Add(new VocabularyKey("SalesRepIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SalesRepIdName")
                    .ModelProperty("salesrepidname", typeof(string)));

                this.InvoiceStateCode = group.Add(new VocabularyKey("InvoiceStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status of the invoice product.")
                    .WithDisplayName("Invoice Status")
                    .ModelProperty("invoicestatecode", typeof(string)));

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

                this.WillCallName = group.Add(new VocabularyKey("WillCallName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("WillCallName")
                    .ModelProperty("willcallname", typeof(string)));

                this.IsCopiedName = group.Add(new VocabularyKey("IsCopiedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsCopiedName")
                    .ModelProperty("iscopiedname", typeof(string)));

                this.ShipTo_FreightTermsCodeName = group.Add(new VocabularyKey("ShipTo_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShipTo_FreightTermsCodeName")
                    .ModelProperty("shipto_freighttermscodename", typeof(string)));

                this.InvoiceStateCodeName = group.Add(new VocabularyKey("InvoiceStateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InvoiceStateCodeName")
                    .ModelProperty("invoicestatecodename", typeof(string)));

                this.PricingErrorCodeName = group.Add(new VocabularyKey("PricingErrorCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PricingErrorCodeName")
                    .ModelProperty("pricingerrorcodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the invoice product line item.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the invoice product line item.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.InvoiceIsPriceLocked = group.Add(new VocabularyKey("InvoiceIsPriceLocked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether invoice product pricing is locked.")
                    .WithDisplayName("Invoice Is Price Locked")
                    .ModelProperty("invoiceispricelocked", typeof(bool)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the invoice product line item.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.InvoiceIsPriceLockedName = group.Add(new VocabularyKey("InvoiceIsPriceLockedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InvoiceIsPriceLockedName")
                    .ModelProperty("invoiceispricelockedname", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"transactioncurrency_invoicedetail")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

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

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.VolumeDiscountAmount_Base = group.Add(new VocabularyKey("VolumeDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Volume Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Volume Discount (Base)")
                    .ModelProperty("volumediscountamount_base", typeof(string)));

                this.BaseAmount_Base = group.Add(new VocabularyKey("BaseAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Amount (Base)")
                    .ModelProperty("baseamount_base", typeof(string)));

                this.PricePerUnit_Base = group.Add(new VocabularyKey("PricePerUnit_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Price Per Unit field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Price Per Unit (Base)")
                    .ModelProperty("priceperunit_base", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

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

                this.ManualDiscountAmount_Base = group.Add(new VocabularyKey("ManualDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Manual Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Manual Discount (Base)")
                    .ModelProperty("manualdiscountamount_base", typeof(string)));

                this.SalesRepIdYomiName = group.Add(new VocabularyKey("SalesRepIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SalesRepIdYomiName")
                    .ModelProperty("salesrepidyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the invoice detail.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the invoice detail.")
                    .WithDisplayName("Owner")
                    .ModelProperty("owneridtype", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_invoicedetail_createdonbehalfby")
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
                    .WithDescription(@"lk_invoicedetail_modifiedonbehalfby")
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

                this.ParentBundleId = group.Add(new VocabularyKey("ParentBundleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"invoicedetail_parent_invoicedetail")
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
                    .WithDescription(@"productAssociation_invoice_details")
                    .WithDisplayName("Bundle Item Association")
                    .ModelProperty("productassociationid", typeof(Guid)));

                this.InvoiceIdName = group.Add(new VocabularyKey("InvoiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("InvoiceIdName")
                    .ModelProperty("invoiceidname", typeof(string)));

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

                this.InvoiceDetailName = group.Add(new VocabularyKey("InvoiceDetailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Invoice Detail Name. Added for 1:n referential relationship (internal purposes only)")
                    .WithDisplayName("Name")
                    .ModelProperty("invoicedetailname", typeof(string)));

                this.SalesOrderDetailId = group.Add(new VocabularyKey("SalesOrderDetailId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for Order Line associated with Invoice Line.")
                    .WithDisplayName("Order Product Id")
                    .ModelProperty("salesorderdetailid", typeof(string)));

                this.ParentBundleIdRef = group.Add(new VocabularyKey("ParentBundleIdRef", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the parent bundle associated with this product")
                    .WithDisplayName("Parent bundle product")
                    .ModelProperty("parentbundleidref", typeof(string)));

                this.SalesOrderDetailIdName = group.Add(new VocabularyKey("SalesOrderDetailIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"")
                    .WithDisplayName("SalesOrderDetailIdName")
                    .ModelProperty("salesorderdetailidname", typeof(string)));

                this.SkipPriceCalculation = group.Add(new VocabularyKey("SkipPriceCalculation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Skip Price Calculation")
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

        public VocabularyKey InvoiceDetailId { get; private set; }

        public VocabularyKey SalesRepId { get; private set; }

        public VocabularyKey IsProductOverridden { get; private set; }

        public VocabularyKey LineItemNumber { get; private set; }

        public VocabularyKey IsCopied { get; private set; }

        public VocabularyKey InvoiceId { get; private set; }

        public VocabularyKey QuantityBackordered { get; private set; }

        public VocabularyKey UoMId { get; private set; }

        public VocabularyKey ProductId { get; private set; }

        public VocabularyKey ActualDeliveryOn { get; private set; }

        public VocabularyKey Quantity { get; private set; }

        public VocabularyKey ManualDiscountAmount { get; private set; }

        public VocabularyKey ProductDescription { get; private set; }

        public VocabularyKey VolumeDiscountAmount { get; private set; }

        public VocabularyKey PricePerUnit { get; private set; }

        public VocabularyKey BaseAmount { get; private set; }

        public VocabularyKey QuantityCancelled { get; private set; }

        public VocabularyKey ShippingTrackingNumber { get; private set; }

        public VocabularyKey ExtendedAmount { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey IsPriceOverridden { get; private set; }

        public VocabularyKey ShipTo_Name { get; private set; }

        public VocabularyKey PricingErrorCode { get; private set; }

        public VocabularyKey Tax { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ShipTo_Line1 { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ShipTo_Line2 { get; private set; }

        public VocabularyKey ShipTo_Line3 { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ShipTo_City { get; private set; }

        public VocabularyKey ShipTo_StateOrProvince { get; private set; }

        public VocabularyKey ShipTo_Country { get; private set; }

        public VocabularyKey ShipTo_PostalCode { get; private set; }

        public VocabularyKey WillCall { get; private set; }

        public VocabularyKey ShipTo_Telephone { get; private set; }

        public VocabularyKey ShipTo_Fax { get; private set; }

        public VocabularyKey ShipTo_FreightTermsCode { get; private set; }

        public VocabularyKey QuantityShipped { get; private set; }

        public VocabularyKey ProductIdName { get; private set; }

        public VocabularyKey UoMIdName { get; private set; }

        public VocabularyKey SalesRepIdName { get; private set; }

        public VocabularyKey InvoiceStateCode { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey IsPriceOverriddenName { get; private set; }

        public VocabularyKey IsProductOverriddenName { get; private set; }

        public VocabularyKey WillCallName { get; private set; }

        public VocabularyKey IsCopiedName { get; private set; }

        public VocabularyKey ShipTo_FreightTermsCodeName { get; private set; }

        public VocabularyKey InvoiceStateCodeName { get; private set; }

        public VocabularyKey PricingErrorCodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey InvoiceIsPriceLocked { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey InvoiceIsPriceLockedName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey VolumeDiscountAmount_Base { get; private set; }

        public VocabularyKey BaseAmount_Base { get; private set; }

        public VocabularyKey PricePerUnit_Base { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey Tax_Base { get; private set; }

        public VocabularyKey ExtendedAmount_Base { get; private set; }

        public VocabularyKey ManualDiscountAmount_Base { get; private set; }

        public VocabularyKey SalesRepIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey SequenceNumber { get; private set; }

        public VocabularyKey ParentBundleId { get; private set; }

        public VocabularyKey ProductTypeCode { get; private set; }

        public VocabularyKey ProductTypeCodeName { get; private set; }

        public VocabularyKey PropertyConfigurationStatus { get; private set; }

        public VocabularyKey PropertyConfigurationStatusName { get; private set; }

        public VocabularyKey ProductAssociationId { get; private set; }

        public VocabularyKey InvoiceIdName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey ProductName { get; private set; }

        public VocabularyKey InvoiceDetailName { get; private set; }

        public VocabularyKey SalesOrderDetailId { get; private set; }

        public VocabularyKey ParentBundleIdRef { get; private set; }

        public VocabularyKey SalesOrderDetailIdName { get; private set; }

        public VocabularyKey SkipPriceCalculation { get; private set; }

        public VocabularyKey skippricecalculationName { get; private set; }


    }
}

