using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class CampaignResponseVocabulary : SimpleVocabulary
    {
        public CampaignResponseVocabulary()
        {
            VocabularyName = "Dynamics365 CampaignResponse";
            KeyPrefix = "dynamics365.campaignresponse";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("CampaignResponse", group =>
            {
                this.IsBilled = group.Add(new VocabularyKey("IsBilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether the campaign response was billed as part of resolving a case.")
                    .WithDisplayName("Is Billed")
                    .ModelProperty("isbilled", typeof(bool)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_campaignresponse_activities")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the campaign response's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.IsWorkflowCreated = group.Add(new VocabularyKey("IsWorkflowCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether the campaign response is created by a workflow rule.")
                    .WithDisplayName("Is Workflow Created")
                    .ModelProperty("isworkflowcreated", typeof(bool)));

                this.LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the responder's last name if the campaign response was received from a new prospect or customer.")
                    .WithDisplayName("Last Name")
                    .ModelProperty("lastname", typeof(string)));

                this.PromotionCodeName = group.Add(new VocabularyKey("PromotionCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a discount offer.")
                    .WithDisplayName("Promotion Code")
                    .ModelProperty("promotioncodename", typeof(string)));

                this.ActualStart = group.Add(new VocabularyKey("ActualStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the actual start date and time for the campaign response.")
                    .WithDisplayName("Actual Start")
                    .ModelProperty("actualstart", typeof(DateTime)));

                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the responder's fax number.")
                    .WithDisplayName("Fax")
                    .ModelProperty("fax", typeof(string)));

                this.Category = group.Add(new VocabularyKey("Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a category to identify the campaign response type, such as new business development or customer retention, to tie the campaign response to a business group or function.")
                    .WithDisplayName("Category")
                    .ModelProperty("category", typeof(string)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign response.")
                    .WithDisplayName("Close By")
                    .ModelProperty("scheduledend", typeof(DateTime)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected start date and time for the activity to provide details about the timing of the campaign response.")
                    .WithDisplayName("Scheduled Start")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_campaignresponse_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Campaign_CampaignResponses")
                    .WithDisplayName("Parent Campaign")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.from = group.Add(new VocabularyKey("from", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("From")
                    .ModelProperty("from", typeof(string)));

                this.Telephone = group.Add(new VocabularyKey("Telephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the responder's primary phone number.")
                    .WithDisplayName("Phone")
                    .ModelProperty("telephone", typeof(string)));

                this.ResponseCode = group.Add(new VocabularyKey("ResponseCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the type of response from the prospect or customer to indicate their interest in the campaign.")
                    .WithDisplayName("Response Code")
                    .ModelProperty("responsecode", typeof(string)));

                this.ActualDurationMinutes = group.Add(new VocabularyKey("ActualDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of minutes spent on this activity. The duration is used in reporting.")
                    .WithDisplayName("Actual Duration ")
                    .ModelProperty("actualdurationminutes", typeof(long)));

                this.Partner = group.Add(new VocabularyKey("Partner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the vendor account or contact to capture any third-party used to obtain the campaign response.")
                    .WithDisplayName("Outsource Vendor")
                    .ModelProperty("partner", typeof(string)));

                this.Subcategory = group.Add(new VocabularyKey("Subcategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales region, business group, or other function.")
                    .WithDisplayName("Sub-Category")
                    .ModelProperty("subcategory", typeof(string)));

                this.CompanyName = group.Add(new VocabularyKey("CompanyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the company if the campaign response was received from a new prospect or customer.")
                    .WithDisplayName("Company Name")
                    .ModelProperty("companyname", typeof(string)));

                this.ChannelTypeCode = group.Add(new VocabularyKey("ChannelTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select how the response was received, such as phone, letter, fax, or email.")
                    .WithDisplayName("Channel")
                    .ModelProperty("channeltypecode", typeof(string)));

                this.FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the responder's first name if the campaign response was received from a new prospect or customer.")
                    .WithDisplayName("First Name")
                    .ModelProperty("firstname", typeof(string)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"activity_pointer_campaignresponse")
                    .WithDisplayName("Campaign Response")
                    .ModelProperty("activityid", typeof(Guid)));

                this.EMailAddress = group.Add(new VocabularyKey("EMailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the responder's email address.")
                    .WithDisplayName("Email")
                    .ModelProperty("emailaddress", typeof(string)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for the associated service.")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.ActualEnd = group.Add(new VocabularyKey("ActualEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the campaign response was actually completed.")
                    .WithDisplayName("Actual End")
                    .ModelProperty("actualend", typeof(DateTime)));

                this.ScheduledDurationMinutes = group.Add(new VocabularyKey("ScheduledDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled duration of the campaign response in minutes.")
                    .WithDisplayName("Scheduled Duration")
                    .ModelProperty("scheduleddurationminutes", typeof(long)));

                this.ReceivedOn = group.Add(new VocabularyKey("ReceivedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date when the campaign response was received.")
                    .WithDisplayName("Received On")
                    .ModelProperty("receivedon", typeof(DateTime)));

                this.OriginatingActivityId = group.Add(new VocabularyKey("OriginatingActivityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the originating activity for the campaign response.")
                    .WithDisplayName("Originating Activity")
                    .ModelProperty("originatingactivityid", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are read-only and can't be edited.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the campaign response.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Customer = group.Add(new VocabularyKey("Customer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the account, contact, or lead that submitted the campaign response, if it was received from an existing prospect or customer.")
                    .WithDisplayName("Customer")
                    .ModelProperty("customer", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_campaignresponse_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a short description about the objective or primary topic of the campaign response.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the campaign response, such as key discussion points or objectives.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"user_campaignresponse")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of the owner of the campaign response, such as user, team, or business unit.")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the user who created the campaign response.")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the user who last modified the campaign response.")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Name status reason for the campaign response.")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.ChannelTypeCodeName = group.Add(new VocabularyKey("ChannelTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Channel type code name of the campaign response.")
                    .WithDisplayName("ChannelTypeCodeName")
                    .ModelProperty("channeltypecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status name of the campaign response.")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.IsWorkflowCreatedName = group.Add(new VocabularyKey("IsWorkflowCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWorkflowCreatedName")
                    .ModelProperty("isworkflowcreatedname", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.OriginatingActivityName = group.Add(new VocabularyKey("OriginatingActivityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the originating activity for the campaign response.")
                    .WithDisplayName("OriginatingActivityName")
                    .ModelProperty("originatingactivityname", typeof(string)));

                this.OriginatingActivityIdTypeCode = group.Add(new VocabularyKey("OriginatingActivityIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of the originating activity for the campaign response.")
                    .WithDisplayName("OriginatingActivityIdTypeCode")
                    .ModelProperty("originatingactivityidtypecode", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.IsBilledName = group.Add(new VocabularyKey("IsBilledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBilledName")
                    .ModelProperty("isbilledname", typeof(string)));

                this.ResponseCodeName = group.Add(new VocabularyKey("ResponseCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Code name of the campaign response.")
                    .WithDisplayName("ResponseCodeName")
                    .ModelProperty("responsecodename", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Priority code name of the campaign response.")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OverriddenCreatedOn")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.YomiLastName = group.Add(new VocabularyKey("YomiLastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.")
                    .WithDisplayName("Yomi Last Name")
                    .ModelProperty("yomilastname", typeof(string)));

                this.YomiFirstName = group.Add(new VocabularyKey("YomiFirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.")
                    .WithDisplayName("Yomi First Name")
                    .ModelProperty("yomifirstname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.YomiCompanyName = group.Add(new VocabularyKey("YomiCompanyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.")
                    .WithDisplayName("Yomi Company Name")
                    .ModelProperty("yomicompanyname", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_campaignresponse_createdonbehalfby")
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
                    .WithDescription(@"lk_campaignresponse_modifiedonbehalfby")
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

                this.ActivityTypeCode = group.Add(new VocabularyKey("ActivityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of activity.")
                    .WithDisplayName("Activity Type")
                    .ModelProperty("activitytypecode", typeof(string)));

                this.ActivityTypeCodeName = group.Add(new VocabularyKey("ActivityTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ActivityTypeCodeName")
                    .ModelProperty("activitytypecodename", typeof(string)));

                this.IsRegularActivity = group.Add(new VocabularyKey("IsRegularActivity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information regarding whether the activity is a regular activity type or event type.")
                    .WithDisplayName("Is Regular Activity")
                    .ModelProperty("isregularactivity", typeof(bool)));

                this.IsRegularActivityName = group.Add(new VocabularyKey("IsRegularActivityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRegularActivityName")
                    .ModelProperty("isregularactivityname", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"team_campaignresponse")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"TransactionCurrency_CampaignResponse")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_campaignresponses")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.ActivityAdditionalParams = group.Add(new VocabularyKey("ActivityAdditionalParams", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Additional Parameters")
                    .ModelProperty("activityadditionalparams", typeof(string)));

                this.LeftVoiceMail = group.Add(new VocabularyKey("LeftVoiceMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Left the voice mail")
                    .WithDisplayName("Left Voice Mail")
                    .ModelProperty("leftvoicemail", typeof(bool)));

                this.IsMapiPrivate = group.Add(new VocabularyKey("IsMapiPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Private")
                    .ModelProperty("ismapiprivate", typeof(bool)));

                this.DeliveryLastAttemptedOn = group.Add(new VocabularyKey("DeliveryLastAttemptedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the delivery of the activity was last attempted.")
                    .WithDisplayName("Date Delivery Last Attempted")
                    .ModelProperty("deliverylastattemptedon", typeof(DateTime)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date and time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.PostponeActivityProcessingUntil = group.Add(new VocabularyKey("PostponeActivityProcessingUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Delay activity processing until")
                    .ModelProperty("postponeactivityprocessinguntil", typeof(DateTime)));

                this.SentOn = group.Add(new VocabularyKey("SentOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the activity was sent.")
                    .WithDisplayName("Date Sent")
                    .ModelProperty("senton", typeof(DateTime)));

                this.SortDate = group.Add(new VocabularyKey("SortDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time by which the activities are sorted.")
                    .WithDisplayName("Sort Date")
                    .ModelProperty("sortdate", typeof(DateTime)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how long, in minutes, that the record was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.ExchangeWebLink = group.Add(new VocabularyKey("ExchangeWebLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"Shows the web link of Activity of type email.")
                    .WithDisplayName("Exchange WebLink")
                    .ModelProperty("exchangeweblink", typeof(string)));

                this.ExchangeItemId = group.Add(new VocabularyKey("ExchangeItemId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"The message id of activity which is returned from Exchange Server.")
                    .WithDisplayName("Exchange Item ID")
                    .ModelProperty("exchangeitemid", typeof(string)));

                this.SeriesId = group.Add(new VocabularyKey("SeriesId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Uniqueidentifier specifying the id of recurring series of an instance.")
                    .WithDisplayName("Series Id")
                    .ModelProperty("seriesid", typeof(Guid)));

                this.DeliveryPriorityCode = group.Add(new VocabularyKey("DeliveryPriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Priority of delivery of the activity to the email server.")
                    .WithDisplayName("Delivery Priority")
                    .ModelProperty("deliveryprioritycode", typeof(string)));

                this.InstanceTypeCode = group.Add(new VocabularyKey("InstanceTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of instance of a recurring series.")
                    .WithDisplayName("Recurring Instance Type")
                    .ModelProperty("instancetypecode", typeof(string)));

                this.Community = group.Add(new VocabularyKey("Community", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.")
                    .WithDisplayName("Social Channel")
                    .ModelProperty("community", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the service level agreement (SLA) that you want to apply to the case record.")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last SLA that was applied to this case. This field is for internal use only.")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.SenderMailboxId = group.Add(new VocabularyKey("SenderMailboxId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the mailbox associated with the sender of the email message.")
                    .WithDisplayName("Sender's Mailbox")
                    .ModelProperty("sendermailboxid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SenderMailboxIdName = group.Add(new VocabularyKey("SenderMailboxIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SenderMailboxIdName")
                    .ModelProperty("sendermailboxidname", typeof(string)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.LeftVoiceMailName = group.Add(new VocabularyKey("LeftVoiceMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeftVoiceMailName")
                    .ModelProperty("leftvoicemailname", typeof(string)));

                this.IsMapiPrivateName = group.Add(new VocabularyKey("IsMapiPrivateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsMapiPrivateName")
                    .ModelProperty("ismapiprivatename", typeof(string)));

                this.DeliveryPriorityCodeName = group.Add(new VocabularyKey("DeliveryPriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DeliveryPriorityCodeName")
                    .ModelProperty("deliveryprioritycodename", typeof(string)));

                this.CommunityName = group.Add(new VocabularyKey("CommunityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CommunityName")
                    .ModelProperty("communityname", typeof(string)));

                this.InstanceTypeCodeName = group.Add(new VocabularyKey("InstanceTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceTypeCodeName")
                    .ModelProperty("instancetypecodename", typeof(string)));

                this.To = group.Add(new VocabularyKey("To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Person who is the receiver of the activity.")
                    .WithDisplayName("To")
                    .ModelProperty("to", typeof(string)));

                this.CC = group.Add(new VocabularyKey("CC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Carbon-copy (cc) recipients of the activity.")
                    .WithDisplayName("CC")
                    .ModelProperty("cc", typeof(string)));

                this.BCC = group.Add(new VocabularyKey("BCC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Blind Carbon-copy (bcc) recipients of the activity.")
                    .WithDisplayName("BCC")
                    .ModelProperty("bcc", typeof(string)));

                this.RequiredAttendees = group.Add(new VocabularyKey("RequiredAttendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"List of required attendees for the activity.")
                    .WithDisplayName("Required Attendees")
                    .ModelProperty("requiredattendees", typeof(string)));

                this.OptionalAttendees = group.Add(new VocabularyKey("OptionalAttendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"List of optional attendees for the activity.")
                    .WithDisplayName("Optional Attendees")
                    .ModelProperty("optionalattendees", typeof(string)));

                this.Organizer = group.Add(new VocabularyKey("Organizer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Person who organized the activity.")
                    .WithDisplayName("Organizer")
                    .ModelProperty("organizer", typeof(string)));

                this.Resources = group.Add(new VocabularyKey("Resources", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Users or facility/equipment that are required for the activity.")
                    .WithDisplayName("Resources")
                    .ModelProperty("resources", typeof(string)));

                this.Customers = group.Add(new VocabularyKey("Customers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Customer with which the activity is associated.")
                    .WithDisplayName("Customers")
                    .ModelProperty("customers", typeof(string)));

                this.Partners = group.Add(new VocabularyKey("Partners", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Outsource vendor with which activity is associated.")
                    .WithDisplayName("Outsource Vendors")
                    .ModelProperty("partners", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey IsBilled { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey IsWorkflowCreated { get; private set; }

        public VocabularyKey LastName { get; private set; }

        public VocabularyKey PromotionCodeName { get; private set; }

        public VocabularyKey ActualStart { get; private set; }

        public VocabularyKey Fax { get; private set; }

        public VocabularyKey Category { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey from { get; private set; }

        public VocabularyKey Telephone { get; private set; }

        public VocabularyKey ResponseCode { get; private set; }

        public VocabularyKey ActualDurationMinutes { get; private set; }

        public VocabularyKey Partner { get; private set; }

        public VocabularyKey Subcategory { get; private set; }

        public VocabularyKey CompanyName { get; private set; }

        public VocabularyKey ChannelTypeCode { get; private set; }

        public VocabularyKey FirstName { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey EMailAddress { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey ActualEnd { get; private set; }

        public VocabularyKey ScheduledDurationMinutes { get; private set; }

        public VocabularyKey ReceivedOn { get; private set; }

        public VocabularyKey OriginatingActivityId { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Customer { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey ChannelTypeCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey IsWorkflowCreatedName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey OriginatingActivityName { get; private set; }

        public VocabularyKey OriginatingActivityIdTypeCode { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey IsBilledName { get; private set; }

        public VocabularyKey ResponseCodeName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey YomiLastName { get; private set; }

        public VocabularyKey YomiFirstName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey YomiCompanyName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ActivityTypeCode { get; private set; }

        public VocabularyKey ActivityTypeCodeName { get; private set; }

        public VocabularyKey IsRegularActivity { get; private set; }

        public VocabularyKey IsRegularActivityName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey ActivityAdditionalParams { get; private set; }

        public VocabularyKey LeftVoiceMail { get; private set; }

        public VocabularyKey IsMapiPrivate { get; private set; }

        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }

        public VocabularyKey SentOn { get; private set; }

        public VocabularyKey SortDate { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey ExchangeWebLink { get; private set; }

        public VocabularyKey ExchangeItemId { get; private set; }

        public VocabularyKey SeriesId { get; private set; }

        public VocabularyKey DeliveryPriorityCode { get; private set; }

        public VocabularyKey InstanceTypeCode { get; private set; }

        public VocabularyKey Community { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey SenderMailboxId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SenderMailboxIdName { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey LeftVoiceMailName { get; private set; }

        public VocabularyKey IsMapiPrivateName { get; private set; }

        public VocabularyKey DeliveryPriorityCodeName { get; private set; }

        public VocabularyKey CommunityName { get; private set; }

        public VocabularyKey InstanceTypeCodeName { get; private set; }

        public VocabularyKey To { get; private set; }

        public VocabularyKey CC { get; private set; }

        public VocabularyKey BCC { get; private set; }

        public VocabularyKey RequiredAttendees { get; private set; }

        public VocabularyKey OptionalAttendees { get; private set; }

        public VocabularyKey Organizer { get; private set; }

        public VocabularyKey Resources { get; private set; }

        public VocabularyKey Customers { get; private set; }

        public VocabularyKey Partners { get; private set; }


    }
}

