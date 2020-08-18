using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class CRM_CONTACTVocabulary : SimpleVocabulary
    {
        public CRM_CONTACTVocabulary()
        {
            this.VocabularyName = "Contact";
            this.KeyPrefix = "dynamics365.contact";
            this.KeySeparator = ".";
            this.Grouping = EntityType.Infrastructure.User;

            this.AddGroup("Contact", group =>
            {
                this.lder_fremtidig_foreningName = group.Add(new VocabularyKey("lder_fremtidig_foreningName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible));
                this.lder_forbundsenhedName = group.Add(new VocabularyKey("lder_forbundsenhedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_lokalafdelingName = group.Add(new VocabularyKey("lder_lokalafdelingName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.MasterContactIdYomiName = group.Add(new VocabularyKey("MasterContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_jobcenterafmeldekodeName = group.Add(new VocabularyKey("lder_jobcenterafmeldekodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredEquipmentIdName = group.Add(new VocabularyKey("PreferredEquipmentIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.MasterContactIdName = group.Add(new VocabularyKey("MasterContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OriginatingLeadIdYomiName = group.Add(new VocabularyKey("OriginatingLeadIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_sprogName = group.Add(new VocabularyKey("lder_sprogName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_stillingskodeName = group.Add(new VocabularyKey("lder_stillingskodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_under_indmeldelse_i_foreningName = group.Add(new VocabularyKey("lder_under_indmeldelse_i_foreningName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_foreningName = group.Add(new VocabularyKey("lder_foreningName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_ansaettelsesforholdName = group.Add(new VocabularyKey("lder_ansaettelsesforholdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_medlemskategoriName = group.Add(new VocabularyKey("lder_medlemskategoriName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredServiceIdName = group.Add(new VocabularyKey("PreferredServiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.DefaultPriceLevelIdName = group.Add(new VocabularyKey("DefaultPriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_moedelokationName = group.Add(new VocabularyKey("lder_moedelokationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OriginatingLeadIdName = group.Add(new VocabularyKey("OriginatingLeadIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredSystemUserIdName = group.Add(new VocabularyKey("PreferredSystemUserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredSystemUserIdYomiName = group.Add(new VocabularyKey("PreferredSystemUserIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_AddressTypeCode = group.Add(new VocabularyKey("Address1_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_City = group.Add(new VocabularyKey("Address1_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Composite = group.Add(new VocabularyKey("Address1_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Country = group.Add(new VocabularyKey("Address1_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_County = group.Add(new VocabularyKey("Address1_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_AddressId = group.Add(new VocabularyKey("Address1_AddressId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Fax = group.Add(new VocabularyKey("Address1_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_FreightTermsCode = group.Add(new VocabularyKey("Address1_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Latitude = group.Add(new VocabularyKey("Address1_Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Line1 = group.Add(new VocabularyKey("Address1_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Line2 = group.Add(new VocabularyKey("Address1_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Line3 = group.Add(new VocabularyKey("Address1_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Longitude = group.Add(new VocabularyKey("Address1_Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Name = group.Add(new VocabularyKey("Address1_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_PostalCode = group.Add(new VocabularyKey("Address1_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_PostOfficeBox = group.Add(new VocabularyKey("Address1_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_PrimaryContactName = group.Add(new VocabularyKey("Address1_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_ShippingMethodCode = group.Add(new VocabularyKey("Address1_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_StateOrProvince = group.Add(new VocabularyKey("Address1_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Telephone1 = group.Add(new VocabularyKey("Address1_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Telephone2 = group.Add(new VocabularyKey("Address1_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_Telephone3 = group.Add(new VocabularyKey("Address1_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_UPSZone = group.Add(new VocabularyKey("Address1_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address1_UTCOffset = group.Add(new VocabularyKey("Address1_UTCOffset", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_AddressTypeCode = group.Add(new VocabularyKey("Address2_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_City = group.Add(new VocabularyKey("Address2_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Composite = group.Add(new VocabularyKey("Address2_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Country = group.Add(new VocabularyKey("Address2_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_County = group.Add(new VocabularyKey("Address2_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_AddressId = group.Add(new VocabularyKey("Address2_AddressId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Fax = group.Add(new VocabularyKey("Address2_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_FreightTermsCode = group.Add(new VocabularyKey("Address2_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Latitude = group.Add(new VocabularyKey("Address2_Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Line1 = group.Add(new VocabularyKey("Address2_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Line2 = group.Add(new VocabularyKey("Address2_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Line3 = group.Add(new VocabularyKey("Address2_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Longitude = group.Add(new VocabularyKey("Address2_Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Name = group.Add(new VocabularyKey("Address2_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_PostalCode = group.Add(new VocabularyKey("Address2_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_PostOfficeBox = group.Add(new VocabularyKey("Address2_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_PrimaryContactName = group.Add(new VocabularyKey("Address2_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_ShippingMethodCode = group.Add(new VocabularyKey("Address2_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_StateOrProvince = group.Add(new VocabularyKey("Address2_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Telephone1 = group.Add(new VocabularyKey("Address2_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Telephone2 = group.Add(new VocabularyKey("Address2_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_Telephone3 = group.Add(new VocabularyKey("Address2_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_UPSZone = group.Add(new VocabularyKey("Address2_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address2_UTCOffset = group.Add(new VocabularyKey("Address2_UTCOffset", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_AddressTypeCode = group.Add(new VocabularyKey("Address3_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_City = group.Add(new VocabularyKey("Address3_City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.Visible));
                this.Address3_Composite = group.Add(new VocabularyKey("Address3_Composite", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                this.Address3_Country = group.Add(new VocabularyKey("Address3_Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible));
                this.Address3_County = group.Add(new VocabularyKey("Address3_County", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                this.Address3_AddressId = group.Add(new VocabularyKey("Address3_AddressId", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                this.Address3_Fax = group.Add(new VocabularyKey("Address3_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_FreightTermsCode = group.Add(new VocabularyKey("Address3_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_Latitude = group.Add(new VocabularyKey("Address3_Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_Line1 = group.Add(new VocabularyKey("Address3_Line1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                this.Address3_Line2 = group.Add(new VocabularyKey("Address3_Line2", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                this.Address3_Line3 = group.Add(new VocabularyKey("Address3_Line3", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                this.Address3_Longitude = group.Add(new VocabularyKey("Address3_Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_Name = group.Add(new VocabularyKey("Address3_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_PostalCode = group.Add(new VocabularyKey("Address3_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_PostOfficeBox = group.Add(new VocabularyKey("Address3_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_PrimaryContactName = group.Add(new VocabularyKey("Address3_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_ShippingMethodCode = group.Add(new VocabularyKey("Address3_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_StateOrProvince = group.Add(new VocabularyKey("Address3_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_Telephone1 = group.Add(new VocabularyKey("Address3_Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Address3_Telephone2 = group.Add(new VocabularyKey("Address3_Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Address3_Telephone3 = group.Add(new VocabularyKey("Address3_Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Address3_UPSZone = group.Add(new VocabularyKey("Address3_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Address3_UTCOffset = group.Add(new VocabularyKey("Address3_UTCOffset", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.PersonName
					, VocabularyKeyVisibility.Visible));
                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OwnerIdDsc = group.Add(new VocabularyKey("OwnerIdDsc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AccountIdName = group.Add(new VocabularyKey("AccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AccountIdYomiName = group.Add(new VocabularyKey("AccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentContactId = group.Add(new VocabularyKey("ParentContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentContactIdName = group.Add(new VocabularyKey("ParentContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentContactIdYomiName = group.Add(new VocabularyKey("ParentContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.DefaultPriceLevelId = group.Add(new VocabularyKey("DefaultPriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CustomerSizeCode = group.Add(new VocabularyKey("CustomerSizeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CustomerTypeCode = group.Add(new VocabularyKey("CustomerTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredContactMethodCode = group.Add(new VocabularyKey("PreferredContactMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.LeadSourceCode = group.Add(new VocabularyKey("LeadSourceCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OriginatingLeadId = group.Add(new VocabularyKey("OriginatingLeadId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PaymentTermsCode = group.Add(new VocabularyKey("PaymentTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ShippingMethodCode = group.Add(new VocabularyKey("ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParticipatesInWorkflow = group.Add(new VocabularyKey("ParticipatesInWorkflow", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.IsBackofficeCustomer = group.Add(new VocabularyKey("IsBackofficeCustomer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Salutation = group.Add(new VocabularyKey("Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.JobTitle = group.Add(new VocabularyKey("JobTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible));
                this.Department = group.Add(new VocabularyKey("Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.NickName = group.Add(new VocabularyKey("NickName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible));
                this.MiddleName = group.Add(new VocabularyKey("MiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible));
                this.Suffix = group.Add(new VocabularyKey("Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.YomiFirstName = group.Add(new VocabularyKey("YomiFirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible));
                this.YomiMiddleName = group.Add(new VocabularyKey("YomiMiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.YomiLastName = group.Add(new VocabularyKey("YomiLastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Anniversary = group.Add(new VocabularyKey("Anniversary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.BirthDate = group.Add(new VocabularyKey("BirthDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                this.GovernmentId = group.Add(new VocabularyKey("GovernmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.YomiFullName = group.Add(new VocabularyKey("YomiFullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                this.GenderCode = group.Add(new VocabularyKey("GenderCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AnnualIncome = group.Add(new VocabularyKey("AnnualIncome", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.HasChildrenCode = group.Add(new VocabularyKey("HasChildrenCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.EducationCode = group.Add(new VocabularyKey("EducationCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.WebSiteUrl = group.Add(new VocabularyKey("WebSiteUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                this.FamilyStatusCode = group.Add(new VocabularyKey("FamilyStatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.FtpSiteUrl = group.Add(new VocabularyKey("FtpSiteUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                this.EMailAddress1 = group.Add(new VocabularyKey("EMailAddress1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.SpousesName = group.Add(new VocabularyKey("SpousesName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AssistantName = group.Add(new VocabularyKey("AssistantName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible));
                this.EMailAddress2 = group.Add(new VocabularyKey("EMailAddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                this.AssistantPhone = group.Add(new VocabularyKey("AssistantPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.EMailAddress3 = group.Add(new VocabularyKey("EMailAddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                this.DoNotPhone = group.Add(new VocabularyKey("DoNotPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ManagerName = group.Add(new VocabularyKey("ManagerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ManagerPhone = group.Add(new VocabularyKey("ManagerPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.DoNotFax = group.Add(new VocabularyKey("DoNotFax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                this.DoNotEMail = group.Add(new VocabularyKey("DoNotEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                this.DoNotPostalMail = group.Add(new VocabularyKey("DoNotPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                this.DoNotBulkEMail = group.Add(new VocabularyKey("DoNotBulkEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                this.DoNotBulkPostalMail = group.Add(new VocabularyKey("DoNotBulkPostalMail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AccountRoleCode = group.Add(new VocabularyKey("AccountRoleCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.TerritoryCode = group.Add(new VocabularyKey("TerritoryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.IsPrivate = group.Add(new VocabularyKey("IsPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                this.CreditLimit = group.Add(new VocabularyKey("CreditLimit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreditOnHold = group.Add(new VocabularyKey("CreditOnHold", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.NumberOfChildren = group.Add(new VocabularyKey("NumberOfChildren", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ChildrensNames = group.Add(new VocabularyKey("ChildrensNames", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.MobilePhone = group.Add(new VocabularyKey("MobilePhone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Pager = group.Add(new VocabularyKey("Pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Telephone1 = group.Add(new VocabularyKey("Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Telephone2 = group.Add(new VocabularyKey("Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Telephone3 = group.Add(new VocabularyKey("Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                this.Aging30 = group.Add(new VocabularyKey("Aging30", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Aging60 = group.Add(new VocabularyKey("Aging60", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Aging90 = group.Add(new VocabularyKey("Aging90", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredSystemUserId = group.Add(new VocabularyKey("PreferredSystemUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredServiceId = group.Add(new VocabularyKey("PreferredServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.MasterId = group.Add(new VocabularyKey("MasterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredAppointmentDayCode = group.Add(new VocabularyKey("PreferredAppointmentDayCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredAppointmentTimeCode = group.Add(new VocabularyKey("PreferredAppointmentTimeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.DoNotSendMM = group.Add(new VocabularyKey("DoNotSendMM", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentCustomerId = group.Add(new VocabularyKey("ParentCustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Merged = group.Add(new VocabularyKey("Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                this.ExternalUserIdentifier = group.Add(new VocabularyKey("ExternalUserIdentifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.PreferredEquipmentId = group.Add(new VocabularyKey("PreferredEquipmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.LastUsedInCampaign = group.Add(new VocabularyKey("LastUsedInCampaign", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentCustomerIdName = group.Add(new VocabularyKey("ParentCustomerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentCustomerIdType = group.Add(new VocabularyKey("ParentCustomerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AnnualIncome_Base = group.Add(new VocabularyKey("AnnualIncome_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreditLimit_Base = group.Add(new VocabularyKey("CreditLimit_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Aging60_Base = group.Add(new VocabularyKey("Aging60_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Aging90_Base = group.Add(new VocabularyKey("Aging90_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Aging30_Base = group.Add(new VocabularyKey("Aging30_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ParentCustomerIdYomiName = group.Add(new VocabularyKey("ParentCustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.IsAutoCreate = group.Add(new VocabularyKey("IsAutoCreate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Business2 = group.Add(new VocabularyKey("Business2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Callback = group.Add(new VocabularyKey("Callback", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Company = group.Add(new VocabularyKey("Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Home2 = group.Add(new VocabularyKey("Home2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_webbrugernavn = group.Add(new VocabularyKey("Ap_webbrugernavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Medlemstype = group.Add(new VocabularyKey("Ap_Medlemstype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_emailvask = group.Add(new VocabularyKey("Ap_emailvask", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Emailugyldig = group.Add(new VocabularyKey("Ap_Emailugyldig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Emailvasketprdato = group.Add(new VocabularyKey("Ap_Emailvasketprdato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Senestedatoforweblogin = group.Add(new VocabularyKey("Ap_Senestedatoforweblogin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_senestelogintype = group.Add(new VocabularyKey("Ap_senestelogintype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_WebUserID = group.Add(new VocabularyKey("Ap_WebUserID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.nn_nndecisionmakerid = group.Add(new VocabularyKey("nn_nndecisionmakerid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.nn_updateprotected = group.Add(new VocabularyKey("nn_updateprotected", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Restance = group.Add(new VocabularyKey("Ap_Restance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Address2MunicipalityCode = group.Add(new VocabularyKey("Ap_Address2MunicipalityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Branchenummer = group.Add(new VocabularyKey("AP_Branchenummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Servicenyhedsbrev = group.Add(new VocabularyKey("Ap_Servicenyhedsbrev", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_testcontact = group.Add(new VocabularyKey("Ap_testcontact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Uddannelsesbaggrund = group.Add(new VocabularyKey("AP_Uddannelsesbaggrund", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Newsletteremail = group.Add(new VocabularyKey("AP_Newsletteremail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Efterloendato = group.Add(new VocabularyKey("Ap_Efterloendato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Efterloen = group.Add(new VocabularyKey("Ap_Efterloen", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Member = group.Add(new VocabularyKey("AP_Member", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Tilbudtildig = group.Add(new VocabularyKey("Ap_Tilbudtildig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Tidligereakasse = group.Add(new VocabularyKey("Ap_Tidligereakasse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Address2CountyCode = group.Add(new VocabularyKey("Ap_Address2CountyCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Pensionistdato = group.Add(new VocabularyKey("Ap_Pensionistdato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Ledigdato = group.Add(new VocabularyKey("Ap_Ledigdato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Medlemsdatasenestopdateret = group.Add(new VocabularyKey("Ap_Medlemsdatasenestopdateret", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Newsletter = group.Add(new VocabularyKey("AP_Newsletter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Lh_Tillgsforsikring = group.Add(new VocabularyKey("Lh_Tillgsforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Uddannelse = group.Add(new VocabularyKey("Ap_Uddannelse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Paneler = group.Add(new VocabularyKey("Ap_Paneler", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Ledig = group.Add(new VocabularyKey("AP_Ledig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Pensionist = group.Add(new VocabularyKey("AP_Pensionist", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Udmeldafnuvaerendeorganisation = group.Add(new VocabularyKey("Ap_Udmeldafnuvaerendeorganisation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_LeadID = group.Add(new VocabularyKey("AP_LeadID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Ansaettelsessted = group.Add(new VocabularyKey("AP_Ansaettelsessted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Indmeldtiakasse = group.Add(new VocabularyKey("AP_Indmeldtiakasse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Branchenavn = group.Add(new VocabularyKey("AP_Branchenavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_NyStilling = group.Add(new VocabularyKey("AP_NyStilling", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Kontonummer = group.Add(new VocabularyKey("Ap_Kontonummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_birthdate = group.Add(new VocabularyKey("Ap_birthdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Efterlonsbidrag = group.Add(new VocabularyKey("AP_Efterlonsbidrag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_SMS = group.Add(new VocabularyKey("Ap_SMS", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Kurserogkonferencer = group.Add(new VocabularyKey("Ap_Kurserogkonferencer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Regnr = group.Add(new VocabularyKey("Ap_Regnr", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Tillidserhverv = group.Add(new VocabularyKey("AP_Tillidserhverv", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_MemberNumber = group.Add(new VocabularyKey("AP_MemberNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Kursist = group.Add(new VocabularyKey("AP_Kursist", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Akasse = group.Add(new VocabularyKey("AP_Akasse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Indmeldtiorganisation = group.Add(new VocabularyKey("AP_Indmeldtiorganisation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Medlemunderoptagelse = group.Add(new VocabularyKey("Ap_Medlemunderoptagelse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Momsregistreretvedoptagelse = group.Add(new VocabularyKey("Ap_Momsregistreretvedoptagelse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Nyhedsbrevsabonnent = group.Add(new VocabularyKey("Ap_Nyhedsbrevsabonnent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Organisation = group.Add(new VocabularyKey("AP_Organisation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_County = group.Add(new VocabularyKey("AP_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Fraflyttetakasse = group.Add(new VocabularyKey("Ap_Fraflyttetakasse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Address2Municipality = group.Add(new VocabularyKey("Ap_Address2Municipality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Sprogkundskaber = group.Add(new VocabularyKey("AP_Sprogkundskaber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Alder = group.Add(new VocabularyKey("AP_Alder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Ap_Udmeldt = group.Add(new VocabularyKey("Ap_Udmeldt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.AP_Tillidsposter = group.Add(new VocabularyKey("AP_Tillidsposter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.Lh_NavisionID = group.Add(new VocabularyKey("Lh_NavisionID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_Doed = group.Add(new VocabularyKey("ap_Doed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_LTDaekning = group.Add(new VocabularyKey("ap_LTDaekning", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_LTKarens = group.Add(new VocabularyKey("ap_LTKarens", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_LTPeriode = group.Add(new VocabularyKey("ap_LTPeriode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_Ulykkesforsikring = group.Add(new VocabularyKey("ap_Ulykkesforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_LTIkraftdato = group.Add(new VocabularyKey("ap_LTIkraftdato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_managementlevel = group.Add(new VocabularyKey("ap_managementlevel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_opdateretfraweb = group.Add(new VocabularyKey("ap_opdateretfraweb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_Privatforsikringer = group.Add(new VocabularyKey("ap_Privatforsikringer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_Sundhedsforsikring = group.Add(new VocabularyKey("ap_Sundhedsforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_Forening = group.Add(new VocabularyKey("ap_Forening", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_KCContactGUID = group.Add(new VocabularyKey("ap_KCContactGUID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_Mobilnummerlandekode = group.Add(new VocabularyKey("ap_Mobilnummerlandekode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.ap_SMSgatewayadresse = group.Add(new VocabularyKey("ap_SMSgatewayadresse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_stillingskode = group.Add(new VocabularyKey("lder_stillingskode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_forbundsenhed = group.Add(new VocabularyKey("lder_forbundsenhed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_lokalafdeling = group.Add(new VocabularyKey("lder_lokalafdeling", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_forening = group.Add(new VocabularyKey("lder_forening", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_address2_kommune = group.Add(new VocabularyKey("lder_address2_kommune", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_address2_landekode_og_land = group.Add(new VocabularyKey("lder_address2_landekode_og_land", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_address2_postnummer_og_by = group.Add(new VocabularyKey("lder_address2_postnummer_og_by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_address2region = group.Add(new VocabularyKey("lder_address2region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_afmeldt_jobcenter = group.Add(new VocabularyKey("lder_afmeldt_jobcenter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_akasse_framelding = group.Add(new VocabularyKey("lder_akasse_framelding", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_akasse_indmelding = group.Add(new VocabularyKey("lder_akasse_indmelding", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_dagpengeretsdato = group.Add(new VocabularyKey("lder_dagpengeretsdato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_digital_kommunikation_fravalgt = group.Add(new VocabularyKey("lder_digital_kommunikation_fravalgt", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_dimittenddato = group.Add(new VocabularyKey("lder_dimittenddato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_efterloensbevis_pr_dato = group.Add(new VocabularyKey("lder_efterloensbevis_pr_dato", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_efterloensordning_pr = group.Add(new VocabularyKey("lder_efterloensordning_pr", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_efterloesnbidrag = group.Add(new VocabularyKey("lder_efterloesnbidrag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_ej_ret_til_juridisk_hjaelp = group.Add(new VocabularyKey("lder_ej_ret_til_juridisk_hjaelp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_foerstkommende_moededato_i_akassen = group.Add(new VocabularyKey("lder_foerstkommende_moededato_i_akassen", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_forsikringsform = group.Add(new VocabularyKey("lder_forsikringsform", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_hemmelig_adresse = group.Add(new VocabularyKey("lder_hemmelig_adresse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_knap_data = group.Add(new VocabularyKey("lder_knap_data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_landekode = group.Add(new VocabularyKey("lder_landekode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_landekode_alternativnummer = group.Add(new VocabularyKey("lder_landekode_alternativnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_landekode_mobilnummer = group.Add(new VocabularyKey("lder_landekode_mobilnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_a_kasse = group.Add(new VocabularyKey("lder_maa_tilbydes_a_kasse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_coaching = group.Add(new VocabularyKey("lder_maa_tilbydes_coaching", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_kurser = group.Add(new VocabularyKey("lder_maa_tilbydes_kurser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_organisation = group.Add(new VocabularyKey("lder_maa_tilbydes_organisation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_outplacement = group.Add(new VocabularyKey("lder_maa_tilbydes_outplacement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_pension = group.Add(new VocabularyKey("lder_maa_tilbydes_pension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_privatforsikring = group.Add(new VocabularyKey("lder_maa_tilbydes_privatforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_sundhedsforsikring = group.Add(new VocabularyKey("lder_maa_tilbydes_sundhedsforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_tillaegsforsikring = group.Add(new VocabularyKey("lder_maa_tilbydes_tillaegsforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_maa_tilbydes_ulykkesforsikring = group.Add(new VocabularyKey("lder_maa_tilbydes_ulykkesforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_medlemstype = group.Add(new VocabularyKey("lder_medlemstype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_modulusid = group.Add(new VocabularyKey("lder_modulusid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_senest_tilbudt_coaching = group.Add(new VocabularyKey("lder_senest_tilbudt_coaching", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_senest_tilbudt_kurser = group.Add(new VocabularyKey("lder_senest_tilbudt_kurser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_senest_tilbudt_outplacement = group.Add(new VocabularyKey("lder_senest_tilbudt_outplacement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_senest_tilbudt_pension = group.Add(new VocabularyKey("lder_senest_tilbudt_pension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_senest_tilbudt_privatforsikring = group.Add(new VocabularyKey("lder_senest_tilbudt_privatforsikring", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_tillidshverv = group.Add(new VocabularyKey("lder_tillidshverv", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_tilmeldt_jobcenter = group.Add(new VocabularyKey("lder_tilmeldt_jobcenter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_tilmeldt_jobcenter_ja_nej = group.Add(new VocabularyKey("lder_tilmeldt_jobcenter_ja_nej", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_vaesentlige_bemaerkninger = group.Add(new VocabularyKey("lder_vaesentlige_bemaerkninger", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_ansaettelsesforhold = group.Add(new VocabularyKey("lder_ansaettelsesforhold", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_under_indmeldelse_i_forening = group.Add(new VocabularyKey("lder_under_indmeldelse_i_forening", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_jobcenterafmeldekode = group.Add(new VocabularyKey("lder_jobcenterafmeldekode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_medlemskategori = group.Add(new VocabularyKey("lder_medlemskategori", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_fremtidig_forening = group.Add(new VocabularyKey("lder_fremtidig_forening", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_ej_tilfredshedsmling = group.Add(new VocabularyKey("lder_ej_tilfredshedsmling", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_moedelokation = group.Add(new VocabularyKey("lder_moedelokation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_sprog = group.Add(new VocabularyKey("lder_sprog", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                this.lder_dato_for_seneste_afholdte_cv_samtale = group.Add(new VocabularyKey("lder_dato_for_seneste_afholdte_cv_samtale", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDataAnnotations(k => k.MaxLength(0)));
                this.lder_klipforbrug = group.Add(new VocabularyKey("lder_klipforbrug", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            this.AddMapping(this.GenderCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Gender);
            this.AddMapping(this.FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            this.AddMapping(this.LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            this.AddMapping(this.MobilePhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            this.AddMapping(this.EMailAddress1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            this.AddMapping(this.Address1_City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCity);
            this.AddMapping(this.Address1_Country, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode);
            this.AddMapping(this.Address1_PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressZipCode);
            this.AddMapping(this.BirthDate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);

            this.AddMapping(this.MiddleName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MiddleName);
            this.AddMapping(this.BirthDate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            this.AddMapping(this.Telephone1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            this.AddMapping(this.JobTitle, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.JobTitle);
            this.AddMapping(this.Address1_Composite, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddress);
            this.AddMapping(this.Salutation, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Title);
            this.AddMapping(this.FullName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FullName);
            this.AddMapping(this.Fax, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Fax);
            this.AddMapping(this.Address1_PostOfficeBox, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressPostOfficeBox);
            this.AddMapping(this.Address1_StateOrProvince, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressState);
        }

        public VocabularyKey lder_fremtidig_foreningName { get; private set; }
        public VocabularyKey EntityImage_URL { get; private set; }
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        public VocabularyKey lder_forbundsenhedName { get; private set; }
        public VocabularyKey lder_lokalafdelingName { get; private set; }
        public VocabularyKey CreatedByYomiName { get; private set; }
        public VocabularyKey MasterContactIdYomiName { get; private set; }
        public VocabularyKey lder_jobcenterafmeldekodeName { get; private set; }
        public VocabularyKey PreferredEquipmentIdName { get; private set; }
        public VocabularyKey MasterContactIdName { get; private set; }
        public VocabularyKey OriginatingLeadIdYomiName { get; private set; }
        public VocabularyKey EntityImage_Timestamp { get; private set; }
        public VocabularyKey ModifiedByName { get; private set; }
        public VocabularyKey lder_sprogName { get; private set; }
        public VocabularyKey lder_stillingskodeName { get; private set; }
        public VocabularyKey lder_under_indmeldelse_i_foreningName { get; private set; }
        public VocabularyKey lder_foreningName { get; private set; }
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        public VocabularyKey lder_ansaettelsesforholdName { get; private set; }
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        public VocabularyKey lder_medlemskategoriName { get; private set; }
        public VocabularyKey PreferredServiceIdName { get; private set; }
        public VocabularyKey DefaultPriceLevelIdName { get; private set; }
        public VocabularyKey lder_moedelokationName { get; private set; }
        public VocabularyKey OriginatingLeadIdName { get; private set; }
        public VocabularyKey CreatedByName { get; private set; }
        public VocabularyKey ModifiedByYomiName { get; private set; }
        public VocabularyKey TransactionCurrencyIdName { get; private set; }
        public VocabularyKey PreferredSystemUserIdName { get; private set; }
        public VocabularyKey PreferredSystemUserIdYomiName { get; private set; }
        public VocabularyKey Address1_AddressTypeCode { get; private set; }
        public VocabularyKey Address1_City { get; private set; }
        public VocabularyKey Address1_Composite { get; private set; }
        public VocabularyKey Address1_Country { get; private set; }
        public VocabularyKey Address1_County { get; private set; }
        public VocabularyKey Address1_AddressId { get; private set; }
        public VocabularyKey Address1_Fax { get; private set; }
        public VocabularyKey Address1_FreightTermsCode { get; private set; }
        public VocabularyKey Address1_Latitude { get; private set; }
        public VocabularyKey Address1_Line1 { get; private set; }
        public VocabularyKey Address1_Line2 { get; private set; }
        public VocabularyKey Address1_Line3 { get; private set; }
        public VocabularyKey Address1_Longitude { get; private set; }
        public VocabularyKey Address1_Name { get; private set; }
        public VocabularyKey Address1_PostalCode { get; private set; }
        public VocabularyKey Address1_PostOfficeBox { get; private set; }
        public VocabularyKey Address1_PrimaryContactName { get; private set; }
        public VocabularyKey Address1_ShippingMethodCode { get; private set; }
        public VocabularyKey Address1_StateOrProvince { get; private set; }
        public VocabularyKey Address1_Telephone1 { get; private set; }
        public VocabularyKey Address1_Telephone2 { get; private set; }
        public VocabularyKey Address1_Telephone3 { get; private set; }
        public VocabularyKey Address1_UPSZone { get; private set; }
        public VocabularyKey Address1_UTCOffset { get; private set; }
        public VocabularyKey Address2_AddressTypeCode { get; private set; }
        public VocabularyKey Address2_City { get; private set; }
        public VocabularyKey Address2_Composite { get; private set; }
        public VocabularyKey Address2_Country { get; private set; }
        public VocabularyKey Address2_County { get; private set; }
        public VocabularyKey Address2_AddressId { get; private set; }
        public VocabularyKey Address2_Fax { get; private set; }
        public VocabularyKey Address2_FreightTermsCode { get; private set; }
        public VocabularyKey Address2_Latitude { get; private set; }
        public VocabularyKey Address2_Line1 { get; private set; }
        public VocabularyKey Address2_Line2 { get; private set; }
        public VocabularyKey Address2_Line3 { get; private set; }
        public VocabularyKey Address2_Longitude { get; private set; }
        public VocabularyKey Address2_Name { get; private set; }
        public VocabularyKey Address2_PostalCode { get; private set; }
        public VocabularyKey Address2_PostOfficeBox { get; private set; }
        public VocabularyKey Address2_PrimaryContactName { get; private set; }
        public VocabularyKey Address2_ShippingMethodCode { get; private set; }
        public VocabularyKey Address2_StateOrProvince { get; private set; }
        public VocabularyKey Address2_Telephone1 { get; private set; }
        public VocabularyKey Address2_Telephone2 { get; private set; }
        public VocabularyKey Address2_Telephone3 { get; private set; }
        public VocabularyKey Address2_UPSZone { get; private set; }
        public VocabularyKey Address2_UTCOffset { get; private set; }
        public VocabularyKey Address3_AddressTypeCode { get; private set; }
        public VocabularyKey Address3_City { get; private set; }
        public VocabularyKey Address3_Composite { get; private set; }
        public VocabularyKey Address3_Country { get; private set; }
        public VocabularyKey Address3_County { get; private set; }
        public VocabularyKey Address3_AddressId { get; private set; }
        public VocabularyKey Address3_Fax { get; private set; }
        public VocabularyKey Address3_FreightTermsCode { get; private set; }
        public VocabularyKey Address3_Latitude { get; private set; }
        public VocabularyKey Address3_Line1 { get; private set; }
        public VocabularyKey Address3_Line2 { get; private set; }
        public VocabularyKey Address3_Line3 { get; private set; }
        public VocabularyKey Address3_Longitude { get; private set; }
        public VocabularyKey Address3_Name { get; private set; }
        public VocabularyKey Address3_PostalCode { get; private set; }
        public VocabularyKey Address3_PostOfficeBox { get; private set; }
        public VocabularyKey Address3_PrimaryContactName { get; private set; }
        public VocabularyKey Address3_ShippingMethodCode { get; private set; }
        public VocabularyKey Address3_StateOrProvince { get; private set; }
        public VocabularyKey Address3_Telephone1 { get; private set; }
        public VocabularyKey Address3_Telephone2 { get; private set; }
        public VocabularyKey Address3_Telephone3 { get; private set; }
        public VocabularyKey Address3_UPSZone { get; private set; }
        public VocabularyKey Address3_UTCOffset { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey OwnerIdDsc { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountIdName { get; private set; }
        public VocabularyKey AccountIdYomiName { get; private set; }
        public VocabularyKey ParentContactId { get; private set; }
        public VocabularyKey ParentContactIdName { get; private set; }
        public VocabularyKey ParentContactIdYomiName { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey DefaultPriceLevelId { get; private set; }
        public VocabularyKey CustomerSizeCode { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey OriginatingLeadId { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey PaymentTermsCode { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey IsBackofficeCustomer { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey NickName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey YomiFirstName { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey YomiMiddleName { get; private set; }
        public VocabularyKey YomiLastName { get; private set; }
        public VocabularyKey Anniversary { get; private set; }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey GovernmentId { get; private set; }
        public VocabularyKey YomiFullName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmployeeId { get; private set; }
        public VocabularyKey GenderCode { get; private set; }
        public VocabularyKey AnnualIncome { get; private set; }
        public VocabularyKey HasChildrenCode { get; private set; }
        public VocabularyKey EducationCode { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey FamilyStatusCode { get; private set; }
        public VocabularyKey FtpSiteUrl { get; private set; }
        public VocabularyKey EMailAddress1 { get; private set; }
        public VocabularyKey SpousesName { get; private set; }
        public VocabularyKey AssistantName { get; private set; }
        public VocabularyKey EMailAddress2 { get; private set; }
        public VocabularyKey AssistantPhone { get; private set; }
        public VocabularyKey EMailAddress3 { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey ManagerName { get; private set; }
        public VocabularyKey ManagerPhone { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotBulkEMail { get; private set; }
        public VocabularyKey DoNotBulkPostalMail { get; private set; }
        public VocabularyKey AccountRoleCode { get; private set; }
        public VocabularyKey TerritoryCode { get; private set; }
        public VocabularyKey IsPrivate { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreditOnHold { get; private set; }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey NumberOfChildren { get; private set; }
        public VocabularyKey ChildrensNames { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey PreferredSystemUserId { get; private set; }
        public VocabularyKey PreferredServiceId { get; private set; }
        public VocabularyKey MasterId { get; private set; }
        public VocabularyKey PreferredAppointmentDayCode { get; private set; }
        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }
        public VocabularyKey DoNotSendMM { get; private set; }
        public VocabularyKey ParentCustomerId { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey ExternalUserIdentifier { get; private set; }
        public VocabularyKey SubscriptionId { get; private set; }
        public VocabularyKey PreferredEquipmentId { get; private set; }
        public VocabularyKey LastUsedInCampaign { get; private set; }
        public VocabularyKey ParentCustomerIdName { get; private set; }
        public VocabularyKey ParentCustomerIdType { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey AnnualIncome_Base { get; private set; }
        public VocabularyKey CreditLimit_Base { get; private set; }
        public VocabularyKey Aging60_Base { get; private set; }
        public VocabularyKey Aging90_Base { get; private set; }
        public VocabularyKey Aging30_Base { get; private set; }
        public VocabularyKey ParentCustomerIdYomiName { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey IsAutoCreate { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Business2 { get; private set; }
        public VocabularyKey Callback { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Home2 { get; private set; }
        public VocabularyKey Ap_webbrugernavn { get; private set; }
        public VocabularyKey Ap_Medlemstype { get; private set; }
        public VocabularyKey Ap_emailvask { get; private set; }
        public VocabularyKey Ap_Emailugyldig { get; private set; }
        public VocabularyKey Ap_Emailvasketprdato { get; private set; }
        public VocabularyKey Ap_Senestedatoforweblogin { get; private set; }
        public VocabularyKey Ap_senestelogintype { get; private set; }
        public VocabularyKey Ap_WebUserID { get; private set; }
        public VocabularyKey nn_nndecisionmakerid { get; private set; }
        public VocabularyKey nn_updateprotected { get; private set; }
        public VocabularyKey Ap_Restance { get; private set; }
        public VocabularyKey Ap_Address2MunicipalityCode { get; private set; }
        public VocabularyKey AP_Branchenummer { get; private set; }
        public VocabularyKey Ap_Servicenyhedsbrev { get; private set; }
        public VocabularyKey Ap_testcontact { get; private set; }
        public VocabularyKey AP_Uddannelsesbaggrund { get; private set; }
        public VocabularyKey AP_Newsletteremail { get; private set; }
        public VocabularyKey Ap_Efterloendato { get; private set; }
        public VocabularyKey Ap_Efterloen { get; private set; }
        public VocabularyKey AP_Member { get; private set; }
        public VocabularyKey Ap_Tilbudtildig { get; private set; }
        public VocabularyKey Ap_Tidligereakasse { get; private set; }
        public VocabularyKey Ap_Address2CountyCode { get; private set; }
        public VocabularyKey Ap_Pensionistdato { get; private set; }
        public VocabularyKey Ap_Ledigdato { get; private set; }
        public VocabularyKey Ap_Medlemsdatasenestopdateret { get; private set; }
        public VocabularyKey AP_Newsletter { get; private set; }
        public VocabularyKey Lh_Tillgsforsikring { get; private set; }
        public VocabularyKey Ap_Uddannelse { get; private set; }
        public VocabularyKey Ap_Paneler { get; private set; }
        public VocabularyKey AP_Ledig { get; private set; }
        public VocabularyKey AP_Pensionist { get; private set; }
        public VocabularyKey Ap_Udmeldafnuvaerendeorganisation { get; private set; }
        public VocabularyKey AP_LeadID { get; private set; }
        public VocabularyKey AP_Ansaettelsessted { get; private set; }
        public VocabularyKey AP_Indmeldtiakasse { get; private set; }
        public VocabularyKey AP_Branchenavn { get; private set; }
        public VocabularyKey AP_NyStilling { get; private set; }
        public VocabularyKey Ap_Kontonummer { get; private set; }
        public VocabularyKey Ap_birthdate { get; private set; }
        public VocabularyKey AP_Efterlonsbidrag { get; private set; }
        public VocabularyKey Ap_SMS { get; private set; }
        public VocabularyKey Ap_Kurserogkonferencer { get; private set; }
        public VocabularyKey Ap_Regnr { get; private set; }
        public VocabularyKey AP_Tillidserhverv { get; private set; }
        public VocabularyKey AP_MemberNumber { get; private set; }
        public VocabularyKey AP_Kursist { get; private set; }
        public VocabularyKey AP_Akasse { get; private set; }
        public VocabularyKey AP_Indmeldtiorganisation { get; private set; }
        public VocabularyKey Ap_Medlemunderoptagelse { get; private set; }
        public VocabularyKey Ap_Momsregistreretvedoptagelse { get; private set; }
        public VocabularyKey Ap_Nyhedsbrevsabonnent { get; private set; }
        public VocabularyKey AP_Organisation { get; private set; }
        public VocabularyKey AP_County { get; private set; }
        public VocabularyKey Ap_Fraflyttetakasse { get; private set; }
        public VocabularyKey Ap_Address2Municipality { get; private set; }
        public VocabularyKey AP_Sprogkundskaber { get; private set; }
        public VocabularyKey AP_Alder { get; private set; }
        public VocabularyKey Ap_Udmeldt { get; private set; }
        public VocabularyKey AP_Tillidsposter { get; private set; }
        public VocabularyKey Lh_NavisionID { get; private set; }
        public VocabularyKey ap_Doed { get; private set; }
        public VocabularyKey ap_LTDaekning { get; private set; }
        public VocabularyKey ap_LTKarens { get; private set; }
        public VocabularyKey ap_LTPeriode { get; private set; }
        public VocabularyKey ap_Ulykkesforsikring { get; private set; }
        public VocabularyKey ap_LTIkraftdato { get; private set; }
        public VocabularyKey ap_managementlevel { get; private set; }
        public VocabularyKey ap_opdateretfraweb { get; private set; }
        public VocabularyKey ap_Privatforsikringer { get; private set; }
        public VocabularyKey ap_Sundhedsforsikring { get; private set; }
        public VocabularyKey ap_Forening { get; private set; }
        public VocabularyKey ap_KCContactGUID { get; private set; }
        public VocabularyKey ap_Mobilnummerlandekode { get; private set; }
        public VocabularyKey ap_SMSgatewayadresse { get; private set; }
        public VocabularyKey lder_stillingskode { get; private set; }
        public VocabularyKey lder_forbundsenhed { get; private set; }
        public VocabularyKey lder_lokalafdeling { get; private set; }
        public VocabularyKey lder_forening { get; private set; }
        public VocabularyKey lder_address2_kommune { get; private set; }
        public VocabularyKey lder_address2_landekode_og_land { get; private set; }
        public VocabularyKey lder_address2_postnummer_og_by { get; private set; }
        public VocabularyKey lder_address2region { get; private set; }
        public VocabularyKey lder_afmeldt_jobcenter { get; private set; }
        public VocabularyKey lder_akasse_framelding { get; private set; }
        public VocabularyKey lder_akasse_indmelding { get; private set; }
        public VocabularyKey lder_dagpengeretsdato { get; private set; }
        public VocabularyKey lder_digital_kommunikation_fravalgt { get; private set; }
        public VocabularyKey lder_dimittenddato { get; private set; }
        public VocabularyKey lder_efterloensbevis_pr_dato { get; private set; }
        public VocabularyKey lder_efterloensordning_pr { get; private set; }
        public VocabularyKey lder_efterloesnbidrag { get; private set; }
        public VocabularyKey lder_ej_ret_til_juridisk_hjaelp { get; private set; }
        public VocabularyKey lder_foerstkommende_moededato_i_akassen { get; private set; }
        public VocabularyKey lder_forsikringsform { get; private set; }
        public VocabularyKey lder_hemmelig_adresse { get; private set; }
        public VocabularyKey lder_knap_data { get; private set; }
        public VocabularyKey lder_landekode { get; private set; }
        public VocabularyKey lder_landekode_alternativnummer { get; private set; }
        public VocabularyKey lder_landekode_mobilnummer { get; private set; }
        public VocabularyKey lder_maa_tilbydes_a_kasse { get; private set; }
        public VocabularyKey lder_maa_tilbydes_coaching { get; private set; }
        public VocabularyKey lder_maa_tilbydes_kurser { get; private set; }
        public VocabularyKey lder_maa_tilbydes_organisation { get; private set; }
        public VocabularyKey lder_maa_tilbydes_outplacement { get; private set; }
        public VocabularyKey lder_maa_tilbydes_pension { get; private set; }
        public VocabularyKey lder_maa_tilbydes_privatforsikring { get; private set; }
        public VocabularyKey lder_maa_tilbydes_sundhedsforsikring { get; private set; }
        public VocabularyKey lder_maa_tilbydes_tillaegsforsikring { get; private set; }
        public VocabularyKey lder_maa_tilbydes_ulykkesforsikring { get; private set; }
        public VocabularyKey lder_medlemstype { get; private set; }
        public VocabularyKey lder_modulusid { get; private set; }
        public VocabularyKey lder_senest_tilbudt_coaching { get; private set; }
        public VocabularyKey lder_senest_tilbudt_kurser { get; private set; }
        public VocabularyKey lder_senest_tilbudt_outplacement { get; private set; }
        public VocabularyKey lder_senest_tilbudt_pension { get; private set; }
        public VocabularyKey lder_senest_tilbudt_privatforsikring { get; private set; }
        public VocabularyKey lder_tillidshverv { get; private set; }
        public VocabularyKey lder_tilmeldt_jobcenter { get; private set; }
        public VocabularyKey lder_tilmeldt_jobcenter_ja_nej { get; private set; }
        public VocabularyKey lder_vaesentlige_bemaerkninger { get; private set; }
        public VocabularyKey lder_ansaettelsesforhold { get; private set; }
        public VocabularyKey lder_under_indmeldelse_i_forening { get; private set; }
        public VocabularyKey lder_jobcenterafmeldekode { get; private set; }
        public VocabularyKey lder_medlemskategori { get; private set; }
        public VocabularyKey lder_fremtidig_forening { get; private set; }
        public VocabularyKey lder_ej_tilfredshedsmling { get; private set; }
        public VocabularyKey lder_moedelokation { get; private set; }
        public VocabularyKey lder_sprog { get; private set; }
        public VocabularyKey lder_dato_for_seneste_afholdte_cv_samtale { get; private set; }
        public VocabularyKey lder_klipforbrug { get; private set; }
    }
}
