using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SystemUserVocabulary : SimpleVocabulary
    {
        public SystemUserVocabulary()
        {
            VocabularyName = "Dynamics365 SystemUser";
            KeyPrefix = "dynamics365.systemuser";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;

            this.AddGroup("SystemUser", group =>
            {
                this.SystemUserId = group.Add(new VocabularyKey("SystemUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the user.")
                    .WithDisplayName("User")
                    .ModelProperty("systemuserid", typeof(Guid)));

                this.TerritoryId = group.Add(new VocabularyKey("TerritoryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the territory to which the user is assigned.")
                    .WithDisplayName("Territory")
                    .ModelProperty("territoryid", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the user.")
                    .WithDisplayName("Organization ")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the business unit with which the user is associated.")
                    .WithDisplayName("Business Unit")
                    .ModelProperty("businessunitid", typeof(string)));

                this.ParentSystemUserId = group.Add(new VocabularyKey("ParentSystemUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the manager of the user.")
                    .WithDisplayName("Manager")
                    .ModelProperty("parentsystemuserid", typeof(string)));

                this.FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"First name of the user.")
                    .WithDisplayName("First Name")
                    .ModelProperty("firstname", typeof(string)));

                this.Salutation = group.Add(new VocabularyKey("Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Salutation for correspondence with the user.")
                    .WithDisplayName("Salutation")
                    .ModelProperty("salutation", typeof(string)));

                this.MiddleName = group.Add(new VocabularyKey("MiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Middle name of the user.")
                    .WithDisplayName("Middle Name")
                    .ModelProperty("middlename", typeof(string)));

                this.LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"Last name of the user.")
                    .WithDisplayName("Last Name")
                    .ModelProperty("lastname", typeof(string)));

                this.PersonalEMailAddress = group.Add(new VocabularyKey("PersonalEMailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Personal email address of the user.")
                    .WithDisplayName("Email 2")
                    .ModelProperty("personalemailaddress", typeof(string)));

                this.FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"Full name of the user.")
                    .WithDisplayName("Full Name")
                    .ModelProperty("fullname", typeof(string)));

                this.NickName = group.Add(new VocabularyKey("NickName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Nickname of the user.")
                    .WithDisplayName("Nickname")
                    .ModelProperty("nickname", typeof(string)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"Title of the user.")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.InternalEMailAddress = group.Add(new VocabularyKey("InternalEMailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Internal email address for the user.")
                    .WithDisplayName("Primary Email")
                    .ModelProperty("internalemailaddress", typeof(string)));

                this.JobTitle = group.Add(new VocabularyKey("JobTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Job title of the user.")
                    .WithDisplayName("Job Title")
                    .ModelProperty("jobtitle", typeof(string)));

                this.MobileAlertEMail = group.Add(new VocabularyKey("MobileAlertEMail", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Mobile alert email address for the user.")
                    .WithDisplayName("Mobile Alert Email")
                    .ModelProperty("mobilealertemail", typeof(string)));

                this.PreferredEmailCode = group.Add(new VocabularyKey("PreferredEmailCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Preferred email address for the user.")
                    .WithDisplayName("Preferred Email")
                    .ModelProperty("preferredemailcode", typeof(string)));

                this.HomePhone = group.Add(new VocabularyKey("HomePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Home phone number for the user.")
                    .WithDisplayName("Home Phone")
                    .ModelProperty("homephone", typeof(string)));

                this.MobilePhone = group.Add(new VocabularyKey("MobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"Mobile phone number for the user.")
                    .WithDisplayName("Mobile Phone")
                    .ModelProperty("mobilephone", typeof(string)));

                this.PreferredPhoneCode = group.Add(new VocabularyKey("PreferredPhoneCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Preferred phone number for the user.")
                    .WithDisplayName("Preferred Phone")
                    .ModelProperty("preferredphonecode", typeof(string)));

                this.PreferredAddressCode = group.Add(new VocabularyKey("PreferredAddressCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Preferred address for the user.")
                    .WithDisplayName("Preferred Address")
                    .ModelProperty("preferredaddresscode", typeof(string)));

                this.PhotoUrl = group.Add(new VocabularyKey("PhotoUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"URL for the Website on which a photo of the user is located.")
                    .WithDisplayName("Photo URL")
                    .ModelProperty("photourl", typeof(string)));

                this.DomainName = group.Add(new VocabularyKey("DomainName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Active Directory domain of which the user is a member.")
                    .WithDisplayName("User Name")
                    .ModelProperty("domainname", typeof(string)));

                this.PassportLo = group.Add(new VocabularyKey("PassportLo", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Passport Lo")
                    .ModelProperty("passportlo", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the user was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.PassportHi = group.Add(new VocabularyKey("PassportHi", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Passport Hi")
                    .ModelProperty("passporthi", typeof(long)));

                this.DisabledReason = group.Add(new VocabularyKey("DisabledReason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"Reason for disabling the user.")
                    .WithDisplayName("Disabled Reason")
                    .ModelProperty("disabledreason", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the user was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the user.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Employee identifier for the user.")
                    .WithDisplayName("Employee")
                    .ModelProperty("employeeid", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the user.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.IsDisabled = group.Add(new VocabularyKey("IsDisabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the user is enabled.")
                    .WithDisplayName("Status")
                    .ModelProperty("isdisabled", typeof(bool)));

                this.GovernmentId = group.Add(new VocabularyKey("GovernmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Government identifier for the user.")
                    .WithDisplayName("Government")
                    .ModelProperty("governmentid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the user.")
                    .WithDisplayName("Version number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ParentSystemUserIdName = group.Add(new VocabularyKey("ParentSystemUserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentSystemUserIdName")
                    .ModelProperty("parentsystemuseridname", typeof(string)));

                this.TerritoryIdName = group.Add(new VocabularyKey("TerritoryIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TerritoryIdName")
                    .ModelProperty("territoryidname", typeof(string)));

                this.Address1_AddressId = group.Add(new VocabularyKey("Address1_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 1.")
                    .WithDisplayName("Address 1: ID")
                    .ModelProperty("address1_addressid", typeof(Guid)));

                this.Address1_AddressTypeCode = group.Add(new VocabularyKey("Address1_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for address 1, such as billing, shipping, or primary address.")
                    .WithDisplayName("Address 1: Address Type")
                    .ModelProperty("address1_addresstypecode", typeof(string)));

                this.Address1_Name = group.Add(new VocabularyKey("Address1_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name to enter for address 1.")
                    .WithDisplayName("Address 1: Name")
                    .ModelProperty("address1_name", typeof(string)));

                this.Address1_Line1 = group.Add(new VocabularyKey("Address1_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"First line for entering address 1 information.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("address1_line1", typeof(string)));

                this.Address1_Line2 = group.Add(new VocabularyKey("Address1_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Second line for entering address 1 information.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("address1_line2", typeof(string)));

                this.Address1_Line3 = group.Add(new VocabularyKey("Address1_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Third line for entering address 1 information.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("address1_line3", typeof(string)));

                this.Address1_City = group.Add(new VocabularyKey("Address1_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"City name for address 1.")
                    .WithDisplayName("City")
                    .ModelProperty("address1_city", typeof(string)));

                this.Address1_StateOrProvince = group.Add(new VocabularyKey("Address1_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"State or province for address 1.")
                    .WithDisplayName("State/Province")
                    .ModelProperty("address1_stateorprovince", typeof(string)));

                this.Address1_County = group.Add(new VocabularyKey("Address1_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"County name for address 1.")
                    .WithDisplayName("Address 1: County")
                    .ModelProperty("address1_county", typeof(string)));

                this.Address1_Country = group.Add(new VocabularyKey("Address1_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"Country/region name in address 1.")
                    .WithDisplayName("Country/Region")
                    .ModelProperty("address1_country", typeof(string)));

                this.Address1_PostOfficeBox = group.Add(new VocabularyKey("Address1_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(40))
                    .WithDescription(@"Post office box number for address 1.")
                    .WithDisplayName("Address 1: Post Office Box")
                    .ModelProperty("address1_postofficebox", typeof(string)));

                this.Address1_PostalCode = group.Add(new VocabularyKey("Address1_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(40))
                    .WithDescription(@"ZIP Code or postal code for address 1.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("address1_postalcode", typeof(string)));

                this.Address1_UTCOffset = group.Add(new VocabularyKey("Address1_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("Address 1: UTC Offset")
                    .ModelProperty("address1_utcoffset", typeof(long)));

                this.Address1_UPSZone = group.Add(new VocabularyKey("Address1_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for address 1.")
                    .WithDisplayName("Address 1: UPS Zone")
                    .ModelProperty("address1_upszone", typeof(string)));

                this.Address1_Latitude = group.Add(new VocabularyKey("Address1_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for address 1.")
                    .WithDisplayName("Address 1: Latitude")
                    .ModelProperty("address1_latitude", typeof(double)));

                this.Address1_Telephone1 = group.Add(new VocabularyKey("Address1_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"First telephone number associated with address 1.")
                    .WithDisplayName("Main Phone")
                    .ModelProperty("address1_telephone1", typeof(string)));

                this.Address1_Longitude = group.Add(new VocabularyKey("Address1_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for address 1.")
                    .WithDisplayName("Address 1: Longitude")
                    .ModelProperty("address1_longitude", typeof(double)));

                this.Address1_ShippingMethodCode = group.Add(new VocabularyKey("Address1_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for address 1.")
                    .WithDisplayName("Address 1: Shipping Method")
                    .ModelProperty("address1_shippingmethodcode", typeof(string)));

                this.Address1_Telephone2 = group.Add(new VocabularyKey("Address1_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number associated with address 1.")
                    .WithDisplayName("Other Phone")
                    .ModelProperty("address1_telephone2", typeof(string)));

                this.Address1_Telephone3 = group.Add(new VocabularyKey("Address1_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number associated with address 1.")
                    .WithDisplayName("Pager")
                    .ModelProperty("address1_telephone3", typeof(string)));

                this.Address1_Fax = group.Add(new VocabularyKey("Address1_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"Fax number for address 1.")
                    .WithDisplayName("Address 1: Fax")
                    .ModelProperty("address1_fax", typeof(string)));

                this.Address2_AddressId = group.Add(new VocabularyKey("Address2_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 2.")
                    .WithDisplayName("Address 2: ID")
                    .ModelProperty("address2_addressid", typeof(Guid)));

                this.Address2_AddressTypeCode = group.Add(new VocabularyKey("Address2_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for address 2, such as billing, shipping, or primary address.")
                    .WithDisplayName("Address 2: Address Type")
                    .ModelProperty("address2_addresstypecode", typeof(string)));

                this.Address2_Name = group.Add(new VocabularyKey("Address2_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name to enter for address 2.")
                    .WithDisplayName("Address 2: Name")
                    .ModelProperty("address2_name", typeof(string)));

                this.Address2_Line1 = group.Add(new VocabularyKey("Address2_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"First line for entering address 2 information.")
                    .WithDisplayName("Other Street 1")
                    .ModelProperty("address2_line1", typeof(string)));

                this.Address2_Line2 = group.Add(new VocabularyKey("Address2_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Second line for entering address 2 information.")
                    .WithDisplayName("Other Street 2")
                    .ModelProperty("address2_line2", typeof(string)));

                this.Address2_Line3 = group.Add(new VocabularyKey("Address2_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Third line for entering address 2 information.")
                    .WithDisplayName("Other Street 3")
                    .ModelProperty("address2_line3", typeof(string)));

                this.Address2_City = group.Add(new VocabularyKey("Address2_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"City name for address 2.")
                    .WithDisplayName("Other City")
                    .ModelProperty("address2_city", typeof(string)));

                this.Address2_StateOrProvince = group.Add(new VocabularyKey("Address2_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"State or province for address 2.")
                    .WithDisplayName("Other State/Province")
                    .ModelProperty("address2_stateorprovince", typeof(string)));

                this.Address2_County = group.Add(new VocabularyKey("Address2_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"County name for address 2.")
                    .WithDisplayName("Address 2: County")
                    .ModelProperty("address2_county", typeof(string)));

                this.Address2_Country = group.Add(new VocabularyKey("Address2_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"Country/region name in address 2.")
                    .WithDisplayName("Other Country/Region")
                    .ModelProperty("address2_country", typeof(string)));

                this.Address2_PostOfficeBox = group.Add(new VocabularyKey("Address2_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(40))
                    .WithDescription(@"Post office box number for address 2.")
                    .WithDisplayName("Address 2: Post Office Box")
                    .ModelProperty("address2_postofficebox", typeof(string)));

                this.Address2_PostalCode = group.Add(new VocabularyKey("Address2_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(40))
                    .WithDescription(@"ZIP Code or postal code for address 2.")
                    .WithDisplayName("Other ZIP/Postal Code")
                    .ModelProperty("address2_postalcode", typeof(string)));

                this.Address2_UTCOffset = group.Add(new VocabularyKey("Address2_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("Address 2: UTC Offset")
                    .ModelProperty("address2_utcoffset", typeof(long)));

                this.Address2_UPSZone = group.Add(new VocabularyKey("Address2_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for address 2.")
                    .WithDisplayName("Address 2: UPS Zone")
                    .ModelProperty("address2_upszone", typeof(string)));

                this.Address2_Latitude = group.Add(new VocabularyKey("Address2_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for address 2.")
                    .WithDisplayName("Address 2: Latitude")
                    .ModelProperty("address2_latitude", typeof(double)));

                this.Address2_Telephone1 = group.Add(new VocabularyKey("Address2_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 1")
                    .ModelProperty("address2_telephone1", typeof(string)));

                this.Address2_Longitude = group.Add(new VocabularyKey("Address2_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for address 2.")
                    .WithDisplayName("Address 2: Longitude")
                    .ModelProperty("address2_longitude", typeof(double)));

                this.Address2_ShippingMethodCode = group.Add(new VocabularyKey("Address2_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for address 2.")
                    .WithDisplayName("Address 2: Shipping Method")
                    .ModelProperty("address2_shippingmethodcode", typeof(string)));

                this.Address2_Telephone2 = group.Add(new VocabularyKey("Address2_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 2")
                    .ModelProperty("address2_telephone2", typeof(string)));

                this.Address2_Telephone3 = group.Add(new VocabularyKey("Address2_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 3")
                    .ModelProperty("address2_telephone3", typeof(string)));

                this.Address2_Fax = group.Add(new VocabularyKey("Address2_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Fax number for address 2.")
                    .WithDisplayName("Address 2: Fax")
                    .ModelProperty("address2_fax", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.BusinessUnitIdName = group.Add(new VocabularyKey("BusinessUnitIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BusinessUnitIdName")
                    .ModelProperty("businessunitidname", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.IsDisabledName = group.Add(new VocabularyKey("IsDisabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDisabledName")
                    .ModelProperty("isdisabledname", typeof(string)));

                this.PreferredPhoneCodeName = group.Add(new VocabularyKey("PreferredPhoneCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredPhoneCodeName")
                    .ModelProperty("preferredphonecodename", typeof(string)));

                this.PreferredEmailCodeName = group.Add(new VocabularyKey("PreferredEmailCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredEmailCodeName")
                    .ModelProperty("preferredemailcodename", typeof(string)));

                this.PreferredAddressCodeName = group.Add(new VocabularyKey("PreferredAddressCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredAddressCodeName")
                    .ModelProperty("preferredaddresscodename", typeof(string)));

                this.Address2_ShippingMethodCodeName = group.Add(new VocabularyKey("Address2_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_ShippingMethodCodeName")
                    .ModelProperty("address2_shippingmethodcodename", typeof(string)));

                this.Address1_AddressTypeCodeName = group.Add(new VocabularyKey("Address1_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_AddressTypeCodeName")
                    .ModelProperty("address1_addresstypecodename", typeof(string)));

                this.Address2_AddressTypeCodeName = group.Add(new VocabularyKey("Address2_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_AddressTypeCodeName")
                    .ModelProperty("address2_addresstypecodename", typeof(string)));

                this.Address1_ShippingMethodCodeName = group.Add(new VocabularyKey("Address1_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_ShippingMethodCodeName")
                    .ModelProperty("address1_shippingmethodcodename", typeof(string)));

                this.Skills = group.Add(new VocabularyKey("Skills", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Skill set of the user.")
                    .WithDisplayName("Skills")
                    .ModelProperty("skills", typeof(string)));

                this.DisplayInServiceViews = group.Add(new VocabularyKey("DisplayInServiceViews", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether to display the user in service views.")
                    .WithDisplayName("Display in Service Views")
                    .ModelProperty("displayinserviceviews", typeof(bool)));

                this.CalendarId = group.Add(new VocabularyKey("CalendarId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Fiscal calendar associated with the user.")
                    .WithDisplayName("Calendar")
                    .ModelProperty("calendarid", typeof(string)));

                this.ActiveDirectoryGuid = group.Add(new VocabularyKey("ActiveDirectoryGuid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Active Directory object GUID for the system user.")
                    .WithDisplayName("Active Directory Guid")
                    .ModelProperty("activedirectoryguid", typeof(Guid)));

                this.SetupUser = group.Add(new VocabularyKey("SetupUser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Check if user is a setup user.")
                    .WithDisplayName("Restricted Access Mode")
                    .ModelProperty("setupuser", typeof(bool)));

                this.SiteId = group.Add(new VocabularyKey("SiteId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Site at which the user is located.")
                    .WithDisplayName("Site")
                    .ModelProperty("siteid", typeof(string)));

                this.SiteIdName = group.Add(new VocabularyKey("SiteIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SiteIdName")
                    .ModelProperty("siteidname", typeof(string)));

                this.SetupUserName = group.Add(new VocabularyKey("SetupUserName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SetupUserName")
                    .ModelProperty("setupusername", typeof(string)));

                this.DisplayInServiceViewsName = group.Add(new VocabularyKey("DisplayInServiceViewsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DisplayInServiceViewsName")
                    .ModelProperty("displayinserviceviewsname", typeof(string)));

                this.WindowsLiveID = group.Add(new VocabularyKey("WindowsLiveID", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Windows Live ID")
                    .WithDisplayName("Windows Live ID")
                    .ModelProperty("windowsliveid", typeof(string)));

                this.IncomingEmailDeliveryMethod = group.Add(new VocabularyKey("IncomingEmailDeliveryMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Incoming email delivery method for the user.")
                    .WithDisplayName("Incoming Email Delivery Method")
                    .ModelProperty("incomingemaildeliverymethod", typeof(string)));

                this.OutgoingEmailDeliveryMethod = group.Add(new VocabularyKey("OutgoingEmailDeliveryMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Outgoing email delivery method for the user.")
                    .WithDisplayName("Outgoing Email Delivery Method")
                    .ModelProperty("outgoingemaildeliverymethod", typeof(string)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.AccessMode = group.Add(new VocabularyKey("AccessMode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of user.")
                    .WithDisplayName("Access Mode")
                    .ModelProperty("accessmode", typeof(string)));

                this.InviteStatusCode = group.Add(new VocabularyKey("InviteStatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"User invitation status.")
                    .WithDisplayName("Invitation Status")
                    .ModelProperty("invitestatuscode", typeof(string)));

                this.IsActiveDirectoryUser = group.Add(new VocabularyKey("IsActiveDirectoryUser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the user is an AD user.")
                    .WithDisplayName("Is Active Directory User")
                    .ModelProperty("isactivedirectoryuser", typeof(bool)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.AccessModeName = group.Add(new VocabularyKey("AccessModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccessModeName")
                    .ModelProperty("accessmodename", typeof(string)));

                this.IncomingEmailDeliveryMethodName = group.Add(new VocabularyKey("IncomingEmailDeliveryMethodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingEmailDeliveryMethodName")
                    .ModelProperty("incomingemaildeliverymethodname", typeof(string)));

                this.OutgoingEmailDeliveryMethodName = group.Add(new VocabularyKey("OutgoingEmailDeliveryMethodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingEmailDeliveryMethodName")
                    .ModelProperty("outgoingemaildeliverymethodname", typeof(string)));

                this.InviteStatusCodeName = group.Add(new VocabularyKey("InviteStatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InviteStatusCodeName")
                    .ModelProperty("invitestatuscodename", typeof(string)));

                this.ParentSystemUserIdYomiName = group.Add(new VocabularyKey("ParentSystemUserIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentSystemUserIdYomiName")
                    .ModelProperty("parentsystemuseridyominame", typeof(string)));

                this.YomiFullName = group.Add(new VocabularyKey("YomiFullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.")
                    .WithDisplayName("Yomi Full Name")
                    .ModelProperty("yomifullname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.YomiLastName = group.Add(new VocabularyKey("YomiLastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.")
                    .WithDisplayName("Yomi Last Name")
                    .ModelProperty("yomilastname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.YomiMiddleName = group.Add(new VocabularyKey("YomiMiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.")
                    .WithDisplayName("Yomi Middle Name")
                    .ModelProperty("yomimiddlename", typeof(string)));

                this.YomiFirstName = group.Add(new VocabularyKey("YomiFirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.")
                    .WithDisplayName("Yomi First Name")
                    .ModelProperty("yomifirstname", typeof(string)));

                this.IsIntegrationUser = group.Add(new VocabularyKey("IsIntegrationUser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Check if user is an integration user.")
                    .WithDisplayName("Integration user mode")
                    .ModelProperty("isintegrationuser", typeof(bool)));

                this.DefaultFiltersPopulated = group.Add(new VocabularyKey("DefaultFiltersPopulated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates if default outlook filters have been populated.")
                    .WithDisplayName("Default Filters Populated")
                    .ModelProperty("defaultfilterspopulated", typeof(bool)));

                this.IsIntegrationUserName = group.Add(new VocabularyKey("IsIntegrationUserName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsIntegrationUserName")
                    .ModelProperty("isintegrationusername", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the systemuser.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.QueueId = group.Add(new VocabularyKey("QueueId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the default queue for the user.")
                    .WithDisplayName("Default Queue")
                    .ModelProperty("queueid", typeof(string)));

                this.QueueIdName = group.Add(new VocabularyKey("QueueIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("QueueIdName")
                    .ModelProperty("queueidname", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the systemuser.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.EmailRouterAccessApproval = group.Add(new VocabularyKey("EmailRouterAccessApproval", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the status of the primary email address.")
                    .WithDisplayName("Primary Email Status")
                    .ModelProperty("emailrouteraccessapproval", typeof(string)));

                this.EmailRouterAccessApprovalName = group.Add(new VocabularyKey("EmailRouterAccessApprovalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EmailRouterAccessApprovalName")
                    .ModelProperty("emailrouteraccessapprovalname", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the currency associated with the systemuser.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the systemuser with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.CALType = group.Add(new VocabularyKey("CALType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"License type of user.")
                    .WithDisplayName("License Type")
                    .ModelProperty("caltype", typeof(string)));

                this.CALTypeName = group.Add(new VocabularyKey("CALTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CALTypeName")
                    .ModelProperty("caltypename", typeof(string)));

                this.IsLicensed = group.Add(new VocabularyKey("IsLicensed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the user is licensed.")
                    .WithDisplayName("User Licensed")
                    .ModelProperty("islicensed", typeof(bool)));

                this.IsSyncWithDirectory = group.Add(new VocabularyKey("IsSyncWithDirectory", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the user is synced with the directory.")
                    .WithDisplayName("User Synced")
                    .ModelProperty("issyncwithdirectory", typeof(bool)));

                this.YammerEmailAddress = group.Add(new VocabularyKey("YammerEmailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"User's Yammer login email address")
                    .WithDisplayName("Yammer Email")
                    .ModelProperty("yammeremailaddress", typeof(string)));

                this.DefaultMailboxName = group.Add(new VocabularyKey("DefaultMailboxName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("DefaultMailboxName")
                    .ModelProperty("defaultmailboxname", typeof(string)));

                this.YammerUserId = group.Add(new VocabularyKey("YammerUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"User's Yammer ID")
                    .WithDisplayName("Yammer User ID")
                    .ModelProperty("yammeruserid", typeof(string)));

                this.DefaultMailbox = group.Add(new VocabularyKey("DefaultMailbox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the mailbox associated with this user.")
                    .WithDisplayName("Mailbox")
                    .ModelProperty("defaultmailbox", typeof(string)));

                this.UserLicenseType = group.Add(new VocabularyKey("UserLicenseType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the type of user license.")
                    .WithDisplayName("User License Type")
                    .ModelProperty("userlicensetype", typeof(long)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default image for the record.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.Address2_Composite = group.Add(new VocabularyKey("Address2_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete secondary address.")
                    .WithDisplayName("Other Address")
                    .ModelProperty("address2_composite", typeof(string)));

                this.Address1_Composite = group.Add(new VocabularyKey("Address1_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete primary address.")
                    .WithDisplayName("Address")
                    .ModelProperty("address1_composite", typeof(string)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.IsEmailAddressApprovedByO365Admin = group.Add(new VocabularyKey("IsEmailAddressApprovedByO365Admin", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the status of approval of the email address by O365 Admin.")
                    .WithDisplayName("Email Address O365 Admin Approval Status")
                    .ModelProperty("isemailaddressapprovedbyo365admin", typeof(bool)));

                this.PositionId = group.Add(new VocabularyKey("PositionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"User's position in hierarchical security model.")
                    .WithDisplayName("Functional Department")
                    .ModelProperty("positionid", typeof(string)));

                this.PositionIdName = group.Add(new VocabularyKey("PositionIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PositionIdName")
                    .ModelProperty("positionidname", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.SharePointEmailAddress = group.Add(new VocabularyKey("SharePointEmailAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"SharePoint Work Email Address")
                    .WithDisplayName("SharePoint Email Address")
                    .ModelProperty("sharepointemailaddress", typeof(string)));

                this.MobileOfflineProfileId = group.Add(new VocabularyKey("MobileOfflineProfileId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Items contained with a particular SystemUser.")
                    .WithDisplayName("Mobile Offline Profile")
                    .ModelProperty("mobileofflineprofileid", typeof(string)));

                this.MobileOfflineProfileIdName = group.Add(new VocabularyKey("MobileOfflineProfileIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MobileOfflineProfileIdName")
                    .ModelProperty("mobileofflineprofileidname", typeof(string)));

                this.DefaultOdbFolderName = group.Add(new VocabularyKey("DefaultOdbFolderName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"Type a default folder name for the user's OneDrive For Business location.")
                    .WithDisplayName("Default OneDrive for Business Folder Name")
                    .ModelProperty("defaultodbfoldername", typeof(string)));

                this.ApplicationId = group.Add(new VocabularyKey("ApplicationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The identifier for the application. This is used to access data in another application.")
                    .WithDisplayName("Application ID")
                    .ModelProperty("applicationid", typeof(Guid)));

                this.ApplicationIdUri = group.Add(new VocabularyKey("ApplicationIdUri", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1024))
                    .WithDescription(@"The URI used as a unique logical identifier for the external app. This can be used to validate the application.")
                    .WithDisplayName("Application ID URI")
                    .ModelProperty("applicationiduri", typeof(string)));

                this.AzureActiveDirectoryObjectId = group.Add(new VocabularyKey("AzureActiveDirectoryObjectId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"This is the application directory object Id.")
                    .WithDisplayName("Azure AD Object ID")
                    .ModelProperty("azureactivedirectoryobjectid", typeof(Guid)));

                this.IdentityId = group.Add(new VocabularyKey("IdentityId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Unique user identity id")
                    .ModelProperty("identityid", typeof(long)));

                this.LatestUpdateTime = group.Add(new VocabularyKey("LatestUpdateTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time stamp of the latest update for the user")
                    .WithDisplayName("Latest User Update Time")
                    .ModelProperty("latestupdatetime", typeof(DateTime)));

                this.UserPuid = group.Add(new VocabularyKey("UserPuid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@" User PUID User Identifiable Information")
                    .WithDisplayName("User PUID")
                    .ModelProperty("userpuid", typeof(string)));

                this.IsLicensedName = group.Add(new VocabularyKey("IsLicensedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsLicensedName")
                    .ModelProperty("islicensedname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SystemUserId { get; private set; }

        public VocabularyKey TerritoryId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey ParentSystemUserId { get; private set; }

        public VocabularyKey FirstName { get; private set; }

        public VocabularyKey Salutation { get; private set; }

        public VocabularyKey MiddleName { get; private set; }

        public VocabularyKey LastName { get; private set; }

        public VocabularyKey PersonalEMailAddress { get; private set; }

        public VocabularyKey FullName { get; private set; }

        public VocabularyKey NickName { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey InternalEMailAddress { get; private set; }

        public VocabularyKey JobTitle { get; private set; }

        public VocabularyKey MobileAlertEMail { get; private set; }

        public VocabularyKey PreferredEmailCode { get; private set; }

        public VocabularyKey HomePhone { get; private set; }

        public VocabularyKey MobilePhone { get; private set; }

        public VocabularyKey PreferredPhoneCode { get; private set; }

        public VocabularyKey PreferredAddressCode { get; private set; }

        public VocabularyKey PhotoUrl { get; private set; }

        public VocabularyKey DomainName { get; private set; }

        public VocabularyKey PassportLo { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey PassportHi { get; private set; }

        public VocabularyKey DisabledReason { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey EmployeeId { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey IsDisabled { get; private set; }

        public VocabularyKey GovernmentId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ParentSystemUserIdName { get; private set; }

        public VocabularyKey TerritoryIdName { get; private set; }

        public VocabularyKey Address1_AddressId { get; private set; }

        public VocabularyKey Address1_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_Name { get; private set; }

        public VocabularyKey Address1_Line1 { get; private set; }

        public VocabularyKey Address1_Line2 { get; private set; }

        public VocabularyKey Address1_Line3 { get; private set; }

        public VocabularyKey Address1_City { get; private set; }

        public VocabularyKey Address1_StateOrProvince { get; private set; }

        public VocabularyKey Address1_County { get; private set; }

        public VocabularyKey Address1_Country { get; private set; }

        public VocabularyKey Address1_PostOfficeBox { get; private set; }

        public VocabularyKey Address1_PostalCode { get; private set; }

        public VocabularyKey Address1_UTCOffset { get; private set; }

        public VocabularyKey Address1_UPSZone { get; private set; }

        public VocabularyKey Address1_Latitude { get; private set; }

        public VocabularyKey Address1_Telephone1 { get; private set; }

        public VocabularyKey Address1_Longitude { get; private set; }

        public VocabularyKey Address1_ShippingMethodCode { get; private set; }

        public VocabularyKey Address1_Telephone2 { get; private set; }

        public VocabularyKey Address1_Telephone3 { get; private set; }

        public VocabularyKey Address1_Fax { get; private set; }

        public VocabularyKey Address2_AddressId { get; private set; }

        public VocabularyKey Address2_AddressTypeCode { get; private set; }

        public VocabularyKey Address2_Name { get; private set; }

        public VocabularyKey Address2_Line1 { get; private set; }

        public VocabularyKey Address2_Line2 { get; private set; }

        public VocabularyKey Address2_Line3 { get; private set; }

        public VocabularyKey Address2_City { get; private set; }

        public VocabularyKey Address2_StateOrProvince { get; private set; }

        public VocabularyKey Address2_County { get; private set; }

        public VocabularyKey Address2_Country { get; private set; }

        public VocabularyKey Address2_PostOfficeBox { get; private set; }

        public VocabularyKey Address2_PostalCode { get; private set; }

        public VocabularyKey Address2_UTCOffset { get; private set; }

        public VocabularyKey Address2_UPSZone { get; private set; }

        public VocabularyKey Address2_Latitude { get; private set; }

        public VocabularyKey Address2_Telephone1 { get; private set; }

        public VocabularyKey Address2_Longitude { get; private set; }

        public VocabularyKey Address2_ShippingMethodCode { get; private set; }

        public VocabularyKey Address2_Telephone2 { get; private set; }

        public VocabularyKey Address2_Telephone3 { get; private set; }

        public VocabularyKey Address2_Fax { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey BusinessUnitIdName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey IsDisabledName { get; private set; }

        public VocabularyKey PreferredPhoneCodeName { get; private set; }

        public VocabularyKey PreferredEmailCodeName { get; private set; }

        public VocabularyKey PreferredAddressCodeName { get; private set; }

        public VocabularyKey Address2_ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address1_AddressTypeCodeName { get; private set; }

        public VocabularyKey Address2_AddressTypeCodeName { get; private set; }

        public VocabularyKey Address1_ShippingMethodCodeName { get; private set; }

        public VocabularyKey Skills { get; private set; }

        public VocabularyKey DisplayInServiceViews { get; private set; }

        public VocabularyKey CalendarId { get; private set; }

        public VocabularyKey ActiveDirectoryGuid { get; private set; }

        public VocabularyKey SetupUser { get; private set; }

        public VocabularyKey SiteId { get; private set; }

        public VocabularyKey SiteIdName { get; private set; }

        public VocabularyKey SetupUserName { get; private set; }

        public VocabularyKey DisplayInServiceViewsName { get; private set; }

        public VocabularyKey WindowsLiveID { get; private set; }

        public VocabularyKey IncomingEmailDeliveryMethod { get; private set; }

        public VocabularyKey OutgoingEmailDeliveryMethod { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey AccessMode { get; private set; }

        public VocabularyKey InviteStatusCode { get; private set; }

        public VocabularyKey IsActiveDirectoryUser { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey AccessModeName { get; private set; }

        public VocabularyKey IncomingEmailDeliveryMethodName { get; private set; }

        public VocabularyKey OutgoingEmailDeliveryMethodName { get; private set; }

        public VocabularyKey InviteStatusCodeName { get; private set; }

        public VocabularyKey ParentSystemUserIdYomiName { get; private set; }

        public VocabularyKey YomiFullName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey YomiLastName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey YomiMiddleName { get; private set; }

        public VocabularyKey YomiFirstName { get; private set; }

        public VocabularyKey IsIntegrationUser { get; private set; }

        public VocabularyKey DefaultFiltersPopulated { get; private set; }

        public VocabularyKey IsIntegrationUserName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey QueueId { get; private set; }

        public VocabularyKey QueueIdName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey EmailRouterAccessApproval { get; private set; }

        public VocabularyKey EmailRouterAccessApprovalName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey CALType { get; private set; }

        public VocabularyKey CALTypeName { get; private set; }

        public VocabularyKey IsLicensed { get; private set; }

        public VocabularyKey IsSyncWithDirectory { get; private set; }

        public VocabularyKey YammerEmailAddress { get; private set; }

        public VocabularyKey DefaultMailboxName { get; private set; }

        public VocabularyKey YammerUserId { get; private set; }

        public VocabularyKey DefaultMailbox { get; private set; }

        public VocabularyKey UserLicenseType { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey Address2_Composite { get; private set; }

        public VocabularyKey Address1_Composite { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey IsEmailAddressApprovedByO365Admin { get; private set; }

        public VocabularyKey PositionId { get; private set; }

        public VocabularyKey PositionIdName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey SharePointEmailAddress { get; private set; }

        public VocabularyKey MobileOfflineProfileId { get; private set; }

        public VocabularyKey MobileOfflineProfileIdName { get; private set; }

        public VocabularyKey DefaultOdbFolderName { get; private set; }

        public VocabularyKey ApplicationId { get; private set; }

        public VocabularyKey ApplicationIdUri { get; private set; }

        public VocabularyKey AzureActiveDirectoryObjectId { get; private set; }

        public VocabularyKey IdentityId { get; private set; }

        public VocabularyKey LatestUpdateTime { get; private set; }

        public VocabularyKey UserPuid { get; private set; }

        public VocabularyKey IsLicensedName { get; private set; }


    }
}

