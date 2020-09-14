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
    public abstract class MailMergeTemplateClueProducer<T> : DynamicsClueProducer<T> where T : MailMergeTemplate
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public MailMergeTemplateClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.MailMergeTemplateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=mailmergetemplate&id={1}", _dynamics365CrawlJobData.Api, input.MailMergeTemplateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.Body] = input.Body.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.TemplateTypeCode] = input.TemplateTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ParameterXml] = input.ParameterXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.MailMergeType] = input.MailMergeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.DefaultFilter] = input.DefaultFilter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.LanguageCode] = input.LanguageCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.DocumentFormat] = input.DocumentFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.MailMergeTemplateId] = input.MailMergeTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.IsPersonal] = input.IsPersonal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.DocumentFormatName] = input.DocumentFormatName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.TemplateTypeCodeName] = input.TemplateTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.IsPersonalName] = input.IsPersonalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.MailMergeTypeName] = input.MailMergeTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.MailMergeTemplateIdUnique] = input.MailMergeTemplateIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailMergeTemplate.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

