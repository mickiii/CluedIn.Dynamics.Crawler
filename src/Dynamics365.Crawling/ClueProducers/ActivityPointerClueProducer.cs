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
    public abstract class ActivityPointerClueProducer<T> : DynamicsClueProducer<T> where T : ActivityPointer
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ActivityPointerClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActivityId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=activitypointer&id={1}", _dynamics365CrawlJobData.Url, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.OwningTeam != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_quickfind, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.interactionforemail, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_sample, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.SLAId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.SLAInvokedId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsubscription, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_lookupconfig, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_nurturebuilder, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookinstance, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.TransactionCurrencyId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.OwningBusinessUnit != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_setactivestate, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.ModifiedBy != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

            //if (input.OwningUser != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

            //if (input.CreatedBy != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

            //if (input.ModifiedOnBehalfBy != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

            //if (input.CreatedOnBehalfBy != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountplan, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.SenderMailboxId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.SenderMailboxId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_numbersequence, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_trace, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_bulktxtmessage, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.OwnerId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.site, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.ServiceId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_expression, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailsend, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.RegardingObjectId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.RegardingObjectId);

            var vocab = new ActivityPointerVocabulary();

            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[vocab.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[vocab.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[vocab.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[vocab.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[vocab.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[vocab.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[vocab.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[vocab.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[vocab.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[vocab.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.ServiceIdName] = input.ServiceIdName.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.InstanceTypeCode] = input.InstanceTypeCode.PrintIfAvailable();
            data.Properties[vocab.SeriesId] = input.SeriesId.PrintIfAvailable();
            data.Properties[vocab.InstanceTypeCodeName] = input.InstanceTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[vocab.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.allparties] = input.allparties.PrintIfAvailable();
            data.Properties[vocab.LeftVoiceMail] = input.LeftVoiceMail.PrintIfAvailable();
            data.Properties[vocab.LeftVoiceMailName] = input.LeftVoiceMailName.PrintIfAvailable();
            data.Properties[vocab.Community] = input.Community.PrintIfAvailable();
            data.Properties[vocab.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.IsMapiPrivate] = input.IsMapiPrivate.PrintIfAvailable();
            data.Properties[vocab.IsMapiPrivateName] = input.IsMapiPrivateName.PrintIfAvailable();
            data.Properties[vocab.ExchangeWebLink] = input.ExchangeWebLink.PrintIfAvailable();
            data.Properties[vocab.ExchangeItemId] = input.ExchangeItemId.PrintIfAvailable();
            data.Properties[vocab.DeliveryPriorityCode] = input.DeliveryPriorityCode.PrintIfAvailable();
            data.Properties[vocab.DeliveryPriorityCodeName] = input.DeliveryPriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.SentOn] = input.SentOn.PrintIfAvailable();
            data.Properties[vocab.DeliveryLastAttemptedOn] = input.DeliveryLastAttemptedOn.PrintIfAvailable();
            data.Properties[vocab.SenderMailboxId] = input.SenderMailboxId.PrintIfAvailable();
            data.Properties[vocab.SenderMailboxIdName] = input.SenderMailboxIdName.PrintIfAvailable();
            data.Properties[vocab.PostponeActivityProcessingUntil] = input.PostponeActivityProcessingUntil.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.SortDate] = input.SortDate.PrintIfAvailable();

            // Add custom fields
            foreach (var key in input.Custom.Keys)
            {
                var customVocab = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                data.Properties[customVocab] = input.Custom[key].PrintIfAvailable();
            }

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

