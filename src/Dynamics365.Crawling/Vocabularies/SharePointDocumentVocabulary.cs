using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SharePointDocumentVocabulary : SimpleVocabulary
    {
        public SharePointDocumentVocabulary()
        {
            VocabularyName = "Dynamics365 SharePointDocument";
            KeyPrefix = "dynamics365.sharepointdocument";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SharePointDocument", group =>
            {
                this.AbsoluteUrl = group.Add(new VocabularyKey("AbsoluteUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Type the URL where the SharePoint document is located.")
                    .WithDisplayName("Absolute URL")
                    .ModelProperty("absoluteurl", typeof(string)));

                this.AppCreatedBy = group.Add(new VocabularyKey("AppCreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Name of the person who created the application.")
                    .WithDisplayName("Application Created by")
                    .ModelProperty("appcreatedby", typeof(string)));

                this.AppModifiedBy = group.Add(new VocabularyKey("AppModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Name of the person who last modified the application.")
                    .WithDisplayName("Application Modified By")
                    .ModelProperty("appmodifiedby", typeof(string)));

                this.Author = group.Add(new VocabularyKey("Author", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Name of the author of the SharePoint document.")
                    .WithDisplayName("Author")
                    .ModelProperty("author", typeof(string)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the business unit that the record is associated with.")
                    .WithDisplayName("Business Unit")
                    .ModelProperty("businessunitid", typeof(string)));

                this.BusinessUnitIdName = group.Add(new VocabularyKey("BusinessUnitIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BusinessUnitIdName")
                    .ModelProperty("businessunitidname", typeof(string)));

                this.CheckedOutTo = group.Add(new VocabularyKey("CheckedOutTo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows who the SharePoint document is checked out to.")
                    .WithDisplayName("Checked Out To")
                    .ModelProperty("checkedoutto", typeof(string)));

                this.CheckInComment = group.Add(new VocabularyKey("CheckInComment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Type a comment about the document that is being checked in.")
                    .WithDisplayName("Check In Comment")
                    .ModelProperty("checkincomment", typeof(string)));

                this.ContentType = group.Add(new VocabularyKey("ContentType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"The content type of the document.")
                    .WithDisplayName("Content Type")
                    .ModelProperty("contenttype", typeof(string)));

                this.ContentTypeId = group.Add(new VocabularyKey("ContentTypeId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the unique identifier of the content type.")
                    .WithDisplayName("Content Type ID")
                    .ModelProperty("contenttypeid", typeof(long)));

                this.CopySource = group.Add(new VocabularyKey("CopySource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"SharePoint source item URL")
                    .WithDisplayName("Copy Source")
                    .ModelProperty("copysource", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

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
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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

                this.DocumentId = group.Add(new VocabularyKey("DocumentId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of a SharePoint document in document library.")
                    .WithDisplayName("Document ID")
                    .ModelProperty("documentid", typeof(long)));

                this.EditUrl = group.Add(new VocabularyKey("EditUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the edit URL of the SharePoint document.")
                    .WithDisplayName("Edit Web App URL")
                    .ModelProperty("editurl", typeof(string)));

                this.Edit = group.Add(new VocabularyKey("Edit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Edit Url of the Sharepoint Form")
                    .WithDisplayName("Edit Url Sharepoint Form")
                    .ModelProperty("edit", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the exchange rate between the currency associated with the SharePoint document record and the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.FileSize = group.Add(new VocabularyKey("FileSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the file size.")
                    .WithDisplayName("File Size")
                    .ModelProperty("filesize", typeof(long)));

                this.FileType = group.Add(new VocabularyKey("FileType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the file type.")
                    .WithDisplayName("File Type")
                    .ModelProperty("filetype", typeof(string)));

                this.ChildFolderCount = group.Add(new VocabularyKey("ChildFolderCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of child folders.")
                    .WithDisplayName("Folder Child Count")
                    .ModelProperty("childfoldercount", typeof(long)));

                this.FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the full name of the SharePoint document.")
                    .WithDisplayName("Name")
                    .ModelProperty("fullname", typeof(string)));

                this.IsCheckedOut = group.Add(new VocabularyKey("IsCheckedOut", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether the file is checked out.")
                    .WithDisplayName("Is Checked out")
                    .ModelProperty("ischeckedout", typeof(bool)));

                this.IsFolder = group.Add(new VocabularyKey("IsFolder", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether the file is a folder.")
                    .WithDisplayName("Is Folder")
                    .ModelProperty("isfolder", typeof(bool)));

                this.ChildItemCount = group.Add(new VocabularyKey("ChildItemCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how many child items there are.")
                    .WithDisplayName("Child Item Count")
                    .ModelProperty("childitemcount", typeof(long)));

                this.Modified = group.Add(new VocabularyKey("Modified", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the SharePoint document was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified")
                    .ModelProperty("modified", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

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
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who modified the record on behalf of another user.")
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

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the SharePoint document.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the business unit that the record owner belongs to.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Owner Id Type")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the team that owns the SharePoint document record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the user who owns the SharePoint document record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.ReadUrl = group.Add(new VocabularyKey("ReadUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the Read URL of the SharePoint document.")
                    .WithDisplayName("Read WebApp URL")
                    .ModelProperty("readurl", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"SalesLiterature_SharepointDocument")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.SharePointCreatedOn = group.Add(new VocabularyKey("SharePointCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the SharePoint document record was created.")
                    .WithDisplayName("Created On SharePoint")
                    .ModelProperty("sharepointcreatedon", typeof(DateTime)));

                this.SharePointDocumentId = group.Add(new VocabularyKey("SharePointDocumentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the unique identifier of the SharePoint document record.")
                    .WithDisplayName("SharePoint Document")
                    .ModelProperty("sharepointdocumentid", typeof(Guid)));

                this.LocationId = group.Add(new VocabularyKey("LocationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Unique identifier of the associated document location.")
                    .WithDisplayName("SharePoint Document Location")
                    .ModelProperty("locationid", typeof(string)));

                this.SharePointModifiedBy = group.Add(new VocabularyKey("SharePointModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows who last updated the document record.")
                    .WithDisplayName("Modified by")
                    .ModelProperty("sharepointmodifiedby", typeof(string)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the title or name that describes the SharePoint document.")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.Version = group.Add(new VocabularyKey("Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the SharePoint document version")
                    .WithDisplayName("SharePoint Document Version")
                    .ModelProperty("version", typeof(string)));

                this.RelativeLocation = group.Add(new VocabularyKey("RelativeLocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Relative location of Sharepoint Document")
                    .WithDisplayName("Path")
                    .ModelProperty("relativelocation", typeof(string)));

                this.DocumentLocationType = group.Add(new VocabularyKey("DocumentLocationType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Location type of the SharePoint document location.")
                    .WithDisplayName("Document Location Type")
                    .ModelProperty("documentlocationtype", typeof(string)));

                this.DocumentLocationTypeName = group.Add(new VocabularyKey("DocumentLocationTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DocumentLocationTypeName")
                    .ModelProperty("documentlocationtypename", typeof(string)));

                this.IsRecursiveFetch = group.Add(new VocabularyKey("IsRecursiveFetch", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether to fetch data recursively from the given folder location.")
                    .WithDisplayName("Is Recursive Fetch")
                    .ModelProperty("isrecursivefetch", typeof(bool)));

                this.ServiceType = group.Add(new VocabularyKey("ServiceType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the service type of the SharePoint site.")
                    .WithDisplayName("Source")
                    .ModelProperty("servicetype", typeof(string)));

                this.ServiceTypeName = group.Add(new VocabularyKey("ServiceTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("ServiceTypeName")
                    .ModelProperty("servicetypename", typeof(string)));

                this.IconClassName = group.Add(new VocabularyKey("IconClassName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Stores the Icon Class name of the SharePoint document.")
                    .WithDisplayName("Icon ClassName")
                    .ModelProperty("iconclassname", typeof(string)));

                this.LocationName = group.Add(new VocabularyKey("LocationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Name of the associated document location.")
                    .WithDisplayName("Location")
                    .ModelProperty("locationname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AbsoluteUrl { get; private set; }

        public VocabularyKey AppCreatedBy { get; private set; }

        public VocabularyKey AppModifiedBy { get; private set; }

        public VocabularyKey Author { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey BusinessUnitIdName { get; private set; }

        public VocabularyKey CheckedOutTo { get; private set; }

        public VocabularyKey CheckInComment { get; private set; }

        public VocabularyKey ContentType { get; private set; }

        public VocabularyKey ContentTypeId { get; private set; }

        public VocabularyKey CopySource { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey DocumentId { get; private set; }

        public VocabularyKey EditUrl { get; private set; }

        public VocabularyKey Edit { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey FileSize { get; private set; }

        public VocabularyKey FileType { get; private set; }

        public VocabularyKey ChildFolderCount { get; private set; }

        public VocabularyKey FullName { get; private set; }

        public VocabularyKey IsCheckedOut { get; private set; }

        public VocabularyKey IsFolder { get; private set; }

        public VocabularyKey ChildItemCount { get; private set; }

        public VocabularyKey Modified { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey ReadUrl { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey SharePointCreatedOn { get; private set; }

        public VocabularyKey SharePointDocumentId { get; private set; }

        public VocabularyKey LocationId { get; private set; }

        public VocabularyKey SharePointModifiedBy { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey Version { get; private set; }

        public VocabularyKey RelativeLocation { get; private set; }

        public VocabularyKey DocumentLocationType { get; private set; }

        public VocabularyKey DocumentLocationTypeName { get; private set; }

        public VocabularyKey IsRecursiveFetch { get; private set; }

        public VocabularyKey ServiceType { get; private set; }

        public VocabularyKey ServiceTypeName { get; private set; }

        public VocabularyKey IconClassName { get; private set; }

        public VocabularyKey LocationName { get; private set; }


    }
}

