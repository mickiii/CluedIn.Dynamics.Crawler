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
    public abstract class ContactClueProducer<T> : DynamicsClueProducer<T> where T : Contact
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ContactClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Infrastructure.User, input.ContactId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=contact&id={1}", this._dynamics365CrawlJobData.Url, input.ContactId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FullName;

            //if (input.DefaultPriceLevelId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.DefaultPriceLevelId);

            if (input.CreatedByExternalParty != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedByExternalParty);

            if (input.ModifiedByExternalParty != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedByExternalParty);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            //if (input.PreferredEquipmentId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.PreferredEquipmentId);

            if (input.MasterId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.MasterId);

            if (input.ParentCustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.ParentCustomerId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            if (input.OriginatingLeadId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.Parent, input, input.OriginatingLeadId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.ParentCustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.ParentCustomerId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.PreferredSystemUserId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.PreferredSystemUserId);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.PreferredServiceId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.PreferredServiceId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            var vocab = new ContactVocabulary();

            data.Properties[vocab.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[vocab.DefaultPriceLevelId] = input.DefaultPriceLevelId.PrintIfAvailable();
            data.Properties[vocab.CustomerSizeCode] = input.CustomerSizeCode.PrintIfAvailable();
            data.Properties[vocab.CustomerTypeCode] = input.CustomerTypeCode.PrintIfAvailable();
            data.Properties[vocab.PreferredContactMethodCode] = input.PreferredContactMethodCode.PrintIfAvailable();
            data.Properties[vocab.LeadSourceCode] = input.LeadSourceCode.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadId] = input.OriginatingLeadId.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[vocab.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[vocab.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[vocab.IsBackofficeCustomer] = input.IsBackofficeCustomer.PrintIfAvailable();
            data.Properties[vocab.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[vocab.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[vocab.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[vocab.Department] = input.Department.PrintIfAvailable();
            data.Properties[vocab.NickName] = input.NickName.PrintIfAvailable();
            data.Properties[vocab.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[vocab.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[vocab.Suffix] = input.Suffix.PrintIfAvailable();
            data.Properties[vocab.YomiFirstName] = input.YomiFirstName.PrintIfAvailable();
            data.Properties[vocab.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[vocab.YomiMiddleName] = input.YomiMiddleName.PrintIfAvailable();
            data.Properties[vocab.YomiLastName] = input.YomiLastName.PrintIfAvailable();
            data.Properties[vocab.Anniversary] = input.Anniversary.PrintIfAvailable();
            data.Properties[vocab.BirthDate] = input.BirthDate.PrintIfAvailable();
            data.Properties[vocab.GovernmentId] = input.GovernmentId.PrintIfAvailable();
            data.Properties[vocab.YomiFullName] = input.YomiFullName.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[vocab.GenderCode] = input.GenderCode.PrintIfAvailable();
            data.Properties[vocab.AnnualIncome] = input.AnnualIncome.PrintIfAvailable();
            data.Properties[vocab.HasChildrenCode] = input.HasChildrenCode.PrintIfAvailable();
            data.Properties[vocab.EducationCode] = input.EducationCode.PrintIfAvailable();
            data.Properties[vocab.WebSiteUrl] = input.WebSiteUrl.PrintIfAvailable();
            data.Properties[vocab.FamilyStatusCode] = input.FamilyStatusCode.PrintIfAvailable();
            data.Properties[vocab.FtpSiteUrl] = input.FtpSiteUrl.PrintIfAvailable();
            data.Properties[vocab.EMailAddress1] = input.EMailAddress1.PrintIfAvailable();
            data.Properties[vocab.SpousesName] = input.SpousesName.PrintIfAvailable();
            data.Properties[vocab.AssistantName] = input.AssistantName.PrintIfAvailable();
            data.Properties[vocab.EMailAddress2] = input.EMailAddress2.PrintIfAvailable();
            data.Properties[vocab.AssistantPhone] = input.AssistantPhone.PrintIfAvailable();
            data.Properties[vocab.EMailAddress3] = input.EMailAddress3.PrintIfAvailable();
            data.Properties[vocab.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[vocab.ManagerName] = input.ManagerName.PrintIfAvailable();
            data.Properties[vocab.ManagerPhone] = input.ManagerPhone.PrintIfAvailable();
            data.Properties[vocab.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[vocab.DoNotEMail] = input.DoNotEMail.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkEMail] = input.DoNotBulkEMail.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkPostalMail] = input.DoNotBulkPostalMail.PrintIfAvailable();
            data.Properties[vocab.AccountRoleCode] = input.AccountRoleCode.PrintIfAvailable();
            data.Properties[vocab.TerritoryCode] = input.TerritoryCode.PrintIfAvailable();
            data.Properties[vocab.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[vocab.CreditLimit] = input.CreditLimit.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.CreditOnHold] = input.CreditOnHold.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.NumberOfChildren] = input.NumberOfChildren.PrintIfAvailable();
            data.Properties[vocab.ChildrensNames] = input.ChildrensNames.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            data.Properties[vocab.Pager] = input.Pager.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.Aging30] = input.Aging30.PrintIfAvailable();
            data.Properties[vocab.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[vocab.Aging60] = input.Aging60.PrintIfAvailable();
            data.Properties[vocab.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[vocab.Aging90] = input.Aging90.PrintIfAvailable();
            data.Properties[vocab.ParentContactId] = input.ParentContactId.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadIdName] = input.OriginatingLeadIdName.PrintIfAvailable();
            data.Properties[vocab.ParentContactIdName] = input.ParentContactIdName.PrintIfAvailable();
            data.Properties[vocab.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[vocab.DefaultPriceLevelIdName] = input.DefaultPriceLevelIdName.PrintIfAvailable();
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
            data.Properties[vocab.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[vocab.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[vocab.IsBackofficeCustomerName] = input.IsBackofficeCustomerName.PrintIfAvailable();
            data.Properties[vocab.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[vocab.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[vocab.CreditOnHoldName] = input.CreditOnHoldName.PrintIfAvailable();
            data.Properties[vocab.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[vocab.DoNotEMailName] = input.DoNotEMailName.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkPostalMailName] = input.DoNotBulkPostalMailName.PrintIfAvailable();
            data.Properties[vocab.DoNotBulkEMailName] = input.DoNotBulkEMailName.PrintIfAvailable();
            data.Properties[vocab.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredContactMethodCodeName] = input.PreferredContactMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.CustomerTypeCodeName] = input.CustomerTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[vocab.AccountRoleCodeName] = input.AccountRoleCodeName.PrintIfAvailable();
            data.Properties[vocab.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[vocab.HasChildrenCodeName] = input.HasChildrenCodeName.PrintIfAvailable();
            data.Properties[vocab.TerritoryCodeName] = input.TerritoryCodeName.PrintIfAvailable();
            data.Properties[vocab.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.GenderCodeName] = input.GenderCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_FreightTermsCodeName] = input.Address2_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.FamilyStatusCodeName] = input.FamilyStatusCodeName.PrintIfAvailable();
            data.Properties[vocab.CustomerSizeCodeName] = input.CustomerSizeCodeName.PrintIfAvailable();
            data.Properties[vocab.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.Address1_FreightTermsCodeName] = input.Address1_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.LeadSourceCodeName] = input.LeadSourceCodeName.PrintIfAvailable();
            data.Properties[vocab.EducationCodeName] = input.EducationCodeName.PrintIfAvailable();
            data.Properties[vocab.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredSystemUserId] = input.PreferredSystemUserId.PrintIfAvailable();
            data.Properties[vocab.PreferredServiceId] = input.PreferredServiceId.PrintIfAvailable();
            data.Properties[vocab.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentDayCode] = input.PreferredAppointmentDayCode.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentTimeCode] = input.PreferredAppointmentTimeCode.PrintIfAvailable();
            data.Properties[vocab.DoNotSendMM] = input.DoNotSendMM.PrintIfAvailable();
            data.Properties[vocab.ParentCustomerId] = input.ParentCustomerId.PrintIfAvailable();
            data.Properties[vocab.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[vocab.ExternalUserIdentifier] = input.ExternalUserIdentifier.PrintIfAvailable();
            data.Properties[vocab.SubscriptionId] = input.SubscriptionId.PrintIfAvailable();
            data.Properties[vocab.PreferredEquipmentId] = input.PreferredEquipmentId.PrintIfAvailable();
            data.Properties[vocab.LastUsedInCampaign] = input.LastUsedInCampaign.PrintIfAvailable();
            data.Properties[vocab.MasterContactIdName] = input.MasterContactIdName.PrintIfAvailable();
            data.Properties[vocab.PreferredSystemUserIdName] = input.PreferredSystemUserIdName.PrintIfAvailable();
            data.Properties[vocab.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentTimeCodeName] = input.PreferredAppointmentTimeCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredEquipmentIdName] = input.PreferredEquipmentIdName.PrintIfAvailable();
            data.Properties[vocab.ParentCustomerIdName] = input.ParentCustomerIdName.PrintIfAvailable();
            data.Properties[vocab.PreferredAppointmentDayCodeName] = input.PreferredAppointmentDayCodeName.PrintIfAvailable();
            data.Properties[vocab.PreferredServiceIdName] = input.PreferredServiceIdName.PrintIfAvailable();
            data.Properties[vocab.ParentCustomerIdType] = input.ParentCustomerIdType.PrintIfAvailable();
            data.Properties[vocab.DoNotSendMarketingMaterialName] = input.DoNotSendMarketingMaterialName.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[vocab.AnnualIncome_Base] = input.AnnualIncome_Base.PrintIfAvailable();
            data.Properties[vocab.CreditLimit_Base] = input.CreditLimit_Base.PrintIfAvailable();
            data.Properties[vocab.Aging60_Base] = input.Aging60_Base.PrintIfAvailable();
            data.Properties[vocab.Aging90_Base] = input.Aging90_Base.PrintIfAvailable();
            data.Properties[vocab.Aging30_Base] = input.Aging30_Base.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName.PrintIfAvailable();
            data.Properties[vocab.ParentCustomerIdYomiName] = input.ParentCustomerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.PreferredSystemUserIdYomiName] = input.PreferredSystemUserIdYomiName.PrintIfAvailable();
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[vocab.MasterContactIdYomiName] = input.MasterContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.ParentContactIdYomiName] = input.ParentContactIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[vocab.IsAutoCreate] = input.IsAutoCreate.PrintIfAvailable();
            data.Properties[vocab.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[vocab.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[vocab.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[vocab.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[vocab.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[vocab.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[vocab.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[vocab.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[vocab.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[vocab.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[vocab.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[vocab.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[vocab.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[vocab.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[vocab.FollowEmail] = input.FollowEmail.PrintIfAvailable();
            data.Properties[vocab.FollowEmailName] = input.FollowEmailName.PrintIfAvailable();
            data.Properties[vocab.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[vocab.Address3_Country] = input.Address3_Country.PrintIfAvailable();
            data.Properties[vocab.Address3_Line1] = input.Address3_Line1.PrintIfAvailable();
            data.Properties[vocab.Address3_Line2] = input.Address3_Line2.PrintIfAvailable();
            data.Properties[vocab.Address3_Line3] = input.Address3_Line3.PrintIfAvailable();
            data.Properties[vocab.Address3_PostalCode] = input.Address3_PostalCode.PrintIfAvailable();
            data.Properties[vocab.Address3_PostOfficeBox] = input.Address3_PostOfficeBox.PrintIfAvailable();
            data.Properties[vocab.Address3_StateOrProvince] = input.Address3_StateOrProvince.PrintIfAvailable();
            data.Properties[vocab.Address3_City] = input.Address3_City.PrintIfAvailable();
            data.Properties[vocab.Business2] = input.Business2.PrintIfAvailable();
            data.Properties[vocab.Callback] = input.Callback.PrintIfAvailable();
            data.Properties[vocab.Company] = input.Company.PrintIfAvailable();
            data.Properties[vocab.Home2] = input.Home2.PrintIfAvailable();
            data.Properties[vocab.Address3_AddressId] = input.Address3_AddressId.PrintIfAvailable();
            data.Properties[vocab.Address3_AddressTypeCodeName] = input.Address3_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.Address3_Composite] = input.Address3_Composite.PrintIfAvailable();
            data.Properties[vocab.Address3_Fax] = input.Address3_Fax.PrintIfAvailable();
            data.Properties[vocab.Address3_FreightTermsCode] = input.Address3_FreightTermsCode.PrintIfAvailable();
            data.Properties[vocab.Address3_FreightTermsCodeName] = input.Address3_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[vocab.Address3_Latitude] = input.Address3_Latitude.PrintIfAvailable();
            data.Properties[vocab.Address3_Longitude] = input.Address3_Longitude.PrintIfAvailable();
            data.Properties[vocab.Address3_Name] = input.Address3_Name.PrintIfAvailable();
            data.Properties[vocab.Address3_PrimaryContactName] = input.Address3_PrimaryContactName.PrintIfAvailable();
            data.Properties[vocab.Address3_ShippingMethodCode] = input.Address3_ShippingMethodCode.PrintIfAvailable();
            data.Properties[vocab.Address3_ShippingMethodCodeName] = input.Address3_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.Address3_Telephone1] = input.Address3_Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address3_Telephone2] = input.Address3_Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address3_Telephone3] = input.Address3_Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address3_UPSZone] = input.Address3_UPSZone.PrintIfAvailable();
            data.Properties[vocab.Address3_UTCOffset] = input.Address3_UTCOffset.PrintIfAvailable();
            data.Properties[vocab.Address3_County] = input.Address3_County.PrintIfAvailable();
            data.Properties[vocab.Address3_AddressTypeCode] = input.Address3_AddressTypeCode.PrintIfAvailable();
            data.Properties[vocab.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[vocab.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[vocab.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[vocab.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[vocab.MarketingOnly] = input.MarketingOnly.PrintIfAvailable();
            data.Properties[vocab.MarketingOnlyName] = input.MarketingOnlyName.PrintIfAvailable();
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

