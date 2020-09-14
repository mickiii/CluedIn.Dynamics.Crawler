using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionClientsVocabulary : SimpleVocabulary
    {
        public SubscriptionClientsVocabulary()
        {
            VocabularyName = "Dynamics365 SubscriptionClients";
            KeyPrefix = "dynamics365.subscriptionclients";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SubscriptionClients", group =>
            {
                this.ClientId = group.Add(new VocabularyKey("ClientId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ClientId")
                    .ModelProperty("clientid", typeof(Guid)));

                this.MachineName = group.Add(new VocabularyKey("MachineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("MachineName")
                    .ModelProperty("machinename", typeof(string)));

                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionId")
                    .ModelProperty("subscriptionid", typeof(Guid)));

                this.IsPrimaryClient = group.Add(new VocabularyKey("IsPrimaryClient", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("IsPrimaryClient")
                    .ModelProperty("isprimaryclient", typeof(bool)));

                this.SubscriptionClientId = group.Add(new VocabularyKey("SubscriptionClientId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionClientId")
                    .ModelProperty("subscriptionclientid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ClientId { get; private set; }

        public VocabularyKey MachineName { get; private set; }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey IsPrimaryClient { get; private set; }

        public VocabularyKey SubscriptionClientId { get; private set; }


    }
}

