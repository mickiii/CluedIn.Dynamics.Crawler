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
    public abstract class TimeZoneLocalizedNameClueProducer<T> : DynamicsClueProducer<T> where T : TimeZoneLocalizedName
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TimeZoneLocalizedNameClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TimeZoneLocalizedNameId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=timezonelocalizedname&id={1}", _dynamics365CrawlJobData.Api, input.TimeZoneLocalizedNameId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.UserInterfaceName;
            /*
             if (input.TimeZoneDefinitionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.timezonedefinition, EntityEdgeType.Parent, input, input.TimeZoneDefinitionId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.CultureId] = input.CultureId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.TimeZoneDefinitionId] = input.TimeZoneDefinitionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.StandardName] = input.StandardName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.TimeZoneLocalizedNameId] = input.TimeZoneLocalizedNameId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.UserInterfaceName] = input.UserInterfaceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.DaylightName] = input.DaylightName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneLocalizedName.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

