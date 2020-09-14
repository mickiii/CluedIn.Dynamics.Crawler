using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ReplicationBacklogVocabulary : SimpleVocabulary
    {
        public ReplicationBacklogVocabulary()
        {
            VocabularyName = "Dynamics365 ReplicationBacklog";
            KeyPrefix = "dynamics365.replicationbacklog";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ReplicationBacklog", group =>
            {
                this.Data = group.Add(new VocabularyKey("Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Additional data related to the replication backlog entry. For internal use only.")
                    .WithDisplayName("Data")
                    .ModelProperty("data", typeof(string)));

                this.ReplicationBacklogId = group.Add(new VocabularyKey("ReplicationBacklogId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the replication backlog entry.")
                    .WithDisplayName("ReplicationBacklogId")
                    .ModelProperty("replicationbacklogid", typeof(Guid)));

                this.ReplicationBacklogType = group.Add(new VocabularyKey("ReplicationBacklogType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The type of replication backlog.")
                    .WithDisplayName("Replication Backlog Type")
                    .ModelProperty("replicationbacklogtype", typeof(string)));

                this.ReplicationBacklogTypeName = group.Add(new VocabularyKey("ReplicationBacklogTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ReplicationBacklogTypeName")
                    .ModelProperty("replicationbacklogtypename", typeof(string)));

                this.TargetObjectId = group.Add(new VocabularyKey("TargetObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the target object")
                    .WithDisplayName("Target Object Id")
                    .ModelProperty("targetobjectid", typeof(string)));

                this.TargetObjectIdName = group.Add(new VocabularyKey("TargetObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(425))
                    .WithDescription(@"Name of the target object for this replication backlog.")
                    .WithDisplayName("Target Object Name")
                    .ModelProperty("targetobjectidname", typeof(string)));

                this.TargetObjectTypeCode = group.Add(new VocabularyKey("TargetObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Object type code of the target object.")
                    .WithDisplayName("Target Object Type Code")
                    .ModelProperty("targetobjecttypecode", typeof(string)));

                this.TargetDatacenterId = group.Add(new VocabularyKey("TargetDatacenterId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Target Data Center Id")
                    .ModelProperty("targetdatacenterid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey Data { get; private set; }

        public VocabularyKey ReplicationBacklogId { get; private set; }

        public VocabularyKey ReplicationBacklogType { get; private set; }

        public VocabularyKey ReplicationBacklogTypeName { get; private set; }

        public VocabularyKey TargetObjectId { get; private set; }

        public VocabularyKey TargetObjectIdName { get; private set; }

        public VocabularyKey TargetObjectTypeCode { get; private set; }

        public VocabularyKey TargetDatacenterId { get; private set; }


    }
}

