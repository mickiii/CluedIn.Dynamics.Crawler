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
    public abstract class StringMapClueProducer<T> : DynamicsClueProducer<T> where T : StringMap
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public StringMapClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.StringMapId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=stringmap&id={1}", _dynamics365CrawlJobData.Api, input.StringMapId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.StringMap.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.AttributeName] = input.AttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.AttributeValue] = input.AttributeValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.LangId] = input.LangId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.Value] = input.Value.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.DisplayOrder] = input.DisplayOrder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.StringMap.StringMapId] = input.StringMapId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

