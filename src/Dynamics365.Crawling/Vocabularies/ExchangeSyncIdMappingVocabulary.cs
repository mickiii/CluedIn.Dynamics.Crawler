using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ExchangeSyncIdMappingVocabulary : SimpleVocabulary
    {
        public ExchangeSyncIdMappingVocabulary()
        {
            VocabularyName = "Dynamics365 ExchangeSyncIdMapping";
            KeyPrefix = "dynamics365.exchangesyncidmapping";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ExchangeSyncIdMapping", group =>
            {
                this.ExchangeSyncIdmappingId = group.Add(new VocabularyKey("ExchangeSyncIdmappingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ExchangeSyncIdmappingId")
                    .ModelProperty("exchangesyncidmappingid", typeof(Guid)));

                this.ExchangeEntryId = group.Add(new VocabularyKey("ExchangeEntryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"")
                    .WithDisplayName("Exchange Id")
                    .ModelProperty("exchangeentryid", typeof(string)));

                this.IsDeletedInExchange = group.Add(new VocabularyKey("IsDeletedInExchange", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("IsDeletedInExchange")
                    .ModelProperty("isdeletedinexchange", typeof(bool)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Crm Id")
                    .ModelProperty("objectid", typeof(Guid)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Object Type Code")
                    .ModelProperty("objecttypecode", typeof(long)));

                this.IsUnlinkedInCRM = group.Add(new VocabularyKey("IsUnlinkedInCRM", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("IsUnlinkedInCRM")
                    .ModelProperty("isunlinkedincrm", typeof(bool)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerId")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningBusinessUnit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningTeam")
                    .ModelProperty("owningteam", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningUser")
                    .ModelProperty("owninguser", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.FromCrmChangeType = group.Add(new VocabularyKey("FromCrmChangeType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("FromCrmChangeType")
                    .ModelProperty("fromcrmchangetype", typeof(long)));

                this.ToCrmChangeType = group.Add(new VocabularyKey("ToCrmChangeType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("ToCrmChangeType")
                    .ModelProperty("tocrmchangetype", typeof(long)));

                this.Retries = group.Add(new VocabularyKey("Retries", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Retries")
                    .ModelProperty("retries", typeof(long)));

                this.LastSyncError = group.Add(new VocabularyKey("LastSyncError", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2048))
                    .WithDescription(@"")
                    .WithDisplayName("Sync Error")
                    .ModelProperty("lastsyncerror", typeof(string)));

                this.UserDecision = group.Add(new VocabularyKey("UserDecision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("UserDecision")
                    .ModelProperty("userdecision", typeof(long)));

                this.LastSyncErrorCode = group.Add(new VocabularyKey("LastSyncErrorCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("LastSyncErrorCode")
                    .ModelProperty("lastsyncerrorcode", typeof(long)));

                this.LastSyncErrorOccurredOn = group.Add(new VocabularyKey("LastSyncErrorOccurredOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Last Sync Error Time")
                    .WithDisplayName("Last Sync Error Time")
                    .ModelProperty("lastsyncerroroccurredon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ItemSubject = group.Add(new VocabularyKey("ItemSubject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2048))
                    .WithDescription(@"")
                    .WithDisplayName("Item Subject")
                    .ModelProperty("itemsubject", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ExchangeSyncIdmappingId { get; private set; }

        public VocabularyKey ExchangeEntryId { get; private set; }

        public VocabularyKey IsDeletedInExchange { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey IsUnlinkedInCRM { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey FromCrmChangeType { get; private set; }

        public VocabularyKey ToCrmChangeType { get; private set; }

        public VocabularyKey Retries { get; private set; }

        public VocabularyKey LastSyncError { get; private set; }

        public VocabularyKey UserDecision { get; private set; }

        public VocabularyKey LastSyncErrorCode { get; private set; }

        public VocabularyKey LastSyncErrorOccurredOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ItemSubject { get; private set; }


    }
}

