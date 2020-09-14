using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class FieldPermissionVocabulary : SimpleVocabulary
    {
        public FieldPermissionVocabulary()
        {
            VocabularyName = "Dynamics365 FieldPermission";
            KeyPrefix = "dynamics365.fieldpermission";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("FieldPermission", group =>
            {
                this.CanRead = group.Add(new VocabularyKey("CanRead", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Can this Profile read the attribute")
                    .WithDisplayName("Can Read the attribute")
                    .ModelProperty("canread", typeof(string)));

                this.CanReadName = group.Add(new VocabularyKey("CanReadName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanReadName")
                    .ModelProperty("canreadname", typeof(string)));

                this.CanUpdate = group.Add(new VocabularyKey("CanUpdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Can this Profile update the attribute")
                    .WithDisplayName("Can Update the attribute")
                    .ModelProperty("canupdate", typeof(string)));

                this.CanUpdateName = group.Add(new VocabularyKey("CanUpdateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanUpdateName")
                    .ModelProperty("canupdatename", typeof(string)));

                this.CanCreate = group.Add(new VocabularyKey("CanCreate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Can this Profile create the attribute")
                    .WithDisplayName("Can create the attribute")
                    .ModelProperty("cancreate", typeof(string)));

                this.CanCreateName = group.Add(new VocabularyKey("CanCreateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanCreateName")
                    .ModelProperty("cancreatename", typeof(string)));

                this.FieldSecurityProfileId = group.Add(new VocabularyKey("FieldSecurityProfileId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of profile to which this privilege belongs.")
                    .WithDisplayName("Profile")
                    .ModelProperty("fieldsecurityprofileid", typeof(string)));

                this.FieldPermissionId = group.Add(new VocabularyKey("FieldPermissionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Field Permission.")
                    .WithDisplayName("Field Permission")
                    .ModelProperty("fieldpermissionid", typeof(Guid)));

                this.EntityName = group.Add(new VocabularyKey("EntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Entity name.")
                    .WithDisplayName("Name of the Entity for which this privilege is defined")
                    .ModelProperty("entityname", typeof(string)));

                this.AttributeLogicalName = group.Add(new VocabularyKey("AttributeLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"Attribute Name.")
                    .WithDisplayName("Name of the attribute for which this privilege is defined")
                    .ModelProperty("attributelogicalname", typeof(string)));

                this.FieldPermissionIdUnique = group.Add(new VocabularyKey("FieldPermissionIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Field Permission")
                    .ModelProperty("fieldpermissionidunique", typeof(Guid)));

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

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the organization")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

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


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CanRead { get; private set; }

        public VocabularyKey CanReadName { get; private set; }

        public VocabularyKey CanUpdate { get; private set; }

        public VocabularyKey CanUpdateName { get; private set; }

        public VocabularyKey CanCreate { get; private set; }

        public VocabularyKey CanCreateName { get; private set; }

        public VocabularyKey FieldSecurityProfileId { get; private set; }

        public VocabularyKey FieldPermissionId { get; private set; }

        public VocabularyKey EntityName { get; private set; }

        public VocabularyKey AttributeLogicalName { get; private set; }

        public VocabularyKey FieldPermissionIdUnique { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }


    }
}

