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
    public abstract class OwnerMappingClueProducer<T> : DynamicsClueProducer<T> where T : OwnerMapping
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OwnerMappingClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.OwnerMappingId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=ownermapping&id={1}", _dynamics365CrawlJobData.Api, input.OwnerMappingId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.TargetSystemUserId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.TargetSystemUserId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ImportMapId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.importmap, EntityEdgeType.Parent, input, input.ImportMapId);


            */
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.TargetUserValueForSourceCRMUserLink] = input.TargetUserValueForSourceCRMUserLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ImportMapId] = input.ImportMapId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.OwnerMappingId] = input.OwnerMappingId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ProcessCode] = input.ProcessCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.SourceSystemUserName] = input.SourceSystemUserName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.TargetSystemUserId] = input.TargetSystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.SourceUserValueForSourceCRMUserLink] = input.SourceUserValueForSourceCRMUserLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.TargetSystemUserDomainName] = input.TargetSystemUserDomainName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ProcessCodeName] = input.ProcessCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ImportMapIdName] = input.ImportMapIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OwnerMapping.OwnerMappingIdUnique] = input.OwnerMappingIdUnique.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

