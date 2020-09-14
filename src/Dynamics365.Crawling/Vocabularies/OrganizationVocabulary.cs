using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OrganizationVocabulary : SimpleVocabulary
    {
        public OrganizationVocabulary()
        {
            VocabularyName = "Dynamics365 Organization";
            KeyPrefix = "dynamics365.organization";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Organization", group =>
            {
                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.")
                    .WithDisplayName("Organization Name")
                    .ModelProperty("name", typeof(string)));

                this.UserGroupId = group.Add(new VocabularyKey("UserGroupId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the default group of users in the organization.")
                    .WithDisplayName("User Group")
                    .ModelProperty("usergroupid", typeof(Guid)));

                this.PrivilegeUserGroupId = group.Add(new VocabularyKey("PrivilegeUserGroupId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the default privilege for users in the organization.")
                    .WithDisplayName("Privilege User Group")
                    .ModelProperty("privilegeusergroupid", typeof(Guid)));

                this.RecurrenceExpansionJobBatchSize = group.Add(new VocabularyKey("RecurrenceExpansionJobBatchSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the value for number of instances created in on demand job in one shot.")
                    .WithDisplayName("Recurrence Expansion On Demand Job Batch Size")
                    .ModelProperty("recurrenceexpansionjobbatchsize", typeof(long)));

                this.RecurrenceExpansionJobBatchInterval = group.Add(new VocabularyKey("RecurrenceExpansionJobBatchInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the interval (in seconds) for pausing expansion job.")
                    .WithDisplayName("Recurrence Expansion Job Batch Interval")
                    .ModelProperty("recurrenceexpansionjobbatchinterval", typeof(long)));

                this.FiscalPeriodType = group.Add(new VocabularyKey("FiscalPeriodType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of fiscal period used throughout Microsoft CRM.")
                    .WithDisplayName("Fiscal Period Type")
                    .ModelProperty("fiscalperiodtype", typeof(long)));

                this.FiscalCalendarStart = group.Add(new VocabularyKey("FiscalCalendarStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start date for the fiscal period that is to be used throughout Microsoft CRM.")
                    .WithDisplayName("Fiscal Calendar Start")
                    .ModelProperty("fiscalcalendarstart", typeof(DateTime)));

                this.DateFormatCode = group.Add(new VocabularyKey("DateFormatCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about how the date is displayed throughout Microsoft CRM.")
                    .WithDisplayName("Date Format Code")
                    .ModelProperty("dateformatcode", typeof(string)));

                this.TimeFormatCode = group.Add(new VocabularyKey("TimeFormatCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies how the time is displayed throughout Microsoft CRM.")
                    .WithDisplayName("Time Format Code")
                    .ModelProperty("timeformatcode", typeof(string)));

                this.CurrencySymbol = group.Add(new VocabularyKey("CurrencySymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(13))
                    .WithDescription(@"Symbol used for currency throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Currency Symbol")
                    .ModelProperty("currencysymbol", typeof(string)));

                this.WeekStartDayCode = group.Add(new VocabularyKey("WeekStartDayCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Designated first day of the week throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Week Start Day Code")
                    .ModelProperty("weekstartdaycode", typeof(string)));

                this.DateSeparator = group.Add(new VocabularyKey("DateSeparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                    .WithDescription(@"Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Date Separator")
                    .ModelProperty("dateseparator", typeof(string)));

                this.FullNameConventionCode = group.Add(new VocabularyKey("FullNameConventionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Order in which names are to be displayed throughout Microsoft CRM.")
                    .WithDisplayName("Full Name Display Order")
                    .ModelProperty("fullnameconventioncode", typeof(string)));

                this.NegativeFormatCode = group.Add(new VocabularyKey("NegativeFormatCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies how negative numbers are displayed throughout Microsoft CRM.")
                    .WithDisplayName("Negative Format")
                    .ModelProperty("negativeformatcode", typeof(string)));

                this.NumberFormat = group.Add(new VocabularyKey("NumberFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2))
                    .WithDescription(@"Specification of how numbers are displayed throughout Microsoft CRM.")
                    .WithDisplayName("Number Format")
                    .ModelProperty("numberformat", typeof(string)));

                this.IsDisabled = group.Add(new VocabularyKey("IsDisabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that specifies whether the organization is disabled.")
                    .WithDisplayName("Is Organization Disabled")
                    .ModelProperty("isdisabled", typeof(bool)));

                this.DisabledReason = group.Add(new VocabularyKey("DisabledReason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"Reason for disabling the organization.")
                    .WithDisplayName("Disabled Reason")
                    .ModelProperty("disabledreason", typeof(string)));

                this.KbPrefix = group.Add(new VocabularyKey("KbPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix to use for all articles in Microsoft Dynamics 365.")
                    .WithDisplayName("Article Prefix")
                    .ModelProperty("kbprefix", typeof(string)));

                this.CurrentKbNumber = group.Add(new VocabularyKey("CurrentKbNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"First article number to use. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Article Number")
                    .ModelProperty("currentkbnumber", typeof(long)));

                this.CasePrefix = group.Add(new VocabularyKey("CasePrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix to use for all cases throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Case Prefix")
                    .ModelProperty("caseprefix", typeof(string)));

                this.CurrentCaseNumber = group.Add(new VocabularyKey("CurrentCaseNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"First case number to use. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Case Number")
                    .ModelProperty("currentcasenumber", typeof(long)));

                this.ContractPrefix = group.Add(new VocabularyKey("ContractPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix to use for all contracts throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Contract Prefix")
                    .ModelProperty("contractprefix", typeof(string)));

                this.CurrentContractNumber = group.Add(new VocabularyKey("CurrentContractNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"First contract number to use. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Contract Number")
                    .ModelProperty("currentcontractnumber", typeof(long)));

                this.QuotePrefix = group.Add(new VocabularyKey("QuotePrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix to use for all quotes throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Quote Prefix")
                    .ModelProperty("quoteprefix", typeof(string)));

                this.CurrentQuoteNumber = group.Add(new VocabularyKey("CurrentQuoteNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"First quote number to use. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Quote Number")
                    .ModelProperty("currentquotenumber", typeof(long)));

                this.OrderPrefix = group.Add(new VocabularyKey("OrderPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix to use for all orders throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Order Prefix")
                    .ModelProperty("orderprefix", typeof(string)));

                this.CurrentOrderNumber = group.Add(new VocabularyKey("CurrentOrderNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"First order number to use. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Order Number")
                    .ModelProperty("currentordernumber", typeof(long)));

                this.InvoicePrefix = group.Add(new VocabularyKey("InvoicePrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix to use for all invoice numbers throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Invoice Prefix")
                    .ModelProperty("invoiceprefix", typeof(string)));

                this.CurrentInvoiceNumber = group.Add(new VocabularyKey("CurrentInvoiceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"First invoice number to use. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Invoice Number")
                    .ModelProperty("currentinvoicenumber", typeof(long)));

                this.UniqueSpecifierLength = group.Add(new VocabularyKey("UniqueSpecifierLength", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of characters appended to invoice, quote, and order numbers.")
                    .WithDisplayName("Unique String Length")
                    .ModelProperty("uniquespecifierlength", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the organization was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the organization was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.FiscalYearFormat = group.Add(new VocabularyKey("FiscalYearFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                    .WithDescription(@"Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.")
                    .WithDisplayName("Fiscal Year Format")
                    .ModelProperty("fiscalyearformat", typeof(string)));

                this.FiscalPeriodFormat = group.Add(new VocabularyKey("FiscalPeriodFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                    .WithDescription(@"Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.")
                    .WithDisplayName("Fiscal Period Format")
                    .ModelProperty("fiscalperiodformat", typeof(string)));

                this.FiscalYearPeriodConnect = group.Add(new VocabularyKey("FiscalYearPeriodConnect", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                    .WithDescription(@"Information that specifies how the names of the fiscal year and the fiscal period should be connected when displayed together.")
                    .WithDisplayName("Fiscal Year Period Connector")
                    .ModelProperty("fiscalyearperiodconnect", typeof(string)));

                this.LanguageCode = group.Add(new VocabularyKey("LanguageCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Preferred language for the organization.")
                    .WithDisplayName("Language")
                    .ModelProperty("languagecode", typeof(long)));

                this.SortId = group.Add(new VocabularyKey("SortId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Sort")
                    .ModelProperty("sortid", typeof(long)));

                this.DateFormatString = group.Add(new VocabularyKey("DateFormatString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"String showing how the date is displayed throughout Microsoft CRM.")
                    .WithDisplayName("Date Format String")
                    .ModelProperty("dateformatstring", typeof(string)));

                this.TimeFormatString = group.Add(new VocabularyKey("TimeFormatString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"Text for how time is displayed in Microsoft Dynamics 365.")
                    .WithDisplayName("Time Format String")
                    .ModelProperty("timeformatstring", typeof(string)));

                this.PricingDecimalPrecision = group.Add(new VocabularyKey("PricingDecimalPrecision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of decimal places that can be used for prices.")
                    .WithDisplayName("Pricing Decimal Precision")
                    .ModelProperty("pricingdecimalprecision", typeof(long)));

                this.ShowWeekNumber = group.Add(new VocabularyKey("ShowWeekNumber", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.")
                    .WithDisplayName("Show Week Number")
                    .ModelProperty("showweeknumber", typeof(bool)));

                this.ShowWeekNumberName = group.Add(new VocabularyKey("ShowWeekNumberName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShowWeekNumberName")
                    .ModelProperty("showweeknumbername", typeof(string)));

                this.IsDisabledName = group.Add(new VocabularyKey("IsDisabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDisabledName")
                    .ModelProperty("isdisabledname", typeof(string)));

                this.DateFormatCodeName = group.Add(new VocabularyKey("DateFormatCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DateFormatCodeName")
                    .ModelProperty("dateformatcodename", typeof(string)));

                this.FullNameConventionCodeName = group.Add(new VocabularyKey("FullNameConventionCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FullNameConventionCodeName")
                    .ModelProperty("fullnameconventioncodename", typeof(string)));

                this.LanguageCodeName = group.Add(new VocabularyKey("LanguageCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LanguageCodeName")
                    .ModelProperty("languagecodename", typeof(string)));

                this.TimeFormatCodeName = group.Add(new VocabularyKey("TimeFormatCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TimeFormatCodeName")
                    .ModelProperty("timeformatcodename", typeof(string)));

                this.NegativeFormatCodeName = group.Add(new VocabularyKey("NegativeFormatCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("NegativeFormatCodeName")
                    .ModelProperty("negativeformatcodename", typeof(string)));

                this.WeekStartDayCodeName = group.Add(new VocabularyKey("WeekStartDayCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("WeekStartDayCodeName")
                    .ModelProperty("weekstartdaycodename", typeof(string)));

                this.NextTrackingNumber = group.Add(new VocabularyKey("NextTrackingNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Next token to be placed on the subject line of an email message.")
                    .WithDisplayName("Next Tracking Number")
                    .ModelProperty("nexttrackingnumber", typeof(long)));

                this.TagMaxAggressiveCycles = group.Add(new VocabularyKey("TagMaxAggressiveCycles", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.")
                    .WithDisplayName("Auto-Tag Max Cycles")
                    .ModelProperty("tagmaxaggressivecycles", typeof(long)));

                this.TokenKey = group.Add(new VocabularyKey("TokenKey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(90))
                    .WithDescription(@"Token key.")
                    .WithDisplayName("Token Key")
                    .ModelProperty("tokenkey", typeof(string)));

                this.SystemUserId = group.Add(new VocabularyKey("SystemUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the system user for the organization.")
                    .WithDisplayName("System User")
                    .ModelProperty("systemuserid", typeof(Guid)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the organization.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.GrantAccessToNetworkService = group.Add(new VocabularyKey("GrantAccessToNetworkService", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Grant Access To Network Service")
                    .ModelProperty("grantaccesstonetworkservice", typeof(bool)));

                this.AllowOutlookScheduledSyncs = group.Add(new VocabularyKey("AllowOutlookScheduledSyncs", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether scheduled synchronizations to Outlook are allowed.")
                    .WithDisplayName("Allow Scheduled Synchronization")
                    .ModelProperty("allowoutlookscheduledsyncs", typeof(bool)));

                this.AllowMarketingEmailExecution = group.Add(new VocabularyKey("AllowMarketingEmailExecution", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether marketing emails execution is allowed.")
                    .WithDisplayName("Allow Marketing Email Execution")
                    .ModelProperty("allowmarketingemailexecution", typeof(bool)));

                this.SqlAccessGroupId = group.Add(new VocabularyKey("SqlAccessGroupId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SQL Access Group")
                    .ModelProperty("sqlaccessgroupid", typeof(Guid)));

                this.CurrencyFormatCode = group.Add(new VocabularyKey("CurrencyFormatCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about how currency symbols are placed throughout Microsoft Dynamics CRM.")
                    .WithDisplayName("Currency Format Code")
                    .ModelProperty("currencyformatcode", typeof(string)));

                this.FiscalSettingsUpdated = group.Add(new VocabularyKey("FiscalSettingsUpdated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that specifies whether the fiscal settings have been updated.")
                    .WithDisplayName("Is Fiscal Settings Updated")
                    .ModelProperty("fiscalsettingsupdated", typeof(bool)));

                this.ReportingGroupId = group.Add(new VocabularyKey("ReportingGroupId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Reporting Group")
                    .ModelProperty("reportinggroupid", typeof(Guid)));

                this.TokenExpiry = group.Add(new VocabularyKey("TokenExpiry", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Duration used for token expiration.")
                    .WithDisplayName("Token Expiration Duration")
                    .ModelProperty("tokenexpiry", typeof(long)));

                this.ShareToPreviousOwnerOnAssign = group.Add(new VocabularyKey("ShareToPreviousOwnerOnAssign", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether to share to previous owner on assign.")
                    .WithDisplayName("Share To Previous Owner On Assign")
                    .ModelProperty("sharetopreviousowneronassign", typeof(bool)));

                this.AcknowledgementTemplateId = group.Add(new VocabularyKey("AcknowledgementTemplateId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the template to be used for acknowledgement when a user unsubscribes.")
                    .WithDisplayName("Acknowledgement Template")
                    .ModelProperty("acknowledgementtemplateid", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the organization.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.IntegrationUserId = group.Add(new VocabularyKey("IntegrationUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the integration user for the organization.")
                    .WithDisplayName("Integration User")
                    .ModelProperty("integrationuserid", typeof(Guid)));

                this.TrackingTokenIdBase = group.Add(new VocabularyKey("TrackingTokenIdBase", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Base number used to provide separate tracking token identifiers to users belonging to different deployments.")
                    .WithDisplayName("Tracking Token Base")
                    .ModelProperty("trackingtokenidbase", typeof(long)));

                this.BusinessClosureCalendarId = group.Add(new VocabularyKey("BusinessClosureCalendarId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business closure calendar of organization.")
                    .WithDisplayName("Business Closure Calendar")
                    .ModelProperty("businessclosurecalendarid", typeof(Guid)));

                this.AllowAutoUnsubscribeAcknowledgement = group.Add(new VocabularyKey("AllowAutoUnsubscribeAcknowledgement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether automatic unsubscribe acknowledgement email is allowed to send.")
                    .WithDisplayName("Allow Automatic Unsubscribe Acknowledgement")
                    .ModelProperty("allowautounsubscribeacknowledgement", typeof(bool)));

                this.AllowAutoUnsubscribe = group.Add(new VocabularyKey("AllowAutoUnsubscribe", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether automatic unsubscribe is allowed.")
                    .WithDisplayName("Allow Automatic Unsubscribe")
                    .ModelProperty("allowautounsubscribe", typeof(bool)));

                this.Picture = group.Add(new VocabularyKey("Picture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Picture")
                    .ModelProperty("picture", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the organization.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.TrackingPrefix = group.Add(new VocabularyKey("TrackingPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"History list of tracking token prefixes.")
                    .WithDisplayName("Tracking Prefix")
                    .ModelProperty("trackingprefix", typeof(string)));

                this.MinOutlookSyncInterval = group.Add(new VocabularyKey("MinOutlookSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Minimum allowed time between scheduled Outlook synchronizations.")
                    .WithDisplayName("Min Synchronization Frequency")
                    .ModelProperty("minoutlooksyncinterval", typeof(long)));

                this.BulkOperationPrefix = group.Add(new VocabularyKey("BulkOperationPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix used for bulk operation numbering.")
                    .WithDisplayName("Bulk Operation Prefix")
                    .ModelProperty("bulkoperationprefix", typeof(string)));

                this.AllowAutoResponseCreation = group.Add(new VocabularyKey("AllowAutoResponseCreation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether automatic response creation is allowed.")
                    .WithDisplayName("Allow Automatic Response Creation")
                    .ModelProperty("allowautoresponsecreation", typeof(bool)));

                this.MaximumTrackingNumber = group.Add(new VocabularyKey("MaximumTrackingNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum tracking number before recycling takes place.")
                    .WithDisplayName("Max Tracking Number")
                    .ModelProperty("maximumtrackingnumber", typeof(long)));

                this.CampaignPrefix = group.Add(new VocabularyKey("CampaignPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix used for campaign numbering.")
                    .WithDisplayName("Campaign Prefix")
                    .ModelProperty("campaignprefix", typeof(string)));

                this.SqlAccessGroupName = group.Add(new VocabularyKey("SqlAccessGroupName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SQL Access Group Name")
                    .ModelProperty("sqlaccessgroupname", typeof(string)));

                this.CurrentCampaignNumber = group.Add(new VocabularyKey("CurrentCampaignNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Current campaign number. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Campaign Number")
                    .ModelProperty("currentcampaignnumber", typeof(long)));

                this.FiscalYearDisplayCode = group.Add(new VocabularyKey("FiscalYearDisplayCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.")
                    .WithDisplayName("Fiscal Year Display")
                    .ModelProperty("fiscalyeardisplaycode", typeof(long)));

                this.SiteMapXml = group.Add(new VocabularyKey("SiteMapXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML string that defines the navigation structure for the application.")
                    .WithDisplayName("SiteMap XML")
                    .ModelProperty("sitemapxml", typeof(string)));

                this.ReportingGroupName = group.Add(new VocabularyKey("ReportingGroupName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Reporting Group Name")
                    .ModelProperty("reportinggroupname", typeof(string)));

                this.CurrentBulkOperationNumber = group.Add(new VocabularyKey("CurrentBulkOperationNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Current bulk operation number. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Bulk Operation Number")
                    .ModelProperty("currentbulkoperationnumber", typeof(long)));

                this.SchemaNamePrefix = group.Add(new VocabularyKey("SchemaNamePrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8))
                    .WithDescription(@"Prefix used for custom entities and attributes.")
                    .WithDisplayName("Customization Name Prefix")
                    .ModelProperty("schemanameprefix", typeof(string)));

                this.IgnoreInternalEmail = group.Add(new VocabularyKey("IgnoreInternalEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether incoming email sent by internal Microsoft Dynamics 365 users or queues should be tracked.")
                    .WithDisplayName("Ignore Internal Email")
                    .ModelProperty("ignoreinternalemail", typeof(bool)));

                this.TagPollingPeriod = group.Add(new VocabularyKey("TagPollingPeriod", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Normal polling frequency used for email receive auto-tagging in outlook.")
                    .WithDisplayName("Auto-Tag Interval")
                    .ModelProperty("tagpollingperiod", typeof(long)));

                this.TrackingTokenIdDigits = group.Add(new VocabularyKey("TrackingTokenIdDigits", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of digits used to represent a tracking token identifier.")
                    .WithDisplayName("Tracking Token Digits")
                    .ModelProperty("trackingtokeniddigits", typeof(long)));

                this.AcknowledgementTemplateIdName = group.Add(new VocabularyKey("AcknowledgementTemplateIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the template to be used for unsubscription acknowledgement.")
                    .WithDisplayName("AcknowledgementTemplateIdName")
                    .ModelProperty("acknowledgementtemplateidname", typeof(string)));

                this.CurrencyFormatCodeName = group.Add(new VocabularyKey("CurrencyFormatCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CurrencyFormatCodeName")
                    .ModelProperty("currencyformatcodename", typeof(string)));

                this.FiscalSettingsUpdatedName = group.Add(new VocabularyKey("FiscalSettingsUpdatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FiscalSettingsUpdatedName")
                    .ModelProperty("fiscalsettingsupdatedname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.NumberGroupFormat = group.Add(new VocabularyKey("NumberGroupFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Specifies how numbers are grouped in Microsoft Dynamics 365.")
                    .WithDisplayName("Number Grouping Format")
                    .ModelProperty("numbergroupformat", typeof(string)));

                this.LongDateFormatCode = group.Add(new VocabularyKey("LongDateFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies how the Long Date format is displayed in Microsoft Dynamics 365.")
                    .WithDisplayName("Long Date Format")
                    .ModelProperty("longdateformatcode", typeof(long)));

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

                this.CurrentImportSequenceNumber = group.Add(new VocabularyKey("CurrentImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Import sequence to use.")
                    .WithDisplayName("Current Import Sequence Number")
                    .ModelProperty("currentimportsequencenumber", typeof(long)));

                this.ParsedTablePrefix = group.Add(new VocabularyKey("ParsedTablePrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix used for parsed tables.")
                    .WithDisplayName("Parsed Table Prefix")
                    .ModelProperty("parsedtableprefix", typeof(string)));

                this.V3CalloutConfigHash = group.Add(new VocabularyKey("V3CalloutConfigHash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Hash of the V3 callout configuration file.")
                    .WithDisplayName("V3 Callout Hash")
                    .ModelProperty("v3calloutconfighash", typeof(string)));

                this.IsFiscalPeriodMonthBased = group.Add(new VocabularyKey("IsFiscalPeriodMonthBased", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the fiscal period is displayed as the month number.")
                    .WithDisplayName("Is Fiscal Period Monthly")
                    .ModelProperty("isfiscalperiodmonthbased", typeof(bool)));

                this.LocaleId = group.Add(new VocabularyKey("LocaleId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the locale of the organization.")
                    .WithDisplayName("Locale")
                    .ModelProperty("localeid", typeof(long)));

                this.ParsedTableColumnPrefix = group.Add(new VocabularyKey("ParsedTableColumnPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(20))
                    .WithDescription(@"Prefix used for parsed table columns.")
                    .WithDisplayName("Parsed Table Column Prefix")
                    .ModelProperty("parsedtablecolumnprefix", typeof(string)));

                this.SupportUserId = group.Add(new VocabularyKey("SupportUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the support user for the organization.")
                    .WithDisplayName("Support User")
                    .ModelProperty("supportuserid", typeof(Guid)));

                this.AMDesignator = group.Add(new VocabularyKey("AMDesignator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                    .WithDescription(@"AM designator to use throughout Microsoft Dynamics CRM.")
                    .WithDisplayName("AM Designator")
                    .ModelProperty("amdesignator", typeof(string)));

                this.CurrencyDisplayOption = group.Add(new VocabularyKey("CurrencyDisplayOption", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether to display money fields with currency code or currency symbol.")
                    .WithDisplayName("Display Currencies Using")
                    .ModelProperty("currencydisplayoption", typeof(string)));

                this.MinAddressBookSyncInterval = group.Add(new VocabularyKey("MinAddressBookSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Normal polling frequency used for address book synchronization in Microsoft Office Outlook.")
                    .WithDisplayName("Min Address Synchronization Frequency")
                    .ModelProperty("minaddressbooksyncinterval", typeof(long)));

                this.IsDuplicateDetectionEnabledForOnlineCreateUpdate = group.Add(new VocabularyKey("IsDuplicateDetectionEnabledForOnlineCreateUpdate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether duplicate detection during online create or update is enabled.")
                    .WithDisplayName("Is Duplicate Detection Enabled for Online Create/Update")
                    .ModelProperty("isduplicatedetectionenabledforonlinecreateupdate", typeof(bool)));

                this.FeatureSet = group.Add(new VocabularyKey("FeatureSet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Features to be enabled as an XML BLOB.")
                    .WithDisplayName("Feature Set")
                    .ModelProperty("featureset", typeof(string)));

                this.BlockedAttachments = group.Add(new VocabularyKey("BlockedAttachments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Prevent upload or download of certain attachment types that are considered dangerous.")
                    .WithDisplayName("Block Attachments")
                    .ModelProperty("blockedattachments", typeof(string)));

                this.IsDuplicateDetectionEnabledForOfflineSync = group.Add(new VocabularyKey("IsDuplicateDetectionEnabledForOfflineSync", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether duplicate detection of records during offline synchronization is enabled.")
                    .WithDisplayName("Is Duplicate Detection Enabled For Offline Synchronization")
                    .ModelProperty("isduplicatedetectionenabledforofflinesync", typeof(bool)));

                this.AllowOfflineScheduledSyncs = group.Add(new VocabularyKey("AllowOfflineScheduledSyncs", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.")
                    .WithDisplayName("Allow Offline Scheduled Synchronization")
                    .ModelProperty("allowofflinescheduledsyncs", typeof(bool)));

                this.AllowUnresolvedPartiesOnEmailSend = group.Add(new VocabularyKey("AllowUnresolvedPartiesOnEmailSend", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).")
                    .WithDisplayName("Allow Unresolved Address Email Send")
                    .ModelProperty("allowunresolvedpartiesonemailsend", typeof(bool)));

                this.TimeSeparator = group.Add(new VocabularyKey("TimeSeparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                    .WithDescription(@"Text for how the time separator is displayed throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Time Separator")
                    .ModelProperty("timeseparator", typeof(string)));

                this.CurrentParsedTableNumber = group.Add(new VocabularyKey("CurrentParsedTableNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"First parsed table number to use.")
                    .WithDisplayName("Current Parsed Table Number")
                    .ModelProperty("currentparsedtablenumber", typeof(long)));

                this.MinOfflineSyncInterval = group.Add(new VocabularyKey("MinOfflineSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.")
                    .WithDisplayName("Min Offline Synchronization Frequency")
                    .ModelProperty("minofflinesyncinterval", typeof(long)));

                this.AllowWebExcelExport = group.Add(new VocabularyKey("AllowWebExcelExport", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.")
                    .WithDisplayName("Allow Export to Excel")
                    .ModelProperty("allowwebexcelexport", typeof(bool)));

                this.ReferenceSiteMapXml = group.Add(new VocabularyKey("ReferenceSiteMapXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML string that defines the navigation structure for the application. This is the site map from the previously upgraded build and is used in a 3-way merge during upgrade.")
                    .WithDisplayName("Reference SiteMap XML")
                    .ModelProperty("referencesitemapxml", typeof(string)));

                this.IsDuplicateDetectionEnabledForImport = group.Add(new VocabularyKey("IsDuplicateDetectionEnabledForImport", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether duplicate detection of records during import is enabled.")
                    .WithDisplayName("Is Duplicate Detection Enabled For Import")
                    .ModelProperty("isduplicatedetectionenabledforimport", typeof(bool)));

                this.CalendarType = group.Add(new VocabularyKey("CalendarType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Calendar type for the system. Set to Gregorian US by default.")
                    .WithDisplayName("Calendar Type")
                    .ModelProperty("calendartype", typeof(long)));

                this.SQMEnabled = group.Add(new VocabularyKey("SQMEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Setting for SQM data collection, 0 no, 1 yes enabled")
                    .WithDisplayName("Is SQM Enabled")
                    .ModelProperty("sqmenabled", typeof(bool)));

                this.NegativeCurrencyFormatCode = group.Add(new VocabularyKey("NegativeCurrencyFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics 365.")
                    .WithDisplayName("Negative Currency Format")
                    .ModelProperty("negativecurrencyformatcode", typeof(long)));

                this.AllowAddressBookSyncs = group.Add(new VocabularyKey("AllowAddressBookSyncs", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.")
                    .WithDisplayName("Allow Address Book Synchronization")
                    .ModelProperty("allowaddressbooksyncs", typeof(bool)));

                this.ISVIntegrationCode = group.Add(new VocabularyKey("ISVIntegrationCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.")
                    .WithDisplayName("ISV Integration Mode")
                    .ModelProperty("isvintegrationcode", typeof(string)));

                this.DecimalSymbol = group.Add(new VocabularyKey("DecimalSymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                    .WithDescription(@"Symbol used for decimal in Microsoft Dynamics 365.")
                    .WithDisplayName("Decimal Symbol")
                    .ModelProperty("decimalsymbol", typeof(string)));

                this.MaxUploadFileSize = group.Add(new VocabularyKey("MaxUploadFileSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum allowed size of an attachment.")
                    .WithDisplayName("Max Upload File Size")
                    .ModelProperty("maxuploadfilesize", typeof(long)));

                this.IsAppMode = group.Add(new VocabularyKey("IsAppMode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.")
                    .WithDisplayName("Is Application Mode Enabled")
                    .ModelProperty("isappmode", typeof(bool)));

                this.EnablePricingOnCreate = group.Add(new VocabularyKey("EnablePricingOnCreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable pricing calculations on a Create call.")
                    .WithDisplayName("Enable Pricing On Create")
                    .ModelProperty("enablepricingoncreate", typeof(bool)));

                this.IsSOPIntegrationEnabled = group.Add(new VocabularyKey("IsSOPIntegrationEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable sales order processing integration.")
                    .WithDisplayName("Is Sales Order Integration Enabled")
                    .ModelProperty("issopintegrationenabled", typeof(bool)));

                this.PMDesignator = group.Add(new VocabularyKey("PMDesignator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                    .WithDescription(@"PM designator to use throughout Microsoft Dynamics 365.")
                    .WithDisplayName("PM Designator")
                    .ModelProperty("pmdesignator", typeof(string)));

                this.CurrencyDecimalPrecision = group.Add(new VocabularyKey("CurrencyDecimalPrecision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of decimal places that can be used for currency.")
                    .WithDisplayName("Currency Decimal Precision")
                    .ModelProperty("currencydecimalprecision", typeof(long)));

                this.MaxAppointmentDurationDays = group.Add(new VocabularyKey("MaxAppointmentDurationDays", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of days an appointment can last.")
                    .WithDisplayName("Max Appointment Duration")
                    .ModelProperty("maxappointmentdurationdays", typeof(long)));

                this.EmailSendPollingPeriod = group.Add(new VocabularyKey("EmailSendPollingPeriod", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Normal polling frequency used for sending email in Microsoft Office Outlook.")
                    .WithDisplayName("Email Send Polling Frequency")
                    .ModelProperty("emailsendpollingperiod", typeof(long)));

                this.RenderSecureIFrameForEmail = group.Add(new VocabularyKey("RenderSecureIFrameForEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.")
                    .WithDisplayName("Render Secure Frame For Email")
                    .ModelProperty("rendersecureiframeforemail", typeof(bool)));

                this.NumberSeparator = group.Add(new VocabularyKey("NumberSeparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                    .WithDescription(@"Symbol used for number separation in Microsoft Dynamics 365.")
                    .WithDisplayName("Number Separator")
                    .ModelProperty("numberseparator", typeof(string)));

                this.PrivReportingGroupId = group.Add(new VocabularyKey("PrivReportingGroupId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Privilege Reporting Group")
                    .ModelProperty("privreportinggroupid", typeof(Guid)));

                this.BaseCurrencyId = group.Add(new VocabularyKey("BaseCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the base currency of the organization.")
                    .WithDisplayName("Currency")
                    .ModelProperty("basecurrencyid", typeof(string)));

                this.MaxRecordsForExportToExcel = group.Add(new VocabularyKey("MaxRecordsForExportToExcel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from the grid.")
                    .WithDisplayName("Max Records For Excel Export")
                    .ModelProperty("maxrecordsforexporttoexcel", typeof(long)));

                this.PrivReportingGroupName = group.Add(new VocabularyKey("PrivReportingGroupName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Privilege Reporting Group Name")
                    .ModelProperty("privreportinggroupname", typeof(string)));

                this.YearStartWeekCode = group.Add(new VocabularyKey("YearStartWeekCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies how the first week of the year is specified in Microsoft Dynamics 365.")
                    .WithDisplayName("Year Start Week Code")
                    .ModelProperty("yearstartweekcode", typeof(long)));

                this.IsPresenceEnabled = group.Add(new VocabularyKey("IsPresenceEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information on whether IM presence is enabled.")
                    .WithDisplayName("Presence Enabled")
                    .ModelProperty("ispresenceenabled", typeof(bool)));

                this.IsDuplicateDetectionEnabled = group.Add(new VocabularyKey("IsDuplicateDetectionEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether duplicate detection of records is enabled.")
                    .WithDisplayName("Is Duplicate Detection Enabled")
                    .ModelProperty("isduplicatedetectionenabled", typeof(bool)));

                this.BaseCurrencyIdName = group.Add(new VocabularyKey("BaseCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BaseCurrencyIdName")
                    .ModelProperty("basecurrencyidname", typeof(string)));

                this.IsPresenceEnabledName = group.Add(new VocabularyKey("IsPresenceEnabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("IsPresenceEnabledName")
                    .ModelProperty("ispresenceenabledname", typeof(string)));

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

                this.ExpireSubscriptionsInDays = group.Add(new VocabularyKey("ExpireSubscriptionsInDays", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of days before deleting inactive subscriptions.")
                    .WithDisplayName("Days to Expire Subscriptions")
                    .ModelProperty("expiresubscriptionsindays", typeof(long)));

                this.IsAuditEnabled = group.Add(new VocabularyKey("IsAuditEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable auditing of changes.")
                    .WithDisplayName("Is Auditing Enabled")
                    .ModelProperty("isauditenabled", typeof(bool)));

                this.BaseCurrencyPrecision = group.Add(new VocabularyKey("BaseCurrencyPrecision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of decimal places that can be used for the base currency.")
                    .WithDisplayName("Base Currency Precision")
                    .ModelProperty("basecurrencyprecision", typeof(long)));

                this.BaseCurrencySymbol = group.Add(new VocabularyKey("BaseCurrencySymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(5))
                    .WithDescription(@"Symbol used for the base currency.")
                    .WithDisplayName("Base Currency Symbol")
                    .ModelProperty("basecurrencysymbol", typeof(string)));

                this.BaseISOCurrencyCode = group.Add(new VocabularyKey("BaseISOCurrencyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(5))
                    .WithDescription(@"")
                    .WithDisplayName("Base ISO Currency Code")
                    .ModelProperty("baseisocurrencycode", typeof(string)));

                this.TraceLogMaximumAgeInDays = group.Add(new VocabularyKey("TraceLogMaximumAgeInDays", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Tracelog record maximum age in days")
                    .WithDisplayName("Tracelog record maximum age in days")
                    .ModelProperty("tracelogmaximumageindays", typeof(long)));

                this.NextCustomObjectTypeCode = group.Add(new VocabularyKey("NextCustomObjectTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Next entity type code to use for custom entities.")
                    .WithDisplayName("Next Entity Type Code")
                    .ModelProperty("nextcustomobjecttypecode", typeof(long)));

                this.MaxRecordsForLookupFilters = group.Add(new VocabularyKey("MaxRecordsForLookupFilters", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of lookup and picklist records that can be selected by user for filtering.")
                    .WithDisplayName("Max Records Filter Selection")
                    .ModelProperty("maxrecordsforlookupfilters", typeof(long)));

                this.AllowEntityOnlyAudit = group.Add(new VocabularyKey("AllowEntityOnlyAudit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether auditing of changes to entity is allowed when no attributes have changed.")
                    .WithDisplayName("Allow Entity Level Auditing")
                    .ModelProperty("allowentityonlyaudit", typeof(bool)));

                this.DefaultRecurrenceEndRangeType = group.Add(new VocabularyKey("DefaultRecurrenceEndRangeType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of default recurrence end range date.")
                    .WithDisplayName("Default Recurrence End Range Type")
                    .ModelProperty("defaultrecurrenceendrangetype", typeof(string)));

                this.DefaultRecurrenceEndRangeTypeName = group.Add(new VocabularyKey("DefaultRecurrenceEndRangeTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("DefaultRecurrenceEndRangeTypeName")
                    .ModelProperty("defaultrecurrenceendrangetypename", typeof(string)));

                this.FutureExpansionWindow = group.Add(new VocabularyKey("FutureExpansionWindow", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the maximum number of months in future for which the recurring activities can be created.")
                    .WithDisplayName("Future Expansion Window")
                    .ModelProperty("futureexpansionwindow", typeof(long)));

                this.PastExpansionWindow = group.Add(new VocabularyKey("PastExpansionWindow", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the maximum number of months in past for which the recurring activities can be created.")
                    .WithDisplayName("Past Expansion Window")
                    .ModelProperty("pastexpansionwindow", typeof(long)));

                this.RecurrenceExpansionSynchCreateMax = group.Add(new VocabularyKey("RecurrenceExpansionSynchCreateMax", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.")
                    .WithDisplayName("Recurrence Expansion Synchronization Create Maximum")
                    .ModelProperty("recurrenceexpansionsynchcreatemax", typeof(long)));

                this.RecurrenceDefaultNumberOfOccurrences = group.Add(new VocabularyKey("RecurrenceDefaultNumberOfOccurrences", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the default value for number of occurrences field in the recurrence dialog.")
                    .WithDisplayName("Recurrence Default Number of Occurrences")
                    .ModelProperty("recurrencedefaultnumberofoccurrences", typeof(long)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the organization.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the organization.")
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

                this.GetStartedPaneContentEnabled = group.Add(new VocabularyKey("GetStartedPaneContentEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Get Started content is enabled for this organization.")
                    .WithDisplayName("Is Get Started Pane Content Enabled")
                    .ModelProperty("getstartedpanecontentenabled", typeof(bool)));

                this.UseReadForm = group.Add(new VocabularyKey("UseReadForm", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the read-optimized form should be enabled for this organization.")
                    .WithDisplayName("Use Read-Optimized Form")
                    .ModelProperty("usereadform", typeof(bool)));

                this.InitialVersion = group.Add(new VocabularyKey("InitialVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(20))
                    .WithDescription(@"Initial version of the organization.")
                    .WithDisplayName("Initial Version")
                    .ModelProperty("initialversion", typeof(string)));

                this.SampleDataImportId = group.Add(new VocabularyKey("SampleDataImportId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the sample data import job.")
                    .WithDisplayName("Sample Data Import")
                    .ModelProperty("sampledataimportid", typeof(Guid)));

                this.ReportScriptErrors = group.Add(new VocabularyKey("ReportScriptErrors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Picklist for selecting the organization preference for reporting scripting errors.")
                    .WithDisplayName("Report Script Errors")
                    .ModelProperty("reportscripterrors", typeof(string)));

                this.ReportScriptErrorsName = group.Add(new VocabularyKey("ReportScriptErrorsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ReportScriptErrorsName")
                    .ModelProperty("reportscripterrorsname", typeof(string)));

                this.RequireApprovalForUserEmail = group.Add(new VocabularyKey("RequireApprovalForUserEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Send As Other User privilege is enabled.")
                    .WithDisplayName("Is Approval For User Email Required")
                    .ModelProperty("requireapprovalforuseremail", typeof(bool)));

                this.RequireApprovalForQueueEmail = group.Add(new VocabularyKey("RequireApprovalForQueueEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Send As Other User privilege is enabled.")
                    .WithDisplayName("Is Approval For Queue Email Required")
                    .ModelProperty("requireapprovalforqueueemail", typeof(bool)));

                this.GoalRollupExpiryTime = group.Add(new VocabularyKey("GoalRollupExpiryTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of days after the goal's end date after which the rollup of the goal stops automatically.")
                    .WithDisplayName("Rollup Expiration Time for Goal")
                    .ModelProperty("goalrollupexpirytime", typeof(long)));

                this.GoalRollupFrequency = group.Add(new VocabularyKey("GoalRollupFrequency", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of hours between automatic rollup jobs .")
                    .WithDisplayName("Automatic Rollup Frequency for Goal")
                    .ModelProperty("goalrollupfrequency", typeof(long)));

                this.AutoApplyDefaultonCaseCreate = group.Add(new VocabularyKey("AutoApplyDefaultonCaseCreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to auto apply the default customer entitlement on case creation.")
                    .WithDisplayName("Auto Apply Default Entitlement on Case Create")
                    .ModelProperty("autoapplydefaultoncasecreate", typeof(bool)));

                this.AutoApplyDefaultonCaseCreateName = group.Add(new VocabularyKey("AutoApplyDefaultonCaseCreateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AutoApplyDefaultonCaseCreateName")
                    .ModelProperty("autoapplydefaultoncasecreatename", typeof(string)));

                this.AutoApplyDefaultonCaseUpdate = group.Add(new VocabularyKey("AutoApplyDefaultonCaseUpdate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to auto apply the default customer entitlement on case update.")
                    .WithDisplayName("Auto Apply Default Entitlement on Case Update")
                    .ModelProperty("autoapplydefaultoncaseupdate", typeof(bool)));

                this.AutoApplyDefaultonCaseUpdateName = group.Add(new VocabularyKey("AutoApplyDefaultonCaseUpdateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AutoApplyDefaultonCaseUpdateName")
                    .ModelProperty("autoapplydefaultoncaseupdatename", typeof(string)));

                this.FiscalYearFormatPrefix = group.Add(new VocabularyKey("FiscalYearFormatPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Prefix for the display of the fiscal year.")
                    .WithDisplayName("Prefix for Fiscal Year")
                    .ModelProperty("fiscalyearformatprefix", typeof(string)));

                this.FiscalYearFormatPrefixName = group.Add(new VocabularyKey("FiscalYearFormatPrefixName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FiscalYearFormatPrefixName")
                    .ModelProperty("fiscalyearformatprefixname", typeof(string)));

                this.FiscalYearFormatSuffix = group.Add(new VocabularyKey("FiscalYearFormatSuffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Suffix for the display of the fiscal year.")
                    .WithDisplayName("Suffix for Fiscal Year")
                    .ModelProperty("fiscalyearformatsuffix", typeof(string)));

                this.FiscalYearFormatSuffixName = group.Add(new VocabularyKey("FiscalYearFormatSuffixName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FiscalYearFormatSuffixName")
                    .ModelProperty("fiscalyearformatsuffixname", typeof(string)));

                this.FiscalYearFormatYear = group.Add(new VocabularyKey("FiscalYearFormatYear", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Format for the year.")
                    .WithDisplayName("Fiscal Year Format Year")
                    .ModelProperty("fiscalyearformatyear", typeof(string)));

                this.FiscalYearFormatYearName = group.Add(new VocabularyKey("FiscalYearFormatYearName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FiscalYearFormatYearName")
                    .ModelProperty("fiscalyearformatyearname", typeof(string)));

                this.DiscountCalculationMethod = group.Add(new VocabularyKey("DiscountCalculationMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Discount calculation method for the QOOI product.")
                    .WithDisplayName("Discount calculation method")
                    .ModelProperty("discountcalculationmethod", typeof(string)));

                this.FiscalPeriodFormatPeriod = group.Add(new VocabularyKey("FiscalPeriodFormatPeriod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Format in which the fiscal period will be displayed.")
                    .WithDisplayName("Format for Fiscal Period")
                    .ModelProperty("fiscalperiodformatperiod", typeof(string)));

                this.FiscalPeriodFormatPeriodName = group.Add(new VocabularyKey("FiscalPeriodFormatPeriodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FiscalPeriodFormatPeriodName")
                    .ModelProperty("fiscalperiodformatperiodname", typeof(string)));

                this.AllowClientMessageBarAd = group.Add(new VocabularyKey("AllowClientMessageBarAd", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Outlook Client message bar advertisement is allowed.")
                    .WithDisplayName("Allow Outlook Client Message Bar Advertisement")
                    .ModelProperty("allowclientmessagebarad", typeof(bool)));

                this.AllowUserFormModePreference = group.Add(new VocabularyKey("AllowUserFormModePreference", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether individuals can select their form mode preference in their personal options.")
                    .WithDisplayName("Allow User Form Mode Preference")
                    .ModelProperty("allowuserformmodepreference", typeof(bool)));

                this.HashFilterKeywords = group.Add(new VocabularyKey("HashFilterKeywords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Filter Subject Keywords")
                    .WithDisplayName("Hash Filter Keywords")
                    .ModelProperty("hashfilterkeywords", typeof(string)));

                this.HashMaxCount = group.Add(new VocabularyKey("HashMaxCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of subject keywords or recipients used for correlation")
                    .WithDisplayName("Hash Max Count")
                    .ModelProperty("hashmaxcount", typeof(long)));

                this.HashDeltaSubjectCount = group.Add(new VocabularyKey("HashDeltaSubjectCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum difference allowed between subject keywords count of the email messaged to be correlated")
                    .WithDisplayName("Hash Delta Subject Count")
                    .ModelProperty("hashdeltasubjectcount", typeof(long)));

                this.HashMinAddressCount = group.Add(new VocabularyKey("HashMinAddressCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Minimum number of recipients required to match for email messaged to be correlated")
                    .WithDisplayName("Hash Min Address Count")
                    .ModelProperty("hashminaddresscount", typeof(long)));

                this.EnableSmartMatching = group.Add(new VocabularyKey("EnableSmartMatching", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Use Smart Matching.")
                    .WithDisplayName("Enable Smart Matching")
                    .ModelProperty("enablesmartmatching", typeof(bool)));

                this.PinpointLanguageCode = group.Add(new VocabularyKey("PinpointLanguageCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("PinpointLanguageCode")
                    .ModelProperty("pinpointlanguagecode", typeof(long)));

                this.OrgDbOrgSettings = group.Add(new VocabularyKey("OrgDbOrgSettings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Organization settings stored in Organization Database.")
                    .WithDisplayName("Organization Database Organization Settings")
                    .ModelProperty("orgdborgsettings", typeof(string)));

                this.IsUserAccessAuditEnabled = group.Add(new VocabularyKey("IsUserAccessAuditEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable auditing of user access.")
                    .WithDisplayName("Is User Access Auditing Enabled")
                    .ModelProperty("isuseraccessauditenabled", typeof(bool)));

                this.UserAccessAuditingInterval = group.Add(new VocabularyKey("UserAccessAuditingInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The interval at which user access is checked for auditing.")
                    .WithDisplayName("User Authentication Auditing Interval")
                    .ModelProperty("useraccessauditinginterval", typeof(long)));

                this.QuickFindRecordLimitEnabled = group.Add(new VocabularyKey("QuickFindRecordLimitEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find queries but prevents overly broad searches).")
                    .WithDisplayName("Quick Find Record Limit Enabled")
                    .ModelProperty("quickfindrecordlimitenabled", typeof(bool)));

                this.EnableBingMapsIntegration = group.Add(new VocabularyKey("EnableBingMapsIntegration", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Integration with Bing Maps")
                    .WithDisplayName("Enable Integration with Bing Maps")
                    .ModelProperty("enablebingmapsintegration", typeof(bool)));

                this.IsDefaultCountryCodeCheckEnabled = group.Add(new VocabularyKey("IsDefaultCountryCodeCheckEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable country code selection.")
                    .WithDisplayName("Enable or disable country code selection")
                    .ModelProperty("isdefaultcountrycodecheckenabled", typeof(bool)));

                this.DefaultCountryCode = group.Add(new VocabularyKey("DefaultCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(30))
                    .WithDescription(@"Text area to enter default country code.")
                    .WithDisplayName("Default Country Code")
                    .ModelProperty("defaultcountrycode", typeof(string)));

                this.UseSkypeProtocol = group.Add(new VocabularyKey("UseSkypeProtocol", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates default protocol selected for organization.")
                    .WithDisplayName("User Skype Protocol")
                    .ModelProperty("useskypeprotocol", typeof(bool)));

                this.IncomingEmailExchangeEmailRetrievalBatchSize = group.Add(new VocabularyKey("IncomingEmailExchangeEmailRetrievalBatchSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Setting for the Async Service Mailbox Queue. Defines the retrieval batch size of exchange server.")
                    .WithDisplayName("Exchange Email Retrieval Batch Size")
                    .ModelProperty("incomingemailexchangeemailretrievalbatchsize", typeof(long)));

                this.EmailCorrelationEnabled = group.Add(new VocabularyKey("EmailCorrelationEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag to turn email correlation on or off.")
                    .WithDisplayName("Use Email Correlation")
                    .ModelProperty("emailcorrelationenabled", typeof(bool)));

                this.MetadataSyncTimestamp = group.Add(new VocabularyKey("MetadataSyncTimestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Contains the maximum version number for attributes used by metadata synchronization that have changed.")
                    .WithDisplayName("Metadata sync version")
                    .ModelProperty("metadatasynctimestamp", typeof(int)));

                this.MetadataSyncLastTimeOfNeverExpiredDeletedObjects = group.Add(new VocabularyKey("MetadataSyncLastTimeOfNeverExpiredDeletedObjects", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"What is the last date/time where there are metadata tracking deleted objects that have never been outside of the expiration period.")
                    .WithDisplayName("The last date/time for never expired metadata tracking deleted objects")
                    .ModelProperty("metadatasynclasttimeofneverexpireddeletedobjects", typeof(DateTime)));

                this.YammerOAuthAccessTokenExpired = group.Add(new VocabularyKey("YammerOAuthAccessTokenExpired", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Denotes whether the OAuth access token for Yammer network has expired")
                    .WithDisplayName("Yammer OAuth Access Token Expired")
                    .ModelProperty("yammeroauthaccesstokenexpired", typeof(bool)));

                this.DefaultEmailSettings = group.Add(new VocabularyKey("DefaultEmailSettings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML string containing the default email settings that are applied when a user or queue is created.")
                    .WithDisplayName("Default Email Settings")
                    .ModelProperty("defaultemailsettings", typeof(string)));

                this.YammerGroupId = group.Add(new VocabularyKey("YammerGroupId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Denotes the Yammer group ID")
                    .WithDisplayName("Yammer Group Id")
                    .ModelProperty("yammergroupid", typeof(long)));

                this.YammerNetworkPermalink = group.Add(new VocabularyKey("YammerNetworkPermalink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Denotes the Yammer network permalink")
                    .WithDisplayName("Yammer Network Permalink")
                    .ModelProperty("yammernetworkpermalink", typeof(string)));

                this.YammerPostMethod = group.Add(new VocabularyKey("YammerPostMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Internal Use Only")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("yammerpostmethod", typeof(string)));

                this.DefaultEmailServerProfileIdName = group.Add(new VocabularyKey("DefaultEmailServerProfileIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the email server profile to be used as default profile for the mailboxes.")
                    .WithDisplayName("DefaultEmailServerProfileIdName")
                    .ModelProperty("defaultemailserverprofileidname", typeof(string)));

                this.EmailConnectionChannel = group.Add(new VocabularyKey("EmailConnectionChannel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select if you want to use the Email Router or server-side synchronization for email processing.")
                    .WithDisplayName("Email Connection Channel")
                    .ModelProperty("emailconnectionchannel", typeof(string)));

                this.DefaultEmailServerProfileId = group.Add(new VocabularyKey("DefaultEmailServerProfileId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the default email server profile.")
                    .WithDisplayName("Email Server Profile")
                    .ModelProperty("defaultemailserverprofileid", typeof(string)));

                this.IsAutoSaveEnabled = group.Add(new VocabularyKey("IsAutoSaveEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information on whether auto save is enabled.")
                    .WithDisplayName("Auto Save Enabled")
                    .ModelProperty("isautosaveenabled", typeof(bool)));

                this.BingMapsApiKey = group.Add(new VocabularyKey("BingMapsApiKey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Api Key to be used in requests to Bing Maps services.")
                    .WithDisplayName("Bing Maps API Key")
                    .ModelProperty("bingmapsapikey", typeof(string)));

                this.GenerateAlertsForErrors = group.Add(new VocabularyKey("GenerateAlertsForErrors", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether alerts will be generated for errors.")
                    .WithDisplayName("Generate Alerts For Errors")
                    .ModelProperty("generatealertsforerrors", typeof(bool)));

                this.GenerateAlertsForInformation = group.Add(new VocabularyKey("GenerateAlertsForInformation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether alerts will be generated for information.")
                    .WithDisplayName("Generate Alerts For Information")
                    .ModelProperty("generatealertsforinformation", typeof(bool)));

                this.GenerateAlertsForWarnings = group.Add(new VocabularyKey("GenerateAlertsForWarnings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether alerts will be generated for warnings.")
                    .WithDisplayName("Generate Alerts For Warnings")
                    .ModelProperty("generatealertsforwarnings", typeof(bool)));

                this.NotifyMailboxOwnerOfEmailServerLevelAlerts = group.Add(new VocabularyKey("NotifyMailboxOwnerOfEmailServerLevelAlerts", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether mailbox owners will be notified of email server profile level alerts.")
                    .WithDisplayName("Notify Mailbox Owner Of Email Server Level Alerts")
                    .ModelProperty("notifymailboxownerofemailserverlevelalerts", typeof(bool)));

                this.MaximumActiveBusinessProcessFlowsAllowedPerEntity = group.Add(new VocabularyKey("MaximumActiveBusinessProcessFlowsAllowedPerEntity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of active business process flows allowed per entity")
                    .WithDisplayName("Maximum active business process flows per entity")
                    .ModelProperty("maximumactivebusinessprocessflowsallowedperentity", typeof(long)));

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

                this.AllowUsersSeeAppdownloadMessage = group.Add(new VocabularyKey("AllowUsersSeeAppdownloadMessage", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the showing tablet application notification bars in a browser is allowed.")
                    .WithDisplayName("Allow the showing tablet application notification bars in a browser.")
                    .ModelProperty("allowusersseeappdownloadmessage", typeof(bool)));

                this.SignupOutlookDownloadFWLink = group.Add(new VocabularyKey("SignupOutlookDownloadFWLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"CRM for Outlook Download URL")
                    .WithDisplayName("CRMForOutlookDownloadURL")
                    .ModelProperty("signupoutlookdownloadfwlink", typeof(string)));

                this.CascadeStatusUpdate = group.Add(new VocabularyKey("CascadeStatusUpdate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag to cascade Update on incident.")
                    .WithDisplayName("Cascade Status Update")
                    .ModelProperty("cascadestatusupdate", typeof(bool)));

                this.RestrictStatusUpdate = group.Add(new VocabularyKey("RestrictStatusUpdate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag to restrict Update on incident.")
                    .WithDisplayName("Restrict Status Update")
                    .ModelProperty("restrictstatusupdate", typeof(bool)));

                this.SuppressSLA = group.Add(new VocabularyKey("SuppressSLA", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether SLA is suppressed.")
                    .WithDisplayName("Is SLA suppressed")
                    .ModelProperty("suppresssla", typeof(bool)));

                this.SocialInsightsTermsAccepted = group.Add(new VocabularyKey("SocialInsightsTermsAccepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag for whether the organization has accepted the Social Insights terms of use.")
                    .WithDisplayName("Social Insights Terms of Use")
                    .ModelProperty("socialinsightstermsaccepted", typeof(bool)));

                this.SocialInsightsInstance = group.Add(new VocabularyKey("SocialInsightsInstance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2048))
                    .WithDescription(@"Identifier for the Social Insights instance for the organization.")
                    .WithDisplayName("Social Insights instance identifier")
                    .ModelProperty("socialinsightsinstance", typeof(string)));

                this.DisableSocialCare = group.Add(new VocabularyKey("DisableSocialCare", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Social Care is disabled.")
                    .WithDisplayName("Is Social Care disabled")
                    .ModelProperty("disablesocialcare", typeof(bool)));

                this.MaxProductsInBundle = group.Add(new VocabularyKey("MaxProductsInBundle", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Restrict the maximum no of items in a bundle")
                    .WithDisplayName("Bundle Item Limit")
                    .ModelProperty("maxproductsinbundle", typeof(long)));

                this.UseInbuiltRuleForDefaultPricelistSelection = group.Add(new VocabularyKey("UseInbuiltRuleForDefaultPricelistSelection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag indicates whether to Use Inbuilt Rule For DefaultPricelist.")
                    .WithDisplayName("Use Inbuilt Rule For Default Pricelist Selection")
                    .ModelProperty("useinbuiltrulefordefaultpricelistselection", typeof(bool)));

                this.OOBPriceCalculationEnabled = group.Add(new VocabularyKey("OOBPriceCalculationEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable OOB pricing calculation logic for Opportunity, Quote, Order and Invoice entities.")
                    .WithDisplayName("Enable OOB Price calculation")
                    .ModelProperty("oobpricecalculationenabled", typeof(bool)));

                this.IsHierarchicalSecurityModelEnabled = group.Add(new VocabularyKey("IsHierarchicalSecurityModelEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Hierarchical Security Model")
                    .WithDisplayName("Enable Hierarchical Security Model")
                    .ModelProperty("ishierarchicalsecuritymodelenabled", typeof(bool)));

                this.MaximumDynamicPropertiesAllowed = group.Add(new VocabularyKey("MaximumDynamicPropertiesAllowed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Restrict the maximum number of product properties for a product family/bundle")
                    .WithDisplayName("Product Properties Item Limit")
                    .ModelProperty("maximumdynamicpropertiesallowed", typeof(long)));

                this.UsePositionHierarchy = group.Add(new VocabularyKey("UsePositionHierarchy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Use position hierarchy")
                    .WithDisplayName("Use position hierarchy")
                    .ModelProperty("usepositionhierarchy", typeof(bool)));

                this.MaxDepthForHierarchicalSecurityModel = group.Add(new VocabularyKey("MaxDepthForHierarchicalSecurityModel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum depth for hierarchy security propagation.")
                    .WithDisplayName("Maximum depth for hierarchy security propagation.")
                    .ModelProperty("maxdepthforhierarchicalsecuritymodel", typeof(long)));

                this.SlaPauseStates = group.Add(new VocabularyKey("SlaPauseStates", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Contains the on hold case status values.")
                    .WithDisplayName("SLA pause states")
                    .ModelProperty("slapausestates", typeof(string)));

                this.SocialInsightsEnabled = group.Add(new VocabularyKey("SocialInsightsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag for whether the organization is using Social Insights.")
                    .WithDisplayName("Social Insights Enabled")
                    .ModelProperty("socialinsightsenabled", typeof(bool)));

                this.IsAppointmentAttachmentSyncEnabled = group.Add(new VocabularyKey("IsAppointmentAttachmentSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable attachments sync for outlook and exchange.")
                    .WithDisplayName("Is Attachment Sync Enabled")
                    .ModelProperty("isappointmentattachmentsyncenabled", typeof(bool)));

                this.IsAssignedTasksSyncEnabled = group.Add(new VocabularyKey("IsAssignedTasksSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable assigned tasks sync for outlook and exchange.")
                    .WithDisplayName("Is Assigned Tasks Sync Enabled")
                    .ModelProperty("isassignedtaskssyncenabled", typeof(bool)));

                this.IsContactMailingAddressSyncEnabled = group.Add(new VocabularyKey("IsContactMailingAddressSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable mailing address sync for outlook and exchange.")
                    .WithDisplayName("Is Mailing Address Sync Enabled")
                    .ModelProperty("iscontactmailingaddresssyncenabled", typeof(bool)));

                this.MaxSupportedInternetExplorerVersion = group.Add(new VocabularyKey("MaxSupportedInternetExplorerVersion", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The maximum version of IE to run browser emulation for in Outlook client")
                    .WithDisplayName("Max supported IE version")
                    .ModelProperty("maxsupportedinternetexplorerversion", typeof(long)));

                this.GlobalHelpUrl = group.Add(new VocabularyKey("GlobalHelpUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"URL for the web page global help.")
                    .WithDisplayName("Global Help URL.")
                    .ModelProperty("globalhelpurl", typeof(string)));

                this.GlobalHelpUrlEnabled = group.Add(new VocabularyKey("GlobalHelpUrlEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the customizable global help is enabled.")
                    .WithDisplayName("Is Customizable Global Help enabled")
                    .ModelProperty("globalhelpurlenabled", typeof(bool)));

                this.GlobalAppendUrlParametersEnabled = group.Add(new VocabularyKey("GlobalAppendUrlParametersEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the append URL parameters is enabled.")
                    .WithDisplayName("Is AppendUrl Parameters enabled")
                    .ModelProperty("globalappendurlparametersenabled", typeof(bool)));

                this.KMSettings = group.Add(new VocabularyKey("KMSettings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML string containing the Knowledge Management settings that are applied in Knowledge Management Wizard.")
                    .WithDisplayName("Knowledge Management Settings")
                    .ModelProperty("kmsettings", typeof(string)));

                this.CreateProductsWithoutParentInActiveState = group.Add(new VocabularyKey("CreateProductsWithoutParentInActiveState", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Initial state of newly created products to be Active instead of Draft")
                    .WithDisplayName("Enable Active Initial Product State")
                    .ModelProperty("createproductswithoutparentinactivestate", typeof(bool)));

                this.IsMailboxInactiveBackoffEnabled = group.Add(new VocabularyKey("IsMailboxInactiveBackoffEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable mailbox keep alive for Server Side Sync.")
                    .WithDisplayName("Is Mailbox Keep Alive Enabled")
                    .ModelProperty("ismailboxinactivebackoffenabled", typeof(bool)));

                this.IsFullTextSearchEnabled = group.Add(new VocabularyKey("IsFullTextSearchEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether full-text search for Quick Find entities should be enabled for the organization.")
                    .WithDisplayName("Enable Full-text search for Quick Find")
                    .ModelProperty("isfulltextsearchenabled", typeof(bool)));

                this.EnforceReadOnlyPlugins = group.Add(new VocabularyKey("EnforceReadOnlyPlugins", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Organization setting to enforce read only plugins.")
                    .WithDisplayName("Organization setting to enforce read only plugins.")
                    .ModelProperty("enforcereadonlyplugins", typeof(bool)));

                this.SharePointDeploymentType = group.Add(new VocabularyKey("SharePointDeploymentType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates which SharePoint deployment type is configured for Server to Server. (Online or On-Premises)")
                    .WithDisplayName("Choose SharePoint Deployment Type")
                    .ModelProperty("sharepointdeploymenttype", typeof(string)));

                this.OrganizationState = group.Add(new VocabularyKey("OrganizationState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the organization lifecycle state")
                    .WithDisplayName("Organization State")
                    .ModelProperty("organizationstate", typeof(string)));

                this.DefaultThemeData = group.Add(new VocabularyKey("DefaultThemeData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Default theme data for the organization.")
                    .WithDisplayName("Default Theme Data")
                    .ModelProperty("defaultthemedata", typeof(string)));

                this.IsFolderBasedTrackingEnabled = group.Add(new VocabularyKey("IsFolderBasedTrackingEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable folder based tracking for Server Side Sync.")
                    .WithDisplayName("Is Folder Based Tracking Enabled")
                    .ModelProperty("isfolderbasedtrackingenabled", typeof(bool)));

                this.WebResourceHash = group.Add(new VocabularyKey("WebResourceHash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Hash value of web resources.")
                    .WithDisplayName("Web resource hash")
                    .ModelProperty("webresourcehash", typeof(string)));

                this.ExpireChangeTrackingInDays = group.Add(new VocabularyKey("ExpireChangeTrackingInDays", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of days to keep change tracking deleted records")
                    .WithDisplayName("Days to Expire Change Tracking Deleted Records")
                    .ModelProperty("expirechangetrackingindays", typeof(long)));

                this.MaxFolderBasedTrackingMappings = group.Add(new VocabularyKey("MaxFolderBasedTrackingMappings", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of Folder Based Tracking mappings user can add")
                    .WithDisplayName("Max Folder Based Tracking Mappings")
                    .ModelProperty("maxfolderbasedtrackingmappings", typeof(long)));

                this.PrivacyStatementUrl = group.Add(new VocabularyKey("PrivacyStatementUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Privacy Statement URL")
                    .WithDisplayName("Privacy Statement URL")
                    .ModelProperty("privacystatementurl", typeof(string)));

                this.PluginTraceLogSetting = group.Add(new VocabularyKey("PluginTraceLogSetting", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Plug-in Trace Log Setting for the Organization.")
                    .WithDisplayName("Plug-in Trace Log Setting")
                    .ModelProperty("plugintracelogsetting", typeof(string)));

                this.PluginTraceLogSettingName = group.Add(new VocabularyKey("PluginTraceLogSettingName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PluginTraceLogSettingName")
                    .ModelProperty("plugintracelogsettingname", typeof(string)));

                this.IsMailboxForcedUnlockingEnabled = group.Add(new VocabularyKey("IsMailboxForcedUnlockingEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable forced unlocking for Server Side Sync mailboxes.")
                    .WithDisplayName("Is Mailbox Forced Unlocking Enabled")
                    .ModelProperty("ismailboxforcedunlockingenabled", typeof(bool)));

                this.MailboxIntermittentIssueMinRange = group.Add(new VocabularyKey("MailboxIntermittentIssueMinRange", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Lower Threshold For Mailbox Intermittent Issue.")
                    .WithDisplayName("Lower Threshold For Mailbox Intermittent Issue")
                    .ModelProperty("mailboxintermittentissueminrange", typeof(long)));

                this.MailboxPermanentIssueMinRange = group.Add(new VocabularyKey("MailboxPermanentIssueMinRange", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Lower Threshold For Mailbox Permanent Issue.")
                    .WithDisplayName("Lower Threshold For Mailbox Permanent Issue.")
                    .ModelProperty("mailboxpermanentissueminrange", typeof(long)));

                this.HighContrastThemeData = group.Add(new VocabularyKey("HighContrastThemeData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"High contrast theme data for the organization.")
                    .WithDisplayName("High contrast Theme Data")
                    .ModelProperty("highcontrastthemedata", typeof(string)));

                this.DelegatedAdminUserId = group.Add(new VocabularyKey("DelegatedAdminUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegated admin user for the organization.")
                    .WithDisplayName("Delegated Admin")
                    .ModelProperty("delegatedadminuserid", typeof(Guid)));

                this.IsExternalSearchIndexEnabled = group.Add(new VocabularyKey("IsExternalSearchIndexEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether data can be synchronized with an external search index.")
                    .WithDisplayName("Enable external search data syncing")
                    .ModelProperty("isexternalsearchindexenabled", typeof(bool)));

                this.IsMobileOfflineEnabled = group.Add(new VocabularyKey("IsMobileOfflineEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature MobileOffline should be enabled for the organization.")
                    .WithDisplayName("Enable MobileOffline for this Organization")
                    .ModelProperty("ismobileofflineenabled", typeof(bool)));

                this.IsOfficeGraphEnabled = group.Add(new VocabularyKey("IsOfficeGraphEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature OfficeGraph should be enabled for the organization.")
                    .WithDisplayName("Enable OfficeGraph for this Organization")
                    .ModelProperty("isofficegraphenabled", typeof(bool)));

                this.IsOneDriveEnabled = group.Add(new VocabularyKey("IsOneDriveEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature One Drive should be enabled for the organization.")
                    .WithDisplayName("Enable One Drive for this Organization")
                    .ModelProperty("isonedriveenabled", typeof(bool)));

                this.ExternalPartyEntitySettings = group.Add(new VocabularyKey("ExternalPartyEntitySettings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML string containing the ExternalPartyEnabled entities settings.")
                    .WithDisplayName("ExternalPartyEnabled Entities Settings.For internal use only")
                    .ModelProperty("externalpartyentitysettings", typeof(string)));

                this.ExternalPartyCorrelationKeys = group.Add(new VocabularyKey("ExternalPartyCorrelationKeys", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML string containing the ExternalPartyEnabled entities correlation keys for association of existing External Party instance entities to newly created IsExternalPartyEnabled entities.For internal use only")
                    .WithDisplayName("ExternalPartyEnabled Entities correlation Keys")
                    .ModelProperty("externalpartycorrelationkeys", typeof(string)));

                this.MaxVerboseLoggingMailbox = group.Add(new VocabularyKey("MaxVerboseLoggingMailbox", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Maximum number of mailboxes that can be toggled for verbose logging")
                    .WithDisplayName("Max No Of Mailboxes To Enable For Verbose Logging")
                    .ModelProperty("maxverboseloggingmailbox", typeof(long)));

                this.MaxVerboseLoggingSyncCycles = group.Add(new VocabularyKey("MaxVerboseLoggingSyncCycles", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Maximum number of sync cycles for which verbose logging will be enabled by default")
                    .WithDisplayName("Maximum number of sync cycles for which verbose logging will be enabled by default")
                    .ModelProperty("maxverboseloggingsynccycles", typeof(long)));

                this.MobileOfflineSyncInterval = group.Add(new VocabularyKey("MobileOfflineSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sync interval for mobile offline.")
                    .WithDisplayName("Sync interval for mobile offline.")
                    .ModelProperty("mobileofflinesyncinterval", typeof(long)));

                this.OfficeGraphDelveUrl = group.Add(new VocabularyKey("OfficeGraphDelveUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"The url to open the Delve for the organization.")
                    .WithDisplayName("The url to open the Delve")
                    .ModelProperty("officegraphdelveurl", typeof(string)));

                this.MobileOfflineMinLicenseTrial = group.Add(new VocabularyKey("MobileOfflineMinLicenseTrial", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Minimum number of user license required for mobile offline service by trial organization")
                    .WithDisplayName("Minimum number of user license required for mobile offline service by trial organization")
                    .ModelProperty("mobileofflineminlicensetrial", typeof(long)));

                this.MobileOfflineMinLicenseProd = group.Add(new VocabularyKey("MobileOfflineMinLicenseProd", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Minimum number of user license required for mobile offline service by production/preview organization")
                    .WithDisplayName("Minimum number of user license required for mobile offline service by production/preview organization")
                    .ModelProperty("mobileofflineminlicenseprod", typeof(long)));

                this.DaysSinceRecordLastModifiedMaxValue = group.Add(new VocabularyKey("DaysSinceRecordLastModifiedMaxValue", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The maximum value for the Mobile Offline setting Days since record last modified")
                    .WithDisplayName("Max value of Days since record last modified")
                    .ModelProperty("dayssincerecordlastmodifiedmaxvalue", typeof(long)));

                this.TaskBasedFlowEnabled = group.Add(new VocabularyKey("TaskBasedFlowEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to turn on task flows for the organization.")
                    .WithDisplayName("Enable Task Flow processes for this Organization")
                    .ModelProperty("taskbasedflowenabled", typeof(bool)));

                this.ShowKBArticleDeprecationNotification = group.Add(new VocabularyKey("ShowKBArticleDeprecationNotification", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to display a KB article deprecation notification to the user.")
                    .WithDisplayName("Show KBArticle deprecation message to user")
                    .ModelProperty("showkbarticledeprecationnotification", typeof(bool)));

                this.AzureSchedulerJobCollectionName = group.Add(new VocabularyKey("AzureSchedulerJobCollectionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("For internal use only.")
                    .ModelProperty("azureschedulerjobcollectionname", typeof(string)));

                this.CortanaProactiveExperienceEnabled = group.Add(new VocabularyKey("CortanaProactiveExperienceEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature CortanaProactiveExperience Flow processes should be enabled for the organization.")
                    .WithDisplayName("Enable Cortana Proactive Experience Flow processes for this Organization")
                    .ModelProperty("cortanaproactiveexperienceenabled", typeof(bool)));

                this.OfficeAppsAutoDeploymentEnabled = group.Add(new VocabularyKey("OfficeAppsAutoDeploymentEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the Office Apps auto deployment is enabled for the organization.")
                    .WithDisplayName("Enable Office Apps Auto Deployment for this Organization")
                    .ModelProperty("officeappsautodeploymentenabled", typeof(bool)));

                this.AppDesignerExperienceEnabled = group.Add(new VocabularyKey("AppDesignerExperienceEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the appDesignerExperience is enabled for the organization.")
                    .WithDisplayName("Enable App Designer Experience for this Organization")
                    .ModelProperty("appdesignerexperienceenabled", typeof(bool)));

                this.EnableImmersiveSkypeIntegration = group.Add(new VocabularyKey("EnableImmersiveSkypeIntegration", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Integration with Immersive Skype")
                    .WithDisplayName("Enable Integration with Immersive Skype")
                    .ModelProperty("enableimmersiveskypeintegration", typeof(bool)));

                this.AutoApplySLA = group.Add(new VocabularyKey("AutoApplySLA", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether to Auto-apply SLA on case record update after SLA was manually applied.")
                    .WithDisplayName("Is Auto-apply SLA After Manually Over-riding")
                    .ModelProperty("autoapplysla", typeof(bool)));

                this.IsEmailServerProfileContentFilteringEnabled = group.Add(new VocabularyKey("IsEmailServerProfileContentFilteringEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Email Server Profile content filtering")
                    .WithDisplayName("Is Email Server Profile Content Filtering Enabled")
                    .ModelProperty("isemailserverprofilecontentfilteringenabled", typeof(bool)));

                this.IsDelegateAccessEnabled = group.Add(new VocabularyKey("IsDelegateAccessEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Delegation Access content")
                    .WithDisplayName("Is Delegation Access Enabled")
                    .ModelProperty("isdelegateaccessenabled", typeof(bool)));

                this.DisplayNavigationTour = group.Add(new VocabularyKey("DisplayNavigationTour", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether or not navigation tour is displayed.")
                    .WithDisplayName("Display Navigation Tour")
                    .ModelProperty("displaynavigationtour", typeof(bool)));

                this.UseLegacyRendering = group.Add(new VocabularyKey("UseLegacyRendering", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use legacy form rendering.")
                    .WithDisplayName("Legacy Form Rendering")
                    .ModelProperty("uselegacyrendering", typeof(bool)));

                this.DefaultMobileOfflineProfileId = group.Add(new VocabularyKey("DefaultMobileOfflineProfileId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the default mobile offline profile.")
                    .WithDisplayName("Default Mobile Offline Profile")
                    .ModelProperty("defaultmobileofflineprofileid", typeof(string)));

                this.DefaultMobileOfflineProfileIdName = group.Add(new VocabularyKey("DefaultMobileOfflineProfileIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the default mobile offline profile to be used as default profile for mobile offline.")
                    .WithDisplayName("DefaultMobileOfflineProfileIdName")
                    .ModelProperty("defaultmobileofflineprofileidname", typeof(string)));

                this.KaPrefix = group.Add(new VocabularyKey("KaPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the prefix to use for all knowledge articles in Microsoft Dynamics 365.")
                    .WithDisplayName("Knowledge Article Prefix")
                    .ModelProperty("kaprefix", typeof(string)));

                this.CurrentKaNumber = group.Add(new VocabularyKey("CurrentKaNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the first number to use for knowledge articles. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Knowledge Article Number")
                    .ModelProperty("currentkanumber", typeof(long)));

                this.CurrentCategoryNumber = group.Add(new VocabularyKey("CurrentCategoryNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the first number to use for Categories. Deprecated. Use SetAutoNumberSeed message.")
                    .WithDisplayName("Current Category Number")
                    .ModelProperty("currentcategorynumber", typeof(long)));

                this.CategoryPrefix = group.Add(new VocabularyKey("CategoryPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the prefix to use for all categories in Microsoft Dynamics 365.")
                    .WithDisplayName("Category Prefix")
                    .ModelProperty("categoryprefix", typeof(string)));

                this.MaximumEntitiesWithActiveSLA = group.Add(new VocabularyKey("MaximumEntitiesWithActiveSLA", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of active SLA allowed per entity in online")
                    .WithDisplayName("Maximum number of active SLA allowed per entity in online")
                    .ModelProperty("maximumentitieswithactivesla", typeof(long)));

                this.MaximumSLAKPIPerEntityWithActiveSLA = group.Add(new VocabularyKey("MaximumSLAKPIPerEntityWithActiveSLA", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of SLA KPI per active SLA allowed for entity in online")
                    .WithDisplayName("Maximum number of active SLA KPI allowed per entity in online")
                    .ModelProperty("maximumslakpiperentitywithactivesla", typeof(long)));

                this.IsConflictDetectionEnabledForMobileClient = group.Add(new VocabularyKey("IsConflictDetectionEnabledForMobileClient", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether conflict detection for mobile client is enabled.")
                    .WithDisplayName("Is Conflict Detection for Mobile Client enabled")
                    .ModelProperty("isconflictdetectionenabledformobileclient", typeof(bool)));

                this.IsDelveActionHubIntegrationEnabled = group.Add(new VocabularyKey("IsDelveActionHubIntegrationEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Action Hub should be enabled for the organization.")
                    .WithDisplayName("Enable Action Hub for this Organization")
                    .ModelProperty("isdelveactionhubintegrationenabled", typeof(bool)));

                this.OrgInsightsEnabled = group.Add(new VocabularyKey("OrgInsightsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to turn on OrgInsights for the organization.")
                    .WithDisplayName("Enable OrgInsights for this Organization")
                    .ModelProperty("orginsightsenabled", typeof(bool)));

                this.ProductRecommendationsEnabled = group.Add(new VocabularyKey("ProductRecommendationsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to turn on product recommendations for the organization.")
                    .WithDisplayName("Enable Product Recommendations for this Organization")
                    .ModelProperty("productrecommendationsenabled", typeof(bool)));

                this.TextAnalyticsEnabled = group.Add(new VocabularyKey("TextAnalyticsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to turn on text analytics for the organization.")
                    .WithDisplayName("Enable Text Analytics for this Organization")
                    .ModelProperty("textanalyticsenabled", typeof(bool)));

                this.MaxConditionsForMobileOfflineFilters = group.Add(new VocabularyKey("MaxConditionsForMobileOfflineFilters", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of conditions allowed for mobile offline filters")
                    .WithDisplayName("Maximum number of conditions allowed for mobile offline filters")
                    .ModelProperty("maxconditionsformobileofflinefilters", typeof(long)));

                this.IsFolderAutoCreatedonSP = group.Add(new VocabularyKey("IsFolderAutoCreatedonSP", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether folders should be automatically created on SharePoint.")
                    .WithDisplayName("Automatically create folders")
                    .ModelProperty("isfolderautocreatedonsp", typeof(bool)));

                this.PowerBiFeatureEnabled = group.Add(new VocabularyKey("PowerBiFeatureEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the Power BI feature should be enabled for the organization.")
                    .WithDisplayName("Enable Power BI feature for this Organization")
                    .ModelProperty("powerbifeatureenabled", typeof(bool)));

                this.IsActionCardEnabled = group.Add(new VocabularyKey("IsActionCardEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Action Card should be enabled for the organization.")
                    .WithDisplayName("Enable Action Card for this Organization")
                    .ModelProperty("isactioncardenabled", typeof(bool)));

                this.IsEmailMonitoringAllowed = group.Add(new VocabularyKey("IsEmailMonitoringAllowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Allow tracking recipient activity on sent emails.")
                    .WithDisplayName("Allow tracking recipient activity on sent emails")
                    .ModelProperty("isemailmonitoringallowed", typeof(bool)));

                this.IsActivityAnalysisEnabled = group.Add(new VocabularyKey("IsActivityAnalysisEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Relationship Analytics should be enabled for the organization.")
                    .WithDisplayName("Enable Relationship Analytics for this Organization")
                    .ModelProperty("isactivityanalysisenabled", typeof(bool)));

                this.IsAutoDataCaptureEnabled = group.Add(new VocabularyKey("IsAutoDataCaptureEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Auto Capture should be enabled for the organization.")
                    .WithDisplayName("Enable Auto Capture for this Organization")
                    .ModelProperty("isautodatacaptureenabled", typeof(bool)));

                this.ExternalBaseUrl = group.Add(new VocabularyKey("ExternalBaseUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Specify the base URL to use to look for external document suggestions.")
                    .WithDisplayName("External Base URL")
                    .ModelProperty("externalbaseurl", typeof(string)));

                this.IsPreviewEnabledForActionCard = group.Add(new VocabularyKey("IsPreviewEnabledForActionCard", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the Preview feature for Action Card should be enabled for the organization.")
                    .WithDisplayName("Enable Preview Action Card feature for this Organization")
                    .ModelProperty("ispreviewenabledforactioncard", typeof(bool)));

                this.IsPreviewForEmailMonitoringAllowed = group.Add(new VocabularyKey("IsPreviewForEmailMonitoringAllowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is Preview For Email Monitoring Allowed.")
                    .WithDisplayName("Allows Preview For Email Monitoring")
                    .ModelProperty("ispreviewforemailmonitoringallowed", typeof(bool)));

                this.UnresolveEmailAddressIfMultipleMatch = group.Add(new VocabularyKey("UnresolveEmailAddressIfMultipleMatch", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether email address should be unresolved if multiple matches are found")
                    .WithDisplayName("Set To,cc,bcc fields as unresolved if multiple matches are found")
                    .ModelProperty("unresolveemailaddressifmultiplematch", typeof(bool)));

                this.RiErrorStatus = group.Add(new VocabularyKey("RiErrorStatus", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Error status of Relationship Insights provisioning.")
                    .WithDisplayName("Error status of Relationship Insights provisioning.")
                    .ModelProperty("rierrorstatus", typeof(long)));

                this.WidgetProperties = group.Add(new VocabularyKey("WidgetProperties", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"For Internal use only.")
                    .WithDisplayName("For Internal use only.")
                    .ModelProperty("widgetproperties", typeof(string)));

                this.EnableMicrosoftFlowIntegration = group.Add(new VocabularyKey("EnableMicrosoftFlowIntegration", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable Integration with Microsoft Flow")
                    .WithDisplayName("Enable Integration with Microsoft Flow")
                    .ModelProperty("enablemicrosoftflowintegration", typeof(bool)));

                this.IsEnabledForAllRoles = group.Add(new VocabularyKey("IsEnabledForAllRoles", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether appmodule is enabled for all roles")
                    .WithDisplayName("option set values for isenabledforallroles")
                    .ModelProperty("isenabledforallroles", typeof(bool)));

                this.IsPreviewForAutoCaptureEnabled = group.Add(new VocabularyKey("IsPreviewForAutoCaptureEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Auto Capture should be enabled for the organization at Preview Settings.")
                    .WithDisplayName("Enable Auto Capture for this Organization at Preview Settings")
                    .ModelProperty("ispreviewforautocaptureenabled", typeof(bool)));

                this.DefaultCrmCustomName = group.Add(new VocabularyKey("DefaultCrmCustomName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the default crm custom.")
                    .WithDisplayName("Name of the default app")
                    .ModelProperty("defaultcrmcustomname", typeof(string)));

                this.ACIWebEndpointUrl = group.Add(new VocabularyKey("ACIWebEndpointUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"ACI Web Endpoint URL.")
                    .WithDisplayName("ACI Tenant URL.")
                    .ModelProperty("aciwebendpointurl", typeof(string)));

                this.EnableLPAuthoring = group.Add(new VocabularyKey("EnableLPAuthoring", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select to enable learning path auhtoring.")
                    .WithDisplayName("Enable Learning Path Authoring")
                    .ModelProperty("enablelpauthoring", typeof(bool)));

                this.IsResourceBookingExchangeSyncEnabled = group.Add(new VocabularyKey("IsResourceBookingExchangeSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if the synchronization of user resource booking with Exchange is enabled at organization level.")
                    .WithDisplayName("Resource booking synchronization enabled")
                    .ModelProperty("isresourcebookingexchangesyncenabled", typeof(bool)));

                this.IsMobileClientOnDemandSyncEnabled = group.Add(new VocabularyKey("IsMobileClientOnDemandSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether mobile client on demand sync is enabled.")
                    .WithDisplayName("Is Mobile Client On Demand Sync enabled")
                    .ModelProperty("ismobileclientondemandsyncenabled", typeof(bool)));

                this.PostMessageWhitelistDomains = group.Add(new VocabularyKey("PostMessageWhitelistDomains", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("For internal use only.")
                    .ModelProperty("postmessagewhitelistdomains", typeof(string)));

                this.IsRelationshipInsightsEnabled = group.Add(new VocabularyKey("IsRelationshipInsightsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Relationship Insights should be enabled for the organization.")
                    .WithDisplayName("Enable Relationship Insights for this Organization")
                    .ModelProperty("isrelationshipinsightsenabled", typeof(bool)));

                this.ResolveSimilarUnresolvedEmailAddress = group.Add(new VocabularyKey("ResolveSimilarUnresolvedEmailAddress", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Apply same email address to all unresolved matches when you manually resolve it for one")
                    .WithDisplayName("Apply same email address to all unresolved matches when you manually resolve it for one")
                    .ModelProperty("resolvesimilarunresolvedemailaddress", typeof(bool)));

                this.IsTextWrapEnabled = group.Add(new VocabularyKey("IsTextWrapEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information on whether text wrap is enabled.")
                    .WithDisplayName("Enable Text Wrap")
                    .ModelProperty("istextwrapenabled", typeof(bool)));

                this.SessionTimeoutEnabled = group.Add(new VocabularyKey("SessionTimeoutEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether session timeout is enabled")
                    .WithDisplayName("Session timeout enabled")
                    .ModelProperty("sessiontimeoutenabled", typeof(bool)));

                this.SessionTimeoutInMins = group.Add(new VocabularyKey("SessionTimeoutInMins", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Session timeout in minutes")
                    .WithDisplayName("Session timeout in minutes")
                    .ModelProperty("sessiontimeoutinmins", typeof(long)));

                this.SessionTimeoutReminderInMins = group.Add(new VocabularyKey("SessionTimeoutReminderInMins", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Session timeout reminder in minutes")
                    .WithDisplayName("Session timeout reminder in minutes")
                    .ModelProperty("sessiontimeoutreminderinmins", typeof(long)));

                this.MicrosoftFlowEnvironment = group.Add(new VocabularyKey("MicrosoftFlowEnvironment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"(Deprecated) Environment selected for Integration with Microsoft Flow")
                    .WithDisplayName("(Deprecated) Environment selected for Integration with Microsoft Flow")
                    .ModelProperty("microsoftflowenvironment", typeof(string)));

                this.InactivityTimeoutEnabled = group.Add(new VocabularyKey("InactivityTimeoutEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether Inactivity timeout is enabled")
                    .WithDisplayName("Inactivity timeout enabled")
                    .ModelProperty("inactivitytimeoutenabled", typeof(bool)));

                this.InactivityTimeoutInMins = group.Add(new VocabularyKey("InactivityTimeoutInMins", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Inactivity timeout in minutes")
                    .WithDisplayName("Inactivity timeout in minutes")
                    .ModelProperty("inactivitytimeoutinmins", typeof(long)));

                this.InactivityTimeoutReminderInMins = group.Add(new VocabularyKey("InactivityTimeoutReminderInMins", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Inactivity timeout reminder in minutes")
                    .WithDisplayName("Inactivity timeout reminder in minutes")
                    .ModelProperty("inactivitytimeoutreminderinmins", typeof(long)));

                this.SyncOptInSelection = group.Add(new VocabularyKey("SyncOptInSelection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates the selection to use the dynamics 365 azure sync framework or server side sync.")
                    .WithDisplayName("Enable dynamics 365 azure sync framework for this organization.")
                    .ModelProperty("syncoptinselection", typeof(bool)));

                this.SyncOptInSelectionStatus = group.Add(new VocabularyKey("SyncOptInSelectionStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates the status of the opt-in or opt-out operation for dynamics 365 azure sync.")
                    .WithDisplayName("Status of opt-in or opt-out operation for dynamics 365 azure sync.")
                    .ModelProperty("syncoptinselectionstatus", typeof(string)));

                this.IsActionSupportFeatureEnabled = group.Add(new VocabularyKey("IsActionSupportFeatureEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether Action Support Feature is enabled")
                    .WithDisplayName("Action Support Feature enabled")
                    .ModelProperty("isactionsupportfeatureenabled", typeof(bool)));

                this.IsBPFEntityCustomizationFeatureEnabled = group.Add(new VocabularyKey("IsBPFEntityCustomizationFeatureEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether BPF Entity Customization Feature is enabled")
                    .WithDisplayName("BPF Entity Customization Feature enabled")
                    .ModelProperty("isbpfentitycustomizationfeatureenabled", typeof(bool)));

                this.BoundDashboardDefaultCardExpanded = group.Add(new VocabularyKey("BoundDashboardDefaultCardExpanded", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Display cards in expanded state for interactive dashboard")
                    .WithDisplayName("Display cards in expanded state for Interactive Dashboard")
                    .ModelProperty("bounddashboarddefaultcardexpanded", typeof(bool)));

                this.MaxActionStepsInBPF = group.Add(new VocabularyKey("MaxActionStepsInBPF", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of actionsteps allowed in a BPF")
                    .WithDisplayName("Maximum number of actionsteps allowed in a BPF")
                    .ModelProperty("maxactionstepsinbpf", typeof(long)));

                this.ServeStaticResourcesFromAzureCDN = group.Add(new VocabularyKey("ServeStaticResourcesFromAzureCDN", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Serve Static Content From CDN")
                    .WithDisplayName("Serve Static Content From CDN")
                    .ModelProperty("servestaticresourcesfromazurecdn", typeof(bool)));

                this.IsExternalFileStorageEnabled = group.Add(new VocabularyKey("IsExternalFileStorageEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the organization's files are being stored in Azure.")
                    .WithDisplayName("Enable external file storage")
                    .ModelProperty("isexternalfilestorageenabled", typeof(bool)));

                this.ClientFeatureSet = group.Add(new VocabularyKey("ClientFeatureSet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Client Features to be enabled as an XML BLOB.")
                    .WithDisplayName("Client Feature Set")
                    .ModelProperty("clientfeatureset", typeof(string)));

                this.IsReadAuditEnabled = group.Add(new VocabularyKey("IsReadAuditEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable or disable auditing of read operations.")
                    .WithDisplayName("Is Read Auditing Enabled")
                    .ModelProperty("isreadauditenabled", typeof(bool)));

                this.IsNotesAnalysisEnabled = group.Add(new VocabularyKey("IsNotesAnalysisEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the feature Notes Analysis should be enabled for the organization.")
                    .WithDisplayName("Enable Notes Analysis for this Organization")
                    .ModelProperty("isnotesanalysisenabled", typeof(bool)));

                this.AllowLegacyDialogsEmbedding = group.Add(new VocabularyKey("AllowLegacyDialogsEmbedding", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable embedding of certain legacy dialogs in Unified Interface browser client")
                    .WithDisplayName("Enable embedding of certain legacy dialogs in Unified Interface browser client")
                    .ModelProperty("allowlegacydialogsembedding", typeof(bool)));

                this.AllowLegacyClientExperience = group.Add(new VocabularyKey("AllowLegacyClientExperience", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable access to legacy web client UI")
                    .WithDisplayName("Enable access to legacy web client UI")
                    .ModelProperty("allowlegacyclientexperience", typeof(bool)));

                this.IsMSTeamsEnabled = group.Add(new VocabularyKey("IsMSTeamsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Microsoft Teams integration has been enabled for the organization.")
                    .WithDisplayName("Enable Microsoft Teams integration")
                    .ModelProperty("ismsteamsenabled", typeof(bool)));

                this.IsLUISEnabledforD365Bot = group.Add(new VocabularyKey("IsLUISEnabledforD365Bot", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Give Consent to use LUIS in Dynamics 365 Bot")
                    .WithDisplayName("LUIS Consent for Dynamics 365 Bot")
                    .ModelProperty("isluisenabledford365bot", typeof(bool)));

                this.SyncBulkOperationBatchSize = group.Add(new VocabularyKey("SyncBulkOperationBatchSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of records to update per operation in Sync Bulk Pause/Resume/Cancel")
                    .WithDisplayName("Number of records to update per operation in Sync Bulk Pause/Resume/Cancel")
                    .ModelProperty("syncbulkoperationbatchsize", typeof(long)));

                this.SyncBulkOperationMaxLimit = group.Add(new VocabularyKey("SyncBulkOperationMaxLimit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Max total number of records to update in database for Sync Bulk Pause/Resume/Cancel")
                    .WithDisplayName("Max total number of records to update in database for Sync Bulk Pause/Resume/Cancel")
                    .ModelProperty("syncbulkoperationmaxlimit", typeof(long)));

                this.EnableUnifiedInterfaceShellRefresh = group.Add(new VocabularyKey("EnableUnifiedInterfaceShellRefresh", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enable site map and commanding update")
                    .WithDisplayName("Enable site map and commanding update")
                    .ModelProperty("enableunifiedinterfaceshellrefresh", typeof(bool)));

                this.IsMSTeamsSettingChangedByUser = group.Add(new VocabularyKey("IsMSTeamsSettingChangedByUser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the user has enabled or disabled Microsoft Teams integration.")
                    .WithDisplayName("Microsoft Teams integration changed by user")
                    .ModelProperty("ismsteamssettingchangedbyuser", typeof(bool)));

                this.EnableLivePersonaCardUCI = group.Add(new VocabularyKey("EnableLivePersonaCardUCI", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the user has enabled or disabled Live Persona Card feature in UCI.")
                    .WithDisplayName("Indicates whether the user has enabled or disabled Live Persona Card feature in UCI.")
                    .ModelProperty("enablelivepersonacarduci", typeof(bool)));

                this.IsMSTeamsCollaborationEnabled = group.Add(new VocabularyKey("IsMSTeamsCollaborationEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Microsoft Teams Collaboration feature has been enabled for the organization.")
                    .WithDisplayName("Enable Microsoft Teams Collaboration for this organization")
                    .ModelProperty("ismsteamscollaborationenabled", typeof(bool)));

                this.IsMSTeamsUserSyncEnabled = group.Add(new VocabularyKey("IsMSTeamsUserSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Microsoft Teams User Sync feature has been enabled for the organization.")
                    .WithDisplayName("Enable Microsoft Teams User Sync for this organization")
                    .ModelProperty("ismsteamsusersyncenabled", typeof(bool)));

                this.IsManualSalesForecastingEnabled = group.Add(new VocabularyKey("IsManualSalesForecastingEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Manual Sales Forecasting feature has been enabled for the organization.")
                    .WithDisplayName("Enable Manual Sales Forecasting feature for this organization")
                    .ModelProperty("ismanualsalesforecastingenabled", typeof(bool)));

                this.IsPDFGenerationEnabled = group.Add(new VocabularyKey("IsPDFGenerationEnabled", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"Indicates whether PDF Generation feature has been enabled for the organization.")
                    .WithDisplayName("Enable PDF Generation feature for this organization")
                    .ModelProperty("ispdfgenerationenabled", typeof(string)));

                this.IsCustomControlsInCanvasAppsEnabled = group.Add(new VocabularyKey("IsCustomControlsInCanvasAppsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Custom Controls in canvas PowerApps feature has been enabled for the organization.")
                    .WithDisplayName("Enable Custom Controls in canvas PowerApps feature for this organization")
                    .ModelProperty("iscustomcontrolsincanvasappsenabled", typeof(bool)));

                this.IsPAIEnabled = group.Add(new VocabularyKey("IsPAIEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether PAI feature has been enabled for the organization.")
                    .WithDisplayName("Enable PAI feature for this organization")
                    .ModelProperty("ispaienabled", typeof(bool)));

                this.IsQuickCreateEnabledForOpportunityClose = group.Add(new VocabularyKey("IsQuickCreateEnabledForOpportunityClose", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use the standard Out-of-box Opportunity Close experience or opt to for a customized experience.")
                    .WithDisplayName("Enable quick create form for opportunity close feature for this organization")
                    .ModelProperty("isquickcreateenabledforopportunityclose", typeof(bool)));

                this.ContentSecurityPolicyConfiguration = group.Add(new VocabularyKey("ContentSecurityPolicyConfiguration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Policy configuration for CSP")
                    .WithDisplayName("Content Security Policy Configuration")
                    .ModelProperty("contentsecuritypolicyconfiguration", typeof(string)));

                this.IsContentSecurityPolicyEnabled = group.Add(new VocabularyKey("IsContentSecurityPolicyEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Content Security Policy has been enabled for the organization.")
                    .WithDisplayName("Enable Content Security Policy for this organization")
                    .ModelProperty("iscontentsecuritypolicyenabled", typeof(bool)));

                this.IsPriceListMandatory = group.Add(new VocabularyKey("IsPriceListMandatory", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether PriceList is mandatory for adding existing products to sales entities.")
                    .WithDisplayName("Indicates whether PriceList is mandatory for adding existing products to sales entities")
                    .ModelProperty("ispricelistmandatory", typeof(bool)));

                this.EnableLivePersonCardIntegrationInOffice = group.Add(new VocabularyKey("EnableLivePersonCardIntegrationInOffice", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office.")
                    .WithDisplayName("Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office.")
                    .ModelProperty("enablelivepersoncardintegrationinoffice", typeof(bool)));

                this.IsContextualEmailEnabled = group.Add(new VocabularyKey("IsContextualEmailEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Contextual email experience is enabled on this organization")
                    .WithDisplayName("Indicates whether Contextual email experience is enabled on this organization")
                    .ModelProperty("iscontextualemailenabled", typeof(bool)));

                this.QualifyLeadAdditionalOptions = group.Add(new VocabularyKey("QualifyLeadAdditionalOptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"Indicates whether prompt should be shown for new Qualify Lead Experience")
                    .WithDisplayName("Enable New Qualify Lead Experience with configuration MDD")
                    .ModelProperty("qualifyleadadditionaloptions", typeof(string)));

                this.BusinessCardOptions = group.Add(new VocabularyKey("BusinessCardOptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"BusinessCardOptions")
                    .WithDisplayName("Enable New BusinessCardOptions")
                    .ModelProperty("businesscardoptions", typeof(string)));

                this.IsPlaybookEnabled = group.Add(new VocabularyKey("IsPlaybookEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether playbook feature has been enabled for the organization.")
                    .WithDisplayName("Enable playbook feature for this organization")
                    .ModelProperty("isplaybookenabled", typeof(bool)));

                this.PaiPreviewScenarioEnabled = group.Add(new VocabularyKey("PaiPreviewScenarioEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Preview feature has been enabled for the organization.")
                    .WithDisplayName("Display Preview Feature for this organization")
                    .ModelProperty("paipreviewscenarioenabled", typeof(bool)));

                this.IsContextualHelpEnabled = group.Add(new VocabularyKey("IsContextualHelpEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select to enable Contextual Help in UCI.")
                    .WithDisplayName("Enables Contextual Help in UCI")
                    .ModelProperty("iscontextualhelpenabled", typeof(bool)));

                this.IsSalesAssistantEnabled = group.Add(new VocabularyKey("IsSalesAssistantEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Sales Assistant mobile app has been enabled for the organization.")
                    .WithDisplayName("Enable Sales Assistant mobile app")
                    .ModelProperty("issalesassistantenabled", typeof(bool)));

                this.IsAutoDataCaptureV2Enabled = group.Add(new VocabularyKey("IsAutoDataCaptureV2Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the V2 feature of Auto Capture should be enabled for the organization.")
                    .WithDisplayName("Enable Auto Capture V2 for this Organization")
                    .ModelProperty("isautodatacapturev2enabled", typeof(bool)));

                this.IsNewAddProductExperienceEnabled = group.Add(new VocabularyKey("IsNewAddProductExperienceEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether new add product experience is enabled.")
                    .WithDisplayName("Indicates whether new add product experience is enabled in opportunity form")
                    .ModelProperty("isnewaddproductexperienceenabled", typeof(bool)));

                this.AuditRetentionPeriod = group.Add(new VocabularyKey("AuditRetentionPeriod", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Audit Retention Period settings stored in Organization Database.")
                    .WithDisplayName("Audit Retention Period Settings")
                    .ModelProperty("auditretentionperiod", typeof(long)));

                this.UseQuickFindViewForGridSearch = group.Add(new VocabularyKey("UseQuickFindViewForGridSearch", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether searching in a grid should use the Quick Find view for the entity.")
                    .WithDisplayName("Use Quick Find view when searching in grids")
                    .ModelProperty("usequickfindviewforgridsearch", typeof(bool)));

                this.IsRichTextNotesEnabled = group.Add(new VocabularyKey("IsRichTextNotesEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether rich text editor for notes experience is enabled on this organization")
                    .WithDisplayName("Indicates whether rich text editor for notes experience is enabled on this organization")
                    .ModelProperty("isrichtextnotesenabled", typeof(bool)));

                this.SendBulkEmailInUCI = group.Add(new VocabularyKey("SendBulkEmailInUCI", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Send Bulk Email in UCI is enabled for the org.")
                    .WithDisplayName("Send Bulk Email in UCI")
                    .ModelProperty("sendbulkemailinuci", typeof(bool)));

                this.IsAllMoneyDecimal = group.Add(new VocabularyKey("IsAllMoneyDecimal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether all money attributes are converted to decimal.")
                    .WithDisplayName("Set if all money attributes are converted to decimal")
                    .ModelProperty("isallmoneydecimal", typeof(bool)));

                this.IsWriteInProductsAllowed = group.Add(new VocabularyKey("IsWriteInProductsAllowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not.")
                    .WithDisplayName("Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not")
                    .ModelProperty("iswriteinproductsallowed", typeof(bool)));

                this.AppointmentRichEditorExperience = group.Add(new VocabularyKey("AppointmentRichEditorExperience", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information on whether rich editing experience for Appointment is enabled.")
                    .WithDisplayName("Enable Rich Editing Experience for Appointment")
                    .ModelProperty("appointmentricheditorexperience", typeof(bool)));

                this.appointmentricheditorexperienceName = group.Add(new VocabularyKey("appointmentricheditorexperienceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("appointmentricheditorexperienceName")
                    .ModelProperty("appointmentricheditorexperiencename", typeof(string)));

                this.SchedulingEngine = group.Add(new VocabularyKey("SchedulingEngine", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Scheduling engine for Appointments and Service Activities")
                    .WithDisplayName("Scheduling engine for Appointments and Service Activities")
                    .ModelProperty("schedulingengine", typeof(string)));

                this.schedulingengineName = group.Add(new VocabularyKey("schedulingengineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("schedulingengineName")
                    .ModelProperty("schedulingenginename", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey UserGroupId { get; private set; }

        public VocabularyKey PrivilegeUserGroupId { get; private set; }

        public VocabularyKey RecurrenceExpansionJobBatchSize { get; private set; }

        public VocabularyKey RecurrenceExpansionJobBatchInterval { get; private set; }

        public VocabularyKey FiscalPeriodType { get; private set; }

        public VocabularyKey FiscalCalendarStart { get; private set; }

        public VocabularyKey DateFormatCode { get; private set; }

        public VocabularyKey TimeFormatCode { get; private set; }

        public VocabularyKey CurrencySymbol { get; private set; }

        public VocabularyKey WeekStartDayCode { get; private set; }

        public VocabularyKey DateSeparator { get; private set; }

        public VocabularyKey FullNameConventionCode { get; private set; }

        public VocabularyKey NegativeFormatCode { get; private set; }

        public VocabularyKey NumberFormat { get; private set; }

        public VocabularyKey IsDisabled { get; private set; }

        public VocabularyKey DisabledReason { get; private set; }

        public VocabularyKey KbPrefix { get; private set; }

        public VocabularyKey CurrentKbNumber { get; private set; }

        public VocabularyKey CasePrefix { get; private set; }

        public VocabularyKey CurrentCaseNumber { get; private set; }

        public VocabularyKey ContractPrefix { get; private set; }

        public VocabularyKey CurrentContractNumber { get; private set; }

        public VocabularyKey QuotePrefix { get; private set; }

        public VocabularyKey CurrentQuoteNumber { get; private set; }

        public VocabularyKey OrderPrefix { get; private set; }

        public VocabularyKey CurrentOrderNumber { get; private set; }

        public VocabularyKey InvoicePrefix { get; private set; }

        public VocabularyKey CurrentInvoiceNumber { get; private set; }

        public VocabularyKey UniqueSpecifierLength { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey FiscalYearFormat { get; private set; }

        public VocabularyKey FiscalPeriodFormat { get; private set; }

        public VocabularyKey FiscalYearPeriodConnect { get; private set; }

        public VocabularyKey LanguageCode { get; private set; }

        public VocabularyKey SortId { get; private set; }

        public VocabularyKey DateFormatString { get; private set; }

        public VocabularyKey TimeFormatString { get; private set; }

        public VocabularyKey PricingDecimalPrecision { get; private set; }

        public VocabularyKey ShowWeekNumber { get; private set; }

        public VocabularyKey ShowWeekNumberName { get; private set; }

        public VocabularyKey IsDisabledName { get; private set; }

        public VocabularyKey DateFormatCodeName { get; private set; }

        public VocabularyKey FullNameConventionCodeName { get; private set; }

        public VocabularyKey LanguageCodeName { get; private set; }

        public VocabularyKey TimeFormatCodeName { get; private set; }

        public VocabularyKey NegativeFormatCodeName { get; private set; }

        public VocabularyKey WeekStartDayCodeName { get; private set; }

        public VocabularyKey NextTrackingNumber { get; private set; }

        public VocabularyKey TagMaxAggressiveCycles { get; private set; }

        public VocabularyKey TokenKey { get; private set; }

        public VocabularyKey SystemUserId { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey GrantAccessToNetworkService { get; private set; }

        public VocabularyKey AllowOutlookScheduledSyncs { get; private set; }

        public VocabularyKey AllowMarketingEmailExecution { get; private set; }

        public VocabularyKey SqlAccessGroupId { get; private set; }

        public VocabularyKey CurrencyFormatCode { get; private set; }

        public VocabularyKey FiscalSettingsUpdated { get; private set; }

        public VocabularyKey ReportingGroupId { get; private set; }

        public VocabularyKey TokenExpiry { get; private set; }

        public VocabularyKey ShareToPreviousOwnerOnAssign { get; private set; }

        public VocabularyKey AcknowledgementTemplateId { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey IntegrationUserId { get; private set; }

        public VocabularyKey TrackingTokenIdBase { get; private set; }

        public VocabularyKey BusinessClosureCalendarId { get; private set; }

        public VocabularyKey AllowAutoUnsubscribeAcknowledgement { get; private set; }

        public VocabularyKey AllowAutoUnsubscribe { get; private set; }

        public VocabularyKey Picture { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey TrackingPrefix { get; private set; }

        public VocabularyKey MinOutlookSyncInterval { get; private set; }

        public VocabularyKey BulkOperationPrefix { get; private set; }

        public VocabularyKey AllowAutoResponseCreation { get; private set; }

        public VocabularyKey MaximumTrackingNumber { get; private set; }

        public VocabularyKey CampaignPrefix { get; private set; }

        public VocabularyKey SqlAccessGroupName { get; private set; }

        public VocabularyKey CurrentCampaignNumber { get; private set; }

        public VocabularyKey FiscalYearDisplayCode { get; private set; }

        public VocabularyKey SiteMapXml { get; private set; }

        public VocabularyKey ReportingGroupName { get; private set; }

        public VocabularyKey CurrentBulkOperationNumber { get; private set; }

        public VocabularyKey SchemaNamePrefix { get; private set; }

        public VocabularyKey IgnoreInternalEmail { get; private set; }

        public VocabularyKey TagPollingPeriod { get; private set; }

        public VocabularyKey TrackingTokenIdDigits { get; private set; }

        public VocabularyKey AcknowledgementTemplateIdName { get; private set; }

        public VocabularyKey CurrencyFormatCodeName { get; private set; }

        public VocabularyKey FiscalSettingsUpdatedName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey NumberGroupFormat { get; private set; }

        public VocabularyKey LongDateFormatCode { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey CurrentImportSequenceNumber { get; private set; }

        public VocabularyKey ParsedTablePrefix { get; private set; }

        public VocabularyKey V3CalloutConfigHash { get; private set; }

        public VocabularyKey IsFiscalPeriodMonthBased { get; private set; }

        public VocabularyKey LocaleId { get; private set; }

        public VocabularyKey ParsedTableColumnPrefix { get; private set; }

        public VocabularyKey SupportUserId { get; private set; }

        public VocabularyKey AMDesignator { get; private set; }

        public VocabularyKey CurrencyDisplayOption { get; private set; }

        public VocabularyKey MinAddressBookSyncInterval { get; private set; }

        public VocabularyKey IsDuplicateDetectionEnabledForOnlineCreateUpdate { get; private set; }

        public VocabularyKey FeatureSet { get; private set; }

        public VocabularyKey BlockedAttachments { get; private set; }

        public VocabularyKey IsDuplicateDetectionEnabledForOfflineSync { get; private set; }

        public VocabularyKey AllowOfflineScheduledSyncs { get; private set; }

        public VocabularyKey AllowUnresolvedPartiesOnEmailSend { get; private set; }

        public VocabularyKey TimeSeparator { get; private set; }

        public VocabularyKey CurrentParsedTableNumber { get; private set; }

        public VocabularyKey MinOfflineSyncInterval { get; private set; }

        public VocabularyKey AllowWebExcelExport { get; private set; }

        public VocabularyKey ReferenceSiteMapXml { get; private set; }

        public VocabularyKey IsDuplicateDetectionEnabledForImport { get; private set; }

        public VocabularyKey CalendarType { get; private set; }

        public VocabularyKey SQMEnabled { get; private set; }

        public VocabularyKey NegativeCurrencyFormatCode { get; private set; }

        public VocabularyKey AllowAddressBookSyncs { get; private set; }

        public VocabularyKey ISVIntegrationCode { get; private set; }

        public VocabularyKey DecimalSymbol { get; private set; }

        public VocabularyKey MaxUploadFileSize { get; private set; }

        public VocabularyKey IsAppMode { get; private set; }

        public VocabularyKey EnablePricingOnCreate { get; private set; }

        public VocabularyKey IsSOPIntegrationEnabled { get; private set; }

        public VocabularyKey PMDesignator { get; private set; }

        public VocabularyKey CurrencyDecimalPrecision { get; private set; }

        public VocabularyKey MaxAppointmentDurationDays { get; private set; }

        public VocabularyKey EmailSendPollingPeriod { get; private set; }

        public VocabularyKey RenderSecureIFrameForEmail { get; private set; }

        public VocabularyKey NumberSeparator { get; private set; }

        public VocabularyKey PrivReportingGroupId { get; private set; }

        public VocabularyKey BaseCurrencyId { get; private set; }

        public VocabularyKey MaxRecordsForExportToExcel { get; private set; }

        public VocabularyKey PrivReportingGroupName { get; private set; }

        public VocabularyKey YearStartWeekCode { get; private set; }

        public VocabularyKey IsPresenceEnabled { get; private set; }

        public VocabularyKey IsDuplicateDetectionEnabled { get; private set; }

        public VocabularyKey BaseCurrencyIdName { get; private set; }

        public VocabularyKey IsPresenceEnabledName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ExpireSubscriptionsInDays { get; private set; }

        public VocabularyKey IsAuditEnabled { get; private set; }

        public VocabularyKey BaseCurrencyPrecision { get; private set; }

        public VocabularyKey BaseCurrencySymbol { get; private set; }

        public VocabularyKey BaseISOCurrencyCode { get; private set; }

        public VocabularyKey TraceLogMaximumAgeInDays { get; private set; }

        public VocabularyKey NextCustomObjectTypeCode { get; private set; }

        public VocabularyKey MaxRecordsForLookupFilters { get; private set; }

        public VocabularyKey AllowEntityOnlyAudit { get; private set; }

        public VocabularyKey DefaultRecurrenceEndRangeType { get; private set; }

        public VocabularyKey DefaultRecurrenceEndRangeTypeName { get; private set; }

        public VocabularyKey FutureExpansionWindow { get; private set; }

        public VocabularyKey PastExpansionWindow { get; private set; }

        public VocabularyKey RecurrenceExpansionSynchCreateMax { get; private set; }

        public VocabularyKey RecurrenceDefaultNumberOfOccurrences { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey GetStartedPaneContentEnabled { get; private set; }

        public VocabularyKey UseReadForm { get; private set; }

        public VocabularyKey InitialVersion { get; private set; }

        public VocabularyKey SampleDataImportId { get; private set; }

        public VocabularyKey ReportScriptErrors { get; private set; }

        public VocabularyKey ReportScriptErrorsName { get; private set; }

        public VocabularyKey RequireApprovalForUserEmail { get; private set; }

        public VocabularyKey RequireApprovalForQueueEmail { get; private set; }

        public VocabularyKey GoalRollupExpiryTime { get; private set; }

        public VocabularyKey GoalRollupFrequency { get; private set; }

        public VocabularyKey AutoApplyDefaultonCaseCreate { get; private set; }

        public VocabularyKey AutoApplyDefaultonCaseCreateName { get; private set; }

        public VocabularyKey AutoApplyDefaultonCaseUpdate { get; private set; }

        public VocabularyKey AutoApplyDefaultonCaseUpdateName { get; private set; }

        public VocabularyKey FiscalYearFormatPrefix { get; private set; }

        public VocabularyKey FiscalYearFormatPrefixName { get; private set; }

        public VocabularyKey FiscalYearFormatSuffix { get; private set; }

        public VocabularyKey FiscalYearFormatSuffixName { get; private set; }

        public VocabularyKey FiscalYearFormatYear { get; private set; }

        public VocabularyKey FiscalYearFormatYearName { get; private set; }

        public VocabularyKey DiscountCalculationMethod { get; private set; }

        public VocabularyKey FiscalPeriodFormatPeriod { get; private set; }

        public VocabularyKey FiscalPeriodFormatPeriodName { get; private set; }

        public VocabularyKey AllowClientMessageBarAd { get; private set; }

        public VocabularyKey AllowUserFormModePreference { get; private set; }

        public VocabularyKey HashFilterKeywords { get; private set; }

        public VocabularyKey HashMaxCount { get; private set; }

        public VocabularyKey HashDeltaSubjectCount { get; private set; }

        public VocabularyKey HashMinAddressCount { get; private set; }

        public VocabularyKey EnableSmartMatching { get; private set; }

        public VocabularyKey PinpointLanguageCode { get; private set; }

        public VocabularyKey OrgDbOrgSettings { get; private set; }

        public VocabularyKey IsUserAccessAuditEnabled { get; private set; }

        public VocabularyKey UserAccessAuditingInterval { get; private set; }

        public VocabularyKey QuickFindRecordLimitEnabled { get; private set; }

        public VocabularyKey EnableBingMapsIntegration { get; private set; }

        public VocabularyKey IsDefaultCountryCodeCheckEnabled { get; private set; }

        public VocabularyKey DefaultCountryCode { get; private set; }

        public VocabularyKey UseSkypeProtocol { get; private set; }

        public VocabularyKey IncomingEmailExchangeEmailRetrievalBatchSize { get; private set; }

        public VocabularyKey EmailCorrelationEnabled { get; private set; }

        public VocabularyKey MetadataSyncTimestamp { get; private set; }

        public VocabularyKey MetadataSyncLastTimeOfNeverExpiredDeletedObjects { get; private set; }

        public VocabularyKey YammerOAuthAccessTokenExpired { get; private set; }

        public VocabularyKey DefaultEmailSettings { get; private set; }

        public VocabularyKey YammerGroupId { get; private set; }

        public VocabularyKey YammerNetworkPermalink { get; private set; }

        public VocabularyKey YammerPostMethod { get; private set; }

        public VocabularyKey DefaultEmailServerProfileIdName { get; private set; }

        public VocabularyKey EmailConnectionChannel { get; private set; }

        public VocabularyKey DefaultEmailServerProfileId { get; private set; }

        public VocabularyKey IsAutoSaveEnabled { get; private set; }

        public VocabularyKey BingMapsApiKey { get; private set; }

        public VocabularyKey GenerateAlertsForErrors { get; private set; }

        public VocabularyKey GenerateAlertsForInformation { get; private set; }

        public VocabularyKey GenerateAlertsForWarnings { get; private set; }

        public VocabularyKey NotifyMailboxOwnerOfEmailServerLevelAlerts { get; private set; }

        public VocabularyKey MaximumActiveBusinessProcessFlowsAllowedPerEntity { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey AllowUsersSeeAppdownloadMessage { get; private set; }

        public VocabularyKey SignupOutlookDownloadFWLink { get; private set; }

        public VocabularyKey CascadeStatusUpdate { get; private set; }

        public VocabularyKey RestrictStatusUpdate { get; private set; }

        public VocabularyKey SuppressSLA { get; private set; }

        public VocabularyKey SocialInsightsTermsAccepted { get; private set; }

        public VocabularyKey SocialInsightsInstance { get; private set; }

        public VocabularyKey DisableSocialCare { get; private set; }

        public VocabularyKey MaxProductsInBundle { get; private set; }

        public VocabularyKey UseInbuiltRuleForDefaultPricelistSelection { get; private set; }

        public VocabularyKey OOBPriceCalculationEnabled { get; private set; }

        public VocabularyKey IsHierarchicalSecurityModelEnabled { get; private set; }

        public VocabularyKey MaximumDynamicPropertiesAllowed { get; private set; }

        public VocabularyKey UsePositionHierarchy { get; private set; }

        public VocabularyKey MaxDepthForHierarchicalSecurityModel { get; private set; }

        public VocabularyKey SlaPauseStates { get; private set; }

        public VocabularyKey SocialInsightsEnabled { get; private set; }

        public VocabularyKey IsAppointmentAttachmentSyncEnabled { get; private set; }

        public VocabularyKey IsAssignedTasksSyncEnabled { get; private set; }

        public VocabularyKey IsContactMailingAddressSyncEnabled { get; private set; }

        public VocabularyKey MaxSupportedInternetExplorerVersion { get; private set; }

        public VocabularyKey GlobalHelpUrl { get; private set; }

        public VocabularyKey GlobalHelpUrlEnabled { get; private set; }

        public VocabularyKey GlobalAppendUrlParametersEnabled { get; private set; }

        public VocabularyKey KMSettings { get; private set; }

        public VocabularyKey CreateProductsWithoutParentInActiveState { get; private set; }

        public VocabularyKey IsMailboxInactiveBackoffEnabled { get; private set; }

        public VocabularyKey IsFullTextSearchEnabled { get; private set; }

        public VocabularyKey EnforceReadOnlyPlugins { get; private set; }

        public VocabularyKey SharePointDeploymentType { get; private set; }

        public VocabularyKey OrganizationState { get; private set; }

        public VocabularyKey DefaultThemeData { get; private set; }

        public VocabularyKey IsFolderBasedTrackingEnabled { get; private set; }

        public VocabularyKey WebResourceHash { get; private set; }

        public VocabularyKey ExpireChangeTrackingInDays { get; private set; }

        public VocabularyKey MaxFolderBasedTrackingMappings { get; private set; }

        public VocabularyKey PrivacyStatementUrl { get; private set; }

        public VocabularyKey PluginTraceLogSetting { get; private set; }

        public VocabularyKey PluginTraceLogSettingName { get; private set; }

        public VocabularyKey IsMailboxForcedUnlockingEnabled { get; private set; }

        public VocabularyKey MailboxIntermittentIssueMinRange { get; private set; }

        public VocabularyKey MailboxPermanentIssueMinRange { get; private set; }

        public VocabularyKey HighContrastThemeData { get; private set; }

        public VocabularyKey DelegatedAdminUserId { get; private set; }

        public VocabularyKey IsExternalSearchIndexEnabled { get; private set; }

        public VocabularyKey IsMobileOfflineEnabled { get; private set; }

        public VocabularyKey IsOfficeGraphEnabled { get; private set; }

        public VocabularyKey IsOneDriveEnabled { get; private set; }

        public VocabularyKey ExternalPartyEntitySettings { get; private set; }

        public VocabularyKey ExternalPartyCorrelationKeys { get; private set; }

        public VocabularyKey MaxVerboseLoggingMailbox { get; private set; }

        public VocabularyKey MaxVerboseLoggingSyncCycles { get; private set; }

        public VocabularyKey MobileOfflineSyncInterval { get; private set; }

        public VocabularyKey OfficeGraphDelveUrl { get; private set; }

        public VocabularyKey MobileOfflineMinLicenseTrial { get; private set; }

        public VocabularyKey MobileOfflineMinLicenseProd { get; private set; }

        public VocabularyKey DaysSinceRecordLastModifiedMaxValue { get; private set; }

        public VocabularyKey TaskBasedFlowEnabled { get; private set; }

        public VocabularyKey ShowKBArticleDeprecationNotification { get; private set; }

        public VocabularyKey AzureSchedulerJobCollectionName { get; private set; }

        public VocabularyKey CortanaProactiveExperienceEnabled { get; private set; }

        public VocabularyKey OfficeAppsAutoDeploymentEnabled { get; private set; }

        public VocabularyKey AppDesignerExperienceEnabled { get; private set; }

        public VocabularyKey EnableImmersiveSkypeIntegration { get; private set; }

        public VocabularyKey AutoApplySLA { get; private set; }

        public VocabularyKey IsEmailServerProfileContentFilteringEnabled { get; private set; }

        public VocabularyKey IsDelegateAccessEnabled { get; private set; }

        public VocabularyKey DisplayNavigationTour { get; private set; }

        public VocabularyKey UseLegacyRendering { get; private set; }

        public VocabularyKey DefaultMobileOfflineProfileId { get; private set; }

        public VocabularyKey DefaultMobileOfflineProfileIdName { get; private set; }

        public VocabularyKey KaPrefix { get; private set; }

        public VocabularyKey CurrentKaNumber { get; private set; }

        public VocabularyKey CurrentCategoryNumber { get; private set; }

        public VocabularyKey CategoryPrefix { get; private set; }

        public VocabularyKey MaximumEntitiesWithActiveSLA { get; private set; }

        public VocabularyKey MaximumSLAKPIPerEntityWithActiveSLA { get; private set; }

        public VocabularyKey IsConflictDetectionEnabledForMobileClient { get; private set; }

        public VocabularyKey IsDelveActionHubIntegrationEnabled { get; private set; }

        public VocabularyKey OrgInsightsEnabled { get; private set; }

        public VocabularyKey ProductRecommendationsEnabled { get; private set; }

        public VocabularyKey TextAnalyticsEnabled { get; private set; }

        public VocabularyKey MaxConditionsForMobileOfflineFilters { get; private set; }

        public VocabularyKey IsFolderAutoCreatedonSP { get; private set; }

        public VocabularyKey PowerBiFeatureEnabled { get; private set; }

        public VocabularyKey IsActionCardEnabled { get; private set; }

        public VocabularyKey IsEmailMonitoringAllowed { get; private set; }

        public VocabularyKey IsActivityAnalysisEnabled { get; private set; }

        public VocabularyKey IsAutoDataCaptureEnabled { get; private set; }

        public VocabularyKey ExternalBaseUrl { get; private set; }

        public VocabularyKey IsPreviewEnabledForActionCard { get; private set; }

        public VocabularyKey IsPreviewForEmailMonitoringAllowed { get; private set; }

        public VocabularyKey UnresolveEmailAddressIfMultipleMatch { get; private set; }

        public VocabularyKey RiErrorStatus { get; private set; }

        public VocabularyKey WidgetProperties { get; private set; }

        public VocabularyKey EnableMicrosoftFlowIntegration { get; private set; }

        public VocabularyKey IsEnabledForAllRoles { get; private set; }

        public VocabularyKey IsPreviewForAutoCaptureEnabled { get; private set; }

        public VocabularyKey DefaultCrmCustomName { get; private set; }

        public VocabularyKey ACIWebEndpointUrl { get; private set; }

        public VocabularyKey EnableLPAuthoring { get; private set; }

        public VocabularyKey IsResourceBookingExchangeSyncEnabled { get; private set; }

        public VocabularyKey IsMobileClientOnDemandSyncEnabled { get; private set; }

        public VocabularyKey PostMessageWhitelistDomains { get; private set; }

        public VocabularyKey IsRelationshipInsightsEnabled { get; private set; }

        public VocabularyKey ResolveSimilarUnresolvedEmailAddress { get; private set; }

        public VocabularyKey IsTextWrapEnabled { get; private set; }

        public VocabularyKey SessionTimeoutEnabled { get; private set; }

        public VocabularyKey SessionTimeoutInMins { get; private set; }

        public VocabularyKey SessionTimeoutReminderInMins { get; private set; }

        public VocabularyKey MicrosoftFlowEnvironment { get; private set; }

        public VocabularyKey InactivityTimeoutEnabled { get; private set; }

        public VocabularyKey InactivityTimeoutInMins { get; private set; }

        public VocabularyKey InactivityTimeoutReminderInMins { get; private set; }

        public VocabularyKey SyncOptInSelection { get; private set; }

        public VocabularyKey SyncOptInSelectionStatus { get; private set; }

        public VocabularyKey IsActionSupportFeatureEnabled { get; private set; }

        public VocabularyKey IsBPFEntityCustomizationFeatureEnabled { get; private set; }

        public VocabularyKey BoundDashboardDefaultCardExpanded { get; private set; }

        public VocabularyKey MaxActionStepsInBPF { get; private set; }

        public VocabularyKey ServeStaticResourcesFromAzureCDN { get; private set; }

        public VocabularyKey IsExternalFileStorageEnabled { get; private set; }

        public VocabularyKey ClientFeatureSet { get; private set; }

        public VocabularyKey IsReadAuditEnabled { get; private set; }

        public VocabularyKey IsNotesAnalysisEnabled { get; private set; }

        public VocabularyKey AllowLegacyDialogsEmbedding { get; private set; }

        public VocabularyKey AllowLegacyClientExperience { get; private set; }

        public VocabularyKey IsMSTeamsEnabled { get; private set; }

        public VocabularyKey IsLUISEnabledforD365Bot { get; private set; }

        public VocabularyKey SyncBulkOperationBatchSize { get; private set; }

        public VocabularyKey SyncBulkOperationMaxLimit { get; private set; }

        public VocabularyKey EnableUnifiedInterfaceShellRefresh { get; private set; }

        public VocabularyKey IsMSTeamsSettingChangedByUser { get; private set; }

        public VocabularyKey EnableLivePersonaCardUCI { get; private set; }

        public VocabularyKey IsMSTeamsCollaborationEnabled { get; private set; }

        public VocabularyKey IsMSTeamsUserSyncEnabled { get; private set; }

        public VocabularyKey IsManualSalesForecastingEnabled { get; private set; }

        public VocabularyKey IsPDFGenerationEnabled { get; private set; }

        public VocabularyKey IsCustomControlsInCanvasAppsEnabled { get; private set; }

        public VocabularyKey IsPAIEnabled { get; private set; }

        public VocabularyKey IsQuickCreateEnabledForOpportunityClose { get; private set; }

        public VocabularyKey ContentSecurityPolicyConfiguration { get; private set; }

        public VocabularyKey IsContentSecurityPolicyEnabled { get; private set; }

        public VocabularyKey IsPriceListMandatory { get; private set; }

        public VocabularyKey EnableLivePersonCardIntegrationInOffice { get; private set; }

        public VocabularyKey IsContextualEmailEnabled { get; private set; }

        public VocabularyKey QualifyLeadAdditionalOptions { get; private set; }

        public VocabularyKey BusinessCardOptions { get; private set; }

        public VocabularyKey IsPlaybookEnabled { get; private set; }

        public VocabularyKey PaiPreviewScenarioEnabled { get; private set; }

        public VocabularyKey IsContextualHelpEnabled { get; private set; }

        public VocabularyKey IsSalesAssistantEnabled { get; private set; }

        public VocabularyKey IsAutoDataCaptureV2Enabled { get; private set; }

        public VocabularyKey IsNewAddProductExperienceEnabled { get; private set; }

        public VocabularyKey AuditRetentionPeriod { get; private set; }

        public VocabularyKey UseQuickFindViewForGridSearch { get; private set; }

        public VocabularyKey IsRichTextNotesEnabled { get; private set; }

        public VocabularyKey SendBulkEmailInUCI { get; private set; }

        public VocabularyKey IsAllMoneyDecimal { get; private set; }

        public VocabularyKey IsWriteInProductsAllowed { get; private set; }

        public VocabularyKey AppointmentRichEditorExperience { get; private set; }

        public VocabularyKey appointmentricheditorexperienceName { get; private set; }

        public VocabularyKey SchedulingEngine { get; private set; }

        public VocabularyKey schedulingengineName { get; private set; }


    }
}

