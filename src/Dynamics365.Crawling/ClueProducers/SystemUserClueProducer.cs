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
    public abstract class SystemUserClueProducer<T> : DynamicsClueProducer<T> where T : SystemUser
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SystemUserClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Infrastructure.User, input.SystemUserId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=systemuser&id={1}", this._dynamics365CrawlJobData.Api, input.SystemUserId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FullName;

            //if (input.MobileOfflineProfileId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.mobileofflineprofile, EntityEdgeType.Parent, input, input.MobileOfflineProfileId);

            //if (input.PositionId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.position, EntityEdgeType.Parent, input, input.PositionId);

            if (input.CalendarId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Calendar, EntityEdgeType.Parent, input, input.CalendarId);

            //if (input.QueueId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.QueueId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.BusinessUnitId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.Parent, input, input.BusinessUnitId);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.ParentSystemUserId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.ParentSystemUserId);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.DefaultMailbox != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Mail.Folder, EntityEdgeType.Parent, input, input.DefaultMailbox);

            if (input.OrganizationId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.OrganizationId.ToString());

            //if (input.SiteId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.site, EntityEdgeType.Parent, input, input.SiteId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            //if (input.TerritoryId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.TerritoryId);

            data.Properties[Dynamics365Vocabulary.SystemUser.SystemUserId] = input.SystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.TerritoryId] = input.TerritoryId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ParentSystemUserId] = input.ParentSystemUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PersonalEMailAddress] = input.PersonalEMailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.NickName] = input.NickName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.InternalEMailAddress] = input.InternalEMailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.MobileAlertEMail] = input.MobileAlertEMail.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PreferredEmailCode] = input.PreferredEmailCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.HomePhone] = input.HomePhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PreferredPhoneCode] = input.PreferredPhoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PreferredAddressCode] = input.PreferredAddressCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PhotoUrl] = input.PhotoUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DomainName] = input.DomainName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PassportLo] = input.PassportLo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PassportHi] = input.PassportHi.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DisabledReason] = input.DisabledReason.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsDisabled] = input.IsDisabled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.GovernmentId] = input.GovernmentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ParentSystemUserIdName] = input.ParentSystemUserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.TerritoryIdName] = input.TerritoryIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.BusinessUnitIdName] = input.BusinessUnitIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsDisabledName] = input.IsDisabledName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PreferredPhoneCodeName] = input.PreferredPhoneCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PreferredEmailCodeName] = input.PreferredEmailCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PreferredAddressCodeName] = input.PreferredAddressCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Skills] = input.Skills.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DisplayInServiceViews] = input.DisplayInServiceViews.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CalendarId] = input.CalendarId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ActiveDirectoryGuid] = input.ActiveDirectoryGuid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.SetupUser] = input.SetupUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.SiteId] = input.SiteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.SiteIdName] = input.SiteIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.SetupUserName] = input.SetupUserName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DisplayInServiceViewsName] = input.DisplayInServiceViewsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.WindowsLiveID] = input.WindowsLiveID.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IncomingEmailDeliveryMethod] = input.IncomingEmailDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.OutgoingEmailDeliveryMethod] = input.OutgoingEmailDeliveryMethod.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.AccessMode] = input.AccessMode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.InviteStatusCode] = input.InviteStatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsActiveDirectoryUser] = input.IsActiveDirectoryUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.AccessModeName] = input.AccessModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IncomingEmailDeliveryMethodName] = input.IncomingEmailDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.OutgoingEmailDeliveryMethodName] = input.OutgoingEmailDeliveryMethodName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.InviteStatusCodeName] = input.InviteStatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ParentSystemUserIdYomiName] = input.ParentSystemUserIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.YomiFullName] = input.YomiFullName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.YomiLastName] = input.YomiLastName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.YomiMiddleName] = input.YomiMiddleName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.YomiFirstName] = input.YomiFirstName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsIntegrationUser] = input.IsIntegrationUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DefaultFiltersPopulated] = input.DefaultFiltersPopulated.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsIntegrationUserName] = input.IsIntegrationUserName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.QueueId] = input.QueueId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.QueueIdName] = input.QueueIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EmailRouterAccessApproval] = input.EmailRouterAccessApproval.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EmailRouterAccessApprovalName] = input.EmailRouterAccessApprovalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CALType] = input.CALType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.CALTypeName] = input.CALTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsLicensed] = input.IsLicensed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsSyncWithDirectory] = input.IsSyncWithDirectory.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.YammerEmailAddress] = input.YammerEmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DefaultMailboxName] = input.DefaultMailboxName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.YammerUserId] = input.YammerUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DefaultMailbox] = input.DefaultMailbox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.UserLicenseType] = input.UserLicenseType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address2_Composite] = input.Address2_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.Address1_Composite] = input.Address1_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsEmailAddressApprovedByO365Admin] = input.IsEmailAddressApprovedByO365Admin.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PositionId] = input.PositionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.PositionIdName] = input.PositionIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.SharePointEmailAddress] = input.SharePointEmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.MobileOfflineProfileId] = input.MobileOfflineProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.MobileOfflineProfileIdName] = input.MobileOfflineProfileIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.DefaultOdbFolderName] = input.DefaultOdbFolderName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ApplicationId] = input.ApplicationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.ApplicationIdUri] = input.ApplicationIdUri.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.AzureActiveDirectoryObjectId] = input.AzureActiveDirectoryObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IdentityId] = input.IdentityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.LatestUpdateTime] = input.LatestUpdateTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.UserPuid] = input.UserPuid.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SystemUser.IsLicensedName] = input.IsLicensedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

