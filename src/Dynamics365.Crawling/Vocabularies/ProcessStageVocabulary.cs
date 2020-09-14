using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ProcessStageVocabulary : SimpleVocabulary
    {
        public ProcessStageVocabulary()
        {
            VocabularyName = "Dynamics365 ProcessStage";
            KeyPrefix = "dynamics365.processstage";
            KeySeparator = ".";
            Grouping = EntityType.ProcessStage;

            this.AddGroup("ProcessStage", group =>
            {
                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the business unit that owns the record.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.PrimaryEntityTypeCode = group.Add(new VocabularyKey("PrimaryEntityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Primary entity associated with the stage.")
                    .WithDisplayName("Primary Entity")
                    .ModelProperty("primaryentitytypecode", typeof(string)));

                this.PrimaryEntityTypeCodeName = group.Add(new VocabularyKey("PrimaryEntityTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryEntityTypeCodeName")
                    .ModelProperty("primaryentitytypecodename", typeof(string)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(string)));

                this.ProcessIdName = group.Add(new VocabularyKey("ProcessIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ProcessIdName")
                    .ModelProperty("processidname", typeof(string)));

                this.ProcessStageId = group.Add(new VocabularyKey("ProcessStageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the ID of the process stage record.")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("processstageid", typeof(Guid)));

                this.StageCategory = group.Add(new VocabularyKey("StageCategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the category of the sales process.")
                    .WithDisplayName("Stage Category")
                    .ModelProperty("stagecategory", typeof(string)));

                this.StageCategoryName = group.Add(new VocabularyKey("StageCategoryName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StageCategoryName")
                    .ModelProperty("stagecategoryname", typeof(string)));

                this.StageName = group.Add(new VocabularyKey("StageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a name for the process stage.")
                    .WithDisplayName("Process Stage Name")
                    .ModelProperty("stagename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the process stage.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ClientData = group.Add(new VocabularyKey("ClientData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Step metadata for process stage")
                    .WithDisplayName("Client Data")
                    .ModelProperty("clientdata", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey PrimaryEntityTypeCode { get; private set; }

        public VocabularyKey PrimaryEntityTypeCodeName { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey ProcessIdName { get; private set; }

        public VocabularyKey ProcessStageId { get; private set; }

        public VocabularyKey StageCategory { get; private set; }

        public VocabularyKey StageCategoryName { get; private set; }

        public VocabularyKey StageName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ClientData { get; private set; }


    }
}

