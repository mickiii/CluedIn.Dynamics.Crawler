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
    public abstract class TimeZoneRuleClueProducer<T> : DynamicsClueProducer<T> where T : TimeZoneRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TimeZoneRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.TimeZoneRuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=timezonerule&id={1}", _dynamics365CrawlJobData.Api, input.TimeZoneRuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.TimeZoneRuleVersionNumber;
            /*
             if (input.TimeZoneDefinitionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.timezonedefinition, EntityEdgeType.Parent, input, input.TimeZoneDefinitionId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardDay] = input.StandardDay.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardMinute] = input.StandardMinute.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardBias] = input.StandardBias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardYear] = input.StandardYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightMonth] = input.DaylightMonth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardDayOfWeek] = input.StandardDayOfWeek.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightSecond] = input.DaylightSecond.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.Bias] = input.Bias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightBias] = input.DaylightBias.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardMonth] = input.StandardMonth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.EffectiveDateTime] = input.EffectiveDateTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightHour] = input.DaylightHour.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardHour] = input.StandardHour.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightYear] = input.DaylightYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.StandardSecond] = input.StandardSecond.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightMinute] = input.DaylightMinute.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.TimeZoneDefinitionId] = input.TimeZoneDefinitionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightDayOfWeek] = input.DaylightDayOfWeek.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.TimeZoneRuleId] = input.TimeZoneRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.DaylightDay] = input.DaylightDay.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.TimeZoneRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

