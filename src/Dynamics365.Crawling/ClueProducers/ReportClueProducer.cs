using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class ReportClueProducer<T> : DynamicsClueProducer<T> where T : Report
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ReportClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.ReportId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=report&id={1}", _dynamics365CrawlJobData.Api, input.ReportId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ParentReportId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.report, EntityEdgeType.Parent, input, input.ParentReportId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.Report.DefaultFilter] = input.DefaultFilter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsCustomReport] = input.IsCustomReport.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SignatureMajorVersion] = input.SignatureMajorVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.BodyText] = input.BodyText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsPersonal] = input.IsPersonal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SignatureLcid] = input.SignatureLcid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CustomReportXml] = input.CustomReportXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ScheduleXml] = input.ScheduleXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SignatureDate] = input.SignatureDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ParentReportId] = input.ParentReportId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.BodyBinary] = input.BodyBinary.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.QueryInfo] = input.QueryInfo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.LanguageCode] = input.LanguageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SignatureId] = input.SignatureId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.BodyUrl] = input.BodyUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SignatureMinorVersion] = input.SignatureMinorVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ReportId] = input.ReportId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsScheduledReport] = input.IsScheduledReport.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ReportTypeCode] = input.ReportTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsScheduledReportName] = input.IsScheduledReportName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ParentReportIdName] = input.ParentReportIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ReportTypeCodeName] = input.ReportTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsPersonalName] = input.IsPersonalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsCustomReportName] = input.IsCustomReportName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ReportIdUnique] = input.ReportIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ReportNameOnSRS] = input.ReportNameOnSRS.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.OriginalBodyText] = input.OriginalBodyText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.CreatedInMajorVersion] = input.CreatedInMajorVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Report.RdlHash] = input.RdlHash.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

