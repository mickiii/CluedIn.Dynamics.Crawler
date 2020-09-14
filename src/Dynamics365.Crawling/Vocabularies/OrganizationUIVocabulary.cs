using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OrganizationUIVocabulary : SimpleVocabulary
    {
        public OrganizationUIVocabulary()
        {
            VocabularyName = "Dynamics365 OrganizationUI";
            KeyPrefix = "dynamics365.organizationui";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("OrganizationUI", group =>
            {
                this.FormId = group.Add(new VocabularyKey("FormId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the record type form.")
                    .WithDisplayName("FormId")
                    .ModelProperty("formid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.FormXml = group.Add(new VocabularyKey("FormXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML representation of the form layout.")
                    .WithDisplayName("FormXml")
                    .ModelProperty("formxml", typeof(string)));

                this.FieldXml = group.Add(new VocabularyKey("FieldXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("FieldXml")
                    .ModelProperty("fieldxml", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Code that represents the record type.")
                    .WithDisplayName("ObjectTypeCode")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.PreviewXml = group.Add(new VocabularyKey("PreviewXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("PreviewXml")
                    .ModelProperty("previewxml", typeof(string)));

                this.PreviewColumnsetXml = group.Add(new VocabularyKey("PreviewColumnsetXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("PreviewColumnsetXml")
                    .ModelProperty("previewcolumnsetxml", typeof(string)));

                this.Version = group.Add(new VocabularyKey("Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Version")
                    .ModelProperty("version", typeof(long)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.OutlookShortcutIcon = group.Add(new VocabularyKey("OutlookShortcutIcon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Binary representation of the large icon used in the Microsoft Dynamics 365 client for Outlook for this record type.")
                    .WithDisplayName("OutlookShortcutIcon")
                    .ModelProperty("outlookshortcuticon", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.GridIcon = group.Add(new VocabularyKey("GridIcon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Binary representation of the icon used in record type grid views.")
                    .WithDisplayName("GridIcon")
                    .ModelProperty("gridicon", typeof(string)));

                this.FormIdUnique = group.Add(new VocabularyKey("FormIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("FormIdUnique")
                    .ModelProperty("formidunique", typeof(Guid)));

                this.LargeEntityIcon = group.Add(new VocabularyKey("LargeEntityIcon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Binary representation of the large icon used in the record type form.")
                    .WithDisplayName("LargeEntityIcon")
                    .ModelProperty("largeentityicon", typeof(string)));

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

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManaged")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey FormId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey FormXml { get; private set; }

        public VocabularyKey FieldXml { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey PreviewXml { get; private set; }

        public VocabularyKey PreviewColumnsetXml { get; private set; }

        public VocabularyKey Version { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey OutlookShortcutIcon { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey GridIcon { get; private set; }

        public VocabularyKey FormIdUnique { get; private set; }

        public VocabularyKey LargeEntityIcon { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }


    }
}

