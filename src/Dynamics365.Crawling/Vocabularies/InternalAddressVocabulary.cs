using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class InternalAddressVocabulary : SimpleVocabulary
    {
        public InternalAddressVocabulary()
        {
            VocabularyName = "Dynamics365 InternalAddress";
            KeyPrefix = "dynamics365.internaladdress";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("InternalAddress", group =>
            {
                this.ParentId = group.Add(new VocabularyKey("ParentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"site_internal_addresses")
                    .WithDisplayName("Parent")
                    .ModelProperty("parentid", typeof(Guid)));

                this.InternalAddressId = group.Add(new VocabularyKey("InternalAddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the internal address.")
                    .WithDisplayName("Internal Address")
                    .ModelProperty("internaladdressid", typeof(Guid)));

                this.AddressNumber = group.Add(new VocabularyKey("AddressNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about which internal address is applicable.")
                    .WithDisplayName("Address Number")
                    .ModelProperty("addressnumber", typeof(long)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of entity with which the internal address is associated.")
                    .WithDisplayName("Object Type")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.AddressTypeCode = group.Add(new VocabularyKey("AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for the internal address.")
                    .WithDisplayName("Address Type")
                    .ModelProperty("addresstypecode", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Name used to identify the internal address.")
                    .WithDisplayName("Address Name")
                    .ModelProperty("name", typeof(string)));

                this.Line1 = group.Add(new VocabularyKey("Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"First line for entering address information.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("line1", typeof(string)));

                this.Line2 = group.Add(new VocabularyKey("Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Second line for entering address information.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("line2", typeof(string)));

                this.Line3 = group.Add(new VocabularyKey("Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Third line for entering address information.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("line3", typeof(string)));

                this.City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"City name in the internal address.")
                    .WithDisplayName("City")
                    .ModelProperty("city", typeof(string)));

                this.StateOrProvince = group.Add(new VocabularyKey("StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"State or province in the internal address.")
                    .WithDisplayName("State/Province")
                    .ModelProperty("stateorprovince", typeof(string)));

                this.County = group.Add(new VocabularyKey("County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"County name in the internal address.")
                    .WithDisplayName("County")
                    .ModelProperty("county", typeof(string)));

                this.Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(128))
                    .WithDescription(@"Country/region name in the internal address.")
                    .WithDisplayName("Country/Region")
                    .ModelProperty("country", typeof(string)));

                this.PostOfficeBox = group.Add(new VocabularyKey("PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Post office box number in the internal address.")
                    .WithDisplayName("Post Office Box")
                    .ModelProperty("postofficebox", typeof(string)));

                this.PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(40))
                    .WithDescription(@"ZIP Code or postal code in the internal address.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("postalcode", typeof(string)));

                this.UTCOffset = group.Add(new VocabularyKey("UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for the internal address. The difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("UTC Offset")
                    .ModelProperty("utcoffset", typeof(long)));

                this.UPSZone = group.Add(new VocabularyKey("UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for the internal address.")
                    .WithDisplayName("UPS Zone")
                    .ModelProperty("upszone", typeof(string)));

                this.Latitude = group.Add(new VocabularyKey("Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for the internal address.")
                    .WithDisplayName("Latitude")
                    .ModelProperty("latitude", typeof(double)));

                this.Telephone1 = group.Add(new VocabularyKey("Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"First telephone number for the internal address.")
                    .WithDisplayName("Main Phone")
                    .ModelProperty("telephone1", typeof(string)));

                this.Longitude = group.Add(new VocabularyKey("Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for the internal address.")
                    .WithDisplayName("Longitude")
                    .ModelProperty("longitude", typeof(double)));

                this.ShippingMethodCode = group.Add(new VocabularyKey("ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for the internal address.")
                    .WithDisplayName("Shipping Method")
                    .ModelProperty("shippingmethodcode", typeof(string)));

                this.Telephone2 = group.Add(new VocabularyKey("Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number for an internal address.")
                    .WithDisplayName("Phone 2")
                    .ModelProperty("telephone2", typeof(string)));

                this.Telephone3 = group.Add(new VocabularyKey("Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number for an internal address.")
                    .WithDisplayName("Phone 3")
                    .ModelProperty("telephone3", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the internal address.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(64))
                    .WithDescription(@"Fax number for the internal address.")
                    .WithDisplayName("Fax")
                    .ModelProperty("fax", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the internal address record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the internal address was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the internal address.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the internal address record was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

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

                this.ShippingMethodCodeName = group.Add(new VocabularyKey("ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShippingMethodCodeName")
                    .ModelProperty("shippingmethodcodename", typeof(string)));

                this.AddressTypeCodeName = group.Add(new VocabularyKey("AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AddressTypeCodeName")
                    .ModelProperty("addresstypecodename", typeof(string)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the internal address.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the internaladdress.")
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

                this.Composite = group.Add(new VocabularyKey("Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete address.")
                    .WithDisplayName("Address")
                    .ModelProperty("composite", typeof(string)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BusinessUnitId")
                    .ModelProperty("businessunitid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ParentId { get; private set; }

        public VocabularyKey InternalAddressId { get; private set; }

        public VocabularyKey AddressNumber { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey AddressTypeCode { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Line1 { get; private set; }

        public VocabularyKey Line2 { get; private set; }

        public VocabularyKey Line3 { get; private set; }

        public VocabularyKey City { get; private set; }

        public VocabularyKey StateOrProvince { get; private set; }

        public VocabularyKey County { get; private set; }

        public VocabularyKey Country { get; private set; }

        public VocabularyKey PostOfficeBox { get; private set; }

        public VocabularyKey PostalCode { get; private set; }

        public VocabularyKey UTCOffset { get; private set; }

        public VocabularyKey UPSZone { get; private set; }

        public VocabularyKey Latitude { get; private set; }

        public VocabularyKey Telephone1 { get; private set; }

        public VocabularyKey Longitude { get; private set; }

        public VocabularyKey ShippingMethodCode { get; private set; }

        public VocabularyKey Telephone2 { get; private set; }

        public VocabularyKey Telephone3 { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Fax { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ShippingMethodCodeName { get; private set; }

        public VocabularyKey AddressTypeCodeName { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey Composite { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }


    }
}

