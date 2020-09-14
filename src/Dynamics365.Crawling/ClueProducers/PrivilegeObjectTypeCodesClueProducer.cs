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
    public abstract class PrivilegeObjectTypeCodesClueProducer<T> : DynamicsClueProducer<T> where T : PrivilegeObjectTypeCodes
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PrivilegeObjectTypeCodesClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PrivilegeObjectTypeCodeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=privilegeobjecttypecodes&id={1}", _dynamics365CrawlJobData.Api, input.PrivilegeObjectTypeCodeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.PrivilegeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.privilege, EntityEdgeType.Parent, input, input.PrivilegeId);


            */
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.PrivilegeId] = input.PrivilegeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.PrivilegeObjectTypeCodeId] = input.PrivilegeObjectTypeCodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrivilegeObjectTypeCodes.PrivilegeObjectTypeCodeRowId] = input.PrivilegeObjectTypeCodeRowId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

