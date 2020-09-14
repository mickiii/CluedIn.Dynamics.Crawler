using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class HierarchyRuleVocabulary : SimpleVocabulary
    {
        public HierarchyRuleVocabulary()
        {
            VocabularyName = "Dynamics365 HierarchyRule";
            KeyPrefix = "dynamics365.hierarchyrule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("HierarchyRule", group =>
            {
                this.HierarchyRuleID = group.Add(new VocabularyKey("HierarchyRuleID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the record type hierarchy rule.")
                    .WithDisplayName("HierarchyRuleID")
                    .ModelProperty("hierarchyruleid", typeof(Guid)));

                this.PrimaryEntityFormID = group.Add(new VocabularyKey("PrimaryEntityFormID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Form Id for the Primary Entity")
                    .WithDisplayName("PrimaryEntity FormID")
                    .ModelProperty("primaryentityformid", typeof(Guid)));

                this.RelatedEntityFormId = group.Add(new VocabularyKey("RelatedEntityFormId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Form Id for the Related Entity.")
                    .WithDisplayName("RelatedEntity FormID")
                    .ModelProperty("relatedentityformid", typeof(Guid)));

                this.PrimaryEntityLogicalName = group.Add(new VocabularyKey("PrimaryEntityLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Logical Name for the Primary entity.")
                    .WithDisplayName("Primary Entity Logical Name")
                    .ModelProperty("primaryentitylogicalname", typeof(string)));

                this.RelatedEntityLogicalName = group.Add(new VocabularyKey("RelatedEntityLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Logical Name for the Related entity.")
                    .WithDisplayName("Related Entity Logical Name")
                    .ModelProperty("relatedentitylogicalname", typeof(string)));

                this.PublishedOn = group.Add(new VocabularyKey("PublishedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PublishedOn")
                    .ModelProperty("publishedon", typeof(DateTime)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
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

                this.HierarchyRuleIDUnique = group.Add(new VocabularyKey("HierarchyRuleIDUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the hierarchy rule used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook")
                    .WithDisplayName("HierarchyRuleIDUnique")
                    .ModelProperty("hierarchyruleidunique", typeof(Guid)));

                this.SortBy = group.Add(new VocabularyKey("SortBy", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"columns to sort in the primary entity")
                    .WithDisplayName("Sort by")
                    .ModelProperty("sortby", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.ShowDisabled = group.Add(new VocabularyKey("ShowDisabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"To show disabled records or not.")
                    .WithDisplayName("Show Disabled")
                    .ModelProperty("showdisabled", typeof(bool)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the hierarchy rule is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

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

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the hierarchy rule.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the hierarchy rule.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the Hierarchy rule.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey HierarchyRuleID { get; private set; }

        public VocabularyKey PrimaryEntityFormID { get; private set; }

        public VocabularyKey RelatedEntityFormId { get; private set; }

        public VocabularyKey PrimaryEntityLogicalName { get; private set; }

        public VocabularyKey RelatedEntityLogicalName { get; private set; }

        public VocabularyKey PublishedOn { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey HierarchyRuleIDUnique { get; private set; }

        public VocabularyKey SortBy { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey ShowDisabled { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }


    }
}

