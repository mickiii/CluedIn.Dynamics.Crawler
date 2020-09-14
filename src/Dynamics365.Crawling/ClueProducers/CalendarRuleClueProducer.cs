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
    public abstract class CalendarRuleClueProducer<T> : DynamicsClueProducer<T> where T : CalendarRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CalendarRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CalendarRuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=calendarrule&id={1}", _dynamics365CrawlJobData.Api, input.CalendarRuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.InnerCalendarId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.calendar, EntityEdgeType.Parent, input, input.InnerCalendarId);

                         if (input.CalendarId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.calendar, EntityEdgeType.Parent, input, input.CalendarId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ServiceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ServiceId);


            */
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsVaried] = input.IsVaried.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Rank] = input.Rank.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CalendarRuleId] = input.CalendarRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Effort] = input.Effort.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.EndTime] = input.EndTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.TimeCode] = input.TimeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Offset] = input.Offset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsSimple] = input.IsSimple.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.TimeZoneCode] = input.TimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsSelected] = input.IsSelected.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ExtentCode] = input.ExtentCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.EffectiveIntervalEnd] = input.EffectiveIntervalEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CalendarId] = input.CalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.InnerCalendarId] = input.InnerCalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Pattern] = input.Pattern.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.GroupDesignator] = input.GroupDesignator.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsModified] = input.IsModified.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.SubCode] = input.SubCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.EffectiveIntervalStart] = input.EffectiveIntervalStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsSimpleName] = input.IsSimpleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsSelectedName] = input.IsSelectedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsModifiedName] = input.IsModifiedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.IsVariedName] = input.IsVariedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ServiceIdName] = input.ServiceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CalendarRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

