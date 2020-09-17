namespace CluedIn.Crawling.Dynamics365.Core.Models
{

    public class Rootobject<T>
    {
        public string odatacontext { get; set; }
        public T[] value { get; set; }
    }

    public class RelationshipDefinition
    {
        public string odatatype { get; set; }
        public string ReferencedAttribute { get; set; }
        public string ReferencedEntity { get; set; }
        public string ReferencingAttribute { get; set; }
        public string ReferencingEntity { get; set; }
        public bool IsHierarchical { get; set; }
        public object EntityKey { get; set; }
        public string ReferencedEntityNavigationPropertyName { get; set; }
        public string ReferencingEntityNavigationPropertyName { get; set; }
        public int RelationshipBehavior { get; set; }
        public bool IsCustomRelationship { get; set; }
        public bool IsValidForAdvancedFind { get; set; }
        public string SchemaName { get; set; }
        public string SecurityTypes { get; set; }
        public bool IsManaged { get; set; }
        public string RelationshipType { get; set; }
        public string IntroducedVersion { get; set; }
        public string MetadataId { get; set; }
        public object HasChanged { get; set; }
        public Associatedmenuconfiguration AssociatedMenuConfiguration { get; set; }
        public Cascadeconfiguration CascadeConfiguration { get; set; }
        public object[] RelationshipAttributes { get; set; }
        public Iscustomizable IsCustomizable { get; set; }
        public string Entity1LogicalName { get; set; }
        public string Entity2LogicalName { get; set; }
        public string IntersectEntityName { get; set; }
        public string Entity1IntersectAttribute { get; set; }
        public string Entity2IntersectAttribute { get; set; }
        public string Entity1NavigationPropertyName { get; set; }
        public string Entity2NavigationPropertyName { get; set; }
        public Entity1associatedmenuconfiguration Entity1AssociatedMenuConfiguration { get; set; }
        public Entity2associatedmenuconfiguration Entity2AssociatedMenuConfiguration { get; set; }
    }

    public class Associatedmenuconfiguration
    {
        public string Behavior { get; set; }
        public string Group { get; set; }
        public int? Order { get; set; }
        public bool IsCustomizable { get; set; }
        public string Icon { get; set; }
        public string ViewId { get; set; }
        public bool AvailableOffline { get; set; }
        public string MenuId { get; set; }
        public string QueryApi { get; set; }
        public Label Label { get; set; }
    }

    public class Label
    {
        public Localizedlabel[] LocalizedLabels { get; set; }
        public Userlocalizedlabel UserLocalizedLabel { get; set; }
    }

    public class Cascadeconfiguration
    {
        public string Assign { get; set; }
        public string Delete { get; set; }
        public string Merge { get; set; }
        public string Reparent { get; set; }
        public string Share { get; set; }
        public string Unshare { get; set; }
        public string RollupView { get; set; }
    }

    public class Entity1associatedmenuconfiguration
    {
        public string Behavior { get; set; }
        public string Group { get; set; }
        public int? Order { get; set; }
        public bool IsCustomizable { get; set; }
        public object Icon { get; set; }
        public string ViewId { get; set; }
        public bool AvailableOffline { get; set; }
        public string MenuId { get; set; }
        public string QueryApi { get; set; }
        public Label1 Label { get; set; }
    }

    public class Label1
    {
        public Localizedlabel1[] LocalizedLabels { get; set; }
        public Userlocalizedlabel1 UserLocalizedLabel { get; set; }
    }

    public class Userlocalizedlabel1
    {
        public string Label { get; set; }
        public int LanguageCode { get; set; }
        public bool IsManaged { get; set; }
        public string MetadataId { get; set; }
        public object HasChanged { get; set; }
    }

    public class Localizedlabel1
    {
        public string Label { get; set; }
        public int LanguageCode { get; set; }
        public bool IsManaged { get; set; }
        public string MetadataId { get; set; }
        public object HasChanged { get; set; }
    }

    public class Entity2associatedmenuconfiguration
    {
        public string Behavior { get; set; }
        public string Group { get; set; }
        public int? Order { get; set; }
        public bool IsCustomizable { get; set; }
        public object Icon { get; set; }
        public string ViewId { get; set; }
        public bool AvailableOffline { get; set; }
        public string MenuId { get; set; }
        public string QueryApi { get; set; }
        public Label2 Label { get; set; }
    }

    public class Label2
    {
        public Localizedlabel2[] LocalizedLabels { get; set; }
        public Userlocalizedlabel2 UserLocalizedLabel { get; set; }
    }

    public class Userlocalizedlabel2
    {
        public string Label { get; set; }
        public int LanguageCode { get; set; }
        public bool IsManaged { get; set; }
        public string MetadataId { get; set; }
        public object HasChanged { get; set; }
    }

    public class Localizedlabel2
    {
        public string Label { get; set; }
        public int LanguageCode { get; set; }
        public bool IsManaged { get; set; }
        public string MetadataId { get; set; }
        public object HasChanged { get; set; }
    }
}
