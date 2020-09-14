using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OwnerVocabulary : SimpleVocabulary
    {
        public OwnerVocabulary()
        {
            VocabularyName = "Dynamics365 Owner";
            KeyPrefix = "dynamics365.owner";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;

            this.AddGroup("Owner", group =>
            {
                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the Owner: systemuserid or teamid.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the Owner.")
                    .WithDisplayName("Owner Name")
                    .ModelProperty("name", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.YomiName = group.Add(new VocabularyKey("YomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Pronunciation of the name of the owner, written in phonetic hiragana or katakana characters.")
                    .WithDisplayName("Yomi Name")
                    .ModelProperty("yominame", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey YomiName { get; private set; }


    }
}

