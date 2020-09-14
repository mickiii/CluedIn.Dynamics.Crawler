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
    public abstract class SdkMessageResponseFieldClueProducer<T> : DynamicsClueProducer<T> where T : SdkMessageResponseField
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SdkMessageResponseFieldClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SdkMessageResponseFieldId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=sdkmessageresponsefield&id={1}", _dynamics365CrawlJobData.Api, input.SdkMessageResponseFieldId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.SdkMessageResponseId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sdkmessageresponse, EntityEdgeType.Parent, input, input.SdkMessageResponseId);


            */
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.PublicName] = input.PublicName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.SdkMessageResponseFieldIdUnique] = input.SdkMessageResponseFieldIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.Value] = input.Value.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.Formatter] = input.Formatter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ClrFormatter] = input.ClrFormatter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.Position] = input.Position.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.SdkMessageResponseFieldId] = input.SdkMessageResponseFieldId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.SdkMessageResponseId] = input.SdkMessageResponseId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ParameterBindingInformation] = input.ParameterBindingInformation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SdkMessageResponseField.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

