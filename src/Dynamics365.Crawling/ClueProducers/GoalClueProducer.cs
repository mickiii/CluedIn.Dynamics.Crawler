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
    public abstract class GoalClueProducer<T> : DynamicsClueProducer<T> where T : Goal
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public GoalClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Marketing.Goal, input.GoalId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=goal&id={1}", this._dynamics365CrawlJobData.Api, input.GoalId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;

            if (input.ParentGoalId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Goal, EntityEdgeType.Parent, input, input.ParentGoalId);

            //if (input.GoalWithErrorId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Goal, EntityEdgeType.Parent, input, input.GoalWithErrorId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            if (input.GoalOwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.GoalOwnerId);

            //if (input.RollupQueryActualIntegerId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollupQueryActualIntegerId);

            //if (input.RollUpQueryActualMoneyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryActualMoneyId);

            //if (input.RollUpQueryActualDecimalId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryActualDecimalId);

            //if (input.RollUpQueryCustomIntegerId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryCustomIntegerId);

            //if (input.RollUpQueryCustomMoneyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryCustomMoneyId);

            //if (input.RollUpQueryCustomDecimalId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryCustomDecimalId);

            //if (input.RollUpQueryInprogressIntegerId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryInprogressIntegerId);

            //if (input.RollUpQueryInprogressMoneyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryInprogressMoneyId);

            //if (input.RollUpQueryInprogressDecimalId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.RollUpQueryInprogressDecimalId);

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            //if (input.MetricId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.metric, EntityEdgeType.Parent, input, input.MetricId);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.GoalOwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.GoalOwnerId);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            data.Properties[Dynamics365Vocabulary.Goal.GoalId] = input.GoalId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.FiscalPeriod] = input.FiscalPeriod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.fiscalperiodName] = input.fiscalperiodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.FiscalYear] = input.FiscalYear.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.fiscalyearName] = input.fiscalyearName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalStartDate] = input.GoalStartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalEndDate] = input.GoalEndDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalOwnerId] = input.GoalOwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalOwnerIdName] = input.GoalOwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalOwnerIdYomiName] = input.GoalOwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ParentGoalId] = input.ParentGoalId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ParentGoalIdName] = input.ParentGoalIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.MetricId] = input.MetricId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.MetricIdName] = input.MetricIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TreeId] = input.TreeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.Depth] = input.Depth.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StretchTargetMoney] = input.StretchTargetMoney.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StretchTargetMoney_Base] = input.StretchTargetMoney_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StretchTargetDecimal] = input.StretchTargetDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StretchTargetInteger] = input.StretchTargetInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TargetMoney] = input.TargetMoney.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TargetMoney_Base] = input.TargetMoney_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TargetDecimal] = input.TargetDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TargetInteger] = input.TargetInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ActualMoney] = input.ActualMoney.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ActualMoney_Base] = input.ActualMoney_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CustomRollupFieldMoney] = input.CustomRollupFieldMoney.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CustomRollupFieldMoney_Base] = input.CustomRollupFieldMoney_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.InProgressMoney] = input.InProgressMoney.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.InProgressMoney_Base] = input.InProgressMoney_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ActualDecimal] = input.ActualDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CustomRollupFieldDecimal] = input.CustomRollupFieldDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.InProgressDecimal] = input.InProgressDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ActualInteger] = input.ActualInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CustomRollupFieldInteger] = input.CustomRollupFieldInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.InProgressInteger] = input.InProgressInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.Percentage] = input.Percentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsFiscalPeriodGoal] = input.IsFiscalPeriodGoal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsFiscalPeriodGoalName] = input.IsFiscalPeriodGoalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ConsiderOnlyGoalOwnersRecords] = input.ConsiderOnlyGoalOwnersRecords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ConsiderOnlyGoalOwnersRecordsName] = input.ConsiderOnlyGoalOwnersRecordsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.LastRolledupDate] = input.LastRolledupDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.TargetString] = input.TargetString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.StretchTargetString] = input.StretchTargetString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ActualString] = input.ActualString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.CustomRollupFieldString] = input.CustomRollupFieldString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.InProgressString] = input.InProgressString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.AmountDataType] = input.AmountDataType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsAmount] = input.IsAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.AmountDataTypeName] = input.AmountDataTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsAmountName] = input.IsAmountName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollupQueryActualIntegerId] = input.RollupQueryActualIntegerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollupQueryActualIntegerIdName] = input.RollupQueryActualIntegerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryActualMoneyId] = input.RollUpQueryActualMoneyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryActualMoneyIdName] = input.RollUpQueryActualMoneyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryActualDecimalId] = input.RollUpQueryActualDecimalId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryActualDecimalIdName] = input.RollUpQueryActualDecimalIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryCustomIntegerId] = input.RollUpQueryCustomIntegerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryCustomIntegerIdName] = input.RollUpQueryCustomIntegerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryCustomMoneyId] = input.RollUpQueryCustomMoneyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryCustomMoneyIdName] = input.RollUpQueryCustomMoneyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryCustomDecimalId] = input.RollUpQueryCustomDecimalId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryCustomDecimalIdName] = input.RollUpQueryCustomDecimalIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryInprogressIntegerId] = input.RollUpQueryInprogressIntegerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryInprogressIntegerIdName] = input.RollUpQueryInprogressIntegerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryInprogressMoneyId] = input.RollUpQueryInprogressMoneyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryInprogressMoneyIdName] = input.RollUpQueryInprogressMoneyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryInprogressDecimalId] = input.RollUpQueryInprogressDecimalId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollUpQueryInprogressDecimalIdName] = input.RollUpQueryInprogressDecimalIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollupOnlyFromChildGoals] = input.RollupOnlyFromChildGoals.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollupOnlyFromChildGoalsName] = input.RollupOnlyFromChildGoalsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalWithErrorId] = input.GoalWithErrorId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalWithErrorIdName] = input.GoalWithErrorIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.RollupErrorCode] = input.RollupErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.GoalOwnerIdType] = input.GoalOwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ComputedTargetAsOfTodayPercentageAchieved] = input.ComputedTargetAsOfTodayPercentageAchieved.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ComputedTargetAsOfTodayMoney] = input.ComputedTargetAsOfTodayMoney.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ComputedTargetAsOfTodayMoney_Base] = input.ComputedTargetAsOfTodayMoney_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ComputedTargetAsOfTodayDecimal] = input.ComputedTargetAsOfTodayDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.ComputedTargetAsOfTodayInteger] = input.ComputedTargetAsOfTodayInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsOverride] = input.IsOverride.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsOverridden] = input.IsOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsOverrideName] = input.IsOverrideName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.IsOverriddenName] = input.IsOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Goal.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

