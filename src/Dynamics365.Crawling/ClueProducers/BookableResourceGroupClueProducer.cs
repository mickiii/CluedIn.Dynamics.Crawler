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
    public abstract class BookableResourceGroupClueProducer<T> : DynamicsClueProducer<T> where T : BookableResourceGroup
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public BookableResourceGroupClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.BookableResourceGroupId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=bookableresourcegroup&id={1}", _dynamics365CrawlJobData.Api, input.BookableResourceGroupId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.ChildResource != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresource, EntityEdgeType.Parent, input, input.ChildResource);

                         if (input.ParentResource != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresource, EntityEdgeType.Parent, input, input.ParentResource);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.BookableResourceGroupId] = input.BookableResourceGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.FromDate] = input.FromDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ToDate] = input.ToDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ChildResource] = input.ChildResource.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ChildResourceName] = input.ChildResourceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ParentResource] = input.ParentResource.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ParentResourceName] = input.ParentResourceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.BookableResourceGroup.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

