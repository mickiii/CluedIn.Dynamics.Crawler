using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class UserSettingsClueProducer<T> : DynamicsClueProducer<T> where T : UserSettings
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public UserSettingsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.SystemUserId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=usersettings&id={1}", _dynamics365CrawlJobData.Api, input.SystemUserId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.BusinessUnitId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.BusinessUnitId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.SystemUserId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SystemUserId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.UserSettings.SystemUserId] = input.SystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.HomepageArea] = input.HomepageArea.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.PagingLimit] = input.PagingLimit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.HomepageSubarea] = input.HomepageSubarea.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DefaultCalendarView] = input.DefaultCalendarView.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.WorkdayStartTime] = input.WorkdayStartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.WorkdayStopTime] = input.WorkdayStopTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IgnoreUnsolicitedEmail] = input.IgnoreUnsolicitedEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneBias] = input.TimeZoneBias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardBias] = input.TimeZoneStandardBias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightBias] = input.TimeZoneDaylightBias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneCode] = input.TimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardYear] = input.TimeZoneStandardYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardMonth] = input.TimeZoneStandardMonth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardDay] = input.TimeZoneStandardDay.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardDayOfWeek] = input.TimeZoneStandardDayOfWeek.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardHour] = input.TimeZoneStandardHour.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardMinute] = input.TimeZoneStandardMinute.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneStandardSecond] = input.TimeZoneStandardSecond.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightYear] = input.TimeZoneDaylightYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightMonth] = input.TimeZoneDaylightMonth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightDay] = input.TimeZoneDaylightDay.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightDayOfWeek] = input.TimeZoneDaylightDayOfWeek.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightHour] = input.TimeZoneDaylightHour.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightMinute] = input.TimeZoneDaylightMinute.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeZoneDaylightSecond] = input.TimeZoneDaylightSecond.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IgnoreUnsolicitedEmailName] = input.IgnoreUnsolicitedEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AdvancedFindStartupMode] = input.AdvancedFindStartupMode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TrackingTokenId] = input.TrackingTokenId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.NextTrackingNumber] = input.NextTrackingNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UserProfile] = input.UserProfile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.NumberSeparator] = input.NumberSeparator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.OutlookSyncInterval] = input.OutlookSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UseCrmFormForTask] = input.UseCrmFormForTask.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.PricingDecimalPrecision] = input.PricingDecimalPrecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.SyncContactCompany] = input.SyncContactCompany.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DateSeparator] = input.DateSeparator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.LongDateFormatCode] = input.LongDateFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AllowEmailCredentials] = input.AllowEmailCredentials.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.FullNameConventionCode] = input.FullNameConventionCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeSeparator] = input.TimeSeparator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeFormatCode] = input.TimeFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.NegativeFormatCode] = input.NegativeFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.OfflineSyncInterval] = input.OfflineSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CalendarType] = input.CalendarType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CurrencySymbol] = input.CurrencySymbol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UILanguageId] = input.UILanguageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UseCrmFormForContact] = input.UseCrmFormForContact.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CurrencyFormatCode] = input.CurrencyFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AddressBookSyncInterval] = input.AddressBookSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DecimalSymbol] = input.DecimalSymbol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UseCrmFormForEmail] = input.UseCrmFormForEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ShowWeekNumber] = input.ShowWeekNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.NegativeCurrencyFormatCode] = input.NegativeCurrencyFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TimeFormatString] = input.TimeFormatString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.EmailUsername] = input.EmailUsername.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DateFormatString] = input.DateFormatString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ReportScriptErrors] = input.ReportScriptErrors.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UseImageStrips] = input.UseImageStrips.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.EmailPassword] = input.EmailPassword.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DateFormatCode] = input.DateFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.UseCrmFormForAppointment] = input.UseCrmFormForAppointment.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsDuplicateDetectionEnabledWhenGoingOnline] = input.IsDuplicateDetectionEnabledWhenGoingOnline.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.LocaleId] = input.LocaleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IncomingEmailFilteringMethod] = input.IncomingEmailFilteringMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CurrencyDecimalPrecision] = input.CurrencyDecimalPrecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AMDesignator] = input.AMDesignator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.NumberGroupFormat] = input.NumberGroupFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.HelpLanguageId] = input.HelpLanguageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.PMDesignator] = input.PMDesignator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IncomingEmailFilteringMethodName] = input.IncomingEmailFilteringMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ReportScriptErrorsName] = input.ReportScriptErrorsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AllowEmailCredentialsName] = input.AllowEmailCredentialsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.PersonalizationSettings] = input.PersonalizationSettings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.VisualizationPaneLayout] = input.VisualizationPaneLayout.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.VisualizationPaneLayoutName] = input.VisualizationPaneLayoutName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.GetStartedPaneContentEnabled] = input.GetStartedPaneContentEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.HomepageLayout] = input.HomepageLayout.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DefaultDashboardId] = input.DefaultDashboardId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsSendAsAllowed] = input.IsSendAsAllowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AutoCreateContactOnPromote] = input.AutoCreateContactOnPromote.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DataValidationModeForExportToExcel] = input.DataValidationModeForExportToExcel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DataValidationModeForExportToExcelName] = input.DataValidationModeForExportToExcelName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.EntityFormMode] = input.EntityFormMode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsDefaultCountryCodeCheckEnabled] = input.IsDefaultCountryCodeCheckEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DefaultCountryCode] = input.DefaultCountryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.LastAlertsViewedTime] = input.LastAlertsViewedTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsGuidedHelpEnabled] = input.IsGuidedHelpEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsAppsForCrmAlertDismissed] = input.IsAppsForCrmAlertDismissed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DefaultSearchExperience] = input.DefaultSearchExperience.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.DefaultSearchExperienceName] = input.DefaultSearchExperienceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.SplitViewState] = input.SplitViewState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsResourceBookingExchangeSyncEnabled] = input.IsResourceBookingExchangeSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.ResourceBookingExchangeSyncVersion] = input.ResourceBookingExchangeSyncVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.SelectedGlobalFilterId] = input.SelectedGlobalFilterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsEmailConversationViewEnabled] = input.IsEmailConversationViewEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.AutoCaptureUserStatus] = input.AutoCaptureUserStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserSettings.IsAutoDataCaptureEnabled] = input.IsAutoDataCaptureEnabled.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

