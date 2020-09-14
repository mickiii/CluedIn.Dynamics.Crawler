using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SystemFormVocabulary : SimpleVocabulary
    {
        public SystemFormVocabulary()
        {
            VocabularyName = "Dynamics365 SystemForm";
            KeyPrefix = "dynamics365.systemform";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SystemForm", group =>
            {
                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the form or dashboard.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.FormId = group.Add(new VocabularyKey("FormId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the record type form.")
                    .WithDisplayName("FormId")
                    .ModelProperty("formid", typeof(Guid)));

                this.FormIdUnique = group.Add(new VocabularyKey("FormIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("FormIdUnique")
                    .ModelProperty("formidunique", typeof(Guid)));

                this.FormXml = group.Add(new VocabularyKey("FormXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML representation of the form layout.")
                    .WithDisplayName("FormXml")
                    .ModelProperty("formxml", typeof(string)));

                this.IsDefault = group.Add(new VocabularyKey("IsDefault", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the form or the dashboard is the system default.")
                    .WithDisplayName("Default Form")
                    .ModelProperty("isdefault", typeof(bool)));

                this.IsDefaultName = group.Add(new VocabularyKey("IsDefaultName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDefaultName")
                    .ModelProperty("isdefaultname", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the form.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Code that represents the record type.")
                    .WithDisplayName("Entity Name")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

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

                this.Type = group.Add(new VocabularyKey("Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the form, for example, Dashboard or Preview.")
                    .WithDisplayName("Form Type")
                    .ModelProperty("type", typeof(string)));

                this.TypeName = group.Add(new VocabularyKey("TypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TypeName")
                    .ModelProperty("typename", typeof(string)));

                this.Version = group.Add(new VocabularyKey("Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Version")
                    .ModelProperty("version", typeof(long)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));

                this.PublishedOn = group.Add(new VocabularyKey("PublishedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Published On")
                    .ModelProperty("publishedon", typeof(DateTime)));

                this.AncestorFormId = group.Add(new VocabularyKey("AncestorFormId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the parent form.")
                    .WithDisplayName("Parent Form")
                    .ModelProperty("ancestorformid", typeof(string)));

                this.AncestorFormIdName = group.Add(new VocabularyKey("AncestorFormIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"")
                    .WithDisplayName("AncestorFormIdName")
                    .ModelProperty("ancestorformidname", typeof(string)));

                this.FormXmlManaged = group.Add(new VocabularyKey("FormXmlManaged", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"formXml diff as in a managed solution. for internal use only")
                    .WithDisplayName("FormXmlManaged")
                    .ModelProperty("formxmlmanaged", typeof(string)));

                this.CanBeDeleted = group.Add(new VocabularyKey("CanBeDeleted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be deleted.")
                    .WithDisplayName("Can Be Deleted")
                    .ModelProperty("canbedeleted", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the form is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.IsAIRMerged = group.Add(new VocabularyKey("IsAIRMerged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether this form is merged with the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.")
                    .WithDisplayName("Refreshed")
                    .ModelProperty("isairmerged", typeof(bool)));

                this.FormPresentation = group.Add(new VocabularyKey("FormPresentation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether this form is in the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.")
                    .WithDisplayName("AIR Refreshed")
                    .ModelProperty("formpresentation", typeof(string)));

                this.FormActivationState = group.Add(new VocabularyKey("FormActivationState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the state of the form.")
                    .WithDisplayName("Form State")
                    .ModelProperty("formactivationstate", typeof(string)));

                this.FormActivationStateName = group.Add(new VocabularyKey("FormActivationStateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("FormActivationStateName")
                    .ModelProperty("formactivationstatename", typeof(string)));

                this.FormPresentationName = group.Add(new VocabularyKey("FormPresentationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("FormPresentationName")
                    .ModelProperty("formpresentationname", typeof(string)));

                this.IsTabletEnabled = group.Add(new VocabularyKey("IsTabletEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the dashboard is enabled for tablet.")
                    .WithDisplayName("Is Tablet Enabled")
                    .ModelProperty("istabletenabled", typeof(bool)));

                this.UniqueName = group.Add(new VocabularyKey("UniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"Unique Name")
                    .WithDisplayName("Unique Name")
                    .ModelProperty("uniquename", typeof(string)));

                this.IsDesktopEnabled = group.Add(new VocabularyKey("IsDesktopEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the dashboard is enabled for desktop.")
                    .WithDisplayName("Is Desktop Enabled")
                    .ModelProperty("isdesktopenabled", typeof(bool)));

                this.FormJson = group.Add(new VocabularyKey("FormJson", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Json representation of the form layout.")
                    .WithDisplayName("FormJson")
                    .ModelProperty("formjson", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey FormId { get; private set; }

        public VocabularyKey FormIdUnique { get; private set; }

        public VocabularyKey FormXml { get; private set; }

        public VocabularyKey IsDefault { get; private set; }

        public VocabularyKey IsDefaultName { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey Type { get; private set; }

        public VocabularyKey TypeName { get; private set; }

        public VocabularyKey Version { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }

        public VocabularyKey PublishedOn { get; private set; }

        public VocabularyKey AncestorFormId { get; private set; }

        public VocabularyKey AncestorFormIdName { get; private set; }

        public VocabularyKey FormXmlManaged { get; private set; }

        public VocabularyKey CanBeDeleted { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey IsAIRMerged { get; private set; }

        public VocabularyKey FormPresentation { get; private set; }

        public VocabularyKey FormActivationState { get; private set; }

        public VocabularyKey FormActivationStateName { get; private set; }

        public VocabularyKey FormPresentationName { get; private set; }

        public VocabularyKey IsTabletEnabled { get; private set; }

        public VocabularyKey UniqueName { get; private set; }

        public VocabularyKey IsDesktopEnabled { get; private set; }

        public VocabularyKey FormJson { get; private set; }


    }
}

