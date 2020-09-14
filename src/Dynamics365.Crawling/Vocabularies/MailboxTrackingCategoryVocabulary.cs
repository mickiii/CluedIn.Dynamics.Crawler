using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class MailboxTrackingCategoryVocabulary : SimpleVocabulary
    {
        public MailboxTrackingCategoryVocabulary()
        {
            VocabularyName = "Dynamics365 MailboxTrackingCategory";
            KeyPrefix = "dynamics365.mailboxtrackingcategory";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("MailboxTrackingCategory", group =>
            {
                this.MailboxTrackingCategoryId = group.Add(new VocabularyKey("MailboxTrackingCategoryId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MailboxTrackingCategoryId")
                    .ModelProperty("mailboxtrackingcategoryid", typeof(Guid)));

                this.MailboxId = group.Add(new VocabularyKey("MailboxId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Mailbox id associated with this record.")
                    .WithDisplayName("MailboxId")
                    .ModelProperty("mailboxid", typeof(string)));

                this.ExchangeCategoryId = group.Add(new VocabularyKey("ExchangeCategoryId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Category Id for a category in Exchange")
                    .WithDisplayName("Exchange Category Id")
                    .ModelProperty("exchangecategoryid", typeof(Guid)));

                this.ExchangeCategoryName = group.Add(new VocabularyKey("ExchangeCategoryName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(512))
                    .WithDescription(@"Exchange Category Name")
                    .WithDisplayName("Exchange Category Name")
                    .ModelProperty("exchangecategoryname", typeof(string)));

                this.ExchangeCategoryColor = group.Add(new VocabularyKey("ExchangeCategoryColor", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Color for category in Exchange.")
                    .WithDisplayName("Color for category in Exchange.")
                    .ModelProperty("exchangecategorycolor", typeof(long)));

                this.CategoryOnboardingStatus = group.Add(new VocabularyKey("CategoryOnboardingStatus", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information to indicate whether the category has been created in Exchange or not.")
                    .WithDisplayName("Category on boarding Status")
                    .ModelProperty("categoryonboardingstatus", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the entry was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the entry was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the category.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the user that owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the category.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey MailboxTrackingCategoryId { get; private set; }

        public VocabularyKey MailboxId { get; private set; }

        public VocabularyKey ExchangeCategoryId { get; private set; }

        public VocabularyKey ExchangeCategoryName { get; private set; }

        public VocabularyKey ExchangeCategoryColor { get; private set; }

        public VocabularyKey CategoryOnboardingStatus { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }


    }
}

