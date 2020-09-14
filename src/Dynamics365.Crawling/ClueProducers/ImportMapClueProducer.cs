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
    public abstract class ImportMapClueProducer<T> : DynamicsClueProducer<T> where T : ImportMap
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ImportMapClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ImportMapId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=importmap&id={1}", _dynamics365CrawlJobData.Api, input.ImportMapId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.ImportMap.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.TargetEntity] = input.TargetEntity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ImportMapType] = input.ImportMapType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.TargetUserIdentifierForSourceCRMUserLink] = input.TargetUserIdentifierForSourceCRMUserLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IsWizardCreated] = input.IsWizardCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ImportMapId] = input.ImportMapId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.SourceUserIdentifierForSourceDataSourceUserLink] = input.SourceUserIdentifierForSourceDataSourceUserLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.SourceUserIdentifierForSourceCRMUserLink] = input.SourceUserIdentifierForSourceCRMUserLink.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.Source] = input.Source.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IsValidForImport] = input.IsValidForImport.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ImportMapTypeName] = input.ImportMapTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IsValidForImportName] = input.IsValidForImportName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IsWizardCreatedName] = input.IsWizardCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.TargetEntityName] = input.TargetEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.MapCustomizations] = input.MapCustomizations.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.EntitiesPerFile] = input.EntitiesPerFile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.EntitiesPerFileName] = input.EntitiesPerFileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.SourceType] = input.SourceType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.SourceTypeName] = input.SourceTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ImportMap.ImportMapIdUnique] = input.ImportMapIdUnique.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

