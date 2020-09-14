using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class MailboxStatistics : DynamicsModel
    {
        [JsonProperty("mailboxstatisticsid")]
        public Guid? MailboxStatisticsId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("mailboxid")]
        public string MailboxId { get; set; }

        [JsonProperty("operationtypeid")]
        public string OperationTypeId { get; set; }

        [JsonProperty("itemsprocessed")]
        public long? ItemsProcessed { get; set; }

        [JsonProperty("itemsfailed")]
        public long? ItemsFailed { get; set; }

        [JsonProperty("processresult")]
        public bool? ProcessResult { get; set; }

        [JsonProperty("mailboxprocessscheduledon")]
        public DateTimeOffset? MailboxProcessScheduledOn { get; set; }

        [JsonProperty("machinename")]
        public string MachineName { get; set; }

        [JsonProperty("mailboxprocessstartedon")]
        public DateTimeOffset? MailboxProcessStartedOn { get; set; }

        [JsonProperty("crmitemsbacklog")]
        public long? CrmItemsBacklog { get; set; }

        [JsonProperty("mailboxprocesscompletedon")]
        public DateTimeOffset? MailboxProcessCompletedOn { get; set; }

        [JsonProperty("individualstepdurations")]
        public string IndividualStepDurations { get; set; }

        [JsonProperty("scheduledtimeintervalinminutes")]
        public long? ScheduledTimeIntervalInMinutes { get; set; }

        [JsonProperty("processtimeintervalinminutes")]
        public long? ProcessTimeIntervalInMinutes { get; set; }

        [JsonProperty("processresultname")]
        public string ProcessResultName { get; set; }

        [JsonProperty("operationtypeidname")]
        public string OperationTypeIdName { get; set; }

        [JsonProperty("asynceventid")]
        public Guid? AsyncEventId { get; set; }


    }
}

