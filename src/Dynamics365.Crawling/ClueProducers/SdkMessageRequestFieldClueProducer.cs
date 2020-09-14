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
    public abstract class SdkMessageRequestFieldClueProducer<T> : DynamicsClueProducer<T> where T : SdkMessageRequestField
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SdkMessageRequestFieldClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SdkMessageRequestFieldId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sdkmessagerequestfield&id={1}", _dynamics365CrawlJobData.Api, input.SdkMessageRequestFieldId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.SdkMessageRequestId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessagerequest, EntityEdgeType.Parent, input, input.SdkMessageRequestId);


            */
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.SdkMessageRequestFieldIdUnique] = input.SdkMessageRequestFieldIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.Optional] = input.Optional.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.Position] = input.Position.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ClrParser] = input.ClrParser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.PublicName] = input.PublicName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.SdkMessageRequestId] = input.SdkMessageRequestId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.Parser] = input.Parser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.SdkMessageRequestFieldId] = input.SdkMessageRequestFieldId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.FieldMask] = input.FieldMask.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ParameterBindingInformation] = input.ParameterBindingInformation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageRequestField.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

