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
    public abstract class SubjectClueProducer<T> : DynamicsClueProducer<T> where T : Subject
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SubjectClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SubjectId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=subject&id={1}", _dynamics365CrawlJobData.Api, input.SubjectId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.ModifiedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.ModifiedByExternalParty);

                         if (input.CreatedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.CreatedByExternalParty);

                         if (input.ParentSubject != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subject, EntityEdgeType.Parent, input, input.ParentSubject);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.Subject.SubjectId] = input.SubjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ParentSubject] = input.ParentSubject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.FeatureMask] = input.FeatureMask.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ParentSubjectName] = input.ParentSubjectName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Subject.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

