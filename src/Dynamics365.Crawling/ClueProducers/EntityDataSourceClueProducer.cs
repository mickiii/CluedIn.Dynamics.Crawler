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
    public abstract class EntityDataSourceClueProducer<T> : DynamicsClueProducer<T> where T : EntityDataSource
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EntityDataSourceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.EntityDataSourceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=entitydatasource&id={1}", _dynamics365CrawlJobData.Api, input.EntityDataSourceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.EntityDataProviderId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitydataprovider, EntityEdgeType.Parent, input, input.EntityDataProviderId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.EntityDataSource.EntityDataSourceId] = input.EntityDataSourceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.EntityName] = input.EntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.ConnectionDefinition] = input.ConnectionDefinition.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.EntityDataSourceIdUnique] = input.EntityDataSourceIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.ConnectionDefinitionSecrets] = input.ConnectionDefinitionSecrets.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.EntityDataProviderId] = input.EntityDataProviderId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.EntityDataProviderIdName] = input.EntityDataProviderIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataSource.Description] = input.Description.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

