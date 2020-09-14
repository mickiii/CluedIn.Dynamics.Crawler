using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OrganizationStatisticVocabulary : SimpleVocabulary
    {
        public OrganizationStatisticVocabulary()
        {
            VocabularyName = "Dynamics365 OrganizationStatistic";
            KeyPrefix = "dynamics365.organizationstatistic";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("OrganizationStatistic", group =>
            {
                this.Hour = group.Add(new VocabularyKey("Hour", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Hour that the statistic measurement was taken.")
                    .WithDisplayName("Hour")
                    .ModelProperty("hour", typeof(long)));

                this.StatisticType = group.Add(new VocabularyKey("StatisticType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Statistic type that is being measured.")
                    .WithDisplayName("Statistic Type")
                    .ModelProperty("statistictype", typeof(long)));

                this.OrganizationStatisticId = group.Add(new VocabularyKey("OrganizationStatisticId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the record.")
                    .WithDisplayName("Org Statistic")
                    .ModelProperty("organizationstatisticid", typeof(Guid)));

                this.ServerName = group.Add(new VocabularyKey("ServerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Server that owns this record.")
                    .WithDisplayName("Server Name")
                    .ModelProperty("servername", typeof(string)));

                this.StatisticValue = group.Add(new VocabularyKey("StatisticValue", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Value of the statistic.")
                    .WithDisplayName("Statistic Value")
                    .ModelProperty("statisticvalue", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey Hour { get; private set; }

        public VocabularyKey StatisticType { get; private set; }

        public VocabularyKey OrganizationStatisticId { get; private set; }

        public VocabularyKey ServerName { get; private set; }

        public VocabularyKey StatisticValue { get; private set; }


    }
}

