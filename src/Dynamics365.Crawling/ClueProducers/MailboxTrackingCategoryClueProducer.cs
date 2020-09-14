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
    public abstract class MailboxTrackingCategoryClueProducer<T> : DynamicsClueProducer<T> where T : MailboxTrackingCategory
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public MailboxTrackingCategoryClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.MailboxTrackingCategoryId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=mailboxtrackingcategory&id={1}", _dynamics365CrawlJobData.Api, input.MailboxTrackingCategoryId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.MailboxId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.MailboxId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.MailboxTrackingCategoryId] = input.MailboxTrackingCategoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.MailboxId] = input.MailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.ExchangeCategoryId] = input.ExchangeCategoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.ExchangeCategoryName] = input.ExchangeCategoryName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.ExchangeCategoryColor] = input.ExchangeCategoryColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.CategoryOnboardingStatus] = input.CategoryOnboardingStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.MailboxTrackingCategory.OwningTeam] = input.OwningTeam.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

