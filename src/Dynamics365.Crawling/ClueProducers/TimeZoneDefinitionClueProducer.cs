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
    public abstract class TimeZoneDefinitionClueProducer<T> : DynamicsClueProducer<T> where T : TimeZoneDefinition
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TimeZoneDefinitionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TimeZoneDefinitionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=timezonedefinition&id={1}", _dynamics365CrawlJobData.Api, input.TimeZoneDefinitionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.UserInterfaceName;
            /*
             if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.TimeZoneCode] = input.TimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.TimeZoneDefinitionId] = input.TimeZoneDefinitionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.Bias] = input.Bias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.DaylightName] = input.DaylightName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.UserInterfaceName] = input.UserInterfaceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.StandardName] = input.StandardName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.RetiredOrder] = input.RetiredOrder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneDefinition.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

