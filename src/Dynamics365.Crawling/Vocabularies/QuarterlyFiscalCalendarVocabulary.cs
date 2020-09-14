using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class QuarterlyFiscalCalendarVocabulary : SimpleVocabulary
    {
        public QuarterlyFiscalCalendarVocabulary()
        {
            VocabularyName = "Dynamics365 QuarterlyFiscalCalendar";
            KeyPrefix = "dynamics365.quarterlyfiscalcalendar";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("QuarterlyFiscalCalendar", group =>
            {
                this.UserFiscalCalendarId = group.Add(new VocabularyKey("UserFiscalCalendarId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the quarterly fiscal calendar.")
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
                    .WithDescription(@"Type of fiscal period used in the sales quota.")
                    .WithDisplayName("FiscalPeriodType")
                    .ModelProperty("fiscalperiodtype", typeof(long)));

                this.EffectiveOn = group.Add(new VocabularyKey("EffectiveOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the quarterly fiscal calendar sales quota takes effect.")
                    .WithDisplayName("EffectiveOn")
                    .ModelProperty("effectiveon", typeof(DateTime)));

                this.Period1 = group.Add(new VocabularyKey("Period1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the first quarter in the fiscal year.")
                    .WithDisplayName("Period1")
                    .ModelProperty("quarter1", typeof(string)));

                this.Period4 = group.Add(new VocabularyKey("Period4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the second quarter in the fiscal year.")
                    .WithDisplayName("Period4")
                    .ModelProperty("quarter2", typeof(string)));

                this.Period7 = group.Add(new VocabularyKey("Period7", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the third quarter in the fiscal year.")
                    .WithDisplayName("Period7")
                    .ModelProperty("quarter3", typeof(string)));

                this.Period10 = group.Add(new VocabularyKey("Period10", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sales quota for the fourth quarter in the fiscal year.")
                    .WithDisplayName("Period10")
                    .ModelProperty("quarter4", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the quarterly fiscal calendar.")
                    .WithDisplayName("CreatedBy")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the quota for the quarterly fiscal calendar was created.")
                    .WithDisplayName("CreatedOn")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the quarterly fiscal calendar.")
                    .WithDisplayName("ModifiedBy")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the quarterly fiscal calendar was last modified.")
                    .WithDisplayName("ModifiedOn")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BusinessUnitId")
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

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the currency associated with the quarterly fiscal calendar.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the quarterly fiscal calendar with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.Period1_Base = group.Add(new VocabularyKey("Period1_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the first quarter in the fiscal year.")
                    .WithDisplayName("Period1_Base")
                    .ModelProperty("quarter1_base", typeof(string)));

                this.Period7_Base = group.Add(new VocabularyKey("Period7_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the third quarter in the fiscal year.")
                    .WithDisplayName("Period7_Base")
                    .ModelProperty("quarter3_base", typeof(string)));

                this.Period10_Base = group.Add(new VocabularyKey("Period10_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the fourth quarter in the fiscal year.")
                    .WithDisplayName("Period10_Base")
                    .ModelProperty("quarter4_base", typeof(string)));

                this.Period4_Base = group.Add(new VocabularyKey("Period4_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the sales quota for the second quarter in the fiscal year")
                    .WithDisplayName("Period4_Base")
                    .ModelProperty("quarter2_base", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

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

                this.SalesPersonIdYomiName = group.Add(new VocabularyKey("SalesPersonIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SalesPersonIdYomiName")
                    .ModelProperty("salespersonidyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the quarterlyfiscalcalendar.")
                    .WithDisplayName("Created By (Delegate)")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the quarterlyfiscalcalendar.")
                    .WithDisplayName("Modified By (Delegate)")
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

        public VocabularyKey Period4 { get; private set; }

        public VocabularyKey Period7 { get; private set; }

        public VocabularyKey Period10 { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey BusinessUnitIdName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey Period1_Base { get; private set; }

        public VocabularyKey Period7_Base { get; private set; }

        public VocabularyKey Period10_Base { get; private set; }

        public VocabularyKey Period4_Base { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey SalesPersonIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }


    }
}

