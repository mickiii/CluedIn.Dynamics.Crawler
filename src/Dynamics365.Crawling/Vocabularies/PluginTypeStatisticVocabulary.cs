using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PluginTypeStatisticVocabulary : SimpleVocabulary
    {
        public PluginTypeStatisticVocabulary()
        {
            VocabularyName = "Dynamics365 PluginTypeStatistic";
            KeyPrefix = "dynamics365.plugintypestatistic";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("PluginTypeStatistic", group =>
            {
                this.PluginTypeStatisticId = group.Add(new VocabularyKey("PluginTypeStatisticId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the plug-in type statistic.")
                    .WithDisplayName("PluginTypeStatisticId")
                    .ModelProperty("plugintypestatisticid", typeof(Guid)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the plug-in type statistic.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the plug-in type statistic was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the plug-in type statistic.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the plug-in type statistic was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.PluginTypeId = group.Add(new VocabularyKey("PluginTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the plug-in type associated with this plug-in type statistic.")
                    .WithDisplayName("Plugin Type")
                    .ModelProperty("plugintypeid", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the plug-in type statistic is associated.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.ExecuteCount = group.Add(new VocabularyKey("ExecuteCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of times the plug-in type has been executed.")
                    .WithDisplayName("Execution Count")
                    .ModelProperty("executecount", typeof(long)));

                this.FailureCount = group.Add(new VocabularyKey("FailureCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of times the plug-in type has failed.")
                    .WithDisplayName("Failure Count")
                    .ModelProperty("failurecount", typeof(long)));

                this.CrashCount = group.Add(new VocabularyKey("CrashCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of times the plug-in type has crashed.")
                    .WithDisplayName("Number of times crashed")
                    .ModelProperty("crashcount", typeof(long)));

                this.FailurePercent = group.Add(new VocabularyKey("FailurePercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Percentage of failures for the plug-in type.")
                    .WithDisplayName("Failure Percent")
                    .ModelProperty("failurepercent", typeof(long)));

                this.CrashPercent = group.Add(new VocabularyKey("CrashPercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Percentage of crashes for the plug-in type.")
                    .WithDisplayName("Percentage of crashes")
                    .ModelProperty("crashpercent", typeof(long)));

                this.CrashContributionPercent = group.Add(new VocabularyKey("CrashContributionPercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The plug-in type percentage contribution to crashes.")
                    .WithDisplayName("Percentage contribution to crashes")
                    .ModelProperty("crashcontributionpercent", typeof(long)));

                this.TerminateCpuContributionPercent = group.Add(new VocabularyKey("TerminateCpuContributionPercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The plug-in type percentage contribution to Worker process termination due to excessive CPU usage.")
                    .WithDisplayName("Terminate CPU Contribution Percent")
                    .ModelProperty("terminatecpucontributionpercent", typeof(long)));

                this.TerminateMemoryContributionPercent = group.Add(new VocabularyKey("TerminateMemoryContributionPercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The plug-in type percentage contribution to Worker process termination due to excessive memory usage.")
                    .WithDisplayName("Terminate Memory Contribution Percent")
                    .ModelProperty("terminatememorycontributionpercent", typeof(long)));

                this.TerminateHandlesContributionPercent = group.Add(new VocabularyKey("TerminateHandlesContributionPercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The plug-in type percentage contribution to Worker process termination due to excessive handle usage.")
                    .WithDisplayName("Terminate Handles Contribution Percent")
                    .ModelProperty("terminatehandlescontributionpercent", typeof(long)));

                this.TerminateOtherContributionPercent = group.Add(new VocabularyKey("TerminateOtherContributionPercent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The plug-in type percentage contribution to Worker process termination due to unknown reasons.")
                    .WithDisplayName("Terminate Other Contribution Percent")
                    .ModelProperty("terminateothercontributionpercent", typeof(long)));

                this.AverageExecuteTimeInMilliseconds = group.Add(new VocabularyKey("AverageExecuteTimeInMilliseconds", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The average execution time (in milliseconds) for the plug-in type.")
                    .WithDisplayName("The average execution time")
                    .ModelProperty("averageexecutetimeinmilliseconds", typeof(long)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the plug-in type statistic.")
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

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the plug-in type statistic.")
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

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.PluginTypeIdName = group.Add(new VocabularyKey("PluginTypeIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PluginTypeIdName")
                    .ModelProperty("plugintypeidname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey PluginTypeStatisticId { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey PluginTypeId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ExecuteCount { get; private set; }

        public VocabularyKey FailureCount { get; private set; }

        public VocabularyKey CrashCount { get; private set; }

        public VocabularyKey FailurePercent { get; private set; }

        public VocabularyKey CrashPercent { get; private set; }

        public VocabularyKey CrashContributionPercent { get; private set; }

        public VocabularyKey TerminateCpuContributionPercent { get; private set; }

        public VocabularyKey TerminateMemoryContributionPercent { get; private set; }

        public VocabularyKey TerminateHandlesContributionPercent { get; private set; }

        public VocabularyKey TerminateOtherContributionPercent { get; private set; }

        public VocabularyKey AverageExecuteTimeInMilliseconds { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey PluginTypeIdName { get; private set; }


    }
}

