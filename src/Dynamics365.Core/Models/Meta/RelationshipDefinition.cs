namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RelationshipDefinition : DynamicsModel
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
}
