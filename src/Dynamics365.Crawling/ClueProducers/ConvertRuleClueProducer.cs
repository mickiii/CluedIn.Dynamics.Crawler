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
    public abstract class ConvertRuleClueProducer<T> : DynamicsClueProducer<T> where T : ConvertRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ConvertRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ConvertRuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=convertrule&id={1}", _dynamics365CrawlJobData.Api, input.ConvertRuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ChannelPropertyGroupId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelpropertygroup, EntityEdgeType.Parent, input, input.ChannelPropertyGroupId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.QueueId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.QueueId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.WorkflowId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.WorkflowId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.ResponseTemplateId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.template, EntityEdgeType.Parent, input, input.ResponseTemplateId);


            */
            data.Properties[Dynamics365Vocabulary.ConvertRule.ConvertRuleId] = input.ConvertRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.AllowUnknownSender] = input.AllowUnknownSender.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ChannelPropertyGroupId] = input.ChannelPropertyGroupId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckActiveEntitlement] = input.CheckActiveEntitlement.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckIfResolved] = input.CheckIfResolved.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SendAutomaticResponse] = input.SendAutomaticResponse.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.QueueId] = input.QueueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.QueueIdName] = input.QueueIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ChannelPropertyGroupIdName] = input.ChannelPropertyGroupIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ResolvedSince] = input.ResolvedSince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SourceTypeCode] = input.SourceTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SourceTypeCodeName] = input.SourceTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ResponseTemplateId] = input.ResponseTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ResponseTemplateIdName] = input.ResponseTemplateIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SourceChannelTypeCode] = input.SourceChannelTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SourceChannelTypeCodeName] = input.SourceChannelTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.WorkflowId] = input.WorkflowId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.WorkflowIdName] = input.WorkflowIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.AllowUnknownSenderName] = input.AllowUnknownSenderName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckIfResolvedName] = input.CheckIfResolvedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SendAutomaticResponseName] = input.SendAutomaticResponseName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckActiveEntitlementName] = input.CheckActiveEntitlementName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.RecordVersion] = input.RecordVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckBlockedSocialProfile] = input.CheckBlockedSocialProfile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckBlockedSocialProfileName] = input.CheckBlockedSocialProfileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckDirectMessages] = input.CheckDirectMessages.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.CheckDirectMessagesName] = input.CheckDirectMessagesName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.ConvertRuleIdUnique] = input.ConvertRuleIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConvertRule.StatusCode] = input.StatusCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

