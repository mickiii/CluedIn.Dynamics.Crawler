using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DuplicateRuleConditionVocabulary : SimpleVocabulary
    {
        public DuplicateRuleConditionVocabulary()
        {
            VocabularyName = "Dynamics365 DuplicateRuleCondition";
            KeyPrefix = "dynamics365.duplicaterulecondition";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("DuplicateRuleCondition", group =>
            {
                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the condition.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.OperatorParam = group.Add(new VocabularyKey("OperatorParam", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Parameter value of N if the operator is Same First Characters or Same Last Characters.")
                    .WithDisplayName("Operator Parameter")
                    .ModelProperty("operatorparam", typeof(long)));

                this.OperatorCode = group.Add(new VocabularyKey("OperatorCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Operator for this rule condition.")
                    .WithDisplayName("Operator Code")
                    .ModelProperty("operatorcode", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the condition was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.BaseAttributeName = group.Add(new VocabularyKey("BaseAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Field that is being compared.")
                    .WithDisplayName("Base Field")
                    .ModelProperty("baseattributename", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the object with which the condition is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.DuplicateRuleConditionId = group.Add(new VocabularyKey("DuplicateRuleConditionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the condition.")
                    .WithDisplayName("Duplicate Rule Condition")
                    .ModelProperty("duplicateruleconditionid", typeof(Guid)));

                this.MatchingAttributeName = group.Add(new VocabularyKey("MatchingAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Field that is being compared with the base field.")
                    .WithDisplayName("Matching Field")
                    .ModelProperty("matchingattributename", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the condition was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the condition.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the condition.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the condition.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.OperatorCodeName = group.Add(new VocabularyKey("OperatorCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Name of the operator.")
                    .WithDisplayName("Operator")
                    .ModelProperty("operatorcodename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

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

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the duplicate rule condition.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the duplicate rule condition.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the duplicate rule condition.")
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

                this.IgnoreBlankValues = group.Add(new VocabularyKey("IgnoreBlankValues", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Determines whether to consider blank values as non-duplicate values")
                    .WithDisplayName("Ignore Blank Values")
                    .ModelProperty("ignoreblankvalues", typeof(bool)));

                this.IgnoreBlankValuesName = group.Add(new VocabularyKey("IgnoreBlankValuesName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the duplicate rule condition should ignore nulls")
                    .WithDisplayName("Ignore Nulls")
                    .ModelProperty("ignoreblankvaluesname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey OperatorParam { get; private set; }

        public VocabularyKey OperatorCode { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey BaseAttributeName { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey DuplicateRuleConditionId { get; private set; }

        public VocabularyKey MatchingAttributeName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey OperatorCodeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey IgnoreBlankValues { get; private set; }

        public VocabularyKey IgnoreBlankValuesName { get; private set; }


    }
}

