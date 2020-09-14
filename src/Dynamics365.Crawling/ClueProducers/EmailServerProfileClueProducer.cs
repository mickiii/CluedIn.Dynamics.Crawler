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
    public abstract class EmailServerProfileClueProducer<T> : DynamicsClueProducer<T> where T : EmailServerProfile
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EmailServerProfileClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.EmailServerProfileId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=emailserverprofile&id={1}", _dynamics365CrawlJobData.Api, input.EmailServerProfileId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.IncomingPartnerApplication != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.partnerapplication, EntityEdgeType.Parent, input, input.IncomingPartnerApplication);

                         if (input.OutgoingPartnerApplication != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.partnerapplication, EntityEdgeType.Parent, input, input.OutgoingPartnerApplication);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);


            */
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EmailServerProfileId] = input.EmailServerProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ServerType] = input.ServerType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ServerTypeName] = input.ServerTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingServerLocation] = input.OutgoingServerLocation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingServerLocation] = input.IncomingServerLocation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingUserName] = input.IncomingUserName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingPassword] = input.IncomingPassword.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingUsername] = input.OutgoingUsername.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingPassword] = input.OutgoingPassword.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingPortNumber] = input.IncomingPortNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingPortNumber] = input.OutgoingPortNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingUseSSL] = input.IncomingUseSSL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingUseSslName] = input.IncomingUseSslName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingUseSSL] = input.OutgoingUseSSL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingUseSslName] = input.OutgoingUseSslName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UseAutoDiscover] = input.UseAutoDiscover.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UseAutoDiscoverName] = input.UseAutoDiscoverName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingAuthenticationProtocol] = input.IncomingAuthenticationProtocol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingAuthenticationProtocolName] = input.IncomingAuthenticationProtocolName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingCredentialRetrieval] = input.OutgoingCredentialRetrieval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingCredentialRetrieval] = input.IncomingCredentialRetrieval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingCredentialRetrievalName] = input.IncomingCredentialRetrievalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingCredentialRetrievalName] = input.OutgoingCredentialRetrievalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EncodingCodePage] = input.EncodingCodePage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ProcessEmailsReceivedAfter] = input.ProcessEmailsReceivedAfter.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.MaxConcurrentConnections] = input.MaxConcurrentConnections.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingAutoGrantDelegateAccess] = input.OutgoingAutoGrantDelegateAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingAutoGrantDelegateAccessName] = input.OutgoingAutoGrantDelegateAccessName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingUseImpersonation] = input.OutgoingUseImpersonation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingUseImpersonationName] = input.OutgoingUseImpersonationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingUseImpersonation] = input.IncomingUseImpersonation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingUseImpersonationName] = input.IncomingUseImpersonationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwningBusinessUnitName] = input.OwningBusinessUnitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingPartnerApplication] = input.IncomingPartnerApplication.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IncomingPartnerApplicationName] = input.IncomingPartnerApplicationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingPartnerApplication] = input.OutgoingPartnerApplication.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingPartnerApplicationName] = input.OutgoingPartnerApplicationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.MoveUndeliveredEmails] = input.MoveUndeliveredEmails.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.MoveUndeliveredEmailsName] = input.MoveUndeliveredEmailsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.MinPollingIntervalInMinutes] = input.MinPollingIntervalInMinutes.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UseSameSettingsForOutgoingConnections] = input.UseSameSettingsForOutgoingConnections.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UseSameSettingsForOutgoingConnectionsName] = input.UseSameSettingsForOutgoingConnectionsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IsIncomingPasswordSet] = input.IsIncomingPasswordSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.IsOutgoingPasswordSet] = input.IsOutgoingPasswordSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingAuthenticationProtocol] = input.OutgoingAuthenticationProtocol.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OutgoingAuthenticationProtocolName] = input.OutgoingAuthenticationProtocolName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ExchangeVersion] = input.ExchangeVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ExchangeVersionName] = input.ExchangeVersionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.TimeoutMailboxConnection] = input.TimeoutMailboxConnection.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.TimeoutMailboxConnectionName] = input.TimeoutMailboxConnectionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.SendEmailAlert] = input.SendEmailAlert.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.SendEmailAlertName] = input.SendEmailAlertName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.TimeoutMailboxConnectionAfterAmount] = input.TimeoutMailboxConnectionAfterAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.EmailServerTypeName] = input.EmailServerTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.ExchangeOnlineTenantId] = input.ExchangeOnlineTenantId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastTestExecutionStatus] = input.LastTestExecutionStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastTestValidationStatus] = input.LastTestValidationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastTestRequest] = input.LastTestRequest.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastTestResponse] = input.LastTestResponse.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastTestStartTime] = input.LastTestStartTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastTestTotalExecutionTime] = input.LastTestTotalExecutionTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.OwnerEmailAddress] = input.OwnerEmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UseDefaultTenantId] = input.UseDefaultTenantId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.UseDefaultTenantIdName] = input.UseDefaultTenantIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastAuthorizationStatus] = input.LastAuthorizationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.LastCrmMessage] = input.LastCrmMessage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.DefaultServerLocation] = input.DefaultServerLocation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EmailServerProfile.VersionNumber] = input.VersionNumber.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

