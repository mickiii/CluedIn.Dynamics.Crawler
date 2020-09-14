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
    public abstract class EntityDataProviderClueProducer<T> : DynamicsClueProducer<T> where T : EntityDataProvider
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EntityDataProviderClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.EntityDataProviderId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=entitydataprovider&id={1}", _dynamics365CrawlJobData.Api, input.EntityDataProviderId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.EntityDataProviderId] = input.EntityDataProviderId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.RetrievePlugin] = input.RetrievePlugin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.RetrieveMultiplePlugin] = input.RetrieveMultiplePlugin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.CreatePlugin] = input.CreatePlugin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.DeletePlugin] = input.DeletePlugin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.UpdatePlugin] = input.UpdatePlugin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.DataSourceLogicalName] = input.DataSourceLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.EntityDataProviderIdUnique] = input.EntityDataProviderIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityDataProvider.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

