using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class UserSettings : DynamicsModel
    {
        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }

        [JsonProperty("businessunitid")]
        public Guid? BusinessUnitId { get; set; }

        [JsonProperty("homepagearea")]
        public string HomepageArea { get; set; }

        [JsonProperty("paginglimit")]
        public long? PagingLimit { get; set; }

        [JsonProperty("homepagesubarea")]
        public string HomepageSubarea { get; set; }

        [JsonProperty("defaultcalendarview")]
        public long? DefaultCalendarView { get; set; }

        [JsonProperty("workdaystarttime")]
        public string WorkdayStartTime { get; set; }

        [JsonProperty("workdaystoptime")]
        public string WorkdayStopTime { get; set; }

        [JsonProperty("ignoreunsolicitedemail")]
        public bool? IgnoreUnsolicitedEmail { get; set; }

        [JsonProperty("timezonebias")]
        public long? TimeZoneBias { get; set; }

        [JsonProperty("timezonestandardbias")]
        public long? TimeZoneStandardBias { get; set; }

        [JsonProperty("timezonedaylightbias")]
        public long? TimeZoneDaylightBias { get; set; }

        [JsonProperty("timezonecode")]
        public long? TimeZoneCode { get; set; }

        [JsonProperty("timezonestandardyear")]
        public long? TimeZoneStandardYear { get; set; }

        [JsonProperty("timezonestandardmonth")]
        public long? TimeZoneStandardMonth { get; set; }

        [JsonProperty("timezonestandardday")]
        public long? TimeZoneStandardDay { get; set; }

        [JsonProperty("timezonestandarddayofweek")]
        public long? TimeZoneStandardDayOfWeek { get; set; }

        [JsonProperty("timezonestandardhour")]
        public long? TimeZoneStandardHour { get; set; }

        [JsonProperty("timezonestandardminute")]
        public long? TimeZoneStandardMinute { get; set; }

        [JsonProperty("timezonestandardsecond")]
        public long? TimeZoneStandardSecond { get; set; }

        [JsonProperty("timezonedaylightyear")]
        public long? TimeZoneDaylightYear { get; set; }

        [JsonProperty("timezonedaylightmonth")]
        public long? TimeZoneDaylightMonth { get; set; }

        [JsonProperty("timezonedaylightday")]
        public long? TimeZoneDaylightDay { get; set; }

        [JsonProperty("timezonedaylightdayofweek")]
        public long? TimeZoneDaylightDayOfWeek { get; set; }

        [JsonProperty("timezonedaylighthour")]
        public long? TimeZoneDaylightHour { get; set; }

        [JsonProperty("timezonedaylightminute")]
        public long? TimeZoneDaylightMinute { get; set; }

        [JsonProperty("timezonedaylightsecond")]
        public long? TimeZoneDaylightSecond { get; set; }

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

        [JsonProperty("ignoreunsolicitedemailname")]
        public string IgnoreUnsolicitedEmailName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("advancedfindstartupmode")]
        public long? AdvancedFindStartupMode { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("trackingtokenid")]
        public long? TrackingTokenId { get; set; }

        [JsonProperty("nexttrackingnumber")]
        public long? NextTrackingNumber { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("userprofile")]
        public string UserProfile { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("numberseparator")]
        public string NumberSeparator { get; set; }

        [JsonProperty("outlooksyncinterval")]
        public long? OutlookSyncInterval { get; set; }

        [JsonProperty("usecrmformfortask")]
        public bool? UseCrmFormForTask { get; set; }

        [JsonProperty("pricingdecimalprecision")]
        public long? PricingDecimalPrecision { get; set; }

        [JsonProperty("synccontactcompany")]
        public bool? SyncContactCompany { get; set; }

        [JsonProperty("dateseparator")]
        public string DateSeparator { get; set; }

        [JsonProperty("longdateformatcode")]
        public long? LongDateFormatCode { get; set; }

        [JsonProperty("allowemailcredentials")]
        public bool? AllowEmailCredentials { get; set; }

        [JsonProperty("fullnameconventioncode")]
        public long? FullNameConventionCode { get; set; }

        [JsonProperty("timeseparator")]
        public string TimeSeparator { get; set; }

        [JsonProperty("timeformatcode")]
        public long? TimeFormatCode { get; set; }

        [JsonProperty("negativeformatcode")]
        public long? NegativeFormatCode { get; set; }

        [JsonProperty("offlinesyncinterval")]
        public long? OfflineSyncInterval { get; set; }

        [JsonProperty("calendartype")]
        public long? CalendarType { get; set; }

        [JsonProperty("currencysymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("uilanguageid")]
        public long? UILanguageId { get; set; }

        [JsonProperty("usecrmformforcontact")]
        public bool? UseCrmFormForContact { get; set; }

        [JsonProperty("currencyformatcode")]
        public long? CurrencyFormatCode { get; set; }

        [JsonProperty("addressbooksyncinterval")]
        public long? AddressBookSyncInterval { get; set; }

        [JsonProperty("decimalsymbol")]
        public string DecimalSymbol { get; set; }

        [JsonProperty("usecrmformforemail")]
        public bool? UseCrmFormForEmail { get; set; }

        [JsonProperty("showweeknumber")]
        public bool? ShowWeekNumber { get; set; }

        [JsonProperty("negativecurrencyformatcode")]
        public long? NegativeCurrencyFormatCode { get; set; }

        [JsonProperty("timeformatstring")]
        public string TimeFormatString { get; set; }

        [JsonProperty("emailusername")]
        public string EmailUsername { get; set; }

        [JsonProperty("dateformatstring")]
        public string DateFormatString { get; set; }

        [JsonProperty("reportscripterrors")]
        public string ReportScriptErrors { get; set; }

        [JsonProperty("useimagestrips")]
        public bool? UseImageStrips { get; set; }

        [JsonProperty("emailpassword")]
        public string EmailPassword { get; set; }

        [JsonProperty("dateformatcode")]
        public long? DateFormatCode { get; set; }

        [JsonProperty("usecrmformforappointment")]
        public bool? UseCrmFormForAppointment { get; set; }

        [JsonProperty("isduplicatedetectionenabledwhengoingonline")]
        public bool? IsDuplicateDetectionEnabledWhenGoingOnline { get; set; }

        [JsonProperty("localeid")]
        public long? LocaleId { get; set; }

        [JsonProperty("incomingemailfilteringmethod")]
        public string IncomingEmailFilteringMethod { get; set; }

        [JsonProperty("currencydecimalprecision")]
        public long? CurrencyDecimalPrecision { get; set; }

        [JsonProperty("amdesignator")]
        public string AMDesignator { get; set; }

        [JsonProperty("numbergroupformat")]
        public string NumberGroupFormat { get; set; }

        [JsonProperty("helplanguageid")]
        public long? HelpLanguageId { get; set; }

        [JsonProperty("pmdesignator")]
        public string PMDesignator { get; set; }

        [JsonProperty("incomingemailfilteringmethodname")]
        public string IncomingEmailFilteringMethodName { get; set; }

        [JsonProperty("reportscripterrorsname")]
        public string ReportScriptErrorsName { get; set; }

        [JsonProperty("allowemailcredentialsname")]
        public string AllowEmailCredentialsName { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("personalizationsettings")]
        public string PersonalizationSettings { get; set; }

        [JsonProperty("visualizationpanelayout")]
        public string VisualizationPaneLayout { get; set; }

        [JsonProperty("visualizationpanelayoutname")]
        public string VisualizationPaneLayoutName { get; set; }

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

        [JsonProperty("homepagelayout")]
        public string HomepageLayout { get; set; }

        [JsonProperty("defaultdashboardid")]
        public Guid? DefaultDashboardId { get; set; }

        [JsonProperty("issendasallowed")]
        public bool? IsSendAsAllowed { get; set; }

        [JsonProperty("autocreatecontactonpromote")]
        public long? AutoCreateContactOnPromote { get; set; }

        [JsonProperty("datavalidationmodeforexporttoexcel")]
        public string DataValidationModeForExportToExcel { get; set; }

        [JsonProperty("datavalidationmodeforexporttoexcelname")]
        public string DataValidationModeForExportToExcelName { get; set; }

        [JsonProperty("entityformmode")]
        public string EntityFormMode { get; set; }

        [JsonProperty("isdefaultcountrycodecheckenabled")]
        public bool? IsDefaultCountryCodeCheckEnabled { get; set; }

        [JsonProperty("defaultcountrycode")]
        public string DefaultCountryCode { get; set; }

        [JsonProperty("lastalertsviewedtime")]
        public DateTimeOffset? LastAlertsViewedTime { get; set; }

        [JsonProperty("isguidedhelpenabled")]
        public bool? IsGuidedHelpEnabled { get; set; }

        [JsonProperty("isappsforcrmalertdismissed")]
        public bool? IsAppsForCrmAlertDismissed { get; set; }

        [JsonProperty("defaultsearchexperience")]
        public string DefaultSearchExperience { get; set; }

        [JsonProperty("defaultsearchexperiencename")]
        public string DefaultSearchExperienceName { get; set; }

        [JsonProperty("splitviewstate")]
        public bool? SplitViewState { get; set; }

        [JsonProperty("isresourcebookingexchangesyncenabled")]
        public bool? IsResourceBookingExchangeSyncEnabled { get; set; }

        [JsonProperty("resourcebookingexchangesyncversion")]
        public int? ResourceBookingExchangeSyncVersion { get; set; }

        [JsonProperty("selectedglobalfilterid")]
        public Guid? SelectedGlobalFilterId { get; set; }

        [JsonProperty("isemailconversationviewenabled")]
        public bool? IsEmailConversationViewEnabled { get; set; }

        [JsonProperty("autocaptureuserstatus")]
        public long? AutoCaptureUserStatus { get; set; }

        [JsonProperty("isautodatacaptureenabled")]
        public bool? IsAutoDataCaptureEnabled { get; set; }


    }
}

