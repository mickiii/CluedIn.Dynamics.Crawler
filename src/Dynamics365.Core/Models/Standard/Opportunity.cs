using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Opportunity : DynamicsModel
    {
        [JsonProperty("opportunityid")]
        public Guid? OpportunityId { get; set; }

        [JsonProperty("pricelevelid")]
        public string PriceLevelId { get; set; }

        [JsonProperty("opportunityratingcode")]
        public string OpportunityRatingCode { get; set; }

        [JsonProperty("prioritycode")]
        public string PriorityCode { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stepid")]
        public Guid? StepId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimatedvalue")]
        public string EstimatedValue { get; set; }

        [JsonProperty("stepname")]
        public string StepName { get; set; }

        [JsonProperty("salesstagecode")]
        public string SalesStageCode { get; set; }

        [JsonProperty("participatesinworkflow")]
        public bool? ParticipatesInWorkflow { get; set; }

        [JsonProperty("pricingerrorcode")]
        public string PricingErrorCode { get; set; }

        [JsonProperty("estimatedclosedate")]
        public DateTimeOffset? EstimatedCloseDate { get; set; }

        [JsonProperty("closeprobability")]
        public long? CloseProbability { get; set; }

        [JsonProperty("actualvalue")]
        public string ActualValue { get; set; }

        [JsonProperty("actualclosedate")]
        public DateTimeOffset? ActualCloseDate { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("originatingleadid")]
        public string OriginatingLeadId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("isprivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("isrevenuesystemcalculated")]
        public bool? IsRevenueSystemCalculated { get; set; }

        [JsonProperty("originatingleadidname")]
        public string OriginatingLeadIdName { get; set; }

        [JsonProperty("contactidname")]
        public string ContactIdName { get; set; }

        [JsonProperty("accountidname")]
        public string AccountIdName { get; set; }

        [JsonProperty("pricelevelidname")]
        public string PriceLevelIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("customerid")]
        public string CustomerId { get; set; }

        [JsonProperty("customeridname")]
        public string CustomerIdName { get; set; }

        [JsonProperty("customeridtype")]
        public string CustomerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("isprivatename")]
        public string IsPrivateName { get; set; }

        [JsonProperty("participatesinworkflowname")]
        public string ParticipatesInWorkflowName { get; set; }

        [JsonProperty("isrevenuesystemcalculatedname")]
        public string IsRevenueSystemCalculatedName { get; set; }

        [JsonProperty("prioritycodename")]
        public string PriorityCodeName { get; set; }

        [JsonProperty("salesstagecodename")]
        public string SalesStageCodeName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("opportunityratingcodename")]
        public string OpportunityRatingCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("pricingerrorcodename")]
        public string PricingErrorCodeName { get; set; }

        [JsonProperty("campaignid")]
        public string CampaignId { get; set; }

        [JsonProperty("campaignidname")]
        public string CampaignIdName { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("actualvalue_base")]
        public string ActualValue_Base { get; set; }

        [JsonProperty("estimatedvalue_base")]
        public string EstimatedValue_Base { get; set; }

        [JsonProperty("contactidyominame")]
        public string ContactIdYomiName { get; set; }

        [JsonProperty("accountidyominame")]
        public string AccountIdYomiName { get; set; }

        [JsonProperty("originatingleadidyominame")]
        public string OriginatingLeadIdYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("customeridyominame")]
        public string CustomerIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("totaltax")]
        public string TotalTax { get; set; }

        [JsonProperty("discountpercentage")]
        public decimal? DiscountPercentage { get; set; }

        [JsonProperty("totalamount")]
        public string TotalAmount { get; set; }

        [JsonProperty("discountamount")]
        public string DiscountAmount { get; set; }

        [JsonProperty("totalamountlessfreight")]
        public string TotalAmountLessFreight { get; set; }

        [JsonProperty("freightamount")]
        public string FreightAmount { get; set; }

        [JsonProperty("totallineitemdiscountamount")]
        public string TotalLineItemDiscountAmount { get; set; }

        [JsonProperty("totallineitemamount")]
        public string TotalLineItemAmount { get; set; }

        [JsonProperty("totaldiscountamount")]
        public string TotalDiscountAmount { get; set; }

        [JsonProperty("totallineitemamount_base")]
        public string TotalLineItemAmount_Base { get; set; }

        [JsonProperty("totaldiscountamount_base")]
        public string TotalDiscountAmount_Base { get; set; }

        [JsonProperty("totaltax_base")]
        public string TotalTax_Base { get; set; }

        [JsonProperty("discountamount_base")]
        public string DiscountAmount_Base { get; set; }

        [JsonProperty("totallineitemdiscountamount_base")]
        public string TotalLineItemDiscountAmount_Base { get; set; }

        [JsonProperty("totalamount_base")]
        public string TotalAmount_Base { get; set; }

        [JsonProperty("totalamountlessfreight_base")]
        public string TotalAmountLessFreight_Base { get; set; }

        [JsonProperty("freightamount_base")]
        public string FreightAmount_Base { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("budgetstatus")]
        public string BudgetStatus { get; set; }

        [JsonProperty("decisionmaker")]
        public bool? DecisionMaker { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("timeline")]
        public string TimeLine { get; set; }

        [JsonProperty("timelinename")]
        public string TimelineName { get; set; }

        [JsonProperty("needname")]
        public string NeedName { get; set; }

        [JsonProperty("decisionmakername")]
        public string DecisionMakerName { get; set; }

        [JsonProperty("budgettypename")]
        public string BudgetTypeName { get; set; }

        [JsonProperty("budgetamount")]
        public string BudgetAmount { get; set; }

        [JsonProperty("budgetamount_base")]
        public string BudgetAmount_Base { get; set; }

        [JsonProperty("parentaccountid")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parentaccountidname")]
        public string ParentAccountIdName { get; set; }

        [JsonProperty("parentaccountidyominame")]
        public string ParentAccountIdYomiName { get; set; }

        [JsonProperty("parentcontactid")]
        public string ParentContactId { get; set; }

        [JsonProperty("parentcontactidname")]
        public string ParentContactIdName { get; set; }

        [JsonProperty("parentcontactidyominame")]
        public string ParentContactIdYomiName { get; set; }

        [JsonProperty("evaluatefit")]
        public bool? EvaluateFit { get; set; }

        [JsonProperty("evaluatefitname")]
        public string EvaluateFitName { get; set; }

        [JsonProperty("initialcommunication")]
        public string InitialCommunication { get; set; }

        [JsonProperty("initialcommunicationname")]
        public string InitialCommunicationName { get; set; }

        [JsonProperty("confirminterest")]
        public bool? ConfirmInterest { get; set; }

        [JsonProperty("confirminterestname")]
        public string ConfirmInterestName { get; set; }

        [JsonProperty("schedulefollowup_prospect")]
        public DateTimeOffset? ScheduleFollowup_Prospect { get; set; }

        [JsonProperty("schedulefollowup_qualify")]
        public DateTimeOffset? ScheduleFollowup_Qualify { get; set; }

        [JsonProperty("scheduleproposalmeeting")]
        public DateTimeOffset? ScheduleProposalMeeting { get; set; }

        [JsonProperty("finaldecisiondate")]
        public DateTimeOffset? FinalDecisionDate { get; set; }

        [JsonProperty("developproposal")]
        public bool? DevelopProposal { get; set; }

        [JsonProperty("developproposalname")]
        public string DevelopProposalName { get; set; }

        [JsonProperty("completeinternalreview")]
        public bool? CompleteInternalReview { get; set; }

        [JsonProperty("completeinternalreviewname")]
        public string CompleteInternalReviewName { get; set; }

        [JsonProperty("captureproposalfeedback")]
        public bool? CaptureProposalFeedback { get; set; }

        [JsonProperty("captureproposalfeedbackname")]
        public string CaptureProposalFeedbackName { get; set; }

        [JsonProperty("resolvefeedback")]
        public bool? ResolveFeedback { get; set; }

        [JsonProperty("resolvefeedbackname")]
        public string ResolveFeedbackName { get; set; }

        [JsonProperty("presentproposal")]
        public bool? PresentProposal { get; set; }

        [JsonProperty("presentproposalname")]
        public string PresentProposalName { get; set; }

        [JsonProperty("sendthankyounote")]
        public bool? SendThankYouNote { get; set; }

        [JsonProperty("sendthankyounotename")]
        public string SendThankYouNoteName { get; set; }

        [JsonProperty("salesstage")]
        public string SalesStage { get; set; }

        [JsonProperty("salesstagename")]
        public string SalesStageName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("completefinalproposal")]
        public bool? CompleteFinalProposal { get; set; }

        [JsonProperty("completefinalproposalname")]
        public string CompleteFinalProposalName { get; set; }

        [JsonProperty("filedebrief")]
        public bool? FileDebrief { get; set; }

        [JsonProperty("filedebriefname")]
        public string FileDeBriefName { get; set; }

        [JsonProperty("pursuitdecision")]
        public bool? PursuitDecision { get; set; }

        [JsonProperty("pursuitdecisionname")]
        public string PursuitDecisionName { get; set; }

        [JsonProperty("customerpainpoints")]
        public string CustomerPainPoints { get; set; }

        [JsonProperty("customerneed")]
        public string CustomerNeed { get; set; }

        [JsonProperty("proposedsolution")]
        public string ProposedSolution { get; set; }

        [JsonProperty("qualificationcomments")]
        public string QualificationComments { get; set; }

        [JsonProperty("quotecomments")]
        public string QuoteComments { get; set; }

        [JsonProperty("purchaseprocess")]
        public string PurchaseProcess { get; set; }

        [JsonProperty("purchaseprocessname")]
        public string PurchaseProcessName { get; set; }

        [JsonProperty("purchasetimeframe")]
        public string PurchaseTimeframe { get; set; }

        [JsonProperty("purchasetimeframename")]
        public string PurchaseTimeframeName { get; set; }

        [JsonProperty("identifycustomercontacts")]
        public bool? IdentifyCustomerContacts { get; set; }

        [JsonProperty("identifycustomercontactsname")]
        public string IdentifyCustomerContactsName { get; set; }

        [JsonProperty("identifycompetitors")]
        public bool? IdentifyCompetitors { get; set; }

        [JsonProperty("identifycompetitorsname")]
        public string IdentifyCompetitorsName { get; set; }

        [JsonProperty("identifypursuitteam")]
        public bool? IdentifyPursuitTeam { get; set; }

        [JsonProperty("identifypursuitteamname")]
        public string IdentifyPursuitTeamName { get; set; }

        [JsonProperty("currentsituation")]
        public string CurrentSituation { get; set; }

        [JsonProperty("presentfinalproposal")]
        public bool? PresentFinalProposal { get; set; }

        [JsonProperty("presentfinalproposalname")]
        public string PresentFinalProposalName { get; set; }

        [JsonProperty("onholdtime")]
        public long? OnHoldTime { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("lastonholdtime")]
        public DateTimeOffset? LastOnHoldTime { get; set; }

        [JsonProperty("slaid")]
        public string SLAId { get; set; }

        [JsonProperty("slaname")]
        public string SLAName { get; set; }

        [JsonProperty("slainvokedid")]
        public string SLAInvokedId { get; set; }

        [JsonProperty("slainvokedidname")]
        public string SLAInvokedIdName { get; set; }

        [JsonProperty("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }

        [JsonProperty("emailaddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("teamsfollowed")]
        public long? TeamsFollowed { get; set; }

        [JsonProperty("skippricecalculation")]
        public string SkipPriceCalculation { get; set; }

        [JsonProperty("skippricecalculationname")]
        public string skippricecalculationName { get; set; }


    }
}

