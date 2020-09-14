using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ContractDetailVocabulary : SimpleVocabulary
    {
        public ContractDetailVocabulary()
        {
            VocabularyName = "Dynamics365 ContractDetail";
            KeyPrefix = "dynamics365.contractdetail";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ContractDetail", group =>
            {
                this.ContractDetailId = group.Add(new VocabularyKey("ContractDetailId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contract line.")
                    .WithDisplayName("Contract Line")
                    .ModelProperty("contractdetailid", typeof(Guid)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the contract is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.ServiceAddress = group.Add(new VocabularyKey("ServiceAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"customer_address_contract_line_items")
                    .WithDisplayName("Location")
                    .ModelProperty("serviceaddress", typeof(string)));

                this.UoMId = group.Add(new VocabularyKey("UoMId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"unit_of_measurement_contract_line_items")
                    .WithDisplayName("Unit")
                    .ModelProperty("uomid", typeof(string)));

                this.ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"product_contract_line_items")
                    .WithDisplayName("Product")
                    .ModelProperty("productid", typeof(string)));

                this.ProductSerialNumber = group.Add(new VocabularyKey("ProductSerialNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the serial number for the product that is eligible for services on the contract line.")
                    .WithDisplayName("Serial Number")
                    .ModelProperty("productserialnumber", typeof(string)));

                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the contact associated with the contract line.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(string)));

                this.ContractId = group.Add(new VocabularyKey("ContractId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contract_line_items")
                    .WithDisplayName("Contract")
                    .ModelProperty("contractid", typeof(string)));

                this.LineItemOrder = group.Add(new VocabularyKey("LineItemOrder", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.")
                    .WithDisplayName("Line Item Order")
                    .ModelProperty("lineitemorder", typeof(long)));

                this.ServiceContractUnitsCode = group.Add(new VocabularyKey("ServiceContractUnitsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.")
                    .WithDisplayName("Service Contract Units")
                    .ModelProperty("servicecontractunitscode", typeof(string)));

                this.InitialQuantity = group.Add(new VocabularyKey("InitialQuantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of units of the specified product or service that are eligible for support on the contract line.")
                    .WithDisplayName("Quantity")
                    .ModelProperty("initialquantity", typeof(long)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Type a title or name that describes the contract line.")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.EffectivityCalendar = group.Add(new VocabularyKey("EffectivityCalendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(168))
                    .WithDescription(@"Days of the week and times for which the contract line item is effective.")
                    .WithDisplayName("Support Calendar")
                    .ModelProperty("effectivitycalendar", typeof(string)));

                this.ActiveOn = group.Add(new VocabularyKey("ActiveOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the contract line becomes active.")
                    .WithDisplayName("Start Date")
                    .ModelProperty("activeon", typeof(DateTime)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ExpiresOn = group.Add(new VocabularyKey("ExpiresOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.")
                    .WithDisplayName("End Date")
                    .ModelProperty("expireson", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_contractdetailbase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.TotalAllotments = group.Add(new VocabularyKey("TotalAllotments", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the total number of minutes or cases allowed for the contract line.")
                    .WithDisplayName("Total Allotments")
                    .ModelProperty("totalallotments", typeof(long)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_contractdetailbase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Rate = group.Add(new VocabularyKey("Rate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.")
                    .WithDisplayName("Rate")
                    .ModelProperty("rate", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the contract template.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Price = group.Add(new VocabularyKey("Price", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the total service charge for the contract line before any discounts are credited.")
                    .WithDisplayName("Total Price")
                    .ModelProperty("price", typeof(string)));

                this.Discount = group.Add(new VocabularyKey("Discount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.")
                    .WithDisplayName("Discount")
                    .ModelProperty("discount", typeof(string)));

                this.Net = group.Add(new VocabularyKey("Net", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.")
                    .WithDisplayName("Net")
                    .ModelProperty("net", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.AllotmentsRemaining = group.Add(new VocabularyKey("AllotmentsRemaining", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.")
                    .WithDisplayName("Allotments Remaining")
                    .ModelProperty("allotmentsremaining", typeof(long)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the contract line's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.AllotmentsUsed = group.Add(new VocabularyKey("AllotmentsUsed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of cases or minutes used in the resolved cases on the contract line.")
                    .WithDisplayName("Allotments Used")
                    .ModelProperty("allotmentsused", typeof(long)));

                this.UoMScheduleId = group.Add(new VocabularyKey("UoMScheduleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contract_detail_unit_of_measure_schedule")
                    .WithDisplayName("Unit Schedule")
                    .ModelProperty("uomscheduleid", typeof(string)));

                this.ContractIdName = group.Add(new VocabularyKey("ContractIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContractIdName")
                    .ModelProperty("contractidname", typeof(string)));

                this.ServiceAddressName = group.Add(new VocabularyKey("ServiceAddressName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ServiceAddressName")
                    .ModelProperty("serviceaddressname", typeof(string)));

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

                this.UoMScheduleIdName = group.Add(new VocabularyKey("UoMScheduleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("UoMScheduleIdName")
                    .ModelProperty("uomscheduleidname", typeof(string)));

                this.ContractStateCode = group.Add(new VocabularyKey("ContractStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status of the contract.")
                    .WithDisplayName("Contract State")
                    .ModelProperty("contractstatecode", typeof(string)));

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
                    .WithDescription(@"contractlineitem_customer_contacts")
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

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.ContractStateCodeName = group.Add(new VocabularyKey("ContractStateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ContractStateCodeName")
                    .ModelProperty("contractstatecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.ServiceContractUnitsCodeName = group.Add(new VocabularyKey("ServiceContractUnitsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ServiceContractUnitsCodeName")
                    .ModelProperty("servicecontractunitscodename", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the contract line.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the contract line.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.DiscountPercentage = group.Add(new VocabularyKey("DiscountPercentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.")
                    .WithDisplayName("Discount (%)")
                    .ModelProperty("discountpercentage", typeof(decimal)));

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

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"transactioncurrency_contractdetail")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

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

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.Discount_Base = group.Add(new VocabularyKey("Discount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Discount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Discount (Base)")
                    .ModelProperty("discount_base", typeof(string)));

                this.Rate_Base = group.Add(new VocabularyKey("Rate_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Rate field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Rate (Base)")
                    .ModelProperty("rate_base", typeof(string)));

                this.Price_Base = group.Add(new VocabularyKey("Price_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Price field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Price (Base)")
                    .ModelProperty("price_base", typeof(string)));

                this.Net_Base = group.Add(new VocabularyKey("Net_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Net field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Net (Base)")
                    .ModelProperty("net_base", typeof(string)));

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

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the contract detail.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.CustomerIdYomiName = group.Add(new VocabularyKey("CustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdYomiName")
                    .ModelProperty("customeridyominame", typeof(string)));

                this.AllotmentsOverage = group.Add(new VocabularyKey("AllotmentsOverage", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.")
                    .WithDisplayName("Allotments Overage")
                    .ModelProperty("allotmentsoverage", typeof(long)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_contractdetail_createdonbehalfby")
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
                    .WithDescription(@"lk_contractdetail_modifiedonbehalfby")
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


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ContractDetailId { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey ServiceAddress { get; private set; }

        public VocabularyKey UoMId { get; private set; }

        public VocabularyKey ProductId { get; private set; }

        public VocabularyKey ProductSerialNumber { get; private set; }

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey ContractId { get; private set; }

        public VocabularyKey LineItemOrder { get; private set; }

        public VocabularyKey ServiceContractUnitsCode { get; private set; }

        public VocabularyKey InitialQuantity { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey EffectivityCalendar { get; private set; }

        public VocabularyKey ActiveOn { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ExpiresOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey TotalAllotments { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Rate { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Price { get; private set; }

        public VocabularyKey Discount { get; private set; }

        public VocabularyKey Net { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey AllotmentsRemaining { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey AllotmentsUsed { get; private set; }

        public VocabularyKey UoMScheduleId { get; private set; }

        public VocabularyKey ContractIdName { get; private set; }

        public VocabularyKey ServiceAddressName { get; private set; }

        public VocabularyKey ProductIdName { get; private set; }

        public VocabularyKey UoMIdName { get; private set; }

        public VocabularyKey UoMScheduleIdName { get; private set; }

        public VocabularyKey ContractStateCode { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CustomerId { get; private set; }

        public VocabularyKey CustomerIdName { get; private set; }

        public VocabularyKey CustomerIdType { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey ContractStateCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ServiceContractUnitsCodeName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey DiscountPercentage { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey Discount_Base { get; private set; }

        public VocabularyKey Rate_Base { get; private set; }

        public VocabularyKey Price_Base { get; private set; }

        public VocabularyKey Net_Base { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey CustomerIdYomiName { get; private set; }

        public VocabularyKey AllotmentsOverage { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }


    }
}

