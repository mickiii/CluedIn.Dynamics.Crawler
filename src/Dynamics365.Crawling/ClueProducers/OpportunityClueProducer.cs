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
    public abstract class OpportunityClueProducer<T> : DynamicsClueProducer<T> where T : Opportunity
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OpportunityClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Sales.Opportunity, input.OpportunityId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=opportunity&id={1}", this._dynamics365CrawlJobData.Api, input.OpportunityId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.PriceLevelId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.PriceLevelId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.CustomerId);

            if (input.ParentContactId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.ParentContactId);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            if (input.CampaignId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Campaign, EntityEdgeType.Parent, input, input.CampaignId);

            if (input.OriginatingLeadId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.Parent, input, input.OriginatingLeadId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.CustomerId);

            if (input.ParentAccountId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.ParentAccountId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            data.Properties[Dynamics365Vocabulary.Opportunity.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OpportunityRatingCode] = input.OpportunityRatingCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StepId] = input.StepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.EstimatedValue] = input.EstimatedValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StepName] = input.StepName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SalesStageCode] = input.SalesStageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.EstimatedCloseDate] = input.EstimatedCloseDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CloseProbability] = input.CloseProbability.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ActualValue] = input.ActualValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ActualCloseDate] = input.ActualCloseDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OriginatingLeadId] = input.OriginatingLeadId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IsRevenueSystemCalculated] = input.IsRevenueSystemCalculated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OriginatingLeadIdName] = input.OriginatingLeadIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IsRevenueSystemCalculatedName] = input.IsRevenueSystemCalculatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SalesStageCodeName] = input.SalesStageCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OpportunityRatingCodeName] = input.OpportunityRatingCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CampaignIdName] = input.CampaignIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ActualValue_Base] = input.ActualValue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.EstimatedValue_Base] = input.EstimatedValue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalTax] = input.TotalTax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DiscountPercentage] = input.DiscountPercentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalAmount] = input.TotalAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DiscountAmount] = input.DiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalAmountLessFreight] = input.TotalAmountLessFreight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.FreightAmount] = input.FreightAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalLineItemDiscountAmount] = input.TotalLineItemDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalLineItemAmount] = input.TotalLineItemAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalDiscountAmount] = input.TotalDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalLineItemAmount_Base] = input.TotalLineItemAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalDiscountAmount_Base] = input.TotalDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalTax_Base] = input.TotalTax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DiscountAmount_Base] = input.DiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalLineItemDiscountAmount_Base] = input.TotalLineItemDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalAmount_Base] = input.TotalAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TotalAmountLessFreight_Base] = input.TotalAmountLessFreight_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.FreightAmount_Base] = input.FreightAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.BudgetStatus] = input.BudgetStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DecisionMaker] = input.DecisionMaker.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.Need] = input.Need.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TimeLine] = input.TimeLine.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TimelineName] = input.TimelineName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.NeedName] = input.NeedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DecisionMakerName] = input.DecisionMakerName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.BudgetTypeName] = input.BudgetTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.BudgetAmount] = input.BudgetAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.BudgetAmount_Base] = input.BudgetAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParentAccountId] = input.ParentAccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParentAccountIdName] = input.ParentAccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParentAccountIdYomiName] = input.ParentAccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParentContactId] = input.ParentContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParentContactIdName] = input.ParentContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ParentContactIdYomiName] = input.ParentContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.EvaluateFit] = input.EvaluateFit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.EvaluateFitName] = input.EvaluateFitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.InitialCommunication] = input.InitialCommunication.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.InitialCommunicationName] = input.InitialCommunicationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ConfirmInterest] = input.ConfirmInterest.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ConfirmInterestName] = input.ConfirmInterestName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ScheduleFollowup_Prospect] = input.ScheduleFollowup_Prospect.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ScheduleFollowup_Qualify] = input.ScheduleFollowup_Qualify.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ScheduleProposalMeeting] = input.ScheduleProposalMeeting.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.FinalDecisionDate] = input.FinalDecisionDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DevelopProposal] = input.DevelopProposal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.DevelopProposalName] = input.DevelopProposalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CompleteInternalReview] = input.CompleteInternalReview.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CompleteInternalReviewName] = input.CompleteInternalReviewName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CaptureProposalFeedback] = input.CaptureProposalFeedback.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CaptureProposalFeedbackName] = input.CaptureProposalFeedbackName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ResolveFeedback] = input.ResolveFeedback.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ResolveFeedbackName] = input.ResolveFeedbackName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PresentProposal] = input.PresentProposal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PresentProposalName] = input.PresentProposalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SendThankYouNote] = input.SendThankYouNote.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SendThankYouNoteName] = input.SendThankYouNoteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SalesStage] = input.SalesStage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SalesStageName] = input.SalesStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CompleteFinalProposal] = input.CompleteFinalProposal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CompleteFinalProposalName] = input.CompleteFinalProposalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.FileDebrief] = input.FileDebrief.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.FileDeBriefName] = input.FileDeBriefName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PursuitDecision] = input.PursuitDecision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PursuitDecisionName] = input.PursuitDecisionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CustomerPainPoints] = input.CustomerPainPoints.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CustomerNeed] = input.CustomerNeed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ProposedSolution] = input.ProposedSolution.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.QualificationComments] = input.QualificationComments.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.QuoteComments] = input.QuoteComments.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PurchaseProcess] = input.PurchaseProcess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PurchaseProcessName] = input.PurchaseProcessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PurchaseTimeframe] = input.PurchaseTimeframe.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PurchaseTimeframeName] = input.PurchaseTimeframeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IdentifyCustomerContacts] = input.IdentifyCustomerContacts.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IdentifyCustomerContactsName] = input.IdentifyCustomerContactsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IdentifyCompetitors] = input.IdentifyCompetitors.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IdentifyCompetitorsName] = input.IdentifyCompetitorsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IdentifyPursuitTeam] = input.IdentifyPursuitTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.IdentifyPursuitTeamName] = input.IdentifyPursuitTeamName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.CurrentSituation] = input.CurrentSituation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PresentFinalProposal] = input.PresentFinalProposal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.PresentFinalProposalName] = input.PresentFinalProposalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Opportunity.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

