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
    public abstract class EntityAnalyticsConfigClueProducer<T> : DynamicsClueProducer<T> where T : EntityAnalyticsConfig
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EntityAnalyticsConfigClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.EntityAnalyticsConfigId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=entityanalyticsconfig&id={1}", _dynamics365CrawlJobData.Api, input.EntityAnalyticsConfigId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.ParentEntityLogicalName;
            /*
             if (input.ParentEntityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entity, EntityEdgeType.Parent, input, input.ParentEntityId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.EntityAnalyticsConfigId] = input.EntityAnalyticsConfigId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.ComponentIdUnique] = input.ComponentIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.componentstateName] = input.componentstateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.ParentEntityLogicalName] = input.ParentEntityLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.ParentEntityId] = input.ParentEntityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.IsEnabledForADLS] = input.IsEnabledForADLS.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.isenabledforadlsName] = input.isenabledforadlsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.ismanagedName] = input.ismanagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.ParentEntityIdName] = input.ParentEntityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntityAnalyticsConfig.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

