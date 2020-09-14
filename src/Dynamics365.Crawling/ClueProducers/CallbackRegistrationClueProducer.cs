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
    public abstract class CallbackRegistrationClueProducer<T> : DynamicsClueProducer<T> where T : CallbackRegistration
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CallbackRegistrationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CallbackRegistrationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=callbackregistration&id={1}", _dynamics365CrawlJobData.Api, input.CallbackRegistrationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CallbackRegistrationId] = input.CallbackRegistrationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.EntityName] = input.EntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.FilteringAttributes] = input.FilteringAttributes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.Url] = input.Url.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.Message] = input.Message.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.MessageName] = input.MessageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.Scope] = input.Scope.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ScopeName] = input.ScopeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.VersionName] = input.VersionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwningBusinessUnitName] = input.OwningBusinessUnitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.FilterExpression] = input.FilterExpression.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.PostponeUntil] = input.PostponeUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.RunAs] = input.RunAs.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CallbackRegistration.RunAsName] = input.RunAsName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

