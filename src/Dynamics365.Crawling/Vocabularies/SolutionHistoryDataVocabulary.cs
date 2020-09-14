using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SolutionHistoryDataVocabulary : SimpleVocabulary
    {
        public SolutionHistoryDataVocabulary()
        {
            VocabularyName = "Dynamics365 SolutionHistoryData";
            KeyPrefix = "dynamics365.solutionhistorydata";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SolutionHistoryData", group =>
            {
                this.SolutionHistoryDataId = group.Add(new VocabularyKey("SolutionHistoryDataId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("SolutionHistoryDataId")
                    .ModelProperty("solutionhistorydataid", typeof(Guid)));

                this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"DateTime of the start of the solution event.")
                    .WithDisplayName("Start Time")
                    .ModelProperty("starttime", typeof(DateTime)));

                this.EndTime = group.Add(new VocabularyKey("EndTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"DateTime of the end of the solution event.")
                    .WithDisplayName("End Time")
                    .ModelProperty("endtime", typeof(DateTime)));

                this.Operation = group.Add(new VocabularyKey("Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The operation performed on the solution.")
                    .WithDisplayName("Operation")
                    .ModelProperty("operation", typeof(string)));

                this.SubOperation = group.Add(new VocabularyKey("SubOperation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The suboperation performed on the solution.")
                    .WithDisplayName("SubOperation")
                    .ModelProperty("suboperation", typeof(string)));

                this.Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The status of the operation performed on the solution.")
                    .WithDisplayName("Status")
                    .ModelProperty("status", typeof(string)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The Solution.")
                    .WithDisplayName("The Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.SolutionName = group.Add(new VocabularyKey("SolutionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(65))
                    .WithDescription(@"Name of the solution.")
                    .WithDisplayName("SolutionName")
                    .ModelProperty("solutionname", typeof(string)));

                this.SolutionVersion = group.Add(new VocabularyKey("SolutionVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"The Version of the Solution.")
                    .WithDisplayName("SolutionVersion")
                    .ModelProperty("solutionversion", typeof(string)));

                this.Result = group.Add(new VocabularyKey("Result", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The result of the operation performed on the solution.")
                    .WithDisplayName("Result")
                    .ModelProperty("result", typeof(long)));

                this.ErrorCode = group.Add(new VocabularyKey("ErrorCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The error code of the operation performed on the solution.")
                    .WithDisplayName("ErrorCode")
                    .ModelProperty("errorcode", typeof(long)));

                this.ExceptionMessage = group.Add(new VocabularyKey("ExceptionMessage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"The Exception Message.")
                    .WithDisplayName("ExceptionMessage")
                    .ModelProperty("exceptionmessage", typeof(string)));

                this.ExceptionStack = group.Add(new VocabularyKey("ExceptionStack", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"The Exception Stack.")
                    .WithDisplayName("ExceptionStack")
                    .ModelProperty("exceptionstack", typeof(string)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The Activity Id.")
                    .WithDisplayName("The Activity Id")
                    .ModelProperty("activityid", typeof(Guid)));

                this.CorrelationId = group.Add(new VocabularyKey("CorrelationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The Correlation Id.")
                    .WithDisplayName("The Correlation Id")
                    .ModelProperty("correlationid", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is Solution Managed")
                    .WithDisplayName("Is Solution Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsPatch = group.Add(new VocabularyKey("IsPatch", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is Solution Patch")
                    .WithDisplayName("Is Solution Patch")
                    .ModelProperty("ispatch", typeof(bool)));

                this.IsOverwriteCustomizations = group.Add(new VocabularyKey("IsOverwriteCustomizations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Does the event overwrite customizations.")
                    .WithDisplayName("Is Overwrite Customizations")
                    .ModelProperty("isoverwritecustomizations", typeof(bool)));

                this.IsMicrosoftPublisher = group.Add(new VocabularyKey("IsMicrosoftPublisher", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is the solution published by a Microsoft publisher.")
                    .WithDisplayName("Is Published by Microsoft")
                    .ModelProperty("ismicrosoftpublisher", typeof(bool)));

                this.PublisherName = group.Add(new VocabularyKey("PublisherName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(512))
                    .WithDescription(@"Name of the solution's publisher.")
                    .WithDisplayName("PublisherName")
                    .ModelProperty("publishername", typeof(string)));

                this.PackageName = group.Add(new VocabularyKey("PackageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Name of the package.")
                    .WithDisplayName("PackageName")
                    .ModelProperty("packagename", typeof(string)));

                this.PackageVersion = group.Add(new VocabularyKey("PackageVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Version of the package.")
                    .WithDisplayName("PackageVersion")
                    .ModelProperty("packageversion", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SolutionHistoryDataId { get; private set; }

        public VocabularyKey StartTime { get; private set; }

        public VocabularyKey EndTime { get; private set; }

        public VocabularyKey Operation { get; private set; }

        public VocabularyKey SubOperation { get; private set; }

        public VocabularyKey Status { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SolutionName { get; private set; }

        public VocabularyKey SolutionVersion { get; private set; }

        public VocabularyKey Result { get; private set; }

        public VocabularyKey ErrorCode { get; private set; }

        public VocabularyKey ExceptionMessage { get; private set; }

        public VocabularyKey ExceptionStack { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey CorrelationId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsPatch { get; private set; }

        public VocabularyKey IsOverwriteCustomizations { get; private set; }

        public VocabularyKey IsMicrosoftPublisher { get; private set; }

        public VocabularyKey PublisherName { get; private set; }

        public VocabularyKey PackageName { get; private set; }

        public VocabularyKey PackageVersion { get; private set; }


    }
}

