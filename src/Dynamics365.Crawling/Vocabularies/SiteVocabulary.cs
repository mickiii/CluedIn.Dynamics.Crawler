using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SiteVocabulary : SimpleVocabulary
    {
        public SiteVocabulary()
        {
            VocabularyName = "Dynamics365 Site";
            KeyPrefix = "dynamics365.site";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Site", group =>
            {
                this.Address2_Latitude = group.Add(new VocabularyKey("Address2_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for address 2.")
                    .WithDisplayName("Address 2: Latitude")
                    .ModelProperty("address2_latitude", typeof(double)));

                this.Address1_County = group.Add(new VocabularyKey("Address1_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"County name for address 1.")
                    .WithDisplayName("Address 1: County")
                    .ModelProperty("address1_county", typeof(string)));

                this.Address2_UPSZone = group.Add(new VocabularyKey("Address2_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for address 2.")
                    .WithDisplayName("Address 2: UPS Zone")
                    .ModelProperty("address2_upszone", typeof(string)));

                this.Address1_ShippingMethodCode = group.Add(new VocabularyKey("Address1_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for address 1.")
                    .WithDisplayName("Address 1: Shipping Method")
                    .ModelProperty("address1_shippingmethodcode", typeof(string)));

                this.Address1_AddressId = group.Add(new VocabularyKey("Address1_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 1.")
                    .WithDisplayName("Address 1: ID")
                    .ModelProperty("address1_addressid", typeof(Guid)));

                this.Address2_StateOrProvince = group.Add(new VocabularyKey("Address2_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"State or province for address 2.")
                    .WithDisplayName("Address 2: State/Province")
                    .ModelProperty("address2_stateorprovince", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the site.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Address1_Latitude = group.Add(new VocabularyKey("Address1_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for address 1.")
                    .WithDisplayName("Address 1: Latitude")
                    .ModelProperty("address1_latitude", typeof(double)));

                this.Address1_PostOfficeBox = group.Add(new VocabularyKey("Address1_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Post office box number for address 1.")
                    .WithDisplayName("Address 1: Post Office Box")
                    .ModelProperty("address1_postofficebox", typeof(string)));

                this.Address1_Longitude = group.Add(new VocabularyKey("Address1_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for address 1.")
                    .WithDisplayName("Address 1: Longitude")
                    .ModelProperty("address1_longitude", typeof(double)));

                this.Address1_Telephone2 = group.Add(new VocabularyKey("Address1_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number associated with address 1.")
                    .WithDisplayName("Other Phone")
                    .ModelProperty("address1_telephone2", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"organization_sites")
                    .WithDisplayName("Organization ")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.EMailAddress = group.Add(new VocabularyKey("EMailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Email address for the site.")
                    .WithDisplayName("Email")
                    .ModelProperty("emailaddress", typeof(string)));

                this.Address2_ShippingMethodCode = group.Add(new VocabularyKey("Address2_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for address 2.")
                    .WithDisplayName("Address 2: Shipping Method")
                    .ModelProperty("address2_shippingmethodcode", typeof(string)));

                this.Address1_Country = group.Add(new VocabularyKey("Address1_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Country/region name for address 1.")
                    .WithDisplayName("Country/Region")
                    .ModelProperty("address1_country", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the site.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Address2_AddressId = group.Add(new VocabularyKey("Address2_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 2.")
                    .WithDisplayName("Address 2: ID")
                    .ModelProperty("address2_addressid", typeof(Guid)));

                this.Address1_City = group.Add(new VocabularyKey("Address1_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"City name for address 1.")
                    .WithDisplayName("City")
                    .ModelProperty("address1_city", typeof(string)));

                this.Address2_Line3 = group.Add(new VocabularyKey("Address2_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Third line for entering address 2 information.")
                    .WithDisplayName("Address 2: Street 3")
                    .ModelProperty("address2_line3", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the site was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.SiteId = group.Add(new VocabularyKey("SiteId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the site.")
                    .WithDisplayName("Site")
                    .ModelProperty("siteid", typeof(Guid)));

                this.Address1_Line3 = group.Add(new VocabularyKey("Address1_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Third line for entering address 1 information.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("address1_line3", typeof(string)));

                this.Address1_AddressTypeCode = group.Add(new VocabularyKey("Address1_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for address 1, such as billing, shipping, or primary address.")
                    .WithDisplayName("Address 1: Address Type")
                    .ModelProperty("address1_addresstypecode", typeof(string)));

                this.Address2_Fax = group.Add(new VocabularyKey("Address2_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Fax number for address 2.")
                    .WithDisplayName("Address 2: Fax")
                    .ModelProperty("address2_fax", typeof(string)));

                this.Address1_UTCOffset = group.Add(new VocabularyKey("Address1_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("Address 1: UTC Offset")
                    .ModelProperty("address1_utcoffset", typeof(long)));

                this.Address2_City = group.Add(new VocabularyKey("Address2_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"City name for address 2.")
                    .WithDisplayName("Address 2: City")
                    .ModelProperty("address2_city", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_sitebase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Address2_Telephone3 = group.Add(new VocabularyKey("Address2_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 3")
                    .ModelProperty("address2_telephone3", typeof(string)));

                this.Address2_Line1 = group.Add(new VocabularyKey("Address2_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"First line for entering address 2 information.")
                    .WithDisplayName("Address 2: Street 1")
                    .ModelProperty("address2_line1", typeof(string)));

                this.Address2_Longitude = group.Add(new VocabularyKey("Address2_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for address 2.")
                    .WithDisplayName("Address 2: Longitude")
                    .ModelProperty("address2_longitude", typeof(double)));

                this.Address2_UTCOffset = group.Add(new VocabularyKey("Address2_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("Address 2: UTC Offset")
                    .ModelProperty("address2_utcoffset", typeof(long)));

                this.Address1_UPSZone = group.Add(new VocabularyKey("Address1_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for address 1.")
                    .WithDisplayName("Address 1: UPS Zone")
                    .ModelProperty("address1_upszone", typeof(string)));

                this.Address2_Country = group.Add(new VocabularyKey("Address2_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Country/region name for address 2.")
                    .WithDisplayName("Address 2: Country/Region")
                    .ModelProperty("address2_country", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the site was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.Address2_PostOfficeBox = group.Add(new VocabularyKey("Address2_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Post office box number for address 2.")
                    .WithDisplayName("Address 2: Post Office Box")
                    .ModelProperty("address2_postofficebox", typeof(string)));

                this.Address2_Telephone2 = group.Add(new VocabularyKey("Address2_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 2")
                    .ModelProperty("address2_telephone2", typeof(string)));

                this.Address2_County = group.Add(new VocabularyKey("Address2_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"County name for address 2.")
                    .WithDisplayName("Address 2: County")
                    .ModelProperty("address2_county", typeof(string)));

                this.Address1_PostalCode = group.Add(new VocabularyKey("Address1_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"ZIP Code or postal code for address 1.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("address1_postalcode", typeof(string)));

                this.Address2_Telephone1 = group.Add(new VocabularyKey("Address2_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 1")
                    .ModelProperty("address2_telephone1", typeof(string)));

                this.Address1_Fax = group.Add(new VocabularyKey("Address1_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Fax number for address 1.")
                    .WithDisplayName("Fax")
                    .ModelProperty("address1_fax", typeof(string)));

                this.Address2_AddressTypeCode = group.Add(new VocabularyKey("Address2_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for address 2, such as billing, shipping, or primary address.")
                    .WithDisplayName("Address 2: Address Type")
                    .ModelProperty("address2_addresstypecode", typeof(string)));

                this.Address1_Telephone1 = group.Add(new VocabularyKey("Address1_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First telephone number associated with address 1.")
                    .WithDisplayName("Main Phone")
                    .ModelProperty("address1_telephone1", typeof(string)));

                this.TimeZoneCode = group.Add(new VocabularyKey("TimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Local time zone for the site.")
                    .WithDisplayName("Time Zone")
                    .ModelProperty("timezonecode", typeof(long)));

                this.Address1_Name = group.Add(new VocabularyKey("Address1_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name to enter for address 1.")
                    .WithDisplayName("Address 1: Name")
                    .ModelProperty("address1_name", typeof(string)));

                this.Address1_Telephone3 = group.Add(new VocabularyKey("Address1_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number associated with address 1.")
                    .WithDisplayName("Address 1: Telephone 3")
                    .ModelProperty("address1_telephone3", typeof(string)));

                this.Address2_PostalCode = group.Add(new VocabularyKey("Address2_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"ZIP Code or postal code for address 2.")
                    .WithDisplayName("Address 2: ZIP/Postal Code")
                    .ModelProperty("address2_postalcode", typeof(string)));

                this.Address2_Name = group.Add(new VocabularyKey("Address2_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name to enter for address 2.")
                    .WithDisplayName("Address 2: Name")
                    .ModelProperty("address2_name", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_sitebase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.Address1_Line1 = group.Add(new VocabularyKey("Address1_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"First line for entering address 1 information.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("address1_line1", typeof(string)));

                this.Address2_Line2 = group.Add(new VocabularyKey("Address2_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Second line for entering address 2 information.")
                    .WithDisplayName("Address 2: Street 2")
                    .ModelProperty("address2_line2", typeof(string)));

                this.Address1_Line2 = group.Add(new VocabularyKey("Address1_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Second line for entering address 1 information.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("address1_line2", typeof(string)));

                this.Address1_StateOrProvince = group.Add(new VocabularyKey("Address1_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"State or province for address 1.")
                    .WithDisplayName("State/Province")
                    .ModelProperty("address1_stateorprovince", typeof(string)));

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

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.Address2_ShippingMethodCodeName = group.Add(new VocabularyKey("Address2_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_ShippingMethodCodeName")
                    .ModelProperty("address2_shippingmethodcodename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.Address1_ShippingMethodCodeName = group.Add(new VocabularyKey("Address1_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_ShippingMethodCodeName")
                    .ModelProperty("address1_shippingmethodcodename", typeof(string)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_site_createdonbehalfby")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

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

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_site_modifiedonbehalfby")
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

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey Address2_Latitude { get; private set; }

        public VocabularyKey Address1_County { get; private set; }

        public VocabularyKey Address2_UPSZone { get; private set; }

        public VocabularyKey Address1_ShippingMethodCode { get; private set; }

        public VocabularyKey Address1_AddressId { get; private set; }

        public VocabularyKey Address2_StateOrProvince { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Address1_Latitude { get; private set; }

        public VocabularyKey Address1_PostOfficeBox { get; private set; }

        public VocabularyKey Address1_Longitude { get; private set; }

        public VocabularyKey Address1_Telephone2 { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey EMailAddress { get; private set; }

        public VocabularyKey Address2_ShippingMethodCode { get; private set; }

        public VocabularyKey Address1_Country { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Address2_AddressId { get; private set; }

        public VocabularyKey Address1_City { get; private set; }

        public VocabularyKey Address2_Line3 { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey SiteId { get; private set; }

        public VocabularyKey Address1_Line3 { get; private set; }

        public VocabularyKey Address1_AddressTypeCode { get; private set; }

        public VocabularyKey Address2_Fax { get; private set; }

        public VocabularyKey Address1_UTCOffset { get; private set; }

        public VocabularyKey Address2_City { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Address2_Telephone3 { get; private set; }

        public VocabularyKey Address2_Line1 { get; private set; }

        public VocabularyKey Address2_Longitude { get; private set; }

        public VocabularyKey Address2_UTCOffset { get; private set; }

        public VocabularyKey Address1_UPSZone { get; private set; }

        public VocabularyKey Address2_Country { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey Address2_PostOfficeBox { get; private set; }

        public VocabularyKey Address2_Telephone2 { get; private set; }

        public VocabularyKey Address2_County { get; private set; }

        public VocabularyKey Address1_PostalCode { get; private set; }

        public VocabularyKey Address2_Telephone1 { get; private set; }

        public VocabularyKey Address1_Fax { get; private set; }

        public VocabularyKey Address2_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_Telephone1 { get; private set; }

        public VocabularyKey TimeZoneCode { get; private set; }

        public VocabularyKey Address1_Name { get; private set; }

        public VocabularyKey Address1_Telephone3 { get; private set; }

        public VocabularyKey Address2_PostalCode { get; private set; }

        public VocabularyKey Address2_Name { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey Address1_Line1 { get; private set; }

        public VocabularyKey Address2_Line2 { get; private set; }

        public VocabularyKey Address1_Line2 { get; private set; }

        public VocabularyKey Address1_StateOrProvince { get; private set; }

        public VocabularyKey Address1_AddressTypeCodeName { get; private set; }

        public VocabularyKey Address2_AddressTypeCodeName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey Address2_ShippingMethodCodeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey Address1_ShippingMethodCodeName { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}

