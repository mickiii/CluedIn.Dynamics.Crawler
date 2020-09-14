using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class MetadataDifferenceVocabulary : SimpleVocabulary
    {
        public MetadataDifferenceVocabulary()
        {
            VocabularyName = "Dynamics365 MetadataDifference";
            KeyPrefix = "dynamics365.metadatadifference";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("MetadataDifference", group =>
            {
                this.MetadataDifferenceId = group.Add(new VocabularyKey("MetadataDifferenceId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the metadata difference.")
                    .WithDisplayName("MetadataDifferenceId")
                    .ModelProperty("metadatadifferenceid", typeof(Guid)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Introduced Version")
                    .WithDisplayName("IntroducedVersion")
                    .ModelProperty("introducedversion", typeof(double)));

                this.IntroducedVersionString = group.Add(new VocabularyKey("IntroducedVersionString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the differences were introduced.")
                    .WithDisplayName("Introduced Version String")
                    .ModelProperty("introducedversionstring", typeof(string)));

                this.DifferenceXml = group.Add(new VocabularyKey("DifferenceXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Difference Xml")
                    .WithDisplayName("DifferenceXml")
                    .ModelProperty("differencexml", typeof(string)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the metadata difference was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the metadata difference was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey MetadataDifferenceId { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey IntroducedVersionString { get; private set; }

        public VocabularyKey DifferenceXml { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }


    }
}

