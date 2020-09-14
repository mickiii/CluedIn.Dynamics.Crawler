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
    public abstract class AzureServiceConnectionClueProducer<T> : DynamicsClueProducer<T> where T : AzureServiceConnection
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AzureServiceConnectionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.AzureServiceConnectionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=azureserviceconnection&id={1}", _dynamics365CrawlJobData.Api, input.AzureServiceConnectionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.AccountKey] = input.AccountKey.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.AzureServiceConnectionId] = input.AzureServiceConnectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ConnectionType] = input.ConnectionType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ConnectionTypeName] = input.ConnectionTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.LastConnectionStatusCode] = input.LastConnectionStatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.LastConnectionStatusCodeName] = input.LastConnectionStatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.LastConnectionTime] = input.LastConnectionTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.ServiceUri] = input.ServiceUri.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.AzureServiceConnection.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

