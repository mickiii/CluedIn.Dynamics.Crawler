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
    public abstract class ChannelAccessProfileRuleItemClueProducer<T> : DynamicsClueProducer<T> where T : ChannelAccessProfileRuleItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ChannelAccessProfileRuleItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ChannelAccessProfileRuleItemId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=channelaccessprofileruleitem&id={1}", _dynamics365CrawlJobData.Api, input.ChannelAccessProfileRuleItemId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ChannelAccessProfileRuleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofilerule, EntityEdgeType.Parent, input, input.ChannelAccessProfileRuleId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.AssociatedChannelAccessProfile != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofile, EntityEdgeType.Parent, input, input.AssociatedChannelAccessProfile);


            */
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ChannelAccessProfileRuleItemIdUnique] = input.ChannelAccessProfileRuleItemIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ConditionXml] = input.ConditionXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ChannelAccessProfileRuleId] = input.ChannelAccessProfileRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ChannelAccessProfileRuleIdName] = input.ChannelAccessProfileRuleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.ChannelAccessProfileRuleItemId] = input.ChannelAccessProfileRuleItemId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.AssociatedChannelAccessProfile] = input.AssociatedChannelAccessProfile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.AssociatedChannelAccessProfileName] = input.AssociatedChannelAccessProfileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ChannelAccessProfileRuleItem.OwningUser] = input.OwningUser.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

