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
    public abstract class UserFiscalCalendarClueProducer<T> : DynamicsClueProducer<T> where T : UserFiscalCalendar
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public UserFiscalCalendarClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=userfiscalcalendar&id={1}", _dynamics365CrawlJobData.Api, input.UserFiscalCalendarId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.BusinessUnitId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.BusinessUnitId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.SalesPersonId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SalesPersonId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);


            */
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.UserFiscalCalendarId] = input.UserFiscalCalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.SalesPersonId] = input.SalesPersonId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.FiscalPeriodType] = input.FiscalPeriodType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.EffectiveOn] = input.EffectiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period1] = input.Period1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period2] = input.Period2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period3] = input.Period3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period4] = input.Period4.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period5] = input.Period5.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period6] = input.Period6.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period7] = input.Period7.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period8] = input.Period8.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period9] = input.Period9.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period10] = input.Period10.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period11] = input.Period11.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period12] = input.Period12.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period13] = input.Period13.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.SalesPersonIdName] = input.SalesPersonIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period4_Base] = input.Period4_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period11_Base] = input.Period11_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period3_Base] = input.Period3_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period1_Base] = input.Period1_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period6_Base] = input.Period6_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period8_Base] = input.Period8_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period9_Base] = input.Period9_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period7_Base] = input.Period7_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period5_Base] = input.Period5_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period13_Base] = input.Period13_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period10_Base] = input.Period10_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period12_Base] = input.Period12_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.Period2_Base] = input.Period2_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.SalesPersonIdYomiName] = input.SalesPersonIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.UserFiscalCalendar.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

