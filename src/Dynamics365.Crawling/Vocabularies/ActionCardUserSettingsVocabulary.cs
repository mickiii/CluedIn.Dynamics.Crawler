using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ActionCardUserSettingsVocabulary : SimpleVocabulary
    {
        public ActionCardUserSettingsVocabulary()
        {
            VocabularyName = "Dynamics365 ActionCardUserSettings";
            KeyPrefix = "dynamics365.actioncardusersettings";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ActionCardUserSettings", group =>
            {
                this.ActionCardUserSettingsId = group.Add(new VocabularyKey("ActionCardUserSettingsId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier user entity")
                    .WithDisplayName("ActionCardUserSettingsId")
                    .ModelProperty("actioncardusersettingsid", typeof(Guid)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the user or team who owns the settings.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns this saved view.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.CardTypeId = group.Add(new VocabularyKey("CardTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"card type attribute")
                    .WithDisplayName("card type")
                    .ModelProperty("cardtypeid", typeof(string)));

                this.IsEnabled = group.Add(new VocabularyKey("IsEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the card is enabled for user or not.")
                    .WithDisplayName("Visibiliy Status of ActionCard")
                    .ModelProperty("isenabled", typeof(bool)));

                this.IsEnabledName = group.Add(new VocabularyKey("IsEnabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsEnabledName")
                    .ModelProperty("isenabledname", typeof(string)));

                this.IntCardOption = group.Add(new VocabularyKey("IntCardOption", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Any int option for a cardtype.")
                    .WithDisplayName("Any int option for a cardtype.")
                    .ModelProperty("intcardoption", typeof(long)));

                this.StringCardOption = group.Add(new VocabularyKey("StringCardOption", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"Any string option for a cardtype.")
                    .WithDisplayName("Any string option for a cardtype.")
                    .ModelProperty("stringcardoption", typeof(string)));

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

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the owner of the saved view.")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of the owner of the saved view, such as user, team, or business unit.")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns this.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns this saved view.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CardTypeIdName = group.Add(new VocabularyKey("CardTypeIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("CardTypeIdName")
                    .ModelProperty("cardtypeidname", typeof(string)));

                this.CardType = group.Add(new VocabularyKey("CardType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The CardType ENUM value.")
                    .WithDisplayName("CardType ENUM")
                    .ModelProperty("cardtype", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ActionCardUserSettingsId { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey CardTypeId { get; private set; }

        public VocabularyKey IsEnabled { get; private set; }

        public VocabularyKey IsEnabledName { get; private set; }

        public VocabularyKey IntCardOption { get; private set; }

        public VocabularyKey StringCardOption { get; private set; }

        public VocabularyKey BoolCardOption { get; private set; }

        public VocabularyKey BoolCardOptionName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CardTypeIdName { get; private set; }

        public VocabularyKey CardType { get; private set; }


    }
}

