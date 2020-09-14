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
    public abstract class RecurrenceRuleClueProducer<T> : DynamicsClueProducer<T> where T : RecurrenceRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public RecurrenceRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.RuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=recurrencerule&id={1}", _dynamics365CrawlJobData.Api, input.RuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.DayOfMonth] = input.DayOfMonth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.RuleId] = input.RuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsNthMonthly] = input.IsNthMonthly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.MonthOfYearName] = input.MonthOfYearName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.EffectiveStartDate] = input.EffectiveStartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.RecurrencePatternType] = input.RecurrencePatternType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.MonthOfYear] = input.MonthOfYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.EffectiveEndDate] = input.EffectiveEndDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.StartTime] = input.StartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.Interval] = input.Interval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.EndTime] = input.EndTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.PatternEndType] = input.PatternEndType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsNthYearly] = input.IsNthYearly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.PatternStartDate] = input.PatternStartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.Instance] = input.Instance.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsWeekDayPattern] = input.IsWeekDayPattern.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.PatternEndDate] = input.PatternEndDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.FirstDayOfWeek] = input.FirstDayOfWeek.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsRegenerate] = input.IsRegenerate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.DaysOfWeekMask] = input.DaysOfWeekMask.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.Occurrences] = input.Occurrences.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.InstanceName] = input.InstanceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsWeekDayPatternName] = input.IsWeekDayPatternName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.RecurrencePatternTypeName] = input.RecurrencePatternTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.PatternEndTypeName] = input.PatternEndTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsNthMonthlyName] = input.IsNthMonthlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsNthYearlyName] = input.IsNthYearlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.IsRegenerateName] = input.IsRegenerateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.RecurrenceRule.OwningTeam] = input.OwningTeam.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

