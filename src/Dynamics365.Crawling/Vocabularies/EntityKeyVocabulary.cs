using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EntityKeyVocabulary : SimpleVocabulary
    {
        public EntityKeyVocabulary()
        {
            VocabularyName = "Dynamics365 EntityKey";
            KeyPrefix = "dynamics365.entitykey";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EntityKey", group =>
            {
                this.EntityKeyId = group.Add(new VocabularyKey("EntityKeyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the entity key.")
                    .WithDisplayName("Entity Key")
                    .ModelProperty("entitykeyid", typeof(Guid)));

                this.LogicalName = group.Add(new VocabularyKey("LogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The name of this Entity Key.")
                    .WithDisplayName("Name")
                    .ModelProperty("logicalname", typeof(string)));

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

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EntityKeyId { get; private set; }

        public VocabularyKey LogicalName { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }


    }
}

