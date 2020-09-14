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
    public abstract class ColumnMappingClueProducer<T> : DynamicsClueProducer<T> where T : ColumnMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ColumnMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ColumnMappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=columnmapping&id={1}", _dynamics365CrawlJobData.Api, input.ColumnMappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.SourceAttributeName;
            /*
             if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ImportMapId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.importmap, EntityEdgeType.Parent, input, input.ImportMapId);


            */
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ColumnMappingId] = input.ColumnMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.TargetEntityName] = input.TargetEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ProcessCode] = input.ProcessCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.TargetAttributeName] = input.TargetAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ImportMapId] = input.ImportMapId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.SourceAttributeName] = input.SourceAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.SourceEntityName] = input.SourceEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ImportMapIdName] = input.ImportMapIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ProcessCodeName] = input.ProcessCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ColumnMapping.ColumnMappingIdUnique] = input.ColumnMappingIdUnique.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

