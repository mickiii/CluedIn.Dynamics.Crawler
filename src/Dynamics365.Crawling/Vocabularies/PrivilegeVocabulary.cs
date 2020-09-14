using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PrivilegeVocabulary : SimpleVocabulary
    {
        public PrivilegeVocabulary()
        {
            VocabularyName = "Dynamics365 Privilege";
            KeyPrefix = "dynamics365.privilege";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Privilege", group =>
            {
                this.PrivilegeId = group.Add(new VocabularyKey("PrivilegeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the privilege.")
                    .WithDisplayName("PrivilegeId")
                    .ModelProperty("privilegeid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the privilege.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.CanBeLocal = group.Add(new VocabularyKey("CanBeLocal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the privilege applies to the user's business unit.")
                    .WithDisplayName("CanBeLocal")
                    .ModelProperty("canbelocal", typeof(bool)));

                this.CanBeDeep = group.Add(new VocabularyKey("CanBeDeep", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the privilege applies to child business units of the business unit associated with the user.")
                    .WithDisplayName("CanBeDeep")
                    .ModelProperty("canbedeep", typeof(bool)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CanBeGlobal = group.Add(new VocabularyKey("CanBeGlobal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the privilege applies to the entire organization.")
                    .WithDisplayName("CanBeGlobal")
                    .ModelProperty("canbeglobal", typeof(bool)));

                this.CanBeBasic = group.Add(new VocabularyKey("CanBeBasic", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the privilege applies to the user, the user's team, or objects shared by the user.")
                    .WithDisplayName("CanBeBasic")
                    .ModelProperty("canbebasic", typeof(bool)));

                this.CanBeLocalName = group.Add(new VocabularyKey("CanBeLocalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeLocalName")
                    .ModelProperty("canbelocalname", typeof(string)));

                this.CanBeGlobalName = group.Add(new VocabularyKey("CanBeGlobalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeGlobalName")
                    .ModelProperty("canbeglobalname", typeof(string)));

                this.CanBeBasicName = group.Add(new VocabularyKey("CanBeBasicName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeBasicName")
                    .ModelProperty("canbebasicname", typeof(string)));

                this.CanBeDeepName = group.Add(new VocabularyKey("CanBeDeepName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeDeepName")
                    .ModelProperty("canbedeepname", typeof(string)));

                this.AccessRight = group.Add(new VocabularyKey("AccessRight", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Rights a user has to an instance of an entity.")
                    .WithDisplayName("AccessRight")
                    .ModelProperty("accessright", typeof(long)));

                this.IsDisabledWhenIntegrated = group.Add(new VocabularyKey("IsDisabledWhenIntegrated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Specifies whether the privilege is disabled.")
                    .WithDisplayName("IsDisabledWhenIntegrated")
                    .ModelProperty("isdisabledwhenintegrated", typeof(bool)));

                this.CanBeEntityReference = group.Add(new VocabularyKey("CanBeEntityReference", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the privilege applies to the local reference of an external party.")
                    .WithDisplayName("CanBeEntityReference")
                    .ModelProperty("canbeentityreference", typeof(bool)));

                this.CanBeEntityReferenceName = group.Add(new VocabularyKey("CanBeEntityReferenceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeEntityReferenceName")
                    .ModelProperty("canbeentityreferencename", typeof(string)));

                this.CanBeParentEntityReference = group.Add(new VocabularyKey("CanBeParentEntityReference", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the privilege applies to parent reference of the external party.")
                    .WithDisplayName("CanBeParentEntityReference")
                    .ModelProperty("canbeparententityreference", typeof(bool)));

                this.CanBeParentEntityReferenceName = group.Add(new VocabularyKey("CanBeParentEntityReferenceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeParentEntityReferenceName")
                    .ModelProperty("canbeparententityreferencename", typeof(string)));

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

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that specifies whether this component is managed.")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the component is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.PrivilegeRowId = group.Add(new VocabularyKey("PrivilegeRowId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Privilege used when synchronizing customizations for the Microsoft Dynamics CRM client for Outlook")
                    .WithDisplayName("App Module Unique Id")
                    .ModelProperty("privilegerowid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey PrivilegeId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey CanBeLocal { get; private set; }

        public VocabularyKey CanBeDeep { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CanBeGlobal { get; private set; }

        public VocabularyKey CanBeBasic { get; private set; }

        public VocabularyKey CanBeLocalName { get; private set; }

        public VocabularyKey CanBeGlobalName { get; private set; }

        public VocabularyKey CanBeBasicName { get; private set; }

        public VocabularyKey CanBeDeepName { get; private set; }

        public VocabularyKey AccessRight { get; private set; }

        public VocabularyKey IsDisabledWhenIntegrated { get; private set; }

        public VocabularyKey CanBeEntityReference { get; private set; }

        public VocabularyKey CanBeEntityReferenceName { get; private set; }

        public VocabularyKey CanBeParentEntityReference { get; private set; }

        public VocabularyKey CanBeParentEntityReferenceName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey PrivilegeRowId { get; private set; }


    }
}

