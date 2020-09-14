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
    public abstract class DynamicPropertyInstanceClueProducer<T> : DynamicsClueProducer<T> where T : DynamicPropertyInstance
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DynamicPropertyInstanceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DynamicPropertyInstanceid.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=dynamicpropertyinstance&id={1}", _dynamics365CrawlJobData.Api, input.DynamicPropertyInstanceid.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorderdetail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.DynamicPropertyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicproperty, EntityEdgeType.Parent, input, input.DynamicPropertyId);

                         if (input.DynamicPropertyInstanceid != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.DynamicPropertyInstanceid);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quotedetail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.DynamicPropertyInstanceid != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.DynamicPropertyInstanceid);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoicedetail, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityproduct, EntityEdgeType.Parent, input, input.RegardingObjectId);


            */
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.DynamicPropertyInstanceid] = input.DynamicPropertyInstanceid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.DynamicPropertyId] = input.DynamicPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.DynamicPropertyIdName] = input.DynamicPropertyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ValueInteger] = input.ValueInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ValueDecimal] = input.ValueDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ValueDouble] = input.ValueDouble.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ValueString] = input.ValueString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.RegardingObjectIdType] = input.RegardingObjectIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.DMTImportState] = input.DMTImportState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.validationstatus] = input.validationstatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.validationstatusname] = input.validationstatusname.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicPropertyInstance.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

