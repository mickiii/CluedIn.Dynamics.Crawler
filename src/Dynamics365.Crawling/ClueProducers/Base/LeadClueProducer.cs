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
    public abstract class LeadClueProducer<T> : DynamicsClueProducer<T> where T : Lead
    {
        public LeadClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Sales.Lead, input.LeadId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=lead&id={1}", this._dynamics365CrawlJobData.Url, input.LeadId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FullName;

            //if (input.RelatedObjectId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.RelatedObjectId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            if (input.ParentContactId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.ParentContactId);

            //if (input.CustomerId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.CustomerId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            if (input.CampaignId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Campaign, EntityEdgeType.Parent, input, input.CampaignId);

            if (input.MasterId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.Parent, input, input.MasterId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.ParentAccountId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.ParentAccountId);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.CustomerId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            //if (input.OriginatingCaseId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.OriginatingCaseId);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.QualifyingOpportunityId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Opportunity, EntityEdgeType.Parent, input, input.QualifyingOpportunityId);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            var vocab = new LeadVocabulary();

            data.Properties[vocab.LeadId] = input.LeadId.PrintIfAvailable();
            data.Properties[vocab.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[vocab.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[vocab.LeadSourceCode] = input.LeadSourceCode.PrintIfAvailable();
            data.Properties[vocab.LeadQualityCode] = input.LeadQualityCode.PrintIfAvailable();
            data.Properties[vocab.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[vocab.IndustryCode] = input.IndustryCode.PrintIfAvailable();
            data.Properties[vocab.PreferredContactMethodCode] = input.PreferredContactMethodCode.PrintIfAvailable();
            data.Properties[vocab.SalesStageCode] = input.SalesStageCode.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.EstimatedValue] = input.EstimatedValue.PrintIfAvailable();
            data.Properties[vocab.EstimatedCloseDate] = input.EstimatedCloseDate.PrintIfAvailable();
            data.Properties[vocab.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[vocab.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[vocab.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[vocab.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[vocab.Revenue] = input.Revenue.PrintIfAvailable();
            data.Properties[vocab.NumberOfEmployees] = input.NumberOfEmployees.PrintIfAvailable();
            data.Properties[vocab.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[vocab.SIC] = input.SIC.PrintIfAvailable();
            data.Properties[vocab.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[vocab.EMailAddress1] = input.EMailAddress1.PrintIfAvailable();
            data.Properties[vocab.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[vocab.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[vocab.DoNotEMail] = input.DoNotEMail.PrintIfAvailable();
            data.Properties[vocab.EMailAddress2] = input.EMailAddress2.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[vocab.EMailAddress3] = input.EMailAddress3.PrintIfAvailable();
            data.Properties[vocab.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[vocab.YomiFirstName] = input.YomiFirstName.PrintIfAvailable();
            data.Properties[vocab.WebSiteUrl] = input.WebSiteUrl.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.YomiMiddleName] = input.YomiMiddleName.PrintIfAvailable();
            data.Properties[vocab.YomiLastName] = input.YomiLastName.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.YomiFullName] = input.YomiFullName.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.Pager] = input.Pager.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[vocab.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[vocab.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[vocab.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[vocab.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[vocab.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[vocab.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[vocab.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[vocab.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[vocab.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[vocab.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[vocab.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[vocab.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[vocab.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[vocab.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[vocab.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[vocab.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[vocab.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[vocab.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[vocab.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[vocab.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[vocab.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[vocab.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[vocab.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[vocab.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[vocab.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[vocab.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[vocab.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[vocab.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[vocab.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[vocab.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[vocab.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[vocab.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[vocab.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[vocab.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[vocab.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[vocab.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[vocab.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[vocab.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[vocab.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[vocab.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[vocab.DoNotEMailName] = input.DoNotEMailName.PrintIfAvailable();
            data.Properties[vocab.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.LeadSourceCodeName] = input.LeadSourceCodeName.PrintIfAvailable();
            data.Properties[vocab.SalesStageCodeName] = input.SalesStageCodeName.PrintIfAvailable();
            data.Properties[vocab.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.LeadQualityCodeName] = input.LeadQualityCodeName.PrintIfAvailable();
            data.Properties[vocab.IndustryCodeName] = input.IndustryCodeName.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredContactMethodCodeName] = input.PreferredContactMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[vocab.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[vocab.DoNotSendMM] = input.DoNotSendMM.PrintIfAvailable();
            data.Properties[vocab.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkEMail] = input.DoNotBulkEMail.PrintIfAvailable();
            data.Properties[vocab.LastUsedInCampaign] = input.LastUsedInCampaign.PrintIfAvailable();
            data.Properties[vocab.CampaignIdName] = input.CampaignIdName.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkEMailName] = input.DoNotBulkEMailName.PrintIfAvailable();
            data.Properties[vocab.MasterLeadIdName] = input.MasterLeadIdName.PrintIfAvailable();
            data.Properties[vocab.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[vocab.DoNotSendMarketingMaterialName] = input.DoNotSendMarketingMaterialName.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.EstimatedAmount] = input.EstimatedAmount.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.EstimatedAmount_Base] = input.EstimatedAmount_Base.PrintIfAvailable();
            data.Properties[vocab.Revenue_Base] = input.Revenue_Base.PrintIfAvailable();
            data.Properties[vocab.YomiCompanyName] = input.YomiCompanyName.PrintIfAvailable();
            data.Properties[vocab.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.MasterLeadIdYomiName] = input.MasterLeadIdYomiName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.IsAutoCreate] = input.IsAutoCreate.PrintIfAvailable();
            data.Properties[vocab.ParentAccountId] = input.ParentAccountId.PrintIfAvailable();
            data.Properties[vocab.ParentContactId] = input.ParentContactId.PrintIfAvailable();
            data.Properties[vocab.ParentAccountIdName] = input.ParentAccountIdName.PrintIfAvailable();
            data.Properties[vocab.ParentAccountIdYomiName] = input.ParentAccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ParentContactIdName] = input.ParentContactIdName.PrintIfAvailable();
            data.Properties[vocab.ParentContactIdYomiName] = input.ParentContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.RelatedObjectId] = input.RelatedObjectId.PrintIfAvailable();
            data.Properties[vocab.BudgetAmount] = input.BudgetAmount.PrintIfAvailable();
            data.Properties[vocab.BudgetAmount_Base] = input.BudgetAmount_Base.PrintIfAvailable();
            data.Properties[vocab.BudgetStatus] = input.BudgetStatus.PrintIfAvailable();
            data.Properties[vocab.BudgetStatusName] = input.BudgetStatusName.PrintIfAvailable();
            data.Properties[vocab.DecisionMaker] = input.DecisionMaker.PrintIfAvailable();
            data.Properties[vocab.DecisionMakerName] = input.DecisionMakerName.PrintIfAvailable();
            data.Properties[vocab.Need] = input.Need.PrintIfAvailable();
            data.Properties[vocab.NeedName] = input.NeedName.PrintIfAvailable();
            data.Properties[vocab.PurchaseTimeFrame] = input.PurchaseTimeFrame.PrintIfAvailable();
            data.Properties[vocab.PurchaseTimeFrameName] = input.PurchaseTimeFrameName.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.EvaluateFit] = input.EvaluateFit.PrintIfAvailable();
            data.Properties[vocab.EvaluateFitName] = input.EvaluateFitName.PrintIfAvailable();
            data.Properties[vocab.InitialCommunication] = input.InitialCommunication.PrintIfAvailable();
            data.Properties[vocab.InitialCommunicationName] = input.InitialCommunicationName.PrintIfAvailable();
            data.Properties[vocab.ConfirmInterest] = input.ConfirmInterest.PrintIfAvailable();
            data.Properties[vocab.ConfirmInterestName] = input.ConfirmInterestName.PrintIfAvailable();
            data.Properties[vocab.PurchaseProcess] = input.PurchaseProcess.PrintIfAvailable();
            data.Properties[vocab.PurchaseProcessName] = input.PurchaseProcessName.PrintIfAvailable();
            data.Properties[vocab.SalesStage] = input.SalesStage.PrintIfAvailable();
            data.Properties[vocab.SalesStageName] = input.SalesStageName.PrintIfAvailable();
            data.Properties[vocab.ScheduleFollowUp_Prospect] = input.ScheduleFollowUp_Prospect.PrintIfAvailable();
            data.Properties[vocab.ScheduleFollowUp_Qualify] = input.ScheduleFollowUp_Qualify.PrintIfAvailable();
            data.Properties[vocab.QualificationComments] = input.QualificationComments.PrintIfAvailable();
            data.Properties[vocab.QualifyingOpportunityId] = input.QualifyingOpportunityId.PrintIfAvailable();
            data.Properties[vocab.QualifyingOpportunityIdName] = input.QualifyingOpportunityIdName.PrintIfAvailable();
            data.Properties[vocab.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[vocab.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[vocab.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[vocab.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[vocab.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[vocab.OriginatingCaseId] = input.OriginatingCaseId.PrintIfAvailable();
            data.Properties[vocab.OriginatingCaseIdName] = input.OriginatingCaseIdName.PrintIfAvailable();
            data.Properties[vocab.RelatedObjectIdName] = input.RelatedObjectIdName.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.FollowEmail] = input.FollowEmail.PrintIfAvailable();
            data.Properties[vocab.FollowEmailName] = input.FollowEmailName.PrintIfAvailable();
            data.Properties[vocab.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[vocab.isautocreateName] = input.isautocreateName.PrintIfAvailable();
            data.Properties[vocab.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();
            data.Properties[vocab.BusinessCard] = input.BusinessCard.PrintIfAvailable();
            data.Properties[vocab.BusinessCardAttributes] = input.BusinessCardAttributes.PrintIfAvailable();

            // Add custom fields
            foreach (var key in input.Custom.Keys)
            {
                var customVocab = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                data.Properties[customVocab] = input.Custom[key].PrintIfAvailable();
            }

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

