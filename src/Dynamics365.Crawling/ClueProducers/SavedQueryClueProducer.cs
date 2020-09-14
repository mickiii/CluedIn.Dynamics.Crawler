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
    public abstract class SavedQueryClueProducer<T> : DynamicsClueProducer<T> where T : SavedQuery
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SavedQueryClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SavedQueryId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=savedquery&id={1}", _dynamics365CrawlJobData.Api, input.SavedQueryId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SavedQuery.SavedQueryId] = input.SavedQueryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.QueryType] = input.QueryType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ReturnedTypeCode] = input.ReturnedTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.QueryAppUsage] = input.QueryAppUsage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsUserDefined] = input.IsUserDefined.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.FetchXml] = input.FetchXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsQuickFindQuery] = input.IsQuickFindQuery.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ColumnSetXml] = input.ColumnSetXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.LayoutXml] = input.LayoutXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.QueryAPI] = input.QueryAPI.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsQuickFindQueryName] = input.IsQuickFindQueryName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsUserDefinedName] = input.IsUserDefinedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsCustomizableName] = input.IsCustomizableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.OfflineSqlQuery] = input.OfflineSqlQuery.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.SavedQueryIdUnique] = input.SavedQueryIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.AdvancedGroupBy] = input.AdvancedGroupBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.ConditionalFormatting] = input.ConditionalFormatting.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.OrganizationTabOrder] = input.OrganizationTabOrder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.CanBeDeleted] = input.CanBeDeleted.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.IsCustom] = input.IsCustom.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SavedQuery.LayoutJson] = input.LayoutJson.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

