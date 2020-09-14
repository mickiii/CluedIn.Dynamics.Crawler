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
    public abstract class QuarterlyFiscalCalendarClueProducer<T> : DynamicsClueProducer<T> where T : QuarterlyFiscalCalendar
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public QuarterlyFiscalCalendarClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.UserFiscalCalendarId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=quarterlyfiscalcalendar&id={1}", _dynamics365CrawlJobData.Api, input.UserFiscalCalendarId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.SalesPersonId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SalesPersonId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.UserFiscalCalendarId] = input.UserFiscalCalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.SalesPersonId] = input.SalesPersonId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.SalesPersonIdName] = input.SalesPersonIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.FiscalPeriodType] = input.FiscalPeriodType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.EffectiveOn] = input.EffectiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period1] = input.Period1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period4] = input.Period4.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period7] = input.Period7.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period10] = input.Period10.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period1_Base] = input.Period1_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period7_Base] = input.Period7_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period10_Base] = input.Period10_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.Period4_Base] = input.Period4_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.SalesPersonIdYomiName] = input.SalesPersonIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuarterlyFiscalCalendar.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

