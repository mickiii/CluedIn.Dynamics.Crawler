using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TraceRegardingVocabulary : SimpleVocabulary
    {
        public TraceRegardingVocabulary()
        {
            VocabularyName = "Dynamics365 TraceRegarding";
            KeyPrefix = "dynamics365.traceregarding";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TraceRegarding", group =>
            {
                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the regarding object.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.RegardingObjectOwnerId = group.Add(new VocabularyKey("RegardingObjectOwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the regarding object.")
                    .WithDisplayName("Owner")
                    .ModelProperty("regardingobjectownerid", typeof(string)));

                this.RegardingObjectOwnerIdType = group.Add(new VocabularyKey("RegardingObjectOwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Owner type of the regarding object.")
                    .WithDisplayName("Owner Type")
                    .ModelProperty("regardingobjectowneridtype", typeof(string)));

                this.RegardingObjectOwningBusinessUnit = group.Add(new VocabularyKey("RegardingObjectOwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the regarding object.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("regardingobjectowningbusinessunit", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the regarding object.")
                    .WithDisplayName("Regarding Object Type")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.RegardingObjectTypeCodeForSharing = group.Add(new VocabularyKey("RegardingObjectTypeCodeForSharing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Regarding Object Type For Sharing")
                    .ModelProperty("regardingobjecttypecodeforsharing", typeof(string)));

                this.TraceRegardingId = group.Add(new VocabularyKey("TraceRegardingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the trace-regarding record.")
                    .WithDisplayName("Trace Regarding")
                    .ModelProperty("traceregardingid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey RegardingObjectOwnerId { get; private set; }

        public VocabularyKey RegardingObjectOwnerIdType { get; private set; }

        public VocabularyKey RegardingObjectOwningBusinessUnit { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey RegardingObjectTypeCodeForSharing { get; private set; }

        public VocabularyKey TraceRegardingId { get; private set; }


    }
}

