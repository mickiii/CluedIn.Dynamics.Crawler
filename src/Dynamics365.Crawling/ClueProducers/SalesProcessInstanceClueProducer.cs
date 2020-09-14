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
    public abstract class SalesProcessInstanceClueProducer<T> : DynamicsClueProducer<T> where T : SalesProcessInstance
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SalesProcessInstanceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SalesProcessInstanceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=salesprocessinstance&id={1}", _dynamics365CrawlJobData.Api, input.SalesProcessInstanceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.BusinessUnitId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.BusinessUnitId);


            */
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.SalesStageName] = input.SalesStageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.SalesProcessInstanceId] = input.SalesProcessInstanceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.SalesProcessName] = input.SalesProcessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesProcessInstance.Name] = input.Name.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

