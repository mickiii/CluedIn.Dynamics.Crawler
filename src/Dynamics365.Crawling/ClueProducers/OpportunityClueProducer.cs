using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=opportunity&id={1}", this._dynamics365CrawlJobData.Url, input.OpportunityId.ToString()), UriKind.Absolute, out Uri uri))
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

            var vocab = new OpportunityVocabulary();

            data.Properties[vocab.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[vocab.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[vocab.OpportunityRatingCode] = input.OpportunityRatingCode.PrintIfAvailable();
            data.Properties[vocab.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[vocab.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[vocab.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.StepId] = input.StepId.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.EstimatedValue] = input.EstimatedValue.PrintIfAvailable();
            data.Properties[vocab.StepName] = input.StepName.PrintIfAvailable();
            data.Properties[vocab.SalesStageCode] = input.SalesStageCode.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[vocab.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[vocab.EstimatedCloseDate] = input.EstimatedCloseDate.PrintIfAvailable();
            data.Properties[vocab.CloseProbability] = input.CloseProbability.PrintIfAvailable();
            data.Properties[vocab.ActualValue] = input.ActualValue.PrintIfAvailable();
            data.Properties[vocab.ActualCloseDate] = input.ActualCloseDate.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadId] = input.OriginatingLeadId.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.IsRevenueSystemCalculated] = input.IsRevenueSystemCalculated.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadIdName] = input.OriginatingLeadIdName.PrintIfAvailable();
            data.Properties[vocab.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[vocab.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[vocab.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[vocab.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[vocab.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[vocab.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[vocab.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[vocab.IsRevenueSystemCalculatedName] = input.IsRevenueSystemCalculatedName.PrintIfAvailable();
            data.Properties[vocab.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.SalesStageCodeName] = input.SalesStageCodeName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.OpportunityRatingCodeName] = input.OpportunityRatingCodeName.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[vocab.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[vocab.CampaignIdName] = input.CampaignIdName.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.ActualValue_Base] = input.ActualValue_Base.PrintIfAvailable();
            data.Properties[vocab.EstimatedValue_Base] = input.EstimatedValue_Base.PrintIfAvailable();
            data.Properties[vocab.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.TotalTax] = input.TotalTax.PrintIfAvailable();
            data.Properties[vocab.DiscountPercentage] = input.DiscountPercentage.PrintIfAvailable();
            data.Properties[vocab.TotalAmount] = input.TotalAmount.PrintIfAvailable();
            data.Properties[vocab.DiscountAmount] = input.DiscountAmount.PrintIfAvailable();
            data.Properties[vocab.TotalAmountLessFreight] = input.TotalAmountLessFreight.PrintIfAvailable();
            data.Properties[vocab.FreightAmount] = input.FreightAmount.PrintIfAvailable();
            data.Properties[vocab.TotalLineItemDiscountAmount] = input.TotalLineItemDiscountAmount.PrintIfAvailable();
            data.Properties[vocab.TotalLineItemAmount] = input.TotalLineItemAmount.PrintIfAvailable();
            data.Properties[vocab.TotalDiscountAmount] = input.TotalDiscountAmount.PrintIfAvailable();
            data.Properties[vocab.TotalLineItemAmount_Base] = input.TotalLineItemAmount_Base.PrintIfAvailable();
            data.Properties[vocab.TotalDiscountAmount_Base] = input.TotalDiscountAmount_Base.PrintIfAvailable();
            data.Properties[vocab.TotalTax_Base] = input.TotalTax_Base.PrintIfAvailable();
            data.Properties[vocab.DiscountAmount_Base] = input.DiscountAmount_Base.PrintIfAvailable();
            data.Properties[vocab.TotalLineItemDiscountAmount_Base] = input.TotalLineItemDiscountAmount_Base.PrintIfAvailable();
            data.Properties[vocab.TotalAmount_Base] = input.TotalAmount_Base.PrintIfAvailable();
            data.Properties[vocab.TotalAmountLessFreight_Base] = input.TotalAmountLessFreight_Base.PrintIfAvailable();
            data.Properties[vocab.FreightAmount_Base] = input.FreightAmount_Base.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.BudgetStatus] = input.BudgetStatus.PrintIfAvailable();
            data.Properties[vocab.DecisionMaker] = input.DecisionMaker.PrintIfAvailable();
            data.Properties[vocab.Need] = input.Need.PrintIfAvailable();
            data.Properties[vocab.TimeLine] = input.TimeLine.PrintIfAvailable();
            data.Properties[vocab.TimelineName] = input.TimelineName.PrintIfAvailable();
            data.Properties[vocab.NeedName] = input.NeedName.PrintIfAvailable();
            data.Properties[vocab.DecisionMakerName] = input.DecisionMakerName.PrintIfAvailable();
            data.Properties[vocab.BudgetTypeName] = input.BudgetTypeName.PrintIfAvailable();
            data.Properties[vocab.BudgetAmount] = input.BudgetAmount.PrintIfAvailable();
            data.Properties[vocab.BudgetAmount_Base] = input.BudgetAmount_Base.PrintIfAvailable();
            data.Properties[vocab.ParentAccountId] = input.ParentAccountId.PrintIfAvailable();
            data.Properties[vocab.ParentAccountIdName] = input.ParentAccountIdName.PrintIfAvailable();
            data.Properties[vocab.ParentAccountIdYomiName] = input.ParentAccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ParentContactId] = input.ParentContactId.PrintIfAvailable();
            data.Properties[vocab.ParentContactIdName] = input.ParentContactIdName.PrintIfAvailable();
            data.Properties[vocab.ParentContactIdYomiName] = input.ParentContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.EvaluateFit] = input.EvaluateFit.PrintIfAvailable();
            data.Properties[vocab.EvaluateFitName] = input.EvaluateFitName.PrintIfAvailable();
            data.Properties[vocab.InitialCommunication] = input.InitialCommunication.PrintIfAvailable();
            data.Properties[vocab.InitialCommunicationName] = input.InitialCommunicationName.PrintIfAvailable();
            data.Properties[vocab.ConfirmInterest] = input.ConfirmInterest.PrintIfAvailable();
            data.Properties[vocab.ConfirmInterestName] = input.ConfirmInterestName.PrintIfAvailable();
            data.Properties[vocab.ScheduleFollowup_Prospect] = input.ScheduleFollowup_Prospect.PrintIfAvailable();
            data.Properties[vocab.ScheduleFollowup_Qualify] = input.ScheduleFollowup_Qualify.PrintIfAvailable();
            data.Properties[vocab.ScheduleProposalMeeting] = input.ScheduleProposalMeeting.PrintIfAvailable();
            data.Properties[vocab.FinalDecisionDate] = input.FinalDecisionDate.PrintIfAvailable();
            data.Properties[vocab.DevelopProposal] = input.DevelopProposal.PrintIfAvailable();
            data.Properties[vocab.DevelopProposalName] = input.DevelopProposalName.PrintIfAvailable();
            data.Properties[vocab.CompleteInternalReview] = input.CompleteInternalReview.PrintIfAvailable();
            data.Properties[vocab.CompleteInternalReviewName] = input.CompleteInternalReviewName.PrintIfAvailable();
            data.Properties[vocab.CaptureProposalFeedback] = input.CaptureProposalFeedback.PrintIfAvailable();
            data.Properties[vocab.CaptureProposalFeedbackName] = input.CaptureProposalFeedbackName.PrintIfAvailable();
            data.Properties[vocab.ResolveFeedback] = input.ResolveFeedback.PrintIfAvailable();
            data.Properties[vocab.ResolveFeedbackName] = input.ResolveFeedbackName.PrintIfAvailable();
            data.Properties[vocab.PresentProposal] = input.PresentProposal.PrintIfAvailable();
            data.Properties[vocab.PresentProposalName] = input.PresentProposalName.PrintIfAvailable();
            data.Properties[vocab.SendThankYouNote] = input.SendThankYouNote.PrintIfAvailable();
            data.Properties[vocab.SendThankYouNoteName] = input.SendThankYouNoteName.PrintIfAvailable();
            data.Properties[vocab.SalesStage] = input.SalesStage.PrintIfAvailable();
            data.Properties[vocab.SalesStageName] = input.SalesStageName.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.CompleteFinalProposal] = input.CompleteFinalProposal.PrintIfAvailable();
            data.Properties[vocab.CompleteFinalProposalName] = input.CompleteFinalProposalName.PrintIfAvailable();
            data.Properties[vocab.FileDebrief] = input.FileDebrief.PrintIfAvailable();
            data.Properties[vocab.FileDeBriefName] = input.FileDeBriefName.PrintIfAvailable();
            data.Properties[vocab.PursuitDecision] = input.PursuitDecision.PrintIfAvailable();
            data.Properties[vocab.PursuitDecisionName] = input.PursuitDecisionName.PrintIfAvailable();
            data.Properties[vocab.CustomerPainPoints] = input.CustomerPainPoints.PrintIfAvailable();
            data.Properties[vocab.CustomerNeed] = input.CustomerNeed.PrintIfAvailable();
            data.Properties[vocab.ProposedSolution] = input.ProposedSolution.PrintIfAvailable();
            data.Properties[vocab.QualificationComments] = input.QualificationComments.PrintIfAvailable();
            data.Properties[vocab.QuoteComments] = input.QuoteComments.PrintIfAvailable();
            data.Properties[vocab.PurchaseProcess] = input.PurchaseProcess.PrintIfAvailable();
            data.Properties[vocab.PurchaseProcessName] = input.PurchaseProcessName.PrintIfAvailable();
            data.Properties[vocab.PurchaseTimeframe] = input.PurchaseTimeframe.PrintIfAvailable();
            data.Properties[vocab.PurchaseTimeframeName] = input.PurchaseTimeframeName.PrintIfAvailable();
            data.Properties[vocab.IdentifyCustomerContacts] = input.IdentifyCustomerContacts.PrintIfAvailable();
            data.Properties[vocab.IdentifyCustomerContactsName] = input.IdentifyCustomerContactsName.PrintIfAvailable();
            data.Properties[vocab.IdentifyCompetitors] = input.IdentifyCompetitors.PrintIfAvailable();
            data.Properties[vocab.IdentifyCompetitorsName] = input.IdentifyCompetitorsName.PrintIfAvailable();
            data.Properties[vocab.IdentifyPursuitTeam] = input.IdentifyPursuitTeam.PrintIfAvailable();
            data.Properties[vocab.IdentifyPursuitTeamName] = input.IdentifyPursuitTeamName.PrintIfAvailable();
            data.Properties[vocab.CurrentSituation] = input.CurrentSituation.PrintIfAvailable();
            data.Properties[vocab.PresentFinalProposal] = input.PresentFinalProposal.PrintIfAvailable();
            data.Properties[vocab.PresentFinalProposalName] = input.PresentFinalProposalName.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[vocab.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[vocab.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();
            data.Properties[vocab.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[vocab.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            // Add custom vocab
            foreach (var key in input.Custom.Keys)
            {
                var vocabName = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                var vocabKey = new VocabularyKey(vocabName, VocabularyKeyDataType.Json, VocabularyKeyVisibility.Visible);
                data.Properties[vocabKey] = input.Custom[key].ToString().PrintIfAvailable();
            }

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

