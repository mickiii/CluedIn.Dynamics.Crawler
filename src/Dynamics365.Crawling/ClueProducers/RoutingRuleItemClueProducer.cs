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
    public abstract class RoutingRuleItemClueProducer<T> : DynamicsClueProducer<T> where T : RoutingRuleItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RoutingRuleItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RoutingRuleItemId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=routingruleitem&id={1}", _dynamics365CrawlJobData.Api, input.RoutingRuleItemId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.RoutingRuleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.routingrule, EntityEdgeType.Parent, input, input.RoutingRuleId);

                         if (input.AssignObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.AssignObjectId);

                         if (input.RoutedQueueId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.RoutedQueueId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.AssignObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.AssignObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.RoutingRuleItemId] = input.RoutingRuleItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.RoutingRuleId] = input.RoutingRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.RoutingRuleIdName] = input.RoutingRuleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.RoutedQueueId] = input.RoutedQueueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.RoutedQueueIdName] = input.RoutedQueueIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ConditionXml] = input.ConditionXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.AssignObjectId] = input.AssignObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.AssignObjectIdType] = input.AssignObjectIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.AssignObjectIdModifiedOn] = input.AssignObjectIdModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.AssignObjectIdName] = input.AssignObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.AssignObjectIdYomiName] = input.AssignObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RoutingRuleItem.RoutingRuleItemIdUnique] = input.RoutingRuleItemIdUnique.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

