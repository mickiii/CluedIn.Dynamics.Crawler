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
    public abstract class SocialInsightsConfigurationClueProducer<T> : DynamicsClueProducer<T> where T : SocialInsightsConfiguration
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SocialInsightsConfigurationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SocialInsightsConfigurationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=socialinsightsconfiguration&id={1}", _dynamics365CrawlJobData.Api, input.SocialInsightsConfigurationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.FormId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemform, EntityEdgeType.Parent, input, input.FormId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.FormId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.userform, EntityEdgeType.Parent, input, input.FormId);


            */
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.FormId] = input.FormId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.FormIdName] = input.FormIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.SocialInsightsConfigurationId] = input.SocialInsightsConfigurationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ControlId] = input.ControlId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.SocialDataItemId] = input.SocialDataItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.SocialDataParameters] = input.SocialDataParameters.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.FormTypeCode] = input.FormTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.FormTypeCodeName] = input.FormTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.SocialDataItemType] = input.SocialDataItemType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SocialInsightsConfiguration.SocialDataItemTypeName] = input.SocialDataItemTypeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

