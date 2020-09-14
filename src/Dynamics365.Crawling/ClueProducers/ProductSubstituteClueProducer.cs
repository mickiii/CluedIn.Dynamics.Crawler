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
    public abstract class ProductSubstituteClueProducer<T> : DynamicsClueProducer<T> where T : ProductSubstitute
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ProductSubstituteClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ProductSubstituteId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=productsubstitute&id={1}", _dynamics365CrawlJobData.Api, input.ProductSubstituteId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
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

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.SubstitutedProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.SubstitutedProductId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.SubstitutedProductId] = input.SubstitutedProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ProductSubstituteId] = input.ProductSubstituteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.SubstitutedProductIdName] = input.SubstitutedProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.SalesRelationshipTypeName] = input.SalesRelationshipTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.SalesRelationshipType] = input.SalesRelationshipType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.Direction] = input.Direction.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.DirectionName] = input.DirectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductSubstitute.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

