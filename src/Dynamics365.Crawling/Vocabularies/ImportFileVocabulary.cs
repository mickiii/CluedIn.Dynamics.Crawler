using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ImportFileVocabulary : SimpleVocabulary
    {
        public ImportFileVocabulary()
        {
            VocabularyName = "Dynamics365 ImportFile";
            KeyPrefix = "dynamics365.importfile";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ImportFile", group =>
            {
                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Shows the name of the import file. This name is based on the name of the uploaded file.")
                    .WithDisplayName("Import Name")
                    .ModelProperty("name", typeof(string)));

                this.IsFirstRowHeader = group.Add(new VocabularyKey("IsFirstRowHeader", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the first row of the import file contains column headings, which are used for data mapping during the import job.")
                    .WithDisplayName("Is First Row Header")
                    .ModelProperty("isfirstrowheader", typeof(bool)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the business unit that the record owner belongs to.")
                    .WithDisplayName("OwningBusinessUnit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.SuccessCount = group.Add(new VocabularyKey("SuccessCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of records in the import file that are imported successfully.")
                    .WithDisplayName("Successes")
                    .ModelProperty("successcount", typeof(long)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the reason code that explains the import file's status to identify the stage of the import process, from parsing the data to completed.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.AdditionalHeaderRow = group.Add(new VocabularyKey("AdditionalHeaderRow", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100000))
                    .WithDescription(@"Shows the secondary column headers. The additional headers are used during the process of transforming the import file into import data records.")
                    .WithDisplayName("Additional Header")
                    .ModelProperty("additionalheaderrow", typeof(string)));

                this.ProcessCode = group.Add(new VocabularyKey("ProcessCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Tells whether the import file should be ignored or processed during the import.")
                    .WithDisplayName("Process Code")
                    .ModelProperty("processcode", typeof(string)));

                this.ParsedTableColumnsNumber = group.Add(new VocabularyKey("ParsedTableColumnsNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of columns included in the parsed import file.")
                    .WithDisplayName("Parse Table Column Number")
                    .ModelProperty("parsedtablecolumnsnumber", typeof(long)));

                this.Content = group.Add(new VocabularyKey("Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Stores the content of the import file, stored as comma-separated values.")
                    .WithDisplayName("Content")
                    .ModelProperty("content", typeof(string)));

                this.RecordsOwnerId = group.Add(new VocabularyKey("RecordsOwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the user that the records created during the import job should be assigned to.")
                    .WithDisplayName("Records Owner")
                    .ModelProperty("recordsownerid", typeof(string)));

                this.Source = group.Add(new VocabularyKey("Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Shows the name of the data source file uploaded in the import job.")
                    .WithDisplayName("Source")
                    .ModelProperty("source", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.SourceEntityName = group.Add(new VocabularyKey("SourceEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Shows the record type (entity) of the source data.")
                    .WithDisplayName("Source Entity")
                    .ModelProperty("sourceentityname", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the status of the import file record. By default, all records are active and can't be deactivated.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.ParsedTableColumnPrefix = group.Add(new VocabularyKey("ParsedTableColumnPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Shows the prefix applied to each column after the import file is parsed.")
                    .WithDisplayName("Parse Table Column Prefix")
                    .ModelProperty("parsedtablecolumnprefix", typeof(string)));

                this.ParsedTableName = group.Add(new VocabularyKey("ParsedTableName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Shows the name of the table that contains the parsed data from the import file.")
                    .WithDisplayName("Parse Table")
                    .ModelProperty("parsedtablename", typeof(string)));

                this.ProgressCounter = group.Add(new VocabularyKey("ProgressCounter", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the progress code for the processing of the import file. This field is used when a paused import job is resumed.")
                    .WithDisplayName("Progress Counter")
                    .ModelProperty("progresscounter", typeof(long)));

                this.EnableDuplicateDetection = group.Add(new VocabularyKey("EnableDuplicateDetection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether duplicate-detection rules should be run against the import job.")
                    .WithDisplayName("Enable Duplicate Detection")
                    .ModelProperty("enableduplicatedetection", typeof(bool)));

                this.ImportId = group.Add(new VocabularyKey("ImportId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the import job that the file was uploaded for.")
                    .WithDisplayName("Import Job ID")
                    .ModelProperty("importid", typeof(string)));

                this.FailureCount = group.Add(new VocabularyKey("FailureCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of records in the import file that cannot be imported.")
                    .WithDisplayName("Errors")
                    .ModelProperty("failurecount", typeof(long)));

                this.FieldDelimiterCode = group.Add(new VocabularyKey("FieldDelimiterCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the character that is used to separate each field in the import file. Typically, it is a comma.")
                    .WithDisplayName("Field Delimiter")
                    .ModelProperty("fielddelimitercode", typeof(string)));

                this.TargetEntityName = group.Add(new VocabularyKey("TargetEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Select the target record type (entity) for the records that will be created during the import job.")
                    .WithDisplayName("Target Entity")
                    .ModelProperty("targetentityname", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.HeaderRow = group.Add(new VocabularyKey("HeaderRow", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Shows a list of each column header in the import file separated by a comma. The header is used for parsing the file during the import job.")
                    .WithDisplayName("Header")
                    .ModelProperty("headerrow", typeof(string)));

                this.CompletedOn = group.Add(new VocabularyKey("CompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the import associated with the import file was completed.")
                    .WithDisplayName("Completed On")
                    .ModelProperty("completedon", typeof(DateTime)));

                this.DataDelimiterCode = group.Add(new VocabularyKey("DataDelimiterCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the single-character data delimiter used in the import file. This is typically a single or double quotation mark.")
                    .WithDisplayName("Data Delimiter")
                    .ModelProperty("datadelimitercode", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user who is assigned to follow up with or manage the import file. This field is updated every time the import file is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.TotalCount = group.Add(new VocabularyKey("TotalCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total number of records in the import file.")
                    .WithDisplayName("Total Processed")
                    .ModelProperty("totalcount", typeof(long)));

                this.ProcessingStatus = group.Add(new VocabularyKey("ProcessingStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the import file's processing status code. This indicates whether the data in the import file has been parsed, transformed, or imported.")
                    .WithDisplayName("Processing Status")
                    .ModelProperty("processingstatus", typeof(string)));

                this.ImportFileId = group.Add(new VocabularyKey("ImportFileId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the import file.")
                    .WithDisplayName("Import")
                    .ModelProperty("importfileid", typeof(Guid)));

                this.Size = group.Add(new VocabularyKey("Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Shows the size of the import file, in kilobytes.")
                    .WithDisplayName("Size")
                    .ModelProperty("size", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ImportMapId = group.Add(new VocabularyKey("ImportMapId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose a data map to match the import file and its column headers with the record types and fields in Microsoft Dynamics 365. If the column headers in the file match the display names of the target fields in Microsoft Dynamics 365, we import the data automatically. If not, you can manually define matches during import.")
                    .WithDisplayName("Data Map")
                    .ModelProperty("importmapid", typeof(string)));

                this.UseSystemMap = group.Add(new VocabularyKey("UseSystemMap", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Tells whether an automatic system map was applied to the import file, which automatically maps the import data to the target entity in Microsoft Dynamics 365.")
                    .WithDisplayName("Use System Map")
                    .ModelProperty("usesystemmap", typeof(bool)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.RecordsOwnerIdType = group.Add(new VocabularyKey("RecordsOwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RecordsOwnerIdType")
                    .ModelProperty("recordsowneridtype", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the import file.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.RecordsOwnerIdName = group.Add(new VocabularyKey("RecordsOwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the record owner.")
                    .WithDisplayName("RecordsOwnerIdName")
                    .ModelProperty("recordsowneridname", typeof(string)));

                this.DataDelimiterName = group.Add(new VocabularyKey("DataDelimiterName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Data delimiter for the content of import file.")
                    .WithDisplayName("DataDelimiterName")
                    .ModelProperty("datadelimitername", typeof(string)));

                this.IsFirstRowHeaderName = group.Add(new VocabularyKey("IsFirstRowHeaderName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the first row contains column headings.")
                    .WithDisplayName("IsFirstRowHeaderName")
                    .ModelProperty("isfirstrowheadername", typeof(string)));

                this.ImportMapIdName = group.Add(new VocabularyKey("ImportMapIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the import map.")
                    .WithDisplayName("ImportMapIdName")
                    .ModelProperty("importmapidname", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ProcessCodeName = group.Add(new VocabularyKey("ProcessCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Process code name for ProcessCode")
                    .WithDisplayName("ProcessCodeName")
                    .ModelProperty("processcodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Name of the status reason of the import file.")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.UseSystemMapName = group.Add(new VocabularyKey("UseSystemMapName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UseSystemMapName")
                    .ModelProperty("usesystemmapname", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status name of the import file.")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.ImportIdName = group.Add(new VocabularyKey("ImportIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the import.")
                    .WithDisplayName("ImportIdName")
                    .ModelProperty("importidname", typeof(string)));

                this.ProcessingStatusName = group.Add(new VocabularyKey("ProcessingStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Processing Status name for ProcessingStatus")
                    .WithDisplayName("ProcessingStatusName")
                    .ModelProperty("processingstatusname", typeof(string)));

                this.FieldDelimiterName = group.Add(new VocabularyKey("FieldDelimiterName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Field delimiter for the content of import file.")
                    .WithDisplayName("FieldDelimiterName")
                    .ModelProperty("fielddelimitername", typeof(string)));

                this.EnableDuplicateDetectionName = group.Add(new VocabularyKey("EnableDuplicateDetectionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indication of whether duplicate detection is enabled or not.")
                    .WithDisplayName("EnableDuplicateDetectionName")
                    .ModelProperty("enableduplicatedetectionname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.RelatedEntityColumns = group.Add(new VocabularyKey("RelatedEntityColumns", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Shows the columns that are mapped to a related record type (entity) of the primary record type (entity) included in the import file.")
                    .WithDisplayName("RelatedEntityColumns")
                    .ModelProperty("relatedentitycolumns", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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

                this.FileTypeCode = group.Add(new VocabularyKey("FileTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the type of source file that is uploaded for import.")
                    .WithDisplayName("File Type")
                    .ModelProperty("filetypecode", typeof(string)));

                this.FileTypeName = group.Add(new VocabularyKey("FileTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"File type of the uploaded source file")
                    .WithDisplayName("FileTypeName")
                    .ModelProperty("filetypename", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the import file.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.PartialFailureCount = group.Add(new VocabularyKey("PartialFailureCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of records in this file that had failures during the import.")
                    .WithDisplayName("Partial Failures")
                    .ModelProperty("partialfailurecount", typeof(long)));

                this.UpsertModeCode = group.Add(new VocabularyKey("UpsertModeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the value which is used for identify the upsert mode. By Default, it is a Create.")
                    .WithDisplayName("Upsert Mode")
                    .ModelProperty("upsertmodecode", typeof(string)));

                this.UpsertModeName = group.Add(new VocabularyKey("UpsertModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Upsert Mode type of the uploaded source file")
                    .WithDisplayName("UpsertModeName")
                    .ModelProperty("upsertmodename", typeof(string)));

                this.EntityKeyId = group.Add(new VocabularyKey("EntityKeyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Alternate key Id")
                    .WithDisplayName("Entity Key ID")
                    .ModelProperty("entitykeyid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey IsFirstRowHeader { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey SuccessCount { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey AdditionalHeaderRow { get; private set; }

        public VocabularyKey ProcessCode { get; private set; }

        public VocabularyKey ParsedTableColumnsNumber { get; private set; }

        public VocabularyKey Content { get; private set; }

        public VocabularyKey RecordsOwnerId { get; private set; }

        public VocabularyKey Source { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey SourceEntityName { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey ParsedTableColumnPrefix { get; private set; }

        public VocabularyKey ParsedTableName { get; private set; }

        public VocabularyKey ProgressCounter { get; private set; }

        public VocabularyKey EnableDuplicateDetection { get; private set; }

        public VocabularyKey ImportId { get; private set; }

        public VocabularyKey FailureCount { get; private set; }

        public VocabularyKey FieldDelimiterCode { get; private set; }

        public VocabularyKey TargetEntityName { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey HeaderRow { get; private set; }

        public VocabularyKey CompletedOn { get; private set; }

        public VocabularyKey DataDelimiterCode { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey TotalCount { get; private set; }

        public VocabularyKey ProcessingStatus { get; private set; }

        public VocabularyKey ImportFileId { get; private set; }

        public VocabularyKey Size { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ImportMapId { get; private set; }

        public VocabularyKey UseSystemMap { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey RecordsOwnerIdType { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey RecordsOwnerIdName { get; private set; }

        public VocabularyKey DataDelimiterName { get; private set; }

        public VocabularyKey IsFirstRowHeaderName { get; private set; }

        public VocabularyKey ImportMapIdName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ProcessCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey UseSystemMapName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ImportIdName { get; private set; }

        public VocabularyKey ProcessingStatusName { get; private set; }

        public VocabularyKey FieldDelimiterName { get; private set; }

        public VocabularyKey EnableDuplicateDetectionName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey RelatedEntityColumns { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey FileTypeCode { get; private set; }

        public VocabularyKey FileTypeName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey PartialFailureCount { get; private set; }

        public VocabularyKey UpsertModeCode { get; private set; }

        public VocabularyKey UpsertModeName { get; private set; }

        public VocabularyKey EntityKeyId { get; private set; }


    }
}

