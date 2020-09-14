using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OrgInsightsMetricVocabulary : SimpleVocabulary
    {
        public OrgInsightsMetricVocabulary()
        {
            VocabularyName = "Dynamics365 OrgInsightsMetric";
            KeyPrefix = "dynamics365.orginsightsmetric";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("OrgInsightsMetric", group =>
            {
                this.OrgInsightsMetricId = group.Add(new VocabularyKey("OrgInsightsMetricId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OrgInsightsMetricId")
                    .ModelProperty("orginsightsmetricid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the record")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the organization insights metric was created")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.InternalName = group.Add(new VocabularyKey("InternalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the metric which is used for retrieving the data")
                    .WithDisplayName("Name of the metric that is used for retrieving the data")
                    .ModelProperty("internalname", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Legend Name used while displaying the metric")
                    .WithDisplayName("Legend Name used wile displaying the metric")
                    .ModelProperty("name", typeof(string)));

                this.MetricType = group.Add(new VocabularyKey("MetricType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the metric")
                    .WithDisplayName("Metric Type")
                    .ModelProperty("metrictype", typeof(string)));

                this.MetricTypeName = group.Add(new VocabularyKey("MetricTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the metric type")
                    .WithDisplayName("MetricTypeName")
                    .ModelProperty("metrictypename", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OrgInsightsMetricId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey InternalName { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey MetricType { get; private set; }

        public VocabularyKey MetricTypeName { get; private set; }


    }
}

