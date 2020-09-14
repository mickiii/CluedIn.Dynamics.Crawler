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
    public abstract class PostFollowClueProducer<T> : DynamicsClueProducer<T> where T : PostFollow
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PostFollowClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PostFollowId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=postfollow&id={1}", _dynamics365CrawlJobData.Api, input.PostFollowId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.RegardingObjectIdName;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processsession, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.PostFollowId] = input.PostFollowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.RegardingObjectIdYomiName] = input.RegardingObjectIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.PostToYammer] = input.PostToYammer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.YammerPostState] = input.YammerPostState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.YammerRetryCount] = input.YammerRetryCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PostFollow.VersionNumber] = input.VersionNumber.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

