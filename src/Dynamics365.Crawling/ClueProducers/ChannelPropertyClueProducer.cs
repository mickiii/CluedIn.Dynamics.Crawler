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
    public abstract class ChannelPropertyClueProducer<T> : DynamicsClueProducer<T> where T : ChannelProperty
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ChannelPropertyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ChannelPropertyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=channelproperty&id={1}", _dynamics365CrawlJobData.Api, input.ChannelPropertyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelpropertygroup, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ChannelPropertyId] = input.ChannelPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.Applicationsource] = input.Applicationsource.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.DataTypeName] = input.DataTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.DataType] = input.DataType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelProperty.ChannelPropertyIdUnique] = input.ChannelPropertyIdUnique.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

