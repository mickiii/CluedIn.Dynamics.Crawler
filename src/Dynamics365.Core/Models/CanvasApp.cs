using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CanvasApp : DynamicsModel
    {
        [JsonProperty("canvasapprowid")]
        public Guid? CanvasAppRowId { get; set; }

        [JsonProperty("appversion")]
        public string AppVersion { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdbyclientversion")]
        public string CreatedByClientVersion { get; set; }

        [JsonProperty("minclientversion")]
        public string MinClientVersion { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("createdtime")]
        public DateTimeOffset? CreatedTime { get; set; }

        [JsonProperty("appopenuri")]
        public string AppOpenUri { get; set; }

        [JsonProperty("iscdsupgraded")]
        public bool? IsCdsUpgraded { get; set; }

        [JsonProperty("galleryitemid")]
        public string GalleryItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("aadlastmodifiedbyid")]
        public string AADLastModifiedById { get; set; }

        [JsonProperty("aadlastpublishedbyid")]
        public string AADLastPublishedById { get; set; }

        [JsonProperty("displayname")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("commitmessage")]
        public string CommitMessage { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("lastmodifiedtime")]
        public DateTimeOffset? LastModifiedTime { get; set; }

        [JsonProperty("lastpublishtime")]
        public DateTimeOffset? LastPublishTime { get; set; }

        [JsonProperty("connectionreferences")]
        public string ConnectionReferences { get; set; }

        [JsonProperty("isfeaturedapp")]
        public bool? IsFeaturedApp { get; set; }

        [JsonProperty("bypassconsent")]
        public bool? BypassConsent { get; set; }

        [JsonProperty("admincontrolbypassconsent")]
        public bool? AdminControlBypassConsent { get; set; }

        [JsonProperty("isheroapp")]
        public bool? IsHeroApp { get; set; }

        [JsonProperty("ishidden")]
        public bool? IsHidden { get; set; }

        [JsonProperty("canvasappid")]
        public Guid? CanvasAppId { get; set; }

        [JsonProperty("backgroundcolor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("iscdsupgradedname")]
        public string IsCdsUpgradedName { get; set; }

        [JsonProperty("isfeaturedappname")]
        public string IsFeaturedAppName { get; set; }

        [JsonProperty("bypassconsentname")]
        public string BypassConsentName { get; set; }

        [JsonProperty("admincontrolbypassconsentname")]
        public string AdminControlBypassConsentName { get; set; }

        [JsonProperty("isheroappname")]
        public string IsHeroAppName { get; set; }

        [JsonProperty("ishiddenname")]
        public string IsHiddenName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owningbusinessunitname")]
        public string OwningBusinessUnitName { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("aadcreatedbyid")]
        public string AADCreatedById { get; set; }

        [JsonProperty("authorizationreferences")]
        public string AuthorizationReferences { get; set; }

        [JsonProperty("embeddedapp")]
        public string EmbeddedApp { get; set; }

        [JsonProperty("cdsdependencies")]
        public string CdsDependencies { get; set; }

        [JsonProperty("databasereferences")]
        public string DatabaseReferences { get; set; }


    }
}

