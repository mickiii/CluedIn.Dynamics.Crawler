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
    public abstract class ProcessStageClueProducer<T> : DynamicsClueProducer<T> where T : ProcessStage
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ProcessStageClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.ProcessStage, input.ProcessStageId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=processstage&id={1}", this._dynamics365CrawlJobData.Api, input.ProcessStageId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.StageName;

            //if (input.ProcessId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ProcessId);

            data.Properties[Dynamics365Vocabulary.ProcessStage.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.PrimaryEntityTypeCode] = input.PrimaryEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.PrimaryEntityTypeCodeName] = input.PrimaryEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.ProcessIdName] = input.ProcessIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.ProcessStageId] = input.ProcessStageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.StageCategory] = input.StageCategory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.StageCategoryName] = input.StageCategoryName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.StageName] = input.StageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProcessStage.ClientData] = input.ClientData.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

