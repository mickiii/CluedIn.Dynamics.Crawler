using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class InvoiceVocabulary : SimpleVocabulary
    {
        public InvoiceVocabulary()
        {
            VocabularyName = "Dynamics365 Invoice";
            KeyPrefix = "dynamics365.invoice";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Invoice", group =>
            {
                this.InvoiceId = group.Add(new VocabularyKey("InvoiceId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the invoice.")
                    .WithDisplayName("Invoice")
                    .ModelProperty("invoiceid", typeof(Guid)));

                this.OpportunityId = group.Add(new VocabularyKey("OpportunityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"opportunity_invoices")
                    .WithDisplayName("Opportunity")
                    .ModelProperty("opportunityid", typeof(string)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.SalesOrderId = group.Add(new VocabularyKey("SalesOrderId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"order_invoices")
                    .WithDisplayName("Order")
                    .ModelProperty("salesorderid", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"system_user_invoices")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_invoices")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.LastBackofficeSubmit = group.Add(new VocabularyKey("LastBackofficeSubmit", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time when the invoice was last submitted to an accounting or ERP system for processing.")
                    .WithDisplayName("Last Submitted to Back Office")
                    .ModelProperty("lastbackofficesubmit", typeof(DateTime)));

                this.PriceLevelId = group.Add(new VocabularyKey("PriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"price_level_invoices")
                    .WithDisplayName("Price List")
                    .ModelProperty("pricelevelid", typeof(string)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the invoice is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact associated with the invoice.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(string)));

                this.InvoiceNumber = group.Add(new VocabularyKey("InvoiceNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Shows the identifying number or code of the invoice.")
                    .WithDisplayName("Invoice ID")
                    .ModelProperty("invoicenumber", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(300))
                    .WithDescription(@"Type a descriptive name for the invoice.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the invoice, such as shipping details or product substitutions.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.DiscountAmount = group.Add(new VocabularyKey("DiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the discount amount for the invoice if the customer is eligible for special savings.")
                    .WithDisplayName("Invoice Discount Amount")
                    .ModelProperty("discountamount", typeof(string)));

                this.FreightAmount = group.Add(new VocabularyKey("FreightAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the cost of freight or shipping for the products included in the invoice for use in calculating the total amount due.")
                    .WithDisplayName("Freight Amount")
                    .ModelProperty("freightamount", typeof(string)));

                this.TotalAmount = group.Add(new VocabularyKey("TotalAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total amount due, calculated as the sum of the products, discount, freight, and taxes for the invoice.")
                    .WithDisplayName("Total Amount")
                    .ModelProperty("totalamount", typeof(string)));

                this.TotalLineItemAmount = group.Add(new VocabularyKey("TotalLineItemAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the sum of all existing and write-in products included on the invoice, based on the specified price list and quantities.")
                    .WithDisplayName("Total Detail Amount")
                    .ModelProperty("totallineitemamount", typeof(string)));

                this.TotalLineItemDiscountAmount = group.Add(new VocabularyKey("TotalLineItemDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.")
                    .WithDisplayName("Total Line Item Discount Amount")
                    .ModelProperty("totallineitemdiscountamount", typeof(string)));

                this.TotalAmountLessFreight = group.Add(new VocabularyKey("TotalAmountLessFreight", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total product amount due, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the invoice.")
                    .WithDisplayName("Total Pre-Freight Amount")
                    .ModelProperty("totalamountlessfreight", typeof(string)));

                this.TotalDiscountAmount = group.Add(new VocabularyKey("TotalDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total discount amount, based on the discount price and rate entered on the invoice.")
                    .WithDisplayName("Total Discount Amount")
                    .ModelProperty("totaldiscountamount", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_invoicebase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.TotalTax = group.Add(new VocabularyKey("TotalTax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total of the Tax amounts specified on all products included in the invoice, included in the Total Amount due calculation for the invoice.")
                    .WithDisplayName("Total Tax")
                    .ModelProperty("totaltax", typeof(string)));

                this.ShippingMethodCode = group.Add(new VocabularyKey("ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Shipping Method")
                    .ModelProperty("shippingmethodcode", typeof(string)));

                this.PaymentTermsCode = group.Add(new VocabularyKey("PaymentTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the payment terms to indicate when the customer needs to pay the total amount.")
                    .WithDisplayName("Payment Terms")
                    .ModelProperty("paymenttermscode", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_invoicebase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the invoice is active, paid, or canceled. Paid and canceled invoices are read-only and can't be edited unless they are reactivated.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the invoice's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.ShipTo_Name = group.Add(new VocabularyKey("ShipTo_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription("Type a name for the customer's shipping address, such as \"Headquarters\" or \"Field office\",  to identify the address.")
                    .WithDisplayName("Ship To Name")
                    .ModelProperty("shipto_name", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the invoice.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.PricingErrorCode = group.Add(new VocabularyKey("PricingErrorCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of pricing error for the invoice.")
                    .WithDisplayName("Pricing Error ")
                    .ModelProperty("pricingerrorcode", typeof(string)));

                this.ShipTo_Line1 = group.Add(new VocabularyKey("ShipTo_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the customer's shipping address.")
                    .WithDisplayName("Ship To Street 1")
                    .ModelProperty("shipto_line1", typeof(string)));

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
                    .WithDescription(@"Select whether the products included in the invoice should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.")
                    .WithDisplayName("Ship To")
                    .ModelProperty("willcall", typeof(bool)));

                this.ShipTo_Telephone = group.Add(new VocabularyKey("ShipTo_Telephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the phone number for the customer's shipping address.")
                    .WithDisplayName("Ship To Phone")
                    .ModelProperty("shipto_telephone", typeof(string)));

                this.BillTo_Name = group.Add(new VocabularyKey("BillTo_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription("Type a name for the customer's billing address, such as \"Headquarters\" or \"Field office\", to identify the address.")
                    .WithDisplayName("Bill To Name")
                    .ModelProperty("billto_name", typeof(string)));

                this.ShipTo_FreightTermsCode = group.Add(new VocabularyKey("ShipTo_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Ship To Freight Terms")
                    .ModelProperty("shipto_freighttermscode", typeof(string)));

                this.ShipTo_Fax = group.Add(new VocabularyKey("ShipTo_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number for the customer's shipping address.")
                    .WithDisplayName("Ship To Fax")
                    .ModelProperty("shipto_fax", typeof(string)));

                this.BillTo_Line1 = group.Add(new VocabularyKey("BillTo_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the customer's billing address.")
                    .WithDisplayName("Bill To Street 1")
                    .ModelProperty("billto_line1", typeof(string)));

                this.BillTo_Line2 = group.Add(new VocabularyKey("BillTo_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the second line of the customer's billing address.")
                    .WithDisplayName("Bill To Street 2")
                    .ModelProperty("billto_line2", typeof(string)));

                this.BillTo_Line3 = group.Add(new VocabularyKey("BillTo_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the third line of the billing address.")
                    .WithDisplayName("Bill To Street 3")
                    .ModelProperty("billto_line3", typeof(string)));

                this.BillTo_City = group.Add(new VocabularyKey("BillTo_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the customer's billing address.")
                    .WithDisplayName("Bill To City")
                    .ModelProperty("billto_city", typeof(string)));

                this.BillTo_StateOrProvince = group.Add(new VocabularyKey("BillTo_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the state or province for the billing address.")
                    .WithDisplayName("Bill To State/Province")
                    .ModelProperty("billto_stateorprovince", typeof(string)));

                this.BillTo_Country = group.Add(new VocabularyKey("BillTo_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the country or region for the customer's billing address.")
                    .WithDisplayName("Bill To Country/Region")
                    .ModelProperty("billto_country", typeof(string)));

                this.BillTo_PostalCode = group.Add(new VocabularyKey("BillTo_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the ZIP Code or postal code for the billing address.")
                    .WithDisplayName("Bill To ZIP/Postal Code")
                    .ModelProperty("billto_postalcode", typeof(string)));

                this.BillTo_Telephone = group.Add(new VocabularyKey("BillTo_Telephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the phone number for the customer's billing address.")
                    .WithDisplayName("Bill To Phone")
                    .ModelProperty("billto_telephone", typeof(string)));

                this.BillTo_Fax = group.Add(new VocabularyKey("BillTo_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number for the customer's billing address.")
                    .WithDisplayName("Bill To Fax")
                    .ModelProperty("billto_fax", typeof(string)));

                this.DiscountPercentage = group.Add(new VocabularyKey("DiscountPercentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the discount rate that should be applied to the Detail Amount field, for use in calculating the Pre-Freight Amount and Total Amount values for the invoice.")
                    .WithDisplayName("Invoice Discount (%)")
                    .ModelProperty("discountpercentage", typeof(decimal)));

                this.ContactIdName = group.Add(new VocabularyKey("ContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdName")
                    .ModelProperty("contactidname", typeof(string)));

                this.AccountIdName = group.Add(new VocabularyKey("AccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdName")
                    .ModelProperty("accountidname", typeof(string)));

                this.OpportunityIdName = group.Add(new VocabularyKey("OpportunityIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OpportunityIdName")
                    .ModelProperty("opportunityidname", typeof(string)));

                this.SalesOrderIdName = group.Add(new VocabularyKey("SalesOrderIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(300))
                    .WithDescription(@"")
                    .WithDisplayName("SalesOrderIdName")
                    .ModelProperty("salesorderidname", typeof(string)));

                this.PriceLevelIdName = group.Add(new VocabularyKey("PriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PriceLevelIdName")
                    .ModelProperty("pricelevelidname", typeof(string)));

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

                this.CustomerId = group.Add(new VocabularyKey("CustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.")
                    .WithDisplayName("Customer")
                    .ModelProperty("customerid", typeof(string)));

                this.CustomerIdName = group.Add(new VocabularyKey("CustomerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdName")
                    .ModelProperty("customeridname", typeof(string)));

                this.CustomerIdType = group.Add(new VocabularyKey("CustomerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Customer Type")
                    .ModelProperty("customeridtype", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"owner_invoices")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.WillCallName = group.Add(new VocabularyKey("WillCallName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("WillCallName")
                    .ModelProperty("willcallname", typeof(string)));

                this.ShipTo_FreightTermsCodeName = group.Add(new VocabularyKey("ShipTo_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShipTo_FreightTermsCodeName")
                    .ModelProperty("shipto_freighttermscodename", typeof(string)));

                this.ShippingMethodCodeName = group.Add(new VocabularyKey("ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShippingMethodCodeName")
                    .ModelProperty("shippingmethodcodename", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.PaymentTermsCodeName = group.Add(new VocabularyKey("PaymentTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PaymentTermsCodeName")
                    .ModelProperty("paymenttermscodename", typeof(string)));

                this.PricingErrorCodeName = group.Add(new VocabularyKey("PricingErrorCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PricingErrorCodeName")
                    .ModelProperty("pricingerrorcodename", typeof(string)));

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

                this.IsPriceLocked = group.Add(new VocabularyKey("IsPriceLocked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether prices specified on the invoice are locked from any further updates.")
                    .WithDisplayName("Prices Locked")
                    .ModelProperty("ispricelocked", typeof(bool)));

                this.DateDelivered = group.Add(new VocabularyKey("DateDelivered", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the products included in the invoice were delivered.")
                    .WithDisplayName("Date Delivered")
                    .ModelProperty("datedelivered", typeof(DateTime)));

                this.DueDate = group.Add(new VocabularyKey("DueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date by which the invoice should be paid by the customer.")
                    .WithDisplayName("Due Date")
                    .ModelProperty("duedate", typeof(DateTime)));

                this.IsPriceLockedName = group.Add(new VocabularyKey("IsPriceLockedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPriceLockedName")
                    .ModelProperty("ispricelockedname", typeof(string)));

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

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"transactioncurrency_invoice")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.TotalLineItemAmount_Base = group.Add(new VocabularyKey("TotalLineItemAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Detail Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Detail Amount (Base)")
                    .ModelProperty("totallineitemamount_base", typeof(string)));

                this.TotalLineItemDiscountAmount_Base = group.Add(new VocabularyKey("TotalLineItemDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total of the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.")
                    .WithDisplayName("Total Line Item Discount Amount (Base)")
                    .ModelProperty("totallineitemdiscountamount_base", typeof(string)));

                this.TotalTax_Base = group.Add(new VocabularyKey("TotalTax_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Tax (Base)")
                    .ModelProperty("totaltax_base", typeof(string)));

                this.TotalAmountLessFreight_Base = group.Add(new VocabularyKey("TotalAmountLessFreight_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Pre-Freight Amount (Base)")
                    .ModelProperty("totalamountlessfreight_base", typeof(string)));

                this.DiscountAmount_Base = group.Add(new VocabularyKey("DiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Invoice Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Invoice Discount Amount (Base)")
                    .ModelProperty("discountamount_base", typeof(string)));

                this.TotalAmount_Base = group.Add(new VocabularyKey("TotalAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Amount (Base)")
                    .ModelProperty("totalamount_base", typeof(string)));

                this.FreightAmount_Base = group.Add(new VocabularyKey("FreightAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Freight Amount (Base)")
                    .ModelProperty("freightamount_base", typeof(string)));

                this.TotalDiscountAmount_Base = group.Add(new VocabularyKey("TotalDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Discount Amount (Base)")
                    .ModelProperty("totaldiscountamount_base", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.AccountIdYomiName = group.Add(new VocabularyKey("AccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdYomiName")
                    .ModelProperty("accountidyominame", typeof(string)));

                this.ContactIdYomiName = group.Add(new VocabularyKey("ContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdYomiName")
                    .ModelProperty("contactidyominame", typeof(string)));

                this.CustomerIdYomiName = group.Add(new VocabularyKey("CustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdYomiName")
                    .ModelProperty("customeridyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_invoice_createdonbehalfby")
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
                    .WithDescription(@"lk_invoice_modifiedonbehalfby")
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

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"team_invoices")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.BillTo_Composite = group.Add(new VocabularyKey("BillTo_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete Bill To address.")
                    .WithDisplayName("Bill To Address")
                    .ModelProperty("billto_composite", typeof(string)));

                this.ShipTo_Composite = group.Add(new VocabularyKey("ShipTo_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete Ship To address.")
                    .WithDisplayName("Ship To Address")
                    .ModelProperty("shipto_composite", typeof(string)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_invoices")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

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

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"manualsla_invoice")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"sla_invoice")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the duration in minutes for which the invoice was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.EmailAddress = group.Add(new VocabularyKey("EmailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The primary email address for the entity.")
                    .WithDisplayName("Email Address")
                    .ModelProperty("emailaddress", typeof(string)));

                this.SkipPriceCalculation = group.Add(new VocabularyKey("SkipPriceCalculation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Skip Price Calculation (For Internal Use)")
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

        public VocabularyKey InvoiceId { get; private set; }

        public VocabularyKey OpportunityId { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey SalesOrderId { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey LastBackofficeSubmit { get; private set; }

        public VocabularyKey PriceLevelId { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey InvoiceNumber { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey DiscountAmount { get; private set; }

        public VocabularyKey FreightAmount { get; private set; }

        public VocabularyKey TotalAmount { get; private set; }

        public VocabularyKey TotalLineItemAmount { get; private set; }

        public VocabularyKey TotalLineItemDiscountAmount { get; private set; }

        public VocabularyKey TotalAmountLessFreight { get; private set; }

        public VocabularyKey TotalDiscountAmount { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey TotalTax { get; private set; }

        public VocabularyKey ShippingMethodCode { get; private set; }

        public VocabularyKey PaymentTermsCode { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey ShipTo_Name { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey PricingErrorCode { get; private set; }

        public VocabularyKey ShipTo_Line1 { get; private set; }

        public VocabularyKey ShipTo_Line2 { get; private set; }

        public VocabularyKey ShipTo_Line3 { get; private set; }

        public VocabularyKey ShipTo_City { get; private set; }

        public VocabularyKey ShipTo_StateOrProvince { get; private set; }

        public VocabularyKey ShipTo_Country { get; private set; }

        public VocabularyKey ShipTo_PostalCode { get; private set; }

        public VocabularyKey WillCall { get; private set; }

        public VocabularyKey ShipTo_Telephone { get; private set; }

        public VocabularyKey BillTo_Name { get; private set; }

        public VocabularyKey ShipTo_FreightTermsCode { get; private set; }

        public VocabularyKey ShipTo_Fax { get; private set; }

        public VocabularyKey BillTo_Line1 { get; private set; }

        public VocabularyKey BillTo_Line2 { get; private set; }

        public VocabularyKey BillTo_Line3 { get; private set; }

        public VocabularyKey BillTo_City { get; private set; }

        public VocabularyKey BillTo_StateOrProvince { get; private set; }

        public VocabularyKey BillTo_Country { get; private set; }

        public VocabularyKey BillTo_PostalCode { get; private set; }

        public VocabularyKey BillTo_Telephone { get; private set; }

        public VocabularyKey BillTo_Fax { get; private set; }

        public VocabularyKey DiscountPercentage { get; private set; }

        public VocabularyKey ContactIdName { get; private set; }

        public VocabularyKey AccountIdName { get; private set; }

        public VocabularyKey OpportunityIdName { get; private set; }

        public VocabularyKey SalesOrderIdName { get; private set; }

        public VocabularyKey PriceLevelIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CustomerId { get; private set; }

        public VocabularyKey CustomerIdName { get; private set; }

        public VocabularyKey CustomerIdType { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey WillCallName { get; private set; }

        public VocabularyKey ShipTo_FreightTermsCodeName { get; private set; }

        public VocabularyKey ShippingMethodCodeName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey PaymentTermsCodeName { get; private set; }

        public VocabularyKey PricingErrorCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey IsPriceLocked { get; private set; }

        public VocabularyKey DateDelivered { get; private set; }

        public VocabularyKey DueDate { get; private set; }

        public VocabularyKey IsPriceLockedName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey TotalLineItemAmount_Base { get; private set; }

        public VocabularyKey TotalLineItemDiscountAmount_Base { get; private set; }

        public VocabularyKey TotalTax_Base { get; private set; }

        public VocabularyKey TotalAmountLessFreight_Base { get; private set; }

        public VocabularyKey DiscountAmount_Base { get; private set; }

        public VocabularyKey TotalAmount_Base { get; private set; }

        public VocabularyKey FreightAmount_Base { get; private set; }

        public VocabularyKey TotalDiscountAmount_Base { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey AccountIdYomiName { get; private set; }

        public VocabularyKey ContactIdYomiName { get; private set; }

        public VocabularyKey CustomerIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey BillTo_Composite { get; private set; }

        public VocabularyKey ShipTo_Composite { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey EmailAddress { get; private set; }

        public VocabularyKey SkipPriceCalculation { get; private set; }

        public VocabularyKey skippricecalculationName { get; private set; }


    }
}

