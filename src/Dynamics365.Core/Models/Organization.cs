using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Organization : DynamicsModel
    {
        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("usergroupid")]
        public Guid? UserGroupId { get; set; }

        [JsonProperty("privilegeusergroupid")]
        public Guid? PrivilegeUserGroupId { get; set; }

        [JsonProperty("recurrenceexpansionjobbatchsize")]
        public long? RecurrenceExpansionJobBatchSize { get; set; }

        [JsonProperty("recurrenceexpansionjobbatchinterval")]
        public long? RecurrenceExpansionJobBatchInterval { get; set; }

        [JsonProperty("fiscalperiodtype")]
        public long? FiscalPeriodType { get; set; }

        [JsonProperty("fiscalcalendarstart")]
        public DateTimeOffset? FiscalCalendarStart { get; set; }

        [JsonProperty("dateformatcode")]
        public string DateFormatCode { get; set; }

        [JsonProperty("timeformatcode")]
        public string TimeFormatCode { get; set; }

        [JsonProperty("currencysymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("weekstartdaycode")]
        public string WeekStartDayCode { get; set; }

        [JsonProperty("dateseparator")]
        public string DateSeparator { get; set; }

        [JsonProperty("fullnameconventioncode")]
        public string FullNameConventionCode { get; set; }

        [JsonProperty("negativeformatcode")]
        public string NegativeFormatCode { get; set; }

        [JsonProperty("numberformat")]
        public string NumberFormat { get; set; }

        [JsonProperty("isdisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("disabledreason")]
        public string DisabledReason { get; set; }

        [JsonProperty("kbprefix")]
        public string KbPrefix { get; set; }

        [JsonProperty("currentkbnumber")]
        public long? CurrentKbNumber { get; set; }

        [JsonProperty("caseprefix")]
        public string CasePrefix { get; set; }

        [JsonProperty("currentcasenumber")]
        public long? CurrentCaseNumber { get; set; }

        [JsonProperty("contractprefix")]
        public string ContractPrefix { get; set; }

        [JsonProperty("currentcontractnumber")]
        public long? CurrentContractNumber { get; set; }

        [JsonProperty("quoteprefix")]
        public string QuotePrefix { get; set; }

        [JsonProperty("currentquotenumber")]
        public long? CurrentQuoteNumber { get; set; }

        [JsonProperty("orderprefix")]
        public string OrderPrefix { get; set; }

        [JsonProperty("currentordernumber")]
        public long? CurrentOrderNumber { get; set; }

        [JsonProperty("invoiceprefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("currentinvoicenumber")]
        public long? CurrentInvoiceNumber { get; set; }

        [JsonProperty("uniquespecifierlength")]
        public long? UniqueSpecifierLength { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("fiscalyearformat")]
        public string FiscalYearFormat { get; set; }

        [JsonProperty("fiscalperiodformat")]
        public string FiscalPeriodFormat { get; set; }

        [JsonProperty("fiscalyearperiodconnect")]
        public string FiscalYearPeriodConnect { get; set; }

        [JsonProperty("languagecode")]
        public long? LanguageCode { get; set; }

        [JsonProperty("sortid")]
        public long? SortId { get; set; }

        [JsonProperty("dateformatstring")]
        public string DateFormatString { get; set; }

        [JsonProperty("timeformatstring")]
        public string TimeFormatString { get; set; }

        [JsonProperty("pricingdecimalprecision")]
        public long? PricingDecimalPrecision { get; set; }

        [JsonProperty("showweeknumber")]
        public bool? ShowWeekNumber { get; set; }

        [JsonProperty("showweeknumbername")]
        public string ShowWeekNumberName { get; set; }

        [JsonProperty("isdisabledname")]
        public string IsDisabledName { get; set; }

        [JsonProperty("dateformatcodename")]
        public string DateFormatCodeName { get; set; }

        [JsonProperty("fullnameconventioncodename")]
        public string FullNameConventionCodeName { get; set; }

        [JsonProperty("languagecodename")]
        public string LanguageCodeName { get; set; }

        [JsonProperty("timeformatcodename")]
        public string TimeFormatCodeName { get; set; }

        [JsonProperty("negativeformatcodename")]
        public string NegativeFormatCodeName { get; set; }

        [JsonProperty("weekstartdaycodename")]
        public string WeekStartDayCodeName { get; set; }

        [JsonProperty("nexttrackingnumber")]
        public long? NextTrackingNumber { get; set; }

        [JsonProperty("tagmaxaggressivecycles")]
        public long? TagMaxAggressiveCycles { get; set; }

        [JsonProperty("tokenkey")]
        public string TokenKey { get; set; }

        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("grantaccesstonetworkservice")]
        public bool? GrantAccessToNetworkService { get; set; }

        [JsonProperty("allowoutlookscheduledsyncs")]
        public bool? AllowOutlookScheduledSyncs { get; set; }

        [JsonProperty("allowmarketingemailexecution")]
        public bool? AllowMarketingEmailExecution { get; set; }

        [JsonProperty("sqlaccessgroupid")]
        public Guid? SqlAccessGroupId { get; set; }

        [JsonProperty("currencyformatcode")]
        public string CurrencyFormatCode { get; set; }

        [JsonProperty("fiscalsettingsupdated")]
        public bool? FiscalSettingsUpdated { get; set; }

        [JsonProperty("reportinggroupid")]
        public Guid? ReportingGroupId { get; set; }

        [JsonProperty("tokenexpiry")]
        public long? TokenExpiry { get; set; }

        [JsonProperty("sharetopreviousowneronassign")]
        public bool? ShareToPreviousOwnerOnAssign { get; set; }

        [JsonProperty("acknowledgementtemplateid")]
        public string AcknowledgementTemplateId { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("integrationuserid")]
        public Guid? IntegrationUserId { get; set; }

        [JsonProperty("trackingtokenidbase")]
        public long? TrackingTokenIdBase { get; set; }

        [JsonProperty("businessclosurecalendarid")]
        public Guid? BusinessClosureCalendarId { get; set; }

        [JsonProperty("allowautounsubscribeacknowledgement")]
        public bool? AllowAutoUnsubscribeAcknowledgement { get; set; }

        [JsonProperty("allowautounsubscribe")]
        public bool? AllowAutoUnsubscribe { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("trackingprefix")]
        public string TrackingPrefix { get; set; }

        [JsonProperty("minoutlooksyncinterval")]
        public long? MinOutlookSyncInterval { get; set; }

        [JsonProperty("bulkoperationprefix")]
        public string BulkOperationPrefix { get; set; }

        [JsonProperty("allowautoresponsecreation")]
        public bool? AllowAutoResponseCreation { get; set; }

        [JsonProperty("maximumtrackingnumber")]
        public long? MaximumTrackingNumber { get; set; }

        [JsonProperty("campaignprefix")]
        public string CampaignPrefix { get; set; }

        [JsonProperty("sqlaccessgroupname")]
        public string SqlAccessGroupName { get; set; }

        [JsonProperty("currentcampaignnumber")]
        public long? CurrentCampaignNumber { get; set; }

        [JsonProperty("fiscalyeardisplaycode")]
        public long? FiscalYearDisplayCode { get; set; }

        [JsonProperty("sitemapxml")]
        public string SiteMapXml { get; set; }

        [JsonProperty("reportinggroupname")]
        public string ReportingGroupName { get; set; }

        [JsonProperty("currentbulkoperationnumber")]
        public long? CurrentBulkOperationNumber { get; set; }

        [JsonProperty("schemanameprefix")]
        public string SchemaNamePrefix { get; set; }

        [JsonProperty("ignoreinternalemail")]
        public bool? IgnoreInternalEmail { get; set; }

        [JsonProperty("tagpollingperiod")]
        public long? TagPollingPeriod { get; set; }

        [JsonProperty("trackingtokeniddigits")]
        public long? TrackingTokenIdDigits { get; set; }

        [JsonProperty("acknowledgementtemplateidname")]
        public string AcknowledgementTemplateIdName { get; set; }

        [JsonProperty("currencyformatcodename")]
        public string CurrencyFormatCodeName { get; set; }

        [JsonProperty("fiscalsettingsupdatedname")]
        public string FiscalSettingsUpdatedName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("numbergroupformat")]
        public string NumberGroupFormat { get; set; }

        [JsonProperty("longdateformatcode")]
        public long? LongDateFormatCode { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("currentimportsequencenumber")]
        public long? CurrentImportSequenceNumber { get; set; }

        [JsonProperty("parsedtableprefix")]
        public string ParsedTablePrefix { get; set; }

        [JsonProperty("v3calloutconfighash")]
        public string V3CalloutConfigHash { get; set; }

        [JsonProperty("isfiscalperiodmonthbased")]
        public bool? IsFiscalPeriodMonthBased { get; set; }

        [JsonProperty("localeid")]
        public long? LocaleId { get; set; }

        [JsonProperty("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix { get; set; }

        [JsonProperty("supportuserid")]
        public Guid? SupportUserId { get; set; }

        [JsonProperty("amdesignator")]
        public string AMDesignator { get; set; }

        [JsonProperty("currencydisplayoption")]
        public string CurrencyDisplayOption { get; set; }

        [JsonProperty("minaddressbooksyncinterval")]
        public long? MinAddressBookSyncInterval { get; set; }

        [JsonProperty("isduplicatedetectionenabledforonlinecreateupdate")]
        public bool? IsDuplicateDetectionEnabledForOnlineCreateUpdate { get; set; }

        [JsonProperty("featureset")]
        public string FeatureSet { get; set; }

        [JsonProperty("blockedattachments")]
        public string BlockedAttachments { get; set; }

        [JsonProperty("isduplicatedetectionenabledforofflinesync")]
        public bool? IsDuplicateDetectionEnabledForOfflineSync { get; set; }

        [JsonProperty("allowofflinescheduledsyncs")]
        public bool? AllowOfflineScheduledSyncs { get; set; }

        [JsonProperty("allowunresolvedpartiesonemailsend")]
        public bool? AllowUnresolvedPartiesOnEmailSend { get; set; }

        [JsonProperty("timeseparator")]
        public string TimeSeparator { get; set; }

        [JsonProperty("currentparsedtablenumber")]
        public long? CurrentParsedTableNumber { get; set; }

        [JsonProperty("minofflinesyncinterval")]
        public long? MinOfflineSyncInterval { get; set; }

        [JsonProperty("allowwebexcelexport")]
        public bool? AllowWebExcelExport { get; set; }

        [JsonProperty("referencesitemapxml")]
        public string ReferenceSiteMapXml { get; set; }

        [JsonProperty("isduplicatedetectionenabledforimport")]
        public bool? IsDuplicateDetectionEnabledForImport { get; set; }

        [JsonProperty("calendartype")]
        public long? CalendarType { get; set; }

        [JsonProperty("sqmenabled")]
        public bool? SQMEnabled { get; set; }

        [JsonProperty("negativecurrencyformatcode")]
        public long? NegativeCurrencyFormatCode { get; set; }

        [JsonProperty("allowaddressbooksyncs")]
        public bool? AllowAddressBookSyncs { get; set; }

        [JsonProperty("isvintegrationcode")]
        public string ISVIntegrationCode { get; set; }

        [JsonProperty("decimalsymbol")]
        public string DecimalSymbol { get; set; }

        [JsonProperty("maxuploadfilesize")]
        public long? MaxUploadFileSize { get; set; }

        [JsonProperty("isappmode")]
        public bool? IsAppMode { get; set; }

        [JsonProperty("enablepricingoncreate")]
        public bool? EnablePricingOnCreate { get; set; }

        [JsonProperty("issopintegrationenabled")]
        public bool? IsSOPIntegrationEnabled { get; set; }

        [JsonProperty("pmdesignator")]
        public string PMDesignator { get; set; }

        [JsonProperty("currencydecimalprecision")]
        public long? CurrencyDecimalPrecision { get; set; }

        [JsonProperty("maxappointmentdurationdays")]
        public long? MaxAppointmentDurationDays { get; set; }

        [JsonProperty("emailsendpollingperiod")]
        public long? EmailSendPollingPeriod { get; set; }

        [JsonProperty("rendersecureiframeforemail")]
        public bool? RenderSecureIFrameForEmail { get; set; }

        [JsonProperty("numberseparator")]
        public string NumberSeparator { get; set; }

        [JsonProperty("privreportinggroupid")]
        public Guid? PrivReportingGroupId { get; set; }

        [JsonProperty("basecurrencyid")]
        public string BaseCurrencyId { get; set; }

        [JsonProperty("maxrecordsforexporttoexcel")]
        public long? MaxRecordsForExportToExcel { get; set; }

        [JsonProperty("privreportinggroupname")]
        public string PrivReportingGroupName { get; set; }

        [JsonProperty("yearstartweekcode")]
        public long? YearStartWeekCode { get; set; }

        [JsonProperty("ispresenceenabled")]
        public bool? IsPresenceEnabled { get; set; }

        [JsonProperty("isduplicatedetectionenabled")]
        public bool? IsDuplicateDetectionEnabled { get; set; }

        [JsonProperty("basecurrencyidname")]
        public string BaseCurrencyIdName { get; set; }

        [JsonProperty("ispresenceenabledname")]
        public string IsPresenceEnabledName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("expiresubscriptionsindays")]
        public long? ExpireSubscriptionsInDays { get; set; }

        [JsonProperty("isauditenabled")]
        public bool? IsAuditEnabled { get; set; }

        [JsonProperty("basecurrencyprecision")]
        public long? BaseCurrencyPrecision { get; set; }

        [JsonProperty("basecurrencysymbol")]
        public string BaseCurrencySymbol { get; set; }

        [JsonProperty("baseisocurrencycode")]
        public string BaseISOCurrencyCode { get; set; }

        [JsonProperty("tracelogmaximumageindays")]
        public long? TraceLogMaximumAgeInDays { get; set; }

        [JsonProperty("nextcustomobjecttypecode")]
        public long? NextCustomObjectTypeCode { get; set; }

        [JsonProperty("maxrecordsforlookupfilters")]
        public long? MaxRecordsForLookupFilters { get; set; }

        [JsonProperty("allowentityonlyaudit")]
        public bool? AllowEntityOnlyAudit { get; set; }

        [JsonProperty("defaultrecurrenceendrangetype")]
        public string DefaultRecurrenceEndRangeType { get; set; }

        [JsonProperty("defaultrecurrenceendrangetypename")]
        public string DefaultRecurrenceEndRangeTypeName { get; set; }

        [JsonProperty("futureexpansionwindow")]
        public long? FutureExpansionWindow { get; set; }

        [JsonProperty("pastexpansionwindow")]
        public long? PastExpansionWindow { get; set; }

        [JsonProperty("recurrenceexpansionsynchcreatemax")]
        public long? RecurrenceExpansionSynchCreateMax { get; set; }

        [JsonProperty("recurrencedefaultnumberofoccurrences")]
        public long? RecurrenceDefaultNumberOfOccurrences { get; set; }

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

        [JsonProperty("getstartedpanecontentenabled")]
        public bool? GetStartedPaneContentEnabled { get; set; }

        [JsonProperty("usereadform")]
        public bool? UseReadForm { get; set; }

        [JsonProperty("initialversion")]
        public string InitialVersion { get; set; }

        [JsonProperty("sampledataimportid")]
        public Guid? SampleDataImportId { get; set; }

        [JsonProperty("reportscripterrors")]
        public string ReportScriptErrors { get; set; }

        [JsonProperty("reportscripterrorsname")]
        public string ReportScriptErrorsName { get; set; }

        [JsonProperty("requireapprovalforuseremail")]
        public bool? RequireApprovalForUserEmail { get; set; }

        [JsonProperty("requireapprovalforqueueemail")]
        public bool? RequireApprovalForQueueEmail { get; set; }

        [JsonProperty("goalrollupexpirytime")]
        public long? GoalRollupExpiryTime { get; set; }

        [JsonProperty("goalrollupfrequency")]
        public long? GoalRollupFrequency { get; set; }

        [JsonProperty("autoapplydefaultoncasecreate")]
        public bool? AutoApplyDefaultonCaseCreate { get; set; }

        [JsonProperty("autoapplydefaultoncasecreatename")]
        public string AutoApplyDefaultonCaseCreateName { get; set; }

        [JsonProperty("autoapplydefaultoncaseupdate")]
        public bool? AutoApplyDefaultonCaseUpdate { get; set; }

        [JsonProperty("autoapplydefaultoncaseupdatename")]
        public string AutoApplyDefaultonCaseUpdateName { get; set; }

        [JsonProperty("fiscalyearformatprefix")]
        public string FiscalYearFormatPrefix { get; set; }

        [JsonProperty("fiscalyearformatprefixname")]
        public string FiscalYearFormatPrefixName { get; set; }

        [JsonProperty("fiscalyearformatsuffix")]
        public string FiscalYearFormatSuffix { get; set; }

        [JsonProperty("fiscalyearformatsuffixname")]
        public string FiscalYearFormatSuffixName { get; set; }

        [JsonProperty("fiscalyearformatyear")]
        public string FiscalYearFormatYear { get; set; }

        [JsonProperty("fiscalyearformatyearname")]
        public string FiscalYearFormatYearName { get; set; }

        [JsonProperty("discountcalculationmethod")]
        public string DiscountCalculationMethod { get; set; }

        [JsonProperty("fiscalperiodformatperiod")]
        public string FiscalPeriodFormatPeriod { get; set; }

        [JsonProperty("fiscalperiodformatperiodname")]
        public string FiscalPeriodFormatPeriodName { get; set; }

        [JsonProperty("allowclientmessagebarad")]
        public bool? AllowClientMessageBarAd { get; set; }

        [JsonProperty("allowuserformmodepreference")]
        public bool? AllowUserFormModePreference { get; set; }

        [JsonProperty("hashfilterkeywords")]
        public string HashFilterKeywords { get; set; }

        [JsonProperty("hashmaxcount")]
        public long? HashMaxCount { get; set; }

        [JsonProperty("hashdeltasubjectcount")]
        public long? HashDeltaSubjectCount { get; set; }

        [JsonProperty("hashminaddresscount")]
        public long? HashMinAddressCount { get; set; }

        [JsonProperty("enablesmartmatching")]
        public bool? EnableSmartMatching { get; set; }

        [JsonProperty("pinpointlanguagecode")]
        public long? PinpointLanguageCode { get; set; }

        [JsonProperty("orgdborgsettings")]
        public string OrgDbOrgSettings { get; set; }

        [JsonProperty("isuseraccessauditenabled")]
        public bool? IsUserAccessAuditEnabled { get; set; }

        [JsonProperty("useraccessauditinginterval")]
        public long? UserAccessAuditingInterval { get; set; }

        [JsonProperty("quickfindrecordlimitenabled")]
        public bool? QuickFindRecordLimitEnabled { get; set; }

        [JsonProperty("enablebingmapsintegration")]
        public bool? EnableBingMapsIntegration { get; set; }

        [JsonProperty("isdefaultcountrycodecheckenabled")]
        public bool? IsDefaultCountryCodeCheckEnabled { get; set; }

        [JsonProperty("defaultcountrycode")]
        public string DefaultCountryCode { get; set; }

        [JsonProperty("useskypeprotocol")]
        public bool? UseSkypeProtocol { get; set; }

        [JsonProperty("incomingemailexchangeemailretrievalbatchsize")]
        public long? IncomingEmailExchangeEmailRetrievalBatchSize { get; set; }

        [JsonProperty("emailcorrelationenabled")]
        public bool? EmailCorrelationEnabled { get; set; }

        [JsonProperty("metadatasynctimestamp")]
        public int? MetadataSyncTimestamp { get; set; }

        [JsonProperty("metadatasynclasttimeofneverexpireddeletedobjects")]
        public DateTimeOffset? MetadataSyncLastTimeOfNeverExpiredDeletedObjects { get; set; }

        [JsonProperty("yammeroauthaccesstokenexpired")]
        public bool? YammerOAuthAccessTokenExpired { get; set; }

        [JsonProperty("defaultemailsettings")]
        public string DefaultEmailSettings { get; set; }

        [JsonProperty("yammergroupid")]
        public long? YammerGroupId { get; set; }

        [JsonProperty("yammernetworkpermalink")]
        public string YammerNetworkPermalink { get; set; }

        [JsonProperty("yammerpostmethod")]
        public string YammerPostMethod { get; set; }

        [JsonProperty("defaultemailserverprofileidname")]
        public string DefaultEmailServerProfileIdName { get; set; }

        [JsonProperty("emailconnectionchannel")]
        public string EmailConnectionChannel { get; set; }

        [JsonProperty("defaultemailserverprofileid")]
        public string DefaultEmailServerProfileId { get; set; }

        [JsonProperty("isautosaveenabled")]
        public bool? IsAutoSaveEnabled { get; set; }

        [JsonProperty("bingmapsapikey")]
        public string BingMapsApiKey { get; set; }

        [JsonProperty("generatealertsforerrors")]
        public bool? GenerateAlertsForErrors { get; set; }

        [JsonProperty("generatealertsforinformation")]
        public bool? GenerateAlertsForInformation { get; set; }

        [JsonProperty("generatealertsforwarnings")]
        public bool? GenerateAlertsForWarnings { get; set; }

        [JsonProperty("notifymailboxownerofemailserverlevelalerts")]
        public bool? NotifyMailboxOwnerOfEmailServerLevelAlerts { get; set; }

        [JsonProperty("maximumactivebusinessprocessflowsallowedperentity")]
        public long? MaximumActiveBusinessProcessFlowsAllowedPerEntity { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("allowusersseeappdownloadmessage")]
        public bool? AllowUsersSeeAppdownloadMessage { get; set; }

        [JsonProperty("signupoutlookdownloadfwlink")]
        public string SignupOutlookDownloadFWLink { get; set; }

        [JsonProperty("cascadestatusupdate")]
        public bool? CascadeStatusUpdate { get; set; }

        [JsonProperty("restrictstatusupdate")]
        public bool? RestrictStatusUpdate { get; set; }

        [JsonProperty("suppresssla")]
        public bool? SuppressSLA { get; set; }

        [JsonProperty("socialinsightstermsaccepted")]
        public bool? SocialInsightsTermsAccepted { get; set; }

        [JsonProperty("socialinsightsinstance")]
        public string SocialInsightsInstance { get; set; }

        [JsonProperty("disablesocialcare")]
        public bool? DisableSocialCare { get; set; }

        [JsonProperty("maxproductsinbundle")]
        public long? MaxProductsInBundle { get; set; }

        [JsonProperty("useinbuiltrulefordefaultpricelistselection")]
        public bool? UseInbuiltRuleForDefaultPricelistSelection { get; set; }

        [JsonProperty("oobpricecalculationenabled")]
        public bool? OOBPriceCalculationEnabled { get; set; }

        [JsonProperty("ishierarchicalsecuritymodelenabled")]
        public bool? IsHierarchicalSecurityModelEnabled { get; set; }

        [JsonProperty("maximumdynamicpropertiesallowed")]
        public long? MaximumDynamicPropertiesAllowed { get; set; }

        [JsonProperty("usepositionhierarchy")]
        public bool? UsePositionHierarchy { get; set; }

        [JsonProperty("maxdepthforhierarchicalsecuritymodel")]
        public long? MaxDepthForHierarchicalSecurityModel { get; set; }

        [JsonProperty("slapausestates")]
        public string SlaPauseStates { get; set; }

        [JsonProperty("socialinsightsenabled")]
        public bool? SocialInsightsEnabled { get; set; }

        [JsonProperty("isappointmentattachmentsyncenabled")]
        public bool? IsAppointmentAttachmentSyncEnabled { get; set; }

        [JsonProperty("isassignedtaskssyncenabled")]
        public bool? IsAssignedTasksSyncEnabled { get; set; }

        [JsonProperty("iscontactmailingaddresssyncenabled")]
        public bool? IsContactMailingAddressSyncEnabled { get; set; }

        [JsonProperty("maxsupportedinternetexplorerversion")]
        public long? MaxSupportedInternetExplorerVersion { get; set; }

        [JsonProperty("globalhelpurl")]
        public string GlobalHelpUrl { get; set; }

        [JsonProperty("globalhelpurlenabled")]
        public bool? GlobalHelpUrlEnabled { get; set; }

        [JsonProperty("globalappendurlparametersenabled")]
        public bool? GlobalAppendUrlParametersEnabled { get; set; }

        [JsonProperty("kmsettings")]
        public string KMSettings { get; set; }

        [JsonProperty("createproductswithoutparentinactivestate")]
        public bool? CreateProductsWithoutParentInActiveState { get; set; }

        [JsonProperty("ismailboxinactivebackoffenabled")]
        public bool? IsMailboxInactiveBackoffEnabled { get; set; }

        [JsonProperty("isfulltextsearchenabled")]
        public bool? IsFullTextSearchEnabled { get; set; }

        [JsonProperty("enforcereadonlyplugins")]
        public bool? EnforceReadOnlyPlugins { get; set; }

        [JsonProperty("sharepointdeploymenttype")]
        public string SharePointDeploymentType { get; set; }

        [JsonProperty("organizationstate")]
        public string OrganizationState { get; set; }

        [JsonProperty("defaultthemedata")]
        public string DefaultThemeData { get; set; }

        [JsonProperty("isfolderbasedtrackingenabled")]
        public bool? IsFolderBasedTrackingEnabled { get; set; }

        [JsonProperty("webresourcehash")]
        public string WebResourceHash { get; set; }

        [JsonProperty("expirechangetrackingindays")]
        public long? ExpireChangeTrackingInDays { get; set; }

        [JsonProperty("maxfolderbasedtrackingmappings")]
        public long? MaxFolderBasedTrackingMappings { get; set; }

        [JsonProperty("privacystatementurl")]
        public string PrivacyStatementUrl { get; set; }

        [JsonProperty("plugintracelogsetting")]
        public string PluginTraceLogSetting { get; set; }

        [JsonProperty("plugintracelogsettingname")]
        public string PluginTraceLogSettingName { get; set; }

        [JsonProperty("ismailboxforcedunlockingenabled")]
        public bool? IsMailboxForcedUnlockingEnabled { get; set; }

        [JsonProperty("mailboxintermittentissueminrange")]
        public long? MailboxIntermittentIssueMinRange { get; set; }

        [JsonProperty("mailboxpermanentissueminrange")]
        public long? MailboxPermanentIssueMinRange { get; set; }

        [JsonProperty("highcontrastthemedata")]
        public string HighContrastThemeData { get; set; }

        [JsonProperty("delegatedadminuserid")]
        public Guid? DelegatedAdminUserId { get; set; }

        [JsonProperty("isexternalsearchindexenabled")]
        public bool? IsExternalSearchIndexEnabled { get; set; }

        [JsonProperty("ismobileofflineenabled")]
        public bool? IsMobileOfflineEnabled { get; set; }

        [JsonProperty("isofficegraphenabled")]
        public bool? IsOfficeGraphEnabled { get; set; }

        [JsonProperty("isonedriveenabled")]
        public bool? IsOneDriveEnabled { get; set; }

        [JsonProperty("externalpartyentitysettings")]
        public string ExternalPartyEntitySettings { get; set; }

        [JsonProperty("externalpartycorrelationkeys")]
        public string ExternalPartyCorrelationKeys { get; set; }

        [JsonProperty("maxverboseloggingmailbox")]
        public long? MaxVerboseLoggingMailbox { get; set; }

        [JsonProperty("maxverboseloggingsynccycles")]
        public long? MaxVerboseLoggingSyncCycles { get; set; }

        [JsonProperty("mobileofflinesyncinterval")]
        public long? MobileOfflineSyncInterval { get; set; }

        [JsonProperty("officegraphdelveurl")]
        public string OfficeGraphDelveUrl { get; set; }

        [JsonProperty("mobileofflineminlicensetrial")]
        public long? MobileOfflineMinLicenseTrial { get; set; }

        [JsonProperty("mobileofflineminlicenseprod")]
        public long? MobileOfflineMinLicenseProd { get; set; }

        [JsonProperty("dayssincerecordlastmodifiedmaxvalue")]
        public long? DaysSinceRecordLastModifiedMaxValue { get; set; }

        [JsonProperty("taskbasedflowenabled")]
        public bool? TaskBasedFlowEnabled { get; set; }

        [JsonProperty("showkbarticledeprecationnotification")]
        public bool? ShowKBArticleDeprecationNotification { get; set; }

        [JsonProperty("azureschedulerjobcollectionname")]
        public string AzureSchedulerJobCollectionName { get; set; }

        [JsonProperty("cortanaproactiveexperienceenabled")]
        public bool? CortanaProactiveExperienceEnabled { get; set; }

        [JsonProperty("officeappsautodeploymentenabled")]
        public bool? OfficeAppsAutoDeploymentEnabled { get; set; }

        [JsonProperty("appdesignerexperienceenabled")]
        public bool? AppDesignerExperienceEnabled { get; set; }

        [JsonProperty("enableimmersiveskypeintegration")]
        public bool? EnableImmersiveSkypeIntegration { get; set; }

        [JsonProperty("autoapplysla")]
        public bool? AutoApplySLA { get; set; }

        [JsonProperty("isemailserverprofilecontentfilteringenabled")]
        public bool? IsEmailServerProfileContentFilteringEnabled { get; set; }

        [JsonProperty("isdelegateaccessenabled")]
        public bool? IsDelegateAccessEnabled { get; set; }

        [JsonProperty("displaynavigationtour")]
        public bool? DisplayNavigationTour { get; set; }

        [JsonProperty("uselegacyrendering")]
        public bool? UseLegacyRendering { get; set; }

        [JsonProperty("defaultmobileofflineprofileid")]
        public string DefaultMobileOfflineProfileId { get; set; }

        [JsonProperty("defaultmobileofflineprofileidname")]
        public string DefaultMobileOfflineProfileIdName { get; set; }

        [JsonProperty("kaprefix")]
        public string KaPrefix { get; set; }

        [JsonProperty("currentkanumber")]
        public long? CurrentKaNumber { get; set; }

        [JsonProperty("currentcategorynumber")]
        public long? CurrentCategoryNumber { get; set; }

        [JsonProperty("categoryprefix")]
        public string CategoryPrefix { get; set; }

        [JsonProperty("maximumentitieswithactivesla")]
        public long? MaximumEntitiesWithActiveSLA { get; set; }

        [JsonProperty("maximumslakpiperentitywithactivesla")]
        public long? MaximumSLAKPIPerEntityWithActiveSLA { get; set; }

        [JsonProperty("isconflictdetectionenabledformobileclient")]
        public bool? IsConflictDetectionEnabledForMobileClient { get; set; }

        [JsonProperty("isdelveactionhubintegrationenabled")]
        public bool? IsDelveActionHubIntegrationEnabled { get; set; }

        [JsonProperty("orginsightsenabled")]
        public bool? OrgInsightsEnabled { get; set; }

        [JsonProperty("productrecommendationsenabled")]
        public bool? ProductRecommendationsEnabled { get; set; }

        [JsonProperty("textanalyticsenabled")]
        public bool? TextAnalyticsEnabled { get; set; }

        [JsonProperty("maxconditionsformobileofflinefilters")]
        public long? MaxConditionsForMobileOfflineFilters { get; set; }

        [JsonProperty("isfolderautocreatedonsp")]
        public bool? IsFolderAutoCreatedonSP { get; set; }

        [JsonProperty("powerbifeatureenabled")]
        public bool? PowerBiFeatureEnabled { get; set; }

        [JsonProperty("isactioncardenabled")]
        public bool? IsActionCardEnabled { get; set; }

        [JsonProperty("isemailmonitoringallowed")]
        public bool? IsEmailMonitoringAllowed { get; set; }

        [JsonProperty("isactivityanalysisenabled")]
        public bool? IsActivityAnalysisEnabled { get; set; }

        [JsonProperty("isautodatacaptureenabled")]
        public bool? IsAutoDataCaptureEnabled { get; set; }

        [JsonProperty("externalbaseurl")]
        public string ExternalBaseUrl { get; set; }

        [JsonProperty("ispreviewenabledforactioncard")]
        public bool? IsPreviewEnabledForActionCard { get; set; }

        [JsonProperty("ispreviewforemailmonitoringallowed")]
        public bool? IsPreviewForEmailMonitoringAllowed { get; set; }

        [JsonProperty("unresolveemailaddressifmultiplematch")]
        public bool? UnresolveEmailAddressIfMultipleMatch { get; set; }

        [JsonProperty("rierrorstatus")]
        public long? RiErrorStatus { get; set; }

        [JsonProperty("widgetproperties")]
        public string WidgetProperties { get; set; }

        [JsonProperty("enablemicrosoftflowintegration")]
        public bool? EnableMicrosoftFlowIntegration { get; set; }

        [JsonProperty("isenabledforallroles")]
        public bool? IsEnabledForAllRoles { get; set; }

        [JsonProperty("ispreviewforautocaptureenabled")]
        public bool? IsPreviewForAutoCaptureEnabled { get; set; }

        [JsonProperty("defaultcrmcustomname")]
        public string DefaultCrmCustomName { get; set; }

        [JsonProperty("aciwebendpointurl")]
        public string ACIWebEndpointUrl { get; set; }

        [JsonProperty("enablelpauthoring")]
        public bool? EnableLPAuthoring { get; set; }

        [JsonProperty("isresourcebookingexchangesyncenabled")]
        public bool? IsResourceBookingExchangeSyncEnabled { get; set; }

        [JsonProperty("ismobileclientondemandsyncenabled")]
        public bool? IsMobileClientOnDemandSyncEnabled { get; set; }

        [JsonProperty("postmessagewhitelistdomains")]
        public string PostMessageWhitelistDomains { get; set; }

        [JsonProperty("isrelationshipinsightsenabled")]
        public bool? IsRelationshipInsightsEnabled { get; set; }

        [JsonProperty("resolvesimilarunresolvedemailaddress")]
        public bool? ResolveSimilarUnresolvedEmailAddress { get; set; }

        [JsonProperty("istextwrapenabled")]
        public bool? IsTextWrapEnabled { get; set; }

        [JsonProperty("sessiontimeoutenabled")]
        public bool? SessionTimeoutEnabled { get; set; }

        [JsonProperty("sessiontimeoutinmins")]
        public long? SessionTimeoutInMins { get; set; }

        [JsonProperty("sessiontimeoutreminderinmins")]
        public long? SessionTimeoutReminderInMins { get; set; }

        [JsonProperty("microsoftflowenvironment")]
        public string MicrosoftFlowEnvironment { get; set; }

        [JsonProperty("inactivitytimeoutenabled")]
        public bool? InactivityTimeoutEnabled { get; set; }

        [JsonProperty("inactivitytimeoutinmins")]
        public long? InactivityTimeoutInMins { get; set; }

        [JsonProperty("inactivitytimeoutreminderinmins")]
        public long? InactivityTimeoutReminderInMins { get; set; }

        [JsonProperty("syncoptinselection")]
        public bool? SyncOptInSelection { get; set; }

        [JsonProperty("syncoptinselectionstatus")]
        public string SyncOptInSelectionStatus { get; set; }

        [JsonProperty("isactionsupportfeatureenabled")]
        public bool? IsActionSupportFeatureEnabled { get; set; }

        [JsonProperty("isbpfentitycustomizationfeatureenabled")]
        public bool? IsBPFEntityCustomizationFeatureEnabled { get; set; }

        [JsonProperty("bounddashboarddefaultcardexpanded")]
        public bool? BoundDashboardDefaultCardExpanded { get; set; }

        [JsonProperty("maxactionstepsinbpf")]
        public long? MaxActionStepsInBPF { get; set; }

        [JsonProperty("servestaticresourcesfromazurecdn")]
        public bool? ServeStaticResourcesFromAzureCDN { get; set; }

        [JsonProperty("isexternalfilestorageenabled")]
        public bool? IsExternalFileStorageEnabled { get; set; }

        [JsonProperty("clientfeatureset")]
        public string ClientFeatureSet { get; set; }

        [JsonProperty("isreadauditenabled")]
        public bool? IsReadAuditEnabled { get; set; }

        [JsonProperty("isnotesanalysisenabled")]
        public bool? IsNotesAnalysisEnabled { get; set; }

        [JsonProperty("allowlegacydialogsembedding")]
        public bool? AllowLegacyDialogsEmbedding { get; set; }

        [JsonProperty("allowlegacyclientexperience")]
        public bool? AllowLegacyClientExperience { get; set; }

        [JsonProperty("ismsteamsenabled")]
        public bool? IsMSTeamsEnabled { get; set; }

        [JsonProperty("isluisenabledford365bot")]
        public bool? IsLUISEnabledforD365Bot { get; set; }

        [JsonProperty("syncbulkoperationbatchsize")]
        public long? SyncBulkOperationBatchSize { get; set; }

        [JsonProperty("syncbulkoperationmaxlimit")]
        public long? SyncBulkOperationMaxLimit { get; set; }

        [JsonProperty("enableunifiedinterfaceshellrefresh")]
        public bool? EnableUnifiedInterfaceShellRefresh { get; set; }

        [JsonProperty("ismsteamssettingchangedbyuser")]
        public bool? IsMSTeamsSettingChangedByUser { get; set; }

        [JsonProperty("enablelivepersonacarduci")]
        public bool? EnableLivePersonaCardUCI { get; set; }

        [JsonProperty("ismsteamscollaborationenabled")]
        public bool? IsMSTeamsCollaborationEnabled { get; set; }

        [JsonProperty("ismsteamsusersyncenabled")]
        public bool? IsMSTeamsUserSyncEnabled { get; set; }

        [JsonProperty("ismanualsalesforecastingenabled")]
        public bool? IsManualSalesForecastingEnabled { get; set; }

        [JsonProperty("ispdfgenerationenabled")]
        public string IsPDFGenerationEnabled { get; set; }

        [JsonProperty("iscustomcontrolsincanvasappsenabled")]
        public bool? IsCustomControlsInCanvasAppsEnabled { get; set; }

        [JsonProperty("ispaienabled")]
        public bool? IsPAIEnabled { get; set; }

        [JsonProperty("isquickcreateenabledforopportunityclose")]
        public bool? IsQuickCreateEnabledForOpportunityClose { get; set; }

        [JsonProperty("contentsecuritypolicyconfiguration")]
        public string ContentSecurityPolicyConfiguration { get; set; }

        [JsonProperty("iscontentsecuritypolicyenabled")]
        public bool? IsContentSecurityPolicyEnabled { get; set; }

        [JsonProperty("ispricelistmandatory")]
        public bool? IsPriceListMandatory { get; set; }

        [JsonProperty("enablelivepersoncardintegrationinoffice")]
        public bool? EnableLivePersonCardIntegrationInOffice { get; set; }

        [JsonProperty("iscontextualemailenabled")]
        public bool? IsContextualEmailEnabled { get; set; }

        [JsonProperty("qualifyleadadditionaloptions")]
        public string QualifyLeadAdditionalOptions { get; set; }

        [JsonProperty("businesscardoptions")]
        public string BusinessCardOptions { get; set; }

        [JsonProperty("isplaybookenabled")]
        public bool? IsPlaybookEnabled { get; set; }

        [JsonProperty("paipreviewscenarioenabled")]
        public bool? PaiPreviewScenarioEnabled { get; set; }

        [JsonProperty("iscontextualhelpenabled")]
        public bool? IsContextualHelpEnabled { get; set; }

        [JsonProperty("issalesassistantenabled")]
        public bool? IsSalesAssistantEnabled { get; set; }

        [JsonProperty("isautodatacapturev2enabled")]
        public bool? IsAutoDataCaptureV2Enabled { get; set; }

        [JsonProperty("isnewaddproductexperienceenabled")]
        public bool? IsNewAddProductExperienceEnabled { get; set; }

        [JsonProperty("auditretentionperiod")]
        public long? AuditRetentionPeriod { get; set; }

        [JsonProperty("usequickfindviewforgridsearch")]
        public bool? UseQuickFindViewForGridSearch { get; set; }

        [JsonProperty("isrichtextnotesenabled")]
        public bool? IsRichTextNotesEnabled { get; set; }

        [JsonProperty("sendbulkemailinuci")]
        public bool? SendBulkEmailInUCI { get; set; }

        [JsonProperty("isallmoneydecimal")]
        public bool? IsAllMoneyDecimal { get; set; }

        [JsonProperty("iswriteinproductsallowed")]
        public bool? IsWriteInProductsAllowed { get; set; }

        [JsonProperty("appointmentricheditorexperience")]
        public bool? AppointmentRichEditorExperience { get; set; }

        [JsonProperty("appointmentricheditorexperiencename")]
        public string appointmentricheditorexperienceName { get; set; }

        [JsonProperty("schedulingengine")]
        public string SchedulingEngine { get; set; }

        [JsonProperty("schedulingenginename")]
        public string schedulingengineName { get; set; }


    }
}

