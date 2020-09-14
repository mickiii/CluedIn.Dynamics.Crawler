using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class BulkOperationLogVocabulary : SimpleVocabulary
    {
        public BulkOperationLogVocabulary()
        {
            VocabularyName = "Dynamics365 BulkOperationLog";
            KeyPrefix = "dynamics365.bulkoperationlog";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("BulkOperationLog", group =>
            {
                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the account, contact, lead, or list that the bulk operation log item applies to.")
                    .WithDisplayName("Customers")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.ErrorNumber = group.Add(new VocabularyKey("ErrorNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the error code that is used to troubleshoot issues in the bulk operation.")
                    .WithDisplayName("Reason Id")
                    .ModelProperty("errornumber", typeof(long)));

                this.CreatedObjectId = group.Add(new VocabularyKey("CreatedObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"CreatedOpportunity_BulkOperationLogs")
                    .WithDisplayName("Created Object")
                    .ModelProperty("createdobjectid", typeof(string)));

                this.BulkOperationLogId = group.Add(new VocabularyKey("BulkOperationLogId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the bulk operation log.")
                    .WithDisplayName("Bulk Operation Log Number")
                    .ModelProperty("bulkoperationlogid", typeof(Guid)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the bulk operation log.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.BulkOperationId = group.Add(new VocabularyKey("BulkOperationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"BulkOperation_logs")
                    .WithDisplayName("Bulk Operation Number")
                    .ModelProperty("bulkoperationid", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the bulk operation log.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.AdditionalInfo = group.Add(new VocabularyKey("AdditionalInfo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100000))
                    .WithDescription(@"Shows the data value at which an error occurred during the quick campaign.")
                    .WithDisplayName("Failed on Line")
                    .ModelProperty("additionalinfo", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.BulkOperationIdName = group.Add(new VocabularyKey("BulkOperationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name for the bulk operation that this log relates to.")
                    .WithDisplayName("BulkOperationIdName")
                    .ModelProperty("bulkoperationidname", typeof(string)));

                this.RegardingObjectIdTypeCode = group.Add(new VocabularyKey("RegardingObjectIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of entity that is the target of the bulk operation.")
                    .WithDisplayName("RegardingObjectIdTypeCode")
                    .ModelProperty("regardingobjectidtypecode", typeof(string)));

                this.CreatedObjectIdName = group.Add(new VocabularyKey("CreatedObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedObjectIdName")
                    .ModelProperty("createdobjectidname", typeof(string)));

                this.CreatedObjectIdTypeCode = group.Add(new VocabularyKey("CreatedObjectIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type code of the entity created by the bulk operation.")
                    .WithDisplayName("CreatedObjectIdTypeCode")
                    .ModelProperty("createdobjectidtypecode", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the bulk operation log.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the owner")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Yomi name of the owner")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version Number")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"name")
                    .WithDisplayName("name")
                    .ModelProperty("name", typeof(string)));

                this.ErrorDescriptionFormatted = group.Add(new VocabularyKey("ErrorDescriptionFormatted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The error description formatted.")
                    .WithDisplayName("Error description")
                    .ModelProperty("errordescriptionformatted", typeof(string)));

                this.ErrorNumberFormatted = group.Add(new VocabularyKey("ErrorNumberFormatted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The error number formatted.")
                    .WithDisplayName("Error number")
                    .ModelProperty("errornumberformatted", typeof(string)));

                this.CampaignActivityId = group.Add(new VocabularyKey("CampaignActivityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the campaign activity record that the log applies to. This information is used to relate log data to the parent campaign activity.")
                    .WithDisplayName("Campaign Activity Number")
                    .ModelProperty("campaignactivityid", typeof(string)));

                this.CampaignActivityIdType = group.Add(new VocabularyKey("CampaignActivityIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("CampaignActivityIdType")
                    .ModelProperty("campaignactivityidtype", typeof(string)));

                this.CampaignActivityIdName = group.Add(new VocabularyKey("CampaignActivityIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"")
                    .WithDisplayName("CampaignActivityIdName")
                    .ModelProperty("campaignactivityidname", typeof(string)));

                this.CampaignActivityIdYomiName = group.Add(new VocabularyKey("CampaignActivityIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"")
                    .WithDisplayName("CampaignActivityIdYomiName")
                    .ModelProperty("campaignactivityidyominame", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey ErrorNumber { get; private set; }

        public VocabularyKey CreatedObjectId { get; private set; }

        public VocabularyKey BulkOperationLogId { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey BulkOperationId { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey AdditionalInfo { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey BulkOperationIdName { get; private set; }

        public VocabularyKey RegardingObjectIdTypeCode { get; private set; }

        public VocabularyKey CreatedObjectIdName { get; private set; }

        public VocabularyKey CreatedObjectIdTypeCode { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ErrorDescriptionFormatted { get; private set; }

        public VocabularyKey ErrorNumberFormatted { get; private set; }

        public VocabularyKey CampaignActivityId { get; private set; }

        public VocabularyKey CampaignActivityIdType { get; private set; }

        public VocabularyKey CampaignActivityIdName { get; private set; }

        public VocabularyKey CampaignActivityIdYomiName { get; private set; }


    }
}

