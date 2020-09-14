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
    public abstract class IncidentClueProducer<T> : DynamicsClueProducer<T> where T : Incident
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public IncidentClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.IncidentId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=incident&id={1}", _dynamics365CrawlJobData.Api, input.IncidentId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.CreatedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.CreatedByExternalParty);

                         if (input.ModifiedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.ModifiedByExternalParty);

                         if (input.KbArticleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.KbArticleId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.ResponsibleContactId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.ResponsibleContactId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.PrimaryContactId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.PrimaryContactId);

                         if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.SLAInvokedId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

                         if (input.SubjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subject, EntityEdgeType.Parent, input, input.SubjectId);

                         if (input.StageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.StageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.IncidentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.childincidentcount, EntityEdgeType.Parent, input, input.IncidentId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ExistingCase != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.ExistingCase);

                         if (input.ParentCaseId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.ParentCaseId);

                         if (input.MasterId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.MasterId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ContractDetailId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contractdetail, EntityEdgeType.Parent, input, input.ContractDetailId);

                         if (input.SocialProfileId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.SocialProfileId);

                         if (input.FirstResponseByKPIId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.slakpiinstance, EntityEdgeType.Parent, input, input.FirstResponseByKPIId);

                         if (input.ResolveByKPIId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.slakpiinstance, EntityEdgeType.Parent, input, input.ResolveByKPIId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.ContractId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.ContractId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.EntitlementId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.EntitlementId);


            */
            data.Properties[Dynamics365Vocabulary.Incident.IncidentId] = input.IncidentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContractDetailId] = input.ContractDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SubjectId] = input.SubjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContractId] = input.ContractId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ActualServiceUnits] = input.ActualServiceUnits.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CaseOriginCode] = input.CaseOriginCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.BilledServiceUnits] = input.BilledServiceUnits.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CaseTypeCode] = input.CaseTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ProductSerialNumber] = input.ProductSerialNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContractServiceLevelCode] = input.ContractServiceLevelCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.IsDecrementing] = input.IsDecrementing.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.TicketNumber] = input.TicketNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerSatisfactionCode] = input.CustomerSatisfactionCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.IncidentStageCode] = input.IncidentStageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FollowupBy] = input.FollowupBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SeverityCode] = input.SeverityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResponsibleContactId] = input.ResponsibleContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SubjectIdName] = input.SubjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResponsibleContactIdName] = input.ResponsibleContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContractIdName] = input.ContractIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContractDetailIdName] = input.ContractDetailIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.IsDecrementingName] = input.IsDecrementingName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CaseOriginCodeName] = input.CaseOriginCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.IncidentStageCodeName] = input.IncidentStageCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SeverityCodeName] = input.SeverityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CaseTypeCodeName] = input.CaseTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerSatisfactionCodeName] = input.CustomerSatisfactionCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContractServiceLevelCodeName] = input.ContractServiceLevelCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.KbArticleId] = input.KbArticleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.KbArticleIdName] = input.KbArticleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResponsibleContactIdYomiName] = input.ResponsibleContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ServiceStage] = input.ServiceStage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ServiceStageName] = input.ServiceStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ExistingCase] = input.ExistingCase.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CheckEmail] = input.CheckEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ActivitiesComplete] = input.ActivitiesComplete.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ActivitiesCompleteName] = input.ActivitiesCompleteName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CheckEmailName] = input.CheckEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FollowUpTaskCreated] = input.FollowUpTaskCreated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FollowUpTaskCreatedName] = input.FollowUpTaskCreatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.NumberOfChildIncidents] = input.NumberOfChildIncidents.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SocialProfileId] = input.SocialProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.MessageTypeCode] = input.MessageTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.BlockedProfile] = input.BlockedProfile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.DecrementEntitlementTermName] = input.DecrementEntitlementTermName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EntitlementId] = input.EntitlementId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EntitlementIdName] = input.EntitlementIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.MasterIdName] = input.MasterIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ParentCaseId] = input.ParentCaseId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.DecrementEntitlementTerm] = input.DecrementEntitlementTerm.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ParentCaseIdName] = input.ParentCaseIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SentimentValue] = input.SentimentValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.SocialProfileIdName] = input.SocialProfileIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.InfluenceScore] = input.InfluenceScore.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.MessageTypeCodeName] = input.MessageTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.BlockedProfileName] = input.BlockedProfileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.RouteCase] = input.RouteCase.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResolveBy] = input.ResolveBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResponseBy] = input.ResponseBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.CustomerContacted] = input.CustomerContacted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.IsEscalated] = input.IsEscalated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EscalatedOn] = input.EscalatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.PrimaryContactId] = input.PrimaryContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.PrimaryContactIdName] = input.PrimaryContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.PrimaryContactIdYomiName] = input.PrimaryContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.IsEscalatedName] = input.IsEscalatedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FirstResponseSent] = input.FirstResponseSent.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FirstResponseSLAStatus] = input.FirstResponseSLAStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResolveBySLAStatus] = input.ResolveBySLAStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FirstResponseSLAStatusName] = input.FirstResponseSLAStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResolveBySLAStatusName] = input.ResolveBySLAStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FirstResponseSentName] = input.FirstResponseSentName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResolveByKPIId] = input.ResolveByKPIId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.ResolveByKPIIdName] = input.ResolveByKPIIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FirstResponseByKPIId] = input.FirstResponseByKPIId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.FirstResponseByKPIIdName] = input.FirstResponseByKPIIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.routecaseName] = input.routecaseName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Incident.customercontactedName] = input.customercontactedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

