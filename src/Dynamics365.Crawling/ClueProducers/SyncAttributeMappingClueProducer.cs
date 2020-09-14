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
    public abstract class SyncAttributeMappingClueProducer<T> : DynamicsClueProducer<T> where T : SyncAttributeMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SyncAttributeMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SyncAttributeMappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=syncattributemapping&id={1}", _dynamics365CrawlJobData.Api, input.SyncAttributeMappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.SyncAttributeMappingProfileId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.syncattributemappingprofile, EntityEdgeType.Parent, input, input.SyncAttributeMappingProfileId);


            */
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SyncAttributeMappingId] = input.SyncAttributeMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SyncAttributeMappingIdUnique] = input.SyncAttributeMappingIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.MappingName] = input.MappingName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.EntityTypeCode] = input.EntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SyncAttributeMappingProfileId] = input.SyncAttributeMappingProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.AttributeCRMName] = input.AttributeCRMName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.AttributeExchangeName] = input.AttributeExchangeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SyncDirection] = input.SyncDirection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.SyncDirectionName] = input.SyncDirectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.IsComputed] = input.IsComputed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.ComputedProperties] = input.ComputedProperties.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.ParentSyncAttributeMappingId] = input.ParentSyncAttributeMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.DefaultSyncDirection] = input.DefaultSyncDirection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.DefaultSyncDirectionName] = input.DefaultSyncDirectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SyncAttributeMapping.AllowedSyncDirection] = input.AllowedSyncDirection.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

