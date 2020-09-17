using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class TaskClueProducer<T> : DynamicsClueProducer<T> where T : Task
    {
        public TaskClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {

        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Task, input.ActivityId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=task&id={1}", this._dynamics365CrawlJobData.Url, input.ActivityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;

            //if (input.ActivityId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ActivityId);

            //if (input.RegardingObjectId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.RegardingObjectId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            //if (input.ServiceId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);

            var vocab = new TaskVocabulary();

            data.Properties[vocab.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[vocab.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[vocab.ScheduledStart] = input.ScheduledStart.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[vocab.ScheduledDurationMinutes] = input.ScheduledDurationMinutes.PrintIfAvailable();
            data.Properties[vocab.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.ActivityId] = input.ActivityId.PrintIfAvailable();
            data.Properties[vocab.Category] = input.Category.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.IsWorkflowCreated] = input.IsWorkflowCreated.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.Subcategory] = input.Subcategory.PrintIfAvailable();
            data.Properties[vocab.ScheduledEnd] = input.ScheduledEnd.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.PercentComplete] = input.PercentComplete.PrintIfAvailable();
            data.Properties[vocab.SubscriptionId] = input.SubscriptionId.PrintIfAvailable();
            data.Properties[vocab.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[vocab.ActualDurationMinutes] = input.ActualDurationMinutes.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.IsBilled] = input.IsBilled.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[vocab.IsWorkflowCreatedName] = input.IsWorkflowCreatedName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.IsBilledName] = input.IsBilledName.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ActivityTypeCode] = input.ActivityTypeCode.PrintIfAvailable();
            data.Properties[vocab.ActivityTypeCodeName] = input.ActivityTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.IsRegularActivity] = input.IsRegularActivity.PrintIfAvailable();
            data.Properties[vocab.IsRegularActivityName] = input.IsRegularActivityName.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.CrmTaskAssignedUniqueId] = input.CrmTaskAssignedUniqueId.PrintIfAvailable();
            data.Properties[vocab.ActivityAdditionalParams] = input.ActivityAdditionalParams.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.SortDate] = input.SortDate.PrintIfAvailable();

            // Add custom vocab
            foreach (var key in input.Custom.Keys)
            {
                var vocabName = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                var vocabKey = new VocabularyKey(vocabName, VocabularyKeyDataType.Json, VocabularyKeyVisibility.Visible);
                data.Properties[vocabKey] = input.Custom[key].ToString().PrintIfAvailable();
            }

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

