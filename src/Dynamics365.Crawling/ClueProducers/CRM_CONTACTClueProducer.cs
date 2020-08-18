using System;

using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core.Models;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using CluedIn.Crawling.Factories;
using CluedIn.Core.Data;
using CluedIn.Core;
using CluedIn.Core.Utilities;
using System.Linq;
using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public class CRM_CONTACTClueProducer : BaseClueProducer<CRM_CONTACT>
    {
        private readonly IClueFactory _factory;

        public CRM_CONTACTClueProducer(IClueFactory factory)
        {
            this._factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(CRM_CONTACT input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            // TODO: Create clue specifying the type of entity it is and ID
            var clue = this._factory.Create(EntityType.Infrastructure.User, input.ContactId, accountId);

            // TODO: Populate clue data
            var data = clue.Data.EntityData;

            //TODO: This could be null - handle it.
            if (!string.IsNullOrEmpty(input.FullName))
            {
                data.Name = input.FullName;
            }
            if (string.IsNullOrWhiteSpace(data.Name))
                data.Name = input.LastName ?? input.FirstName;

            if (string.IsNullOrWhiteSpace(data.Name))
                data.Name = input.EMailAddress1 ?? input.EMailAddress2 ?? input.EMailAddress3 ?? input.EmployeeId;
            if (!string.IsNullOrEmpty(input.Description))
            {
                data.Description = input.Description;
            }
            if (DateTimeOffset.TryParse(input.CreatedOn, out DateTimeOffset date))
                data.CreatedDate = date;
            if (DateTimeOffset.TryParse(input.ModifiedOn, out DateTimeOffset mod))
                data.ModifiedDate = mod;


            if (!string.IsNullOrWhiteSpace(input.ContactId))
                data.Codes.Add(new EntityCode(EntityType.Infrastructure.User, "Dynamics", input.ContactId));

            if (!string.IsNullOrWhiteSpace(input.ContactId))
                data.Codes.Add(new EntityCode(EntityType.Infrastructure.User, CodeOrigin.CluedIn, input.ContactId));

            if (!string.IsNullOrWhiteSpace(input.ap_KCContactGUID))
                data.Codes.Add(new EntityCode(EntityType.Infrastructure.User, "KC CRM", input.ap_KCContactGUID));

            if (!string.IsNullOrWhiteSpace(input.lder_modulusid))
                data.Codes.Add(new EntityCode(EntityType.Infrastructure.User, "Modulus", input.lder_modulusid));

            if (!string.IsNullOrWhiteSpace(input.AP_MemberNumber))
                data.Codes.Add(new EntityCode(EntityType.Infrastructure.User, "ModulusMedlem", input.AP_MemberNumber));

            if (!string.IsNullOrWhiteSpace(input.AccountId))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.AccountId);

            if (!string.IsNullOrWhiteSpace(input.ParentContactId))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.ParentContactId);

            if (!string.IsNullOrWhiteSpace(input.ParentCustomerId))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.ParentCustomerId);

            if (!string.IsNullOrWhiteSpace(input.OriginatingLeadId))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.OriginatingLeadId);

            if (!string.IsNullOrWhiteSpace(input.OwnerId))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //Author
            if (!string.IsNullOrWhiteSpace(input.CreatedBy))
            {
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

                if (!string.IsNullOrWhiteSpace(input.CreatedByName))
                    data.Authors.Add(new PersonReference(input.CreatedByName, new EntityCode(EntityType.Infrastructure.User, Dynamics365Constants.CodeOrigin, input.CreatedBy)));
                else
                    data.Authors.Add(new PersonReference(new EntityCode(EntityType.Infrastructure.User, Dynamics365Constants.CodeOrigin, input.CreatedBy)));
            }

            if (!string.IsNullOrWhiteSpace(input.OwningUser))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            //Last Modified By
            if (!string.IsNullOrWhiteSpace(input.ModifiedBy))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.Parent);

            var vocab = new CRM_CONTACTVocabulary();

            data.Properties[vocab.lder_fremtidig_foreningName] = input.lder_fremtidig_foreningName;
            //TODO: Preview Image?
            data.Properties[vocab.EntityImage_URL] = input.EntityImage_URL;
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName;
            data.Properties[vocab.lder_forbundsenhedName] = input.lder_forbundsenhedName;
            data.Properties[vocab.lder_lokalafdelingName] = input.lder_lokalafdelingName;
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName;
            data.Properties[vocab.MasterContactIdYomiName] = input.MasterContactIdYomiName;
            data.Properties[vocab.lder_jobcenterafmeldekodeName] = input.lder_jobcenterafmeldekodeName;
            data.Properties[vocab.PreferredEquipmentIdName] = input.PreferredEquipmentIdName;
            data.Properties[vocab.MasterContactIdName] = input.MasterContactIdName;
            data.Properties[vocab.OriginatingLeadIdYomiName] = input.OriginatingLeadIdYomiName;
            data.Properties[vocab.EntityImage_Timestamp] = input.EntityImage_Timestamp;
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName;
            data.Properties[vocab.lder_sprogName] = input.lder_sprogName;
            data.Properties[vocab.lder_stillingskodeName] = input.lder_stillingskodeName;
            data.Properties[vocab.lder_under_indmeldelse_i_foreningName] = input.lder_under_indmeldelse_i_foreningName;
            data.Properties[vocab.lder_foreningName] = input.lder_foreningName;
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName;
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName;
            data.Properties[vocab.lder_ansaettelsesforholdName] = input.lder_ansaettelsesforholdName;
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName;
            data.Properties[vocab.lder_medlemskategoriName] = input.lder_medlemskategoriName;
            data.Properties[vocab.PreferredServiceIdName] = input.PreferredServiceIdName;
            data.Properties[vocab.DefaultPriceLevelIdName] = input.DefaultPriceLevelIdName;
            data.Properties[vocab.lder_moedelokationName] = input.lder_moedelokationName;
            data.Properties[vocab.OriginatingLeadIdName] = input.OriginatingLeadIdName;
            data.Properties[vocab.CreatedByName] = input.CreatedByName;
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName;
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName;
            data.Properties[vocab.PreferredSystemUserIdName] = input.PreferredSystemUserIdName;
            data.Properties[vocab.PreferredSystemUserIdYomiName] = input.PreferredSystemUserIdYomiName;
            data.Properties[vocab.Address1_AddressTypeCode] = input.Address1_AddressTypeCode;
            data.Properties[vocab.Address1_City] = input.Address1_City;
            data.Properties[vocab.Address1_Composite] = input.Address1_Composite;
            data.Properties[vocab.Address1_Country] = input.Address1_Country;
            data.Properties[vocab.Address1_County] = input.Address1_County;
            data.Properties[vocab.Address1_AddressId] = input.Address1_AddressId;
            data.Properties[vocab.Address1_Fax] = input.Address1_Fax;
            data.Properties[vocab.Address1_FreightTermsCode] = input.Address1_FreightTermsCode;
            data.Properties[vocab.Address1_Latitude] = input.Address1_Latitude;
            data.Properties[vocab.Address1_Line1] = input.Address1_Line1;
            data.Properties[vocab.Address1_Line2] = input.Address1_Line2;
            data.Properties[vocab.Address1_Line3] = input.Address1_Line3;
            data.Properties[vocab.Address1_Longitude] = input.Address1_Longitude;
            data.Properties[vocab.Address1_Name] = input.Address1_Name;
            data.Properties[vocab.Address1_PostalCode] = input.Address1_PostalCode;
            data.Properties[vocab.Address1_PostOfficeBox] = input.Address1_PostOfficeBox;
            data.Properties[vocab.Address1_PrimaryContactName] = input.Address1_PrimaryContactName;
            data.Properties[vocab.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode;
            data.Properties[vocab.Address1_StateOrProvince] = input.Address1_StateOrProvince;
            data.Properties[vocab.Address1_Telephone1] = input.Address1_Telephone1;
            data.Properties[vocab.Address1_Telephone2] = input.Address1_Telephone2;
            data.Properties[vocab.Address1_Telephone3] = input.Address1_Telephone3;
            data.Properties[vocab.Address1_UPSZone] = input.Address1_UPSZone;
            data.Properties[vocab.Address1_UTCOffset] = input.Address1_UTCOffset;
            data.Properties[vocab.Address2_AddressTypeCode] = input.Address2_AddressTypeCode;
            data.Properties[vocab.Address2_City] = input.Address2_City;
            data.Properties[vocab.Address2_Composite] = input.Address2_Composite;
            data.Properties[vocab.Address2_Country] = input.Address2_Country;
            data.Properties[vocab.Address2_County] = input.Address2_County;
            data.Properties[vocab.Address2_AddressId] = input.Address2_AddressId;
            data.Properties[vocab.Address2_Fax] = input.Address2_Fax;
            data.Properties[vocab.Address2_FreightTermsCode] = input.Address2_FreightTermsCode;
            data.Properties[vocab.Address2_Latitude] = input.Address2_Latitude;
            data.Properties[vocab.Address2_Line1] = input.Address2_Line1;
            data.Properties[vocab.Address2_Line2] = input.Address2_Line2;
            data.Properties[vocab.Address2_Line3] = input.Address2_Line3;
            data.Properties[vocab.Address2_Longitude] = input.Address2_Longitude;
            data.Properties[vocab.Address2_Name] = input.Address2_Name;
            data.Properties[vocab.Address2_PostalCode] = input.Address2_PostalCode;
            data.Properties[vocab.Address2_PostOfficeBox] = input.Address2_PostOfficeBox;
            data.Properties[vocab.Address2_PrimaryContactName] = input.Address2_PrimaryContactName;
            data.Properties[vocab.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode;
            data.Properties[vocab.Address2_StateOrProvince] = input.Address2_StateOrProvince;
            data.Properties[vocab.Address2_Telephone1] = input.Address2_Telephone1;
            data.Properties[vocab.Address2_Telephone2] = input.Address2_Telephone2;
            data.Properties[vocab.Address2_Telephone3] = input.Address2_Telephone3;
            data.Properties[vocab.Address2_UPSZone] = input.Address2_UPSZone;
            data.Properties[vocab.Address2_UTCOffset] = input.Address2_UTCOffset;
            data.Properties[vocab.Address3_AddressTypeCode] = input.Address3_AddressTypeCode;
            data.Properties[vocab.Address3_City] = input.Address3_City;
            data.Properties[vocab.Address3_Composite] = input.Address3_Composite;
            data.Properties[vocab.Address3_Country] = input.Address3_Country;
            data.Properties[vocab.Address3_County] = input.Address3_County;
            data.Properties[vocab.Address3_AddressId] = input.Address3_AddressId;
            data.Properties[vocab.Address3_Fax] = input.Address3_Fax;
            data.Properties[vocab.Address3_FreightTermsCode] = input.Address3_FreightTermsCode;
            data.Properties[vocab.Address3_Latitude] = input.Address3_Latitude;
            data.Properties[vocab.Address3_Line1] = input.Address3_Line1;
            data.Properties[vocab.Address3_Line2] = input.Address3_Line2;
            data.Properties[vocab.Address3_Line3] = input.Address3_Line3;
            data.Properties[vocab.Address3_Longitude] = input.Address3_Longitude;
            data.Properties[vocab.Address3_Name] = input.Address3_Name;
            data.Properties[vocab.Address3_PostalCode] = input.Address3_PostalCode;
            data.Properties[vocab.Address3_PostOfficeBox] = input.Address3_PostOfficeBox;
            data.Properties[vocab.Address3_PrimaryContactName] = input.Address3_PrimaryContactName;
            data.Properties[vocab.Address3_ShippingMethodCode] = input.Address3_ShippingMethodCode;
            data.Properties[vocab.Address3_StateOrProvince] = input.Address3_StateOrProvince;
            data.Properties[vocab.Address3_Telephone1] = input.Address3_Telephone1;
            data.Properties[vocab.Address3_Telephone2] = input.Address3_Telephone2;
            data.Properties[vocab.Address3_Telephone3] = input.Address3_Telephone3;
            data.Properties[vocab.Address3_UPSZone] = input.Address3_UPSZone;
            data.Properties[vocab.Address3_UTCOffset] = input.Address3_UTCOffset;
            data.Properties[vocab.OwnerId] = input.OwnerId;
            data.Properties[vocab.OwnerIdName] = input.OwnerIdName;
            data.Properties[vocab.OwnerIdYomiName] = input.OwnerIdYomiName;
            data.Properties[vocab.OwnerIdDsc] = input.OwnerIdDsc;
            data.Properties[vocab.OwnerIdType] = input.OwnerIdType;
            data.Properties[vocab.OwningUser] = input.OwningUser;
            data.Properties[vocab.OwningTeam] = input.OwningTeam;
            data.Properties[vocab.AccountId] = input.AccountId;
            data.Properties[vocab.AccountIdName] = input.AccountIdName;
            data.Properties[vocab.AccountIdYomiName] = input.AccountIdYomiName;
            data.Properties[vocab.ParentContactId] = input.ParentContactId;
            data.Properties[vocab.ParentContactIdName] = input.ParentContactIdName;
            data.Properties[vocab.ParentContactIdYomiName] = input.ParentContactIdYomiName;
            data.Properties[vocab.ContactId] = input.ContactId;
            data.Properties[vocab.DefaultPriceLevelId] = input.DefaultPriceLevelId;
            data.Properties[vocab.CustomerSizeCode] = input.CustomerSizeCode;
            data.Properties[vocab.CustomerTypeCode] = input.CustomerTypeCode;
            data.Properties[vocab.PreferredContactMethodCode] = input.PreferredContactMethodCode;
            data.Properties[vocab.LeadSourceCode] = input.LeadSourceCode;
            data.Properties[vocab.OriginatingLeadId] = input.OriginatingLeadId;
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit;
            data.Properties[vocab.PaymentTermsCode] = input.PaymentTermsCode;
            data.Properties[vocab.ShippingMethodCode] = input.ShippingMethodCode;
            data.Properties[vocab.ParticipatesInWorkflow] = input.ParticipatesInWorkflow;
            data.Properties[vocab.IsBackofficeCustomer] = input.IsBackofficeCustomer;
            data.Properties[vocab.Salutation] = input.Salutation;
            data.Properties[vocab.JobTitle] = input.JobTitle;
            data.Properties[vocab.FirstName] = input.FirstName;
            data.Properties[vocab.Department] = input.Department;
            data.Properties[vocab.NickName] = input.NickName;
            data.Properties[vocab.MiddleName] = input.MiddleName;
            data.Properties[vocab.LastName] = input.LastName;
            data.Properties[vocab.Suffix] = input.Suffix;
            data.Properties[vocab.YomiFirstName] = input.YomiFirstName;
            data.Properties[vocab.FullName] = input.FullName;
            data.Properties[vocab.YomiMiddleName] = input.YomiMiddleName;
            data.Properties[vocab.YomiLastName] = input.YomiLastName;
            data.Properties[vocab.Anniversary] = input.Anniversary;
            data.Properties[vocab.BirthDate] = input.BirthDate;
            data.Properties[vocab.GovernmentId] = input.GovernmentId;
            data.Properties[vocab.YomiFullName] = input.YomiFullName;
            //TODO: Set the description
            data.Properties[vocab.Description] = input.Description;
            data.Properties[vocab.EmployeeId] = input.EmployeeId;
            data.Properties[vocab.GenderCode] = input.GenderCode;
            data.Properties[vocab.AnnualIncome] = input.AnnualIncome;
            data.Properties[vocab.HasChildrenCode] = input.HasChildrenCode;
            data.Properties[vocab.EducationCode] = input.EducationCode;
            data.Properties[vocab.WebSiteUrl] = input.WebSiteUrl;
            data.Properties[vocab.FamilyStatusCode] = input.FamilyStatusCode;
            data.Properties[vocab.FtpSiteUrl] = input.FtpSiteUrl;
            data.Properties[vocab.EMailAddress1] = input.EMailAddress1;
            data.Properties[vocab.SpousesName] = input.SpousesName;
            data.Properties[vocab.AssistantName] = input.AssistantName;
            data.Properties[vocab.EMailAddress2] = input.EMailAddress2;
            data.Properties[vocab.AssistantPhone] = input.AssistantPhone;
            data.Properties[vocab.EMailAddress3] = input.EMailAddress3;
            data.Properties[vocab.DoNotPhone] = input.DoNotPhone;
            data.Properties[vocab.ManagerName] = input.ManagerName;
            data.Properties[vocab.ManagerPhone] = input.ManagerPhone;
            data.Properties[vocab.DoNotFax] = input.DoNotFax;
            data.Properties[vocab.DoNotEMail] = input.DoNotEMail;
            data.Properties[vocab.DoNotPostalMail] = input.DoNotPostalMail;
            data.Properties[vocab.DoNotBulkEMail] = input.DoNotBulkEMail;
            data.Properties[vocab.DoNotBulkPostalMail] = input.DoNotBulkPostalMail;
            data.Properties[vocab.AccountRoleCode] = input.AccountRoleCode;
            data.Properties[vocab.TerritoryCode] = input.TerritoryCode;
            data.Properties[vocab.IsPrivate] = input.IsPrivate;
            data.Properties[vocab.CreditLimit] = input.CreditLimit;
            data.Properties[vocab.CreatedOn] = input.CreatedOn;
            data.Properties[vocab.CreditOnHold] = input.CreditOnHold;
            data.Properties[vocab.CreatedBy] = input.CreatedBy;
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn;
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy;
            data.Properties[vocab.NumberOfChildren] = input.NumberOfChildren;
            data.Properties[vocab.ChildrensNames] = input.ChildrensNames;
            data.Properties[vocab.VersionNumber] = input.VersionNumber;
            data.Properties[vocab.MobilePhone] = input.MobilePhone;
            data.Properties[vocab.Pager] = input.Pager;
            data.Properties[vocab.Telephone1] = input.Telephone1;
            data.Properties[vocab.Telephone2] = input.Telephone2;
            data.Properties[vocab.Telephone3] = input.Telephone3;
            data.Properties[vocab.Fax] = input.Fax;
            data.Properties[vocab.Aging30] = input.Aging30;
            data.Properties[vocab.StateCode] = input.StateCode;
            data.Properties[vocab.Aging60] = input.Aging60;
            data.Properties[vocab.StatusCode] = input.StatusCode;
            data.Properties[vocab.Aging90] = input.Aging90;
            data.Properties[vocab.PreferredSystemUserId] = input.PreferredSystemUserId;
            data.Properties[vocab.PreferredServiceId] = input.PreferredServiceId;
            data.Properties[vocab.MasterId] = input.MasterId;
            data.Properties[vocab.PreferredAppointmentDayCode] = input.PreferredAppointmentDayCode;
            data.Properties[vocab.PreferredAppointmentTimeCode] = input.PreferredAppointmentTimeCode;
            data.Properties[vocab.DoNotSendMM] = input.DoNotSendMM;
            data.Properties[vocab.ParentCustomerId] = input.ParentCustomerId;
            data.Properties[vocab.Merged] = input.Merged;
            data.Properties[vocab.ExternalUserIdentifier] = input.ExternalUserIdentifier;
            data.Properties[vocab.SubscriptionId] = input.SubscriptionId;
            data.Properties[vocab.PreferredEquipmentId] = input.PreferredEquipmentId;
            data.Properties[vocab.LastUsedInCampaign] = input.LastUsedInCampaign;
            data.Properties[vocab.ParentCustomerIdName] = input.ParentCustomerIdName;
            data.Properties[vocab.ParentCustomerIdType] = input.ParentCustomerIdType;
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId;
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn;
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate;
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber;
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber;
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode;
            data.Properties[vocab.AnnualIncome_Base] = input.AnnualIncome_Base;
            data.Properties[vocab.CreditLimit_Base] = input.CreditLimit_Base;
            data.Properties[vocab.Aging60_Base] = input.Aging60_Base;
            data.Properties[vocab.Aging90_Base] = input.Aging90_Base;
            data.Properties[vocab.Aging30_Base] = input.Aging30_Base;
            data.Properties[vocab.ParentCustomerIdYomiName] = input.ParentCustomerIdYomiName;
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy;
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy;
            data.Properties[vocab.IsAutoCreate] = input.IsAutoCreate;
            data.Properties[vocab.StageId] = input.StageId;
            data.Properties[vocab.ProcessId] = input.ProcessId;
            data.Properties[vocab.EntityImageId] = input.EntityImageId;
            data.Properties[vocab.TraversedPath] = input.TraversedPath;
            data.Properties[vocab.Business2] = input.Business2;
            data.Properties[vocab.Callback] = input.Callback;
            data.Properties[vocab.Company] = input.Company;
            data.Properties[vocab.Home2] = input.Home2;
            data.Properties[vocab.Ap_webbrugernavn] = input.Ap_webbrugernavn;
            data.Properties[vocab.Ap_Medlemstype] = input.Ap_Medlemstype;
            data.Properties[vocab.Ap_emailvask] = input.Ap_emailvask;
            data.Properties[vocab.Ap_Emailugyldig] = input.Ap_Emailugyldig;
            data.Properties[vocab.Ap_Emailvasketprdato] = input.Ap_Emailvasketprdato;
            data.Properties[vocab.Ap_Senestedatoforweblogin] = input.Ap_Senestedatoforweblogin;
            data.Properties[vocab.Ap_senestelogintype] = input.Ap_senestelogintype;
            data.Properties[vocab.Ap_WebUserID] = input.Ap_WebUserID;
            data.Properties[vocab.nn_nndecisionmakerid] = input.nn_nndecisionmakerid;
            data.Properties[vocab.nn_updateprotected] = input.nn_updateprotected;
            data.Properties[vocab.Ap_Restance] = input.Ap_Restance;
            data.Properties[vocab.Ap_Address2MunicipalityCode] = input.Ap_Address2MunicipalityCode;
            data.Properties[vocab.AP_Branchenummer] = input.AP_Branchenummer;
            data.Properties[vocab.Ap_Servicenyhedsbrev] = input.Ap_Servicenyhedsbrev;
            data.Properties[vocab.Ap_testcontact] = input.Ap_testcontact;
            data.Properties[vocab.AP_Uddannelsesbaggrund] = input.AP_Uddannelsesbaggrund;
            data.Properties[vocab.AP_Newsletteremail] = input.AP_Newsletteremail;
            data.Properties[vocab.Ap_Efterloendato] = input.Ap_Efterloendato;
            data.Properties[vocab.Ap_Efterloen] = input.Ap_Efterloen;
            data.Properties[vocab.AP_Member] = input.AP_Member;
            data.Properties[vocab.Ap_Tilbudtildig] = input.Ap_Tilbudtildig;
            data.Properties[vocab.Ap_Tidligereakasse] = input.Ap_Tidligereakasse;
            data.Properties[vocab.Ap_Address2CountyCode] = input.Ap_Address2CountyCode;
            data.Properties[vocab.Ap_Pensionistdato] = input.Ap_Pensionistdato;
            data.Properties[vocab.Ap_Ledigdato] = input.Ap_Ledigdato;
            data.Properties[vocab.Ap_Medlemsdatasenestopdateret] = input.Ap_Medlemsdatasenestopdateret;
            data.Properties[vocab.AP_Newsletter] = input.AP_Newsletter;
            data.Properties[vocab.Lh_Tillgsforsikring] = input.Lh_Tillgsforsikring;
            data.Properties[vocab.Ap_Uddannelse] = input.Ap_Uddannelse;
            data.Properties[vocab.Ap_Paneler] = input.Ap_Paneler;
            data.Properties[vocab.AP_Ledig] = input.AP_Ledig;
            data.Properties[vocab.AP_Pensionist] = input.AP_Pensionist;
            data.Properties[vocab.Ap_Udmeldafnuvaerendeorganisation] = input.Ap_Udmeldafnuvaerendeorganisation;
            data.Properties[vocab.AP_LeadID] = input.AP_LeadID;
            data.Properties[vocab.AP_Ansaettelsessted] = input.AP_Ansaettelsessted;
            data.Properties[vocab.AP_Indmeldtiakasse] = input.AP_Indmeldtiakasse;
            data.Properties[vocab.AP_Branchenavn] = input.AP_Branchenavn;
            data.Properties[vocab.AP_NyStilling] = input.AP_NyStilling;
            data.Properties[vocab.Ap_Kontonummer] = input.Ap_Kontonummer;
            data.Properties[vocab.Ap_birthdate] = input.Ap_birthdate;
            data.Properties[vocab.AP_Efterlonsbidrag] = input.AP_Efterlonsbidrag;
            data.Properties[vocab.Ap_SMS] = input.Ap_SMS;
            data.Properties[vocab.Ap_Kurserogkonferencer] = input.Ap_Kurserogkonferencer;
            data.Properties[vocab.Ap_Regnr] = input.Ap_Regnr;
            data.Properties[vocab.AP_Tillidserhverv] = input.AP_Tillidserhverv;
            data.Properties[vocab.AP_MemberNumber] = input.AP_MemberNumber;
            data.Properties[vocab.AP_Kursist] = input.AP_Kursist;
            data.Properties[vocab.AP_Akasse] = input.AP_Akasse;
            data.Properties[vocab.AP_Indmeldtiorganisation] = input.AP_Indmeldtiorganisation;
            data.Properties[vocab.Ap_Medlemunderoptagelse] = input.Ap_Medlemunderoptagelse;
            data.Properties[vocab.Ap_Momsregistreretvedoptagelse] = input.Ap_Momsregistreretvedoptagelse;
            data.Properties[vocab.Ap_Nyhedsbrevsabonnent] = input.Ap_Nyhedsbrevsabonnent;
            data.Properties[vocab.AP_Organisation] = input.AP_Organisation;
            data.Properties[vocab.AP_County] = input.AP_County;
            data.Properties[vocab.Ap_Fraflyttetakasse] = input.Ap_Fraflyttetakasse;
            data.Properties[vocab.Ap_Address2Municipality] = input.Ap_Address2Municipality;
            data.Properties[vocab.AP_Sprogkundskaber] = input.AP_Sprogkundskaber;
            data.Properties[vocab.AP_Alder] = input.AP_Alder;
            data.Properties[vocab.Ap_Udmeldt] = input.Ap_Udmeldt;
            data.Properties[vocab.AP_Tillidsposter] = input.AP_Tillidsposter;
            data.Properties[vocab.Lh_NavisionID] = input.Lh_NavisionID;
            data.Properties[vocab.ap_Doed] = input.ap_Doed;
            data.Properties[vocab.ap_LTDaekning] = input.ap_LTDaekning;
            data.Properties[vocab.ap_LTKarens] = input.ap_LTKarens;
            data.Properties[vocab.ap_LTPeriode] = input.ap_LTPeriode;
            data.Properties[vocab.ap_Ulykkesforsikring] = input.ap_Ulykkesforsikring;
            data.Properties[vocab.ap_LTIkraftdato] = input.ap_LTIkraftdato;
            data.Properties[vocab.ap_managementlevel] = input.ap_managementlevel;
            data.Properties[vocab.ap_opdateretfraweb] = input.ap_opdateretfraweb;
            data.Properties[vocab.ap_Privatforsikringer] = input.ap_Privatforsikringer;
            data.Properties[vocab.ap_Sundhedsforsikring] = input.ap_Sundhedsforsikring;
            data.Properties[vocab.ap_Forening] = input.ap_Forening;
            data.Properties[vocab.ap_KCContactGUID] = input.ap_KCContactGUID;
            data.Properties[vocab.ap_Mobilnummerlandekode] = input.ap_Mobilnummerlandekode;
            data.Properties[vocab.ap_SMSgatewayadresse] = input.ap_SMSgatewayadresse;
            data.Properties[vocab.lder_stillingskode] = input.lder_stillingskode;
            data.Properties[vocab.lder_forbundsenhed] = input.lder_forbundsenhed;
            data.Properties[vocab.lder_lokalafdeling] = input.lder_lokalafdeling;
            data.Properties[vocab.lder_forening] = input.lder_forening;
            data.Properties[vocab.lder_address2_kommune] = input.lder_address2_kommune;
            data.Properties[vocab.lder_address2_landekode_og_land] = input.lder_address2_landekode_og_land;
            data.Properties[vocab.lder_address2_postnummer_og_by] = input.lder_address2_postnummer_og_by;
            data.Properties[vocab.lder_address2region] = input.lder_address2region;
            data.Properties[vocab.lder_afmeldt_jobcenter] = input.lder_afmeldt_jobcenter;
            data.Properties[vocab.lder_akasse_framelding] = input.lder_akasse_framelding;
            data.Properties[vocab.lder_akasse_indmelding] = input.lder_akasse_indmelding;
            data.Properties[vocab.lder_dagpengeretsdato] = input.lder_dagpengeretsdato;
            data.Properties[vocab.lder_digital_kommunikation_fravalgt] = input.lder_digital_kommunikation_fravalgt;
            data.Properties[vocab.lder_dimittenddato] = input.lder_dimittenddato;
            data.Properties[vocab.lder_efterloensbevis_pr_dato] = input.lder_efterloensbevis_pr_dato;
            data.Properties[vocab.lder_efterloensordning_pr] = input.lder_efterloensordning_pr;
            data.Properties[vocab.lder_efterloesnbidrag] = input.lder_efterloesnbidrag;
            data.Properties[vocab.lder_ej_ret_til_juridisk_hjaelp] = input.lder_ej_ret_til_juridisk_hjaelp;
            data.Properties[vocab.lder_foerstkommende_moededato_i_akassen] = input.lder_foerstkommende_moededato_i_akassen;
            data.Properties[vocab.lder_forsikringsform] = input.lder_forsikringsform;
            data.Properties[vocab.lder_hemmelig_adresse] = input.lder_hemmelig_adresse;
            data.Properties[vocab.lder_knap_data] = input.lder_knap_data;
            data.Properties[vocab.lder_landekode] = input.lder_landekode;
            data.Properties[vocab.lder_landekode_alternativnummer] = input.lder_landekode_alternativnummer;
            data.Properties[vocab.lder_landekode_mobilnummer] = input.lder_landekode_mobilnummer;
            data.Properties[vocab.lder_maa_tilbydes_a_kasse] = input.lder_maa_tilbydes_a_kasse;
            data.Properties[vocab.lder_maa_tilbydes_coaching] = input.lder_maa_tilbydes_coaching;
            data.Properties[vocab.lder_maa_tilbydes_kurser] = input.lder_maa_tilbydes_kurser;
            data.Properties[vocab.lder_maa_tilbydes_organisation] = input.lder_maa_tilbydes_organisation;
            data.Properties[vocab.lder_maa_tilbydes_outplacement] = input.lder_maa_tilbydes_outplacement;
            data.Properties[vocab.lder_maa_tilbydes_pension] = input.lder_maa_tilbydes_pension;
            data.Properties[vocab.lder_maa_tilbydes_privatforsikring] = input.lder_maa_tilbydes_privatforsikring;
            data.Properties[vocab.lder_maa_tilbydes_sundhedsforsikring] = input.lder_maa_tilbydes_sundhedsforsikring;
            data.Properties[vocab.lder_maa_tilbydes_tillaegsforsikring] = input.lder_maa_tilbydes_tillaegsforsikring;
            data.Properties[vocab.lder_maa_tilbydes_ulykkesforsikring] = input.lder_maa_tilbydes_ulykkesforsikring;
            data.Properties[vocab.lder_medlemstype] = input.lder_medlemstype;
            data.Properties[vocab.lder_modulusid] = input.lder_modulusid;
            data.Properties[vocab.lder_senest_tilbudt_coaching] = input.lder_senest_tilbudt_coaching;
            data.Properties[vocab.lder_senest_tilbudt_kurser] = input.lder_senest_tilbudt_kurser;
            data.Properties[vocab.lder_senest_tilbudt_outplacement] = input.lder_senest_tilbudt_outplacement;
            data.Properties[vocab.lder_senest_tilbudt_pension] = input.lder_senest_tilbudt_pension;
            data.Properties[vocab.lder_senest_tilbudt_privatforsikring] = input.lder_senest_tilbudt_privatforsikring;
            data.Properties[vocab.lder_tillidshverv] = input.lder_tillidshverv;
            data.Properties[vocab.lder_tilmeldt_jobcenter] = input.lder_tilmeldt_jobcenter;
            data.Properties[vocab.lder_tilmeldt_jobcenter_ja_nej] = input.lder_tilmeldt_jobcenter_ja_nej;
            data.Properties[vocab.lder_vaesentlige_bemaerkninger] = input.lder_vaesentlige_bemaerkninger;
            data.Properties[vocab.lder_ansaettelsesforhold] = input.lder_ansaettelsesforhold;
            data.Properties[vocab.lder_under_indmeldelse_i_forening] = input.lder_under_indmeldelse_i_forening;
            data.Properties[vocab.lder_jobcenterafmeldekode] = input.lder_jobcenterafmeldekode;
            data.Properties[vocab.lder_medlemskategori] = input.lder_medlemskategori;
            data.Properties[vocab.lder_fremtidig_forening] = input.lder_fremtidig_forening;
            data.Properties[vocab.lder_ej_tilfredshedsmling] = input.lder_ej_tilfredshedsmling;
            data.Properties[vocab.lder_moedelokation] = input.lder_moedelokation;
            data.Properties[vocab.lder_sprog] = input.lder_sprog;
            data.Properties[vocab.lder_dato_for_seneste_afholdte_cv_samtale] = input.lder_dato_for_seneste_afholdte_cv_samtale;
            data.Properties[vocab.lder_klipforbrug] = input.lder_klipforbrug;

            return clue;
        }
    }
}
