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
    public abstract class CategoryClueProducer<T> : DynamicsClueProducer<T> where T : Category
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CategoryClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CategoryId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=category&id={1}", _dynamics365CrawlJobData.Api, input.CategoryId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.ParentCategoryId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.category, EntityEdgeType.Parent, input, input.ParentCategoryId);


            */
            data.Properties[Dynamics365Vocabulary.Category.CategoryId] = input.CategoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ParentCategoryId] = input.ParentCategoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ParentCategoryIdName] = input.ParentCategoryIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.CategoryNumber] = input.CategoryNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Category.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

