using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class MailboxStatisticsVocabulary : SimpleVocabulary
    {
        public MailboxStatisticsVocabulary()
        {
            VocabularyName = "Dynamics365 MailboxStatistics";
            KeyPrefix = "dynamics365.mailboxstatistics";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("MailboxStatistics", group =>
            {
                this.MailboxStatisticsId = group.Add(new VocabularyKey("MailboxStatisticsId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MailboxStatisticsId")
                    .ModelProperty("mailboxstatisticsid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the record.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.MailboxId = group.Add(new VocabularyKey("MailboxId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Regarding Mailbox.")
                    .WithDisplayName("Regarding Mailbox")
                    .ModelProperty("mailboxid", typeof(string)));

                this.OperationTypeId = group.Add(new VocabularyKey("OperationTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the mailbox operation")
                    .WithDisplayName("Mailbox Operation Type")
                    .ModelProperty("operationtypeid", typeof(string)));

                this.ItemsProcessed = group.Add(new VocabularyKey("ItemsProcessed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of items processed.")
                    .WithDisplayName("Items Processed")
                    .ModelProperty("itemsprocessed", typeof(long)));

                this.ItemsFailed = group.Add(new VocabularyKey("ItemsFailed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of items processed unsuccessfully.")
                    .WithDisplayName("Items Failed")
                    .ModelProperty("itemsfailed", typeof(long)));

                this.ProcessResult = group.Add(new VocabularyKey("ProcessResult", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Result of Mailbox processing cycle")
                    .WithDisplayName("Process Result")
                    .ModelProperty("processresult", typeof(bool)));

                this.MailboxProcessScheduledOn = group.Add(new VocabularyKey("MailboxProcessScheduledOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled time of the synchronization cycle.")
                    .WithDisplayName("Scheduled Time for Processing")
                    .ModelProperty("mailboxprocessscheduledon", typeof(DateTime)));

                this.MachineName = group.Add(new VocabularyKey("MachineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of Machine on which mailbox was processed")
                    .WithDisplayName("Machine Name")
                    .ModelProperty("machinename", typeof(string)));

                this.MailboxProcessStartedOn = group.Add(new VocabularyKey("MailboxProcessStartedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Start time of the synchronization cycle.")
                    .WithDisplayName("Start Time for Processing")
                    .ModelProperty("mailboxprocessstartedon", typeof(DateTime)));

                this.CrmItemsBacklog = group.Add(new VocabularyKey("CrmItemsBacklog", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Items remaining in CRM to process after this synchronization cycle.")
                    .WithDisplayName("Items in CRM Left to Process")
                    .ModelProperty("crmitemsbacklog", typeof(long)));

                this.MailboxProcessCompletedOn = group.Add(new VocabularyKey("MailboxProcessCompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Completion time of the synchronization cycle.")
                    .WithDisplayName("End Time for Processing")
                    .ModelProperty("mailboxprocesscompletedon", typeof(DateTime)));

                this.IndividualStepDurations = group.Add(new VocabularyKey("IndividualStepDurations", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Time each exchange sync step is taking")
                    .WithDisplayName("Individual Step Durations")
                    .ModelProperty("individualstepdurations", typeof(string)));

                this.ScheduledTimeIntervalInMinutes = group.Add(new VocabularyKey("ScheduledTimeIntervalInMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time it took from the scheduled time to the actual start time to process the mailbox.")
                    .WithDisplayName("Queue Duration")
                    .ModelProperty("scheduledtimeintervalinminutes", typeof(long)));

                this.ProcessTimeIntervalInMinutes = group.Add(new VocabularyKey("ProcessTimeIntervalInMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time it took to process the mailbox.")
                    .WithDisplayName("Process Duration")
                    .ModelProperty("processtimeintervalinminutes", typeof(long)));

                this.ProcessResultName = group.Add(new VocabularyKey("ProcessResultName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ProcessResultName")
                    .ModelProperty("processresultname", typeof(string)));

                this.OperationTypeIdName = group.Add(new VocabularyKey("OperationTypeIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OperationTypeIdName")
                    .ModelProperty("operationtypeidname", typeof(string)));

                this.AsyncEventId = group.Add(new VocabularyKey("AsyncEventId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Async Event Id")
                    .ModelProperty("asynceventid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey MailboxStatisticsId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey MailboxId { get; private set; }

        public VocabularyKey OperationTypeId { get; private set; }

        public VocabularyKey ItemsProcessed { get; private set; }

        public VocabularyKey ItemsFailed { get; private set; }

        public VocabularyKey ProcessResult { get; private set; }

        public VocabularyKey MailboxProcessScheduledOn { get; private set; }

        public VocabularyKey MachineName { get; private set; }

        public VocabularyKey MailboxProcessStartedOn { get; private set; }

        public VocabularyKey CrmItemsBacklog { get; private set; }

        public VocabularyKey MailboxProcessCompletedOn { get; private set; }

        public VocabularyKey IndividualStepDurations { get; private set; }

        public VocabularyKey ScheduledTimeIntervalInMinutes { get; private set; }

        public VocabularyKey ProcessTimeIntervalInMinutes { get; private set; }

        public VocabularyKey ProcessResultName { get; private set; }

        public VocabularyKey OperationTypeIdName { get; private set; }

        public VocabularyKey AsyncEventId { get; private set; }


    }
}

