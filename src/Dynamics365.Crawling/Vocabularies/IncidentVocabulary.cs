using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class IncidentVocabulary : SimpleVocabulary
    {
        public IncidentVocabulary()
        {
            VocabularyName = "Dynamics365 Incident";
            KeyPrefix = "dynamics365.incident";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Incident", group =>
            {
                this.IncidentId = group.Add(new VocabularyKey("IncidentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_incident_ChildIncidentCount")
                    .WithDisplayName("Case")
                    .ModelProperty("incidentid", typeof(Guid)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_incidents")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.ContractDetailId = group.Add(new VocabularyKey("ContractDetailId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contract_detail_cases")
                    .WithDisplayName("Contract Line")
                    .ModelProperty("contractdetailid", typeof(string)));

                this.SubjectId = group.Add(new VocabularyKey("SubjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"subject_incidents")
                    .WithDisplayName("Subject")
                    .ModelProperty("subjectid", typeof(string)));

                this.ContractId = group.Add(new VocabularyKey("ContractId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contract_cases")
                    .WithDisplayName("Contract")
                    .ModelProperty("contractid", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"manualsla_cases")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"system_user_incidents")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.ActualServiceUnits = group.Add(new VocabularyKey("ActualServiceUnits", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of service units that were actually required to resolve the case.")
                    .WithDisplayName("Actual Service Units")
                    .ModelProperty("actualserviceunits", typeof(long)));

                this.CaseOriginCode = group.Add(new VocabularyKey("CaseOriginCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.")
                    .WithDisplayName("Origin")
                    .ModelProperty("caseorigincode", typeof(string)));

                this.BilledServiceUnits = group.Add(new VocabularyKey("BilledServiceUnits", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of service units that were billed to the customer for the case.")
                    .WithDisplayName("Billed Service Units")
                    .ModelProperty("billedserviceunits", typeof(long)));

                this.CaseTypeCode = group.Add(new VocabularyKey("CaseTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the type of case to identify the incident for use in case routing and analysis.")
                    .WithDisplayName("Case Type")
                    .ModelProperty("casetypecode", typeof(string)));

                this.ProductSerialNumber = group.Add(new VocabularyKey("ProductSerialNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.")
                    .WithDisplayName("Serial Number")
                    .ModelProperty("productserialnumber", typeof(string)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics 365 views.")
                    .WithDisplayName("Case Title")
                    .ModelProperty("title", typeof(string)));

                this.ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"product_incidents")
                    .WithDisplayName("Product")
                    .ModelProperty("productid", typeof(string)));

                this.ContractServiceLevelCode = group.Add(new VocabularyKey("ContractServiceLevelCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the service level for the case to make sure the case is handled correctly.")
                    .WithDisplayName("Service Level")
                    .ModelProperty("contractservicelevelcode", typeof(string)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the case is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the case to assist the service team in reaching a resolution.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact associated with the case.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(string)));

                this.IsDecrementing = group.Add(new VocabularyKey("IsDecrementing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Decrementing")
                    .ModelProperty("isdecrementing", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.TicketNumber = group.Add(new VocabularyKey("TicketNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Shows the case number for customer reference and searching capabilities. This cannot be modified.")
                    .WithDisplayName("Case Number - Not Used")
                    .ModelProperty("ticketnumber", typeof(string)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.CustomerSatisfactionCode = group.Add(new VocabularyKey("CustomerSatisfactionCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the customer's level of satisfaction with the handling and resolution of the case.")
                    .WithDisplayName("Satisfaction")
                    .ModelProperty("customersatisfactioncode", typeof(string)));

                this.IncidentStageCode = group.Add(new VocabularyKey("IncidentStageCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the current stage of the service process for the case to assist service team members when they review or transfer a case.")
                    .WithDisplayName("Case Stage")
                    .ModelProperty("incidentstagecode", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_incidentbase_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.FollowupBy = group.Add(new VocabularyKey("FollowupBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date by which a customer service representative has to follow up with the customer on this case.")
                    .WithDisplayName("Follow Up By")
                    .ModelProperty("followupby", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_incidentbase_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the case.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.SeverityCode = group.Add(new VocabularyKey("SeverityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the severity of this case to indicate the incident's impact on the customer's business.")
                    .WithDisplayName("Severity")
                    .ModelProperty("severitycode", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the case's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.ResponsibleContactId = group.Add(new VocabularyKey("ResponsibleContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"contact_as_responsible_contact")
                    .WithDisplayName("Responsible Contact")
                    .ModelProperty("responsiblecontactid", typeof(string)));

                this.SubjectIdName = group.Add(new VocabularyKey("SubjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SubjectIdName")
                    .ModelProperty("subjectidname", typeof(string)));

                this.AccountIdName = group.Add(new VocabularyKey("AccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdName")
                    .ModelProperty("accountidname", typeof(string)));

                this.ContactIdName = group.Add(new VocabularyKey("ContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdName")
                    .ModelProperty("contactidname", typeof(string)));

                this.ResponsibleContactIdName = group.Add(new VocabularyKey("ResponsibleContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ResponsibleContactIdName")
                    .ModelProperty("responsiblecontactidname", typeof(string)));

                this.ContractIdName = group.Add(new VocabularyKey("ContractIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContractIdName")
                    .ModelProperty("contractidname", typeof(string)));

                this.ContractDetailIdName = group.Add(new VocabularyKey("ContractDetailIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContractDetailIdName")
                    .ModelProperty("contractdetailidname", typeof(string)));

                this.ProductIdName = group.Add(new VocabularyKey("ProductIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ProductIdName")
                    .ModelProperty("productidname", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.CustomerId = group.Add(new VocabularyKey("CustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.")
                    .WithDisplayName("Contact")
                    .ModelProperty("customerid", typeof(string)));

                this.CustomerIdName = group.Add(new VocabularyKey("CustomerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdName")
                    .ModelProperty("customeridname", typeof(string)));

                this.CustomerIdType = group.Add(new VocabularyKey("CustomerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Customer Type")
                    .ModelProperty("customeridtype", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Team Owner")
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

                this.IsDecrementingName = group.Add(new VocabularyKey("IsDecrementingName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDecrementingName")
                    .ModelProperty("isdecrementingname", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.CaseOriginCodeName = group.Add(new VocabularyKey("CaseOriginCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CaseOriginCodeName")
                    .ModelProperty("caseorigincodename", typeof(string)));

                this.IncidentStageCodeName = group.Add(new VocabularyKey("IncidentStageCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncidentStageCodeName")
                    .ModelProperty("incidentstagecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.SeverityCodeName = group.Add(new VocabularyKey("SeverityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SeverityCodeName")
                    .ModelProperty("severitycodename", typeof(string)));

                this.CaseTypeCodeName = group.Add(new VocabularyKey("CaseTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CaseTypeCodeName")
                    .ModelProperty("casetypecodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.CustomerSatisfactionCodeName = group.Add(new VocabularyKey("CustomerSatisfactionCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CustomerSatisfactionCodeName")
                    .ModelProperty("customersatisfactioncodename", typeof(string)));

                this.ContractServiceLevelCodeName = group.Add(new VocabularyKey("ContractServiceLevelCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ContractServiceLevelCodeName")
                    .ModelProperty("contractservicelevelcodename", typeof(string)));

                this.KbArticleId = group.Add(new VocabularyKey("KbArticleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"kbarticle_incidents")
                    .WithDisplayName("Knowledge Base Article")
                    .ModelProperty("kbarticleid", typeof(string)));

                this.KbArticleIdName = group.Add(new VocabularyKey("KbArticleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("KbArticleIdName")
                    .ModelProperty("kbarticleidname", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.ContactIdYomiName = group.Add(new VocabularyKey("ContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdYomiName")
                    .ModelProperty("contactidyominame", typeof(string)));

                this.AccountIdYomiName = group.Add(new VocabularyKey("AccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdYomiName")
                    .ModelProperty("accountidyominame", typeof(string)));

                this.ResponsibleContactIdYomiName = group.Add(new VocabularyKey("ResponsibleContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ResponsibleContactIdYomiName")
                    .ModelProperty("responsiblecontactidyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CustomerIdYomiName = group.Add(new VocabularyKey("CustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdYomiName")
                    .ModelProperty("customeridyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_incidentbase_createdonbehalfby")
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
                    .WithDescription(@"lk_incidentbase_modifiedonbehalfby")
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

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"team_incidents")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"TransactionCurrency_Incident")
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

                this.ServiceStage = group.Add(new VocabularyKey("ServiceStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the stage, in the case resolution process, that the case is in.")
                    .WithDisplayName("Service Stage")
                    .ModelProperty("servicestage", typeof(string)));

                this.ServiceStageName = group.Add(new VocabularyKey("ServiceStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ServiceStageName")
                    .ModelProperty("servicestagename", typeof(string)));

                this.ExistingCase = group.Add(new VocabularyKey("ExistingCase", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"incident_existingcase")
                    .WithDisplayName("Existing Case")
                    .ModelProperty("existingcase", typeof(string)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_incident")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The default image for the entity.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.CheckEmail = group.Add(new VocabularyKey("CheckEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"This attribute is used for Sample Service Business Processes.")
                    .WithDisplayName("Check Email")
                    .ModelProperty("checkemail", typeof(bool)));

                this.ActivitiesComplete = group.Add(new VocabularyKey("ActivitiesComplete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"This attribute is used for Sample Service Business Processes.")
                    .WithDisplayName("Activities Complete")
                    .ModelProperty("activitiescomplete", typeof(bool)));

                this.ActivitiesCompleteName = group.Add(new VocabularyKey("ActivitiesCompleteName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ActivitiesCompleteName")
                    .ModelProperty("activitiescompletename", typeof(string)));

                this.CheckEmailName = group.Add(new VocabularyKey("CheckEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CheckEmailName")
                    .ModelProperty("checkemailname", typeof(string)));

                this.FollowUpTaskCreated = group.Add(new VocabularyKey("FollowUpTaskCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"This attribute is used for Sample Service Business Processes.")
                    .WithDisplayName("Follow up Task Created")
                    .ModelProperty("followuptaskcreated", typeof(bool)));

                this.FollowUpTaskCreatedName = group.Add(new VocabularyKey("FollowUpTaskCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FollowUpTaskCreatedName")
                    .ModelProperty("followuptaskcreatedname", typeof(string)));

                this.NumberOfChildIncidents = group.Add(new VocabularyKey("NumberOfChildIncidents", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of child incidents associated with the incident.")
                    .WithDisplayName("Child Cases")
                    .ModelProperty("numberofchildincidents", typeof(long)));

                this.SocialProfileId = group.Add(new VocabularyKey("SocialProfileId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"socialprofile_cases")
                    .WithDisplayName("Social Profile")
                    .ModelProperty("socialprofileid", typeof(string)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last SLA that was applied to this case. This field is for internal use only.")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.MessageTypeCode = group.Add(new VocabularyKey("MessageTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether the post originated as a public or private message.")
                    .WithDisplayName("Received As")
                    .ModelProperty("messagetypecode", typeof(string)));

                this.BlockedProfile = group.Add(new VocabularyKey("BlockedProfile", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Details whether the profile is blocked or not.")
                    .WithDisplayName("Blocked Profile")
                    .ModelProperty("blockedprofile", typeof(bool)));

                this.DecrementEntitlementTermName = group.Add(new VocabularyKey("DecrementEntitlementTermName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DecrementEntitlementTermName")
                    .ModelProperty("decremententitlementtermname", typeof(string)));

                this.EntitlementId = group.Add(new VocabularyKey("EntitlementId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"entitlement_cases")
                    .WithDisplayName("Entitlement")
                    .ModelProperty("entitlementid", typeof(string)));

                this.EntitlementIdName = group.Add(new VocabularyKey("EntitlementIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("EntitlementIdName")
                    .ModelProperty("entitlementidname", typeof(string)));

                this.MasterId = group.Add(new VocabularyKey("MasterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"incident_master_incident")
                    .WithDisplayName("Master Case")
                    .ModelProperty("masterid", typeof(string)));

                this.MasterIdName = group.Add(new VocabularyKey("MasterIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterIdName")
                    .ModelProperty("masteridname", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.ParentCaseId = group.Add(new VocabularyKey("ParentCaseId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"incident_parent_incident")
                    .WithDisplayName("Parent Case")
                    .ModelProperty("parentcaseid", typeof(string)));

                this.DecrementEntitlementTerm = group.Add(new VocabularyKey("DecrementEntitlementTerm", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether terms of the associated entitlement should be decremented or not.")
                    .WithDisplayName("Decrement Entitlement Terms")
                    .ModelProperty("decremententitlementterm", typeof(bool)));

                this.ParentCaseIdName = group.Add(new VocabularyKey("ParentCaseIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentCaseIdName")
                    .ModelProperty("parentcaseidname", typeof(string)));

                this.CreatedByExternalParty = group.Add(new VocabularyKey("CreatedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_externalparty_incident_createdby")
                    .WithDisplayName("Created By (External Party)")
                    .ModelProperty("createdbyexternalparty", typeof(string)));

                this.CreatedByExternalPartyName = group.Add(new VocabularyKey("CreatedByExternalPartyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByExternalPartyName")
                    .ModelProperty("createdbyexternalpartyname", typeof(string)));

                this.CreatedByExternalPartyYomiName = group.Add(new VocabularyKey("CreatedByExternalPartyYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByExternalPartyYomiName")
                    .ModelProperty("createdbyexternalpartyyominame", typeof(string)));

                this.ModifiedByExternalParty = group.Add(new VocabularyKey("ModifiedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_externalparty_incident_modifiedby")
                    .WithDisplayName("Modified By (External Party)")
                    .ModelProperty("modifiedbyexternalparty", typeof(string)));

                this.ModifiedByExternalPartyName = group.Add(new VocabularyKey("ModifiedByExternalPartyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByExternalPartyName")
                    .ModelProperty("modifiedbyexternalpartyname", typeof(string)));

                this.ModifiedByExternalPartyYomiName = group.Add(new VocabularyKey("ModifiedByExternalPartyYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByExternalPartyYomiName")
                    .ModelProperty("modifiedbyexternalpartyyominame", typeof(string)));

                this.SentimentValue = group.Add(new VocabularyKey("SentimentValue", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.")
                    .WithDisplayName("Sentiment Value")
                    .ModelProperty("sentimentvalue", typeof(double)));

                this.SocialProfileIdName = group.Add(new VocabularyKey("SocialProfileIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SocialProfileIdName")
                    .ModelProperty("socialprofileidname", typeof(string)));

                this.InfluenceScore = group.Add(new VocabularyKey("InfluenceScore", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Will contain the Influencer score coming from NetBreeze.")
                    .WithDisplayName("Influence Score")
                    .ModelProperty("influencescore", typeof(double)));

                this.MessageTypeCodeName = group.Add(new VocabularyKey("MessageTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MessageTypeCodeName")
                    .ModelProperty("messagetypecodename", typeof(string)));

                this.BlockedProfileName = group.Add(new VocabularyKey("BlockedProfileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BlockedProfileName")
                    .ModelProperty("blockedprofilename", typeof(string)));

                this.Merged = group.Add(new VocabularyKey("Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Tells whether the incident has been merged with another incident.")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("merged", typeof(bool)));

                this.RouteCase = group.Add(new VocabularyKey("RouteCase", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Tells whether the incident has been routed to queue or not.")
                    .WithDisplayName("Route Case")
                    .ModelProperty("routecase", typeof(bool)));

                this.ResolveBy = group.Add(new VocabularyKey("ResolveBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date by when the case must be resolved.")
                    .WithDisplayName("Resolve By")
                    .ModelProperty("resolveby", typeof(DateTime)));

                this.ResponseBy = group.Add(new VocabularyKey("ResponseBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("First Response By")
                    .ModelProperty("responseby", typeof(DateTime)));

                this.CustomerContacted = group.Add(new VocabularyKey("CustomerContacted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Tells whether customer service representative has contacted the customer or not.")
                    .WithDisplayName("Customer Contacted")
                    .ModelProperty("customercontacted", typeof(bool)));

                this.IsEscalated = group.Add(new VocabularyKey("IsEscalated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if the case has been escalated.")
                    .WithDisplayName("Is Escalated")
                    .ModelProperty("isescalated", typeof(bool)));

                this.EscalatedOn = group.Add(new VocabularyKey("EscalatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the date and time when the case was escalated.")
                    .WithDisplayName("Escalated On")
                    .ModelProperty("escalatedon", typeof(DateTime)));

                this.PrimaryContactId = group.Add(new VocabularyKey("PrimaryContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a primary contact for this case.")
                    .WithDisplayName("Primary Contact")
                    .ModelProperty("primarycontactid", typeof(string)));

                this.PrimaryContactIdName = group.Add(new VocabularyKey("PrimaryContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryContactIdName")
                    .ModelProperty("primarycontactidname", typeof(string)));

                this.PrimaryContactIdYomiName = group.Add(new VocabularyKey("PrimaryContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryContactIdYomiName")
                    .ModelProperty("primarycontactidyominame", typeof(string)));

                this.IsEscalatedName = group.Add(new VocabularyKey("IsEscalatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsEscalatedName")
                    .ModelProperty("isescalatedname", typeof(string)));

                this.FirstResponseSent = group.Add(new VocabularyKey("FirstResponseSent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if the first response has been sent.")
                    .WithDisplayName("First Response Sent")
                    .ModelProperty("firstresponsesent", typeof(bool)));

                this.MergedName = group.Add(new VocabularyKey("MergedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MergedName")
                    .ModelProperty("mergedname", typeof(string)));

                this.FirstResponseSLAStatus = group.Add(new VocabularyKey("FirstResponseSLAStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the status of the initial response time for the case according to the terms of the SLA.")
                    .WithDisplayName("First Response SLA Status")
                    .ModelProperty("firstresponseslastatus", typeof(string)));

                this.ResolveBySLAStatus = group.Add(new VocabularyKey("ResolveBySLAStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the status of the resolution time for the case according to the terms of the SLA.")
                    .WithDisplayName("Resolve By SLA Status")
                    .ModelProperty("resolvebyslastatus", typeof(string)));

                this.FirstResponseSLAStatusName = group.Add(new VocabularyKey("FirstResponseSLAStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FirstResponseSLAStatusName")
                    .ModelProperty("firstresponseslastatusname", typeof(string)));

                this.ResolveBySLAStatusName = group.Add(new VocabularyKey("ResolveBySLAStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ResolveBySLAStatusName")
                    .ModelProperty("resolvebyslastatusname", typeof(string)));

                this.FirstResponseSentName = group.Add(new VocabularyKey("FirstResponseSentName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FirstResponseSentName")
                    .ModelProperty("firstresponsesentname", typeof(string)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the duration in minutes for which the case was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.ResolveByKPIId = group.Add(new VocabularyKey("ResolveByKPIId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"slakpiinstance_incident_resolvebykpi")
                    .WithDisplayName("Resolve By KPI")
                    .ModelProperty("resolvebykpiid", typeof(string)));

                this.ResolveByKPIIdName = group.Add(new VocabularyKey("ResolveByKPIIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ResolveByKPIIdName")
                    .ModelProperty("resolvebykpiidname", typeof(string)));

                this.FirstResponseByKPIId = group.Add(new VocabularyKey("FirstResponseByKPIId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"slakpiinstance_incident_firstresponsebykpi")
                    .WithDisplayName("First Response By KPI")
                    .ModelProperty("firstresponsebykpiid", typeof(string)));

                this.FirstResponseByKPIIdName = group.Add(new VocabularyKey("FirstResponseByKPIIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("FirstResponseByKPIIdName")
                    .ModelProperty("firstresponsebykpiidname", typeof(string)));

                this.EmailAddress = group.Add(new VocabularyKey("EmailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The primary email address for the entity.")
                    .WithDisplayName("Email Address")
                    .ModelProperty("emailaddress", typeof(string)));

                this.routecaseName = group.Add(new VocabularyKey("routecaseName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("routecaseName")
                    .ModelProperty("routecasename", typeof(string)));

                this.customercontactedName = group.Add(new VocabularyKey("customercontactedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("customercontactedName")
                    .ModelProperty("customercontactedname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey IncidentId { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey ContractDetailId { get; private set; }

        public VocabularyKey SubjectId { get; private set; }

        public VocabularyKey ContractId { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey ActualServiceUnits { get; private set; }

        public VocabularyKey CaseOriginCode { get; private set; }

        public VocabularyKey BilledServiceUnits { get; private set; }

        public VocabularyKey CaseTypeCode { get; private set; }

        public VocabularyKey ProductSerialNumber { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey ProductId { get; private set; }

        public VocabularyKey ContractServiceLevelCode { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey IsDecrementing { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey TicketNumber { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey CustomerSatisfactionCode { get; private set; }

        public VocabularyKey IncidentStageCode { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey FollowupBy { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey SeverityCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey ResponsibleContactId { get; private set; }

        public VocabularyKey SubjectIdName { get; private set; }

        public VocabularyKey AccountIdName { get; private set; }

        public VocabularyKey ContactIdName { get; private set; }

        public VocabularyKey ResponsibleContactIdName { get; private set; }

        public VocabularyKey ContractIdName { get; private set; }

        public VocabularyKey ContractDetailIdName { get; private set; }

        public VocabularyKey ProductIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CustomerId { get; private set; }

        public VocabularyKey CustomerIdName { get; private set; }

        public VocabularyKey CustomerIdType { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey IsDecrementingName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey CaseOriginCodeName { get; private set; }

        public VocabularyKey IncidentStageCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey SeverityCodeName { get; private set; }

        public VocabularyKey CaseTypeCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey CustomerSatisfactionCodeName { get; private set; }

        public VocabularyKey ContractServiceLevelCodeName { get; private set; }

        public VocabularyKey KbArticleId { get; private set; }

        public VocabularyKey KbArticleIdName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey ContactIdYomiName { get; private set; }

        public VocabularyKey AccountIdYomiName { get; private set; }

        public VocabularyKey ResponsibleContactIdYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CustomerIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey ServiceStage { get; private set; }

        public VocabularyKey ServiceStageName { get; private set; }

        public VocabularyKey ExistingCase { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey CheckEmail { get; private set; }

        public VocabularyKey ActivitiesComplete { get; private set; }

        public VocabularyKey ActivitiesCompleteName { get; private set; }

        public VocabularyKey CheckEmailName { get; private set; }

        public VocabularyKey FollowUpTaskCreated { get; private set; }

        public VocabularyKey FollowUpTaskCreatedName { get; private set; }

        public VocabularyKey NumberOfChildIncidents { get; private set; }

        public VocabularyKey SocialProfileId { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey MessageTypeCode { get; private set; }

        public VocabularyKey BlockedProfile { get; private set; }

        public VocabularyKey DecrementEntitlementTermName { get; private set; }

        public VocabularyKey EntitlementId { get; private set; }

        public VocabularyKey EntitlementIdName { get; private set; }

        public VocabularyKey MasterId { get; private set; }

        public VocabularyKey MasterIdName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey ParentCaseId { get; private set; }

        public VocabularyKey DecrementEntitlementTerm { get; private set; }

        public VocabularyKey ParentCaseIdName { get; private set; }

        public VocabularyKey CreatedByExternalParty { get; private set; }

        public VocabularyKey CreatedByExternalPartyName { get; private set; }

        public VocabularyKey CreatedByExternalPartyYomiName { get; private set; }

        public VocabularyKey ModifiedByExternalParty { get; private set; }

        public VocabularyKey ModifiedByExternalPartyName { get; private set; }

        public VocabularyKey ModifiedByExternalPartyYomiName { get; private set; }

        public VocabularyKey SentimentValue { get; private set; }

        public VocabularyKey SocialProfileIdName { get; private set; }

        public VocabularyKey InfluenceScore { get; private set; }

        public VocabularyKey MessageTypeCodeName { get; private set; }

        public VocabularyKey BlockedProfileName { get; private set; }

        public VocabularyKey Merged { get; private set; }

        public VocabularyKey RouteCase { get; private set; }

        public VocabularyKey ResolveBy { get; private set; }

        public VocabularyKey ResponseBy { get; private set; }

        public VocabularyKey CustomerContacted { get; private set; }

        public VocabularyKey IsEscalated { get; private set; }

        public VocabularyKey EscalatedOn { get; private set; }

        public VocabularyKey PrimaryContactId { get; private set; }

        public VocabularyKey PrimaryContactIdName { get; private set; }

        public VocabularyKey PrimaryContactIdYomiName { get; private set; }

        public VocabularyKey IsEscalatedName { get; private set; }

        public VocabularyKey FirstResponseSent { get; private set; }

        public VocabularyKey MergedName { get; private set; }

        public VocabularyKey FirstResponseSLAStatus { get; private set; }

        public VocabularyKey ResolveBySLAStatus { get; private set; }

        public VocabularyKey FirstResponseSLAStatusName { get; private set; }

        public VocabularyKey ResolveBySLAStatusName { get; private set; }

        public VocabularyKey FirstResponseSentName { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey ResolveByKPIId { get; private set; }

        public VocabularyKey ResolveByKPIIdName { get; private set; }

        public VocabularyKey FirstResponseByKPIId { get; private set; }

        public VocabularyKey FirstResponseByKPIIdName { get; private set; }

        public VocabularyKey EmailAddress { get; private set; }

        public VocabularyKey routecaseName { get; private set; }

        public VocabularyKey customercontactedName { get; private set; }


    }
}

