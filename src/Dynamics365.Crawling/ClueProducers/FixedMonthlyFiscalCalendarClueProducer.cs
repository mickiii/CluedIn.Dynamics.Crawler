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
    public abstract class FixedMonthlyFiscalCalendarClueProducer<T> : DynamicsClueProducer<T> where T : FixedMonthlyFiscalCalendar
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public FixedMonthlyFiscalCalendarClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=fixedmonthlyfiscalcalendar&id={1}", _dynamics365CrawlJobData.Api, input.UserFiscalCalendarId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.SalesPersonId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SalesPersonId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.UserFiscalCalendarId] = input.UserFiscalCalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.SalesPersonId] = input.SalesPersonId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.SalesPersonIdName] = input.SalesPersonIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.FiscalPeriodType] = input.FiscalPeriodType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.EffectiveOn] = input.EffectiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period1] = input.Period1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period2] = input.Period2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period3] = input.Period3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period4] = input.Period4.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period5] = input.Period5.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period6] = input.Period6.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period7] = input.Period7.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period8] = input.Period8.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period9] = input.Period9.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period10] = input.Period10.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period11] = input.Period11.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period12] = input.Period12.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period13] = input.Period13.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period11_Base] = input.Period11_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period9_Base] = input.Period9_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period12_Base] = input.Period12_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period2_Base] = input.Period2_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period5_Base] = input.Period5_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period13_Base] = input.Period13_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period3_Base] = input.Period3_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period10_Base] = input.Period10_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period8_Base] = input.Period8_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period4_Base] = input.Period4_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period6_Base] = input.Period6_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period1_Base] = input.Period1_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.Period7_Base] = input.Period7_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.SalesPersonIdYomiName] = input.SalesPersonIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FixedMonthlyFiscalCalendar.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

