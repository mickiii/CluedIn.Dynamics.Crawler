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
    public abstract class DynamicPropertyOptionSetItemClueProducer<T> : DynamicsClueProducer<T> where T : DynamicPropertyOptionSetItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DynamicPropertyOptionSetItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DynamicPropertyOptionSetValueId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=dynamicpropertyoptionsetitem&id={1}", _dynamics365CrawlJobData.Api, input.DynamicPropertyOptionSetValueId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.DynamicPropertyOptionName;
            /*
             if (input.DynamicPropertyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicproperty, EntityEdgeType.Parent, input, input.DynamicPropertyId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyOptionName] = input.DynamicPropertyOptionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyOptionValue] = input.DynamicPropertyOptionValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyOptionDescription] = input.DynamicPropertyOptionDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyId] = input.DynamicPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyIdName] = input.DynamicPropertyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyOptionSetValueId] = input.DynamicPropertyOptionSetValueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DynamicPropertyOptionSetValueSequenceNumber] = input.DynamicPropertyOptionSetValueSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.DMTImportState] = input.DMTImportState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyOptionSetItem.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

