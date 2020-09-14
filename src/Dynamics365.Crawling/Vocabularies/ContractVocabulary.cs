using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ContractVocabulary : SimpleVocabulary
    {
        public ContractVocabulary()
        {
            VocabularyName = "Dynamics365 Contract";
            KeyPrefix = "dynamics365.contract";
            KeySeparator = ".";
            Grouping = EntityType.Sales.Contract;

            this.AddGroup("Contract", group =>
            {
                this.ContractId = group.Add(new VocabularyKey("ContractId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contract.")
                    .WithDisplayName("Contract")
                    .ModelProperty("contractid", typeof(Guid)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_service_contracts")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.ContractTemplateId = group.Add(new VocabularyKey("ContractTemplateId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contract_template_contracts")
                    .WithDisplayName("Contract Template")
                    .ModelProperty("contracttemplateid", typeof(string)));

                this.ContractServiceLevelCode = group.Add(new VocabularyKey("ContractServiceLevelCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.")
                    .WithDisplayName("Service Level")
                    .ModelProperty("contractservicelevelcode", typeof(string)));

                this.ServiceAddress = group.Add(new VocabularyKey("ServiceAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"customer_address_contracts_as_service_address")
                    .WithDisplayName("Contract Address")
                    .ModelProperty("serviceaddress", typeof(string)));

                this.BillToAddress = group.Add(new VocabularyKey("BillToAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"customer_address_contracts_as_billing_address")
                    .WithDisplayName("Bill To Address")
                    .ModelProperty("billtoaddress", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"system_user_service_contracts")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact specified for the contract.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(string)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the contract is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.BillingAccountId = group.Add(new VocabularyKey("BillingAccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account to which the contract is to be billed.")
                    .WithDisplayName("Billing Account")
                    .ModelProperty("billingaccountid", typeof(string)));

                this.ContractNumber = group.Add(new VocabularyKey("ContractNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.")
                    .WithDisplayName("Contract ID")
                    .ModelProperty("contractnumber", typeof(string)));

                this.BillingContactId = group.Add(new VocabularyKey("BillingContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact to whom the contract is to be billed.")
                    .WithDisplayName("Billing Contact")
                    .ModelProperty("billingcontactid", typeof(string)));

                this.ActiveOn = group.Add(new VocabularyKey("ActiveOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the contract becomes active.")
                    .WithDisplayName("Contract Start Date")
                    .ModelProperty("activeon", typeof(DateTime)));

                this.ExpiresOn = group.Add(new VocabularyKey("ExpiresOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the contract expires.")
                    .WithDisplayName("Contract End Date")
                    .ModelProperty("expireson", typeof(DateTime)));

                this.CancelOn = group.Add(new VocabularyKey("CancelOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the contract was canceled.")
                    .WithDisplayName("Cancellation Date")
                    .ModelProperty("cancelon", typeof(DateTime)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a title or name for the contract that indicates the purpose of the contract.")
                    .WithDisplayName("Contract Name")
                    .ModelProperty("title", typeof(string)));

                this.ContractLanguage = group.Add(new VocabularyKey("ContractLanguage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information about the contract, such as the products or services provided to the customer.")
                    .WithDisplayName("Description")
                    .ModelProperty("contractlanguage", typeof(string)));

                this.BillingStartOn = group.Add(new VocabularyKey("BillingStartOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.")
                    .WithDisplayName("Billing Start Date")
                    .ModelProperty("billingstarton", typeof(DateTime)));

                this.EffectivityCalendar = group.Add(new VocabularyKey("EffectivityCalendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(168))
                    .WithDescription(@"Days of the week and times during which customer service support is available for the duration of the contract.")
                    .WithDisplayName("Support Calendar")
                    .ModelProperty("effectivitycalendar", typeof(string)));

                this.BillingEndOn = group.Add(new VocabularyKey("BillingEndOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.")
                    .WithDisplayName("Billing End Date")
                    .ModelProperty("billingendon", typeof(DateTime)));

                this.BillingFrequencyCode = group.Add(new VocabularyKey("BillingFrequencyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the billing schedule of the contract to indicate how often the customer should be invoiced.")
                    .WithDisplayName("Billing Frequency")
                    .ModelProperty("billingfrequencycode", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_contractbase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_contractbase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.AllotmentTypeCode = group.Add(new VocabularyKey("AllotmentTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of allotment that the contract supports.")
                    .WithDisplayName("Allotment Type")
                    .ModelProperty("allotmenttypecode", typeof(string)));

                this.UseDiscountAsPercentage = group.Add(new VocabularyKey("UseDiscountAsPercentage", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.")
                    .WithDisplayName("Discount")
                    .ModelProperty("usediscountaspercentage", typeof(bool)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.TotalPrice = group.Add(new VocabularyKey("TotalPrice", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.")
                    .WithDisplayName("Total Price")
                    .ModelProperty("totalprice", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the contract.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.TotalDiscount = group.Add(new VocabularyKey("TotalDiscount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.")
                    .WithDisplayName("Total Discount")
                    .ModelProperty("totaldiscount", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.NetPrice = group.Add(new VocabularyKey("NetPrice", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.")
                    .WithDisplayName("Net Price")
                    .ModelProperty("netprice", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the contract's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.OriginatingContract = group.Add(new VocabularyKey("OriginatingContract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"contract_originating_contract")
                    .WithDisplayName("Originating Contract")
                    .ModelProperty("originatingcontract", typeof(string)));

                this.Duration = group.Add(new VocabularyKey("Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows for the duration of the contract, in days, based on the contract start and end dates.")
                    .WithDisplayName("Duration")
                    .ModelProperty("duration", typeof(long)));

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

                this.BillingContactIdName = group.Add(new VocabularyKey("BillingContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BillingContactIdName")
                    .ModelProperty("billingcontactidname", typeof(string)));

                this.BillingAccountIdName = group.Add(new VocabularyKey("BillingAccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BillingAccountIdName")
                    .ModelProperty("billingaccountidname", typeof(string)));

                this.ContractTemplateIdName = group.Add(new VocabularyKey("ContractTemplateIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContractTemplateIdName")
                    .ModelProperty("contracttemplateidname", typeof(string)));

                this.OriginatingContractName = group.Add(new VocabularyKey("OriginatingContractName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingContractName")
                    .ModelProperty("originatingcontractname", typeof(string)));

                this.BillToAddressName = group.Add(new VocabularyKey("BillToAddressName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the address that is to be billed for the contract.")
                    .WithDisplayName("BillToAddressName")
                    .ModelProperty("billtoaddressname", typeof(string)));

                this.ServiceAddressName = group.Add(new VocabularyKey("ServiceAddressName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ServiceAddressName")
                    .ModelProperty("serviceaddressname", typeof(string)));

                this.ContractTemplateAbbreviation = group.Add(new VocabularyKey("ContractTemplateAbbreviation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(20))
                    .WithDescription(@"Shows the abbreviation of the contract template selected when the contract is created.")
                    .WithDisplayName("Template Abbreviation")
                    .ModelProperty("contracttemplateabbreviation", typeof(string)));

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
                    .WithDescription(@"Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.")
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

                this.BillingCustomerId = group.Add(new VocabularyKey("BillingCustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contract_billingcustomer_contacts")
                    .WithDisplayName("Bill To Customer")
                    .ModelProperty("billingcustomerid", typeof(string)));

                this.BillingCustomerIdName = group.Add(new VocabularyKey("BillingCustomerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("BillingCustomerIdName")
                    .ModelProperty("billingcustomeridname", typeof(string)));

                this.BillingCustomerIdType = group.Add(new VocabularyKey("BillingCustomerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Bill To Customer Type")
                    .ModelProperty("billingcustomeridtype", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"owner_contracts")
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

                this.UseDiscountAsPercentageName = group.Add(new VocabularyKey("UseDiscountAsPercentageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UseDiscountAsPercentageName")
                    .ModelProperty("usediscountaspercentagename", typeof(string)));

                this.BillingFrequencyCodeName = group.Add(new VocabularyKey("BillingFrequencyCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BillingFrequencyCodeName")
                    .ModelProperty("billingfrequencycodename", typeof(string)));

                this.ContractServiceLevelCodeName = group.Add(new VocabularyKey("ContractServiceLevelCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ContractServiceLevelCodeName")
                    .ModelProperty("contractservicelevelcodename", typeof(string)));

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

                this.AllotmentTypeCodeName = group.Add(new VocabularyKey("AllotmentTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AllotmentTypeCodeName")
                    .ModelProperty("allotmenttypecodename", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

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

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"transactioncurrency_contract")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TotalDiscount_Base = group.Add(new VocabularyKey("TotalDiscount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Discount field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Discount (Base)")
                    .ModelProperty("totaldiscount_base", typeof(string)));

                this.NetPrice_Base = group.Add(new VocabularyKey("NetPrice_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Net Price field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Net Price (Base)")
                    .ModelProperty("netprice_base", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.TotalPrice_Base = group.Add(new VocabularyKey("TotalPrice_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Price field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Price (Base)")
                    .ModelProperty("totalprice_base", typeof(string)));

                this.BillingContactIdYomiName = group.Add(new VocabularyKey("BillingContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BillingContactIdYomiName")
                    .ModelProperty("billingcontactidyominame", typeof(string)));

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

                this.BillingAccountIdYomiName = group.Add(new VocabularyKey("BillingAccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BillingAccountIdYomiName")
                    .ModelProperty("billingaccountidyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.BillingCustomerIdYomiName = group.Add(new VocabularyKey("BillingCustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("BillingCustomerIdYomiName")
                    .ModelProperty("billingcustomeridyominame", typeof(string)));

                this.ContactIdYomiName = group.Add(new VocabularyKey("ContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdYomiName")
                    .ModelProperty("contactidyominame", typeof(string)));

                this.AccountIdYomiName = group.Add(new VocabularyKey("AccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdYomiName")
                    .ModelProperty("accountidyominame", typeof(string)));

                this.CustomerIdYomiName = group.Add(new VocabularyKey("CustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdYomiName")
                    .ModelProperty("customeridyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_contract_createdonbehalfby")
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
                    .WithDescription(@"lk_contract_modifiedonbehalfby")
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
                    .WithDescription(@"team_service_contracts")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

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

                this.EmailAddress = group.Add(new VocabularyKey("EmailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The primary email address for the entity.")
                    .WithDisplayName("Email Address")
                    .ModelProperty("emailaddress", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ContractId { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey ContractTemplateId { get; private set; }

        public VocabularyKey ContractServiceLevelCode { get; private set; }

        public VocabularyKey ServiceAddress { get; private set; }

        public VocabularyKey BillToAddress { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey BillingAccountId { get; private set; }

        public VocabularyKey ContractNumber { get; private set; }

        public VocabularyKey BillingContactId { get; private set; }

        public VocabularyKey ActiveOn { get; private set; }

        public VocabularyKey ExpiresOn { get; private set; }

        public VocabularyKey CancelOn { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey ContractLanguage { get; private set; }

        public VocabularyKey BillingStartOn { get; private set; }

        public VocabularyKey EffectivityCalendar { get; private set; }

        public VocabularyKey BillingEndOn { get; private set; }

        public VocabularyKey BillingFrequencyCode { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey AllotmentTypeCode { get; private set; }

        public VocabularyKey UseDiscountAsPercentage { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey TotalPrice { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey TotalDiscount { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey NetPrice { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey OriginatingContract { get; private set; }

        public VocabularyKey Duration { get; private set; }

        public VocabularyKey ContactIdName { get; private set; }

        public VocabularyKey AccountIdName { get; private set; }

        public VocabularyKey BillingContactIdName { get; private set; }

        public VocabularyKey BillingAccountIdName { get; private set; }

        public VocabularyKey ContractTemplateIdName { get; private set; }

        public VocabularyKey OriginatingContractName { get; private set; }

        public VocabularyKey BillToAddressName { get; private set; }

        public VocabularyKey ServiceAddressName { get; private set; }

        public VocabularyKey ContractTemplateAbbreviation { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CustomerId { get; private set; }

        public VocabularyKey CustomerIdName { get; private set; }

        public VocabularyKey CustomerIdType { get; private set; }

        public VocabularyKey BillingCustomerId { get; private set; }

        public VocabularyKey BillingCustomerIdName { get; private set; }

        public VocabularyKey BillingCustomerIdType { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey UseDiscountAsPercentageName { get; private set; }

        public VocabularyKey BillingFrequencyCodeName { get; private set; }

        public VocabularyKey ContractServiceLevelCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey AllotmentTypeCodeName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TotalDiscount_Base { get; private set; }

        public VocabularyKey NetPrice_Base { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey TotalPrice_Base { get; private set; }

        public VocabularyKey BillingContactIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey BillingAccountIdYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey BillingCustomerIdYomiName { get; private set; }

        public VocabularyKey ContactIdYomiName { get; private set; }

        public VocabularyKey AccountIdYomiName { get; private set; }

        public VocabularyKey CustomerIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey EmailAddress { get; private set; }


    }
}

