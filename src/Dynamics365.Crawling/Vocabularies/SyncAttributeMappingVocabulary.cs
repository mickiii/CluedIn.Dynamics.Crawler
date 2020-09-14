using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SyncAttributeMappingVocabulary : SimpleVocabulary
    {
        public SyncAttributeMappingVocabulary()
        {
            VocabularyName = "Dynamics365 SyncAttributeMapping";
            KeyPrefix = "dynamics365.syncattributemapping";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SyncAttributeMapping", group =>
            {
                this.SyncAttributeMappingId = group.Add(new VocabularyKey("SyncAttributeMappingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Sync-Attribute Mapping.")
                    .WithDisplayName("Sync-Attribute Mapping Id")
                    .ModelProperty("syncattributemappingid", typeof(Guid)));

                this.SyncAttributeMappingIdUnique = group.Add(new VocabularyKey("SyncAttributeMappingIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Sync-Attribute Mapping")
                    .ModelProperty("syncattributemappingidunique", typeof(Guid)));

                this.MappingName = group.Add(new VocabularyKey("MappingName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Attribute Name.")
                    .WithDisplayName("Name of the attribute for which this mapping is defined")
                    .ModelProperty("mappingname", typeof(string)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.EntityTypeCode = group.Add(new VocabularyKey("EntityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Entity name.")
                    .WithDisplayName("Name of the Entity for which this attribute mapping is defined")
                    .ModelProperty("entitytypecode", typeof(string)));

                this.SyncAttributeMappingProfileId = group.Add(new VocabularyKey("SyncAttributeMappingProfileId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of profile to which this mapping belongs.")
                    .WithDisplayName("Profile")
                    .ModelProperty("syncattributemappingprofileid", typeof(string)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the organization")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

                this.AttributeCRMName = group.Add(new VocabularyKey("AttributeCRMName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"CRM Attribute Name.")
                    .WithDisplayName("CRM Name of the attribute for which this mapping is defined")
                    .ModelProperty("attributecrmname", typeof(string)));

                this.AttributeExchangeName = group.Add(new VocabularyKey("AttributeExchangeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Exchange Attribute Name.")
                    .WithDisplayName("Exchange Name of the attribute for which this mapping is defined")
                    .ModelProperty("attributeexchangename", typeof(string)));

                this.SyncDirection = group.Add(new VocabularyKey("SyncDirection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sync Direction")
                    .WithDisplayName("Sync Direction")
                    .ModelProperty("syncdirection", typeof(string)));

                this.SyncDirectionName = group.Add(new VocabularyKey("SyncDirectionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SyncDirectionName")
                    .ModelProperty("syncdirectionname", typeof(string)));

                this.IsComputed = group.Add(new VocabularyKey("IsComputed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the mapping is a computed property")
                    .WithDisplayName("Is Computed")
                    .ModelProperty("iscomputed", typeof(bool)));

                this.ComputedProperties = group.Add(new VocabularyKey("ComputedProperties", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"Computed Properties.")
                    .WithDisplayName("Computed Properties for one attribute")
                    .ModelProperty("computedproperties", typeof(string)));

                this.ParentSyncAttributeMappingId = group.Add(new VocabularyKey("ParentSyncAttributeMappingId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Parent Sync-Attribute Mapping to which this mapping belongs")
                    .WithDisplayName("Parent Sync-Attribute Mapping")
                    .ModelProperty("parentsyncattributemappingid", typeof(string)));

                this.DefaultSyncDirection = group.Add(new VocabularyKey("DefaultSyncDirection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Default Sync Direction")
                    .WithDisplayName("Sync Direction")
                    .ModelProperty("defaultsyncdirection", typeof(string)));

                this.DefaultSyncDirectionName = group.Add(new VocabularyKey("DefaultSyncDirectionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DefaultSyncDirectionName")
                    .ModelProperty("defaultsyncdirectionname", typeof(string)));

                this.AllowedSyncDirection = group.Add(new VocabularyKey("AllowedSyncDirection", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Allowed Sync Directions")
                    .WithDisplayName("Allowed Sync Directions")
                    .ModelProperty("allowedsyncdirection", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SyncAttributeMappingId { get; private set; }

        public VocabularyKey SyncAttributeMappingIdUnique { get; private set; }

        public VocabularyKey MappingName { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey EntityTypeCode { get; private set; }

        public VocabularyKey SyncAttributeMappingProfileId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey AttributeCRMName { get; private set; }

        public VocabularyKey AttributeExchangeName { get; private set; }

        public VocabularyKey SyncDirection { get; private set; }

        public VocabularyKey SyncDirectionName { get; private set; }

        public VocabularyKey IsComputed { get; private set; }

        public VocabularyKey ComputedProperties { get; private set; }

        public VocabularyKey ParentSyncAttributeMappingId { get; private set; }

        public VocabularyKey DefaultSyncDirection { get; private set; }

        public VocabularyKey DefaultSyncDirectionName { get; private set; }

        public VocabularyKey AllowedSyncDirection { get; private set; }


    }
}

