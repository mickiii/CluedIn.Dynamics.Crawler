using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionVocabulary : SimpleVocabulary
    {
        public SubscriptionVocabulary()
        {
            VocabularyName = "Dynamics365 Subscription";
            KeyPrefix = "dynamics365.subscription";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Subscription", group =>
            {
                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionId")
                    .ModelProperty("subscriptionid", typeof(Guid)));

                this.SystemUserId = group.Add(new VocabularyKey("SystemUserId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SystemUserId")
                    .ModelProperty("systemuserid", typeof(Guid)));

                this.MachineName = group.Add(new VocabularyKey("MachineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("MachineName")
                    .ModelProperty("machinename", typeof(string)));

                this.LastSyncStartedOn = group.Add(new VocabularyKey("LastSyncStartedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("LastSyncStartedOn")
                    .ModelProperty("lastsyncstartedon", typeof(DateTime)));

                this.SyncEntryTableName = group.Add(new VocabularyKey("SyncEntryTableName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(128))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SyncEntryTableName")
                    .ModelProperty("syncentrytablename", typeof(string)));

                this.SubscriptionType = group.Add(new VocabularyKey("SubscriptionType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionType")
                    .ModelProperty("subscriptiontype", typeof(long)));

                this.CompletedSyncStartedOn = group.Add(new VocabularyKey("CompletedSyncStartedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"UTC time when the last successfully completed synchronization was started. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("CompletedSyncStartedOn")
                    .ModelProperty("completedsyncstartedon", typeof(DateTime)));

                this.ReInitialize = group.Add(new VocabularyKey("ReInitialize", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Database time stamp at the start time of the last successfully completed synchronization.")
                    .WithDisplayName("ReInitialize")
                    .ModelProperty("reinitialize", typeof(bool)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.CompletedSyncVersionNumber = group.Add(new VocabularyKey("CompletedSyncVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Database time stamp at the start time of the last successfully completed synchronization.")
                    .WithDisplayName("CompletedSyncVersionNumber")
                    .ModelProperty("completedsyncversionnumber", typeof(int)));

                this.ClientVersion = group.Add(new VocabularyKey("ClientVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Client Version.")
                    .WithDisplayName("Client Version.")
                    .ModelProperty("clientversion", typeof(string)));

                this.ResetForCreate = group.Add(new VocabularyKey("ResetForCreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ResetForCreate")
                    .ModelProperty("resetforcreate", typeof(bool)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey SystemUserId { get; private set; }

        public VocabularyKey MachineName { get; private set; }

        public VocabularyKey LastSyncStartedOn { get; private set; }

        public VocabularyKey SyncEntryTableName { get; private set; }

        public VocabularyKey SubscriptionType { get; private set; }

        public VocabularyKey CompletedSyncStartedOn { get; private set; }

        public VocabularyKey ReInitialize { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey CompletedSyncVersionNumber { get; private set; }

        public VocabularyKey ClientVersion { get; private set; }

        public VocabularyKey ResetForCreate { get; private set; }


    }
}

