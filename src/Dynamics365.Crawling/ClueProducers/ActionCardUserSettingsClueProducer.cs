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
    public abstract class ActionCardUserSettingsClueProducer<T> : DynamicsClueProducer<T> where T : ActionCardUserSettings
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ActionCardUserSettingsClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ActionCardUserSettingsId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=actioncardusersettings&id={1}", _dynamics365CrawlJobData.Api, input.ActionCardUserSettingsId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CardTypeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cardtype, EntityEdgeType.Parent, input, input.CardTypeId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.ActionCardUserSettingsId] = input.ActionCardUserSettingsId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.CardTypeId] = input.CardTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.IsEnabled] = input.IsEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.IsEnabledName] = input.IsEnabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.IntCardOption] = input.IntCardOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.StringCardOption] = input.StringCardOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.BoolCardOption] = input.BoolCardOption.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.BoolCardOptionName] = input.BoolCardOptionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.CardTypeIdName] = input.CardTypeIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ActionCardUserSettings.CardType] = input.CardType.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

