using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LocalConfigStoreVocabulary : SimpleVocabulary
    {
        public LocalConfigStoreVocabulary()
        {
            VocabularyName = "Dynamics365 LocalConfigStore";
            KeyPrefix = "dynamics365.localconfigstore";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("LocalConfigStore", group =>
            {
                this.Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of LocalConfigStore entry.")
                    .WithDisplayName("Id")
                    .ModelProperty("id", typeof(Guid)));

                this.AssemblyName = group.Add(new VocabularyKey("AssemblyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"Assembly Name")
                    .WithDisplayName("Assembly Name")
                    .ModelProperty("assemblyname", typeof(string)));

                this.PublicToken = group.Add(new VocabularyKey("PublicToken", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"Assembly Public Token")
                    .WithDisplayName("Assembly Public Token")
                    .ModelProperty("publictoken", typeof(string)));

                this.KeyName = group.Add(new VocabularyKey("KeyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"Key Name")
                    .WithDisplayName("Key Name")
                    .ModelProperty("keyname", typeof(string)));

                this.Value = group.Add(new VocabularyKey("Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Value")
                    .WithDisplayName("Value")
                    .ModelProperty("value", typeof(string)));

                this.IsValueSet = group.Add(new VocabularyKey("IsValueSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsValueSet")
                    .ModelProperty("isvalueset", typeof(bool)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey Id { get; private set; }

        public VocabularyKey AssemblyName { get; private set; }

        public VocabularyKey PublicToken { get; private set; }

        public VocabularyKey KeyName { get; private set; }

        public VocabularyKey Value { get; private set; }

        public VocabularyKey IsValueSet { get; private set; }


    }
}

