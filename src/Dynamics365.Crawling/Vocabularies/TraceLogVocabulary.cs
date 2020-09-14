using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TraceLogVocabulary : SimpleVocabulary
    {
        public TraceLogVocabulary()
        {
            VocabularyName = "Dynamics365 TraceLog";
            KeyPrefix = "dynamics365.tracelog";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TraceLog", group =>
            {
                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the trace.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time the error is created and logged.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the trace.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.Level = group.Add(new VocabularyKey("Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about the trace level.")
                    .WithDisplayName("Level")
                    .ModelProperty("level", typeof(string)));

                this.LevelName = group.Add(new VocabularyKey("LevelName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LevelName")
                    .ModelProperty("levelname", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the trace.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time the error is updated and logged for the same regarding object.")
                    .WithDisplayName("Last Update On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the trace.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the trace.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Regarding mailbox or email server profile.")
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

                this.Text = group.Add(new VocabularyKey("Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Text of the trace.")
                    .WithDisplayName("Text")
                    .ModelProperty("text", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.TraceCode = group.Add(new VocabularyKey("TraceCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Error code.")
                    .WithDisplayName("Error Code")
                    .ModelProperty("tracecode", typeof(long)));

                this.TraceLogId = group.Add(new VocabularyKey("TraceLogId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the trace.")
                    .WithDisplayName("Trace")
                    .ModelProperty("tracelogid", typeof(Guid)));

                this.TraceRegardingId = group.Add(new VocabularyKey("TraceRegardingId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Trace Regarding")
                    .ModelProperty("traceregardingid", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the trace was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TraceParameterXml = group.Add(new VocabularyKey("TraceParameterXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML representation of the trace parameters.")
                    .WithDisplayName("Trace Parameter XML")
                    .ModelProperty("traceparameterxml", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.IsUnique = group.Add(new VocabularyKey("IsUnique", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Tells if this traceLog is created uniquely(only one) for the associated entity.")
                    .WithDisplayName("Is Unique Trace")
                    .ModelProperty("isunique", typeof(bool)));

                this.ParentTraceLogId = group.Add(new VocabularyKey("ParentTraceLogId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the parent ID of the trace log.")
                    .WithDisplayName("Parent Id")
                    .ModelProperty("parenttracelogid", typeof(string)));

                this.TraceParameterHash = group.Add(new VocabularyKey("TraceParameterHash", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Stores the hash of the entity object associated with this tracelog. Hash is computed using the object type code and its id.")
                    .WithDisplayName("Trace Parameter Hash")
                    .ModelProperty("traceparameterhash", typeof(long)));

                this.CollationLevel = group.Add(new VocabularyKey("CollationLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the collation level")
                    .WithDisplayName("Collation Level")
                    .ModelProperty("collationlevel", typeof(long)));

                this.IsUniqueName = group.Add(new VocabularyKey("IsUniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsUniqueName")
                    .ModelProperty("isuniquename", typeof(string)));

                this.TraceDetailXml = group.Add(new VocabularyKey("TraceDetailXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML representation of the trace details.")
                    .WithDisplayName("Trace Detail XML")
                    .ModelProperty("tracedetailxml", typeof(string)));

                this.CanBeDeleted = group.Add(new VocabularyKey("CanBeDeleted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates if this trace log can be deleted.")
                    .WithDisplayName("Trace CanBeDeleted Flag")
                    .ModelProperty("canbedeleted", typeof(bool)));

                this.CanBeDeletedName = group.Add(new VocabularyKey("CanBeDeletedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeDeletedName")
                    .ModelProperty("canbedeletedname", typeof(string)));

                this.TraceActionXml = group.Add(new VocabularyKey("TraceActionXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"XML representation of the trace actions.")
                    .WithDisplayName("Trace Actions XML")
                    .ModelProperty("traceactionxml", typeof(string)));

                this.MachineName = group.Add(new VocabularyKey("MachineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(320))
                    .WithDescription(@"")
                    .WithDisplayName("MachineName")
                    .ModelProperty("machinename", typeof(string)));

                this.ErrorTypeDisplay = group.Add(new VocabularyKey("ErrorTypeDisplay", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(320))
                    .WithDescription(@"")
                    .WithDisplayName("Trace Error Details")
                    .ModelProperty("errortypedisplay", typeof(string)));

                this.TraceStatus = group.Add(new VocabularyKey("TraceStatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status about the trace.")
                    .WithDisplayName("Trace Status")
                    .ModelProperty("tracestatus", typeof(bool)));

                this.TraceStatusName = group.Add(new VocabularyKey("TraceStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TraceStatusName")
                    .ModelProperty("tracestatusname", typeof(string)));

                this.ErrorDetails = group.Add(new VocabularyKey("ErrorDetails", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2048))
                    .WithDescription(@"")
                    .WithDisplayName("ErrorDetails")
                    .ModelProperty("errordetails", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey Level { get; private set; }

        public VocabularyKey LevelName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey RegardingObjectOwnerId { get; private set; }

        public VocabularyKey RegardingObjectOwnerIdType { get; private set; }

        public VocabularyKey RegardingObjectOwningBusinessUnit { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey Text { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey TraceCode { get; private set; }

        public VocabularyKey TraceLogId { get; private set; }

        public VocabularyKey TraceRegardingId { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TraceParameterXml { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey IsUnique { get; private set; }

        public VocabularyKey ParentTraceLogId { get; private set; }

        public VocabularyKey TraceParameterHash { get; private set; }

        public VocabularyKey CollationLevel { get; private set; }

        public VocabularyKey IsUniqueName { get; private set; }

        public VocabularyKey TraceDetailXml { get; private set; }

        public VocabularyKey CanBeDeleted { get; private set; }

        public VocabularyKey CanBeDeletedName { get; private set; }

        public VocabularyKey TraceActionXml { get; private set; }

        public VocabularyKey MachineName { get; private set; }

        public VocabularyKey ErrorTypeDisplay { get; private set; }

        public VocabularyKey TraceStatus { get; private set; }

        public VocabularyKey TraceStatusName { get; private set; }

        public VocabularyKey ErrorDetails { get; private set; }


    }
}

