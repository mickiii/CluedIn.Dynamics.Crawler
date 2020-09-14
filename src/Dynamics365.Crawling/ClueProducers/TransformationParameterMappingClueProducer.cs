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
    public abstract class TransformationParameterMappingClueProducer<T> : DynamicsClueProducer<T> where T : TransformationParameterMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TransformationParameterMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TransformationParameterMappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=transformationparametermapping&id={1}", _dynamics365CrawlJobData.Api, input.TransformationParameterMappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Data;
            /*
             if (input.TransformationMappingId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transformationmapping, EntityEdgeType.Parent, input, input.TransformationMappingId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ParameterArrayIndex] = input.ParameterArrayIndex.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ParameterTypeCode] = input.ParameterTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.TransformationParameterMappingId] = input.TransformationParameterMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.TransformationMappingId] = input.TransformationMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.DataTypeCode] = input.DataTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.Data] = input.Data.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ParameterSequence] = input.ParameterSequence.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.DataTypeCodeName] = input.DataTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ParameterTypeCodeName] = input.ParameterTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.TransformationMappingIdName] = input.TransformationMappingIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TransformationParameterMapping.TransformationParameterMappingIdUnique] = input.TransformationParameterMappingIdUnique.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

