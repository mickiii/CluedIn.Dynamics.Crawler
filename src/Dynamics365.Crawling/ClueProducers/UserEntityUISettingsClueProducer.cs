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
    public abstract class UserEntityUISettingsClueProducer<T> : DynamicsClueProducer<T> where T : UserEntityUISettings
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public UserEntityUISettingsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.UserEntityUISettingsId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=userentityuisettings&id={1}", _dynamics365CrawlJobData.Api, input.UserEntityUISettingsId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.UserEntityUISettingsId] = input.UserEntityUISettingsId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.TabOrderXml] = input.TabOrderXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.ReadingPaneXml] = input.ReadingPaneXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.MRUXml] = input.MRUXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.InsertIntoEmailMRUXml] = input.InsertIntoEmailMRUXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.RecentlyViewedXml] = input.RecentlyViewedXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.LastViewedFormXml] = input.LastViewedFormXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.ShowInAddressBook] = input.ShowInAddressBook.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserEntityUISettings.LookupMRUXml] = input.LookupMRUXml.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

