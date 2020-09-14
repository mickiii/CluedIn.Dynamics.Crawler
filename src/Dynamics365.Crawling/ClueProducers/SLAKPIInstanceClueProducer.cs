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
    public abstract class SLAKPIInstanceClueProducer<T> : DynamicsClueProducer<T> where T : SLAKPIInstance
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SLAKPIInstanceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SLAKPIInstanceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=slakpiinstance&id={1}", _dynamics365CrawlJobData.Api, input.SLAKPIInstanceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.Regarding);

                         if (input.Regarding != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.Regarding);


            */
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.SLAKPIInstanceId] = input.SLAKPIInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ComputedFailureTime] = input.ComputedFailureTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ComputedWarningTime] = input.ComputedWarningTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.FailureTime] = input.FailureTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.Regarding] = input.Regarding.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.RegardingName] = input.RegardingName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.Status] = input.Status.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.StatusName] = input.StatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.SucceededOn] = input.SucceededOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.WarningTime] = input.WarningTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.WarningTimeReached] = input.WarningTimeReached.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.HasNearedViolationName] = input.HasNearedViolationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.RegardingYomiName] = input.RegardingYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SLAKPIInstance.RegardingIdName] = input.RegardingIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

