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
    public abstract class AccountClueProducer<T> : DynamicsClueProducer<T> where T : Account
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AccountClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            _factory = factory;

            _dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = _factory.Create(EntityType.Organization, input.AccountId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=account&id={1}", _dynamics365CrawlJobData.Url, input.AccountId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.DefaultPriceLevelId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.DefaultPriceLevelId);

            if (input.ModifiedByExternalParty != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedByExternalParty);

            if (input.CreatedByExternalParty != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedByExternalParty);

            if (input.OwningTeam != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.OwnedBy, input, input.OwningTeam);

            //if (input.PreferredEquipmentId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.PreferredEquipmentId);

            //if (input.PrimaryContactId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.PrimaryContactId);

            //if (input.SLAId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.SLAInvokedId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            if (input.OriginatingLeadId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.StartedOn, input, input.OriginatingLeadId);

            if (input.StageId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.ParentAccountId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.ParentAccountId);

            if (input.MasterId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.MasterId);

            if (input.OwningBusinessUnit != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.OwningUser != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.ModifiedBy != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedBy != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            //if (input.PreferredSystemUserId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType., input, input.PreferredSystemUserId);

            if (input.ModifiedOnBehalfBy != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.CreatedOnBehalfBy != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.OwnerId != null)
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.PreferredServiceId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.PreferredServiceId);

            //if (input.EntityImageId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            //if (input.TerritoryId != null)
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.TerritoryId);

            var vocab = new AccountVocabulary();

            data.Properties[vocab.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[vocab.AccountCategoryCode] = input.AccountCategoryCode.PrintIfAvailable();
            data.Properties[vocab.TerritoryId] = input.TerritoryId.PrintIfAvailable();
            data.Properties[vocab.DefaultPriceLevelId] = input.DefaultPriceLevelId.PrintIfAvailable();
            data.Properties[vocab.CustomerSizeCode] = input.CustomerSizeCode.PrintIfAvailable();
            data.Properties[vocab.PreferredContactMethodCode] = input.PreferredContactMethodCode.PrintIfAvailable();
            data.Properties[vocab.CustomerTypeCode] = input.CustomerTypeCode.PrintIfAvailable();
            data.Properties[vocab.AccountRatingCode] = input.AccountRatingCode.PrintIfAvailable();
            data.Properties[vocab.IndustryCode] = input.IndustryCode.PrintIfAvailable();
            data.Properties[vocab.TerritoryCode] = input.TerritoryCode.PrintIfAvailable();
            data.Properties[vocab.AccountClassificationCode] = input.AccountClassificationCode.PrintIfAvailable();
            data.Properties[vocab.BusinessTypeCode] = input.BusinessTypeCode.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadId] = input.OriginatingLeadId.PrintIfAvailable();
            data.Properties[vocab.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[vocab.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[vocab.PrimaryContactId] = input.PrimaryContactId.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.AccountNumber] = input.AccountNumber.PrintIfAvailable();
            data.Properties[vocab.Revenue] = input.Revenue.PrintIfAvailable();
            data.Properties[vocab.NumberOfEmployees] = input.NumberOfEmployees.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.SIC] = input.SIC.PrintIfAvailable();
            data.Properties[vocab.OwnershipCode] = input.OwnershipCode.PrintIfAvailable();
            data.Properties[vocab.MarketCap] = input.MarketCap.PrintIfAvailable();
            data.Properties[vocab.SharesOutstanding] = input.SharesOutstanding.PrintIfAvailable();
            data.Properties[vocab.TickerSymbol] = input.TickerSymbol.PrintIfAvailable();
            data.Properties[vocab.StockExchange] = input.StockExchange.PrintIfAvailable();
            data.Properties[vocab.WebSiteURL] = input.WebSiteURL.PrintIfAvailable();
            data.Properties[vocab.FtpSiteURL] = input.FtpSiteURL.PrintIfAvailable();
            data.Properties[vocab.EMailAddress1] = input.EMailAddress1.PrintIfAvailable();
            data.Properties[vocab.EMailAddress2] = input.EMailAddress2.PrintIfAvailable();
            data.Properties[vocab.EMailAddress3] = input.EMailAddress3.PrintIfAvailable();
            data.Properties[vocab.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[vocab.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.DoNotEMail] = input.DoNotEMail.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkEMail] = input.DoNotBulkEMail.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkPostalMail] = input.DoNotBulkPostalMail.PrintIfAvailable();
            data.Properties[vocab.CreditLimit] = input.CreditLimit.PrintIfAvailable();
            data.Properties[vocab.CreditOnHold] = input.CreditOnHold.PrintIfAvailable();
            data.Properties[vocab.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.ParentAccountId] = input.ParentAccountId.PrintIfAvailable();
            data.Properties[vocab.Aging30] = input.Aging30.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.Aging60] = input.Aging60.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.Aging90] = input.Aging90.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadIdName] = input.OriginatingLeadIdName.PrintIfAvailable();
            data.Properties[vocab.PrimaryContactIdName] = input.PrimaryContactIdName.PrintIfAvailable();
            data.Properties[vocab.ParentAccountIdName] = input.ParentAccountIdName.PrintIfAvailable();
            data.Properties[vocab.DefaultPriceLevelIdName] = input.DefaultPriceLevelIdName.PrintIfAvailable();
            data.Properties[vocab.TerritoryIdName] = input.TerritoryIdName.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[vocab.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[vocab.Address1_PrimaryContactName] = input.Address1_PrimaryContactName.PrintIfAvailable();
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
            data.Properties[vocab.Address1_FreightTermsCode] = input.Address1_FreightTermsCode.PrintIfAvailable();
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
            data.Properties[vocab.Address2_PrimaryContactName] = input.Address2_PrimaryContactName.PrintIfAvailable();
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
            data.Properties[vocab.Address2_FreightTermsCode] = input.Address2_FreightTermsCode.PrintIfAvailable();
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
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[vocab.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[vocab.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkPostalMailName] = input.DoNotBulkPostalMailName.PrintIfAvailable();
            data.Properties[vocab.CreditOnHoldName] = input.CreditOnHoldName.PrintIfAvailable();
            data.Properties[vocab.DoNotEMailName] = input.DoNotEMailName.PrintIfAvailable();
            data.Properties[vocab.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkEMailName] = input.DoNotBulkEMailName.PrintIfAvailable();
            data.Properties[vocab.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.IndustryCodeName] = input.IndustryCodeName.PrintIfAvailable();
            data.Properties[vocab.AccountRatingCodeName] = input.AccountRatingCodeName.PrintIfAvailable();
            data.Properties[vocab.OwnershipCodeName] = input.OwnershipCodeName.PrintIfAvailable();
            data.Properties[vocab.AccountClassificationCodeName] = input.AccountClassificationCodeName.PrintIfAvailable();
            data.Properties[vocab.CustomerSizeCodeName] = input.CustomerSizeCodeName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.Address1_FreightTermsCodeName] = input.Address1_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.BusinessTypeCodeName] = input.BusinessTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_FreightTermsCodeName] = input.Address2_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.AccountCategoryCodeName] = input.AccountCategoryCodeName.PrintIfAvailable();
            data.Properties[vocab.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredContactMethodCodeName] = input.PreferredContactMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.TerritoryCodeName] = input.TerritoryCodeName.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.CustomerTypeCodeName] = input.CustomerTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentDayCode] = input.PreferredAppointmentDayCode.PrintIfAvailable();
            data.Properties[vocab.PreferredSystemUserId] = input.PreferredSystemUserId.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentTimeCode] = input.PreferredAppointmentTimeCode.PrintIfAvailable();
            data.Properties[vocab.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[vocab.DoNotSendMM] = input.DoNotSendMM.PrintIfAvailable();
            data.Properties[vocab.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[vocab.LastUsedInCampaign] = input.LastUsedInCampaign.PrintIfAvailable();
            data.Properties[vocab.PreferredServiceId] = input.PreferredServiceId.PrintIfAvailable();
            data.Properties[vocab.PreferredEquipmentId] = input.PreferredEquipmentId.PrintIfAvailable();
            data.Properties[vocab.PreferredEquipmentIdName] = input.PreferredEquipmentIdName.PrintIfAvailable();
            data.Properties[vocab.PreferredServiceIdName] = input.PreferredServiceIdName.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentTimeCodeName] = input.PreferredAppointmentTimeCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentDayCodeName] = input.PreferredAppointmentDayCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredSystemUserIdName] = input.PreferredSystemUserIdName.PrintIfAvailable();
            data.Properties[vocab.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[vocab.MasterAccountIdName] = input.MasterAccountIdName.PrintIfAvailable();
            data.Properties[vocab.DoNotSendMarketingMaterialName] = input.DoNotSendMarketingMaterialName.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.CreditLimit_Base] = input.CreditLimit_Base.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.Aging30_Base] = input.Aging30_Base.PrintIfAvailable();
            data.Properties[vocab.Revenue_Base] = input.Revenue_Base.PrintIfAvailable();
            data.Properties[vocab.Aging90_Base] = input.Aging90_Base.PrintIfAvailable();
            data.Properties[vocab.MarketCap_Base] = input.MarketCap_Base.PrintIfAvailable();
            data.Properties[vocab.Aging60_Base] = input.Aging60_Base.PrintIfAvailable();
            data.Properties[vocab.PreferredSystemUserIdYomiName] = input.PreferredSystemUserIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ParentAccountIdYomiName] = input.ParentAccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName.PrintIfAvailable();
            data.Properties[vocab.MasterAccountIdYomiName] = input.MasterAccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.PrimaryContactIdYomiName] = input.PrimaryContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.YomiName] = input.YomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[vocab.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[vocab.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[vocab.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[vocab.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[vocab.OpenDeals] = input.OpenDeals.PrintIfAvailable();
            data.Properties[vocab.OpenDeals_Date] = input.OpenDeals_Date.PrintIfAvailable();
            data.Properties[vocab.OpenDeals_State] = input.OpenDeals_State.PrintIfAvailable();
            data.Properties[vocab.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[vocab.OpenRevenue] = input.OpenRevenue.PrintIfAvailable();
            data.Properties[vocab.OpenRevenue_Base] = input.OpenRevenue_Base.PrintIfAvailable();
            data.Properties[vocab.OpenRevenue_Date] = input.OpenRevenue_Date.PrintIfAvailable();
            data.Properties[vocab.OpenRevenue_State] = input.OpenRevenue_State.PrintIfAvailable();
            data.Properties[vocab.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[vocab.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[vocab.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[vocab.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[vocab.PrimarySatoriId] = input.PrimarySatoriId.PrintIfAvailable();
            data.Properties[vocab.PrimaryTwitterId] = input.PrimaryTwitterId.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.FollowEmail] = input.FollowEmail.PrintIfAvailable();
            data.Properties[vocab.FollowEmailName] = input.FollowEmailName.PrintIfAvailable();
            data.Properties[vocab.MarketingOnly] = input.MarketingOnly.PrintIfAvailable();
            data.Properties[vocab.MarketingOnlyName] = input.MarketingOnlyName.PrintIfAvailable();
            data.Properties[vocab.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();

            // Add custom fields
            foreach (var key in input.Custom.Keys)
            {
                var customVocab = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                data.Properties[customVocab] = input.Custom[key].PrintIfAvailable();
            }

            Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

