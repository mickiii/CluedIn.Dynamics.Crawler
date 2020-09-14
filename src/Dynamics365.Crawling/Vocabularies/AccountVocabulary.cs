using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Dynamics365 Account";
            KeyPrefix = "dynamics365.account";
            KeySeparator = ".";
            Grouping = EntityType.Organization;

            this.AddGroup("Account", group =>
            {
                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(Guid)));

                this.AccountCategoryCode = group.Add(new VocabularyKey("AccountCategoryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a category to indicate whether the customer account is standard or preferred.")
                    .WithDisplayName("Category")
                    .ModelProperty("accountcategorycode", typeof(string)));

                this.TerritoryId = group.Add(new VocabularyKey("TerritoryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.")
                    .WithDisplayName("Territory")
                    .ModelProperty("territoryid", typeof(string)));

                this.DefaultPriceLevelId = group.Add(new VocabularyKey("DefaultPriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.")
                    .WithDisplayName("Price List")
                    .ModelProperty("defaultpricelevelid", typeof(string)));

                this.CustomerSizeCode = group.Add(new VocabularyKey("CustomerSizeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the size category or range of the account for segmentation and reporting purposes.")
                    .WithDisplayName("Customer Size")
                    .ModelProperty("customersizecode", typeof(string)));

                this.PreferredContactMethodCode = group.Add(new VocabularyKey("PreferredContactMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred method of contact.")
                    .WithDisplayName("Preferred Method of Contact")
                    .ModelProperty("preferredcontactmethodcode", typeof(string)));

                this.CustomerTypeCode = group.Add(new VocabularyKey("CustomerTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the category that best describes the relationship between the account and your organization.")
                    .WithDisplayName("Relationship Type")
                    .ModelProperty("customertypecode", typeof(string)));

                this.AccountRatingCode = group.Add(new VocabularyKey("AccountRatingCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a rating to indicate the value of the customer account.")
                    .WithDisplayName("Account Rating")
                    .ModelProperty("accountratingcode", typeof(string)));

                this.IndustryCode = group.Add(new VocabularyKey("IndustryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the account's primary industry for use in marketing segmentation and demographic analysis.")
                    .WithDisplayName("Industry")
                    .ModelProperty("industrycode", typeof(string)));

                this.TerritoryCode = group.Add(new VocabularyKey("TerritoryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a region or territory for the account for use in segmentation and analysis.")
                    .WithDisplayName("Territory Code")
                    .ModelProperty("territorycode", typeof(string)));

                this.AccountClassificationCode = group.Add(new VocabularyKey("AccountClassificationCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.")
                    .WithDisplayName("Classification")
                    .ModelProperty("accountclassificationcode", typeof(string)));

                this.BusinessTypeCode = group.Add(new VocabularyKey("BusinessTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the legal designation or other business type of the account for contracts or reporting purposes.")
                    .WithDisplayName("Business Type")
                    .ModelProperty("businesstypecode", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the business unit that the record owner belongs to.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the account.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OriginatingLeadId = group.Add(new VocabularyKey("OriginatingLeadId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics CRM. This is used to relate the account to data on the originating lead for use in reporting and analytics.")
                    .WithDisplayName("Originating Lead")
                    .ModelProperty("originatingleadid", typeof(string)));

                this.PaymentTermsCode = group.Add(new VocabularyKey("PaymentTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the payment terms to indicate when the customer needs to pay the total amount.")
                    .WithDisplayName("Payment Terms")
                    .ModelProperty("paymenttermscode", typeof(string)));

                this.ShippingMethodCode = group.Add(new VocabularyKey("ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.")
                    .WithDisplayName("Shipping Method")
                    .ModelProperty("shippingmethodcode", typeof(string)));

                this.PrimaryContactId = group.Add(new VocabularyKey("PrimaryContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the primary contact for the account to provide quick access to contact details.")
                    .WithDisplayName("Primary Contact")
                    .ModelProperty("primarycontactid", typeof(string)));

                this.ParticipatesInWorkflow = group.Add(new VocabularyKey("ParticipatesInWorkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.")
                    .WithDisplayName("Participates in Workflow")
                    .ModelProperty("participatesinworkflow", typeof(bool)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Type the full legal Company Name")
                    .WithDisplayName("Account Name")
                    .ModelProperty("name", typeof(string)));

                this.AccountNumber = group.Add(new VocabularyKey("AccountNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Automatically generated Account ID number")
                    .WithDisplayName("Account Number")
                    .ModelProperty("accountnumber", typeof(string)));

                this.Revenue = group.Add(new VocabularyKey("Revenue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the annual revenue for the account, used as an indicator in financial performance analysis.")
                    .WithDisplayName("Annual Revenue")
                    .ModelProperty("revenue", typeof(string)));

                this.NumberOfEmployees = group.Add(new VocabularyKey("NumberOfEmployees", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the total number of employees working at the account")
                    .WithDisplayName("Number of Employees")
                    .ModelProperty("numberofemployees", typeof(long)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5000))
                    .WithDescription(@"Type a short description of the company. Can typically be found on the company's website")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.SIC = group.Add(new VocabularyKey("SIC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"The Standard Industrial Classification SIC is a system for classifying industries by a four-digit code")
                    .WithDisplayName("SIC Code")
                    .ModelProperty("sic", typeof(string)));

                this.OwnershipCode = group.Add(new VocabularyKey("OwnershipCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the account's ownership structure, such as public or private.")
                    .WithDisplayName("Ownership")
                    .ModelProperty("ownershipcode", typeof(string)));

                this.MarketCap = group.Add(new VocabularyKey("MarketCap", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.")
                    .WithDisplayName("Market Capitalization")
                    .ModelProperty("marketcap", typeof(string)));

                this.SharesOutstanding = group.Add(new VocabularyKey("SharesOutstanding", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.")
                    .WithDisplayName("Shares Outstanding")
                    .ModelProperty("sharesoutstanding", typeof(long)));

                this.TickerSymbol = group.Add(new VocabularyKey("TickerSymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(10))
                    .WithDescription(@"Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.")
                    .WithDisplayName("Ticker Symbol")
                    .ModelProperty("tickersymbol", typeof(string)));

                this.StockExchange = group.Add(new VocabularyKey("StockExchange", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the stock exchange at which the account is listed to track their stock and financial performance of the company.")
                    .WithDisplayName("Stock Exchange")
                    .ModelProperty("stockexchange", typeof(string)));

                this.WebSiteURL = group.Add(new VocabularyKey("WebSiteURL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the account's website URL to get quick details about the company profile.")
                    .WithDisplayName("Website")
                    .ModelProperty("websiteurl", typeof(string)));

                this.FtpSiteURL = group.Add(new VocabularyKey("FtpSiteURL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the URL for the account's FTP site to enable users to access data and share documents.")
                    .WithDisplayName("FTP Site")
                    .ModelProperty("ftpsiteurl", typeof(string)));

                this.EMailAddress1 = group.Add(new VocabularyKey("EMailAddress1", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the primary email address for the account.")
                    .WithDisplayName("Email")
                    .ModelProperty("emailaddress1", typeof(string)));

                this.EMailAddress2 = group.Add(new VocabularyKey("EMailAddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the secondary email address for the account.")
                    .WithDisplayName("Email Address 2")
                    .ModelProperty("emailaddress2", typeof(string)));

                this.EMailAddress3 = group.Add(new VocabularyKey("EMailAddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type an alternate email address for the account.")
                    .WithDisplayName("Email Address 3")
                    .ModelProperty("emailaddress3", typeof(string)));

                this.DoNotPhone = group.Add(new VocabularyKey("DoNotPhone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.")
                    .WithDisplayName("Do not allow Phone Calls")
                    .ModelProperty("donotphone", typeof(bool)));

                this.DoNotFax = group.Add(new VocabularyKey("DoNotFax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.")
                    .WithDisplayName("Do not allow Faxes")
                    .ModelProperty("donotfax", typeof(bool)));

                this.Telephone1 = group.Add(new VocabularyKey("Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the corporate business number for the account. 
Prefix the number with a +country code")
                    .WithDisplayName("Main Phone")
                    .ModelProperty("telephone1", typeof(string)));

                this.DoNotEMail = group.Add(new VocabularyKey("DoNotEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account allows direct email sent from Microsoft Dynamics 365.")
                    .WithDisplayName("Do not allow Emails")
                    .ModelProperty("donotemail", typeof(bool)));

                this.Telephone2 = group.Add(new VocabularyKey("Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second phone number for this account.")
                    .WithDisplayName("Other Phone")
                    .ModelProperty("telephone2", typeof(string)));

                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number for the account.
Only use numbers after the country code.")
                    .WithDisplayName("Fax")
                    .ModelProperty("fax", typeof(string)));

                this.Telephone3 = group.Add(new VocabularyKey("Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number for this account.")
                    .WithDisplayName("Telephone 3")
                    .ModelProperty("telephone3", typeof(string)));

                this.DoNotPostalMail = group.Add(new VocabularyKey("DoNotPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.")
                    .WithDisplayName("Do not allow Mails")
                    .ModelProperty("donotpostalmail", typeof(bool)));

                this.DoNotBulkEMail = group.Add(new VocabularyKey("DoNotBulkEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.")
                    .WithDisplayName("Do not allow Bulk Emails")
                    .ModelProperty("donotbulkemail", typeof(bool)));

                this.DoNotBulkPostalMail = group.Add(new VocabularyKey("DoNotBulkPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.")
                    .WithDisplayName("Do not allow Bulk Mails")
                    .ModelProperty("donotbulkpostalmail", typeof(bool)));

                this.CreditLimit = group.Add(new VocabularyKey("CreditLimit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.")
                    .WithDisplayName("Credit Limit")
                    .ModelProperty("creditlimit", typeof(string)));

                this.CreditOnHold = group.Add(new VocabularyKey("CreditOnHold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.")
                    .WithDisplayName("Credit Hold")
                    .ModelProperty("creditonhold", typeof(bool)));

                this.IsPrivate = group.Add(new VocabularyKey("IsPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPrivate")
                    .ModelProperty("isprivate", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the account.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ParentAccountId = group.Add(new VocabularyKey("ParentAccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.")
                    .WithDisplayName("Parent Account")
                    .ModelProperty("parentaccountid", typeof(string)));

                this.Aging30 = group.Add(new VocabularyKey("Aging30", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Aging 30")
                    .ModelProperty("aging30", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.Aging60 = group.Add(new VocabularyKey("Aging60", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Aging 60")
                    .ModelProperty("aging60", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the account's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.Aging90 = group.Add(new VocabularyKey("Aging90", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Aging 90")
                    .ModelProperty("aging90", typeof(string)));

                this.OriginatingLeadIdName = group.Add(new VocabularyKey("OriginatingLeadIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingLeadIdName")
                    .ModelProperty("originatingleadidname", typeof(string)));

                this.PrimaryContactIdName = group.Add(new VocabularyKey("PrimaryContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryContactIdName")
                    .ModelProperty("primarycontactidname", typeof(string)));

                this.ParentAccountIdName = group.Add(new VocabularyKey("ParentAccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentAccountIdName")
                    .ModelProperty("parentaccountidname", typeof(string)));

                this.DefaultPriceLevelIdName = group.Add(new VocabularyKey("DefaultPriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("DefaultPriceLevelIdName")
                    .ModelProperty("defaultpricelevelidname", typeof(string)));

                this.TerritoryIdName = group.Add(new VocabularyKey("TerritoryIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TerritoryIdName")
                    .ModelProperty("territoryidname", typeof(string)));

                this.Address1_AddressId = group.Add(new VocabularyKey("Address1_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 1.")
                    .WithDisplayName("Address 1: ID")
                    .ModelProperty("address1_addressid", typeof(Guid)));

                this.Address1_AddressTypeCode = group.Add(new VocabularyKey("Address1_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the primary address type.")
                    .WithDisplayName("Address 1: Address Type")
                    .ModelProperty("address1_addresstypecode", typeof(string)));

                this.Address1_Name = group.Add(new VocabularyKey("Address1_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a descriptive name for the primary address, such as Corporate Headquarters.")
                    .WithDisplayName("Address 1: Name")
                    .ModelProperty("address1_name", typeof(string)));

                this.Address1_PrimaryContactName = group.Add(new VocabularyKey("Address1_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the main contact at the account's primary address.")
                    .WithDisplayName("Address 1: Primary Contact Name")
                    .ModelProperty("address1_primarycontactname", typeof(string)));

                this.Address1_Line1 = group.Add(new VocabularyKey("Address1_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the primary address.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("address1_line1", typeof(string)));

                this.Address1_Line2 = group.Add(new VocabularyKey("Address1_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the second line of the primary address.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("address1_line2", typeof(string)));

                this.Address1_Line3 = group.Add(new VocabularyKey("Address1_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the third line of the primary address.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("address1_line3", typeof(string)));

                this.Address1_City = group.Add(new VocabularyKey("Address1_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the primary address.")
                    .WithDisplayName("City")
                    .ModelProperty("address1_city", typeof(string)));

                this.Address1_StateOrProvince = group.Add(new VocabularyKey("Address1_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the state or province of the primary address.")
                    .WithDisplayName("Address 1: State/Province (No NOT Use)")
                    .ModelProperty("address1_stateorprovince", typeof(string)));

                this.Address1_County = group.Add(new VocabularyKey("Address1_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the county for the primary address.")
                    .WithDisplayName("Address 1: County")
                    .ModelProperty("address1_county", typeof(string)));

                this.Address1_Country = group.Add(new VocabularyKey("Address1_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the country or region for the primary address.")
                    .WithDisplayName("Address 1: Country/Region (No NOT Use)")
                    .ModelProperty("address1_country", typeof(string)));

                this.Address1_PostOfficeBox = group.Add(new VocabularyKey("Address1_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the post office box number of the primary address.")
                    .WithDisplayName("Address 1: Post Office Box")
                    .ModelProperty("address1_postofficebox", typeof(string)));

                this.Address1_PostalCode = group.Add(new VocabularyKey("Address1_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the ZIP Code or postal code for the primary address.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("address1_postalcode", typeof(string)));

                this.Address1_UTCOffset = group.Add(new VocabularyKey("Address1_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.")
                    .WithDisplayName("Address 1: UTC Offset")
                    .ModelProperty("address1_utcoffset", typeof(long)));

                this.Address1_FreightTermsCode = group.Add(new VocabularyKey("Address1_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms for the primary address to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Address 1: Freight Terms")
                    .ModelProperty("address1_freighttermscode", typeof(string)));

                this.Address1_UPSZone = group.Add(new VocabularyKey("Address1_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.")
                    .WithDisplayName("Address 1: UPS Zone")
                    .ModelProperty("address1_upszone", typeof(string)));

                this.Address1_Latitude = group.Add(new VocabularyKey("Address1_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the latitude value for the primary address for use in mapping and other applications.")
                    .WithDisplayName("Address 1: Latitude")
                    .ModelProperty("address1_latitude", typeof(double)));

                this.Address1_Telephone1 = group.Add(new VocabularyKey("Address1_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the main phone number associated with the primary address.")
                    .WithDisplayName("Address Phone")
                    .ModelProperty("address1_telephone1", typeof(string)));

                this.Address1_Longitude = group.Add(new VocabularyKey("Address1_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the longitude value for the primary address for use in mapping and other applications.")
                    .WithDisplayName("Address 1: Longitude")
                    .ModelProperty("address1_longitude", typeof(double)));

                this.Address1_ShippingMethodCode = group.Add(new VocabularyKey("Address1_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Address 1: Shipping Method")
                    .ModelProperty("address1_shippingmethodcode", typeof(string)));

                this.Address1_Telephone2 = group.Add(new VocabularyKey("Address1_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second phone number associated with the primary address.")
                    .WithDisplayName("Address 1: Telephone 2")
                    .ModelProperty("address1_telephone2", typeof(string)));

                this.Address1_Telephone3 = group.Add(new VocabularyKey("Address1_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number associated with the primary address.")
                    .WithDisplayName("Address 1: Telephone 3")
                    .ModelProperty("address1_telephone3", typeof(string)));

                this.Address1_Fax = group.Add(new VocabularyKey("Address1_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number associated with the primary address.")
                    .WithDisplayName("Address 1: Fax")
                    .ModelProperty("address1_fax", typeof(string)));

                this.Address2_AddressId = group.Add(new VocabularyKey("Address2_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 2.")
                    .WithDisplayName("Address 2: ID")
                    .ModelProperty("address2_addressid", typeof(Guid)));

                this.Address2_AddressTypeCode = group.Add(new VocabularyKey("Address2_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the secondary address type.")
                    .WithDisplayName("Address 2: Address Type")
                    .ModelProperty("address2_addresstypecode", typeof(string)));

                this.Address2_Name = group.Add(new VocabularyKey("Address2_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a descriptive name for the secondary address, such as Corporate Headquarters.")
                    .WithDisplayName("Address 2: Name")
                    .ModelProperty("address2_name", typeof(string)));

                this.Address2_PrimaryContactName = group.Add(new VocabularyKey("Address2_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the main contact at the account's secondary address.")
                    .WithDisplayName("Address 2: Primary Contact Name")
                    .ModelProperty("address2_primarycontactname", typeof(string)));

                this.Address2_Line1 = group.Add(new VocabularyKey("Address2_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the secondary address.")
                    .WithDisplayName("Address 2: Street 1")
                    .ModelProperty("address2_line1", typeof(string)));

                this.Address2_Line2 = group.Add(new VocabularyKey("Address2_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the second line of the secondary address.")
                    .WithDisplayName("Address 2: Street 2")
                    .ModelProperty("address2_line2", typeof(string)));

                this.Address2_Line3 = group.Add(new VocabularyKey("Address2_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the third line of the secondary address.")
                    .WithDisplayName("Address 2: Street 3")
                    .ModelProperty("address2_line3", typeof(string)));

                this.Address2_City = group.Add(new VocabularyKey("Address2_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the secondary address.")
                    .WithDisplayName("Address 2: City")
                    .ModelProperty("address2_city", typeof(string)));

                this.Address2_StateOrProvince = group.Add(new VocabularyKey("Address2_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the state or province of the secondary address.")
                    .WithDisplayName("Address 2: State/Province")
                    .ModelProperty("address2_stateorprovince", typeof(string)));

                this.Address2_County = group.Add(new VocabularyKey("Address2_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the county for the secondary address.")
                    .WithDisplayName("Address 2: County")
                    .ModelProperty("address2_county", typeof(string)));

                this.Address2_Country = group.Add(new VocabularyKey("Address2_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the country or region for the secondary address.")
                    .WithDisplayName("Address 2: Country/Region")
                    .ModelProperty("address2_country", typeof(string)));

                this.Address2_PostOfficeBox = group.Add(new VocabularyKey("Address2_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the post office box number of the secondary address.")
                    .WithDisplayName("Address 2: Post Office Box")
                    .ModelProperty("address2_postofficebox", typeof(string)));

                this.Address2_PostalCode = group.Add(new VocabularyKey("Address2_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the ZIP Code or postal code for the secondary address.")
                    .WithDisplayName("Address 2: ZIP/Postal Code")
                    .ModelProperty("address2_postalcode", typeof(string)));

                this.Address2_UTCOffset = group.Add(new VocabularyKey("Address2_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.")
                    .WithDisplayName("Address 2: UTC Offset")
                    .ModelProperty("address2_utcoffset", typeof(long)));

                this.Address2_FreightTermsCode = group.Add(new VocabularyKey("Address2_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms for the secondary address to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Address 2: Freight Terms")
                    .ModelProperty("address2_freighttermscode", typeof(string)));

                this.Address2_UPSZone = group.Add(new VocabularyKey("Address2_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.")
                    .WithDisplayName("Address 2: UPS Zone")
                    .ModelProperty("address2_upszone", typeof(string)));

                this.Address2_Latitude = group.Add(new VocabularyKey("Address2_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the latitude value for the secondary address for use in mapping and other applications.")
                    .WithDisplayName("Address 2: Latitude")
                    .ModelProperty("address2_latitude", typeof(double)));

                this.Address2_Telephone1 = group.Add(new VocabularyKey("Address2_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the main phone number associated with the secondary address.")
                    .WithDisplayName("Address 2: Telephone 1")
                    .ModelProperty("address2_telephone1", typeof(string)));

                this.Address2_Longitude = group.Add(new VocabularyKey("Address2_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the longitude value for the secondary address for use in mapping and other applications.")
                    .WithDisplayName("Address 2: Longitude")
                    .ModelProperty("address2_longitude", typeof(double)));

                this.Address2_ShippingMethodCode = group.Add(new VocabularyKey("Address2_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Address 2: Shipping Method")
                    .ModelProperty("address2_shippingmethodcode", typeof(string)));

                this.Address2_Telephone2 = group.Add(new VocabularyKey("Address2_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second phone number associated with the secondary address.")
                    .WithDisplayName("Address 2: Telephone 2")
                    .ModelProperty("address2_telephone2", typeof(string)));

                this.Address2_Telephone3 = group.Add(new VocabularyKey("Address2_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number associated with the secondary address.")
                    .WithDisplayName("Address 2: Telephone 3")
                    .ModelProperty("address2_telephone3", typeof(string)));

                this.Address2_Fax = group.Add(new VocabularyKey("Address2_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number associated with the secondary address.")
                    .WithDisplayName("Address 2: Fax")
                    .ModelProperty("address2_fax", typeof(string)));

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

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Team Owner")
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

                this.DoNotFaxName = group.Add(new VocabularyKey("DoNotFaxName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotFaxName")
                    .ModelProperty("donotfaxname", typeof(string)));

                this.DoNotPhoneName = group.Add(new VocabularyKey("DoNotPhoneName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPhoneName")
                    .ModelProperty("donotphonename", typeof(string)));

                this.DoNotBulkPostalMailName = group.Add(new VocabularyKey("DoNotBulkPostalMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotBulkPostalMailName")
                    .ModelProperty("donotbulkpostalmailname", typeof(string)));

                this.CreditOnHoldName = group.Add(new VocabularyKey("CreditOnHoldName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CreditOnHoldName")
                    .ModelProperty("creditonholdname", typeof(string)));

                this.DoNotEMailName = group.Add(new VocabularyKey("DoNotEMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotEMailName")
                    .ModelProperty("donotemailname", typeof(string)));

                this.IsPrivateName = group.Add(new VocabularyKey("IsPrivateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPrivateName")
                    .ModelProperty("isprivatename", typeof(string)));

                this.DoNotPostalMailName = group.Add(new VocabularyKey("DoNotPostalMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPostalMailName")
                    .ModelProperty("donotpostalmailname", typeof(string)));

                this.ParticipatesInWorkflowName = group.Add(new VocabularyKey("ParticipatesInWorkflowName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ParticipatesInWorkflowName")
                    .ModelProperty("participatesinworkflowname", typeof(string)));

                this.DoNotBulkEMailName = group.Add(new VocabularyKey("DoNotBulkEMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotBulkEMailName")
                    .ModelProperty("donotbulkemailname", typeof(string)));

                this.Address1_ShippingMethodCodeName = group.Add(new VocabularyKey("Address1_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_ShippingMethodCodeName")
                    .ModelProperty("address1_shippingmethodcodename", typeof(string)));

                this.IndustryCodeName = group.Add(new VocabularyKey("IndustryCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IndustryCodeName")
                    .ModelProperty("industrycodename", typeof(string)));

                this.AccountRatingCodeName = group.Add(new VocabularyKey("AccountRatingCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccountRatingCodeName")
                    .ModelProperty("accountratingcodename", typeof(string)));

                this.OwnershipCodeName = group.Add(new VocabularyKey("OwnershipCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnershipCodeName")
                    .ModelProperty("ownershipcodename", typeof(string)));

                this.AccountClassificationCodeName = group.Add(new VocabularyKey("AccountClassificationCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccountClassificationCodeName")
                    .ModelProperty("accountclassificationcodename", typeof(string)));

                this.CustomerSizeCodeName = group.Add(new VocabularyKey("CustomerSizeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CustomerSizeCodeName")
                    .ModelProperty("customersizecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.ShippingMethodCodeName = group.Add(new VocabularyKey("ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShippingMethodCodeName")
                    .ModelProperty("shippingmethodcodename", typeof(string)));

                this.Address1_FreightTermsCodeName = group.Add(new VocabularyKey("Address1_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_FreightTermsCodeName")
                    .ModelProperty("address1_freighttermscodename", typeof(string)));

                this.BusinessTypeCodeName = group.Add(new VocabularyKey("BusinessTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BusinessTypeCodeName")
                    .ModelProperty("businesstypecodename", typeof(string)));

                this.Address2_FreightTermsCodeName = group.Add(new VocabularyKey("Address2_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_FreightTermsCodeName")
                    .ModelProperty("address2_freighttermscodename", typeof(string)));

                this.AccountCategoryCodeName = group.Add(new VocabularyKey("AccountCategoryCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccountCategoryCodeName")
                    .ModelProperty("accountcategorycodename", typeof(string)));

                this.PaymentTermsCodeName = group.Add(new VocabularyKey("PaymentTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PaymentTermsCodeName")
                    .ModelProperty("paymenttermscodename", typeof(string)));

                this.PreferredContactMethodCodeName = group.Add(new VocabularyKey("PreferredContactMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredContactMethodCodeName")
                    .ModelProperty("preferredcontactmethodcodename", typeof(string)));

                this.TerritoryCodeName = group.Add(new VocabularyKey("TerritoryCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TerritoryCodeName")
                    .ModelProperty("territorycodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.CustomerTypeCodeName = group.Add(new VocabularyKey("CustomerTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CustomerTypeCodeName")
                    .ModelProperty("customertypecodename", typeof(string)));

                this.Address1_AddressTypeCodeName = group.Add(new VocabularyKey("Address1_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_AddressTypeCodeName")
                    .ModelProperty("address1_addresstypecodename", typeof(string)));

                this.Address2_ShippingMethodCodeName = group.Add(new VocabularyKey("Address2_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_ShippingMethodCodeName")
                    .ModelProperty("address2_shippingmethodcodename", typeof(string)));

                this.Address2_AddressTypeCodeName = group.Add(new VocabularyKey("Address2_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_AddressTypeCodeName")
                    .ModelProperty("address2_addresstypecodename", typeof(string)));

                this.PreferredAppointmentDayCode = group.Add(new VocabularyKey("PreferredAppointmentDayCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred day of the week for service appointments.")
                    .WithDisplayName("Preferred Day")
                    .ModelProperty("preferredappointmentdaycode", typeof(string)));

                this.PreferredSystemUserId = group.Add(new VocabularyKey("PreferredSystemUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the preferred service representative for reference when you schedule service activities for the account.")
                    .WithDisplayName("Preferred User")
                    .ModelProperty("preferredsystemuserid", typeof(string)));

                this.PreferredAppointmentTimeCode = group.Add(new VocabularyKey("PreferredAppointmentTimeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred time of day for service appointments.")
                    .WithDisplayName("Preferred Time")
                    .ModelProperty("preferredappointmenttimecode", typeof(string)));

                this.Merged = group.Add(new VocabularyKey("Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether the account has been merged with another account.")
                    .WithDisplayName("Merged")
                    .ModelProperty("merged", typeof(bool)));

                this.DoNotSendMM = group.Add(new VocabularyKey("DoNotSendMM", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the account accepts marketing materials, such as brochures or catalogs.")
                    .WithDisplayName("Send Marketing Materials")
                    .ModelProperty("donotsendmm", typeof(bool)));

                this.MasterId = group.Add(new VocabularyKey("MasterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the master account that the account was merged with.")
                    .WithDisplayName("Master ID")
                    .ModelProperty("masterid", typeof(string)));

                this.LastUsedInCampaign = group.Add(new VocabularyKey("LastUsedInCampaign", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date when the account was last included in a marketing campaign or quick campaign.")
                    .WithDisplayName("Last Date Included in Campaign")
                    .ModelProperty("lastusedincampaign", typeof(DateTime)));

                this.PreferredServiceId = group.Add(new VocabularyKey("PreferredServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the account's preferred service for reference when you schedule service activities.")
                    .WithDisplayName("Preferred Service")
                    .ModelProperty("preferredserviceid", typeof(string)));

                this.PreferredEquipmentId = group.Add(new VocabularyKey("PreferredEquipmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.")
                    .WithDisplayName("Preferred Facility/Equipment")
                    .ModelProperty("preferredequipmentid", typeof(string)));

                this.PreferredEquipmentIdName = group.Add(new VocabularyKey("PreferredEquipmentIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredEquipmentIdName")
                    .ModelProperty("preferredequipmentidname", typeof(string)));

                this.PreferredServiceIdName = group.Add(new VocabularyKey("PreferredServiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredServiceIdName")
                    .ModelProperty("preferredserviceidname", typeof(string)));

                this.PreferredAppointmentTimeCodeName = group.Add(new VocabularyKey("PreferredAppointmentTimeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredAppointmentTimeCodeName")
                    .ModelProperty("preferredappointmenttimecodename", typeof(string)));

                this.PreferredAppointmentDayCodeName = group.Add(new VocabularyKey("PreferredAppointmentDayCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredAppointmentDayCodeName")
                    .ModelProperty("preferredappointmentdaycodename", typeof(string)));

                this.PreferredSystemUserIdName = group.Add(new VocabularyKey("PreferredSystemUserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredSystemUserIdName")
                    .ModelProperty("preferredsystemuseridname", typeof(string)));

                this.MergedName = group.Add(new VocabularyKey("MergedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MergedName")
                    .ModelProperty("mergedname", typeof(string)));

                this.MasterAccountIdName = group.Add(new VocabularyKey("MasterAccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterAccountIdName")
                    .ModelProperty("masteraccountidname", typeof(string)));

                this.DoNotSendMarketingMaterialName = group.Add(new VocabularyKey("DoNotSendMarketingMaterialName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotSendMarketingMaterialName")
                    .ModelProperty("donotsendmarketingmaterialname", typeof(string)));

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

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

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

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.CreditLimit_Base = group.Add(new VocabularyKey("CreditLimit_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the credit limit converted to the system's default base currency for reporting purposes.")
                    .WithDisplayName("Credit Limit (Base)")
                    .ModelProperty("creditlimit_base", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.Aging30_Base = group.Add(new VocabularyKey("Aging30_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The base currency equivalent of the aging 30 field.")
                    .WithDisplayName("Aging 30 (Base)")
                    .ModelProperty("aging30_base", typeof(string)));

                this.Revenue_Base = group.Add(new VocabularyKey("Revenue_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Annual Revenue (Base)")
                    .ModelProperty("revenue_base", typeof(string)));

                this.Aging90_Base = group.Add(new VocabularyKey("Aging90_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The base currency equivalent of the aging 90 field.")
                    .WithDisplayName("Aging 90 (Base)")
                    .ModelProperty("aging90_base", typeof(string)));

                this.MarketCap_Base = group.Add(new VocabularyKey("MarketCap_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the market capitalization converted to the system's default base currency.")
                    .WithDisplayName("Market Capitalization (Base)")
                    .ModelProperty("marketcap_base", typeof(string)));

                this.Aging60_Base = group.Add(new VocabularyKey("Aging60_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The base currency equivalent of the aging 60 field.")
                    .WithDisplayName("Aging 60 (Base)")
                    .ModelProperty("aging60_base", typeof(string)));

                this.PreferredSystemUserIdYomiName = group.Add(new VocabularyKey("PreferredSystemUserIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredSystemUserIdYomiName")
                    .ModelProperty("preferredsystemuseridyominame", typeof(string)));

                this.ParentAccountIdYomiName = group.Add(new VocabularyKey("ParentAccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentAccountIdYomiName")
                    .ModelProperty("parentaccountidyominame", typeof(string)));

                this.OriginatingLeadIdYomiName = group.Add(new VocabularyKey("OriginatingLeadIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingLeadIdYomiName")
                    .ModelProperty("originatingleadidyominame", typeof(string)));

                this.MasterAccountIdYomiName = group.Add(new VocabularyKey("MasterAccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterAccountIdYomiName")
                    .ModelProperty("masteraccountidyominame", typeof(string)));

                this.PrimaryContactIdYomiName = group.Add(new VocabularyKey("PrimaryContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryContactIdYomiName")
                    .ModelProperty("primarycontactidyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.YomiName = group.Add(new VocabularyKey("YomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.")
                    .WithDisplayName("Yomi Account Name")
                    .ModelProperty("yominame", typeof(string)));

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
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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
                    .WithDescription(@"Unique identifier of the team who owns the account.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default image for the record.")
                    .WithDisplayName("Default Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.Address2_Composite = group.Add(new VocabularyKey("Address2_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete secondary address.")
                    .WithDisplayName("Address 2")
                    .ModelProperty("address2_composite", typeof(string)));

                this.Address1_Composite = group.Add(new VocabularyKey("Address1_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete primary address.")
                    .WithDisplayName("Address 1")
                    .ModelProperty("address1_composite", typeof(string)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.OpenDeals = group.Add(new VocabularyKey("OpenDeals", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of open opportunities against an account and its child accounts.")
                    .WithDisplayName("Open Deals")
                    .ModelProperty("opendeals", typeof(long)));

                this.OpenDeals_Date = group.Add(new VocabularyKey("OpenDeals_Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The date time for Open Deals.")
                    .WithDisplayName("Open Deals(Last Updated Time)")
                    .ModelProperty("opendeals_date", typeof(DateTime)));

                this.OpenDeals_State = group.Add(new VocabularyKey("OpenDeals_State", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"State of Open Deals.")
                    .WithDisplayName("Open Deals(State)")
                    .ModelProperty("opendeals_state", typeof(long)));

                this.TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey("TimeSpentByMeOnEmailAndMeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1250))
                    .WithDescription(@"Total time spent for emails (read and write) and meetings by me in relation to account record.")
                    .WithDisplayName("Time Spent by me")
                    .ModelProperty("timespentbymeonemailandmeetings", typeof(string)));

                this.OpenRevenue = group.Add(new VocabularyKey("OpenRevenue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sum of open revenue against an account and its child accounts.")
                    .WithDisplayName("Sum of Open Oppty Revenue")
                    .ModelProperty("openrevenue", typeof(string)));

                this.OpenRevenue_Base = group.Add(new VocabularyKey("OpenRevenue_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sum of open revenue against an account and its child accounts.")
                    .WithDisplayName("Open Revenue (Base)")
                    .ModelProperty("openrevenue_base", typeof(string)));

                this.OpenRevenue_Date = group.Add(new VocabularyKey("OpenRevenue_Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The date time for Open Revenue.")
                    .WithDisplayName("Open Revenue(Last Updated Time)")
                    .ModelProperty("openrevenue_date", typeof(DateTime)));

                this.OpenRevenue_State = group.Add(new VocabularyKey("OpenRevenue_State", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"State of Open Revenue.")
                    .WithDisplayName("Open Revenue(State)")
                    .ModelProperty("openrevenue_state", typeof(long)));

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

                this.PrimarySatoriId = group.Add(new VocabularyKey("PrimarySatoriId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Primary Satori ID for Account")
                    .WithDisplayName("Primary Satori ID")
                    .ModelProperty("primarysatoriid", typeof(string)));

                this.PrimaryTwitterId = group.Add(new VocabularyKey("PrimaryTwitterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"Primary Twitter ID for Account")
                    .WithDisplayName("Primary Twitter ID")
                    .ModelProperty("primarytwitterid", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the service level agreement (SLA) that you want to apply to the Account record.")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last SLA that was applied to this case. This field is for internal use only.")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how long, in minutes, that the record was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date and time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.FollowEmail = group.Add(new VocabularyKey("FollowEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.")
                    .WithDisplayName("Follow Email Activity")
                    .ModelProperty("followemail", typeof(bool)));

                this.FollowEmailName = group.Add(new VocabularyKey("FollowEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FollowEmailName")
                    .ModelProperty("followemailname", typeof(string)));

                this.MarketingOnly = group.Add(new VocabularyKey("MarketingOnly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether is only for marketing")
                    .WithDisplayName("Marketing Only")
                    .ModelProperty("marketingonly", typeof(bool)));

                this.MarketingOnlyName = group.Add(new VocabularyKey("MarketingOnlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MarketingOnlyName")
                    .ModelProperty("marketingonlyname", typeof(string)));

                this.TeamsFollowed = group.Add(new VocabularyKey("TeamsFollowed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of users or conversations followed the record")
                    .WithDisplayName("TeamsFollowed")
                    .ModelProperty("teamsfollowed", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey AccountCategoryCode { get; private set; }

        public VocabularyKey TerritoryId { get; private set; }

        public VocabularyKey DefaultPriceLevelId { get; private set; }

        public VocabularyKey CustomerSizeCode { get; private set; }

        public VocabularyKey PreferredContactMethodCode { get; private set; }

        public VocabularyKey CustomerTypeCode { get; private set; }

        public VocabularyKey AccountRatingCode { get; private set; }

        public VocabularyKey IndustryCode { get; private set; }

        public VocabularyKey TerritoryCode { get; private set; }

        public VocabularyKey AccountClassificationCode { get; private set; }

        public VocabularyKey BusinessTypeCode { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OriginatingLeadId { get; private set; }

        public VocabularyKey PaymentTermsCode { get; private set; }

        public VocabularyKey ShippingMethodCode { get; private set; }

        public VocabularyKey PrimaryContactId { get; private set; }

        public VocabularyKey ParticipatesInWorkflow { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey AccountNumber { get; private set; }

        public VocabularyKey Revenue { get; private set; }

        public VocabularyKey NumberOfEmployees { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey SIC { get; private set; }

        public VocabularyKey OwnershipCode { get; private set; }

        public VocabularyKey MarketCap { get; private set; }

        public VocabularyKey SharesOutstanding { get; private set; }

        public VocabularyKey TickerSymbol { get; private set; }

        public VocabularyKey StockExchange { get; private set; }

        public VocabularyKey WebSiteURL { get; private set; }

        public VocabularyKey FtpSiteURL { get; private set; }

        public VocabularyKey EMailAddress1 { get; private set; }

        public VocabularyKey EMailAddress2 { get; private set; }

        public VocabularyKey EMailAddress3 { get; private set; }

        public VocabularyKey DoNotPhone { get; private set; }

        public VocabularyKey DoNotFax { get; private set; }

        public VocabularyKey Telephone1 { get; private set; }

        public VocabularyKey DoNotEMail { get; private set; }

        public VocabularyKey Telephone2 { get; private set; }

        public VocabularyKey Fax { get; private set; }

        public VocabularyKey Telephone3 { get; private set; }

        public VocabularyKey DoNotPostalMail { get; private set; }

        public VocabularyKey DoNotBulkEMail { get; private set; }

        public VocabularyKey DoNotBulkPostalMail { get; private set; }

        public VocabularyKey CreditLimit { get; private set; }

        public VocabularyKey CreditOnHold { get; private set; }

        public VocabularyKey IsPrivate { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ParentAccountId { get; private set; }

        public VocabularyKey Aging30 { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey Aging60 { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey Aging90 { get; private set; }

        public VocabularyKey OriginatingLeadIdName { get; private set; }

        public VocabularyKey PrimaryContactIdName { get; private set; }

        public VocabularyKey ParentAccountIdName { get; private set; }

        public VocabularyKey DefaultPriceLevelIdName { get; private set; }

        public VocabularyKey TerritoryIdName { get; private set; }

        public VocabularyKey Address1_AddressId { get; private set; }

        public VocabularyKey Address1_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_Name { get; private set; }

        public VocabularyKey Address1_PrimaryContactName { get; private set; }

        public VocabularyKey Address1_Line1 { get; private set; }

        public VocabularyKey Address1_Line2 { get; private set; }

        public VocabularyKey Address1_Line3 { get; private set; }

        public VocabularyKey Address1_City { get; private set; }

        public VocabularyKey Address1_StateOrProvince { get; private set; }

        public VocabularyKey Address1_County { get; private set; }

        public VocabularyKey Address1_Country { get; private set; }

        public VocabularyKey Address1_PostOfficeBox { get; private set; }

        public VocabularyKey Address1_PostalCode { get; private set; }

        public VocabularyKey Address1_UTCOffset { get; private set; }

        public VocabularyKey Address1_FreightTermsCode { get; private set; }

        public VocabularyKey Address1_UPSZone { get; private set; }

        public VocabularyKey Address1_Latitude { get; private set; }

        public VocabularyKey Address1_Telephone1 { get; private set; }

        public VocabularyKey Address1_Longitude { get; private set; }

        public VocabularyKey Address1_ShippingMethodCode { get; private set; }

        public VocabularyKey Address1_Telephone2 { get; private set; }

        public VocabularyKey Address1_Telephone3 { get; private set; }

        public VocabularyKey Address1_Fax { get; private set; }

        public VocabularyKey Address2_AddressId { get; private set; }

        public VocabularyKey Address2_AddressTypeCode { get; private set; }

        public VocabularyKey Address2_Name { get; private set; }

        public VocabularyKey Address2_PrimaryContactName { get; private set; }

        public VocabularyKey Address2_Line1 { get; private set; }

        public VocabularyKey Address2_Line2 { get; private set; }

        public VocabularyKey Address2_Line3 { get; private set; }

        public VocabularyKey Address2_City { get; private set; }

        public VocabularyKey Address2_StateOrProvince { get; private set; }

        public VocabularyKey Address2_County { get; private set; }

        public VocabularyKey Address2_Country { get; private set; }

        public VocabularyKey Address2_PostOfficeBox { get; private set; }

        public VocabularyKey Address2_PostalCode { get; private set; }

        public VocabularyKey Address2_UTCOffset { get; private set; }

        public VocabularyKey Address2_FreightTermsCode { get; private set; }

        public VocabularyKey Address2_UPSZone { get; private set; }

        public VocabularyKey Address2_Latitude { get; private set; }

        public VocabularyKey Address2_Telephone1 { get; private set; }

        public VocabularyKey Address2_Longitude { get; private set; }

        public VocabularyKey Address2_ShippingMethodCode { get; private set; }

        public VocabularyKey Address2_Telephone2 { get; private set; }

        public VocabularyKey Address2_Telephone3 { get; private set; }

        public VocabularyKey Address2_Fax { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey DoNotFaxName { get; private set; }

        public VocabularyKey DoNotPhoneName { get; private set; }

        public VocabularyKey DoNotBulkPostalMailName { get; private set; }

        public VocabularyKey CreditOnHoldName { get; private set; }

        public VocabularyKey DoNotEMailName { get; private set; }

        public VocabularyKey IsPrivateName { get; private set; }

        public VocabularyKey DoNotPostalMailName { get; private set; }

        public VocabularyKey ParticipatesInWorkflowName { get; private set; }

        public VocabularyKey DoNotBulkEMailName { get; private set; }

        public VocabularyKey Address1_ShippingMethodCodeName { get; private set; }

        public VocabularyKey IndustryCodeName { get; private set; }

        public VocabularyKey AccountRatingCodeName { get; private set; }

        public VocabularyKey OwnershipCodeName { get; private set; }

        public VocabularyKey AccountClassificationCodeName { get; private set; }

        public VocabularyKey CustomerSizeCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address1_FreightTermsCodeName { get; private set; }

        public VocabularyKey BusinessTypeCodeName { get; private set; }

        public VocabularyKey Address2_FreightTermsCodeName { get; private set; }

        public VocabularyKey AccountCategoryCodeName { get; private set; }

        public VocabularyKey PaymentTermsCodeName { get; private set; }

        public VocabularyKey PreferredContactMethodCodeName { get; private set; }

        public VocabularyKey TerritoryCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey CustomerTypeCodeName { get; private set; }

        public VocabularyKey Address1_AddressTypeCodeName { get; private set; }

        public VocabularyKey Address2_ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address2_AddressTypeCodeName { get; private set; }

        public VocabularyKey PreferredAppointmentDayCode { get; private set; }

        public VocabularyKey PreferredSystemUserId { get; private set; }

        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }

        public VocabularyKey Merged { get; private set; }

        public VocabularyKey DoNotSendMM { get; private set; }

        public VocabularyKey MasterId { get; private set; }

        public VocabularyKey LastUsedInCampaign { get; private set; }

        public VocabularyKey PreferredServiceId { get; private set; }

        public VocabularyKey PreferredEquipmentId { get; private set; }

        public VocabularyKey PreferredEquipmentIdName { get; private set; }

        public VocabularyKey PreferredServiceIdName { get; private set; }

        public VocabularyKey PreferredAppointmentTimeCodeName { get; private set; }

        public VocabularyKey PreferredAppointmentDayCodeName { get; private set; }

        public VocabularyKey PreferredSystemUserIdName { get; private set; }

        public VocabularyKey MergedName { get; private set; }

        public VocabularyKey MasterAccountIdName { get; private set; }

        public VocabularyKey DoNotSendMarketingMaterialName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey CreditLimit_Base { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey Aging30_Base { get; private set; }

        public VocabularyKey Revenue_Base { get; private set; }

        public VocabularyKey Aging90_Base { get; private set; }

        public VocabularyKey MarketCap_Base { get; private set; }

        public VocabularyKey Aging60_Base { get; private set; }

        public VocabularyKey PreferredSystemUserIdYomiName { get; private set; }

        public VocabularyKey ParentAccountIdYomiName { get; private set; }

        public VocabularyKey OriginatingLeadIdYomiName { get; private set; }

        public VocabularyKey MasterAccountIdYomiName { get; private set; }

        public VocabularyKey PrimaryContactIdYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey YomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey Address2_Composite { get; private set; }

        public VocabularyKey Address1_Composite { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey OpenDeals { get; private set; }

        public VocabularyKey OpenDeals_Date { get; private set; }

        public VocabularyKey OpenDeals_State { get; private set; }

        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }

        public VocabularyKey OpenRevenue { get; private set; }

        public VocabularyKey OpenRevenue_Base { get; private set; }

        public VocabularyKey OpenRevenue_Date { get; private set; }

        public VocabularyKey OpenRevenue_State { get; private set; }

        public VocabularyKey CreatedByExternalParty { get; private set; }

        public VocabularyKey CreatedByExternalPartyName { get; private set; }

        public VocabularyKey CreatedByExternalPartyYomiName { get; private set; }

        public VocabularyKey ModifiedByExternalParty { get; private set; }

        public VocabularyKey ModifiedByExternalPartyName { get; private set; }

        public VocabularyKey ModifiedByExternalPartyYomiName { get; private set; }

        public VocabularyKey PrimarySatoriId { get; private set; }

        public VocabularyKey PrimaryTwitterId { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey FollowEmail { get; private set; }

        public VocabularyKey FollowEmailName { get; private set; }

        public VocabularyKey MarketingOnly { get; private set; }

        public VocabularyKey MarketingOnlyName { get; private set; }

        public VocabularyKey TeamsFollowed { get; private set; }


    }
}

