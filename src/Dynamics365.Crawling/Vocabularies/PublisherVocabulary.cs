using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PublisherVocabulary : SimpleVocabulary
    {
        public PublisherVocabulary()
        {
            VocabularyName = "Dynamics365 Publisher";
            KeyPrefix = "dynamics365.publisher";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Publisher", group =>
            {
                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the publisher.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.Address1_Telephone3 = group.Add(new VocabularyKey("Address1_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number associated with address 1.")
                    .WithDisplayName("Address 1: Telephone 3")
                    .ModelProperty("address1_telephone3", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the solution.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.Address2_Country = group.Add(new VocabularyKey("Address2_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Country/region name for address 2.")
                    .WithDisplayName("Address 2: Country/Region")
                    .ModelProperty("address2_country", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the publisher.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Address1_Telephone2 = group.Add(new VocabularyKey("Address1_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number associated with address 1.")
                    .WithDisplayName("Address 1: Telephone 2")
                    .ModelProperty("address1_telephone2", typeof(string)));

                this.Address2_AddressTypeCode = group.Add(new VocabularyKey("Address2_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for address 2. such as billing, shipping, or primary address.")
                    .WithDisplayName("Address 2: Address Type")
                    .ModelProperty("address2_addresstypecode", typeof(string)));

                this.Address1_AddressTypeCode = group.Add(new VocabularyKey("Address1_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for address 1, such as billing, shipping, or primary address.")
                    .WithDisplayName("Address 1: Address Type")
                    .ModelProperty("address1_addresstypecode", typeof(string)));

                this.Address1_Line3 = group.Add(new VocabularyKey("Address1_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third line for entering address 1 information.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("address1_line3", typeof(string)));

                this.Address2_Name = group.Add(new VocabularyKey("Address2_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name to enter for address 2.")
                    .WithDisplayName("Address 2: Name")
                    .ModelProperty("address2_name", typeof(string)));

                this.Address1_AddressId = group.Add(new VocabularyKey("Address1_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 1.")
                    .WithDisplayName("Address 1: ID")
                    .ModelProperty("address1_addressid", typeof(Guid)));

                this.Address2_AddressId = group.Add(new VocabularyKey("Address2_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 2.")
                    .WithDisplayName("Address 2: ID")
                    .ModelProperty("address2_addressid", typeof(Guid)));

                this.Address1_Latitude = group.Add(new VocabularyKey("Address1_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for address 1.")
                    .WithDisplayName("Address 1: Latitude")
                    .ModelProperty("address1_latitude", typeof(double)));

                this.Address2_County = group.Add(new VocabularyKey("Address2_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"County name for address 2.")
                    .WithDisplayName("Address 2: County")
                    .ModelProperty("address2_county", typeof(string)));

                this.Address1_Country = group.Add(new VocabularyKey("Address1_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Country/region name for address 1.")
                    .WithDisplayName("Country/Region")
                    .ModelProperty("address1_country", typeof(string)));

                this.Address2_City = group.Add(new VocabularyKey("Address2_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"City name for address 2.")
                    .WithDisplayName("Address 2: City")
                    .ModelProperty("address2_city", typeof(string)));

                this.EMailAddress = group.Add(new VocabularyKey("EMailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Email address for the publisher.")
                    .WithDisplayName("Email")
                    .ModelProperty("emailaddress", typeof(string)));

                this.Address1_ShippingMethodCode = group.Add(new VocabularyKey("Address1_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for address 1.")
                    .WithDisplayName("Address 1: Shipping Method")
                    .ModelProperty("address1_shippingmethodcode", typeof(string)));

                this.Address2_Longitude = group.Add(new VocabularyKey("Address2_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for address 2.")
                    .WithDisplayName("Address 2: Longitude")
                    .ModelProperty("address2_longitude", typeof(double)));

                this.Address2_Line2 = group.Add(new VocabularyKey("Address2_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second line for entering address 2 information.")
                    .WithDisplayName("Address 2: Street 2")
                    .ModelProperty("address2_line2", typeof(string)));

                this.Address1_UTCOffset = group.Add(new VocabularyKey("Address1_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("Address 1: UTC Offset")
                    .ModelProperty("address1_utcoffset", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the publisher was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.Address1_County = group.Add(new VocabularyKey("Address1_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"County name for address 1.")
                    .WithDisplayName("Address 1: County")
                    .ModelProperty("address1_county", typeof(string)));

                this.Address1_Fax = group.Add(new VocabularyKey("Address1_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Fax number for address 1.")
                    .WithDisplayName("Address 1: Fax")
                    .ModelProperty("address1_fax", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Address2_UTCOffset = group.Add(new VocabularyKey("Address2_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("Address 2: UTC Offset")
                    .ModelProperty("address2_utcoffset", typeof(long)));

                this.Address1_Name = group.Add(new VocabularyKey("Address1_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name to enter for address 1.")
                    .WithDisplayName("Address 1: Name")
                    .ModelProperty("address1_name", typeof(string)));

                this.Address1_UPSZone = group.Add(new VocabularyKey("Address1_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for address 1.")
                    .WithDisplayName("Address 1: UPS Zone")
                    .ModelProperty("address1_upszone", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the publisher was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.Address1_PostOfficeBox = group.Add(new VocabularyKey("Address1_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Post office box number for address 1.")
                    .WithDisplayName("Address 1: Post Office Box")
                    .ModelProperty("address1_postofficebox", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the publisher.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CustomizationPrefix = group.Add(new VocabularyKey("CustomizationPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8))
                    .WithDescription(@"Prefix used for new entities, attributes, and entity relationships for solutions associated with this publisher.")
                    .WithDisplayName("Prefix")
                    .ModelProperty("customizationprefix", typeof(string)));

                this.Address2_StateOrProvince = group.Add(new VocabularyKey("Address2_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"State or province for address 2.")
                    .WithDisplayName("Address 2: State/Province")
                    .ModelProperty("address2_stateorprovince", typeof(string)));

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

                this.Address2_UPSZone = group.Add(new VocabularyKey("Address2_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for address 2.")
                    .WithDisplayName("Address 2: UPS Zone")
                    .ModelProperty("address2_upszone", typeof(string)));

                this.Address1_Telephone1 = group.Add(new VocabularyKey("Address1_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First telephone number associated with address 1.")
                    .WithDisplayName("Phone")
                    .ModelProperty("address1_telephone1", typeof(string)));

                this.SupportingWebsiteUrl = group.Add(new VocabularyKey("SupportingWebsiteUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"URL for the supporting website of this publisher.")
                    .WithDisplayName("Website")
                    .ModelProperty("supportingwebsiteurl", typeof(string)));

                this.Address1_Longitude = group.Add(new VocabularyKey("Address1_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for address 1.")
                    .WithDisplayName("Address 1: Longitude")
                    .ModelProperty("address1_longitude", typeof(double)));

                this.Address2_PostOfficeBox = group.Add(new VocabularyKey("Address2_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Post office box number for address 2.")
                    .WithDisplayName("Address 2: Post Office Box")
                    .ModelProperty("address2_postofficebox", typeof(string)));

                this.Address2_Latitude = group.Add(new VocabularyKey("Address2_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for address 2.")
                    .WithDisplayName("Address 2: Latitude")
                    .ModelProperty("address2_latitude", typeof(double)));

                this.Address2_Line3 = group.Add(new VocabularyKey("Address2_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third line for entering address 2 information.")
                    .WithDisplayName("Address 2: Street 3")
                    .ModelProperty("address2_line3", typeof(string)));

                this.Address2_Telephone1 = group.Add(new VocabularyKey("Address2_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 1")
                    .ModelProperty("address2_telephone1", typeof(string)));

                this.PublisherId = group.Add(new VocabularyKey("PublisherId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the publisher.")
                    .WithDisplayName("Publisher Identifier")
                    .ModelProperty("publisherid", typeof(Guid)));

                this.Address2_Line1 = group.Add(new VocabularyKey("Address2_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First line for entering address 2 information.")
                    .WithDisplayName("Address 2: Street 1")
                    .ModelProperty("address2_line1", typeof(string)));

                this.Address1_Line2 = group.Add(new VocabularyKey("Address1_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second line for entering address 1 information.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("address1_line2", typeof(string)));

                this.Address2_PostalCode = group.Add(new VocabularyKey("Address2_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"ZIP Code or postal code for address 2.")
                    .WithDisplayName("Address 2: ZIP/Postal Code")
                    .ModelProperty("address2_postalcode", typeof(string)));

                this.Address1_PostalCode = group.Add(new VocabularyKey("Address1_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"ZIP Code or postal code for address 1.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("address1_postalcode", typeof(string)));

                this.Address1_StateOrProvince = group.Add(new VocabularyKey("Address1_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"State or province for address 1.")
                    .WithDisplayName("State/Province")
                    .ModelProperty("address1_stateorprovince", typeof(string)));

                this.Address1_Line1 = group.Add(new VocabularyKey("Address1_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First line for entering address 1 information.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("address1_line1", typeof(string)));

                this.Address2_Fax = group.Add(new VocabularyKey("Address2_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Fax number for address 2.")
                    .WithDisplayName("Address 2: Fax")
                    .ModelProperty("address2_fax", typeof(string)));

                this.Address1_City = group.Add(new VocabularyKey("Address1_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"City name for address 1.")
                    .WithDisplayName("City")
                    .ModelProperty("address1_city", typeof(string)));

                this.Address2_Telephone3 = group.Add(new VocabularyKey("Address2_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number associated with address 2.")
                    .WithDisplayName("Address 2: Telephone 3")
                    .ModelProperty("address2_telephone3", typeof(string)));

                this.Address1_ShippingMethodCodeName = group.Add(new VocabularyKey("Address1_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_ShippingMethodCodeName")
                    .ModelProperty("address1_shippingmethodcodename", typeof(string)));

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

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

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

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.UniqueName = group.Add(new VocabularyKey("UniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"The unique name of this publisher.")
                    .WithDisplayName("Name")
                    .ModelProperty("uniquename", typeof(string)));

                this.FriendlyName = group.Add(new VocabularyKey("FriendlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"User display name for this publisher.")
                    .WithDisplayName("Display Name")
                    .ModelProperty("friendlyname", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the publisher.")
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

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the publisher.")
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

                this.CustomizationOptionValuePrefix = group.Add(new VocabularyKey("CustomizationOptionValuePrefix", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Default option value prefix used for newly created options for solutions associated with this publisher.")
                    .WithDisplayName("Option Value Prefix")
                    .ModelProperty("customizationoptionvalueprefix", typeof(long)));

                this.PinpointPublisherId = group.Add(new VocabularyKey("PinpointPublisherId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Identifier of the publisher in Microsoft Pinpoint.")
                    .WithDisplayName("PinpointPublisherId")
                    .ModelProperty("pinpointpublisherid", typeof(int)));

                this.PinpointPublisherDefaultLocale = group.Add(new VocabularyKey("PinpointPublisherDefaultLocale", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(16))
                    .WithDescription(@"Default locale of the publisher in Microsoft Pinpoint.")
                    .WithDisplayName("PinpointPublisherDefaultLocale")
                    .ModelProperty("pinpointpublisherdefaultlocale", typeof(string)));

                this.IsReadonly = group.Add(new VocabularyKey("IsReadonly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the publisher was created as part of a managed solution installation.")
                    .WithDisplayName("Is Read-Only Publisher")
                    .ModelProperty("isreadonly", typeof(bool)));

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

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey Address1_Telephone3 { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey Address2_Country { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Address1_Telephone2 { get; private set; }

        public VocabularyKey Address2_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_Line3 { get; private set; }

        public VocabularyKey Address2_Name { get; private set; }

        public VocabularyKey Address1_AddressId { get; private set; }

        public VocabularyKey Address2_AddressId { get; private set; }

        public VocabularyKey Address1_Latitude { get; private set; }

        public VocabularyKey Address2_County { get; private set; }

        public VocabularyKey Address1_Country { get; private set; }

        public VocabularyKey Address2_City { get; private set; }

        public VocabularyKey EMailAddress { get; private set; }

        public VocabularyKey Address1_ShippingMethodCode { get; private set; }

        public VocabularyKey Address2_Longitude { get; private set; }

        public VocabularyKey Address2_Line2 { get; private set; }

        public VocabularyKey Address1_UTCOffset { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey Address1_County { get; private set; }

        public VocabularyKey Address1_Fax { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Address2_UTCOffset { get; private set; }

        public VocabularyKey Address1_Name { get; private set; }

        public VocabularyKey Address1_UPSZone { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey Address1_PostOfficeBox { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CustomizationPrefix { get; private set; }

        public VocabularyKey Address2_StateOrProvince { get; private set; }

        public VocabularyKey Address2_ShippingMethodCode { get; private set; }

        public VocabularyKey Address2_Telephone2 { get; private set; }

        public VocabularyKey Address2_UPSZone { get; private set; }

        public VocabularyKey Address1_Telephone1 { get; private set; }

        public VocabularyKey SupportingWebsiteUrl { get; private set; }

        public VocabularyKey Address1_Longitude { get; private set; }

        public VocabularyKey Address2_PostOfficeBox { get; private set; }

        public VocabularyKey Address2_Latitude { get; private set; }

        public VocabularyKey Address2_Line3 { get; private set; }

        public VocabularyKey Address2_Telephone1 { get; private set; }

        public VocabularyKey PublisherId { get; private set; }

        public VocabularyKey Address2_Line1 { get; private set; }

        public VocabularyKey Address1_Line2 { get; private set; }

        public VocabularyKey Address2_PostalCode { get; private set; }

        public VocabularyKey Address1_PostalCode { get; private set; }

        public VocabularyKey Address1_StateOrProvince { get; private set; }

        public VocabularyKey Address1_Line1 { get; private set; }

        public VocabularyKey Address2_Fax { get; private set; }

        public VocabularyKey Address1_City { get; private set; }

        public VocabularyKey Address2_Telephone3 { get; private set; }

        public VocabularyKey Address1_ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address2_AddressTypeCodeName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey Address2_ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address1_AddressTypeCodeName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey UniqueName { get; private set; }

        public VocabularyKey FriendlyName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CustomizationOptionValuePrefix { get; private set; }

        public VocabularyKey PinpointPublisherId { get; private set; }

        public VocabularyKey PinpointPublisherDefaultLocale { get; private set; }

        public VocabularyKey IsReadonly { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }


    }
}

