using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class GlobalSearchConfigurationVocabulary : SimpleVocabulary
    {
        public GlobalSearchConfigurationVocabulary()
        {
            VocabularyName = "Dynamics365 GlobalSearchConfiguration";
            KeyPrefix = "dynamics365.globalsearchconfiguration";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("GlobalSearchConfiguration", group =>
            {
                this.GlobalSearchConfigurationId = group.Add(new VocabularyKey("GlobalSearchConfigurationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("GlobalSearchConfigurationId")
                    .ModelProperty("globalsearchconfigurationid", typeof(Guid)));

                this.SearchProviderName = group.Add(new VocabularyKey("SearchProviderName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"")
                    .WithDisplayName("SearchProviderName")
                    .ModelProperty("searchprovidername", typeof(string)));

                this.SearchProviderResultsPage = group.Add(new VocabularyKey("SearchProviderResultsPage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"")
                    .WithDisplayName("SearchProviderResultsPage")
                    .ModelProperty("searchproviderresultspage", typeof(string)));

                this.IsLocalized = group.Add(new VocabularyKey("IsLocalized", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the search logical name is localized.")
                    .WithDisplayName("IsLocalized")
                    .ModelProperty("islocalized", typeof(bool)));

                this.IsEnabled = group.Add(new VocabularyKey("IsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the specified search is enabled.")
                    .WithDisplayName("IsEnabled")
                    .ModelProperty("isenabled", typeof(bool)));

                this.IsSearchBoxVisible = group.Add(new VocabularyKey("IsSearchBoxVisible", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether the Search Box is visible.")
                    .WithDisplayName("IsSearchBoxVisible")
                    .ModelProperty("issearchboxvisible", typeof(bool)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.GlobalSearchConfigurationidUnique = group.Add(new VocabularyKey("GlobalSearchConfigurationidUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("GlobalSearchConfigurationidUnique")
                    .ModelProperty("globalsearchconfigurationidunique", typeof(Guid)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey GlobalSearchConfigurationId { get; private set; }

        public VocabularyKey SearchProviderName { get; private set; }

        public VocabularyKey SearchProviderResultsPage { get; private set; }

        public VocabularyKey IsLocalized { get; private set; }

        public VocabularyKey IsEnabled { get; private set; }

        public VocabularyKey IsSearchBoxVisible { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey GlobalSearchConfigurationidUnique { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }


    }
}

