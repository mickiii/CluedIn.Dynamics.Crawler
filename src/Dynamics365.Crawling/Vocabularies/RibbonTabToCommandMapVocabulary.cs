using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RibbonTabToCommandMapVocabulary : SimpleVocabulary
    {
        public RibbonTabToCommandMapVocabulary()
        {
            VocabularyName = "Dynamics365 RibbonTabToCommandMap";
            KeyPrefix = "dynamics365.ribbontabtocommandmap";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RibbonTabToCommandMap", group =>
            {
                this.TabId = group.Add(new VocabularyKey("TabId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"The Id of a tab")
                    .WithDisplayName("TabId")
                    .ModelProperty("tabid", typeof(string)));

                this.RibbonTabToCommandMapUniqueId = group.Add(new VocabularyKey("RibbonTabToCommandMapUniqueId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("RibbonTabToCommandMapUniqueId")
                    .ModelProperty("ribbontabtocommandmapuniqueid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.ControlId = group.Add(new VocabularyKey("ControlId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"A control id within that tab.")
                    .WithDisplayName("ControlId")
                    .ModelProperty("controlid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Entity = group.Add(new VocabularyKey("Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"The entity this rule applies to, also the entity this rule was imported from, will be exported to.")
                    .WithDisplayName("Entity")
                    .ModelProperty("entity", typeof(string)));

                this.Command = group.Add(new VocabularyKey("Command", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"A command Id of a control within that tab.")
                    .WithDisplayName("Command")
                    .ModelProperty("command", typeof(string)));

                this.RibbonTabToCommandMapId = group.Add(new VocabularyKey("RibbonTabToCommandMapId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier.")
                    .WithDisplayName("Primary Key")
                    .ModelProperty("ribbontabtocommandmapid", typeof(Guid)));

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

                this.RibbonDiffId = group.Add(new VocabularyKey("RibbonDiffId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the ribbon customization with which the ribbon command is associated.")
                    .WithDisplayName("RibbonDiffId")
                    .ModelProperty("ribbondiffid", typeof(string)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManaged")
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

        public VocabularyKey TabId { get; private set; }

        public VocabularyKey RibbonTabToCommandMapUniqueId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ControlId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Entity { get; private set; }

        public VocabularyKey Command { get; private set; }

        public VocabularyKey RibbonTabToCommandMapId { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey RibbonDiffId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }


    }
}

