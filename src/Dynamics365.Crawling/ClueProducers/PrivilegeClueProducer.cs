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
    public abstract class PrivilegeClueProducer<T> : DynamicsClueProducer<T> where T : Privilege
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PrivilegeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PrivilegeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=privilege&id={1}", _dynamics365CrawlJobData.Api, input.PrivilegeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.SolutionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solution, EntityEdgeType.Parent, input, input.SolutionId);


            */
            data.Properties[Dynamics365Vocabulary.Privilege.PrivilegeId] = input.PrivilegeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeLocal] = input.CanBeLocal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeDeep] = input.CanBeDeep.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeGlobal] = input.CanBeGlobal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeBasic] = input.CanBeBasic.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeLocalName] = input.CanBeLocalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeGlobalName] = input.CanBeGlobalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeBasicName] = input.CanBeBasicName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeDeepName] = input.CanBeDeepName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.AccessRight] = input.AccessRight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.IsDisabledWhenIntegrated] = input.IsDisabledWhenIntegrated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeEntityReference] = input.CanBeEntityReference.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeEntityReferenceName] = input.CanBeEntityReferenceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeParentEntityReference] = input.CanBeParentEntityReference.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.CanBeParentEntityReferenceName] = input.CanBeParentEntityReferenceName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Privilege.PrivilegeRowId] = input.PrivilegeRowId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

