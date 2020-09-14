using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RibbonMetadataToProcessVocabulary : SimpleVocabulary
    {
        public RibbonMetadataToProcessVocabulary()
        {
            VocabularyName = "Dynamics365 RibbonMetadataToProcess";
            KeyPrefix = "dynamics365.ribbonmetadatatoprocess";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RibbonMetadataToProcess", group =>
            {
                this.RibbonMetadataRowId = group.Add(new VocabularyKey("RibbonMetadataRowId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for Ribbon Metadata Instance To Process")
                    .WithDisplayName("Ribbon Metadata To Process")
                    .ModelProperty("ribbonmetadatarowid", typeof(Guid)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Solution Id")
                    .WithDisplayName("Solution Id")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.EntityName = group.Add(new VocabularyKey("EntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Entity Logical Name")
                    .WithDisplayName("Entity Logical Name")
                    .ModelProperty("entityname", typeof(string)));

                this.Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status")
                    .WithDisplayName("Status")
                    .ModelProperty("status", typeof(long)));

                this.RetryCount = group.Add(new VocabularyKey("RetryCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Retry Count")
                    .WithDisplayName("Retry Count")
                    .ModelProperty("retrycount", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ProcessedOn = group.Add(new VocabularyKey("ProcessedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was processed. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Processed On")
                    .ModelProperty("processedon", typeof(DateTime)));

                this.CompletedOn = group.Add(new VocabularyKey("CompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the ribbon entity record has finished processing. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Completed On")
                    .ModelProperty("completedon", typeof(DateTime)));

                this.ExceptionMessage = group.Add(new VocabularyKey("ExceptionMessage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1024))
                    .WithDescription(@"Exception message")
                    .WithDisplayName("Exception message which occurred during ribbon entity processing.")
                    .ModelProperty("exceptionmessage", typeof(string)));

                this.IsDbUpdate = group.Add(new VocabularyKey("IsDbUpdate", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Is entity created via Db Update")
                    .WithDisplayName("Is entity created via Db Update")
                    .ModelProperty("isdbupdate", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RibbonMetadataRowId { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey EntityName { get; private set; }

        public VocabularyKey Status { get; private set; }

        public VocabularyKey RetryCount { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ProcessedOn { get; private set; }

        public VocabularyKey CompletedOn { get; private set; }

        public VocabularyKey ExceptionMessage { get; private set; }

        public VocabularyKey IsDbUpdate { get; private set; }


    }
}

