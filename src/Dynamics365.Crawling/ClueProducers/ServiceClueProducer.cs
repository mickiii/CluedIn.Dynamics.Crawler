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
    public abstract class ServiceClueProducer<T> : DynamicsClueProducer<T> where T : Service
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ServiceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ServiceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=service&id={1}", _dynamics365CrawlJobData.Api, input.ServiceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.CalendarId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.calendar, EntityEdgeType.Parent, input, input.CalendarId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ResourceSpecId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcespec, EntityEdgeType.Parent, input, input.ResourceSpecId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.StrategyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.plugintype, EntityEdgeType.Parent, input, input.StrategyId);


            */
            data.Properties[Dynamics365Vocabulary.Service.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ServiceId] = input.ServiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ResourceSpecId] = input.ResourceSpecId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.AnchorOffset] = input.AnchorOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.IsSchedulable] = input.IsSchedulable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.StrategyId] = input.StrategyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.InitialStatusCode] = input.InitialStatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CalendarId] = input.CalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ShowResources] = input.ShowResources.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.Granularity] = input.Granularity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.IsVisible] = input.IsVisible.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.InitialStatusCodeName] = input.InitialStatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.IsVisibleName] = input.IsVisibleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ShowResourcesName] = input.ShowResourcesName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ResourceSpecIdName] = input.ResourceSpecIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.IsSchedulableName] = input.IsSchedulableName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Service.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

