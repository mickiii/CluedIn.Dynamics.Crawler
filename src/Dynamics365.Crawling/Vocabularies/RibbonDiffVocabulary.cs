using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RibbonDiffVocabulary : SimpleVocabulary
    {
        public RibbonDiffVocabulary()
        {
            VocabularyName = "Dynamics365 RibbonDiff";
            KeyPrefix = "dynamics365.ribbondiff";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RibbonDiff", group =>
            {
                this.TabId = group.Add(new VocabularyKey("TabId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"The ID of the tab this definition applies to.")
                    .WithDisplayName("TabId")
                    .ModelProperty("tabid", typeof(string)));

                this.RDX = group.Add(new VocabularyKey("RDX", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Ribbon definition XML string that contains one change action.")
                    .WithDisplayName("RDX")
                    .ModelProperty("rdx", typeof(string)));

                this.ContextGroupId = group.Add(new VocabularyKey("ContextGroupId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the context group for this tab. If this ribbon definition adds a new tab, then it is a contextual tab.")
                    .WithDisplayName("ContextGroupId")
                    .ModelProperty("contextgroupid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.RibbonDiffUniqueId = group.Add(new VocabularyKey("RibbonDiffUniqueId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.")
                    .WithDisplayName("RibbonDiffUniqueId")
                    .ModelProperty("ribbondiffuniqueid", typeof(Guid)));

                this.Entity = group.Add(new VocabularyKey("Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"The entity this rule applies to, also the entity this rule was imported from, will be exported to.")
                    .WithDisplayName("Entity")
                    .ModelProperty("entity", typeof(string)));

                this.Sequence = group.Add(new VocabularyKey("Sequence", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence in which the definition is to be applied.")
                    .WithDisplayName("Sequence")
                    .ModelProperty("sequence", typeof(long)));

                this.RibbonDiffId = group.Add(new VocabularyKey("RibbonDiffId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier.")
                    .WithDisplayName("Primary Key")
                    .ModelProperty("ribbondiffid", typeof(Guid)));

                this.DiffType = group.Add(new VocabularyKey("DiffType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the type of ribbon definition.")
                    .WithDisplayName("DiffType")
                    .ModelProperty("difftype", typeof(string)));

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

                this.RibbonCustomizationId = group.Add(new VocabularyKey("RibbonCustomizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the ribbon customization with which the ribbon command is associated.")
                    .WithDisplayName("RibbonCustomizationId")
                    .ModelProperty("ribboncustomizationid", typeof(string)));

                this.DiffId = group.Add(new VocabularyKey("DiffId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"The string ID of this ribbon definition.")
                    .WithDisplayName("DiffId")
                    .ModelProperty("diffid", typeof(string)));

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

                this.IsAppAware = group.Add(new VocabularyKey("IsAppAware", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the ribbondiff is associated with app module.")
                    .WithDisplayName("IsAppAware")
                    .ModelProperty("isappaware", typeof(bool)));

                this.IsAppAwareName = group.Add(new VocabularyKey("IsAppAwareName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsAppAwareName")
                    .ModelProperty("isappawarename", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey TabId { get; private set; }

        public VocabularyKey RDX { get; private set; }

        public VocabularyKey ContextGroupId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey RibbonDiffUniqueId { get; private set; }

        public VocabularyKey Entity { get; private set; }

        public VocabularyKey Sequence { get; private set; }

        public VocabularyKey RibbonDiffId { get; private set; }

        public VocabularyKey DiffType { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey RibbonCustomizationId { get; private set; }

        public VocabularyKey DiffId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey IsAppAware { get; private set; }

        public VocabularyKey IsAppAwareName { get; private set; }


    }
}

