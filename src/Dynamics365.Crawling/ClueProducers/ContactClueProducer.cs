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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=contact&id={1}", this._dynamics365CrawlJobData.Api, input.ContactId.ToString()), UriKind.Absolute, out Uri uri))
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

            data.Properties[Dynamics365Vocabulary.Contact.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DefaultPriceLevelId] = input.DefaultPriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CustomerSizeCode] = input.CustomerSizeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CustomerTypeCode] = input.CustomerTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredContactMethodCode] = input.PreferredContactMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.LeadSourceCode] = input.LeadSourceCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OriginatingLeadId] = input.OriginatingLeadId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParticipatesInWorkflow] = input.ParticipatesInWorkflow.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.IsBackofficeCustomer] = input.IsBackofficeCustomer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Department] = input.Department.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.NickName] = input.NickName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Suffix] = input.Suffix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.YomiFirstName] = input.YomiFirstName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.YomiMiddleName] = input.YomiMiddleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.YomiLastName] = input.YomiLastName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Anniversary] = input.Anniversary.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.BirthDate] = input.BirthDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.GovernmentId] = input.GovernmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.YomiFullName] = input.YomiFullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.GenderCode] = input.GenderCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AnnualIncome] = input.AnnualIncome.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.HasChildrenCode] = input.HasChildrenCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EducationCode] = input.EducationCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.WebSiteUrl] = input.WebSiteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FamilyStatusCode] = input.FamilyStatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FtpSiteUrl] = input.FtpSiteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EMailAddress1] = input.EMailAddress1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.SpousesName] = input.SpousesName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AssistantName] = input.AssistantName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EMailAddress2] = input.EMailAddress2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AssistantPhone] = input.AssistantPhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EMailAddress3] = input.EMailAddress3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotPhone] = input.DoNotPhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ManagerName] = input.ManagerName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ManagerPhone] = input.ManagerPhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotFax] = input.DoNotFax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotEMail] = input.DoNotEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotPostalMail] = input.DoNotPostalMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotBulkEMail] = input.DoNotBulkEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotBulkPostalMail] = input.DoNotBulkPostalMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AccountRoleCode] = input.AccountRoleCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TerritoryCode] = input.TerritoryCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreditLimit] = input.CreditLimit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreditOnHold] = input.CreditOnHold.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.NumberOfChildren] = input.NumberOfChildren.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ChildrensNames] = input.ChildrensNames.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Pager] = input.Pager.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Aging30] = input.Aging30.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Aging60] = input.Aging60.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Aging90] = input.Aging90.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentContactId] = input.ParentContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OriginatingLeadIdName] = input.OriginatingLeadIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentContactIdName] = input.ParentContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DefaultPriceLevelIdName] = input.DefaultPriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_PrimaryContactName] = input.Address1_PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_FreightTermsCode] = input.Address1_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_PrimaryContactName] = input.Address2_PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_FreightTermsCode] = input.Address2_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotFaxName] = input.DoNotFaxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.IsBackofficeCustomerName] = input.IsBackofficeCustomerName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParticipatesInWorkflowName] = input.ParticipatesInWorkflowName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotPostalMailName] = input.DoNotPostalMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreditOnHoldName] = input.CreditOnHoldName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotPhoneName] = input.DoNotPhoneName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotEMailName] = input.DoNotEMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotBulkPostalMailName] = input.DoNotBulkPostalMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotBulkEMailName] = input.DoNotBulkEMailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredContactMethodCodeName] = input.PreferredContactMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CustomerTypeCodeName] = input.CustomerTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AccountRoleCodeName] = input.AccountRoleCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.HasChildrenCodeName] = input.HasChildrenCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TerritoryCodeName] = input.TerritoryCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.GenderCodeName] = input.GenderCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_FreightTermsCodeName] = input.Address2_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FamilyStatusCodeName] = input.FamilyStatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CustomerSizeCodeName] = input.CustomerSizeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_FreightTermsCodeName] = input.Address1_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.LeadSourceCodeName] = input.LeadSourceCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EducationCodeName] = input.EducationCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredSystemUserId] = input.PreferredSystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredServiceId] = input.PreferredServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MasterId] = input.MasterId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredAppointmentDayCode] = input.PreferredAppointmentDayCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredAppointmentTimeCode] = input.PreferredAppointmentTimeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotSendMM] = input.DoNotSendMM.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentCustomerId] = input.ParentCustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ExternalUserIdentifier] = input.ExternalUserIdentifier.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.SubscriptionId] = input.SubscriptionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredEquipmentId] = input.PreferredEquipmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.LastUsedInCampaign] = input.LastUsedInCampaign.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MasterContactIdName] = input.MasterContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredSystemUserIdName] = input.PreferredSystemUserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MergedName] = input.MergedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredAppointmentTimeCodeName] = input.PreferredAppointmentTimeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredEquipmentIdName] = input.PreferredEquipmentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentCustomerIdName] = input.ParentCustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredAppointmentDayCodeName] = input.PreferredAppointmentDayCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredServiceIdName] = input.PreferredServiceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentCustomerIdType] = input.ParentCustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.DoNotSendMarketingMaterialName] = input.DoNotSendMarketingMaterialName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AnnualIncome_Base] = input.AnnualIncome_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreditLimit_Base] = input.CreditLimit_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Aging60_Base] = input.Aging60_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Aging90_Base] = input.Aging90_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Aging30_Base] = input.Aging30_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentCustomerIdYomiName] = input.ParentCustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.PreferredSystemUserIdYomiName] = input.PreferredSystemUserIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MasterContactIdYomiName] = input.MasterContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ParentContactIdYomiName] = input.ParentContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.IsAutoCreate] = input.IsAutoCreate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FollowEmail] = input.FollowEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.FollowEmailName] = input.FollowEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TimeSpentByMeOnEmailAndMeetings] = input.TimeSpentByMeOnEmailAndMeetings.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Country] = input.Address3_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Line1] = input.Address3_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Line2] = input.Address3_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Line3] = input.Address3_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_PostalCode] = input.Address3_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_PostOfficeBox] = input.Address3_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_StateOrProvince] = input.Address3_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_City] = input.Address3_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Business2] = input.Business2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Callback] = input.Callback.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Company] = input.Company.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Home2] = input.Home2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_AddressId] = input.Address3_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_AddressTypeCodeName] = input.Address3_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Composite] = input.Address3_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Fax] = input.Address3_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_FreightTermsCode] = input.Address3_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_FreightTermsCodeName] = input.Address3_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Latitude] = input.Address3_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Longitude] = input.Address3_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Name] = input.Address3_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_PrimaryContactName] = input.Address3_PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_ShippingMethodCode] = input.Address3_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_ShippingMethodCodeName] = input.Address3_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Telephone1] = input.Address3_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Telephone2] = input.Address3_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_Telephone3] = input.Address3_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_UPSZone] = input.Address3_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_UTCOffset] = input.Address3_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_County] = input.Address3_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.Address3_AddressTypeCode] = input.Address3_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MarketingOnly] = input.MarketingOnly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.MarketingOnlyName] = input.MarketingOnlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.TeamsFollowed] = input.TeamsFollowed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.BusinessCard] = input.BusinessCard.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contact.BusinessCardAttributes] = input.BusinessCardAttributes.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

