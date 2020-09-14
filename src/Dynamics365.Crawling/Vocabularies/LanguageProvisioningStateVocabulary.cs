using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LanguageProvisioningStateVocabulary : SimpleVocabulary
    {
        public LanguageProvisioningStateVocabulary()
        {
            VocabularyName = "Dynamics365 LanguageProvisioningState";
            KeyPrefix = "dynamics365.languageprovisioningstate";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("LanguageProvisioningState", group =>
            {
                this.LanguageProvisioningStateId = group.Add(new VocabularyKey("LanguageProvisioningStateId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Language Provisioning State")
                    .ModelProperty("languageprovisioningstateid", typeof(Guid)));

                this.ApplicationVersion = group.Add(new VocabularyKey("ApplicationVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Application Version")
                    .WithDisplayName("Application Version")
                    .ModelProperty("applicationversion", typeof(string)));

                this.LanguageId = group.Add(new VocabularyKey("LanguageId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Language Id")
                    .WithDisplayName("Language Id")
                    .ModelProperty("languageid", typeof(long)));

                this.SolutionUniqueName = group.Add(new VocabularyKey("SolutionUniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Solution Unique Name")
                    .WithDisplayName("Solution Unique Name")
                    .ModelProperty("solutionuniquename", typeof(string)));

                this.SolutionFileVersion = group.Add(new VocabularyKey("SolutionFileVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Solution File Version")
                    .WithDisplayName("Solution File Version")
                    .ModelProperty("solutionfileversion", typeof(string)));

                this.ProvisioningStage = group.Add(new VocabularyKey("ProvisioningStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Provisioning Stage")
                    .WithDisplayName("Provisioning Stage")
                    .ModelProperty("provisioningstage", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey LanguageProvisioningStateId { get; private set; }

        public VocabularyKey ApplicationVersion { get; private set; }

        public VocabularyKey LanguageId { get; private set; }

        public VocabularyKey SolutionUniqueName { get; private set; }

        public VocabularyKey SolutionFileVersion { get; private set; }

        public VocabularyKey ProvisioningStage { get; private set; }


    }
}

