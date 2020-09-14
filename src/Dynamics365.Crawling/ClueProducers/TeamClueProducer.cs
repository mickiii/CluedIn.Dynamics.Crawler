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
    public abstract class TeamClueProducer<T> : DynamicsClueProducer<T> where T : Team
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public TeamClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Infrastructure.Group, input.TeamId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=team&id={1}", this._dynamics365CrawlJobData.Api, input.TeamId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.RegardingObjectId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

            //if (input.QueueId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.QueueId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TeamTemplateId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.teamtemplate, EntityEdgeType.Parent, input, input.TeamTemplateId);

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.BusinessUnitId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.Parent, input, input.BusinessUnitId);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.AdministratorId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.AdministratorId);

            if (input.OrganizationId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.OrganizationId.ToString());

            if (input.RegardingObjectId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

            data.Properties[Dynamics365Vocabulary.Team.TeamId] = input.TeamId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.EMailAddress] = input.EMailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.AdministratorId] = input.AdministratorId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.AdministratorIdName] = input.AdministratorIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.AdministratorIdYomiName] = input.AdministratorIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.YomiName] = input.YomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.AzureActiveDirectoryObjectId] = input.AzureActiveDirectoryObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.QueueId] = input.QueueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.QueueIdName] = input.QueueIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.TeamType] = input.TeamType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.TeamTypeName] = input.TeamTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.TeamTemplateId] = input.TeamTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.SystemManaged] = input.SystemManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.SystemManagedName] = input.SystemManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Team.ProcessId] = input.ProcessId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

