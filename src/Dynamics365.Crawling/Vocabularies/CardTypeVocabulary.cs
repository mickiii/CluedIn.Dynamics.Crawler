using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class CardTypeVocabulary : SimpleVocabulary
    {
        public CardTypeVocabulary()
        {
            VocabularyName = "Dynamics365 CardType";
            KeyPrefix = "dynamics365.cardtype";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("CardType", group =>
            {
                this.CardTypeId = group.Add(new VocabularyKey("CardTypeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("CardType")
                    .ModelProperty("cardtypeid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

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

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

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

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.Priority = group.Add(new VocabularyKey("Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The Priority of the CardType")
                    .WithDisplayName("Priority")
                    .ModelProperty("priority", typeof(long)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CardName = group.Add(new VocabularyKey("CardName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The name of the custom entity.")
                    .WithDisplayName("CardName")
                    .ModelProperty("cardname", typeof(string)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.IsEnabled = group.Add(new VocabularyKey("IsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"IsEnabled")
                    .WithDisplayName("IsEnabled")
                    .ModelProperty("isenabled", typeof(bool)));

                this.ScheduleTime = group.Add(new VocabularyKey("ScheduleTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"This column is updated by the Plugin based on the last fetched data.")
                    .WithDisplayName("ScheduleTime")
                    .ModelProperty("scheduletime", typeof(DateTime)));

                this.LastSyncTime = group.Add(new VocabularyKey("LastSyncTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"This column is updated by the Plugin based on the last fetched data.")
                    .WithDisplayName("LastSyncTime")
                    .ModelProperty("lastsynctime", typeof(DateTime)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the CardType with respect to the base currency.")
                    .WithDisplayName("ExchangeRate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Exchange rate for the currency associated with the CardType with respect to the base currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.SoftTitle = group.Add(new VocabularyKey("SoftTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"The soft title of the card.")
                    .WithDisplayName("Soft Title")
                    .ModelProperty("softtitle", typeof(string)));

                this.SummaryText = group.Add(new VocabularyKey("SummaryText", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"The summary text of the card.")
                    .WithDisplayName("Summary Text")
                    .ModelProperty("summarytext", typeof(string)));

                this.GroupType = group.Add(new VocabularyKey("GroupType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Specifies the card group type")
                    .WithDisplayName("GroupType")
                    .ModelProperty("grouptype", typeof(string)));

                this.HasSnoozeDismiss = group.Add(new VocabularyKey("HasSnoozeDismiss", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies if the card type has snooze dismiss")
                    .WithDisplayName("HasSnoozeDismiss")
                    .ModelProperty("hassnoozedismiss", typeof(bool)));

                this.HasSnoozeDismissName = group.Add(new VocabularyKey("HasSnoozeDismissName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("HasSnoozeDismissName")
                    .ModelProperty("hassnoozedismissname", typeof(string)));

                this.CardType = group.Add(new VocabularyKey("CardType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The CardType ENUM value.")
                    .WithDisplayName("CardType ENUM")
                    .ModelProperty("cardtype", typeof(long)));

                this.Actions = group.Add(new VocabularyKey("Actions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("CommandBar Actions JSON definition")
                    .ModelProperty("actions", typeof(string)));

                this.IsEnabledName = group.Add(new VocabularyKey("IsEnabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsEnabledName")
                    .ModelProperty("isenabledname", typeof(string)));

                this.StringCardOption = group.Add(new VocabularyKey("StringCardOption", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"Any string option for a cardtype.")
                    .WithDisplayName("Any string option for a cardtype.")
                    .ModelProperty("stringcardoption", typeof(string)));

                this.IntCardOption = group.Add(new VocabularyKey("IntCardOption", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Any int option for a cardtype.")
                    .WithDisplayName("Any int option for a cardtype.")
                    .ModelProperty("intcardoption", typeof(long)));

                this.BoolCardOption = group.Add(new VocabularyKey("BoolCardOption", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Bolean option for a cardtype.")
                    .WithDisplayName("Bolean option for a cardtype.")
                    .ModelProperty("boolcardoption", typeof(bool)));

                this.BoolCardOptionName = group.Add(new VocabularyKey("BoolCardOptionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BoolCardOptionName")
                    .ModelProperty("boolcardoptionname", typeof(string)));

                this.IsPreviewCard = group.Add(new VocabularyKey("IsPreviewCard", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"IsPreviewCard")
                    .WithDisplayName("IsPreviewCard")
                    .ModelProperty("ispreviewcard", typeof(bool)));

                this.IsPreviewCardName = group.Add(new VocabularyKey("IsPreviewCardName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPreviewCardName")
                    .ModelProperty("ispreviewcardname", typeof(string)));

                this.IsLiveOnly = group.Add(new VocabularyKey("IsLiveOnly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"IsLiveOnly")
                    .WithDisplayName("IsLiveOnly")
                    .ModelProperty("isliveonly", typeof(bool)));

                this.IsLiveOnlyName = group.Add(new VocabularyKey("IsLiveOnlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsLiveOnlyName")
                    .ModelProperty("isliveonlyname", typeof(string)));

                this.CardTypeIcon = group.Add(new VocabularyKey("CardTypeIcon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"The CardTypeIcon of the card.")
                    .WithDisplayName("CardTypeIcon")
                    .ModelProperty("cardtypeicon", typeof(string)));

                this.ClientAvailability = group.Add(new VocabularyKey("ClientAvailability", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Determines on which client is this card available on.")
                    .WithDisplayName("Card Client Availability")
                    .ModelProperty("clientavailability", typeof(string)));

                this.ClientAvailabilityName = group.Add(new VocabularyKey("ClientAvailabilityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ClientAvailabilityName")
                    .ModelProperty("clientavailabilityname", typeof(string)));

                this.PublisherName = group.Add(new VocabularyKey("PublisherName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"The publisher name of card type")
                    .WithDisplayName("PublisherName")
                    .ModelProperty("publishername", typeof(string)));

                this.IsBaseCard = group.Add(new VocabularyKey("IsBaseCard", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"IsBaseCard")
                    .WithDisplayName("IsBaseCard")
                    .ModelProperty("isbasecard", typeof(bool)));

                this.IsBaseCardName = group.Add(new VocabularyKey("IsBaseCardName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBaseCardName")
                    .ModelProperty("isbasecardname", typeof(string)));

                this.GroupCategory = group.Add(new VocabularyKey("GroupCategory", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"GroupCategory dictates the grouping of cards in the Assistant.")
                    .WithDisplayName("GroupCategory ENUM")
                    .ModelProperty("groupcategory", typeof(long)));

                this.AdaptiveCardTemplate = group.Add(new VocabularyKey("AdaptiveCardTemplate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"AdaptiveCard template.")
                    .WithDisplayName("AdaptiveCard template")
                    .ModelProperty("adaptivecardtemplate", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CardTypeId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey Priority { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CardName { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey IsEnabled { get; private set; }

        public VocabularyKey ScheduleTime { get; private set; }

        public VocabularyKey LastSyncTime { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey SoftTitle { get; private set; }

        public VocabularyKey SummaryText { get; private set; }

        public VocabularyKey GroupType { get; private set; }

        public VocabularyKey HasSnoozeDismiss { get; private set; }

        public VocabularyKey HasSnoozeDismissName { get; private set; }

        public VocabularyKey CardType { get; private set; }

        public VocabularyKey Actions { get; private set; }

        public VocabularyKey IsEnabledName { get; private set; }

        public VocabularyKey StringCardOption { get; private set; }

        public VocabularyKey IntCardOption { get; private set; }

        public VocabularyKey BoolCardOption { get; private set; }

        public VocabularyKey BoolCardOptionName { get; private set; }

        public VocabularyKey IsPreviewCard { get; private set; }

        public VocabularyKey IsPreviewCardName { get; private set; }

        public VocabularyKey IsLiveOnly { get; private set; }

        public VocabularyKey IsLiveOnlyName { get; private set; }

        public VocabularyKey CardTypeIcon { get; private set; }

        public VocabularyKey ClientAvailability { get; private set; }

        public VocabularyKey ClientAvailabilityName { get; private set; }

        public VocabularyKey PublisherName { get; private set; }

        public VocabularyKey IsBaseCard { get; private set; }

        public VocabularyKey IsBaseCardName { get; private set; }

        public VocabularyKey GroupCategory { get; private set; }

        public VocabularyKey AdaptiveCardTemplate { get; private set; }


    }
}

