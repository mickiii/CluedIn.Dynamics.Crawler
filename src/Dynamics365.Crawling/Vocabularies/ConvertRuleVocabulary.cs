using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ConvertRuleVocabulary : SimpleVocabulary
    {
        public ConvertRuleVocabulary()
        {
            VocabularyName = "Dynamics365 ConvertRule";
            KeyPrefix = "dynamics365.convertrule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ConvertRule", group =>
            {
                this.ConvertRuleId = group.Add(new VocabularyKey("ConvertRuleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Convert Rule")
                    .ModelProperty("convertruleid", typeof(Guid)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Owner name of the routing rule.")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

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

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
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

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the rule for creating records automatically.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for the user that owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a title or name of the queue for which the setting is defined.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Owner Id")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the convert rule.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.AllowUnknownSender = group.Add(new VocabularyKey("AllowUnknownSender", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether items from unknown senders should be converted to records.")
                    .WithDisplayName("Allow Unknown Sender")
                    .ModelProperty("allowunknownsender", typeof(bool)));

                this.ChannelPropertyGroupId = group.Add(new VocabularyKey("ChannelPropertyGroupId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"channel property group associated with the convert rule.")
                    .WithDisplayName("Channel Property Group")
                    .ModelProperty("channelpropertygroupid", typeof(string)));

                this.CheckActiveEntitlement = group.Add(new VocabularyKey("CheckActiveEntitlement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether cases should be created for customers with active entitlements.")
                    .WithDisplayName("Check Active SLA")
                    .ModelProperty("checkactiveentitlement", typeof(bool)));

                this.CheckIfResolved = group.Add(new VocabularyKey("CheckIfResolved", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether an item related to a resolved case should be converted to a case.")
                    .WithDisplayName("Check If Resolved")
                    .ModelProperty("checkifresolved", typeof(bool)));

                this.SendAutomaticResponse = group.Add(new VocabularyKey("SendAutomaticResponse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether to send an automatic email response to the customer after a record is created.")
                    .WithDisplayName("Send Automatic Response")
                    .ModelProperty("sendautomaticresponse", typeof(bool)));

                this.QueueId = group.Add(new VocabularyKey("QueueId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the queue that the rule is assigned to.")
                    .WithDisplayName("Queue")
                    .ModelProperty("queueid", typeof(string)));

                this.QueueIdName = group.Add(new VocabularyKey("QueueIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("QueueIdName")
                    .ModelProperty("queueidname", typeof(string)));

                this.ChannelPropertyGroupIdName = group.Add(new VocabularyKey("ChannelPropertyGroupIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("ChannelPropertyGroupIdName")
                    .ModelProperty("channelpropertygroupidname", typeof(string)));

                this.ResolvedSince = group.Add(new VocabularyKey("ResolvedSince", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"If you want to create a new case for an item associated with a resolved case, type how long a case must remain resolved before a new case is created for the associated item.")
                    .WithDisplayName("Resolved Since")
                    .ModelProperty("resolvedsince", typeof(long)));

                this.SourceTypeCode = group.Add(new VocabularyKey("SourceTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Source of the record.")
                    .WithDisplayName("Source Type")
                    .ModelProperty("sourcetypecode", typeof(string)));

                this.SourceTypeCodeName = group.Add(new VocabularyKey("SourceTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SourceTypeCodeName")
                    .ModelProperty("sourcetypecodename", typeof(string)));

                this.ResponseTemplateId = group.Add(new VocabularyKey("ResponseTemplateId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the email template to use to create an automatic response to the customer.")
                    .WithDisplayName("Response Email Template")
                    .ModelProperty("responsetemplateid", typeof(string)));

                this.ResponseTemplateIdName = group.Add(new VocabularyKey("ResponseTemplateIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ResponseTemplateIdName")
                    .ModelProperty("responsetemplateidname", typeof(string)));

                this.SourceChannelTypeCode = group.Add(new VocabularyKey("SourceChannelTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Identifies the Dynamics 365 activity that's the source of the record.")
                    .WithDisplayName("Source Type")
                    .ModelProperty("sourcechanneltypecode", typeof(string)));

                this.SourceChannelTypeCodeName = group.Add(new VocabularyKey("SourceChannelTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SourceChannelTypeCodeName")
                    .ModelProperty("sourcechanneltypecodename", typeof(string)));

                this.WorkflowId = group.Add(new VocabularyKey("WorkflowId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the workflow for this rule.")
                    .WithDisplayName("Workflow")
                    .ModelProperty("workflowid", typeof(string)));

                this.WorkflowIdName = group.Add(new VocabularyKey("WorkflowIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("WorkflowIdName")
                    .ModelProperty("workflowidname", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the currency associated with the queue.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.AllowUnknownSenderName = group.Add(new VocabularyKey("AllowUnknownSenderName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AllowUnknownSenderName")
                    .ModelProperty("allowunknownsendername", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the queue with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.CheckIfResolvedName = group.Add(new VocabularyKey("CheckIfResolvedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CheckIfResolvedName")
                    .ModelProperty("checkifresolvedname", typeof(string)));

                this.SendAutomaticResponseName = group.Add(new VocabularyKey("SendAutomaticResponseName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SendAutomaticResponseName")
                    .ModelProperty("sendautomaticresponsename", typeof(string)));

                this.CheckActiveEntitlementName = group.Add(new VocabularyKey("CheckActiveEntitlementName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CheckActiveEntitlementName")
                    .ModelProperty("checkactiveentitlementname", typeof(string)));

                this.RecordVersion = group.Add(new VocabularyKey("RecordVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(50))
                    .WithDescription(@"Record Version")
                    .WithDisplayName("Record Version")
                    .ModelProperty("recordversion", typeof(string)));

                this.CheckBlockedSocialProfile = group.Add(new VocabularyKey("CheckBlockedSocialProfile", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information whether record needs to be created for black listed social profiles.")
                    .WithDisplayName("Check black listed social profiles")
                    .ModelProperty("checkblockedsocialprofile", typeof(bool)));

                this.CheckBlockedSocialProfileName = group.Add(new VocabularyKey("CheckBlockedSocialProfileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CheckBlockedSocialProfileName")
                    .ModelProperty("checkblockedsocialprofilename", typeof(string)));

                this.CheckDirectMessages = group.Add(new VocabularyKey("CheckDirectMessages", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information whether record needs to be created for direct messages.")
                    .WithDisplayName("Create records for private messages only")
                    .ModelProperty("checkdirectmessages", typeof(bool)));

                this.CheckDirectMessagesName = group.Add(new VocabularyKey("CheckDirectMessagesName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CheckDirectMessagesName")
                    .ModelProperty("checkdirectmessagesname", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the business unit that the convert rule owner belongs to.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.ConvertRuleIdUnique = group.Add(new VocabularyKey("ConvertRuleIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Unique Id")
                    .ModelProperty("convertruleidunique", typeof(Guid)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the Convert Rule")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the Convert Rule")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ConvertRuleId { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey AllowUnknownSender { get; private set; }

        public VocabularyKey ChannelPropertyGroupId { get; private set; }

        public VocabularyKey CheckActiveEntitlement { get; private set; }

        public VocabularyKey CheckIfResolved { get; private set; }

        public VocabularyKey SendAutomaticResponse { get; private set; }

        public VocabularyKey QueueId { get; private set; }

        public VocabularyKey QueueIdName { get; private set; }

        public VocabularyKey ChannelPropertyGroupIdName { get; private set; }

        public VocabularyKey ResolvedSince { get; private set; }

        public VocabularyKey SourceTypeCode { get; private set; }

        public VocabularyKey SourceTypeCodeName { get; private set; }

        public VocabularyKey ResponseTemplateId { get; private set; }

        public VocabularyKey ResponseTemplateIdName { get; private set; }

        public VocabularyKey SourceChannelTypeCode { get; private set; }

        public VocabularyKey SourceChannelTypeCodeName { get; private set; }

        public VocabularyKey WorkflowId { get; private set; }

        public VocabularyKey WorkflowIdName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey AllowUnknownSenderName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey CheckIfResolvedName { get; private set; }

        public VocabularyKey SendAutomaticResponseName { get; private set; }

        public VocabularyKey CheckActiveEntitlementName { get; private set; }

        public VocabularyKey RecordVersion { get; private set; }

        public VocabularyKey CheckBlockedSocialProfile { get; private set; }

        public VocabularyKey CheckBlockedSocialProfileName { get; private set; }

        public VocabularyKey CheckDirectMessages { get; private set; }

        public VocabularyKey CheckDirectMessagesName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey ConvertRuleIdUnique { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }


    }
}

