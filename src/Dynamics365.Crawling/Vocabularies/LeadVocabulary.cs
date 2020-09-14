using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Dynamics365 Lead";
            KeyPrefix = "dynamics365.lead";
            KeySeparator = ".";
            Grouping = EntityType.Sales.Lead;

            this.AddGroup("Lead", group =>
            {
                this.LeadId = group.Add(new VocabularyKey("LeadId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the lead.")
                    .WithDisplayName("Lead")
                    .ModelProperty("leadid", typeof(Guid)));

                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact with which the lead is associated.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(string)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the lead is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.LeadSourceCode = group.Add(new VocabularyKey("LeadSourceCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the primary marketing source that prompted the lead to contact you.")
                    .WithDisplayName("Lead Source")
                    .ModelProperty("leadsourcecode", typeof(string)));

                this.LeadQualityCode = group.Add(new VocabularyKey("LeadQualityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Lead Rating (Cold/Warm/Hot) correlates to ‘Priority’ defined in the Engage stage, or has been rated by urgency from e.g. Event (import file)")
                    .WithDisplayName("Rating")
                    .ModelProperty("leadqualitycode", typeof(string)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicate the urgency of which the request is needed by selecting a time frame in Priority.")
                    .WithDisplayName("Project Timeline")
                    .ModelProperty("prioritycode", typeof(string)));

                this.IndustryCode = group.Add(new VocabularyKey("IndustryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.")
                    .WithDisplayName("Industry")
                    .ModelProperty("industrycode", typeof(string)));

                this.PreferredContactMethodCode = group.Add(new VocabularyKey("PreferredContactMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred method of contact.")
                    .WithDisplayName("Preferred Method of Contact")
                    .ModelProperty("preferredcontactmethodcode", typeof(string)));

                this.SalesStageCode = group.Add(new VocabularyKey("SalesStageCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.")
                    .WithDisplayName("Sales Stage Code")
                    .ModelProperty("salesstagecode", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_leads")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(300))
                    .WithDescription(@"Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.")
                    .WithDisplayName("Topic")
                    .ModelProperty("subject", typeof(string)));

                this.ParticipatesInWorkflow = group.Add(new VocabularyKey("ParticipatesInWorkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the lead participates in workflow rules.")
                    .WithDisplayName("Participates in Workflow")
                    .ModelProperty("participatesinworkflow", typeof(bool)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5000))
                    .WithDescription(@"Additional information from the Comments section of the Webform")
                    .WithDisplayName("Comments from webform")
                    .ModelProperty("description", typeof(string)));

                this.EstimatedValue = group.Add(new VocabularyKey("EstimatedValue", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.")
                    .WithDisplayName("Est. Value (deprecated)")
                    .ModelProperty("estimatedvalue", typeof(double)));

                this.EstimatedCloseDate = group.Add(new VocabularyKey("EstimatedCloseDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.")
                    .WithDisplayName("Est. Close Date")
                    .ModelProperty("estimatedclosedate", typeof(DateTime)));

                this.CompanyName = group.Add(new VocabularyKey("CompanyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.")
                    .WithDisplayName("Company Name")
                    .ModelProperty("companyname", typeof(string)));

                this.FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("First Name")
                    .ModelProperty("firstname", typeof(string)));

                this.MiddleName = group.Add(new VocabularyKey("MiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.")
                    .WithDisplayName("Middle Name")
                    .ModelProperty("middlename", typeof(string)));

                this.LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("Last Name")
                    .ModelProperty("lastname", typeof(string)));

                this.Revenue = group.Add(new VocabularyKey("Revenue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.")
                    .WithDisplayName("Annual Revenue")
                    .ModelProperty("revenue", typeof(string)));

                this.NumberOfEmployees = group.Add(new VocabularyKey("NumberOfEmployees", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicate the total number of employees regardless of UC/CC on the specific location.")
                    .WithDisplayName("Total No. of Employees - old (text)")
                    .ModelProperty("numberofemployees", typeof(long)));

                this.DoNotPhone = group.Add(new VocabularyKey("DoNotPhone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead allows phone calls.")
                    .WithDisplayName("Do not allow Phone Calls")
                    .ModelProperty("donotphone", typeof(bool)));

                this.SIC = group.Add(new VocabularyKey("SIC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.")
                    .WithDisplayName("SIC Code")
                    .ModelProperty("sic", typeof(string)));

                this.DoNotFax = group.Add(new VocabularyKey("DoNotFax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead allows faxes.")
                    .WithDisplayName("Do not allow Faxes")
                    .ModelProperty("donotfax", typeof(bool)));

                this.EMailAddress1 = group.Add(new VocabularyKey("EMailAddress1", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the primary email address for the lead.")
                    .WithDisplayName("E-Mail")
                    .ModelProperty("emailaddress1", typeof(string)));

                this.JobTitle = group.Add(new VocabularyKey("JobTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("Job Title")
                    .ModelProperty("jobtitle", typeof(string)));

                this.Salutation = group.Add(new VocabularyKey("Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.")
                    .WithDisplayName("Salutation")
                    .ModelProperty("salutation", typeof(string)));

                this.DoNotEMail = group.Add(new VocabularyKey("DoNotEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead allows direct email sent from Microsoft Dynamics 365.")
                    .WithDisplayName("Do not allow Emails")
                    .ModelProperty("donotemail", typeof(bool)));

                this.EMailAddress2 = group.Add(new VocabularyKey("EMailAddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the secondary email address for the lead.")
                    .WithDisplayName("Email Address 2")
                    .ModelProperty("emailaddress2", typeof(string)));

                this.DoNotPostalMail = group.Add(new VocabularyKey("DoNotPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead allows direct mail.")
                    .WithDisplayName("Do not allow Mails")
                    .ModelProperty("donotpostalmail", typeof(bool)));

                this.EMailAddress3 = group.Add(new VocabularyKey("EMailAddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a third email address for the lead.")
                    .WithDisplayName("Email Address 3")
                    .ModelProperty("emailaddress3", typeof(string)));

                this.FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Combines and shows the lead's first and last names so the full name can be displayed in views and reports.")
                    .WithDisplayName("Name")
                    .ModelProperty("fullname", typeof(string)));

                this.YomiFirstName = group.Add(new VocabularyKey("YomiFirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.")
                    .WithDisplayName("Yomi First Name")
                    .ModelProperty("yomifirstname", typeof(string)));

                this.WebSiteUrl = group.Add(new VocabularyKey("WebSiteUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the website URL for the company associated with this lead.")
                    .WithDisplayName("Website")
                    .ModelProperty("websiteurl", typeof(string)));

                this.Telephone1 = group.Add(new VocabularyKey("Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the work phone number for the primary contact for the lead.")
                    .WithDisplayName("Business Phone")
                    .ModelProperty("telephone1", typeof(string)));

                this.Telephone2 = group.Add(new VocabularyKey("Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the home phone number for the primary contact for the lead.")
                    .WithDisplayName("Direct Phone")
                    .ModelProperty("telephone2", typeof(string)));

                this.Telephone3 = group.Add(new VocabularyKey("Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type an alternate phone number for the primary contact for the lead.")
                    .WithDisplayName("Other Phone")
                    .ModelProperty("telephone3", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.IsPrivate = group.Add(new VocabularyKey("IsPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the lead is private or visible to the entire organization.")
                    .WithDisplayName("Is Private")
                    .ModelProperty("isprivate", typeof(bool)));

                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number for the primary contact for the lead.")
                    .WithDisplayName("Fax")
                    .ModelProperty("fax", typeof(string)));

                this.YomiMiddleName = group.Add(new VocabularyKey("YomiMiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.")
                    .WithDisplayName("Yomi Middle Name")
                    .ModelProperty("yomimiddlename", typeof(string)));

                this.YomiLastName = group.Add(new VocabularyKey("YomiLastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.")
                    .WithDisplayName("Yomi Last Name")
                    .ModelProperty("yomilastname", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.YomiFullName = group.Add(new VocabularyKey("YomiFullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.")
                    .WithDisplayName("Yomi Full Name")
                    .ModelProperty("yomifullname", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lead_owning_user")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.MobilePhone = group.Add(new VocabularyKey("MobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the mobile phone number for the primary contact for the lead.")
                    .WithDisplayName("Mobile Phone")
                    .ModelProperty("mobilephone", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.")
                    .WithDisplayName("System Status")
                    .ModelProperty("statecode", typeof(string)));

                this.Pager = group.Add(new VocabularyKey("Pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the pager number for the primary contact for the lead.")
                    .WithDisplayName("Pager")
                    .ModelProperty("pager", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the lead's status.")
                    .WithDisplayName("Lead Status (System)")
                    .ModelProperty("statuscode", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the lead.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

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

                this.Address1_AddressId = group.Add(new VocabularyKey("Address1_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 1.")
                    .WithDisplayName("Address 1: ID")
                    .ModelProperty("address1_addressid", typeof(Guid)));

                this.Address1_AddressTypeCode = group.Add(new VocabularyKey("Address1_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the primary address type.")
                    .WithDisplayName("Address 1: Address Type")
                    .ModelProperty("address1_addresstypecode", typeof(string)));

                this.Address1_Name = group.Add(new VocabularyKey("Address1_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a descriptive name for the primary address, such as Corporate Headquarters.")
                    .WithDisplayName("Address 1: Name")
                    .ModelProperty("address1_name", typeof(string)));

                this.Address1_Line1 = group.Add(new VocabularyKey("Address1_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the primary address.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("address1_line1", typeof(string)));

                this.Address1_Line2 = group.Add(new VocabularyKey("Address1_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the second line of the primary address.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("address1_line2", typeof(string)));

                this.Address1_Line3 = group.Add(new VocabularyKey("Address1_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the third line of the primary address.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("address1_line3", typeof(string)));

                this.Address1_City = group.Add(new VocabularyKey("Address1_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the primary address.")
                    .WithDisplayName("City")
                    .ModelProperty("address1_city", typeof(string)));

                this.Address1_StateOrProvince = group.Add(new VocabularyKey("Address1_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the state or province of the primary address.")
                    .WithDisplayName("Address 1: State/Province (No NOT Use)")
                    .ModelProperty("address1_stateorprovince", typeof(string)));

                this.Address1_County = group.Add(new VocabularyKey("Address1_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the county for the primary address.")
                    .WithDisplayName("Address 1: County")
                    .ModelProperty("address1_county", typeof(string)));

                this.Address1_Country = group.Add(new VocabularyKey("Address1_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the country or region for the primary address.")
                    .WithDisplayName("Country/Region (No NOT Use)")
                    .ModelProperty("address1_country", typeof(string)));

                this.Address1_PostOfficeBox = group.Add(new VocabularyKey("Address1_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the post office box number of the primary address.")
                    .WithDisplayName("Address 1: Post Office Box")
                    .ModelProperty("address1_postofficebox", typeof(string)));

                this.Address1_PostalCode = group.Add(new VocabularyKey("Address1_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the ZIP Code or postal code for the primary address.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("address1_postalcode", typeof(string)));

                this.Address1_UTCOffset = group.Add(new VocabularyKey("Address1_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.")
                    .WithDisplayName("Address 1: UTC Offset")
                    .ModelProperty("address1_utcoffset", typeof(long)));

                this.Address1_UPSZone = group.Add(new VocabularyKey("Address1_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.")
                    .WithDisplayName("Address 1: UPS Zone")
                    .ModelProperty("address1_upszone", typeof(string)));

                this.Address1_Latitude = group.Add(new VocabularyKey("Address1_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the latitude value for the primary address for use in mapping and other applications.")
                    .WithDisplayName("Address 1: Latitude")
                    .ModelProperty("address1_latitude", typeof(double)));

                this.Address1_Telephone1 = group.Add(new VocabularyKey("Address1_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the main phone number associated with the primary address.")
                    .WithDisplayName("Address 1: Telephone 1")
                    .ModelProperty("address1_telephone1", typeof(string)));

                this.Address1_Longitude = group.Add(new VocabularyKey("Address1_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the longitude value for the primary address for use in mapping and other applications.")
                    .WithDisplayName("Address 1: Longitude")
                    .ModelProperty("address1_longitude", typeof(double)));

                this.Address1_ShippingMethodCode = group.Add(new VocabularyKey("Address1_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Address 1: Shipping Method")
                    .ModelProperty("address1_shippingmethodcode", typeof(string)));

                this.Address1_Telephone2 = group.Add(new VocabularyKey("Address1_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second phone number associated with the primary address.")
                    .WithDisplayName("Address 1: Telephone 2")
                    .ModelProperty("address1_telephone2", typeof(string)));

                this.Address1_Telephone3 = group.Add(new VocabularyKey("Address1_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number associated with the primary address.")
                    .WithDisplayName("Address 1: Telephone 3")
                    .ModelProperty("address1_telephone3", typeof(string)));

                this.Address1_Fax = group.Add(new VocabularyKey("Address1_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number associated with the primary address.")
                    .WithDisplayName("Address 1: Fax")
                    .ModelProperty("address1_fax", typeof(string)));

                this.Address2_AddressId = group.Add(new VocabularyKey("Address2_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 2.")
                    .WithDisplayName("Address 2: ID")
                    .ModelProperty("address2_addressid", typeof(Guid)));

                this.Address2_AddressTypeCode = group.Add(new VocabularyKey("Address2_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the secondary address type.")
                    .WithDisplayName("Address 2: Address Type")
                    .ModelProperty("address2_addresstypecode", typeof(string)));

                this.Address2_Name = group.Add(new VocabularyKey("Address2_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a descriptive name for the secondary address, such as Corporate Headquarters.")
                    .WithDisplayName("Address 2: Name")
                    .ModelProperty("address2_name", typeof(string)));

                this.Address2_Line1 = group.Add(new VocabularyKey("Address2_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the first line of the secondary address.")
                    .WithDisplayName("Address 2: Street 1")
                    .ModelProperty("address2_line1", typeof(string)));

                this.Address2_Line2 = group.Add(new VocabularyKey("Address2_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the second line of the secondary address.")
                    .WithDisplayName("Address 2: Street 2")
                    .ModelProperty("address2_line2", typeof(string)));

                this.Address2_Line3 = group.Add(new VocabularyKey("Address2_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the third line of the secondary address.")
                    .WithDisplayName("Address 2: Street 3")
                    .ModelProperty("address2_line3", typeof(string)));

                this.Address2_City = group.Add(new VocabularyKey("Address2_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the secondary address.")
                    .WithDisplayName("Address 2: City")
                    .ModelProperty("address2_city", typeof(string)));

                this.Address2_StateOrProvince = group.Add(new VocabularyKey("Address2_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the state or province of the secondary address.")
                    .WithDisplayName("Address 2: State/Province")
                    .ModelProperty("address2_stateorprovince", typeof(string)));

                this.Address2_County = group.Add(new VocabularyKey("Address2_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the county for the secondary address.")
                    .WithDisplayName("Address 2: County")
                    .ModelProperty("address2_county", typeof(string)));

                this.Address2_Country = group.Add(new VocabularyKey("Address2_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the country or region for the secondary address.")
                    .WithDisplayName("Address 2: Country/Region")
                    .ModelProperty("address2_country", typeof(string)));

                this.Address2_PostOfficeBox = group.Add(new VocabularyKey("Address2_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the post office box number of the secondary address.")
                    .WithDisplayName("Address 2: Post Office Box")
                    .ModelProperty("address2_postofficebox", typeof(string)));

                this.Address2_PostalCode = group.Add(new VocabularyKey("Address2_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Type the ZIP Code or postal code for the secondary address.")
                    .WithDisplayName("Address 2: ZIP/Postal Code")
                    .ModelProperty("address2_postalcode", typeof(string)));

                this.Address2_UTCOffset = group.Add(new VocabularyKey("Address2_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.")
                    .WithDisplayName("Address 2: UTC Offset")
                    .ModelProperty("address2_utcoffset", typeof(long)));

                this.Address2_UPSZone = group.Add(new VocabularyKey("Address2_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.")
                    .WithDisplayName("Address 2: UPS Zone")
                    .ModelProperty("address2_upszone", typeof(string)));

                this.Address2_Latitude = group.Add(new VocabularyKey("Address2_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the latitude value for the secondary address for use in mapping and other applications.")
                    .WithDisplayName("Address 2: Latitude")
                    .ModelProperty("address2_latitude", typeof(double)));

                this.Address2_Telephone1 = group.Add(new VocabularyKey("Address2_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the main phone number associated with the secondary address.")
                    .WithDisplayName("Address 2: Telephone 1")
                    .ModelProperty("address2_telephone1", typeof(string)));

                this.Address2_Longitude = group.Add(new VocabularyKey("Address2_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the longitude value for the secondary address for use in mapping and other applications.")
                    .WithDisplayName("Address 2: Longitude")
                    .ModelProperty("address2_longitude", typeof(double)));

                this.Address2_ShippingMethodCode = group.Add(new VocabularyKey("Address2_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Address 2: Shipping Method")
                    .ModelProperty("address2_shippingmethodcode", typeof(string)));

                this.Address2_Telephone2 = group.Add(new VocabularyKey("Address2_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second phone number associated with the secondary address.")
                    .WithDisplayName("Address 2: Telephone 2")
                    .ModelProperty("address2_telephone2", typeof(string)));

                this.Address2_Telephone3 = group.Add(new VocabularyKey("Address2_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number associated with the secondary address.")
                    .WithDisplayName("Address 2: Telephone 3")
                    .ModelProperty("address2_telephone3", typeof(string)));

                this.Address2_Fax = group.Add(new VocabularyKey("Address2_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number associated with the secondary address.")
                    .WithDisplayName("Address 2: Fax")
                    .ModelProperty("address2_fax", typeof(string)));

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
                    .WithDisplayName("Customer")
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

                this.IsPrivateName = group.Add(new VocabularyKey("IsPrivateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPrivateName")
                    .ModelProperty("isprivatename", typeof(string)));

                this.DoNotPostalMailName = group.Add(new VocabularyKey("DoNotPostalMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPostalMailName")
                    .ModelProperty("donotpostalmailname", typeof(string)));

                this.DoNotFaxName = group.Add(new VocabularyKey("DoNotFaxName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotFaxName")
                    .ModelProperty("donotfaxname", typeof(string)));

                this.DoNotEMailName = group.Add(new VocabularyKey("DoNotEMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotEMailName")
                    .ModelProperty("donotemailname", typeof(string)));

                this.DoNotPhoneName = group.Add(new VocabularyKey("DoNotPhoneName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPhoneName")
                    .ModelProperty("donotphonename", typeof(string)));

                this.ParticipatesInWorkflowName = group.Add(new VocabularyKey("ParticipatesInWorkflowName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ParticipatesInWorkflowName")
                    .ModelProperty("participatesinworkflowname", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.LeadSourceCodeName = group.Add(new VocabularyKey("LeadSourceCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeadSourceCodeName")
                    .ModelProperty("leadsourcecodename", typeof(string)));

                this.SalesStageCodeName = group.Add(new VocabularyKey("SalesStageCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SalesStageCodeName")
                    .ModelProperty("salesstagecodename", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.Address2_AddressTypeCodeName = group.Add(new VocabularyKey("Address2_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_AddressTypeCodeName")
                    .ModelProperty("address2_addresstypecodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.Address1_ShippingMethodCodeName = group.Add(new VocabularyKey("Address1_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_ShippingMethodCodeName")
                    .ModelProperty("address1_shippingmethodcodename", typeof(string)));

                this.LeadQualityCodeName = group.Add(new VocabularyKey("LeadQualityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeadQualityCodeName")
                    .ModelProperty("leadqualitycodename", typeof(string)));

                this.IndustryCodeName = group.Add(new VocabularyKey("IndustryCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IndustryCodeName")
                    .ModelProperty("industrycodename", typeof(string)));

                this.Address1_AddressTypeCodeName = group.Add(new VocabularyKey("Address1_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_AddressTypeCodeName")
                    .ModelProperty("address1_addresstypecodename", typeof(string)));

                this.Address2_ShippingMethodCodeName = group.Add(new VocabularyKey("Address2_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_ShippingMethodCodeName")
                    .ModelProperty("address2_shippingmethodcodename", typeof(string)));

                this.PreferredContactMethodCodeName = group.Add(new VocabularyKey("PreferredContactMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredContactMethodCodeName")
                    .ModelProperty("preferredcontactmethodcodename", typeof(string)));

                this.MasterId = group.Add(new VocabularyKey("MasterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lead_master_lead")
                    .WithDisplayName("Master ID")
                    .ModelProperty("masterid", typeof(string)));

                this.CampaignId = group.Add(new VocabularyKey("CampaignId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify communications received by the lead.")
                    .WithDisplayName("Source Campaign")
                    .ModelProperty("campaignid", typeof(string)));

                this.DoNotSendMM = group.Add(new VocabularyKey("DoNotSendMM", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.")
                    .WithDisplayName("Marketing Material")
                    .ModelProperty("donotsendmm", typeof(bool)));

                this.Merged = group.Add(new VocabularyKey("Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Tells whether the lead has been merged with another lead.")
                    .WithDisplayName("Merged")
                    .ModelProperty("merged", typeof(bool)));

                this.DoNotBulkEMail = group.Add(new VocabularyKey("DoNotBulkEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.")
                    .WithDisplayName("E-Mail Permission")
                    .ModelProperty("donotbulkemail", typeof(bool)));

                this.LastUsedInCampaign = group.Add(new VocabularyKey("LastUsedInCampaign", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date when the lead was last included in a marketing campaign or quick campaign.")
                    .WithDisplayName("Last Campaign Date")
                    .ModelProperty("lastusedincampaign", typeof(DateTime)));

                this.CampaignIdName = group.Add(new VocabularyKey("CampaignIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CampaignIdName")
                    .ModelProperty("campaignidname", typeof(string)));

                this.DoNotBulkEMailName = group.Add(new VocabularyKey("DoNotBulkEMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotBulkEMailName")
                    .ModelProperty("donotbulkemailname", typeof(string)));

                this.MasterLeadIdName = group.Add(new VocabularyKey("MasterLeadIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterLeadIdName")
                    .ModelProperty("masterleadidname", typeof(string)));

                this.MergedName = group.Add(new VocabularyKey("MergedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MergedName")
                    .ModelProperty("mergedname", typeof(string)));

                this.DoNotSendMarketingMaterialName = group.Add(new VocabularyKey("DoNotSendMarketingMaterialName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotSendMarketingMaterialName")
                    .ModelProperty("donotsendmarketingmaterialname", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.EstimatedAmount = group.Add(new VocabularyKey("EstimatedAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.")
                    .WithDisplayName("Est. Value")
                    .ModelProperty("estimatedamount", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.EstimatedAmount_Base = group.Add(new VocabularyKey("EstimatedAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Est. Value field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Est. Value (Base)")
                    .ModelProperty("estimatedamount_base", typeof(string)));

                this.Revenue_Base = group.Add(new VocabularyKey("Revenue_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Annual Revenue field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Annual Revenue (Base)")
                    .ModelProperty("revenue_base", typeof(string)));

                this.YomiCompanyName = group.Add(new VocabularyKey("YomiCompanyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.")
                    .WithDisplayName("Yomi Company Name")
                    .ModelProperty("yomicompanyname", typeof(string)));

                this.AccountIdYomiName = group.Add(new VocabularyKey("AccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdYomiName")
                    .ModelProperty("accountidyominame", typeof(string)));

                this.ContactIdYomiName = group.Add(new VocabularyKey("ContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ContactIdYomiName")
                    .ModelProperty("contactidyominame", typeof(string)));

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

                this.MasterLeadIdYomiName = group.Add(new VocabularyKey("MasterLeadIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterLeadIdYomiName")
                    .ModelProperty("masterleadidyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.CustomerIdYomiName = group.Add(new VocabularyKey("CustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("CustomerIdYomiName")
                    .ModelProperty("customeridyominame", typeof(string)));

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
                    .WithDescription(@"lead_owning_team")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.IsAutoCreate = group.Add(new VocabularyKey("IsAutoCreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the contact was auto-created when promoting an email or an appointment.")
                    .WithDisplayName("Auto-created")
                    .ModelProperty("isautocreate", typeof(bool)));

                this.ParentAccountId = group.Add(new VocabularyKey("ParentAccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"lead_parent_account")
                    .WithDisplayName("Parent Account for lead")
                    .ModelProperty("parentaccountid", typeof(string)));

                this.ParentContactId = group.Add(new VocabularyKey("ParentContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"lead_parent_contact")
                    .WithDisplayName("Parent Contact for lead")
                    .ModelProperty("parentcontactid", typeof(string)));

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

                this.RelatedObjectId = group.Add(new VocabularyKey("RelatedObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Related Campaign Response.")
                    .WithDisplayName("Related Campaign Response")
                    .ModelProperty("relatedobjectid", typeof(string)));

                this.BudgetAmount = group.Add(new VocabularyKey("BudgetAmount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicate the customer budget amount available (if known).")
                    .WithDisplayName("Estimated Revenue")
                    .ModelProperty("budgetamount", typeof(string)));

                this.BudgetAmount_Base = group.Add(new VocabularyKey("BudgetAmount_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Base currency equivalent of the estimated budget of the lead.")
                    .WithDisplayName("Budget Amount (Base)")
                    .ModelProperty("budgetamount_base", typeof(string)));

                this.BudgetStatus = group.Add(new VocabularyKey("BudgetStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about the budget status of the lead's company or organization.")
                    .WithDisplayName("Budget")
                    .ModelProperty("budgetstatus", typeof(string)));

                this.BudgetStatusName = group.Add(new VocabularyKey("BudgetStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BudgetStatusName")
                    .ModelProperty("budgetstatusname", typeof(string)));

                this.DecisionMaker = group.Add(new VocabularyKey("DecisionMaker", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether your notes include information about who makes the purchase decisions at the lead's company.")
                    .WithDisplayName("Decision Maker?")
                    .ModelProperty("decisionmaker", typeof(bool)));

                this.DecisionMakerName = group.Add(new VocabularyKey("DecisionMakerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DecisionMakerName")
                    .ModelProperty("decisionmakername", typeof(string)));

                this.Need = group.Add(new VocabularyKey("Need", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose how high the level of need is for the lead's company.")
                    .WithDisplayName("Need")
                    .ModelProperty("need", typeof(string)));

                this.NeedName = group.Add(new VocabularyKey("NeedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("NeedName")
                    .ModelProperty("needname", typeof(string)));

                this.PurchaseTimeFrame = group.Add(new VocabularyKey("PurchaseTimeFrame", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose how long the lead will likely take to make the purchase, so the sales team will be aware.")
                    .WithDisplayName("Purchase Timeframe")
                    .ModelProperty("purchasetimeframe", typeof(string)));

                this.PurchaseTimeFrameName = group.Add(new VocabularyKey("PurchaseTimeFrameName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PurchaseTimeFrameName")
                    .ModelProperty("purchasetimeframename", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

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
                    .WithDescription(@"Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.")
                    .WithDisplayName("Confirm Interest")
                    .ModelProperty("confirminterest", typeof(bool)));

                this.ConfirmInterestName = group.Add(new VocabularyKey("ConfirmInterestName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ConfirmInterestName")
                    .ModelProperty("confirminterestname", typeof(string)));

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

                this.SalesStage = group.Add(new VocabularyKey("SalesStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.")
                    .WithDisplayName("Sales Stage")
                    .ModelProperty("salesstage", typeof(string)));

                this.SalesStageName = group.Add(new VocabularyKey("SalesStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SalesStageName")
                    .ModelProperty("salesstagename", typeof(string)));

                this.ScheduleFollowUp_Prospect = group.Add(new VocabularyKey("ScheduleFollowUp_Prospect", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time of the prospecting follow-up meeting with the lead.")
                    .WithDisplayName("Schedule Follow Up (Prospect)")
                    .ModelProperty("schedulefollowup_prospect", typeof(DateTime)));

                this.ScheduleFollowUp_Qualify = group.Add(new VocabularyKey("ScheduleFollowUp_Qualify", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date and time of the qualifying follow-up meeting with the lead.")
                    .WithDisplayName("Schedule Follow Up (Qualify)")
                    .ModelProperty("schedulefollowup_qualify", typeof(DateTime)));

                this.QualificationComments = group.Add(new VocabularyKey("QualificationComments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type comments about the qualification or scoring of the lead.")
                    .WithDisplayName("Qualification Comments")
                    .ModelProperty("qualificationcomments", typeof(string)));

                this.QualifyingOpportunityId = group.Add(new VocabularyKey("QualifyingOpportunityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the opportunity that the lead was qualified on and then converted to.")
                    .WithDisplayName("Qualifying Opportunity")
                    .ModelProperty("qualifyingopportunityid", typeof(string)));

                this.QualifyingOpportunityIdName = group.Add(new VocabularyKey("QualifyingOpportunityIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("QualifyingOpportunityIdName")
                    .ModelProperty("qualifyingopportunityidname", typeof(string)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default image for the record.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"processstage_lead")
                    .WithDisplayName("Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.Address2_Composite = group.Add(new VocabularyKey("Address2_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete secondary address.")
                    .WithDisplayName("Address 2")
                    .ModelProperty("address2_composite", typeof(string)));

                this.Address1_Composite = group.Add(new VocabularyKey("Address1_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete primary address.")
                    .WithDisplayName("Address 1")
                    .ModelProperty("address1_composite", typeof(string)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.OriginatingCaseId = group.Add(new VocabularyKey("OriginatingCaseId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"This attribute is used for Sample Service Business Processes.")
                    .WithDisplayName("Originating Case")
                    .ModelProperty("originatingcaseid", typeof(string)));

                this.OriginatingCaseIdName = group.Add(new VocabularyKey("OriginatingCaseIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingCaseIdName")
                    .ModelProperty("originatingcaseidname", typeof(string)));

                this.RelatedObjectIdName = group.Add(new VocabularyKey("RelatedObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("RelatedObjectIdName")
                    .ModelProperty("relatedobjectidname", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"manualsla_lead")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"sla_lead")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how long, in minutes, that the record was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date and time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.FollowEmail = group.Add(new VocabularyKey("FollowEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.")
                    .WithDisplayName("Follow Email Activity")
                    .ModelProperty("followemail", typeof(bool)));

                this.FollowEmailName = group.Add(new VocabularyKey("FollowEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FollowEmailName")
                    .ModelProperty("followemailname", typeof(string)));

                this.TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey("TimeSpentByMeOnEmailAndMeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1250))
                    .WithDescription(@"Total time spent for emails (read and write) and meetings by me in relation to the lead record.")
                    .WithDisplayName("Time Spent by me")
                    .ModelProperty("timespentbymeonemailandmeetings", typeof(string)));

                this.isautocreateName = group.Add(new VocabularyKey("isautocreateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isautocreateName")
                    .ModelProperty("isautocreatename", typeof(string)));

                this.TeamsFollowed = group.Add(new VocabularyKey("TeamsFollowed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of users or conversations followed the record")
                    .WithDisplayName("TeamsFollowed")
                    .ModelProperty("teamsfollowed", typeof(long)));

                this.BusinessCard = group.Add(new VocabularyKey("BusinessCard", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Stores Image of the Business Card")
                    .WithDisplayName("Business Card")
                    .ModelProperty("businesscard", typeof(string)));

                this.BusinessCardAttributes = group.Add(new VocabularyKey("BusinessCardAttributes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4000))
                    .WithDescription(@"Stores Business Card Control Properties.")
                    .WithDisplayName("BusinessCardAttributes")
                    .ModelProperty("businesscardattributes", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey LeadId { get; private set; }

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey LeadSourceCode { get; private set; }

        public VocabularyKey LeadQualityCode { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey IndustryCode { get; private set; }

        public VocabularyKey PreferredContactMethodCode { get; private set; }

        public VocabularyKey SalesStageCode { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey ParticipatesInWorkflow { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey EstimatedValue { get; private set; }

        public VocabularyKey EstimatedCloseDate { get; private set; }

        public VocabularyKey CompanyName { get; private set; }

        public VocabularyKey FirstName { get; private set; }

        public VocabularyKey MiddleName { get; private set; }

        public VocabularyKey LastName { get; private set; }

        public VocabularyKey Revenue { get; private set; }

        public VocabularyKey NumberOfEmployees { get; private set; }

        public VocabularyKey DoNotPhone { get; private set; }

        public VocabularyKey SIC { get; private set; }

        public VocabularyKey DoNotFax { get; private set; }

        public VocabularyKey EMailAddress1 { get; private set; }

        public VocabularyKey JobTitle { get; private set; }

        public VocabularyKey Salutation { get; private set; }

        public VocabularyKey DoNotEMail { get; private set; }

        public VocabularyKey EMailAddress2 { get; private set; }

        public VocabularyKey DoNotPostalMail { get; private set; }

        public VocabularyKey EMailAddress3 { get; private set; }

        public VocabularyKey FullName { get; private set; }

        public VocabularyKey YomiFirstName { get; private set; }

        public VocabularyKey WebSiteUrl { get; private set; }

        public VocabularyKey Telephone1 { get; private set; }

        public VocabularyKey Telephone2 { get; private set; }

        public VocabularyKey Telephone3 { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey IsPrivate { get; private set; }

        public VocabularyKey Fax { get; private set; }

        public VocabularyKey YomiMiddleName { get; private set; }

        public VocabularyKey YomiLastName { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey YomiFullName { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey MobilePhone { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey Pager { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ContactIdName { get; private set; }

        public VocabularyKey AccountIdName { get; private set; }

        public VocabularyKey Address1_AddressId { get; private set; }

        public VocabularyKey Address1_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_Name { get; private set; }

        public VocabularyKey Address1_Line1 { get; private set; }

        public VocabularyKey Address1_Line2 { get; private set; }

        public VocabularyKey Address1_Line3 { get; private set; }

        public VocabularyKey Address1_City { get; private set; }

        public VocabularyKey Address1_StateOrProvince { get; private set; }

        public VocabularyKey Address1_County { get; private set; }

        public VocabularyKey Address1_Country { get; private set; }

        public VocabularyKey Address1_PostOfficeBox { get; private set; }

        public VocabularyKey Address1_PostalCode { get; private set; }

        public VocabularyKey Address1_UTCOffset { get; private set; }

        public VocabularyKey Address1_UPSZone { get; private set; }

        public VocabularyKey Address1_Latitude { get; private set; }

        public VocabularyKey Address1_Telephone1 { get; private set; }

        public VocabularyKey Address1_Longitude { get; private set; }

        public VocabularyKey Address1_ShippingMethodCode { get; private set; }

        public VocabularyKey Address1_Telephone2 { get; private set; }

        public VocabularyKey Address1_Telephone3 { get; private set; }

        public VocabularyKey Address1_Fax { get; private set; }

        public VocabularyKey Address2_AddressId { get; private set; }

        public VocabularyKey Address2_AddressTypeCode { get; private set; }

        public VocabularyKey Address2_Name { get; private set; }

        public VocabularyKey Address2_Line1 { get; private set; }

        public VocabularyKey Address2_Line2 { get; private set; }

        public VocabularyKey Address2_Line3 { get; private set; }

        public VocabularyKey Address2_City { get; private set; }

        public VocabularyKey Address2_StateOrProvince { get; private set; }

        public VocabularyKey Address2_County { get; private set; }

        public VocabularyKey Address2_Country { get; private set; }

        public VocabularyKey Address2_PostOfficeBox { get; private set; }

        public VocabularyKey Address2_PostalCode { get; private set; }

        public VocabularyKey Address2_UTCOffset { get; private set; }

        public VocabularyKey Address2_UPSZone { get; private set; }

        public VocabularyKey Address2_Latitude { get; private set; }

        public VocabularyKey Address2_Telephone1 { get; private set; }

        public VocabularyKey Address2_Longitude { get; private set; }

        public VocabularyKey Address2_ShippingMethodCode { get; private set; }

        public VocabularyKey Address2_Telephone2 { get; private set; }

        public VocabularyKey Address2_Telephone3 { get; private set; }

        public VocabularyKey Address2_Fax { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CustomerId { get; private set; }

        public VocabularyKey CustomerIdName { get; private set; }

        public VocabularyKey CustomerIdType { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey IsPrivateName { get; private set; }

        public VocabularyKey DoNotPostalMailName { get; private set; }

        public VocabularyKey DoNotFaxName { get; private set; }

        public VocabularyKey DoNotEMailName { get; private set; }

        public VocabularyKey DoNotPhoneName { get; private set; }

        public VocabularyKey ParticipatesInWorkflowName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey LeadSourceCodeName { get; private set; }

        public VocabularyKey SalesStageCodeName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey Address2_AddressTypeCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey Address1_ShippingMethodCodeName { get; private set; }

        public VocabularyKey LeadQualityCodeName { get; private set; }

        public VocabularyKey IndustryCodeName { get; private set; }

        public VocabularyKey Address1_AddressTypeCodeName { get; private set; }

        public VocabularyKey Address2_ShippingMethodCodeName { get; private set; }

        public VocabularyKey PreferredContactMethodCodeName { get; private set; }

        public VocabularyKey MasterId { get; private set; }

        public VocabularyKey CampaignId { get; private set; }

        public VocabularyKey DoNotSendMM { get; private set; }

        public VocabularyKey Merged { get; private set; }

        public VocabularyKey DoNotBulkEMail { get; private set; }

        public VocabularyKey LastUsedInCampaign { get; private set; }

        public VocabularyKey CampaignIdName { get; private set; }

        public VocabularyKey DoNotBulkEMailName { get; private set; }

        public VocabularyKey MasterLeadIdName { get; private set; }

        public VocabularyKey MergedName { get; private set; }

        public VocabularyKey DoNotSendMarketingMaterialName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey EstimatedAmount { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey EstimatedAmount_Base { get; private set; }

        public VocabularyKey Revenue_Base { get; private set; }

        public VocabularyKey YomiCompanyName { get; private set; }

        public VocabularyKey AccountIdYomiName { get; private set; }

        public VocabularyKey ContactIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey MasterLeadIdYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey CustomerIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey IsAutoCreate { get; private set; }

        public VocabularyKey ParentAccountId { get; private set; }

        public VocabularyKey ParentContactId { get; private set; }

        public VocabularyKey ParentAccountIdName { get; private set; }

        public VocabularyKey ParentAccountIdYomiName { get; private set; }

        public VocabularyKey ParentContactIdName { get; private set; }

        public VocabularyKey ParentContactIdYomiName { get; private set; }

        public VocabularyKey RelatedObjectId { get; private set; }

        public VocabularyKey BudgetAmount { get; private set; }

        public VocabularyKey BudgetAmount_Base { get; private set; }

        public VocabularyKey BudgetStatus { get; private set; }

        public VocabularyKey BudgetStatusName { get; private set; }

        public VocabularyKey DecisionMaker { get; private set; }

        public VocabularyKey DecisionMakerName { get; private set; }

        public VocabularyKey Need { get; private set; }

        public VocabularyKey NeedName { get; private set; }

        public VocabularyKey PurchaseTimeFrame { get; private set; }

        public VocabularyKey PurchaseTimeFrameName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey EvaluateFit { get; private set; }

        public VocabularyKey EvaluateFitName { get; private set; }

        public VocabularyKey InitialCommunication { get; private set; }

        public VocabularyKey InitialCommunicationName { get; private set; }

        public VocabularyKey ConfirmInterest { get; private set; }

        public VocabularyKey ConfirmInterestName { get; private set; }

        public VocabularyKey PurchaseProcess { get; private set; }

        public VocabularyKey PurchaseProcessName { get; private set; }

        public VocabularyKey SalesStage { get; private set; }

        public VocabularyKey SalesStageName { get; private set; }

        public VocabularyKey ScheduleFollowUp_Prospect { get; private set; }

        public VocabularyKey ScheduleFollowUp_Qualify { get; private set; }

        public VocabularyKey QualificationComments { get; private set; }

        public VocabularyKey QualifyingOpportunityId { get; private set; }

        public VocabularyKey QualifyingOpportunityIdName { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey Address2_Composite { get; private set; }

        public VocabularyKey Address1_Composite { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey OriginatingCaseId { get; private set; }

        public VocabularyKey OriginatingCaseIdName { get; private set; }

        public VocabularyKey RelatedObjectIdName { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey FollowEmail { get; private set; }

        public VocabularyKey FollowEmailName { get; private set; }

        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }

        public VocabularyKey isautocreateName { get; private set; }

        public VocabularyKey TeamsFollowed { get; private set; }

        public VocabularyKey BusinessCard { get; private set; }

        public VocabularyKey BusinessCardAttributes { get; private set; }


    }
}

