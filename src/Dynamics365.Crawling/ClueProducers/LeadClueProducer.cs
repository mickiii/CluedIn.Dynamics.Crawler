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
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public LeadClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Sales.Lead, input.LeadId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=lead&id={1}", this._dynamics365CrawlJobData.Api, input.LeadId.ToString()), UriKind.Absolute, out Uri uri))
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

            data.Properties[Dynamics365Vocabulary.Lead.LeadId] = input.LeadId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LeadSourceCode] = input.LeadSourceCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LeadQualityCode] = input.LeadQualityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.IndustryCode] = input.IndustryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PreferredContactMethodCode] = input.PreferredContactMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SalesStageCode] = input.SalesStageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EstimatedValue] = input.EstimatedValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EstimatedCloseDate] = input.EstimatedCloseDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Revenue] = input.Revenue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.NumberOfEmployees] = input.NumberOfEmployees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SIC] = input.SIC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EMailAddress1] = input.EMailAddress1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotEMail] = input.DoNotEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EMailAddress2] = input.EMailAddress2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EMailAddress3] = input.EMailAddress3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.YomiFirstName] = input.YomiFirstName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.WebSiteUrl] = input.WebSiteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.YomiMiddleName] = input.YomiMiddleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.YomiLastName] = input.YomiLastName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.YomiFullName] = input.YomiFullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Pager] = input.Pager.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotEMailName] = input.DoNotEMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LeadSourceCodeName] = input.LeadSourceCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SalesStageCodeName] = input.SalesStageCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LeadQualityCodeName] = input.LeadQualityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.IndustryCodeName] = input.IndustryCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PreferredContactMethodCodeName] = input.PreferredContactMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotSendMM] = input.DoNotSendMM.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotBulkEMail] = input.DoNotBulkEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LastUsedInCampaign] = input.LastUsedInCampaign.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CampaignIdName] = input.CampaignIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotBulkEMailName] = input.DoNotBulkEMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.MasterLeadIdName] = input.MasterLeadIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DoNotSendMarketingMaterialName] = input.DoNotSendMarketingMaterialName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EstimatedAmount] = input.EstimatedAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EstimatedAmount_Base] = input.EstimatedAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Revenue_Base] = input.Revenue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.YomiCompanyName] = input.YomiCompanyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.MasterLeadIdYomiName] = input.MasterLeadIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.IsAutoCreate] = input.IsAutoCreate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParentAccountId] = input.ParentAccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParentContactId] = input.ParentContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParentAccountIdName] = input.ParentAccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParentAccountIdYomiName] = input.ParentAccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParentContactIdName] = input.ParentContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ParentContactIdYomiName] = input.ParentContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.RelatedObjectId] = input.RelatedObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.BudgetAmount] = input.BudgetAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.BudgetAmount_Base] = input.BudgetAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.BudgetStatus] = input.BudgetStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.BudgetStatusName] = input.BudgetStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DecisionMaker] = input.DecisionMaker.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.DecisionMakerName] = input.DecisionMakerName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Need] = input.Need.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.NeedName] = input.NeedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PurchaseTimeFrame] = input.PurchaseTimeFrame.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PurchaseTimeFrameName] = input.PurchaseTimeFrameName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EvaluateFit] = input.EvaluateFit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EvaluateFitName] = input.EvaluateFitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.InitialCommunication] = input.InitialCommunication.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.InitialCommunicationName] = input.InitialCommunicationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ConfirmInterest] = input.ConfirmInterest.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ConfirmInterestName] = input.ConfirmInterestName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PurchaseProcess] = input.PurchaseProcess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.PurchaseProcessName] = input.PurchaseProcessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SalesStage] = input.SalesStage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SalesStageName] = input.SalesStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ScheduleFollowUp_Prospect] = input.ScheduleFollowUp_Prospect.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ScheduleFollowUp_Qualify] = input.ScheduleFollowUp_Qualify.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.QualificationComments] = input.QualificationComments.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.QualifyingOpportunityId] = input.QualifyingOpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.QualifyingOpportunityIdName] = input.QualifyingOpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OriginatingCaseId] = input.OriginatingCaseId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OriginatingCaseIdName] = input.OriginatingCaseIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.RelatedObjectIdName] = input.RelatedObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.FollowEmail] = input.FollowEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.FollowEmailName] = input.FollowEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.isautocreateName] = input.isautocreateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.BusinessCard] = input.BusinessCard.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Lead.BusinessCardAttributes] = input.BusinessCardAttributes.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

