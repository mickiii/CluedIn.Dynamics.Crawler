using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RibbonClientMetadataVocabulary : SimpleVocabulary
    {
        public RibbonClientMetadataVocabulary()
        {
            VocabularyName = "Dynamics365 RibbonClientMetadata";
            KeyPrefix = "dynamics365.ribbonclientmetadata";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RibbonClientMetadata", group =>
            {
                this.RibbonId = group.Add(new VocabularyKey("RibbonId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of a ribbon client metadata.")
                    .WithDisplayName("Ribbon Client Metadata Identifier.")
                    .ModelProperty("ribbonid", typeof(Guid)));

                this.RibbonJson = group.Add(new VocabularyKey("RibbonJson", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Ribbon representation in JSON format.")
                    .WithDisplayName("RibbonJson")
                    .ModelProperty("ribbonjson", typeof(string)));

                this.EntityLogicalName = group.Add(new VocabularyKey("EntityLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Entity logical name")
                    .WithDisplayName("EntityLogicalName")
                    .ModelProperty("entitylogicalname", typeof(string)));

                this.RibbonContext = group.Add(new VocabularyKey("RibbonContext", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(32))
                    .WithDescription(@"Ribbon context")
                    .WithDisplayName("RibbonContext")
                    .ModelProperty("ribboncontext", typeof(string)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ComponentState")
                    .ModelProperty("componentstate", typeof(long)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.RibbonIdUnique = group.Add(new VocabularyKey("RibbonIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Ribbon client Metadata")
                    .WithDisplayName("RibbonIdUnique")
                    .ModelProperty("ribbonidunique", typeof(Guid)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RibbonId { get; private set; }

        public VocabularyKey RibbonJson { get; private set; }

        public VocabularyKey EntityLogicalName { get; private set; }

        public VocabularyKey RibbonContext { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey RibbonIdUnique { get; private set; }

        public VocabularyKey SolutionId { get; private set; }


    }
}

