using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PostRegardingVocabulary : SimpleVocabulary
    {
        public PostRegardingVocabulary()
        {
            VocabularyName = "Dynamics365 PostRegarding";
            KeyPrefix = "dynamics365.postregarding";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("PostRegarding", group =>
            {
                this.PostRegardingId = group.Add(new VocabularyKey("PostRegardingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the ID of the record that the post is referring to.")
                    .WithDisplayName("PostRegardingId")
                    .ModelProperty("postregardingid", typeof(Guid)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"opportunity_PostRegardings")
                    .WithDisplayName("RegardingObjectId")
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
                    .WithDescription(@"Type of the RegardingObjectOwnerId")
                    .WithDisplayName("RegardingObjectOwnerIdType")
                    .ModelProperty("regardingobjectowneridtype", typeof(string)));

                this.RegardingObjectOwningBusinessUnit = group.Add(new VocabularyKey("RegardingObjectOwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the business unit that owns the regarding object.")
                    .WithDisplayName("Regarding object owning Business Unit")
                    .ModelProperty("regardingobjectowningbusinessunit", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the RegardingObject")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.RegardingObjectTypeCodeForSharing = group.Add(new VocabularyKey("RegardingObjectTypeCodeForSharing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the entity type of the regarding object for sharing.")
                    .WithDisplayName("RegardingObjectTypeCodeForSharing")
                    .ModelProperty("regardingobjecttypecodeforsharing", typeof(string)));

                this.LatestManualPostModifiedOn = group.Add(new VocabularyKey("LatestManualPostModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date of Latest Manual Post on the Regarding entity")
                    .WithDisplayName("Latest Manual Post")
                    .ModelProperty("latestmanualpostmodifiedon", typeof(DateTime)));

                this.LatestAutoPostModifiedOn = group.Add(new VocabularyKey("LatestAutoPostModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date of Latest Auto Post on the Regarding entity")
                    .WithDisplayName("Latest Auto Post")
                    .ModelProperty("latestautopostmodifiedon", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey PostRegardingId { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey RegardingObjectOwnerId { get; private set; }

        public VocabularyKey RegardingObjectOwnerIdType { get; private set; }

        public VocabularyKey RegardingObjectOwningBusinessUnit { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey RegardingObjectTypeCodeForSharing { get; private set; }

        public VocabularyKey LatestManualPostModifiedOn { get; private set; }

        public VocabularyKey LatestAutoPostModifiedOn { get; private set; }


    }
}

