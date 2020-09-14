using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TraceAssociationVocabulary : SimpleVocabulary
    {
        public TraceAssociationVocabulary()
        {
            VocabularyName = "Dynamics365 TraceAssociation";
            KeyPrefix = "dynamics365.traceassociation";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TraceAssociation", group =>
            {
                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the trace association.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.TraceAssociationId = group.Add(new VocabularyKey("TraceAssociationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the trace association.")
                    .WithDisplayName("Trace Association")
                    .ModelProperty("traceassociationid", typeof(Guid)));

                this.TraceLogId = group.Add(new VocabularyKey("TraceLogId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the trace.")
                    .WithDisplayName("Trace")
                    .ModelProperty("tracelogid", typeof(string)));

                this.TraceLogIdName = group.Add(new VocabularyKey("TraceLogIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TraceLogIdName")
                    .ModelProperty("tracelogidname", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the object the trace association is regarding.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the regarding object.")
                    .WithDisplayName("Regarding Object Type")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey TraceAssociationId { get; private set; }

        public VocabularyKey TraceLogId { get; private set; }

        public VocabularyKey TraceLogIdName { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }


    }
}

