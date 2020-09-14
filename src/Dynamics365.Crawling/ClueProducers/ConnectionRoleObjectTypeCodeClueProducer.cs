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
    public abstract class ConnectionRoleObjectTypeCodeClueProducer<T> : DynamicsClueProducer<T> where T : ConnectionRoleObjectTypeCode
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ConnectionRoleObjectTypeCodeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ConnectionRoleObjectTypeCodeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=connectionroleobjecttypecode&id={1}", _dynamics365CrawlJobData.Api, input.ConnectionRoleObjectTypeCodeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ConnectionRoleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connectionrole, EntityEdgeType.Parent, input, input.ConnectionRoleId);


            */
            data.Properties[Dynamics365Vocabulary.ConnectionRoleObjectTypeCode.ConnectionRoleId] = input.ConnectionRoleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConnectionRoleObjectTypeCode.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConnectionRoleObjectTypeCode.ConnectionRoleObjectTypeCodeId] = input.ConnectionRoleObjectTypeCodeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConnectionRoleObjectTypeCode.AssociatedObjectTypeCode] = input.AssociatedObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConnectionRoleObjectTypeCode.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ConnectionRoleObjectTypeCode.ConnectionRoleIdName] = input.ConnectionRoleIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

