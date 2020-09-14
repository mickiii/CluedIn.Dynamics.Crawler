using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Dynamics365 Opportunity";
            KeyPrefix = "dynamics365.opportunity";
            KeySeparator = ".";
            Grouping = EntityType.Sales.Opportunity;

            this.AddGroup("Opportunity", group =>
            {
                this.OpportunityId = group.Add(new VocabularyKey("OpportunityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the opportunity.")
                    .WithDisplayName("Opportunity")
                    .ModelProperty("opportunityid", typeof(Guid)));

                this.PriceLevelId = group.Add(new VocabularyKey("PriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.")
                    .WithDisplayName("Price List")
                    .ModelProperty("pricelevelid", typeof(string)));

                this.OpportunityRatingCode = group.Add(new VocabularyKey("OpportunityRatingCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.")
                    .WithDisplayName("Rating")
                    .ModelProperty("opportunityratingcode", typeof(string)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact associated with the opportunity.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(string)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the opportunity is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(300))
                    .WithDescription(@"Type a subject or descriptive name, such as the expected order or company name, for the opportunity.")
                    .WithDisplayName("Topic")
                    .ModelProperty("name", typeof(string)));

                this.StepId = group.Add(new VocabularyKey("StepId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the workflow step.")
                    .WithDisplayName("Step")
                    .ModelProperty("stepid", typeof(Guid)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.EstimatedValue = group.Add(new VocabularyKey("EstimatedValue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.")
                    .WithDisplayName("Est. Revenue")
                    .ModelProperty("estimatedvalue", typeof(string)));

                this.StepName = group.Add(new VocabularyKey("StepName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Shows the current phase in the sales pipeline for the opportunity. This is updated by a workflow.")
                    .WithDisplayName("Pipeline Phase")
                    .ModelProperty("stepname", typeof(string)));

                this.SalesStageCode = group.Add(new VocabularyKey("SalesStageCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.")
                    .WithDisplayName("Process Code")
                    .ModelProperty("salesstagecode", typeof(string)));

                this.ParticipatesInWorkflow = group.Add(new VocabularyKey("ParticipatesInWorkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the opportunity participates in workflow rules.")
                    .WithDisplayName("Participates in Workflow")
                    .ModelProperty("participatesinworkflow", typeof(bool)));

                this.PricingErrorCode = group.Add(new VocabularyKey("PricingErrorCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Pricing error for the opportunity.")
                    .WithDisplayName("Pricing Error ")
                    .ModelProperty("pricingerrorcode", typeof(string)));

                this.EstimatedCloseDate = group.Add(new VocabularyKey("EstimatedCloseDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected closing date of the opportunity to help make accurate revenue forecasts.")
                    .WithDisplayName("Estimated Close Date")
                    .ModelProperty("estimatedclosedate", typeof(DateTime)));

                this.CloseProbability = group.Add(new VocabularyKey("CloseProbability", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.")
                    .WithDisplayName("Probability")
                    .ModelProperty("closeprobability", typeof(long)));

                this.ActualValue = group.Add(new VocabularyKey("ActualValue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won.")
                    .WithDisplayName("Actual Revenue")
                    .ModelProperty("actualvalue", typeof(string)));

                this.ActualCloseDate = group.Add(new VocabularyKey("ActualCloseDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the opportunity was closed or canceled.")
                    .WithDisplayName("Actual Close Date")
                    .ModelProperty("actualclosedate", typeof(DateTime)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"opportunity_owning_user")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_opportunities")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OriginatingLeadId = group.Add(new VocabularyKey("OriginatingLeadId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.")
                    .WithDisplayName("Originating Lead")
                    .ModelProperty("originatingleadid", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.IsPrivate = group.Add(new VocabularyKey("IsPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the opportunity is private or visible to the entire organization.")
                    .WithDisplayName("Is Private")
                    .ModelProperty("isprivate", typeof(bool)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the opportunity.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the opportunity's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.IsRevenueSystemCalculated = group.Add(new VocabularyKey("IsRevenueSystemCalculated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.")
                    .WithDisplayName("Revenue")
                    .ModelProperty("isrevenuesystemcalculated", typeof(bool)));

                this.OriginatingLeadIdName = group.Add(new VocabularyKey("OriginatingLeadIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingLeadIdName")
                    .ModelProperty("originatingleadidname", typeof(string)));

                this.ContactIdName = group.Add(new VocabularyKey("ContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdName")
                    .ModelProperty("contactidname", typeof(string)));

                this.AccountIdName = group.Add(new VocabularyKey("AccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdName")
                    .ModelProperty("accountidname", typeof(string)));

                this.PriceLevelIdName = group.Add(new VocabularyKey("PriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PriceLevelIdName")
                    .ModelProperty("pricelevelidname", typeof(string)));

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
                    .WithDescription(@"Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.")
                    .WithDisplayName("Potential Customer")
                    .ModelProperty("customerid", typeof(string)));

                this.CustomerIdName = group.Add(new VocabularyKey("CustomerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdName")
                    .ModelProperty("customeridname", typeof(string)));

                this.CustomerIdType = group.Add(new VocabularyKey("CustomerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Potential Customer Type")
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

                this.IsPrivateName = group.Add(new VocabularyKey("IsPrivateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPrivateName")
                    .ModelProperty("isprivatename", typeof(string)));

                this.ParticipatesInWorkflowName = group.Add(new VocabularyKey("ParticipatesInWorkflowName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ParticipatesInWorkflowName")
                    .ModelProperty("participatesinworkflowname", typeof(string)));

                this.IsRevenueSystemCalculatedName = group.Add(new VocabularyKey("IsRevenueSystemCalculatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRevenueSystemCalculatedName")
                    .ModelProperty("isrevenuesystemcalculatedname", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.SalesStageCodeName = group.Add(new VocabularyKey("SalesStageCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SalesStageCodeName")
                    .ModelProperty("salesstagecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.OpportunityRatingCodeName = group.Add(new VocabularyKey("OpportunityRatingCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OpportunityRatingCodeName")
                    .ModelProperty("opportunityratingcodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.PricingErrorCodeName = group.Add(new VocabularyKey("PricingErrorCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PricingErrorCodeName")
                    .ModelProperty("pricingerrorcodename", typeof(string)));

                this.CampaignId = group.Add(new VocabularyKey("CampaignId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.")
                    .WithDisplayName("Source Campaign")
                    .ModelProperty("campaignid", typeof(string)));

                this.CampaignIdName = group.Add(new VocabularyKey("CampaignIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CampaignIdName")
                    .ModelProperty("campaignidname", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

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

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ActualValue_Base = group.Add(new VocabularyKey("ActualValue_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Actual Revenue (Base)")
                    .ModelProperty("actualvalue_base", typeof(string)));

                this.EstimatedValue_Base = group.Add(new VocabularyKey("EstimatedValue_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Est. Revenue (Base)")
                    .ModelProperty("estimatedvalue_base", typeof(string)));

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

                this.OriginatingLeadIdYomiName = group.Add(new VocabularyKey("OriginatingLeadIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingLeadIdYomiName")
                    .ModelProperty("originatingleadidyominame", typeof(string)));

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

                this.TotalTax = group.Add(new VocabularyKey("TotalTax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.")
                    .WithDisplayName("Total Tax")
                    .ModelProperty("totaltax", typeof(string)));

                this.DiscountPercentage = group.Add(new VocabularyKey("DiscountPercentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.")
                    .WithDisplayName("Opportunity Discount (%)")
                    .ModelProperty("discountpercentage", typeof(decimal)));

                this.TotalAmount = group.Add(new VocabularyKey("TotalAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.")
                    .WithDisplayName("Revenue Total")
                    .ModelProperty("totalamount", typeof(string)));

                this.DiscountAmount = group.Add(new VocabularyKey("DiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the discount amount for the opportunity if the customer is eligible for special savings.")
                    .WithDisplayName("Opportunity Discount Amount")
                    .ModelProperty("discountamount", typeof(string)));

                this.TotalAmountLessFreight = group.Add(new VocabularyKey("TotalAmountLessFreight", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.")
                    .WithDisplayName("Total Pre-Freight Amount")
                    .ModelProperty("totalamountlessfreight", typeof(string)));

                this.FreightAmount = group.Add(new VocabularyKey("FreightAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.")
                    .WithDisplayName("Freight Amount")
                    .ModelProperty("freightamount", typeof(string)));

                this.TotalLineItemDiscountAmount = group.Add(new VocabularyKey("TotalLineItemDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.")
                    .WithDisplayName("Total Line Item Discount Amount")
                    .ModelProperty("totallineitemdiscountamount", typeof(string)));

                this.TotalLineItemAmount = group.Add(new VocabularyKey("TotalLineItemAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.")
                    .WithDisplayName("Total Detail Amount")
                    .ModelProperty("totallineitemamount", typeof(string)));

                this.TotalDiscountAmount = group.Add(new VocabularyKey("TotalDiscountAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the total discount amount, based on the discount price and rate entered on the opportunity.")
                    .WithDisplayName("Total Discount Amount")
                    .ModelProperty("totaldiscountamount", typeof(string)));

                this.TotalLineItemAmount_Base = group.Add(new VocabularyKey("TotalLineItemAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Detail Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Detail Amount (Base)")
                    .ModelProperty("totallineitemamount_base", typeof(string)));

                this.TotalDiscountAmount_Base = group.Add(new VocabularyKey("TotalDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Discount Amount (Base)")
                    .ModelProperty("totaldiscountamount_base", typeof(string)));

                this.TotalTax_Base = group.Add(new VocabularyKey("TotalTax_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Tax (Base)")
                    .ModelProperty("totaltax_base", typeof(string)));

                this.DiscountAmount_Base = group.Add(new VocabularyKey("DiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Opportunity Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Opportunity Discount Amount (Base)")
                    .ModelProperty("discountamount_base", typeof(string)));

                this.TotalLineItemDiscountAmount_Base = group.Add(new VocabularyKey("TotalLineItemDiscountAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Line Item Discount Amount field to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Line Item Discount Amount (Base)")
                    .ModelProperty("totallineitemdiscountamount_base", typeof(string)));

                this.TotalAmount_Base = group.Add(new VocabularyKey("TotalAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Revenue Total (Base)")
                    .ModelProperty("totalamount_base", typeof(string)));

                this.TotalAmountLessFreight_Base = group.Add(new VocabularyKey("TotalAmountLessFreight_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Total Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Total Pre-Freight Amount (Base)")
                    .ModelProperty("totalamountlessfreight_base", typeof(string)));

                this.FreightAmount_Base = group.Add(new VocabularyKey("FreightAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Freight Amount (Base)")
                    .ModelProperty("freightamount_base", typeof(string)));

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

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record on behalf of another user.")
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
                    .WithDescription(@"team_opportunities")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.BudgetStatus = group.Add(new VocabularyKey("BudgetStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.")
                    .WithDisplayName("Budget")
                    .ModelProperty("budgetstatus", typeof(string)));

                this.DecisionMaker = group.Add(new VocabularyKey("DecisionMaker", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether your notes include information about who makes the purchase decisions at the lead's company.")
                    .WithDisplayName("Decision Maker?")
                    .ModelProperty("decisionmaker", typeof(bool)));

                this.Need = group.Add(new VocabularyKey("Need", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose how high the level of need is for the lead's company.")
                    .WithDisplayName("Need")
                    .ModelProperty("need", typeof(string)));

                this.TimeLine = group.Add(new VocabularyKey("TimeLine", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select when the opportunity is likely to be closed.")
                    .WithDisplayName("Timeline")
                    .ModelProperty("timeline", typeof(string)));

                this.TimelineName = group.Add(new VocabularyKey("TimelineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TimelineName")
                    .ModelProperty("timelinename", typeof(string)));

                this.NeedName = group.Add(new VocabularyKey("NeedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("NeedName")
                    .ModelProperty("needname", typeof(string)));

                this.DecisionMakerName = group.Add(new VocabularyKey("DecisionMakerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DecisionMakerName")
                    .ModelProperty("decisionmakername", typeof(string)));

                this.BudgetTypeName = group.Add(new VocabularyKey("BudgetTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BudgetTypeName")
                    .ModelProperty("budgettypename", typeof(string)));

                this.BudgetAmount = group.Add(new VocabularyKey("BudgetAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.")
                    .WithDisplayName("Budget Amount")
                    .ModelProperty("budgetamount", typeof(string)));

                this.BudgetAmount_Base = group.Add(new VocabularyKey("BudgetAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the budget amount converted to the system's base currency.")
                    .WithDisplayName("Budget Amount (Base)")
                    .ModelProperty("budgetamount_base", typeof(string)));

                this.ParentAccountId = group.Add(new VocabularyKey("ParentAccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.")
                    .WithDisplayName("Account")
                    .ModelProperty("parentaccountid", typeof(string)));

                this.ParentAccountIdName = group.Add(new VocabularyKey("ParentAccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentAccountIdName")
                    .ModelProperty("parentaccountidname", typeof(string)));

                this.ParentAccountIdYomiName = group.Add(new VocabularyKey("ParentAccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentAccountIdYomiName")
                    .ModelProperty("parentaccountidyominame", typeof(string)));

                this.ParentContactId = group.Add(new VocabularyKey("ParentContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.")
                    .WithDisplayName("Contact")
                    .ModelProperty("parentcontactid", typeof(string)));

                this.ParentContactIdName = group.Add(new VocabularyKey("ParentContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentContactIdName")
                    .ModelProperty("parentcontactidname", typeof(string)));

                this.ParentContactIdYomiName = group.Add(new VocabularyKey("ParentContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentContactIdYomiName")
                    .ModelProperty("parentcontactidyominame", typeof(string)));

                this.EvaluateFit = group.Add(new VocabularyKey("EvaluateFit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the fit between the lead's requirements and your offerings was evaluated.")
                    .WithDisplayName("Evaluate Fit")
                    .ModelProperty("evaluatefit", typeof(bool)));

                this.EvaluateFitName = group.Add(new VocabularyKey("EvaluateFitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EvaluateFitName")
                    .ModelProperty("evaluatefitname", typeof(string)));

                this.InitialCommunication = group.Add(new VocabularyKey("InitialCommunication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether someone from the sales team contacted this lead earlier.")
                    .WithDisplayName("Initial Communication")
                    .ModelProperty("initialcommunication", typeof(string)));

                this.InitialCommunicationName = group.Add(new VocabularyKey("InitialCommunicationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InitialCommunicationName")
                    .ModelProperty("initialcommunicationname", typeof(string)));

                this.ConfirmInterest = group.Add(new VocabularyKey("ConfirmInterest", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.")
                    .WithDisplayName("Confirm Interest")
                    .ModelProperty("confirminterest", typeof(bool)));

                this.ConfirmInterestName = group.Add(new VocabularyKey("ConfirmInterestName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ConfirmInterestName")
                    .ModelProperty("confirminterestname", typeof(string)));

                this.ScheduleFollowup_Prospect = group.Add(new VocabularyKey("ScheduleFollowup_Prospect", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time of the prospecting follow-up meeting with the lead.")
                    .WithDisplayName("Scheduled Follow up (Prospect)")
                    .ModelProperty("schedulefollowup_prospect", typeof(DateTime)));

                this.ScheduleFollowup_Qualify = group.Add(new VocabularyKey("ScheduleFollowup_Qualify", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time of the qualifying follow-up meeting with the lead.")
                    .WithDisplayName("Scheduled Follow up (Qualify)")
                    .ModelProperty("schedulefollowup_qualify", typeof(DateTime)));

                this.ScheduleProposalMeeting = group.Add(new VocabularyKey("ScheduleProposalMeeting", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time of the proposal meeting for the opportunity.")
                    .WithDisplayName("Schedule Proposal Meeting")
                    .ModelProperty("scheduleproposalmeeting", typeof(DateTime)));

                this.FinalDecisionDate = group.Add(new VocabularyKey("FinalDecisionDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time when the final decision of the opportunity was made.")
                    .WithDisplayName("Final Decision Date")
                    .ModelProperty("finaldecisiondate", typeof(DateTime)));

                this.DevelopProposal = group.Add(new VocabularyKey("DevelopProposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether a proposal has been developed for the opportunity.")
                    .WithDisplayName("Develop Proposal")
                    .ModelProperty("developproposal", typeof(bool)));

                this.DevelopProposalName = group.Add(new VocabularyKey("DevelopProposalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DevelopProposalName")
                    .ModelProperty("developproposalname", typeof(string)));

                this.CompleteInternalReview = group.Add(new VocabularyKey("CompleteInternalReview", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether an internal review has been completed for this opportunity.")
                    .WithDisplayName("Complete Internal Review")
                    .ModelProperty("completeinternalreview", typeof(bool)));

                this.CompleteInternalReviewName = group.Add(new VocabularyKey("CompleteInternalReviewName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CompleteInternalReviewName")
                    .ModelProperty("completeinternalreviewname", typeof(string)));

                this.CaptureProposalFeedback = group.Add(new VocabularyKey("CaptureProposalFeedback", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether the proposal feedback has been captured for the opportunity.")
                    .WithDisplayName("Proposal Feedback Captured")
                    .ModelProperty("captureproposalfeedback", typeof(bool)));

                this.CaptureProposalFeedbackName = group.Add(new VocabularyKey("CaptureProposalFeedbackName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CaptureProposalFeedbackName")
                    .ModelProperty("captureproposalfeedbackname", typeof(string)));

                this.ResolveFeedback = group.Add(new VocabularyKey("ResolveFeedback", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether the proposal feedback has been captured and resolved for the opportunity.")
                    .WithDisplayName("Feedback Resolved")
                    .ModelProperty("resolvefeedback", typeof(bool)));

                this.ResolveFeedbackName = group.Add(new VocabularyKey("ResolveFeedbackName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ResolveFeedbackName")
                    .ModelProperty("resolvefeedbackname", typeof(string)));

                this.PresentProposal = group.Add(new VocabularyKey("PresentProposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether a proposal for the opportunity has been presented to the account.")
                    .WithDisplayName("Presented Proposal")
                    .ModelProperty("presentproposal", typeof(bool)));

                this.PresentProposalName = group.Add(new VocabularyKey("PresentProposalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PresentProposalName")
                    .ModelProperty("presentproposalname", typeof(string)));

                this.SendThankYouNote = group.Add(new VocabularyKey("SendThankYouNote", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether a thank you note has been sent to the account for considering the proposal.")
                    .WithDisplayName("Send Thank You Note")
                    .ModelProperty("sendthankyounote", typeof(bool)));

                this.SendThankYouNoteName = group.Add(new VocabularyKey("SendThankYouNoteName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SendThankYouNoteName")
                    .ModelProperty("sendthankyounotename", typeof(string)));

                this.SalesStage = group.Add(new VocabularyKey("SalesStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.")
                    .WithDisplayName("Sales Stage")
                    .ModelProperty("salesstage", typeof(string)));

                this.SalesStageName = group.Add(new VocabularyKey("SalesStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SalesStageName")
                    .ModelProperty("salesstagename", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.CompleteFinalProposal = group.Add(new VocabularyKey("CompleteFinalProposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether a final proposal has been completed for the opportunity.")
                    .WithDisplayName("Final Proposal Ready")
                    .ModelProperty("completefinalproposal", typeof(bool)));

                this.CompleteFinalProposalName = group.Add(new VocabularyKey("CompleteFinalProposalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CompleteFinalProposalName")
                    .ModelProperty("completefinalproposalname", typeof(string)));

                this.FileDebrief = group.Add(new VocabularyKey("FileDebrief", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.")
                    .WithDisplayName("File Debrief")
                    .ModelProperty("filedebrief", typeof(bool)));

                this.FileDeBriefName = group.Add(new VocabularyKey("FileDeBriefName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FileDeBriefName")
                    .ModelProperty("filedebriefname", typeof(string)));

                this.PursuitDecision = group.Add(new VocabularyKey("PursuitDecision", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the decision about pursuing the opportunity has been made.")
                    .WithDisplayName("Decide Go/No-Go")
                    .ModelProperty("pursuitdecision", typeof(bool)));

                this.PursuitDecisionName = group.Add(new VocabularyKey("PursuitDecisionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PursuitDecisionName")
                    .ModelProperty("pursuitdecisionname", typeof(string)));

                this.CustomerPainPoints = group.Add(new VocabularyKey("CustomerPainPoints", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.")
                    .WithDisplayName("Customer Pain Points")
                    .ModelProperty("customerpainpoints", typeof(string)));

                this.CustomerNeed = group.Add(new VocabularyKey("CustomerNeed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.")
                    .WithDisplayName("Customer Need")
                    .ModelProperty("customerneed", typeof(string)));

                this.ProposedSolution = group.Add(new VocabularyKey("ProposedSolution", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type notes about the proposed solution for the opportunity.")
                    .WithDisplayName("Proposed Solution")
                    .ModelProperty("proposedsolution", typeof(string)));

                this.QualificationComments = group.Add(new VocabularyKey("QualificationComments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type comments about the qualification or scoring of the lead.")
                    .WithDisplayName("Qualification Comments")
                    .ModelProperty("qualificationcomments", typeof(string)));

                this.QuoteComments = group.Add(new VocabularyKey("QuoteComments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type comments about the quotes associated with the opportunity.")
                    .WithDisplayName("Quote Comments")
                    .ModelProperty("quotecomments", typeof(string)));

                this.PurchaseProcess = group.Add(new VocabularyKey("PurchaseProcess", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether an individual or a committee will be involved in the purchase process for the lead.")
                    .WithDisplayName("Purchase Process")
                    .ModelProperty("purchaseprocess", typeof(string)));

                this.PurchaseProcessName = group.Add(new VocabularyKey("PurchaseProcessName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PurchaseProcessName")
                    .ModelProperty("purchaseprocessname", typeof(string)));

                this.PurchaseTimeframe = group.Add(new VocabularyKey("PurchaseTimeframe", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose how long the lead will likely take to make the purchase.")
                    .WithDisplayName("Purchase Timeframe")
                    .ModelProperty("purchasetimeframe", typeof(string)));

                this.PurchaseTimeframeName = group.Add(new VocabularyKey("PurchaseTimeframeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PurchaseTimeframeName")
                    .ModelProperty("purchasetimeframename", typeof(string)));

                this.IdentifyCustomerContacts = group.Add(new VocabularyKey("IdentifyCustomerContacts", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the customer contacts for this opportunity have been identified.")
                    .WithDisplayName("Identify Customer Contacts")
                    .ModelProperty("identifycustomercontacts", typeof(bool)));

                this.IdentifyCustomerContactsName = group.Add(new VocabularyKey("IdentifyCustomerContactsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IdentifyCustomerContactsName")
                    .ModelProperty("identifycustomercontactsname", typeof(string)));

                this.IdentifyCompetitors = group.Add(new VocabularyKey("IdentifyCompetitors", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether information about competitors is included.")
                    .WithDisplayName("Identify Competitors")
                    .ModelProperty("identifycompetitors", typeof(bool)));

                this.IdentifyCompetitorsName = group.Add(new VocabularyKey("IdentifyCompetitorsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IdentifyCompetitorsName")
                    .ModelProperty("identifycompetitorsname", typeof(string)));

                this.IdentifyPursuitTeam = group.Add(new VocabularyKey("IdentifyPursuitTeam", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether you have recorded who will pursue the opportunity.")
                    .WithDisplayName("Identify Sales Team")
                    .ModelProperty("identifypursuitteam", typeof(bool)));

                this.IdentifyPursuitTeamName = group.Add(new VocabularyKey("IdentifyPursuitTeamName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IdentifyPursuitTeamName")
                    .ModelProperty("identifypursuitteamname", typeof(string)));

                this.CurrentSituation = group.Add(new VocabularyKey("CurrentSituation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type notes about the company or organization associated with the opportunity.")
                    .WithDisplayName("Current Situation")
                    .ModelProperty("currentsituation", typeof(string)));

                this.PresentFinalProposal = group.Add(new VocabularyKey("PresentFinalProposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the final proposal has been presented to the account.")
                    .WithDisplayName("Present Final Proposal")
                    .ModelProperty("presentfinalproposal", typeof(bool)));

                this.PresentFinalProposalName = group.Add(new VocabularyKey("PresentFinalProposalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PresentFinalProposalName")
                    .ModelProperty("presentfinalproposalname", typeof(string)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the duration in minutes for which the opportunity was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_opportunity")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"manualsla_opportunity")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"sla_opportunity")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey("TimeSpentByMeOnEmailAndMeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1250))
                    .WithDescription(@"Total time spent for emails (read and write) and meetings by me in relation to the opportunity record.")
                    .WithDisplayName("Time Spent by me")
                    .ModelProperty("timespentbymeonemailandmeetings", typeof(string)));

                this.EmailAddress = group.Add(new VocabularyKey("EmailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The primary email address for the entity.")
                    .WithDisplayName("Email Address")
                    .ModelProperty("emailaddress", typeof(string)));

                this.TeamsFollowed = group.Add(new VocabularyKey("TeamsFollowed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of users or conversations followed the record")
                    .WithDisplayName("TeamsFollowed")
                    .ModelProperty("teamsfollowed", typeof(long)));

                this.SkipPriceCalculation = group.Add(new VocabularyKey("SkipPriceCalculation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Skip Price Calculation (For Internal Use)")
                    .WithDisplayName("Skip Price Calculation")
                    .ModelProperty("skippricecalculation", typeof(string)));

                this.skippricecalculationName = group.Add(new VocabularyKey("skippricecalculationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("skippricecalculationName")
                    .ModelProperty("skippricecalculationname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OpportunityId { get; private set; }

        public VocabularyKey PriceLevelId { get; private set; }

        public VocabularyKey OpportunityRatingCode { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey StepId { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey EstimatedValue { get; private set; }

        public VocabularyKey StepName { get; private set; }

        public VocabularyKey SalesStageCode { get; private set; }

        public VocabularyKey ParticipatesInWorkflow { get; private set; }

        public VocabularyKey PricingErrorCode { get; private set; }

        public VocabularyKey EstimatedCloseDate { get; private set; }

        public VocabularyKey CloseProbability { get; private set; }

        public VocabularyKey ActualValue { get; private set; }

        public VocabularyKey ActualCloseDate { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OriginatingLeadId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey IsPrivate { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey IsRevenueSystemCalculated { get; private set; }

        public VocabularyKey OriginatingLeadIdName { get; private set; }

        public VocabularyKey ContactIdName { get; private set; }

        public VocabularyKey AccountIdName { get; private set; }

        public VocabularyKey PriceLevelIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CustomerId { get; private set; }

        public VocabularyKey CustomerIdName { get; private set; }

        public VocabularyKey CustomerIdType { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey IsPrivateName { get; private set; }

        public VocabularyKey ParticipatesInWorkflowName { get; private set; }

        public VocabularyKey IsRevenueSystemCalculatedName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey SalesStageCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey OpportunityRatingCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey PricingErrorCodeName { get; private set; }

        public VocabularyKey CampaignId { get; private set; }

        public VocabularyKey CampaignIdName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ActualValue_Base { get; private set; }

        public VocabularyKey EstimatedValue_Base { get; private set; }

        public VocabularyKey ContactIdYomiName { get; private set; }

        public VocabularyKey AccountIdYomiName { get; private set; }

        public VocabularyKey OriginatingLeadIdYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CustomerIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey TotalTax { get; private set; }

        public VocabularyKey DiscountPercentage { get; private set; }

        public VocabularyKey TotalAmount { get; private set; }

        public VocabularyKey DiscountAmount { get; private set; }

        public VocabularyKey TotalAmountLessFreight { get; private set; }

        public VocabularyKey FreightAmount { get; private set; }

        public VocabularyKey TotalLineItemDiscountAmount { get; private set; }

        public VocabularyKey TotalLineItemAmount { get; private set; }

        public VocabularyKey TotalDiscountAmount { get; private set; }

        public VocabularyKey TotalLineItemAmount_Base { get; private set; }

        public VocabularyKey TotalDiscountAmount_Base { get; private set; }

        public VocabularyKey TotalTax_Base { get; private set; }

        public VocabularyKey DiscountAmount_Base { get; private set; }

        public VocabularyKey TotalLineItemDiscountAmount_Base { get; private set; }

        public VocabularyKey TotalAmount_Base { get; private set; }

        public VocabularyKey TotalAmountLessFreight_Base { get; private set; }

        public VocabularyKey FreightAmount_Base { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey BudgetStatus { get; private set; }

        public VocabularyKey DecisionMaker { get; private set; }

        public VocabularyKey Need { get; private set; }

        public VocabularyKey TimeLine { get; private set; }

        public VocabularyKey TimelineName { get; private set; }

        public VocabularyKey NeedName { get; private set; }

        public VocabularyKey DecisionMakerName { get; private set; }

        public VocabularyKey BudgetTypeName { get; private set; }

        public VocabularyKey BudgetAmount { get; private set; }

        public VocabularyKey BudgetAmount_Base { get; private set; }

        public VocabularyKey ParentAccountId { get; private set; }

        public VocabularyKey ParentAccountIdName { get; private set; }

        public VocabularyKey ParentAccountIdYomiName { get; private set; }

        public VocabularyKey ParentContactId { get; private set; }

        public VocabularyKey ParentContactIdName { get; private set; }

        public VocabularyKey ParentContactIdYomiName { get; private set; }

        public VocabularyKey EvaluateFit { get; private set; }

        public VocabularyKey EvaluateFitName { get; private set; }

        public VocabularyKey InitialCommunication { get; private set; }

        public VocabularyKey InitialCommunicationName { get; private set; }

        public VocabularyKey ConfirmInterest { get; private set; }

        public VocabularyKey ConfirmInterestName { get; private set; }

        public VocabularyKey ScheduleFollowup_Prospect { get; private set; }

        public VocabularyKey ScheduleFollowup_Qualify { get; private set; }

        public VocabularyKey ScheduleProposalMeeting { get; private set; }

        public VocabularyKey FinalDecisionDate { get; private set; }

        public VocabularyKey DevelopProposal { get; private set; }

        public VocabularyKey DevelopProposalName { get; private set; }

        public VocabularyKey CompleteInternalReview { get; private set; }

        public VocabularyKey CompleteInternalReviewName { get; private set; }

        public VocabularyKey CaptureProposalFeedback { get; private set; }

        public VocabularyKey CaptureProposalFeedbackName { get; private set; }

        public VocabularyKey ResolveFeedback { get; private set; }

        public VocabularyKey ResolveFeedbackName { get; private set; }

        public VocabularyKey PresentProposal { get; private set; }

        public VocabularyKey PresentProposalName { get; private set; }

        public VocabularyKey SendThankYouNote { get; private set; }

        public VocabularyKey SendThankYouNoteName { get; private set; }

        public VocabularyKey SalesStage { get; private set; }

        public VocabularyKey SalesStageName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey CompleteFinalProposal { get; private set; }

        public VocabularyKey CompleteFinalProposalName { get; private set; }

        public VocabularyKey FileDebrief { get; private set; }

        public VocabularyKey FileDeBriefName { get; private set; }

        public VocabularyKey PursuitDecision { get; private set; }

        public VocabularyKey PursuitDecisionName { get; private set; }

        public VocabularyKey CustomerPainPoints { get; private set; }

        public VocabularyKey CustomerNeed { get; private set; }

        public VocabularyKey ProposedSolution { get; private set; }

        public VocabularyKey QualificationComments { get; private set; }

        public VocabularyKey QuoteComments { get; private set; }

        public VocabularyKey PurchaseProcess { get; private set; }

        public VocabularyKey PurchaseProcessName { get; private set; }

        public VocabularyKey PurchaseTimeframe { get; private set; }

        public VocabularyKey PurchaseTimeframeName { get; private set; }

        public VocabularyKey IdentifyCustomerContacts { get; private set; }

        public VocabularyKey IdentifyCustomerContactsName { get; private set; }

        public VocabularyKey IdentifyCompetitors { get; private set; }

        public VocabularyKey IdentifyCompetitorsName { get; private set; }

        public VocabularyKey IdentifyPursuitTeam { get; private set; }

        public VocabularyKey IdentifyPursuitTeamName { get; private set; }

        public VocabularyKey CurrentSituation { get; private set; }

        public VocabularyKey PresentFinalProposal { get; private set; }

        public VocabularyKey PresentFinalProposalName { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }

        public VocabularyKey EmailAddress { get; private set; }

        public VocabularyKey TeamsFollowed { get; private set; }

        public VocabularyKey SkipPriceCalculation { get; private set; }

        public VocabularyKey skippricecalculationName { get; private set; }


    }
}

