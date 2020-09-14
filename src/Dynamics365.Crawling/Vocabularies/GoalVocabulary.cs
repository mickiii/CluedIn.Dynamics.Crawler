using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class GoalVocabulary : SimpleVocabulary
    {
        public GoalVocabulary()
        {
            VocabularyName = "Dynamics365 Goal";
            KeyPrefix = "dynamics365.goal";
            KeySeparator = ".";
            Grouping = EntityType.Marketing.Goal;

            this.AddGroup("Goal", group =>
            {
                this.GoalId = group.Add(new VocabularyKey("GoalId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the goal.")
                    .WithDisplayName("Goal")
                    .ModelProperty("goalid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record on behalf of another user.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Manager")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Owner Id Type")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the manager")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Yomi name of the owner")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the business unit that owns the record.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the user who owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the goal is open, completed, or canceled. Completed and canceled goals are read-only and can't be edited.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the goal's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the goal.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a title or name that describes the goal.")
                    .WithDisplayName("Name")
                    .ModelProperty("title", typeof(string)));

                this.FiscalPeriod = group.Add(new VocabularyKey("FiscalPeriod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the fiscal period for the goal.")
                    .WithDisplayName("Fiscal Period")
                    .ModelProperty("fiscalperiod", typeof(string)));

                this.fiscalperiodName = group.Add(new VocabularyKey("fiscalperiodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("fiscalperiodName")
                    .ModelProperty("fiscalperiodname", typeof(string)));

                this.FiscalYear = group.Add(new VocabularyKey("FiscalYear", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the fiscal year for the goal that's being tracked.")
                    .WithDisplayName("Fiscal Year")
                    .ModelProperty("fiscalyear", typeof(string)));

                this.fiscalyearName = group.Add(new VocabularyKey("fiscalyearName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("fiscalyearName")
                    .ModelProperty("fiscalyearname", typeof(string)));

                this.GoalStartDate = group.Add(new VocabularyKey("GoalStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time when the period for tracking the goal begins.")
                    .WithDisplayName("From")
                    .ModelProperty("goalstartdate", typeof(DateTime)));

                this.GoalEndDate = group.Add(new VocabularyKey("GoalEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the goal ends.")
                    .WithDisplayName("To")
                    .ModelProperty("goalenddate", typeof(DateTime)));

                this.GoalOwnerId = group.Add(new VocabularyKey("GoalOwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the user or team responsible for meeting the goal.")
                    .WithDisplayName("Goal Owner")
                    .ModelProperty("goalownerid", typeof(string)));

                this.GoalOwnerIdName = group.Add(new VocabularyKey("GoalOwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("GoalOwnerIdName")
                    .ModelProperty("goalowneridname", typeof(string)));

                this.GoalOwnerIdYomiName = group.Add(new VocabularyKey("GoalOwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("GoalOwnerIdYomiName")
                    .ModelProperty("goalowneridyominame", typeof(string)));

                this.ParentGoalId = group.Add(new VocabularyKey("ParentGoalId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose a parent goal if the current goal is a child goal. This sets up a parent-child relationship for reporting and analytics.")
                    .WithDisplayName("Parent Goal")
                    .ModelProperty("parentgoalid", typeof(string)));

                this.ParentGoalIdName = group.Add(new VocabularyKey("ParentGoalIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentGoalIdName")
                    .ModelProperty("parentgoalidname", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.MetricId = group.Add(new VocabularyKey("MetricId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the metric for the goal. This metric determines how the goal is tracked.")
                    .WithDisplayName("Goal Metric")
                    .ModelProperty("metricid", typeof(string)));

                this.MetricIdName = group.Add(new VocabularyKey("MetricIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MetricIdName")
                    .ModelProperty("metricidname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.TreeId = group.Add(new VocabularyKey("TreeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the goal tree.")
                    .WithDisplayName("Tree ID")
                    .ModelProperty("treeid", typeof(Guid)));

                this.Depth = group.Add(new VocabularyKey("Depth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Depth of the goal in the tree.")
                    .WithDisplayName("Depth")
                    .ModelProperty("depth", typeof(long)));

                this.StretchTargetMoney = group.Add(new VocabularyKey("StretchTargetMoney", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select stretch target (money) of the goal to define a higher or difficult level of goal than the usual ones.")
                    .WithDisplayName("Stretch Target (Money)")
                    .ModelProperty("stretchtargetmoney", typeof(string)));

                this.StretchTargetMoney_Base = group.Add(new VocabularyKey("StretchTargetMoney_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the stretch target (money) in base currency to indicate a higher or difficult level of goal than the usual ones.")
                    .WithDisplayName("Stretch Target (Money) (Base)")
                    .ModelProperty("stretchtargetmoney_base", typeof(string)));

                this.StretchTargetDecimal = group.Add(new VocabularyKey("StretchTargetDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a stretch target (decimal) of the goal to define a higher or difficult level of goal than the usual ones.")
                    .WithDisplayName("Stretch Target (Decimal)")
                    .ModelProperty("stretchtargetdecimal", typeof(decimal)));

                this.StretchTargetInteger = group.Add(new VocabularyKey("StretchTargetInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the stretch target (integer) of the goal to define a higher or difficult level of goal than the usual ones.")
                    .WithDisplayName("Stretch Target (Integer)")
                    .ModelProperty("stretchtargetinteger", typeof(long)));

                this.TargetMoney = group.Add(new VocabularyKey("TargetMoney", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a goal target (money) to track a monetary amount such as revenue from a product.")
                    .WithDisplayName("Target (Money)")
                    .ModelProperty("targetmoney", typeof(string)));

                this.TargetMoney_Base = group.Add(new VocabularyKey("TargetMoney_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the goal target of the money type in base currency.")
                    .WithDisplayName("Target (Money) (Base)")
                    .ModelProperty("targetmoney_base", typeof(string)));

                this.TargetDecimal = group.Add(new VocabularyKey("TargetDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a goal target of the decimal type to use for tracking data that include partial numbers, such as pounds sold of a product sold by weight.")
                    .WithDisplayName("Target (Decimal)")
                    .ModelProperty("targetdecimal", typeof(decimal)));

                this.TargetInteger = group.Add(new VocabularyKey("TargetInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a goal target of the integer type to use for tracking anything countable in whole numbers, such as units sold.")
                    .WithDisplayName("Target (Integer)")
                    .ModelProperty("targetinteger", typeof(long)));

                this.ActualMoney = group.Add(new VocabularyKey("ActualMoney", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the actual value (Money type) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount and the amount data type is Money.")
                    .WithDisplayName("Actual (Money)")
                    .ModelProperty("actualmoney", typeof(string)));

                this.ActualMoney_Base = group.Add(new VocabularyKey("ActualMoney_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the actual value (money type) in base currency to track goal results against the target.")
                    .WithDisplayName("Actual (Money) (Base)")
                    .ModelProperty("actualmoney_base", typeof(string)));

                this.CustomRollupFieldMoney = group.Add(new VocabularyKey("CustomRollupFieldMoney", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates a placeholder rollup field for a money value to track a third category of results other than actuals and in-progress results.")
                    .WithDisplayName("Custom Rollup Field (Money)")
                    .ModelProperty("customrollupfieldmoney", typeof(string)));

                this.CustomRollupFieldMoney_Base = group.Add(new VocabularyKey("CustomRollupFieldMoney_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates a placeholder rollup field for a money value in base currency to track a third category of results other than actuals and in-progress results.")
                    .WithDisplayName("Custom Rollup Field (Money) (Base)")
                    .ModelProperty("customrollupfieldmoney_base", typeof(string)));

                this.InProgressMoney = group.Add(new VocabularyKey("InProgressMoney", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the in-progress value (money) against the target. This value could contribute to a goal, but is not counted yet as actual.")
                    .WithDisplayName("In-progress (Money)")
                    .ModelProperty("inprogressmoney", typeof(string)));

                this.InProgressMoney_Base = group.Add(new VocabularyKey("InProgressMoney_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the in-progress value (money) in base currency to track goal results against the target.")
                    .WithDisplayName("In-progress (Money) (Base)")
                    .ModelProperty("inprogressmoney_base", typeof(string)));

                this.ActualDecimal = group.Add(new VocabularyKey("ActualDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the actual value (Decimal type) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount and the amount data type is Decimal.")
                    .WithDisplayName("Actual (Decimal)")
                    .ModelProperty("actualdecimal", typeof(decimal)));

                this.CustomRollupFieldDecimal = group.Add(new VocabularyKey("CustomRollupFieldDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates a placeholder rollup field for a decimal value to track a third category of results other than actuals and in-progress results.")
                    .WithDisplayName("Custom Rollup Field (Decimal)")
                    .ModelProperty("customrollupfielddecimal", typeof(decimal)));

                this.InProgressDecimal = group.Add(new VocabularyKey("InProgressDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the in-progress value (decimal) against the target. This value could contribute to a goal, but is not counted yet as actual.")
                    .WithDisplayName("In-progress (Decimal)")
                    .ModelProperty("inprogressdecimal", typeof(decimal)));

                this.ActualInteger = group.Add(new VocabularyKey("ActualInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the actual value (integer) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount or Count and the amount data type is Integer.")
                    .WithDisplayName("Actual (Integer)")
                    .ModelProperty("actualinteger", typeof(long)));

                this.CustomRollupFieldInteger = group.Add(new VocabularyKey("CustomRollupFieldInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates a placeholder rollup field for an integer value to track a third category of results other than actuals and in-progress results.")
                    .WithDisplayName("Custom Rollup Field (Integer)")
                    .ModelProperty("customrollupfieldinteger", typeof(long)));

                this.InProgressInteger = group.Add(new VocabularyKey("InProgressInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the in-progress value (integer) against the target. This value could contribute to a goal, but is not counted yet as actual.")
                    .WithDisplayName("In-progress (Integer)")
                    .ModelProperty("inprogressinteger", typeof(long)));

                this.Percentage = group.Add(new VocabularyKey("Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the percentage achieved against the target goal.")
                    .WithDisplayName("Percentage Achieved")
                    .ModelProperty("percentage", typeof(decimal)));

                this.IsFiscalPeriodGoal = group.Add(new VocabularyKey("IsFiscalPeriodGoal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the goal period is a fiscal period or custom period.")
                    .WithDisplayName("Goal Period Type")
                    .ModelProperty("isfiscalperiodgoal", typeof(bool)));

                this.IsFiscalPeriodGoalName = group.Add(new VocabularyKey("IsFiscalPeriodGoalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsFiscalPeriodGoalName")
                    .ModelProperty("isfiscalperiodgoalname", typeof(string)));

                this.ConsiderOnlyGoalOwnersRecords = group.Add(new VocabularyKey("ConsiderOnlyGoalOwnersRecords", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether only the goal owner's records, or all records, should be rolled up for goal results.")
                    .WithDisplayName("Record Set for Rollup")
                    .ModelProperty("consideronlygoalownersrecords", typeof(bool)));

                this.ConsiderOnlyGoalOwnersRecordsName = group.Add(new VocabularyKey("ConsiderOnlyGoalOwnersRecordsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ConsiderOnlyGoalOwnersRecordsName")
                    .ModelProperty("consideronlygoalownersrecordsname", typeof(string)));

                this.LastRolledupDate = group.Add(new VocabularyKey("LastRolledupDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the goal was last rolled up. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Last Rolled Up Date")
                    .ModelProperty("lastrolledupdate", typeof(DateTime)));

                this.TargetString = group.Add(new VocabularyKey("TargetString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Target value of the goal.")
                    .WithDisplayName("Target")
                    .ModelProperty("targetstring", typeof(string)));

                this.StretchTargetString = group.Add(new VocabularyKey("StretchTargetString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Stretch target value for all data types.")
                    .WithDisplayName("Stretched Target")
                    .ModelProperty("stretchtargetstring", typeof(string)));

                this.ActualString = group.Add(new VocabularyKey("ActualString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Actual Value of the goal.")
                    .WithDisplayName("Actual")
                    .ModelProperty("actualstring", typeof(string)));

                this.CustomRollupFieldString = group.Add(new VocabularyKey("CustomRollupFieldString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Placeholder rollup field for the goal.")
                    .WithDisplayName("Custom Rollup Field")
                    .ModelProperty("customrollupfieldstring", typeof(string)));

                this.InProgressString = group.Add(new VocabularyKey("InProgressString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"In-progress value of the goal.")
                    .WithDisplayName("In-Progress")
                    .ModelProperty("inprogressstring", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the goal.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.AmountDataType = group.Add(new VocabularyKey("AmountDataType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Data type of the amount.")
                    .WithDisplayName("Amount Data Type")
                    .ModelProperty("amountdatatype", typeof(string)));

                this.IsAmount = group.Add(new VocabularyKey("IsAmount", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the metric type is Count or Amount.")
                    .WithDisplayName("Metric Type")
                    .ModelProperty("isamount", typeof(bool)));

                this.AmountDataTypeName = group.Add(new VocabularyKey("AmountDataTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AmountDataTypeName")
                    .ModelProperty("amountdatatypename", typeof(string)));

                this.IsAmountName = group.Add(new VocabularyKey("IsAmountName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsAmountName")
                    .ModelProperty("isamountname", typeof(string)));

                this.RollupQueryActualIntegerId = group.Add(new VocabularyKey("RollupQueryActualIntegerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate the actual data for the goal (integer).")
                    .WithDisplayName("Rollup Query - Actual(Integer)")
                    .ModelProperty("rollupqueryactualintegerid", typeof(string)));

                this.RollupQueryActualIntegerIdName = group.Add(new VocabularyKey("RollupQueryActualIntegerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollupQueryActualIntegerIdName")
                    .ModelProperty("rollupqueryactualintegeridname", typeof(string)));

                this.RollUpQueryActualMoneyId = group.Add(new VocabularyKey("RollUpQueryActualMoneyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate the actual data for the goal (money).")
                    .WithDisplayName("Rollup Query - Actual(Money)")
                    .ModelProperty("rollupqueryactualmoneyid", typeof(string)));

                this.RollUpQueryActualMoneyIdName = group.Add(new VocabularyKey("RollUpQueryActualMoneyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryActualMoneyIdName")
                    .ModelProperty("rollupqueryactualmoneyidname", typeof(string)));

                this.RollUpQueryActualDecimalId = group.Add(new VocabularyKey("RollUpQueryActualDecimalId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate the actual data for the goal (decimal).")
                    .WithDisplayName("Rollup Query - Actual(Decimal)")
                    .ModelProperty("rollupqueryactualdecimalid", typeof(string)));

                this.RollUpQueryActualDecimalIdName = group.Add(new VocabularyKey("RollUpQueryActualDecimalIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryActualDecimalIdName")
                    .ModelProperty("rollupqueryactualdecimalidname", typeof(string)));

                this.RollUpQueryCustomIntegerId = group.Add(new VocabularyKey("RollUpQueryCustomIntegerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate data for the custom rollup field (integer).")
                    .WithDisplayName("Rollup Query - Custom Rollup Field (Integer)")
                    .ModelProperty("rollupquerycustomintegerid", typeof(string)));

                this.RollUpQueryCustomIntegerIdName = group.Add(new VocabularyKey("RollUpQueryCustomIntegerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryCustomIntegerIdName")
                    .ModelProperty("rollupquerycustomintegeridname", typeof(string)));

                this.RollUpQueryCustomMoneyId = group.Add(new VocabularyKey("RollUpQueryCustomMoneyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate data for the custom rollup field (money).")
                    .WithDisplayName("Rollup Query - Custom Rollup Field (Money)")
                    .ModelProperty("rollupquerycustommoneyid", typeof(string)));

                this.RollUpQueryCustomMoneyIdName = group.Add(new VocabularyKey("RollUpQueryCustomMoneyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryCustomMoneyIdName")
                    .ModelProperty("rollupquerycustommoneyidname", typeof(string)));

                this.RollUpQueryCustomDecimalId = group.Add(new VocabularyKey("RollUpQueryCustomDecimalId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate data for the custom rollup field (decimal).")
                    .WithDisplayName("Rollup Query - Custom Rollup Field (Decimal)")
                    .ModelProperty("rollupquerycustomdecimalid", typeof(string)));

                this.RollUpQueryCustomDecimalIdName = group.Add(new VocabularyKey("RollUpQueryCustomDecimalIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryCustomDecimalIdName")
                    .ModelProperty("rollupquerycustomdecimalidname", typeof(string)));

                this.RollUpQueryInprogressIntegerId = group.Add(new VocabularyKey("RollUpQueryInprogressIntegerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate data for the in-progress rollup field (integer).")
                    .WithDisplayName("Rollup Query - In-progress(Integer)")
                    .ModelProperty("rollupqueryinprogressintegerid", typeof(string)));

                this.RollUpQueryInprogressIntegerIdName = group.Add(new VocabularyKey("RollUpQueryInprogressIntegerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryInprogressIntegerIdName")
                    .ModelProperty("rollupqueryinprogressintegeridname", typeof(string)));

                this.RollUpQueryInprogressMoneyId = group.Add(new VocabularyKey("RollUpQueryInprogressMoneyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate data for the in-progress rollup field (money).")
                    .WithDisplayName("Rollup Query - In-progress(Money)")
                    .ModelProperty("rollupqueryinprogressmoneyid", typeof(string)));

                this.RollUpQueryInprogressMoneyIdName = group.Add(new VocabularyKey("RollUpQueryInprogressMoneyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryInprogressMoneyIdName")
                    .ModelProperty("rollupqueryinprogressmoneyidname", typeof(string)));

                this.RollUpQueryInprogressDecimalId = group.Add(new VocabularyKey("RollUpQueryInprogressDecimalId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the query that will be used to calculate data for the in-progress rollup field (decimal).")
                    .WithDisplayName("Rollup Query - In-progress(Decimal)")
                    .ModelProperty("rollupqueryinprogressdecimalid", typeof(string)));

                this.RollUpQueryInprogressDecimalIdName = group.Add(new VocabularyKey("RollUpQueryInprogressDecimalIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RollUpQueryInprogressDecimalIdName")
                    .ModelProperty("rollupqueryinprogressdecimalidname", typeof(string)));

                this.RollupOnlyFromChildGoals = group.Add(new VocabularyKey("RollupOnlyFromChildGoals", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the data should be rolled up only from the child goals.")
                    .WithDisplayName("Roll Up Only from Child Goals")
                    .ModelProperty("rolluponlyfromchildgoals", typeof(bool)));

                this.RollupOnlyFromChildGoalsName = group.Add(new VocabularyKey("RollupOnlyFromChildGoalsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RollupOnlyFromChildGoalsName")
                    .ModelProperty("rolluponlyfromchildgoalsname", typeof(string)));

                this.GoalWithErrorId = group.Add(new VocabularyKey("GoalWithErrorId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the goal that caused an error in the rollup of the goal hierarchy.")
                    .WithDisplayName("Goal With Error")
                    .ModelProperty("goalwitherrorid", typeof(string)));

                this.GoalWithErrorIdName = group.Add(new VocabularyKey("GoalWithErrorIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("GoalWithErrorIdName")
                    .ModelProperty("goalwitherroridname", typeof(string)));

                this.RollupErrorCode = group.Add(new VocabularyKey("RollupErrorCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Error code associated with rollup.")
                    .WithDisplayName("Rollup Error Code")
                    .ModelProperty("rolluperrorcode", typeof(long)));

                this.GoalOwnerIdType = group.Add(new VocabularyKey("GoalOwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Goal Owner Type")
                    .ModelProperty("goalowneridtype", typeof(string)));

                this.ComputedTargetAsOfTodayPercentageAchieved = group.Add(new VocabularyKey("ComputedTargetAsOfTodayPercentageAchieved", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the expected value for percentage achieved against the target goal as of the current date.")
                    .WithDisplayName("Today's Target (Percentage Achieved)")
                    .ModelProperty("computedtargetasoftodaypercentageachieved", typeof(decimal)));

                this.ComputedTargetAsOfTodayMoney = group.Add(new VocabularyKey("ComputedTargetAsOfTodayMoney", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the expected amount for actual value (money type) against the target goal as of the current date.")
                    .WithDisplayName("Today's Target (Money)")
                    .ModelProperty("computedtargetasoftodaymoney", typeof(string)));

                this.ComputedTargetAsOfTodayMoney_Base = group.Add(new VocabularyKey("ComputedTargetAsOfTodayMoney_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the expected amount in base currency for actual value (money type) against the target goal as of the current date.")
                    .WithDisplayName("Today's Target (Money) (Base)")
                    .ModelProperty("computedtargetasoftodaymoney_base", typeof(string)));

                this.ComputedTargetAsOfTodayDecimal = group.Add(new VocabularyKey("ComputedTargetAsOfTodayDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the expected amount for actual value (decimal type) against the target goal.")
                    .WithDisplayName("Today's Target (Decimal)")
                    .ModelProperty("computedtargetasoftodaydecimal", typeof(decimal)));

                this.ComputedTargetAsOfTodayInteger = group.Add(new VocabularyKey("ComputedTargetAsOfTodayInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the expected amount for actual value (integer type) against the target goal as of the current date.")
                    .WithDisplayName("Today's Target (Integer)")
                    .ModelProperty("computedtargetasoftodayinteger", typeof(long)));

                this.IsOverride = group.Add(new VocabularyKey("IsOverride", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the values of system rollup fields can be updated.")
                    .WithDisplayName("Override")
                    .ModelProperty("isoverride", typeof(bool)));

                this.IsOverridden = group.Add(new VocabularyKey("IsOverridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the system rollup fields are updated. If set to Yes, the next system rollup will not update the values of the rollup fields with the system calculated values.")
                    .WithDisplayName("Overridden")
                    .ModelProperty("isoverridden", typeof(bool)));

                this.IsOverrideName = group.Add(new VocabularyKey("IsOverrideName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsOverrideName")
                    .ModelProperty("isoverridename", typeof(string)));

                this.IsOverriddenName = group.Add(new VocabularyKey("IsOverriddenName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsOverriddenName")
                    .ModelProperty("isoverriddenname", typeof(string)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The default image for the entity.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey GoalId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey FiscalPeriod { get; private set; }

        public VocabularyKey fiscalperiodName { get; private set; }

        public VocabularyKey FiscalYear { get; private set; }

        public VocabularyKey fiscalyearName { get; private set; }

        public VocabularyKey GoalStartDate { get; private set; }

        public VocabularyKey GoalEndDate { get; private set; }

        public VocabularyKey GoalOwnerId { get; private set; }

        public VocabularyKey GoalOwnerIdName { get; private set; }

        public VocabularyKey GoalOwnerIdYomiName { get; private set; }

        public VocabularyKey ParentGoalId { get; private set; }

        public VocabularyKey ParentGoalIdName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey MetricId { get; private set; }

        public VocabularyKey MetricIdName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey TreeId { get; private set; }

        public VocabularyKey Depth { get; private set; }

        public VocabularyKey StretchTargetMoney { get; private set; }

        public VocabularyKey StretchTargetMoney_Base { get; private set; }

        public VocabularyKey StretchTargetDecimal { get; private set; }

        public VocabularyKey StretchTargetInteger { get; private set; }

        public VocabularyKey TargetMoney { get; private set; }

        public VocabularyKey TargetMoney_Base { get; private set; }

        public VocabularyKey TargetDecimal { get; private set; }

        public VocabularyKey TargetInteger { get; private set; }

        public VocabularyKey ActualMoney { get; private set; }

        public VocabularyKey ActualMoney_Base { get; private set; }

        public VocabularyKey CustomRollupFieldMoney { get; private set; }

        public VocabularyKey CustomRollupFieldMoney_Base { get; private set; }

        public VocabularyKey InProgressMoney { get; private set; }

        public VocabularyKey InProgressMoney_Base { get; private set; }

        public VocabularyKey ActualDecimal { get; private set; }

        public VocabularyKey CustomRollupFieldDecimal { get; private set; }

        public VocabularyKey InProgressDecimal { get; private set; }

        public VocabularyKey ActualInteger { get; private set; }

        public VocabularyKey CustomRollupFieldInteger { get; private set; }

        public VocabularyKey InProgressInteger { get; private set; }

        public VocabularyKey Percentage { get; private set; }

        public VocabularyKey IsFiscalPeriodGoal { get; private set; }

        public VocabularyKey IsFiscalPeriodGoalName { get; private set; }

        public VocabularyKey ConsiderOnlyGoalOwnersRecords { get; private set; }

        public VocabularyKey ConsiderOnlyGoalOwnersRecordsName { get; private set; }

        public VocabularyKey LastRolledupDate { get; private set; }

        public VocabularyKey TargetString { get; private set; }

        public VocabularyKey StretchTargetString { get; private set; }

        public VocabularyKey ActualString { get; private set; }

        public VocabularyKey CustomRollupFieldString { get; private set; }

        public VocabularyKey InProgressString { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey AmountDataType { get; private set; }

        public VocabularyKey IsAmount { get; private set; }

        public VocabularyKey AmountDataTypeName { get; private set; }

        public VocabularyKey IsAmountName { get; private set; }

        public VocabularyKey RollupQueryActualIntegerId { get; private set; }

        public VocabularyKey RollupQueryActualIntegerIdName { get; private set; }

        public VocabularyKey RollUpQueryActualMoneyId { get; private set; }

        public VocabularyKey RollUpQueryActualMoneyIdName { get; private set; }

        public VocabularyKey RollUpQueryActualDecimalId { get; private set; }

        public VocabularyKey RollUpQueryActualDecimalIdName { get; private set; }

        public VocabularyKey RollUpQueryCustomIntegerId { get; private set; }

        public VocabularyKey RollUpQueryCustomIntegerIdName { get; private set; }

        public VocabularyKey RollUpQueryCustomMoneyId { get; private set; }

        public VocabularyKey RollUpQueryCustomMoneyIdName { get; private set; }

        public VocabularyKey RollUpQueryCustomDecimalId { get; private set; }

        public VocabularyKey RollUpQueryCustomDecimalIdName { get; private set; }

        public VocabularyKey RollUpQueryInprogressIntegerId { get; private set; }

        public VocabularyKey RollUpQueryInprogressIntegerIdName { get; private set; }

        public VocabularyKey RollUpQueryInprogressMoneyId { get; private set; }

        public VocabularyKey RollUpQueryInprogressMoneyIdName { get; private set; }

        public VocabularyKey RollUpQueryInprogressDecimalId { get; private set; }

        public VocabularyKey RollUpQueryInprogressDecimalIdName { get; private set; }

        public VocabularyKey RollupOnlyFromChildGoals { get; private set; }

        public VocabularyKey RollupOnlyFromChildGoalsName { get; private set; }

        public VocabularyKey GoalWithErrorId { get; private set; }

        public VocabularyKey GoalWithErrorIdName { get; private set; }

        public VocabularyKey RollupErrorCode { get; private set; }

        public VocabularyKey GoalOwnerIdType { get; private set; }

        public VocabularyKey ComputedTargetAsOfTodayPercentageAchieved { get; private set; }

        public VocabularyKey ComputedTargetAsOfTodayMoney { get; private set; }

        public VocabularyKey ComputedTargetAsOfTodayMoney_Base { get; private set; }

        public VocabularyKey ComputedTargetAsOfTodayDecimal { get; private set; }

        public VocabularyKey ComputedTargetAsOfTodayInteger { get; private set; }

        public VocabularyKey IsOverride { get; private set; }

        public VocabularyKey IsOverridden { get; private set; }

        public VocabularyKey IsOverrideName { get; private set; }

        public VocabularyKey IsOverriddenName { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }


    }
}

