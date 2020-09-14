using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionSyncInfoVocabulary : SimpleVocabulary
    {
        public SubscriptionSyncInfoVocabulary()
        {
            VocabularyName = "Dynamics365 SubscriptionSyncInfo";
            KeyPrefix = "dynamics365.subscriptionsyncinfo";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SubscriptionSyncInfo", group =>
            {
                this.EndTime = group.Add(new VocabularyKey("EndTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("EndTime")
                    .ModelProperty("endtime", typeof(DateTime)));

                this.SubscriptionSyncInfoId = group.Add(new VocabularyKey("SubscriptionSyncInfoId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionSyncInfoId")
                    .ModelProperty("subscriptionsyncinfoid", typeof(long)));

                this.DeleteObjectCount = group.Add(new VocabularyKey("DeleteObjectCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("DeleteObjectCount")
                    .ModelProperty("deleteobjectcount", typeof(long)));

                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionId")
                    .ModelProperty("subscriptionid", typeof(string)));

                this.SyncResult = group.Add(new VocabularyKey("SyncResult", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SyncResult")
                    .ModelProperty("syncresult", typeof(bool)));

                this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("StartTime")
                    .ModelProperty("starttime", typeof(DateTime)));

                this.DataSize = group.Add(new VocabularyKey("DataSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("DataSize")
                    .ModelProperty("datasize", typeof(long)));

                this.InsertObjectCount = group.Add(new VocabularyKey("InsertObjectCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("InsertObjectCount")
                    .ModelProperty("insertobjectcount", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.ClientVersion = group.Add(new VocabularyKey("ClientVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(20))
                    .WithDescription(@"Client (subscriber) version number.")
                    .WithDisplayName("ClientVersion")
                    .ModelProperty("clientversion", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EndTime { get; private set; }

        public VocabularyKey SubscriptionSyncInfoId { get; private set; }

        public VocabularyKey DeleteObjectCount { get; private set; }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey SyncResult { get; private set; }

        public VocabularyKey StartTime { get; private set; }

        public VocabularyKey DataSize { get; private set; }

        public VocabularyKey InsertObjectCount { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey ClientVersion { get; private set; }


    }
}

