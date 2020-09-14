using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class FixedMonthlyFiscalCalendarVocabulary : SimpleVocabulary
    {
        public FixedMonthlyFiscalCalendarVocabulary()
        {
            VocabularyName = "Dynamics365 FixedMonthlyFiscalCalendar";
            KeyPrefix = "dynamics365.fixedmonthlyfiscalcalendar";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("FixedMonthlyFiscalCalendar", group =>
            {
                this.UserFiscalCalendarId = group.Add(new VocabularyKey("UserFiscalCalendarId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user of the fiscal calendar.")
                    .WithDisplayName("UserFiscalCalendarId")
                    .ModelProperty("userfiscalcalendarid", typeof(Guid)));

                this.SalesPersonId = group.Add(new VocabularyKey("SalesPersonId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated salesperson.")
                    .WithDisplayName("SalesPersonId")
                    .ModelProperty("salespersonid", typeof(string)));

                this.SalesPersonIdName = group.Add(new VocabularyKey("SalesPersonIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SalesPersonIdName")
                    .ModelProperty("salespersonidname", typeof(string)));

                this.FiscalPeriodType = group.Add(new VocabularyKey("FiscalPeriodType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of fiscal period used in the fixed monthly fiscal calendar sales quota.")
                    .WithDisplayName("FiscalPeriodType")
                    .ModelProperty("fiscalperiodtype", typeof(long)));

                this.EffectiveOn = group.Add(new VocabularyKey("EffectiveOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the fixed monthly fiscal calendar sales quota takes effect.")
                    .WithDisplayName("EffectiveOn")
                    .ModelProperty("effectiveon", typeof(DateTime)));

                this.Period1 = group.Add(new VocabularyKey("Period1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the first period in the fiscal year.")
                    .WithDisplayName("Period1")
                    .ModelProperty("period1", typeof(string)));

                this.Period2 = group.Add(new VocabularyKey("Period2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the second period in the fiscal year.")
                    .WithDisplayName("Period2")
                    .ModelProperty("period2", typeof(string)));

                this.Period3 = group.Add(new VocabularyKey("Period3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the third period in the fiscal year.")
                    .WithDisplayName("Period3")
                    .ModelProperty("period3", typeof(string)));

                this.Period4 = group.Add(new VocabularyKey("Period4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the fourth period in the fiscal year.")
                    .WithDisplayName("Period4")
                    .ModelProperty("period4", typeof(string)));

                this.Period5 = group.Add(new VocabularyKey("Period5", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the fifth period in the fiscal year.")
                    .WithDisplayName("Period5")
                    .ModelProperty("period5", typeof(string)));

                this.Period6 = group.Add(new VocabularyKey("Period6", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the sixth period in the fiscal year.")
                    .WithDisplayName("Period6")
                    .ModelProperty("period6", typeof(string)));

                this.Period7 = group.Add(new VocabularyKey("Period7", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the seventh period in the fiscal year.")
                    .WithDisplayName("Period7")
                    .ModelProperty("period7", typeof(string)));

                this.Period8 = group.Add(new VocabularyKey("Period8", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the eighth period in the fiscal year.")
                    .WithDisplayName("Period8")
                    .ModelProperty("period8", typeof(string)));

                this.Period9 = group.Add(new VocabularyKey("Period9", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the ninth period in the fiscal year.")
                    .WithDisplayName("Period9")
                    .ModelProperty("period9", typeof(string)));

                this.Period10 = group.Add(new VocabularyKey("Period10", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the tenth period in the fiscal year.")
                    .WithDisplayName("Period10")
                    .ModelProperty("period10", typeof(string)));

                this.Period11 = group.Add(new VocabularyKey("Period11", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the eleventh period in the fiscal year.")
                    .WithDisplayName("Period11")
                    .ModelProperty("period11", typeof(string)));

                this.Period12 = group.Add(new VocabularyKey("Period12", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the twelfth period in the fiscal year.")
                    .WithDisplayName("Period12")
                    .ModelProperty("period12", typeof(string)));

                this.Period13 = group.Add(new VocabularyKey("Period13", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the thirteenth period in the fiscal year.")
                    .WithDisplayName("Period13")
                    .ModelProperty("period13", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the fiscal calendar.")
                    .WithDisplayName("CreatedBy")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the quota for the fixed monthly fiscal calendar was created.")
                    .WithDisplayName("CreatedOn")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the fixed monthly fiscal calendar.")
                    .WithDisplayName("ModifiedBy")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the fixed monthly fiscal calendar was last modified.")
                    .WithDisplayName("ModifiedOn")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Business unit responsible for the quota associated with this calendar.")
                    .WithDisplayName("Business Unit")
                    .ModelProperty("businessunitid", typeof(string)));

                this.BusinessUnitIdName = group.Add(new VocabularyKey("BusinessUnitIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BusinessUnitIdName")
                    .ModelProperty("businessunitidname", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the fixed monthly fiscal calendar with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the currency associated with the fixed monthly fiscal calendar.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.Period11_Base = group.Add(new VocabularyKey("Period11_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the eleventh period in the fiscal year.")
                    .WithDisplayName("Period11_Base")
                    .ModelProperty("period11_base", typeof(string)));

                this.Period9_Base = group.Add(new VocabularyKey("Period9_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the ninth period in the fiscal year.")
                    .WithDisplayName("Period9_Base")
                    .ModelProperty("period9_base", typeof(string)));

                this.Period12_Base = group.Add(new VocabularyKey("Period12_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the twelfth period in the fiscal year.")
                    .WithDisplayName("Period12_Base")
                    .ModelProperty("period12_base", typeof(string)));

                this.Period2_Base = group.Add(new VocabularyKey("Period2_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the second period in the fiscal year.")
                    .WithDisplayName("Period2_Base")
                    .ModelProperty("period2_base", typeof(string)));

                this.Period5_Base = group.Add(new VocabularyKey("Period5_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the fifth period in the fiscal year.")
                    .WithDisplayName("Period5_Base")
                    .ModelProperty("period5_base", typeof(string)));

                this.Period13_Base = group.Add(new VocabularyKey("Period13_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the thirteenth period in the fiscal year.")
                    .WithDisplayName("Period13_Base")
                    .ModelProperty("period13_base", typeof(string)));

                this.Period3_Base = group.Add(new VocabularyKey("Period3_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the third period in the fiscal year.")
                    .WithDisplayName("Period3_Base")
                    .ModelProperty("period3_base", typeof(string)));

                this.Period10_Base = group.Add(new VocabularyKey("Period10_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the tenth period in the fiscal year.")
                    .WithDisplayName("Period10_Base")
                    .ModelProperty("period10_base", typeof(string)));

                this.Period8_Base = group.Add(new VocabularyKey("Period8_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the eighth period in the fiscal year.")
                    .WithDisplayName("Period8_Base")
                    .ModelProperty("period8_base", typeof(string)));

                this.Period4_Base = group.Add(new VocabularyKey("Period4_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the fourth period in the fiscal year.")
                    .WithDisplayName("Period4_Base")
                    .ModelProperty("period4_base", typeof(string)));

                this.Period6_Base = group.Add(new VocabularyKey("Period6_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the sixth period in the fiscal year.")
                    .WithDisplayName("Period6_Base")
                    .ModelProperty("period6_base", typeof(string)));

                this.Period1_Base = group.Add(new VocabularyKey("Period1_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the first period in the fiscal year.")
                    .WithDisplayName("Period1_Base")
                    .ModelProperty("period1_base", typeof(string)));

                this.Period7_Base = group.Add(new VocabularyKey("Period7_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the seventh period in the fiscal year.")
                    .WithDisplayName("Period7_Base")
                    .ModelProperty("period7_base", typeof(string)));

                this.SalesPersonIdYomiName = group.Add(new VocabularyKey("SalesPersonIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SalesPersonIdYomiName")
                    .ModelProperty("salespersonidyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the fixedmonthlyfiscalcalendar.")
                    .WithDisplayName("CreatedOnBehalfBy")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the fixedmonthlyfiscalcalendar.")
                    .WithDisplayName("ModifiedOnBehalfBy")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey UserFiscalCalendarId { get; private set; }

        public VocabularyKey SalesPersonId { get; private set; }

        public VocabularyKey SalesPersonIdName { get; private set; }

        public VocabularyKey FiscalPeriodType { get; private set; }

        public VocabularyKey EffectiveOn { get; private set; }

        public VocabularyKey Period1 { get; private set; }

        public VocabularyKey Period2 { get; private set; }

        public VocabularyKey Period3 { get; private set; }

        public VocabularyKey Period4 { get; private set; }

        public VocabularyKey Period5 { get; private set; }

        public VocabularyKey Period6 { get; private set; }

        public VocabularyKey Period7 { get; private set; }

        public VocabularyKey Period8 { get; private set; }

        public VocabularyKey Period9 { get; private set; }

        public VocabularyKey Period10 { get; private set; }

        public VocabularyKey Period11 { get; private set; }

        public VocabularyKey Period12 { get; private set; }

        public VocabularyKey Period13 { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey BusinessUnitIdName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey Period11_Base { get; private set; }

        public VocabularyKey Period9_Base { get; private set; }

        public VocabularyKey Period12_Base { get; private set; }

        public VocabularyKey Period2_Base { get; private set; }

        public VocabularyKey Period5_Base { get; private set; }

        public VocabularyKey Period13_Base { get; private set; }

        public VocabularyKey Period3_Base { get; private set; }

        public VocabularyKey Period10_Base { get; private set; }

        public VocabularyKey Period8_Base { get; private set; }

        public VocabularyKey Period4_Base { get; private set; }

        public VocabularyKey Period6_Base { get; private set; }

        public VocabularyKey Period1_Base { get; private set; }

        public VocabularyKey Period7_Base { get; private set; }

        public VocabularyKey SalesPersonIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }


    }
}

