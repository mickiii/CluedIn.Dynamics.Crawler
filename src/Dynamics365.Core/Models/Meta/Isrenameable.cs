using System.Collections.Generic;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public partial class Attribute
    {
        [JsonProperty("MetadataId")]
        public string MetadataId { get; set; }

        [JsonProperty("HasChanged")]
        public object HasChanged { get; set; }

        [JsonProperty("AttributeOf")]
        public string AttributeOf { get; set; }

        [JsonProperty("AttributeType")]
        public string AttributeType { get; set; }

        [JsonProperty("ColumnNumber")]
        public long ColumnNumber { get; set; }

        [JsonProperty("DeprecatedVersion")]
        public object DeprecatedVersion { get; set; }

        [JsonProperty("IntroducedVersion")]
        public object IntroducedVersion { get; set; }

        [JsonProperty("EntityLogicalName")]
        public string EntityLogicalName { get; set; }

        [JsonProperty("IsCustomAttribute")]
        public bool IsCustomAttribute { get; set; }

        [JsonProperty("IsPrimaryId")]
        public bool IsPrimaryId { get; set; }

        [JsonProperty("IsValidODataAttribute")]
        public bool IsValidODataAttribute { get; set; }

        [JsonProperty("IsPrimaryName")]
        public bool IsPrimaryName { get; set; }

        [JsonProperty("IsValidForCreate")]
        public bool IsValidForCreate { get; set; }

        [JsonProperty("IsValidForRead")]
        public bool IsValidForRead { get; set; }

        [JsonProperty("IsValidForUpdate")]
        public bool IsValidForUpdate { get; set; }

        [JsonProperty("CanBeSecuredForRead")]
        public bool CanBeSecuredForRead { get; set; }

        [JsonProperty("CanBeSecuredForCreate")]
        public bool CanBeSecuredForCreate { get; set; }

        [JsonProperty("CanBeSecuredForUpdate")]
        public bool CanBeSecuredForUpdate { get; set; }

        [JsonProperty("IsSecured")]
        public bool IsSecured { get; set; }

        [JsonProperty("IsRetrievable")]
        public bool IsRetrievable { get; set; }

        [JsonProperty("IsFilterable")]
        public bool IsFilterable { get; set; }

        [JsonProperty("IsSearchable")]
        public bool IsSearchable { get; set; }

        [JsonProperty("IsManaged")]
        public bool IsManaged { get; set; }

        [JsonProperty("LinkedAttributeId")]
        public object LinkedAttributeId { get; set; }

        [JsonProperty("LogicalName")]
        public string LogicalName { get; set; }

        [JsonProperty("IsValidForForm")]
        public bool IsValidForForm { get; set; }

        [JsonProperty("IsRequiredForForm")]
        public bool IsRequiredForForm { get; set; }

        [JsonProperty("IsValidForGrid")]
        public bool IsValidForGrid { get; set; }

        [JsonProperty("SchemaName")]
        public string SchemaName { get; set; }

        [JsonProperty("ExternalName")]
        public object ExternalName { get; set; }

        [JsonProperty("IsLogical")]
        public bool IsLogical { get; set; }

        [JsonProperty("IsDataSourceSecret")]
        public bool IsDataSourceSecret { get; set; }

        [JsonProperty("InheritsFrom")]
        public object InheritsFrom { get; set; }

        [JsonProperty("SourceType")]
        public long? SourceType { get; set; }

        [JsonProperty("AutoNumberFormat")]
        public string AutoNumberFormat { get; set; }

        [JsonProperty("AttributeTypeName")]
        public object AttributeTypeName { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("DisplayName")]
        public Description DisplayName { get; set; }

        [JsonProperty("IsAuditEnabled")]
        public Ismappable IsAuditEnabled { get; set; }

        [JsonProperty("IsGlobalFilterEnabled")]
        public Ismappable IsGlobalFilterEnabled { get; set; }

        [JsonProperty("IsSortableEnabled")]
        public Ismappable IsSortableEnabled { get; set; }

        [JsonProperty("IsCustomizable")]
        public Ismappable IsCustomizable { get; set; }

        [JsonProperty("IsRenameable")]
        public Ismappable IsRenameable { get; set; }

        [JsonProperty("IsValidForAdvancedFind")]
        public Ismappable IsValidForAdvancedFind { get; set; }

        [JsonProperty("RequiredLevel")]
        public object RequiredLevel { get; set; }

        [JsonProperty("CanModifyAdditionalSettings")]
        public Ismappable CanModifyAdditionalSettings { get; set; }

        [JsonProperty("@odata.type", NullValueHandling = NullValueHandling.Ignore)]
        public string OdataType { get; set; }

        [JsonProperty("Format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        [JsonProperty("ImeMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ImeMode { get; set; }

        [JsonProperty("MaxLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxLength { get; set; }

        [JsonProperty("YomiOf")]
        public string YomiOf { get; set; }

        [JsonProperty("IsLocalizable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocalizable { get; set; }

        [JsonProperty("DatabaseLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? DatabaseLength { get; set; }

        [JsonProperty("FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        [JsonProperty("SourceTypeMask", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceTypeMask { get; set; }

        [JsonProperty("FormatName", NullValueHandling = NullValueHandling.Ignore)]
        public object FormatName { get; set; }

        [JsonProperty("MinSupportedValue", NullValueHandling = NullValueHandling.Ignore)]
        public object MinSupportedValue { get; set; }

        [JsonProperty("MaxSupportedValue", NullValueHandling = NullValueHandling.Ignore)]
        public object MaxSupportedValue { get; set; }

        [JsonProperty("DateTimeBehavior", NullValueHandling = NullValueHandling.Ignore)]
        public object DateTimeBehavior { get; set; }

        [JsonProperty("CanChangeDateTimeBehavior", NullValueHandling = NullValueHandling.Ignore)]
        public Ismappable CanChangeDateTimeBehavior { get; set; }

        [JsonProperty("MaxValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }

        [JsonProperty("MinValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinValue { get; set; }

        [JsonProperty("Precision", NullValueHandling = NullValueHandling.Ignore)]
        public long? Precision { get; set; }

        [JsonProperty("PrecisionSource", NullValueHandling = NullValueHandling.Ignore)]
        public long? PrecisionSource { get; set; }

        [JsonProperty("CalculationOf")]
        public string CalculationOf { get; set; }

        [JsonProperty("IsBaseCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBaseCurrency { get; set; }

        [JsonProperty("DefaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultValue { get; set; }

        [JsonProperty("DefaultFormValue")]
        public long? DefaultFormValue { get; set; }

        [JsonProperty("ParentPicklistLogicalName")]
        public object ParentPicklistLogicalName { get; set; }

        [JsonProperty("ChildPicklistLogicalNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ChildPicklistLogicalNames { get; set; }

        [JsonProperty("Targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Targets { get; set; }

        [JsonProperty("IsPrimaryImage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrimaryImage { get; set; }

        [JsonProperty("MaxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxHeight { get; set; }

        [JsonProperty("MaxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxWidth { get; set; }

        [JsonProperty("MaxSizeInKB", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxSizeInKb { get; set; }

        [JsonProperty("CanStoreFullImage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanStoreFullImage { get; set; }

        [JsonProperty("IsEntityReferenceStored", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEntityReferenceStored { get; set; }
    }


}
