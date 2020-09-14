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

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Organization, input.AccountId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=account&id={1}", this._dynamics365CrawlJobData.Api, input.AccountId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.DefaultPriceLevelId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.DefaultPriceLevelId);

            if (input.ModifiedByExternalParty != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedByExternalParty);

            if (input.CreatedByExternalParty != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedByExternalParty);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.OwnedBy, input, input.OwningTeam);

            //if (input.PreferredEquipmentId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.PreferredEquipmentId);

            //if (input.PrimaryContactId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.PrimaryContactId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            if (input.OriginatingLeadId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.StartedOn, input, input.OriginatingLeadId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.ParentAccountId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.ParentAccountId);

            if (input.MasterId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.MasterId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            //if (input.PreferredSystemUserId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType., input, input.PreferredSystemUserId);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.PreferredServiceId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.PreferredServiceId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            //if (input.TerritoryId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.TerritoryId);

            data.Properties[Dynamics365Vocabulary.Account.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountCategoryCode] = input.AccountCategoryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TerritoryId] = input.TerritoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DefaultPriceLevelId] = input.DefaultPriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CustomerSizeCode] = input.CustomerSizeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredContactMethodCode] = input.PreferredContactMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CustomerTypeCode] = input.CustomerTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountRatingCode] = input.AccountRatingCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.IndustryCode] = input.IndustryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TerritoryCode] = input.TerritoryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountClassificationCode] = input.AccountClassificationCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.BusinessTypeCode] = input.BusinessTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OriginatingLeadId] = input.OriginatingLeadId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PrimaryContactId] = input.PrimaryContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountNumber] = input.AccountNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Revenue] = input.Revenue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.NumberOfEmployees] = input.NumberOfEmployees.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.SIC] = input.SIC.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwnershipCode] = input.OwnershipCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MarketCap] = input.MarketCap.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.SharesOutstanding] = input.SharesOutstanding.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TickerSymbol] = input.TickerSymbol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.StockExchange] = input.StockExchange.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.WebSiteURL] = input.WebSiteURL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.FtpSiteURL] = input.FtpSiteURL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EMailAddress1] = input.EMailAddress1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EMailAddress2] = input.EMailAddress2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EMailAddress3] = input.EMailAddress3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotEMail] = input.DoNotEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotBulkEMail] = input.DoNotBulkEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotBulkPostalMail] = input.DoNotBulkPostalMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreditLimit] = input.CreditLimit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreditOnHold] = input.CreditOnHold.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ParentAccountId] = input.ParentAccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Aging30] = input.Aging30.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Aging60] = input.Aging60.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Aging90] = input.Aging90.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OriginatingLeadIdName] = input.OriginatingLeadIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PrimaryContactIdName] = input.PrimaryContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ParentAccountIdName] = input.ParentAccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DefaultPriceLevelIdName] = input.DefaultPriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TerritoryIdName] = input.TerritoryIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_PrimaryContactName] = input.Address1_PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_FreightTermsCode] = input.Address1_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_PrimaryContactName] = input.Address2_PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_FreightTermsCode] = input.Address2_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotBulkPostalMailName] = input.DoNotBulkPostalMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreditOnHoldName] = input.CreditOnHoldName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotEMailName] = input.DoNotEMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotBulkEMailName] = input.DoNotBulkEMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.IndustryCodeName] = input.IndustryCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountRatingCodeName] = input.AccountRatingCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwnershipCodeName] = input.OwnershipCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountClassificationCodeName] = input.AccountClassificationCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CustomerSizeCodeName] = input.CustomerSizeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_FreightTermsCodeName] = input.Address1_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.BusinessTypeCodeName] = input.BusinessTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_FreightTermsCodeName] = input.Address2_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.AccountCategoryCodeName] = input.AccountCategoryCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredContactMethodCodeName] = input.PreferredContactMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TerritoryCodeName] = input.TerritoryCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CustomerTypeCodeName] = input.CustomerTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredAppointmentDayCode] = input.PreferredAppointmentDayCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredSystemUserId] = input.PreferredSystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredAppointmentTimeCode] = input.PreferredAppointmentTimeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotSendMM] = input.DoNotSendMM.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.LastUsedInCampaign] = input.LastUsedInCampaign.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredServiceId] = input.PreferredServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredEquipmentId] = input.PreferredEquipmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredEquipmentIdName] = input.PreferredEquipmentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredServiceIdName] = input.PreferredServiceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredAppointmentTimeCodeName] = input.PreferredAppointmentTimeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredAppointmentDayCodeName] = input.PreferredAppointmentDayCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredSystemUserIdName] = input.PreferredSystemUserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MasterAccountIdName] = input.MasterAccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.DoNotSendMarketingMaterialName] = input.DoNotSendMarketingMaterialName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreditLimit_Base] = input.CreditLimit_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Aging30_Base] = input.Aging30_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Revenue_Base] = input.Revenue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Aging90_Base] = input.Aging90_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MarketCap_Base] = input.MarketCap_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Aging60_Base] = input.Aging60_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PreferredSystemUserIdYomiName] = input.PreferredSystemUserIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ParentAccountIdYomiName] = input.ParentAccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MasterAccountIdYomiName] = input.MasterAccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PrimaryContactIdYomiName] = input.PrimaryContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.YomiName] = input.YomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenDeals] = input.OpenDeals.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenDeals_Date] = input.OpenDeals_Date.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenDeals_State] = input.OpenDeals_State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenRevenue] = input.OpenRevenue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenRevenue_Base] = input.OpenRevenue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenRevenue_Date] = input.OpenRevenue_Date.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OpenRevenue_State] = input.OpenRevenue_State.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PrimarySatoriId] = input.PrimarySatoriId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.PrimaryTwitterId] = input.PrimaryTwitterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.FollowEmail] = input.FollowEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.FollowEmailName] = input.FollowEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MarketingOnly] = input.MarketingOnly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.MarketingOnlyName] = input.MarketingOnlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Account.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

