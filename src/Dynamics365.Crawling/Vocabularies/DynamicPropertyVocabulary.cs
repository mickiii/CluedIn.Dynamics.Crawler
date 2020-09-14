using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DynamicPropertyVocabulary : SimpleVocabulary
    {
        public DynamicPropertyVocabulary()
        {
            VocabularyName = "Dynamics365 DynamicProperty";
            KeyPrefix = "dynamics365.dynamicproperty";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("DynamicProperty", group =>
            {
                this.DynamicPropertyId = group.Add(new VocabularyKey("DynamicPropertyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the unique identifier of the property.")
                    .WithDisplayName("Property ID")
                    .ModelProperty("dynamicpropertyid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the property.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type a description for the property.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.DataType = group.Add(new VocabularyKey("DataType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the data type of the property.")
                    .WithDisplayName("Data Type")
                    .ModelProperty("datatype", typeof(string)));

                this.DefaultValueInteger = group.Add(new VocabularyKey("DefaultValueInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default value of the property for a whole number data type.")
                    .WithDisplayName("Default Whole Number Value")
                    .ModelProperty("defaultvalueinteger", typeof(long)));

                this.DefaultValueString = group.Add(new VocabularyKey("DefaultValueString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"Shows the default value of the property for a string data type.")
                    .WithDisplayName("Default String Value")
                    .ModelProperty("defaultvaluestring", typeof(string)));

                this.DefaultValueDecimal = group.Add(new VocabularyKey("DefaultValueDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default value of the property for a decimal data type.")
                    .WithDisplayName("Default Decimal Value")
                    .ModelProperty("defaultvaluedecimal", typeof(decimal)));

                this.BaseDynamicPropertyId = group.Add(new VocabularyKey("BaseDynamicPropertyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"dynamicproperty_base_dynamicproperty")
                    .WithDisplayName("Base Property")
                    .ModelProperty("basedynamicpropertyid", typeof(string)));

                this.BaseDynamicPropertyIdName = group.Add(new VocabularyKey("BaseDynamicPropertyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("BaseDynamicPropertyIdName")
                    .ModelProperty("basedynamicpropertyidname", typeof(string)));

                this.MinValueDecimal = group.Add(new VocabularyKey("MinValueDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the minimum allowed value of the property for a decimal data type.")
                    .WithDisplayName("Minimum Decimal Value")
                    .ModelProperty("minvaluedecimal", typeof(decimal)));

                this.MaxValueDecimal = group.Add(new VocabularyKey("MaxValueDecimal", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the maximum allowed value of the property for a decimal data type.")
                    .WithDisplayName("Maximum Decimal Value")
                    .ModelProperty("maxvaluedecimal", typeof(decimal)));

                this.Precision = group.Add(new VocabularyKey("Precision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the allowed precision of the property for a whole number data type.")
                    .WithDisplayName("Precision")
                    .ModelProperty("precision", typeof(long)));

                this.statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the state of the property.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the property is active or inactive.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"ProductAssociation_DynamicProperty")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.DefaultValueDouble = group.Add(new VocabularyKey("DefaultValueDouble", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default value of the property for a double data type.")
                    .WithDisplayName("Default Double Value")
                    .ModelProperty("defaultvaluedouble", typeof(double)));

                this.MinValueDouble = group.Add(new VocabularyKey("MinValueDouble", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the minimum allowed value of the property for a double data type.")
                    .WithDisplayName("Minimum Double Value")
                    .ModelProperty("minvaluedouble", typeof(double)));

                this.MaxValueDouble = group.Add(new VocabularyKey("MaxValueDouble", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the maximum allowed value of the property for a double data type.")
                    .WithDisplayName("Maximum Double Value")
                    .ModelProperty("maxvaluedouble", typeof(double)));

                this.MinValueInteger = group.Add(new VocabularyKey("MinValueInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the minimum allowed value of the property for a whole number data type.")
                    .WithDisplayName("Minimum Whole Number Value")
                    .ModelProperty("minvalueinteger", typeof(long)));

                this.MaxValueInteger = group.Add(new VocabularyKey("MaxValueInteger", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the maximum allowed value of the property for a whole number data type.")
                    .WithDisplayName("Maximum Whole Number Value")
                    .ModelProperty("maxvalueinteger", typeof(long)));

                this.IsReadOnly = group.Add(new VocabularyKey("IsReadOnly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Defines whether the attribute is read-only or if it can be edited.")
                    .WithDisplayName("Read-Only")
                    .ModelProperty("isreadonly", typeof(bool)));

                this.IsHidden = group.Add(new VocabularyKey("IsHidden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Defines whether the attribute is hidden or shown.")
                    .WithDisplayName("Hidden")
                    .ModelProperty("ishidden", typeof(bool)));

                this.IsRequired = group.Add(new VocabularyKey("IsRequired", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Defines whether the attribute is mandatory.")
                    .WithDisplayName("Required")
                    .ModelProperty("isrequired", typeof(bool)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the property.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the attribute was migrated.")
                    .WithDisplayName("Attribute Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.OverwrittenDynamicPropertyId = group.Add(new VocabularyKey("OverwrittenDynamicPropertyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the related overwritten property.")
                    .WithDisplayName("Overwritten Property")
                    .ModelProperty("overwrittendynamicpropertyid", typeof(Guid)));

                this.RootDynamicPropertyId = group.Add(new VocabularyKey("RootDynamicPropertyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the root property that this property is derived from.")
                    .WithDisplayName("Root Property")
                    .ModelProperty("rootdynamicpropertyid", typeof(Guid)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this property.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"dynamicproperty_organization")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.MaxLengthString = group.Add(new VocabularyKey("MaxLengthString", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the maximum allowed length of the property for a string data type.")
                    .WithDisplayName("Maximum String Length")
                    .ModelProperty("maxlengthstring", typeof(long)));

                this.DefaultValueOptionSet = group.Add(new VocabularyKey("DefaultValueOptionSet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"DefaultValueOptionSet_DynamicProperty")
                    .WithDisplayName("Default OptionSet Value")
                    .ModelProperty("defaultvalueoptionset", typeof(string)));

                this.DefaultValueOptionSetName = group.Add(new VocabularyKey("DefaultValueOptionSetName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("DefaultValueOptionSetName")
                    .ModelProperty("defaultvalueoptionsetname", typeof(string)));

                this.statecodeName = group.Add(new VocabularyKey("statecodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("statecodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.statuscodeName = group.Add(new VocabularyKey("statuscodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("statuscodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.DMTImportState = group.Add(new VocabularyKey("DMTImportState", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Internal Use Only")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("dmtimportstate", typeof(long)));

                this.IsReadOnlyName = group.Add(new VocabularyKey("IsReadOnlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsReadOnlyName")
                    .ModelProperty("isreadonlyname", typeof(string)));

                this.IsHiddenName = group.Add(new VocabularyKey("IsHiddenName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsHiddenName")
                    .ModelProperty("ishiddenname", typeof(string)));

                this.IsRequiredName = group.Add(new VocabularyKey("IsRequiredName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRequiredName")
                    .ModelProperty("isrequiredname", typeof(string)));

                this.DataTypeName = group.Add(new VocabularyKey("DataTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DataTypeName")
                    .ModelProperty("datatypename", typeof(string)));

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

        public VocabularyKey DynamicPropertyId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey DataType { get; private set; }

        public VocabularyKey DefaultValueInteger { get; private set; }

        public VocabularyKey DefaultValueString { get; private set; }

        public VocabularyKey DefaultValueDecimal { get; private set; }

        public VocabularyKey BaseDynamicPropertyId { get; private set; }

        public VocabularyKey BaseDynamicPropertyIdName { get; private set; }

        public VocabularyKey MinValueDecimal { get; private set; }

        public VocabularyKey MaxValueDecimal { get; private set; }

        public VocabularyKey Precision { get; private set; }

        public VocabularyKey statecode { get; private set; }

        public VocabularyKey statuscode { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey DefaultValueDouble { get; private set; }

        public VocabularyKey MinValueDouble { get; private set; }

        public VocabularyKey MaxValueDouble { get; private set; }

        public VocabularyKey MinValueInteger { get; private set; }

        public VocabularyKey MaxValueInteger { get; private set; }

        public VocabularyKey IsReadOnly { get; private set; }

        public VocabularyKey IsHidden { get; private set; }

        public VocabularyKey IsRequired { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey OverwrittenDynamicPropertyId { get; private set; }

        public VocabularyKey RootDynamicPropertyId { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey MaxLengthString { get; private set; }

        public VocabularyKey DefaultValueOptionSet { get; private set; }

        public VocabularyKey DefaultValueOptionSetName { get; private set; }

        public VocabularyKey statecodeName { get; private set; }

        public VocabularyKey statuscodeName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey DMTImportState { get; private set; }

        public VocabularyKey IsReadOnlyName { get; private set; }

        public VocabularyKey IsHiddenName { get; private set; }

        public VocabularyKey IsRequiredName { get; private set; }

        public VocabularyKey DataTypeName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}

