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
    public abstract class MailboxClueProducer<T> : DynamicsClueProducer<T> where T : Mailbox
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public MailboxClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.MailboxId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=mailbox&id={1}", _dynamics365CrawlJobData.Api, input.MailboxId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.EmailServerProfile != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.emailserverprofile, EntityEdgeType.Parent, input, input.EmailServerProfile);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);


            */
            data.Properties[Dynamics365Vocabulary.Mailbox.MailboxId] = input.MailboxId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ExchangeSyncStateXml] = input.ExchangeSyncStateXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IncomingEmailDeliveryMethod] = input.IncomingEmailDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IncomingEmailDeliveryMethodName] = input.IncomingEmailDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OutgoingEmailDeliveryMethod] = input.OutgoingEmailDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OutgoingEmailDeliveryMethodName] = input.OutgoingEmailDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ProcessAndDeleteEmails] = input.ProcessAndDeleteEmails.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ProcessAndDeleteEmailsName] = input.ProcessAndDeleteEmailsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.AllowEmailConnectorToUseCredentials] = input.AllowEmailConnectorToUseCredentials.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.AllowEmailConnectorToUseCredentialsName] = input.AllowEmailConnectorToUseCredentialsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.Username] = input.Username.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.Password] = input.Password.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EmailServerProfile] = input.EmailServerProfile.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EmailServerProfileName] = input.EmailServerProfileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsForwardMailbox] = input.IsForwardMailbox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsForwardMailboxName] = input.IsForwardMailboxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OwningBusinessUnitName] = input.OwningBusinessUnitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EmailRouterAccessApproval] = input.EmailRouterAccessApproval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EmailRouterAccessApprovalName] = input.EmailRouterAccessApprovalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.HostId] = input.HostId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.NoEmailCount] = input.NoEmailCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ProcessEmailReceivedAfter] = input.ProcessEmailReceivedAfter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ReceivingPostponedUntil] = input.ReceivingPostponedUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastMessageId] = input.LastMessageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OutgoingEmailStatus] = input.OutgoingEmailStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OutgoingEmailStatusName] = input.OutgoingEmailStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IncomingEmailStatus] = input.IncomingEmailStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IncomingEmailStatusName] = input.IncomingEmailStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.TestMailboxAccessCompletedOn] = input.TestMailboxAccessCompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.TestEmailConfigurationScheduled] = input.TestEmailConfigurationScheduled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EnabledForIncomingEmail] = input.EnabledForIncomingEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.TransientFailureCount] = input.TransientFailureCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ACTDeliveryMethod] = input.ACTDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ACTDeliveryMethodName] = input.ACTDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.TestEmailConfigurationScheduledName] = input.TestEmailConfigurationScheduledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.PostponeTestEmailConfigurationUntil] = input.PostponeTestEmailConfigurationUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.TestEmailConfigurationRetryCount] = input.TestEmailConfigurationRetryCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.PostponeSendingUntil] = input.PostponeSendingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastActiveOn] = input.LastActiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.UndeliverableFolder] = input.UndeliverableFolder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsPasswordSet] = input.IsPasswordSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EnabledForIncomingEmailName] = input.EnabledForIncomingEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EnabledForOutgoingEmail] = input.EnabledForOutgoingEmail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EnabledForOutgoingEmailName] = input.EnabledForOutgoingEmailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ProcessingStateCode] = input.ProcessingStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastAutoDiscoveredOn] = input.LastAutoDiscoveredOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.PostponeMailboxProcessingUntil] = input.PostponeMailboxProcessingUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EWSURL] = input.EWSURL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.MailboxProcessingContext] = input.MailboxProcessingContext.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EnabledForACT] = input.EnabledForACT.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EnabledForACTName] = input.EnabledForACTName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ReceivingPostponedUntilForACT] = input.ReceivingPostponedUntilForACT.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.NoACTCount] = input.NoACTCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ACTStatus] = input.ACTStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ACTStatusName] = input.ACTStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsEmailAddressApprovedByO365Admin] = input.IsEmailAddressApprovedByO365Admin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsACTSyncOrgFlagSet] = input.IsACTSyncOrgFlagSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ProcessedTimes] = input.ProcessedTimes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastDuration] = input.LastDuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OrgMarkedAsPrimaryForExchangeSync] = input.OrgMarkedAsPrimaryForExchangeSync.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.AverageTotalDuration] = input.AverageTotalDuration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSyncErrorCode] = input.LastSyncErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSyncError] = input.LastSyncError.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSyncErrorCount] = input.LastSyncErrorCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSyncErrorOccurredOn] = input.LastSyncErrorOccurredOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSyncErrorMachineName] = input.LastSyncErrorMachineName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ItemsProcessedForLastSync] = input.ItemsProcessedForLastSync.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ItemsFailedForLastSync] = input.ItemsFailedForLastSync.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSyncStartedOn] = input.LastSyncStartedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastSuccessfulSyncCompletedOn] = input.LastSuccessfulSyncCompletedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.FolderHierarchy] = input.FolderHierarchy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ProcessingLastAttemptedOn] = input.ProcessingLastAttemptedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ForcedUnlockCount] = input.ForcedUnlockCount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.LastMailboxForcedUnlockOccurredOn] = input.LastMailboxForcedUnlockOccurredOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsServiceAccount] = input.IsServiceAccount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.VerboseLoggingEnabled] = input.VerboseLoggingEnabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OfficeAppsDeploymentScheduled] = input.OfficeAppsDeploymentScheduled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OfficeAppsDeploymentScheduledName] = input.OfficeAppsDeploymentScheduledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OfficeAppsDeploymentStatus] = input.OfficeAppsDeploymentStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OfficeAppsDeploymentStatusName] = input.OfficeAppsDeploymentStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OfficeAppsDeploymentCompleteOn] = input.OfficeAppsDeploymentCompleteOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.OfficeAppsDeploymentError] = input.OfficeAppsDeploymentError.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.PostponeOfficeAppsDeploymentUntil] = input.PostponeOfficeAppsDeploymentUntil.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.MailboxStatus] = input.MailboxStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.MailboxStatusName] = input.MailboxStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.IsExchangeContactsImportScheduled] = input.IsExchangeContactsImportScheduled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ExchangeContactsImportStatus] = input.ExchangeContactsImportStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Mailbox.ExchangeContactsImportCompletedOn] = input.ExchangeContactsImportCompletedOn.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

