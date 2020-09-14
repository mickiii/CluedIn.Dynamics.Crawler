using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UserSettingsVocabulary : SimpleVocabulary
        {
            public UserSettingsVocabulary()
            {
                VocabularyName = "Dynamics365 UserSettings";
                KeyPrefix = "dynamics365.usersettings";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UserSettings", group =>
                {
                    this.SystemUserId = group.Add(new VocabularyKey("SystemUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user.")
                        .WithDisplayName("SystemUserId")
                        .ModelProperty("systemuserid", typeof(Guid)));
                    
                    this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the business unit with which the user is associated.")
                        .WithDisplayName("BusinessUnitId")
                        .ModelProperty("businessunitid", typeof(Guid)));
                    
                    this.HomepageArea = group.Add(new VocabularyKey("HomepageArea", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                        .WithDescription(@"Web site home page for the user.")
                        .WithDisplayName("HomepageArea")
                        .ModelProperty("homepagearea", typeof(string)));
                    
                    this.PagingLimit = group.Add(new VocabularyKey("PagingLimit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies how many items to list on a page in list views.")
                        .WithDisplayName("PagingLimit")
                        .ModelProperty("paginglimit", typeof(long)));
                    
                    this.HomepageSubarea = group.Add(new VocabularyKey("HomepageSubarea", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                        .WithDescription(@"Web site page for the user.")
                        .WithDisplayName("HomepageSubarea")
                        .ModelProperty("homepagesubarea", typeof(string)));
                    
                    this.DefaultCalendarView = group.Add(new VocabularyKey("DefaultCalendarView", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Default calendar view for the user.")
                        .WithDisplayName("DefaultCalendarView")
                        .ModelProperty("defaultcalendarview", typeof(long)));
                    
                    this.WorkdayStartTime = group.Add(new VocabularyKey("WorkdayStartTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                        .WithDescription(@"Workday start time for the user.")
                        .WithDisplayName("WorkdayStartTime")
                        .ModelProperty("workdaystarttime", typeof(string)));
                    
                    this.WorkdayStopTime = group.Add(new VocabularyKey("WorkdayStopTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                        .WithDescription(@"Workday stop time for the user.")
                        .WithDisplayName("WorkdayStopTime")
                        .ModelProperty("workdaystoptime", typeof(string)));
                    
                    this.IgnoreUnsolicitedEmail = group.Add(new VocabularyKey("IgnoreUnsolicitedEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether a user account is to ignore unsolicited email (deprecated).")
                        .WithDisplayName("IgnoreUnsolicitedEmail")
                        .ModelProperty("ignoreunsolicitedemail", typeof(bool)));
                    
                    this.TimeZoneBias = group.Add(new VocabularyKey("TimeZoneBias", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone adjustment for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneBias")
                        .ModelProperty("timezonebias", typeof(long)));
                    
                    this.TimeZoneStandardBias = group.Add(new VocabularyKey("TimeZoneStandardBias", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard time bias for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardBias")
                        .ModelProperty("timezonestandardbias", typeof(long)));
                    
                    this.TimeZoneDaylightBias = group.Add(new VocabularyKey("TimeZoneDaylightBias", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight adjustment for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightBias")
                        .ModelProperty("timezonedaylightbias", typeof(long)));
                    
                    this.TimeZoneCode = group.Add(new VocabularyKey("TimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone for the user.")
                        .WithDisplayName("TimeZoneCode")
                        .ModelProperty("timezonecode", typeof(long)));
                    
                    this.TimeZoneStandardYear = group.Add(new VocabularyKey("TimeZoneStandardYear", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard year for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardYear")
                        .ModelProperty("timezonestandardyear", typeof(long)));
                    
                    this.TimeZoneStandardMonth = group.Add(new VocabularyKey("TimeZoneStandardMonth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard month for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardMonth")
                        .ModelProperty("timezonestandardmonth", typeof(long)));
                    
                    this.TimeZoneStandardDay = group.Add(new VocabularyKey("TimeZoneStandardDay", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard day for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardDay")
                        .ModelProperty("timezonestandardday", typeof(long)));
                    
                    this.TimeZoneStandardDayOfWeek = group.Add(new VocabularyKey("TimeZoneStandardDayOfWeek", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard day of week for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardDayOfWeek")
                        .ModelProperty("timezonestandarddayofweek", typeof(long)));
                    
                    this.TimeZoneStandardHour = group.Add(new VocabularyKey("TimeZoneStandardHour", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard hour for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardHour")
                        .ModelProperty("timezonestandardhour", typeof(long)));
                    
                    this.TimeZoneStandardMinute = group.Add(new VocabularyKey("TimeZoneStandardMinute", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard minute for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardMinute")
                        .ModelProperty("timezonestandardminute", typeof(long)));
                    
                    this.TimeZoneStandardSecond = group.Add(new VocabularyKey("TimeZoneStandardSecond", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone standard second for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneStandardSecond")
                        .ModelProperty("timezonestandardsecond", typeof(long)));
                    
                    this.TimeZoneDaylightYear = group.Add(new VocabularyKey("TimeZoneDaylightYear", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight year for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightYear")
                        .ModelProperty("timezonedaylightyear", typeof(long)));
                    
                    this.TimeZoneDaylightMonth = group.Add(new VocabularyKey("TimeZoneDaylightMonth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight month for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightMonth")
                        .ModelProperty("timezonedaylightmonth", typeof(long)));
                    
                    this.TimeZoneDaylightDay = group.Add(new VocabularyKey("TimeZoneDaylightDay", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight day for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightDay")
                        .ModelProperty("timezonedaylightday", typeof(long)));
                    
                    this.TimeZoneDaylightDayOfWeek = group.Add(new VocabularyKey("TimeZoneDaylightDayOfWeek", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight day of week for the user. System calculated based on the time zone selected in Options.")
                        .WithDisplayName("TimeZoneDaylightDayOfWeek")
                        .ModelProperty("timezonedaylightdayofweek", typeof(long)));
                    
                    this.TimeZoneDaylightHour = group.Add(new VocabularyKey("TimeZoneDaylightHour", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight hour for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightHour")
                        .ModelProperty("timezonedaylighthour", typeof(long)));
                    
                    this.TimeZoneDaylightMinute = group.Add(new VocabularyKey("TimeZoneDaylightMinute", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight minute for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightMinute")
                        .ModelProperty("timezonedaylightminute", typeof(long)));
                    
                    this.TimeZoneDaylightSecond = group.Add(new VocabularyKey("TimeZoneDaylightSecond", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Local time zone daylight second for the user. System calculated based on the time zone selected.")
                        .WithDisplayName("TimeZoneDaylightSecond")
                        .ModelProperty("timezonedaylightsecond", typeof(long)));
                    
                    this.BusinessUnitIdName = group.Add(new VocabularyKey("BusinessUnitIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("BusinessUnitIdName")
                        .ModelProperty("businessunitidname", typeof(string)));
                    
                    this.IgnoreUnsolicitedEmailName = group.Add(new VocabularyKey("IgnoreUnsolicitedEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IgnoreUnsolicitedEmailName")
                        .ModelProperty("ignoreunsolicitedemailname", typeof(string)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the user settings.")
                        .WithDisplayName("ModifiedBy")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.AdvancedFindStartupMode = group.Add(new VocabularyKey("AdvancedFindStartupMode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Default mode, such as simple or detailed, for advanced find.")
                        .WithDisplayName("AdvancedFindStartupMode")
                        .ModelProperty("advancedfindstartupmode", typeof(long)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the user settings object was created.")
                        .WithDisplayName("CreatedOn")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.TrackingTokenId = group.Add(new VocabularyKey("TrackingTokenId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Tracking token ID.")
                        .WithDisplayName("TrackingTokenId")
                        .ModelProperty("trackingtokenid", typeof(long)));
                    
                    this.NextTrackingNumber = group.Add(new VocabularyKey("NextTrackingNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Next tracking number.")
                        .WithDisplayName("NextTrackingNumber")
                        .ModelProperty("nexttrackingnumber", typeof(long)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the user settings object was last modified.")
                        .WithDisplayName("ModifiedOn")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the user settings.")
                        .WithDisplayName("CreatedBy")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.UserProfile = group.Add(new VocabularyKey("UserProfile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                        .WithDescription(@"Specifies user profile ids in comma separated list.")
                        .WithDisplayName("UserProfile")
                        .ModelProperty("userprofile", typeof(string)));
                    
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
                    
                    this.NumberSeparator = group.Add(new VocabularyKey("NumberSeparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                        .WithDescription(@"Symbol used for number separation in Microsoft Dynamics 365.")
                        .WithDisplayName("NumberSeparator")
                        .ModelProperty("numberseparator", typeof(string)));
                    
                    this.OutlookSyncInterval = group.Add(new VocabularyKey("OutlookSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Normal polling frequency used for record synchronization in Microsoft Office Outlook.")
                        .WithDisplayName("OutlookSyncInterval")
                        .ModelProperty("outlooksyncinterval", typeof(long)));
                    
                    this.UseCrmFormForTask = group.Add(new VocabularyKey("UseCrmFormForTask", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether to use the Microsoft Dynamics 365 task form within Microsoft Office Outlook for creating new tasks.")
                        .WithDisplayName("UseCrmFormForTask")
                        .ModelProperty("usecrmformfortask", typeof(bool)));
                    
                    this.PricingDecimalPrecision = group.Add(new VocabularyKey("PricingDecimalPrecision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Number of decimal places that can be used for prices.")
                        .WithDisplayName("PricingDecimalPrecision")
                        .ModelProperty("pricingdecimalprecision", typeof(long)));
                    
                    this.SyncContactCompany = group.Add(new VocabularyKey("SyncContactCompany", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates if the company field in Microsoft Office Outlook items are set during Outlook synchronization.")
                        .WithDisplayName("SyncContactCompany")
                        .ModelProperty("synccontactcompany", typeof(bool)));
                    
                    this.DateSeparator = group.Add(new VocabularyKey("DateSeparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                        .WithDescription(@"Character used to separate the month, the day, and the year in dates in Microsoft Dynamics 365.")
                        .WithDisplayName("DateSeparator")
                        .ModelProperty("dateseparator", typeof(string)));
                    
                    this.LongDateFormatCode = group.Add(new VocabularyKey("LongDateFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies how Long Date is displayed throughout Microsoft 365.")
                        .WithDisplayName("LongDateFormatCode")
                        .ModelProperty("longdateformatcode", typeof(long)));
                    
                    this.AllowEmailCredentials = group.Add(new VocabularyKey("AllowEmailCredentials", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"This attribute is no longer used. The data is now in the Mailbox.AllowEmailConnectorToUseCredentials attribute.")
                        .WithDisplayName("AllowEmailCredentials")
                        .ModelProperty("allowemailcredentials", typeof(bool)));
                    
                    this.FullNameConventionCode = group.Add(new VocabularyKey("FullNameConventionCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Order in which names are to be displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("FullNameConventionCode")
                        .ModelProperty("fullnameconventioncode", typeof(long)));
                    
                    this.TimeSeparator = group.Add(new VocabularyKey("TimeSeparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                        .WithDescription(@"Text for how time is displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("TimeSeparator")
                        .ModelProperty("timeseparator", typeof(string)));
                    
                    this.TimeFormatCode = group.Add(new VocabularyKey("TimeFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies how the time is displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("TimeFormatCode")
                        .ModelProperty("timeformatcode", typeof(long)));
                    
                    this.NegativeFormatCode = group.Add(new VocabularyKey("NegativeFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies how negative numbers are displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("NegativeFormatCode")
                        .ModelProperty("negativeformatcode", typeof(long)));
                    
                    this.OfflineSyncInterval = group.Add(new VocabularyKey("OfflineSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.")
                        .WithDisplayName("OfflineSyncInterval")
                        .ModelProperty("offlinesyncinterval", typeof(long)));
                    
                    this.CalendarType = group.Add(new VocabularyKey("CalendarType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Calendar type for the system. Set to Gregorian US by default.")
                        .WithDisplayName("CalendarType")
                        .ModelProperty("calendartype", typeof(long)));
                    
                    this.CurrencySymbol = group.Add(new VocabularyKey("CurrencySymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(13))
                        .WithDescription(@"Symbol used for currency in Microsoft Dynamics 365.")
                        .WithDisplayName("CurrencySymbol")
                        .ModelProperty("currencysymbol", typeof(string)));
                    
                    this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the default currency of the user.")
                        .WithDisplayName("Currency")
                        .ModelProperty("transactioncurrencyid", typeof(string)));
                    
                    this.UILanguageId = group.Add(new VocabularyKey("UILanguageId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the language in which to view the user interface (UI).")
                        .WithDisplayName("UILanguageId")
                        .ModelProperty("uilanguageid", typeof(long)));
                    
                    this.UseCrmFormForContact = group.Add(new VocabularyKey("UseCrmFormForContact", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether to use the Microsoft Dynamics 365 contact form within Microsoft Office Outlook for creating new contacts.")
                        .WithDisplayName("UseCrmFormForContact")
                        .ModelProperty("usecrmformforcontact", typeof(bool)));
                    
                    this.CurrencyFormatCode = group.Add(new VocabularyKey("CurrencyFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information about how currency symbols are placed in Microsoft Dynamics 365.")
                        .WithDisplayName("CurrencyFormatCode")
                        .ModelProperty("currencyformatcode", typeof(long)));
                    
                    this.AddressBookSyncInterval = group.Add(new VocabularyKey("AddressBookSyncInterval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Normal polling frequency used for address book synchronization in Microsoft Office Outlook.")
                        .WithDisplayName("AddressBookSyncInterval")
                        .ModelProperty("addressbooksyncinterval", typeof(long)));
                    
                    this.DecimalSymbol = group.Add(new VocabularyKey("DecimalSymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5))
                        .WithDescription(@"Symbol used for decimal in Microsoft Dynamics 365.")
                        .WithDisplayName("DecimalSymbol")
                        .ModelProperty("decimalsymbol", typeof(string)));
                    
                    this.UseCrmFormForEmail = group.Add(new VocabularyKey("UseCrmFormForEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether to use the Microsoft Dynamics 365 email form within Microsoft Office Outlook for creating new emails.")
                        .WithDisplayName("UseCrmFormForEmail")
                        .ModelProperty("usecrmformforemail", typeof(bool)));
                    
                    this.ShowWeekNumber = group.Add(new VocabularyKey("ShowWeekNumber", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether to display the week number in calendar displays in Microsoft Dynamics 365.")
                        .WithDisplayName("ShowWeekNumber")
                        .ModelProperty("showweeknumber", typeof(bool)));
                    
                    this.NegativeCurrencyFormatCode = group.Add(new VocabularyKey("NegativeCurrencyFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies how negative currency numbers are displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("NegativeCurrencyFormatCode")
                        .ModelProperty("negativecurrencyformatcode", typeof(long)));
                    
                    this.TimeFormatString = group.Add(new VocabularyKey("TimeFormatString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                        .WithDescription(@"Text for how time is displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("TimeFormatString")
                        .ModelProperty("timeformatstring", typeof(string)));
                    
                    this.EmailUsername = group.Add(new VocabularyKey("EmailUsername", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                        .WithDescription(@"This attribute is no longer used. The data is now in the Mailbox.UserName attribute.")
                        .WithDisplayName("EmailUsername")
                        .ModelProperty("emailusername", typeof(string)));
                    
                    this.DateFormatString = group.Add(new VocabularyKey("DateFormatString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                        .WithDescription(@"String showing how the date is displayed throughout Microsoft 365.")
                        .WithDisplayName("DateFormatString")
                        .ModelProperty("dateformatstring", typeof(string)));
                    
                    this.ReportScriptErrors = group.Add(new VocabularyKey("ReportScriptErrors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Picklist for selecting the user preference for reporting scripting errors.")
                        .WithDisplayName("Report Script Errors")
                        .ModelProperty("reportscripterrors", typeof(string)));
                    
                    this.UseImageStrips = group.Add(new VocabularyKey("UseImageStrips", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether image strips are used to render images.")
                        .WithDisplayName("UseImageStrips")
                        .ModelProperty("useimagestrips", typeof(bool)));
                    
                    this.EmailPassword = group.Add(new VocabularyKey("EmailPassword", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                        .WithDescription(@"This attribute is no longer used. The data is now in the Mailbox.Password attribute.")
                        .WithDisplayName("EmailPassword")
                        .ModelProperty("emailpassword", typeof(string)));
                    
                    this.DateFormatCode = group.Add(new VocabularyKey("DateFormatCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information about how the date is displayed in Microsoft Dynamics 365.")
                        .WithDisplayName("DateFormatCode")
                        .ModelProperty("dateformatcode", typeof(long)));
                    
                    this.UseCrmFormForAppointment = group.Add(new VocabularyKey("UseCrmFormForAppointment", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether to use the Microsoft Dynamics 365 appointment form within Microsoft Office Outlook for creating new appointments.")
                        .WithDisplayName("UseCrmFormForAppointment")
                        .ModelProperty("usecrmformforappointment", typeof(bool)));
                    
                    this.IsDuplicateDetectionEnabledWhenGoingOnline = group.Add(new VocabularyKey("IsDuplicateDetectionEnabledWhenGoingOnline", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates if duplicate detection is enabled when going online.")
                        .WithDisplayName("IsDuplicateDetectionEnabledWhenGoingOnline")
                        .ModelProperty("isduplicatedetectionenabledwhengoingonline", typeof(bool)));
                    
                    this.LocaleId = group.Add(new VocabularyKey("LocaleId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the user locale.")
                        .WithDisplayName("LocaleId")
                        .ModelProperty("localeid", typeof(long)));
                    
                    this.IncomingEmailFilteringMethod = group.Add(new VocabularyKey("IncomingEmailFilteringMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Incoming email filtering method.")
                        .WithDisplayName("Incoming Email Filtering Method")
                        .ModelProperty("incomingemailfilteringmethod", typeof(string)));
                    
                    this.CurrencyDecimalPrecision = group.Add(new VocabularyKey("CurrencyDecimalPrecision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Number of decimal places that can be used for currency.")
                        .WithDisplayName("CurrencyDecimalPrecision")
                        .ModelProperty("currencydecimalprecision", typeof(long)));
                    
                    this.AMDesignator = group.Add(new VocabularyKey("AMDesignator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                        .WithDescription(@"AM designator to use in Microsoft Dynamics 365.")
                        .WithDisplayName("AMDesignator")
                        .ModelProperty("amdesignator", typeof(string)));
                    
                    this.NumberGroupFormat = group.Add(new VocabularyKey("NumberGroupFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                        .WithDescription(@"Information that specifies how numbers are grouped in Microsoft Dynamics 365.")
                        .WithDisplayName("NumberGroupFormat")
                        .ModelProperty("numbergroupformat", typeof(string)));
                    
                    this.HelpLanguageId = group.Add(new VocabularyKey("HelpLanguageId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the Help language.")
                        .WithDisplayName("HelpLanguageId")
                        .ModelProperty("helplanguageid", typeof(long)));
                    
                    this.PMDesignator = group.Add(new VocabularyKey("PMDesignator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(25))
                        .WithDescription(@"PM designator to use in Microsoft Dynamics 365.")
                        .WithDisplayName("PMDesignator")
                        .ModelProperty("pmdesignator", typeof(string)));
                    
                    this.IncomingEmailFilteringMethodName = group.Add(new VocabularyKey("IncomingEmailFilteringMethodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IncomingEmailFilteringMethodName")
                        .ModelProperty("incomingemailfilteringmethodname", typeof(string)));
                    
                    this.ReportScriptErrorsName = group.Add(new VocabularyKey("ReportScriptErrorsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ReportScriptErrorsName")
                        .ModelProperty("reportscripterrorsname", typeof(string)));
                    
                    this.AllowEmailCredentialsName = group.Add(new VocabularyKey("AllowEmailCredentialsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("AllowEmailCredentialsName")
                        .ModelProperty("allowemailcredentialsname", typeof(string)));
                    
                    this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("TransactionCurrencyIdName")
                        .ModelProperty("transactioncurrencyidname", typeof(string)));
                    
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
                    
                    this.PersonalizationSettings = group.Add(new VocabularyKey("PersonalizationSettings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("PersonalizationSettings")
                        .ModelProperty("personalizationsettings", typeof(string)));
                    
                    this.VisualizationPaneLayout = group.Add(new VocabularyKey("VisualizationPaneLayout", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"The layout of the visualization pane.")
                        .WithDisplayName("Visualization Pane Layout.")
                        .ModelProperty("visualizationpanelayout", typeof(string)));
                    
                    this.VisualizationPaneLayoutName = group.Add(new VocabularyKey("VisualizationPaneLayoutName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VisualizationPaneLayoutName")
                        .ModelProperty("visualizationpanelayoutname", typeof(string)));
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the usersettings.")
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
                        .WithDescription(@"Unique identifier of the delegate user who last modified the usersettings.")
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
                        .WithDescription(@"Information that specifies whether the Get Started pane in lists is enabled.")
                        .WithDisplayName("GetStartedPaneContentEnabled")
                        .ModelProperty("getstartedpanecontentenabled", typeof(bool)));
                    
                    this.HomepageLayout = group.Add(new VocabularyKey("HomepageLayout", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                        .WithDescription(@"Configuration of the home page layout.")
                        .WithDisplayName("HomepageLayout")
                        .ModelProperty("homepagelayout", typeof(string)));
                    
                    this.DefaultDashboardId = group.Add(new VocabularyKey("DefaultDashboardId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the default dashboard.")
                        .WithDisplayName("DefaultDashboardId")
                        .ModelProperty("defaultdashboardid", typeof(Guid)));
                    
                    this.IsSendAsAllowed = group.Add(new VocabularyKey("IsSendAsAllowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates if send as other user privilege is enabled or not.")
                        .WithDisplayName("IsSendAsAllowed")
                        .ModelProperty("issendasallowed", typeof(bool)));
                    
                    this.AutoCreateContactOnPromote = group.Add(new VocabularyKey("AutoCreateContactOnPromote", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Auto-create contact on client promote")
                        .WithDisplayName("AutoCreateContactOnPromote")
                        .ModelProperty("autocreatecontactonpromote", typeof(long)));
                    
                    this.DataValidationModeForExportToExcel = group.Add(new VocabularyKey("DataValidationModeForExportToExcel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies the level of data validation in excel worksheets exported in a format suitable for import.")
                        .WithDisplayName("Data Validation Mode For Export To Excel")
                        .ModelProperty("datavalidationmodeforexporttoexcel", typeof(string)));
                    
                    this.DataValidationModeForExportToExcelName = group.Add(new VocabularyKey("DataValidationModeForExportToExcelName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("DataValidationModeForExportToExcelName")
                        .ModelProperty("datavalidationmodeforexporttoexcelname", typeof(string)));
                    
                    this.EntityFormMode = group.Add(new VocabularyKey("EntityFormMode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates the form mode to be used.")
                        .WithDisplayName("Form Mode")
                        .ModelProperty("entityformmode", typeof(string)));
                    
                    this.IsDefaultCountryCodeCheckEnabled = group.Add(new VocabularyKey("IsDefaultCountryCodeCheckEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Enable or disable country code selection .")
                        .WithDisplayName("Enable Default Country Code")
                        .ModelProperty("isdefaultcountrycodecheckenabled", typeof(bool)));
                    
                    this.DefaultCountryCode = group.Add(new VocabularyKey("DefaultCountryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(30))
                        .WithDescription(@"Text area to enter default country code.")
                        .WithDisplayName("Default Country Code")
                        .ModelProperty("defaultcountrycode", typeof(string)));
                    
                    this.LastAlertsViewedTime = group.Add(new VocabularyKey("LastAlertsViewedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Shows the last time when the traces were read from the database.")
                        .WithDisplayName("LastAlertsViewedTime")
                        .ModelProperty("lastalertsviewedtime", typeof(DateTime)));
                    
                    this.IsGuidedHelpEnabled = group.Add(new VocabularyKey("IsGuidedHelpEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Enable or disable guided help.")
                        .WithDisplayName("Enable Default Guided Help")
                        .ModelProperty("isguidedhelpenabled", typeof(bool)));
                    
                    this.IsAppsForCrmAlertDismissed = group.Add(new VocabularyKey("IsAppsForCrmAlertDismissed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Show or dismiss alert for Apps for 365.")
                        .WithDisplayName("Show alert for Apps for 365.")
                        .ModelProperty("isappsforcrmalertdismissed", typeof(bool)));
                    
                    this.DefaultSearchExperience = group.Add(new VocabularyKey("DefaultSearchExperience", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Default search experience for the user.")
                        .WithDisplayName("Default Search Experience")
                        .ModelProperty("defaultsearchexperience", typeof(string)));
                    
                    this.DefaultSearchExperienceName = group.Add(new VocabularyKey("DefaultSearchExperienceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("DefaultSearchExperienceName")
                        .ModelProperty("defaultsearchexperiencename", typeof(string)));
                    
                    this.SplitViewState = group.Add(new VocabularyKey("SplitViewState", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"For Internal use only")
                        .WithDisplayName("SplitViewState")
                        .ModelProperty("splitviewstate", typeof(bool)));
                    
                    this.IsResourceBookingExchangeSyncEnabled = group.Add(new VocabularyKey("IsResourceBookingExchangeSyncEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates if the synchronization of user resource booking with Exchange is enabled at user level.")
                        .WithDisplayName("Resource booking synchronization enabled")
                        .ModelProperty("isresourcebookingexchangesyncenabled", typeof(bool)));
                    
                    this.ResourceBookingExchangeSyncVersion = group.Add(new VocabularyKey("ResourceBookingExchangeSyncVersion", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"The version number for resource booking synchronization with Exchange.")
                        .WithDisplayName("User resource booking synchronization version")
                        .ModelProperty("resourcebookingexchangesyncversion", typeof(int)));
                    
                    this.SelectedGlobalFilterId = group.Add(new VocabularyKey("SelectedGlobalFilterId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Store selected customer service hub dashboard saved filter id.")
                        .WithDisplayName("SelectedGlobalFilterId")
                        .ModelProperty("selectedglobalfilterid", typeof(Guid)));
                    
                    this.IsEmailConversationViewEnabled = group.Add(new VocabularyKey("IsEmailConversationViewEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Enable or disable email conversation view on timeline wall selection.")
                        .WithDisplayName("IsEmailConversationViewEnabled")
                        .ModelProperty("isemailconversationviewenabled", typeof(bool)));
                    
                    this.AutoCaptureUserStatus = group.Add(new VocabularyKey("AutoCaptureUserStatus", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Set user status for ADC Suggestions")
                        .WithDisplayName("AutoCaptureUserStatus")
                        .ModelProperty("autocaptureuserstatus", typeof(long)));
                    
                    this.IsAutoDataCaptureEnabled = group.Add(new VocabularyKey("IsAutoDataCaptureEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether to use the Auto Capture feature enabled or not.")
                        .WithDisplayName("IsAutoDataCaptureEnabled")
                        .ModelProperty("isautodatacaptureenabled", typeof(bool)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey SystemUserId { get; private set; }
        
        public VocabularyKey BusinessUnitId { get; private set; }
        
        public VocabularyKey HomepageArea { get; private set; }
        
        public VocabularyKey PagingLimit { get; private set; }
        
        public VocabularyKey HomepageSubarea { get; private set; }
        
        public VocabularyKey DefaultCalendarView { get; private set; }
        
        public VocabularyKey WorkdayStartTime { get; private set; }
        
        public VocabularyKey WorkdayStopTime { get; private set; }
        
        public VocabularyKey IgnoreUnsolicitedEmail { get; private set; }
        
        public VocabularyKey TimeZoneBias { get; private set; }
        
        public VocabularyKey TimeZoneStandardBias { get; private set; }
        
        public VocabularyKey TimeZoneDaylightBias { get; private set; }
        
        public VocabularyKey TimeZoneCode { get; private set; }
        
        public VocabularyKey TimeZoneStandardYear { get; private set; }
        
        public VocabularyKey TimeZoneStandardMonth { get; private set; }
        
        public VocabularyKey TimeZoneStandardDay { get; private set; }
        
        public VocabularyKey TimeZoneStandardDayOfWeek { get; private set; }
        
        public VocabularyKey TimeZoneStandardHour { get; private set; }
        
        public VocabularyKey TimeZoneStandardMinute { get; private set; }
        
        public VocabularyKey TimeZoneStandardSecond { get; private set; }
        
        public VocabularyKey TimeZoneDaylightYear { get; private set; }
        
        public VocabularyKey TimeZoneDaylightMonth { get; private set; }
        
        public VocabularyKey TimeZoneDaylightDay { get; private set; }
        
        public VocabularyKey TimeZoneDaylightDayOfWeek { get; private set; }
        
        public VocabularyKey TimeZoneDaylightHour { get; private set; }
        
        public VocabularyKey TimeZoneDaylightMinute { get; private set; }
        
        public VocabularyKey TimeZoneDaylightSecond { get; private set; }
        
        public VocabularyKey BusinessUnitIdName { get; private set; }
        
        public VocabularyKey IgnoreUnsolicitedEmailName { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey AdvancedFindStartupMode { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey TrackingTokenId { get; private set; }
        
        public VocabularyKey NextTrackingNumber { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey UserProfile { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey NumberSeparator { get; private set; }
        
        public VocabularyKey OutlookSyncInterval { get; private set; }
        
        public VocabularyKey UseCrmFormForTask { get; private set; }
        
        public VocabularyKey PricingDecimalPrecision { get; private set; }
        
        public VocabularyKey SyncContactCompany { get; private set; }
        
        public VocabularyKey DateSeparator { get; private set; }
        
        public VocabularyKey LongDateFormatCode { get; private set; }
        
        public VocabularyKey AllowEmailCredentials { get; private set; }
        
        public VocabularyKey FullNameConventionCode { get; private set; }
        
        public VocabularyKey TimeSeparator { get; private set; }
        
        public VocabularyKey TimeFormatCode { get; private set; }
        
        public VocabularyKey NegativeFormatCode { get; private set; }
        
        public VocabularyKey OfflineSyncInterval { get; private set; }
        
        public VocabularyKey CalendarType { get; private set; }
        
        public VocabularyKey CurrencySymbol { get; private set; }
        
        public VocabularyKey TransactionCurrencyId { get; private set; }
        
        public VocabularyKey UILanguageId { get; private set; }
        
        public VocabularyKey UseCrmFormForContact { get; private set; }
        
        public VocabularyKey CurrencyFormatCode { get; private set; }
        
        public VocabularyKey AddressBookSyncInterval { get; private set; }
        
        public VocabularyKey DecimalSymbol { get; private set; }
        
        public VocabularyKey UseCrmFormForEmail { get; private set; }
        
        public VocabularyKey ShowWeekNumber { get; private set; }
        
        public VocabularyKey NegativeCurrencyFormatCode { get; private set; }
        
        public VocabularyKey TimeFormatString { get; private set; }
        
        public VocabularyKey EmailUsername { get; private set; }
        
        public VocabularyKey DateFormatString { get; private set; }
        
        public VocabularyKey ReportScriptErrors { get; private set; }
        
        public VocabularyKey UseImageStrips { get; private set; }
        
        public VocabularyKey EmailPassword { get; private set; }
        
        public VocabularyKey DateFormatCode { get; private set; }
        
        public VocabularyKey UseCrmFormForAppointment { get; private set; }
        
        public VocabularyKey IsDuplicateDetectionEnabledWhenGoingOnline { get; private set; }
        
        public VocabularyKey LocaleId { get; private set; }
        
        public VocabularyKey IncomingEmailFilteringMethod { get; private set; }
        
        public VocabularyKey CurrencyDecimalPrecision { get; private set; }
        
        public VocabularyKey AMDesignator { get; private set; }
        
        public VocabularyKey NumberGroupFormat { get; private set; }
        
        public VocabularyKey HelpLanguageId { get; private set; }
        
        public VocabularyKey PMDesignator { get; private set; }
        
        public VocabularyKey IncomingEmailFilteringMethodName { get; private set; }
        
        public VocabularyKey ReportScriptErrorsName { get; private set; }
        
        public VocabularyKey AllowEmailCredentialsName { get; private set; }
        
        public VocabularyKey TransactionCurrencyIdName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey PersonalizationSettings { get; private set; }
        
        public VocabularyKey VisualizationPaneLayout { get; private set; }
        
        public VocabularyKey VisualizationPaneLayoutName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey GetStartedPaneContentEnabled { get; private set; }
        
        public VocabularyKey HomepageLayout { get; private set; }
        
        public VocabularyKey DefaultDashboardId { get; private set; }
        
        public VocabularyKey IsSendAsAllowed { get; private set; }
        
        public VocabularyKey AutoCreateContactOnPromote { get; private set; }
        
        public VocabularyKey DataValidationModeForExportToExcel { get; private set; }
        
        public VocabularyKey DataValidationModeForExportToExcelName { get; private set; }
        
        public VocabularyKey EntityFormMode { get; private set; }
        
        public VocabularyKey IsDefaultCountryCodeCheckEnabled { get; private set; }
        
        public VocabularyKey DefaultCountryCode { get; private set; }
        
        public VocabularyKey LastAlertsViewedTime { get; private set; }
        
        public VocabularyKey IsGuidedHelpEnabled { get; private set; }
        
        public VocabularyKey IsAppsForCrmAlertDismissed { get; private set; }
        
        public VocabularyKey DefaultSearchExperience { get; private set; }
        
        public VocabularyKey DefaultSearchExperienceName { get; private set; }
        
        public VocabularyKey SplitViewState { get; private set; }
        
        public VocabularyKey IsResourceBookingExchangeSyncEnabled { get; private set; }
        
        public VocabularyKey ResourceBookingExchangeSyncVersion { get; private set; }
        
        public VocabularyKey SelectedGlobalFilterId { get; private set; }
        
        public VocabularyKey IsEmailConversationViewEnabled { get; private set; }
        
        public VocabularyKey AutoCaptureUserStatus { get; private set; }
        
        public VocabularyKey IsAutoDataCaptureEnabled { get; private set; }
        
        
        }
    }
    
