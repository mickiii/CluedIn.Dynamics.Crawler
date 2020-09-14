using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Goal : DynamicsModel
    {
        [JsonProperty("goalid")]
        public Guid? GoalId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fiscalperiod")]
        public string FiscalPeriod { get; set; }

        [JsonProperty("fiscalperiodname")]
        public string fiscalperiodName { get; set; }

        [JsonProperty("fiscalyear")]
        public string FiscalYear { get; set; }

        [JsonProperty("fiscalyearname")]
        public string fiscalyearName { get; set; }

        [JsonProperty("goalstartdate")]
        public DateTimeOffset? GoalStartDate { get; set; }

        [JsonProperty("goalenddate")]
        public DateTimeOffset? GoalEndDate { get; set; }

        [JsonProperty("goalownerid")]
        public string GoalOwnerId { get; set; }

        [JsonProperty("goalowneridname")]
        public string GoalOwnerIdName { get; set; }

        [JsonProperty("goalowneridyominame")]
        public string GoalOwnerIdYomiName { get; set; }

        [JsonProperty("parentgoalid")]
        public string ParentGoalId { get; set; }

        [JsonProperty("parentgoalidname")]
        public string ParentGoalIdName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("metricid")]
        public string MetricId { get; set; }

        [JsonProperty("metricidname")]
        public string MetricIdName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("treeid")]
        public Guid? TreeId { get; set; }

        [JsonProperty("depth")]
        public long? Depth { get; set; }

        [JsonProperty("stretchtargetmoney")]
        public string StretchTargetMoney { get; set; }

        [JsonProperty("stretchtargetmoney_base")]
        public string StretchTargetMoney_Base { get; set; }

        [JsonProperty("stretchtargetdecimal")]
        public decimal? StretchTargetDecimal { get; set; }

        [JsonProperty("stretchtargetinteger")]
        public long? StretchTargetInteger { get; set; }

        [JsonProperty("targetmoney")]
        public string TargetMoney { get; set; }

        [JsonProperty("targetmoney_base")]
        public string TargetMoney_Base { get; set; }

        [JsonProperty("targetdecimal")]
        public decimal? TargetDecimal { get; set; }

        [JsonProperty("targetinteger")]
        public long? TargetInteger { get; set; }

        [JsonProperty("actualmoney")]
        public string ActualMoney { get; set; }

        [JsonProperty("actualmoney_base")]
        public string ActualMoney_Base { get; set; }

        [JsonProperty("customrollupfieldmoney")]
        public string CustomRollupFieldMoney { get; set; }

        [JsonProperty("customrollupfieldmoney_base")]
        public string CustomRollupFieldMoney_Base { get; set; }

        [JsonProperty("inprogressmoney")]
        public string InProgressMoney { get; set; }

        [JsonProperty("inprogressmoney_base")]
        public string InProgressMoney_Base { get; set; }

        [JsonProperty("actualdecimal")]
        public decimal? ActualDecimal { get; set; }

        [JsonProperty("customrollupfielddecimal")]
        public decimal? CustomRollupFieldDecimal { get; set; }

        [JsonProperty("inprogressdecimal")]
        public decimal? InProgressDecimal { get; set; }

        [JsonProperty("actualinteger")]
        public long? ActualInteger { get; set; }

        [JsonProperty("customrollupfieldinteger")]
        public long? CustomRollupFieldInteger { get; set; }

        [JsonProperty("inprogressinteger")]
        public long? InProgressInteger { get; set; }

        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        [JsonProperty("isfiscalperiodgoal")]
        public bool? IsFiscalPeriodGoal { get; set; }

        [JsonProperty("isfiscalperiodgoalname")]
        public string IsFiscalPeriodGoalName { get; set; }

        [JsonProperty("consideronlygoalownersrecords")]
        public bool? ConsiderOnlyGoalOwnersRecords { get; set; }

        [JsonProperty("consideronlygoalownersrecordsname")]
        public string ConsiderOnlyGoalOwnersRecordsName { get; set; }

        [JsonProperty("lastrolledupdate")]
        public DateTimeOffset? LastRolledupDate { get; set; }

        [JsonProperty("targetstring")]
        public string TargetString { get; set; }

        [JsonProperty("stretchtargetstring")]
        public string StretchTargetString { get; set; }

        [JsonProperty("actualstring")]
        public string ActualString { get; set; }

        [JsonProperty("customrollupfieldstring")]
        public string CustomRollupFieldString { get; set; }

        [JsonProperty("inprogressstring")]
        public string InProgressString { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("amountdatatype")]
        public string AmountDataType { get; set; }

        [JsonProperty("isamount")]
        public bool? IsAmount { get; set; }

        [JsonProperty("amountdatatypename")]
        public string AmountDataTypeName { get; set; }

        [JsonProperty("isamountname")]
        public string IsAmountName { get; set; }

        [JsonProperty("rollupqueryactualintegerid")]
        public string RollupQueryActualIntegerId { get; set; }

        [JsonProperty("rollupqueryactualintegeridname")]
        public string RollupQueryActualIntegerIdName { get; set; }

        [JsonProperty("rollupqueryactualmoneyid")]
        public string RollUpQueryActualMoneyId { get; set; }

        [JsonProperty("rollupqueryactualmoneyidname")]
        public string RollUpQueryActualMoneyIdName { get; set; }

        [JsonProperty("rollupqueryactualdecimalid")]
        public string RollUpQueryActualDecimalId { get; set; }

        [JsonProperty("rollupqueryactualdecimalidname")]
        public string RollUpQueryActualDecimalIdName { get; set; }

        [JsonProperty("rollupquerycustomintegerid")]
        public string RollUpQueryCustomIntegerId { get; set; }

        [JsonProperty("rollupquerycustomintegeridname")]
        public string RollUpQueryCustomIntegerIdName { get; set; }

        [JsonProperty("rollupquerycustommoneyid")]
        public string RollUpQueryCustomMoneyId { get; set; }

        [JsonProperty("rollupquerycustommoneyidname")]
        public string RollUpQueryCustomMoneyIdName { get; set; }

        [JsonProperty("rollupquerycustomdecimalid")]
        public string RollUpQueryCustomDecimalId { get; set; }

        [JsonProperty("rollupquerycustomdecimalidname")]
        public string RollUpQueryCustomDecimalIdName { get; set; }

        [JsonProperty("rollupqueryinprogressintegerid")]
        public string RollUpQueryInprogressIntegerId { get; set; }

        [JsonProperty("rollupqueryinprogressintegeridname")]
        public string RollUpQueryInprogressIntegerIdName { get; set; }

        [JsonProperty("rollupqueryinprogressmoneyid")]
        public string RollUpQueryInprogressMoneyId { get; set; }

        [JsonProperty("rollupqueryinprogressmoneyidname")]
        public string RollUpQueryInprogressMoneyIdName { get; set; }

        [JsonProperty("rollupqueryinprogressdecimalid")]
        public string RollUpQueryInprogressDecimalId { get; set; }

        [JsonProperty("rollupqueryinprogressdecimalidname")]
        public string RollUpQueryInprogressDecimalIdName { get; set; }

        [JsonProperty("rolluponlyfromchildgoals")]
        public bool? RollupOnlyFromChildGoals { get; set; }

        [JsonProperty("rolluponlyfromchildgoalsname")]
        public string RollupOnlyFromChildGoalsName { get; set; }

        [JsonProperty("goalwitherrorid")]
        public string GoalWithErrorId { get; set; }

        [JsonProperty("goalwitherroridname")]
        public string GoalWithErrorIdName { get; set; }

        [JsonProperty("rolluperrorcode")]
        public long? RollupErrorCode { get; set; }

        [JsonProperty("goalowneridtype")]
        public string GoalOwnerIdType { get; set; }

        [JsonProperty("computedtargetasoftodaypercentageachieved")]
        public decimal? ComputedTargetAsOfTodayPercentageAchieved { get; set; }

        [JsonProperty("computedtargetasoftodaymoney")]
        public string ComputedTargetAsOfTodayMoney { get; set; }

        [JsonProperty("computedtargetasoftodaymoney_base")]
        public string ComputedTargetAsOfTodayMoney_Base { get; set; }

        [JsonProperty("computedtargetasoftodaydecimal")]
        public decimal? ComputedTargetAsOfTodayDecimal { get; set; }

        [JsonProperty("computedtargetasoftodayinteger")]
        public long? ComputedTargetAsOfTodayInteger { get; set; }

        [JsonProperty("isoverride")]
        public bool? IsOverride { get; set; }

        [JsonProperty("isoverridden")]
        public bool? IsOverridden { get; set; }

        [JsonProperty("isoverridename")]
        public string IsOverrideName { get; set; }

        [JsonProperty("isoverriddenname")]
        public string IsOverriddenName { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }


    }
}

