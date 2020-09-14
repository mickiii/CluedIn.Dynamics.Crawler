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
    public abstract class OrganizationClueProducer<T> : DynamicsClueProducer<T> where T : Organization
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OrganizationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.OrganizationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=organization&id={1}", _dynamics365CrawlJobData.Api, input.OrganizationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.DefaultMobileOfflineProfileId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mobileofflineprofile, EntityEdgeType.Parent, input, input.DefaultMobileOfflineProfileId);

                         if (input.DefaultEmailServerProfileId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.emailserverprofile, EntityEdgeType.Parent, input, input.DefaultEmailServerProfileId);

                         if (input.BusinessClosureCalendarId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.calendar, EntityEdgeType.Parent, input, input.BusinessClosureCalendarId);

                         if (input.BaseCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.BaseCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.AcknowledgementTemplateId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.template, EntityEdgeType.Parent, input, input.AcknowledgementTemplateId);


            */
            data.Properties[Dynamics365Vocabulary.Organization.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UserGroupId] = input.UserGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PrivilegeUserGroupId] = input.PrivilegeUserGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RecurrenceExpansionJobBatchSize] = input.RecurrenceExpansionJobBatchSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RecurrenceExpansionJobBatchInterval] = input.RecurrenceExpansionJobBatchInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalPeriodType] = input.FiscalPeriodType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalCalendarStart] = input.FiscalCalendarStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DateFormatCode] = input.DateFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TimeFormatCode] = input.TimeFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrencySymbol] = input.CurrencySymbol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.WeekStartDayCode] = input.WeekStartDayCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DateSeparator] = input.DateSeparator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FullNameConventionCode] = input.FullNameConventionCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NegativeFormatCode] = input.NegativeFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NumberFormat] = input.NumberFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDisabled] = input.IsDisabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DisabledReason] = input.DisabledReason.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.KbPrefix] = input.KbPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentKbNumber] = input.CurrentKbNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CasePrefix] = input.CasePrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentCaseNumber] = input.CurrentCaseNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ContractPrefix] = input.ContractPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentContractNumber] = input.CurrentContractNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.QuotePrefix] = input.QuotePrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentQuoteNumber] = input.CurrentQuoteNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OrderPrefix] = input.OrderPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentOrderNumber] = input.CurrentOrderNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.InvoicePrefix] = input.InvoicePrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentInvoiceNumber] = input.CurrentInvoiceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UniqueSpecifierLength] = input.UniqueSpecifierLength.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormat] = input.FiscalYearFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalPeriodFormat] = input.FiscalPeriodFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearPeriodConnect] = input.FiscalYearPeriodConnect.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.LanguageCode] = input.LanguageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SortId] = input.SortId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DateFormatString] = input.DateFormatString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TimeFormatString] = input.TimeFormatString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PricingDecimalPrecision] = input.PricingDecimalPrecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ShowWeekNumber] = input.ShowWeekNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ShowWeekNumberName] = input.ShowWeekNumberName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDisabledName] = input.IsDisabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DateFormatCodeName] = input.DateFormatCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FullNameConventionCodeName] = input.FullNameConventionCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.LanguageCodeName] = input.LanguageCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TimeFormatCodeName] = input.TimeFormatCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NegativeFormatCodeName] = input.NegativeFormatCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.WeekStartDayCodeName] = input.WeekStartDayCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NextTrackingNumber] = input.NextTrackingNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TagMaxAggressiveCycles] = input.TagMaxAggressiveCycles.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TokenKey] = input.TokenKey.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SystemUserId] = input.SystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GrantAccessToNetworkService] = input.GrantAccessToNetworkService.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowOutlookScheduledSyncs] = input.AllowOutlookScheduledSyncs.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowMarketingEmailExecution] = input.AllowMarketingEmailExecution.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SqlAccessGroupId] = input.SqlAccessGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrencyFormatCode] = input.CurrencyFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalSettingsUpdated] = input.FiscalSettingsUpdated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ReportingGroupId] = input.ReportingGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TokenExpiry] = input.TokenExpiry.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ShareToPreviousOwnerOnAssign] = input.ShareToPreviousOwnerOnAssign.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AcknowledgementTemplateId] = input.AcknowledgementTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IntegrationUserId] = input.IntegrationUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TrackingTokenIdBase] = input.TrackingTokenIdBase.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BusinessClosureCalendarId] = input.BusinessClosureCalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowAutoUnsubscribeAcknowledgement] = input.AllowAutoUnsubscribeAcknowledgement.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowAutoUnsubscribe] = input.AllowAutoUnsubscribe.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.Picture] = input.Picture.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TrackingPrefix] = input.TrackingPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MinOutlookSyncInterval] = input.MinOutlookSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BulkOperationPrefix] = input.BulkOperationPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowAutoResponseCreation] = input.AllowAutoResponseCreation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaximumTrackingNumber] = input.MaximumTrackingNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CampaignPrefix] = input.CampaignPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SqlAccessGroupName] = input.SqlAccessGroupName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentCampaignNumber] = input.CurrentCampaignNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearDisplayCode] = input.FiscalYearDisplayCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SiteMapXml] = input.SiteMapXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ReportingGroupName] = input.ReportingGroupName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentBulkOperationNumber] = input.CurrentBulkOperationNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SchemaNamePrefix] = input.SchemaNamePrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IgnoreInternalEmail] = input.IgnoreInternalEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TagPollingPeriod] = input.TagPollingPeriod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TrackingTokenIdDigits] = input.TrackingTokenIdDigits.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AcknowledgementTemplateIdName] = input.AcknowledgementTemplateIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrencyFormatCodeName] = input.CurrencyFormatCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalSettingsUpdatedName] = input.FiscalSettingsUpdatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NumberGroupFormat] = input.NumberGroupFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.LongDateFormatCode] = input.LongDateFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentImportSequenceNumber] = input.CurrentImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ParsedTablePrefix] = input.ParsedTablePrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.V3CalloutConfigHash] = input.V3CalloutConfigHash.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsFiscalPeriodMonthBased] = input.IsFiscalPeriodMonthBased.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.LocaleId] = input.LocaleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ParsedTableColumnPrefix] = input.ParsedTableColumnPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SupportUserId] = input.SupportUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AMDesignator] = input.AMDesignator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrencyDisplayOption] = input.CurrencyDisplayOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MinAddressBookSyncInterval] = input.MinAddressBookSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDuplicateDetectionEnabledForOnlineCreateUpdate] = input.IsDuplicateDetectionEnabledForOnlineCreateUpdate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FeatureSet] = input.FeatureSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BlockedAttachments] = input.BlockedAttachments.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDuplicateDetectionEnabledForOfflineSync] = input.IsDuplicateDetectionEnabledForOfflineSync.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowOfflineScheduledSyncs] = input.AllowOfflineScheduledSyncs.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowUnresolvedPartiesOnEmailSend] = input.AllowUnresolvedPartiesOnEmailSend.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TimeSeparator] = input.TimeSeparator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentParsedTableNumber] = input.CurrentParsedTableNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MinOfflineSyncInterval] = input.MinOfflineSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowWebExcelExport] = input.AllowWebExcelExport.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ReferenceSiteMapXml] = input.ReferenceSiteMapXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDuplicateDetectionEnabledForImport] = input.IsDuplicateDetectionEnabledForImport.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CalendarType] = input.CalendarType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SQMEnabled] = input.SQMEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NegativeCurrencyFormatCode] = input.NegativeCurrencyFormatCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowAddressBookSyncs] = input.AllowAddressBookSyncs.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ISVIntegrationCode] = input.ISVIntegrationCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DecimalSymbol] = input.DecimalSymbol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxUploadFileSize] = input.MaxUploadFileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAppMode] = input.IsAppMode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnablePricingOnCreate] = input.EnablePricingOnCreate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsSOPIntegrationEnabled] = input.IsSOPIntegrationEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PMDesignator] = input.PMDesignator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrencyDecimalPrecision] = input.CurrencyDecimalPrecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxAppointmentDurationDays] = input.MaxAppointmentDurationDays.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EmailSendPollingPeriod] = input.EmailSendPollingPeriod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RenderSecureIFrameForEmail] = input.RenderSecureIFrameForEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NumberSeparator] = input.NumberSeparator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PrivReportingGroupId] = input.PrivReportingGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BaseCurrencyId] = input.BaseCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxRecordsForExportToExcel] = input.MaxRecordsForExportToExcel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PrivReportingGroupName] = input.PrivReportingGroupName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.YearStartWeekCode] = input.YearStartWeekCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPresenceEnabled] = input.IsPresenceEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDuplicateDetectionEnabled] = input.IsDuplicateDetectionEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BaseCurrencyIdName] = input.BaseCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPresenceEnabledName] = input.IsPresenceEnabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ExpireSubscriptionsInDays] = input.ExpireSubscriptionsInDays.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAuditEnabled] = input.IsAuditEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BaseCurrencyPrecision] = input.BaseCurrencyPrecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BaseCurrencySymbol] = input.BaseCurrencySymbol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BaseISOCurrencyCode] = input.BaseISOCurrencyCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TraceLogMaximumAgeInDays] = input.TraceLogMaximumAgeInDays.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NextCustomObjectTypeCode] = input.NextCustomObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxRecordsForLookupFilters] = input.MaxRecordsForLookupFilters.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowEntityOnlyAudit] = input.AllowEntityOnlyAudit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultRecurrenceEndRangeType] = input.DefaultRecurrenceEndRangeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultRecurrenceEndRangeTypeName] = input.DefaultRecurrenceEndRangeTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FutureExpansionWindow] = input.FutureExpansionWindow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PastExpansionWindow] = input.PastExpansionWindow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RecurrenceExpansionSynchCreateMax] = input.RecurrenceExpansionSynchCreateMax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RecurrenceDefaultNumberOfOccurrences] = input.RecurrenceDefaultNumberOfOccurrences.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GetStartedPaneContentEnabled] = input.GetStartedPaneContentEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UseReadForm] = input.UseReadForm.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.InitialVersion] = input.InitialVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SampleDataImportId] = input.SampleDataImportId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ReportScriptErrors] = input.ReportScriptErrors.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ReportScriptErrorsName] = input.ReportScriptErrorsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RequireApprovalForUserEmail] = input.RequireApprovalForUserEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RequireApprovalForQueueEmail] = input.RequireApprovalForQueueEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GoalRollupExpiryTime] = input.GoalRollupExpiryTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GoalRollupFrequency] = input.GoalRollupFrequency.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AutoApplyDefaultonCaseCreate] = input.AutoApplyDefaultonCaseCreate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AutoApplyDefaultonCaseCreateName] = input.AutoApplyDefaultonCaseCreateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AutoApplyDefaultonCaseUpdate] = input.AutoApplyDefaultonCaseUpdate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AutoApplyDefaultonCaseUpdateName] = input.AutoApplyDefaultonCaseUpdateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormatPrefix] = input.FiscalYearFormatPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormatPrefixName] = input.FiscalYearFormatPrefixName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormatSuffix] = input.FiscalYearFormatSuffix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormatSuffixName] = input.FiscalYearFormatSuffixName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormatYear] = input.FiscalYearFormatYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalYearFormatYearName] = input.FiscalYearFormatYearName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DiscountCalculationMethod] = input.DiscountCalculationMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalPeriodFormatPeriod] = input.FiscalPeriodFormatPeriod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.FiscalPeriodFormatPeriodName] = input.FiscalPeriodFormatPeriodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowClientMessageBarAd] = input.AllowClientMessageBarAd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowUserFormModePreference] = input.AllowUserFormModePreference.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.HashFilterKeywords] = input.HashFilterKeywords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.HashMaxCount] = input.HashMaxCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.HashDeltaSubjectCount] = input.HashDeltaSubjectCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.HashMinAddressCount] = input.HashMinAddressCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableSmartMatching] = input.EnableSmartMatching.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PinpointLanguageCode] = input.PinpointLanguageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OrgDbOrgSettings] = input.OrgDbOrgSettings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsUserAccessAuditEnabled] = input.IsUserAccessAuditEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UserAccessAuditingInterval] = input.UserAccessAuditingInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.QuickFindRecordLimitEnabled] = input.QuickFindRecordLimitEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableBingMapsIntegration] = input.EnableBingMapsIntegration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDefaultCountryCodeCheckEnabled] = input.IsDefaultCountryCodeCheckEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultCountryCode] = input.DefaultCountryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UseSkypeProtocol] = input.UseSkypeProtocol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IncomingEmailExchangeEmailRetrievalBatchSize] = input.IncomingEmailExchangeEmailRetrievalBatchSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EmailCorrelationEnabled] = input.EmailCorrelationEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MetadataSyncTimestamp] = input.MetadataSyncTimestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MetadataSyncLastTimeOfNeverExpiredDeletedObjects] = input.MetadataSyncLastTimeOfNeverExpiredDeletedObjects.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.YammerOAuthAccessTokenExpired] = input.YammerOAuthAccessTokenExpired.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultEmailSettings] = input.DefaultEmailSettings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.YammerGroupId] = input.YammerGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.YammerNetworkPermalink] = input.YammerNetworkPermalink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.YammerPostMethod] = input.YammerPostMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultEmailServerProfileIdName] = input.DefaultEmailServerProfileIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EmailConnectionChannel] = input.EmailConnectionChannel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultEmailServerProfileId] = input.DefaultEmailServerProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAutoSaveEnabled] = input.IsAutoSaveEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BingMapsApiKey] = input.BingMapsApiKey.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GenerateAlertsForErrors] = input.GenerateAlertsForErrors.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GenerateAlertsForInformation] = input.GenerateAlertsForInformation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GenerateAlertsForWarnings] = input.GenerateAlertsForWarnings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.NotifyMailboxOwnerOfEmailServerLevelAlerts] = input.NotifyMailboxOwnerOfEmailServerLevelAlerts.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaximumActiveBusinessProcessFlowsAllowedPerEntity] = input.MaximumActiveBusinessProcessFlowsAllowedPerEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowUsersSeeAppdownloadMessage] = input.AllowUsersSeeAppdownloadMessage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SignupOutlookDownloadFWLink] = input.SignupOutlookDownloadFWLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CascadeStatusUpdate] = input.CascadeStatusUpdate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RestrictStatusUpdate] = input.RestrictStatusUpdate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SuppressSLA] = input.SuppressSLA.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SocialInsightsTermsAccepted] = input.SocialInsightsTermsAccepted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SocialInsightsInstance] = input.SocialInsightsInstance.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DisableSocialCare] = input.DisableSocialCare.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxProductsInBundle] = input.MaxProductsInBundle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UseInbuiltRuleForDefaultPricelistSelection] = input.UseInbuiltRuleForDefaultPricelistSelection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OOBPriceCalculationEnabled] = input.OOBPriceCalculationEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsHierarchicalSecurityModelEnabled] = input.IsHierarchicalSecurityModelEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaximumDynamicPropertiesAllowed] = input.MaximumDynamicPropertiesAllowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UsePositionHierarchy] = input.UsePositionHierarchy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxDepthForHierarchicalSecurityModel] = input.MaxDepthForHierarchicalSecurityModel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SlaPauseStates] = input.SlaPauseStates.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SocialInsightsEnabled] = input.SocialInsightsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAppointmentAttachmentSyncEnabled] = input.IsAppointmentAttachmentSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAssignedTasksSyncEnabled] = input.IsAssignedTasksSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsContactMailingAddressSyncEnabled] = input.IsContactMailingAddressSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxSupportedInternetExplorerVersion] = input.MaxSupportedInternetExplorerVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GlobalHelpUrl] = input.GlobalHelpUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GlobalHelpUrlEnabled] = input.GlobalHelpUrlEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.GlobalAppendUrlParametersEnabled] = input.GlobalAppendUrlParametersEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.KMSettings] = input.KMSettings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CreateProductsWithoutParentInActiveState] = input.CreateProductsWithoutParentInActiveState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMailboxInactiveBackoffEnabled] = input.IsMailboxInactiveBackoffEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsFullTextSearchEnabled] = input.IsFullTextSearchEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnforceReadOnlyPlugins] = input.EnforceReadOnlyPlugins.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SharePointDeploymentType] = input.SharePointDeploymentType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OrganizationState] = input.OrganizationState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultThemeData] = input.DefaultThemeData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsFolderBasedTrackingEnabled] = input.IsFolderBasedTrackingEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.WebResourceHash] = input.WebResourceHash.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ExpireChangeTrackingInDays] = input.ExpireChangeTrackingInDays.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxFolderBasedTrackingMappings] = input.MaxFolderBasedTrackingMappings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PrivacyStatementUrl] = input.PrivacyStatementUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PluginTraceLogSetting] = input.PluginTraceLogSetting.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PluginTraceLogSettingName] = input.PluginTraceLogSettingName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMailboxForcedUnlockingEnabled] = input.IsMailboxForcedUnlockingEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MailboxIntermittentIssueMinRange] = input.MailboxIntermittentIssueMinRange.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MailboxPermanentIssueMinRange] = input.MailboxPermanentIssueMinRange.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.HighContrastThemeData] = input.HighContrastThemeData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DelegatedAdminUserId] = input.DelegatedAdminUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsExternalSearchIndexEnabled] = input.IsExternalSearchIndexEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMobileOfflineEnabled] = input.IsMobileOfflineEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsOfficeGraphEnabled] = input.IsOfficeGraphEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsOneDriveEnabled] = input.IsOneDriveEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ExternalPartyEntitySettings] = input.ExternalPartyEntitySettings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ExternalPartyCorrelationKeys] = input.ExternalPartyCorrelationKeys.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxVerboseLoggingMailbox] = input.MaxVerboseLoggingMailbox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxVerboseLoggingSyncCycles] = input.MaxVerboseLoggingSyncCycles.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MobileOfflineSyncInterval] = input.MobileOfflineSyncInterval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OfficeGraphDelveUrl] = input.OfficeGraphDelveUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MobileOfflineMinLicenseTrial] = input.MobileOfflineMinLicenseTrial.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MobileOfflineMinLicenseProd] = input.MobileOfflineMinLicenseProd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DaysSinceRecordLastModifiedMaxValue] = input.DaysSinceRecordLastModifiedMaxValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TaskBasedFlowEnabled] = input.TaskBasedFlowEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ShowKBArticleDeprecationNotification] = input.ShowKBArticleDeprecationNotification.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AzureSchedulerJobCollectionName] = input.AzureSchedulerJobCollectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CortanaProactiveExperienceEnabled] = input.CortanaProactiveExperienceEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OfficeAppsAutoDeploymentEnabled] = input.OfficeAppsAutoDeploymentEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AppDesignerExperienceEnabled] = input.AppDesignerExperienceEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableImmersiveSkypeIntegration] = input.EnableImmersiveSkypeIntegration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AutoApplySLA] = input.AutoApplySLA.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsEmailServerProfileContentFilteringEnabled] = input.IsEmailServerProfileContentFilteringEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDelegateAccessEnabled] = input.IsDelegateAccessEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DisplayNavigationTour] = input.DisplayNavigationTour.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UseLegacyRendering] = input.UseLegacyRendering.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultMobileOfflineProfileId] = input.DefaultMobileOfflineProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultMobileOfflineProfileIdName] = input.DefaultMobileOfflineProfileIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.KaPrefix] = input.KaPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentKaNumber] = input.CurrentKaNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CurrentCategoryNumber] = input.CurrentCategoryNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.CategoryPrefix] = input.CategoryPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaximumEntitiesWithActiveSLA] = input.MaximumEntitiesWithActiveSLA.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaximumSLAKPIPerEntityWithActiveSLA] = input.MaximumSLAKPIPerEntityWithActiveSLA.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsConflictDetectionEnabledForMobileClient] = input.IsConflictDetectionEnabledForMobileClient.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsDelveActionHubIntegrationEnabled] = input.IsDelveActionHubIntegrationEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.OrgInsightsEnabled] = input.OrgInsightsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ProductRecommendationsEnabled] = input.ProductRecommendationsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.TextAnalyticsEnabled] = input.TextAnalyticsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxConditionsForMobileOfflineFilters] = input.MaxConditionsForMobileOfflineFilters.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsFolderAutoCreatedonSP] = input.IsFolderAutoCreatedonSP.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PowerBiFeatureEnabled] = input.PowerBiFeatureEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsActionCardEnabled] = input.IsActionCardEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsEmailMonitoringAllowed] = input.IsEmailMonitoringAllowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsActivityAnalysisEnabled] = input.IsActivityAnalysisEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAutoDataCaptureEnabled] = input.IsAutoDataCaptureEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ExternalBaseUrl] = input.ExternalBaseUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPreviewEnabledForActionCard] = input.IsPreviewEnabledForActionCard.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPreviewForEmailMonitoringAllowed] = input.IsPreviewForEmailMonitoringAllowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UnresolveEmailAddressIfMultipleMatch] = input.UnresolveEmailAddressIfMultipleMatch.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.RiErrorStatus] = input.RiErrorStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.WidgetProperties] = input.WidgetProperties.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableMicrosoftFlowIntegration] = input.EnableMicrosoftFlowIntegration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsEnabledForAllRoles] = input.IsEnabledForAllRoles.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPreviewForAutoCaptureEnabled] = input.IsPreviewForAutoCaptureEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.DefaultCrmCustomName] = input.DefaultCrmCustomName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ACIWebEndpointUrl] = input.ACIWebEndpointUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableLPAuthoring] = input.EnableLPAuthoring.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsResourceBookingExchangeSyncEnabled] = input.IsResourceBookingExchangeSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMobileClientOnDemandSyncEnabled] = input.IsMobileClientOnDemandSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PostMessageWhitelistDomains] = input.PostMessageWhitelistDomains.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsRelationshipInsightsEnabled] = input.IsRelationshipInsightsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ResolveSimilarUnresolvedEmailAddress] = input.ResolveSimilarUnresolvedEmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsTextWrapEnabled] = input.IsTextWrapEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SessionTimeoutEnabled] = input.SessionTimeoutEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SessionTimeoutInMins] = input.SessionTimeoutInMins.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SessionTimeoutReminderInMins] = input.SessionTimeoutReminderInMins.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MicrosoftFlowEnvironment] = input.MicrosoftFlowEnvironment.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.InactivityTimeoutEnabled] = input.InactivityTimeoutEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.InactivityTimeoutInMins] = input.InactivityTimeoutInMins.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.InactivityTimeoutReminderInMins] = input.InactivityTimeoutReminderInMins.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SyncOptInSelection] = input.SyncOptInSelection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SyncOptInSelectionStatus] = input.SyncOptInSelectionStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsActionSupportFeatureEnabled] = input.IsActionSupportFeatureEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsBPFEntityCustomizationFeatureEnabled] = input.IsBPFEntityCustomizationFeatureEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BoundDashboardDefaultCardExpanded] = input.BoundDashboardDefaultCardExpanded.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.MaxActionStepsInBPF] = input.MaxActionStepsInBPF.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ServeStaticResourcesFromAzureCDN] = input.ServeStaticResourcesFromAzureCDN.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsExternalFileStorageEnabled] = input.IsExternalFileStorageEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ClientFeatureSet] = input.ClientFeatureSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsReadAuditEnabled] = input.IsReadAuditEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsNotesAnalysisEnabled] = input.IsNotesAnalysisEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowLegacyDialogsEmbedding] = input.AllowLegacyDialogsEmbedding.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AllowLegacyClientExperience] = input.AllowLegacyClientExperience.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMSTeamsEnabled] = input.IsMSTeamsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsLUISEnabledforD365Bot] = input.IsLUISEnabledforD365Bot.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SyncBulkOperationBatchSize] = input.SyncBulkOperationBatchSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SyncBulkOperationMaxLimit] = input.SyncBulkOperationMaxLimit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableUnifiedInterfaceShellRefresh] = input.EnableUnifiedInterfaceShellRefresh.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMSTeamsSettingChangedByUser] = input.IsMSTeamsSettingChangedByUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableLivePersonaCardUCI] = input.EnableLivePersonaCardUCI.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMSTeamsCollaborationEnabled] = input.IsMSTeamsCollaborationEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsMSTeamsUserSyncEnabled] = input.IsMSTeamsUserSyncEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsManualSalesForecastingEnabled] = input.IsManualSalesForecastingEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPDFGenerationEnabled] = input.IsPDFGenerationEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsCustomControlsInCanvasAppsEnabled] = input.IsCustomControlsInCanvasAppsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPAIEnabled] = input.IsPAIEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsQuickCreateEnabledForOpportunityClose] = input.IsQuickCreateEnabledForOpportunityClose.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.ContentSecurityPolicyConfiguration] = input.ContentSecurityPolicyConfiguration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsContentSecurityPolicyEnabled] = input.IsContentSecurityPolicyEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPriceListMandatory] = input.IsPriceListMandatory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.EnableLivePersonCardIntegrationInOffice] = input.EnableLivePersonCardIntegrationInOffice.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsContextualEmailEnabled] = input.IsContextualEmailEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.QualifyLeadAdditionalOptions] = input.QualifyLeadAdditionalOptions.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.BusinessCardOptions] = input.BusinessCardOptions.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsPlaybookEnabled] = input.IsPlaybookEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.PaiPreviewScenarioEnabled] = input.PaiPreviewScenarioEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsContextualHelpEnabled] = input.IsContextualHelpEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsSalesAssistantEnabled] = input.IsSalesAssistantEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAutoDataCaptureV2Enabled] = input.IsAutoDataCaptureV2Enabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsNewAddProductExperienceEnabled] = input.IsNewAddProductExperienceEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AuditRetentionPeriod] = input.AuditRetentionPeriod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.UseQuickFindViewForGridSearch] = input.UseQuickFindViewForGridSearch.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsRichTextNotesEnabled] = input.IsRichTextNotesEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SendBulkEmailInUCI] = input.SendBulkEmailInUCI.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsAllMoneyDecimal] = input.IsAllMoneyDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.IsWriteInProductsAllowed] = input.IsWriteInProductsAllowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.AppointmentRichEditorExperience] = input.AppointmentRichEditorExperience.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.appointmentricheditorexperienceName] = input.appointmentricheditorexperienceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.SchedulingEngine] = input.SchedulingEngine.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Organization.schedulingengineName] = input.schedulingengineName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

