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
    public abstract class SocialActivityClueProducer<T> : DynamicsClueProducer<T> where T : SocialActivity
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SocialActivityClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=socialactivity&id={1}", _dynamics365CrawlJobData.Api, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;
            /*
             if (input.ActivityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.PostAuthorAccount != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.PostAuthorAccount);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.PostAuthor != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.PostAuthor);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_quickfind, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_sample, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.SLAInvokedId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

                         if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsubscription, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_lookupconfig, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_nurturebuilder, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookinstance, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.PostAuthorAccount != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.PostAuthorAccount);

                         if (input.PostAuthor != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.PostAuthor);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.asyncoperation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_setactivestate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountplan, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.PostFromProfileId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.PostFromProfileId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_numbersequence, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_trace, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_bulktxtmessage, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.site, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ServiceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_expression, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailsend, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.RegardingObjectId);


            */
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.From] = input.From.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.Resources] = input.Resources.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.To] = input.To.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.Community] = input.Community.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SentimentValue] = input.SentimentValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostedOn] = input.PostedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostURL] = input.PostURL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.InResponseTo] = input.InResponseTo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostMessageType] = input.PostMessageType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostId] = input.PostId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ThreadId] = input.ThreadId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.DirectionCode] = input.DirectionCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.DirectionCodeName] = input.DirectionCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostFromProfileId] = input.PostFromProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostToProfileId] = input.PostToProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostMessageTypeName] = input.PostMessageTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostFromProfileIdName] = input.PostFromProfileIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorName] = input.PostAuthorName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorYomiName] = input.PostAuthorYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorType] = input.PostAuthorType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorAccount] = input.PostAuthorAccount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorAccountName] = input.PostAuthorAccountName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorAccountYomiName] = input.PostAuthorAccountYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthorAccountType] = input.PostAuthorAccountType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.PostAuthor] = input.PostAuthor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SocialAdditionalParams] = input.SocialAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialActivity.SortDate] = input.SortDate.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

