using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Dynamics365 Contact";
            KeyPrefix = "dynamics365.contact";
            KeySeparator = ".";
            Grouping = EntityType.Infrastructure.User;

            this.AddGroup("Contact", group =>
            {
                this.ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the contact.")
                    .WithDisplayName("Contact")
                    .ModelProperty("contactid", typeof(Guid)));

                this.DefaultPriceLevelId = group.Add(new VocabularyKey("DefaultPriceLevelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.")
                    .WithDisplayName("Price List")
                    .ModelProperty("defaultpricelevelid", typeof(string)));

                this.CustomerSizeCode = group.Add(new VocabularyKey("CustomerSizeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the size of the contact's company for segmentation and reporting purposes.")
                    .WithDisplayName("Customer Size")
                    .ModelProperty("customersizecode", typeof(string)));

                this.CustomerTypeCode = group.Add(new VocabularyKey("CustomerTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the category that best describes the relationship between the contact and your organization.")
                    .WithDisplayName("Relationship Type")
                    .ModelProperty("customertypecode", typeof(string)));

                this.PreferredContactMethodCode = group.Add(new VocabularyKey("PreferredContactMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred method of contact.")
                    .WithDisplayName("Preferred Method of Contact")
                    .ModelProperty("preferredcontactmethodcode", typeof(string)));

                this.LeadSourceCode = group.Add(new VocabularyKey("LeadSourceCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the primary marketing source that directed the contact to your organization.")
                    .WithDisplayName("Lead Source")
                    .ModelProperty("leadsourcecode", typeof(string)));

                this.OriginatingLeadId = group.Add(new VocabularyKey("OriginatingLeadId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics CRM. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.")
                    .WithDisplayName("Originating Lead")
                    .ModelProperty("originatingleadid", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the contact.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the contact.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.PaymentTermsCode = group.Add(new VocabularyKey("PaymentTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the payment terms to indicate when the customer needs to pay the total amount.")
                    .WithDisplayName("Payment Terms")
                    .ModelProperty("paymenttermscode", typeof(string)));

                this.ShippingMethodCode = group.Add(new VocabularyKey("ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Shipping Method")
                    .ModelProperty("shippingmethodcode", typeof(string)));

                this.AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the account with which the contact is associated.")
                    .WithDisplayName("Account")
                    .ModelProperty("accountid", typeof(string)));

                this.ParticipatesInWorkflow = group.Add(new VocabularyKey("ParticipatesInWorkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the contact participates in workflow rules.")
                    .WithDisplayName("Participates in Workflow")
                    .ModelProperty("participatesinworkflow", typeof(bool)));

                this.IsBackofficeCustomer = group.Add(new VocabularyKey("IsBackofficeCustomer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.")
                    .WithDisplayName("Back Office Customer")
                    .ModelProperty("isbackofficecustomer", typeof(bool)));

                this.Salutation = group.Add(new VocabularyKey("Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.")
                    .WithDisplayName("Salutation")
                    .ModelProperty("salutation", typeof(string)));

                this.JobTitle = group.Add(new VocabularyKey("JobTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("Job Title")
                    .ModelProperty("jobtitle", typeof(string)));

                this.FirstName = group.Add(new VocabularyKey("FirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("First Name")
                    .ModelProperty("firstname", typeof(string)));

                this.Department = group.Add(new VocabularyKey("Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"If needed, update with a more specific Department name to give details on the organizational set-up for the contact person")
                    .WithDisplayName("Department")
                    .ModelProperty("department", typeof(string)));

                this.NickName = group.Add(new VocabularyKey("NickName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the contact's nickname.")
                    .WithDisplayName("Nickname")
                    .ModelProperty("nickname", typeof(string)));

                this.MiddleName = group.Add(new VocabularyKey("MiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the contact's middle name or initial to make sure the contact is addressed correctly.")
                    .WithDisplayName("Middle Name")
                    .ModelProperty("middlename", typeof(string)));

                this.LastName = group.Add(new VocabularyKey("LastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("Last Name")
                    .ModelProperty("lastname", typeof(string)));

                this.Suffix = group.Add(new VocabularyKey("Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(10))
                    .WithDescription(@"Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("Suffix")
                    .ModelProperty("suffix", typeof(string)));

                this.YomiFirstName = group.Add(new VocabularyKey("YomiFirstName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.")
                    .WithDisplayName("Yomi First Name")
                    .ModelProperty("yomifirstname", typeof(string)));

                this.FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.")
                    .WithDisplayName("Full Name")
                    .ModelProperty("fullname", typeof(string)));

                this.YomiMiddleName = group.Add(new VocabularyKey("YomiMiddleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.")
                    .WithDisplayName("Yomi Middle Name")
                    .ModelProperty("yomimiddlename", typeof(string)));

                this.YomiLastName = group.Add(new VocabularyKey("YomiLastName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.")
                    .WithDisplayName("Yomi Last Name")
                    .ModelProperty("yomilastname", typeof(string)));

                this.Anniversary = group.Add(new VocabularyKey("Anniversary", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.")
                    .WithDisplayName("Anniversary")
                    .ModelProperty("anniversary", typeof(DateTime)));

                this.BirthDate = group.Add(new VocabularyKey("BirthDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the contact's birthday for use in customer gift programs or other communications.")
                    .WithDisplayName("Birthday")
                    .ModelProperty("birthdate", typeof(DateTime)));

                this.GovernmentId = group.Add(new VocabularyKey("GovernmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the passport number or other government ID for the contact for use in documents or reports.")
                    .WithDisplayName("Government")
                    .ModelProperty("governmentid", typeof(string)));

                this.YomiFullName = group.Add(new VocabularyKey("YomiFullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.")
                    .WithDisplayName("Yomi Full Name")
                    .ModelProperty("yomifullname", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4000))
                    .WithDescription(@"Type additional information to describe the contact, such as an excerpt from the company's website.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.")
                    .WithDisplayName("Employee")
                    .ModelProperty("employeeid", typeof(string)));

                this.GenderCode = group.Add(new VocabularyKey("GenderCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.")
                    .WithDisplayName("Gender")
                    .ModelProperty("gendercode", typeof(string)));

                this.AnnualIncome = group.Add(new VocabularyKey("AnnualIncome", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the contact's annual income for use in profiling and financial analysis.")
                    .WithDisplayName("Annual Income")
                    .ModelProperty("annualincome", typeof(string)));

                this.HasChildrenCode = group.Add(new VocabularyKey("HasChildrenCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact has any children for reference in follow-up phone calls and other communications.")
                    .WithDisplayName("Has Children")
                    .ModelProperty("haschildrencode", typeof(string)));

                this.EducationCode = group.Add(new VocabularyKey("EducationCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the contact's highest level of education for use in segmentation and analysis.")
                    .WithDisplayName("Education")
                    .ModelProperty("educationcode", typeof(string)));

                this.WebSiteUrl = group.Add(new VocabularyKey("WebSiteUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the contact's professional or personal website or blog URL.")
                    .WithDisplayName("Website")
                    .ModelProperty("websiteurl", typeof(string)));

                this.FamilyStatusCode = group.Add(new VocabularyKey("FamilyStatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the marital status of the contact for reference in follow-up phone calls and other communications.")
                    .WithDisplayName("Marital Status")
                    .ModelProperty("familystatuscode", typeof(string)));

                this.FtpSiteUrl = group.Add(new VocabularyKey("FtpSiteUrl", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the URL for the contact's FTP site to enable users to access data and share documents.")
                    .WithDisplayName("FTP Site")
                    .ModelProperty("ftpsiteurl", typeof(string)));

                this.EMailAddress1 = group.Add(new VocabularyKey("EMailAddress1", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the primary email address for the contact.")
                    .WithDisplayName("E-Mail")
                    .ModelProperty("emailaddress1", typeof(string)));

                this.SpousesName = group.Add(new VocabularyKey("SpousesName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.")
                    .WithDisplayName("Spouse/Partner Name")
                    .ModelProperty("spousesname", typeof(string)));

                this.AssistantName = group.Add(new VocabularyKey("AssistantName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the contact's assistant.")
                    .WithDisplayName("Assistant")
                    .ModelProperty("assistantname", typeof(string)));

                this.EMailAddress2 = group.Add(new VocabularyKey("EMailAddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the secondary email address for the contact.")
                    .WithDisplayName("E-Mail 2")
                    .ModelProperty("emailaddress2", typeof(string)));

                this.AssistantPhone = group.Add(new VocabularyKey("AssistantPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the phone number for the contact's assistant.")
                    .WithDisplayName("Assistant Phone")
                    .ModelProperty("assistantphone", typeof(string)));

                this.EMailAddress3 = group.Add(new VocabularyKey("EMailAddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type an alternate email address for the contact.")
                    .WithDisplayName("Email Address 3")
                    .ModelProperty("emailaddress3", typeof(string)));

                this.DoNotPhone = group.Add(new VocabularyKey("DoNotPhone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.")
                    .WithDisplayName("Do not allow Phone Calls")
                    .ModelProperty("donotphone", typeof(bool)));

                this.ManagerName = group.Add(new VocabularyKey("ManagerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.")
                    .WithDisplayName("Manager")
                    .ModelProperty("managername", typeof(string)));

                this.ManagerPhone = group.Add(new VocabularyKey("ManagerPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the phone number for the contact's manager.")
                    .WithDisplayName("Manager Phone")
                    .ModelProperty("managerphone", typeof(string)));

                this.DoNotFax = group.Add(new VocabularyKey("DoNotFax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.")
                    .WithDisplayName("Do not allow Faxes")
                    .ModelProperty("donotfax", typeof(bool)));

                this.DoNotEMail = group.Add(new VocabularyKey("DoNotEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.")
                    .WithDisplayName("Do not allow Emails")
                    .ModelProperty("donotemail", typeof(bool)));

                this.DoNotPostalMail = group.Add(new VocabularyKey("DoNotPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.")
                    .WithDisplayName("Do not allow Mails")
                    .ModelProperty("donotpostalmail", typeof(bool)));

                this.DoNotBulkEMail = group.Add(new VocabularyKey("DoNotBulkEMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.")
                    .WithDisplayName("E-Mail Permission")
                    .ModelProperty("donotbulkemail", typeof(bool)));

                this.DoNotBulkPostalMail = group.Add(new VocabularyKey("DoNotBulkPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.")
                    .WithDisplayName("Do not allow Bulk Mails")
                    .ModelProperty("donotbulkpostalmail", typeof(bool)));

                this.AccountRoleCode = group.Add(new VocabularyKey("AccountRoleCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.")
                    .WithDisplayName("Role")
                    .ModelProperty("accountrolecode", typeof(string)));

                this.TerritoryCode = group.Add(new VocabularyKey("TerritoryCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a region or territory for the contact for use in segmentation and analysis.")
                    .WithDisplayName("Territory")
                    .ModelProperty("territorycode", typeof(string)));

                this.IsPrivate = group.Add(new VocabularyKey("IsPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPrivate")
                    .ModelProperty("isprivate", typeof(bool)));

                this.CreditLimit = group.Add(new VocabularyKey("CreditLimit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.")
                    .WithDisplayName("Credit Limit")
                    .ModelProperty("creditlimit", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreditOnHold = group.Add(new VocabularyKey("CreditOnHold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.")
                    .WithDisplayName("Credit Hold")
                    .ModelProperty("creditonhold", typeof(bool)));

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

                this.NumberOfChildren = group.Add(new VocabularyKey("NumberOfChildren", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of children the contact has for reference in follow-up phone calls and other communications.")
                    .WithDisplayName("No. of Children")
                    .ModelProperty("numberofchildren", typeof(long)));

                this.ChildrensNames = group.Add(new VocabularyKey("ChildrensNames", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"Type the names of the contact's children for reference in communications and client programs.")
                    .WithDisplayName("Children's Names")
                    .ModelProperty("childrensnames", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the contact.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.MobilePhone = group.Add(new VocabularyKey("MobilePhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the Mobile phone number for the contact. Prefix the number with a +country code")
                    .WithDisplayName("Mobile Phone")
                    .ModelProperty("mobilephone", typeof(string)));

                this.Pager = group.Add(new VocabularyKey("Pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the pager number for the contact.")
                    .WithDisplayName("Pager")
                    .ModelProperty("pager", typeof(string)));

                this.Telephone1 = group.Add(new VocabularyKey("Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the main phone number for the contact. Prefix the number with a +country code")
                    .WithDisplayName("Main Phone")
                    .ModelProperty("telephone1", typeof(string)));

                this.Telephone2 = group.Add(new VocabularyKey("Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the Direct phone number for the contact. Prefix the number with a +country code")
                    .WithDisplayName("Direct Phone")
                    .ModelProperty("telephone2", typeof(string)));

                this.Telephone3 = group.Add(new VocabularyKey("Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number for this contact.")
                    .WithDisplayName("Telephone 3")
                    .ModelProperty("telephone3", typeof(string)));

                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number for the contact.")
                    .WithDisplayName("Fax")
                    .ModelProperty("fax", typeof(string)));

                this.Aging30 = group.Add(new VocabularyKey("Aging30", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Aging 30")
                    .ModelProperty("aging30", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.Aging60 = group.Add(new VocabularyKey("Aging60", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Aging 60")
                    .ModelProperty("aging60", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the contact's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.Aging90 = group.Add(new VocabularyKey("Aging90", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Aging 90")
                    .ModelProperty("aging90", typeof(string)));

                this.ParentContactId = group.Add(new VocabularyKey("ParentContactId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the parent contact.")
                    .WithDisplayName("Parent Contact")
                    .ModelProperty("parentcontactid", typeof(string)));

                this.OriginatingLeadIdName = group.Add(new VocabularyKey("OriginatingLeadIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingLeadIdName")
                    .ModelProperty("originatingleadidname", typeof(string)));

                this.ParentContactIdName = group.Add(new VocabularyKey("ParentContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentContactIdName")
                    .ModelProperty("parentcontactidname", typeof(string)));

                this.AccountIdName = group.Add(new VocabularyKey("AccountIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdName")
                    .ModelProperty("accountidname", typeof(string)));

                this.DefaultPriceLevelIdName = group.Add(new VocabularyKey("DefaultPriceLevelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("DefaultPriceLevelIdName")
                    .ModelProperty("defaultpricelevelidname", typeof(string)));

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
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a descriptive name for the primary address, such as Corporate Headquarters.")
                    .WithDisplayName("Address 1: Name")
                    .ModelProperty("address1_name", typeof(string)));

                this.Address1_PrimaryContactName = group.Add(new VocabularyKey("Address1_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the main contact at the account's primary address.")
                    .WithDisplayName("Address 1: Primary Contact Name")
                    .ModelProperty("address1_primarycontactname", typeof(string)));

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
                    .WithDisplayName("Address 1: Country/Region (No NOT Use)")
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

                this.Address1_FreightTermsCode = group.Add(new VocabularyKey("Address1_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms for the primary address to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Address 1: Freight Terms")
                    .ModelProperty("address1_freighttermscode", typeof(string)));

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
                    .WithDisplayName("Address 1: Phone")
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

                this.Address2_PrimaryContactName = group.Add(new VocabularyKey("Address2_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the main contact at the account's secondary address.")
                    .WithDisplayName("Address 2: Primary Contact Name")
                    .ModelProperty("address2_primarycontactname", typeof(string)));

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

                this.Address2_FreightTermsCode = group.Add(new VocabularyKey("Address2_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms for the secondary address to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Address 2: Freight Terms")
                    .ModelProperty("address2_freighttermscode", typeof(string)));

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

                this.DoNotFaxName = group.Add(new VocabularyKey("DoNotFaxName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotFaxName")
                    .ModelProperty("donotfaxname", typeof(string)));

                this.IsBackofficeCustomerName = group.Add(new VocabularyKey("IsBackofficeCustomerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBackofficeCustomerName")
                    .ModelProperty("isbackofficecustomername", typeof(string)));

                this.ParticipatesInWorkflowName = group.Add(new VocabularyKey("ParticipatesInWorkflowName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ParticipatesInWorkflowName")
                    .ModelProperty("participatesinworkflowname", typeof(string)));

                this.DoNotPostalMailName = group.Add(new VocabularyKey("DoNotPostalMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPostalMailName")
                    .ModelProperty("donotpostalmailname", typeof(string)));

                this.CreditOnHoldName = group.Add(new VocabularyKey("CreditOnHoldName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CreditOnHoldName")
                    .ModelProperty("creditonholdname", typeof(string)));

                this.DoNotPhoneName = group.Add(new VocabularyKey("DoNotPhoneName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPhoneName")
                    .ModelProperty("donotphonename", typeof(string)));

                this.DoNotEMailName = group.Add(new VocabularyKey("DoNotEMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotEMailName")
                    .ModelProperty("donotemailname", typeof(string)));

                this.DoNotBulkPostalMailName = group.Add(new VocabularyKey("DoNotBulkPostalMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotBulkPostalMailName")
                    .ModelProperty("donotbulkpostalmailname", typeof(string)));

                this.DoNotBulkEMailName = group.Add(new VocabularyKey("DoNotBulkEMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotBulkEMailName")
                    .ModelProperty("donotbulkemailname", typeof(string)));

                this.Address1_AddressTypeCodeName = group.Add(new VocabularyKey("Address1_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_AddressTypeCodeName")
                    .ModelProperty("address1_addresstypecodename", typeof(string)));

                this.PreferredContactMethodCodeName = group.Add(new VocabularyKey("PreferredContactMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredContactMethodCodeName")
                    .ModelProperty("preferredcontactmethodcodename", typeof(string)));

                this.Address2_AddressTypeCodeName = group.Add(new VocabularyKey("Address2_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_AddressTypeCodeName")
                    .ModelProperty("address2_addresstypecodename", typeof(string)));

                this.CustomerTypeCodeName = group.Add(new VocabularyKey("CustomerTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CustomerTypeCodeName")
                    .ModelProperty("customertypecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.AccountRoleCodeName = group.Add(new VocabularyKey("AccountRoleCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccountRoleCodeName")
                    .ModelProperty("accountrolecodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.HasChildrenCodeName = group.Add(new VocabularyKey("HasChildrenCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("HasChildrenCodeName")
                    .ModelProperty("haschildrencodename", typeof(string)));

                this.TerritoryCodeName = group.Add(new VocabularyKey("TerritoryCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TerritoryCodeName")
                    .ModelProperty("territorycodename", typeof(string)));

                this.Address1_ShippingMethodCodeName = group.Add(new VocabularyKey("Address1_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_ShippingMethodCodeName")
                    .ModelProperty("address1_shippingmethodcodename", typeof(string)));

                this.PaymentTermsCodeName = group.Add(new VocabularyKey("PaymentTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PaymentTermsCodeName")
                    .ModelProperty("paymenttermscodename", typeof(string)));

                this.GenderCodeName = group.Add(new VocabularyKey("GenderCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("GenderCodeName")
                    .ModelProperty("gendercodename", typeof(string)));

                this.Address2_FreightTermsCodeName = group.Add(new VocabularyKey("Address2_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_FreightTermsCodeName")
                    .ModelProperty("address2_freighttermscodename", typeof(string)));

                this.FamilyStatusCodeName = group.Add(new VocabularyKey("FamilyStatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FamilyStatusCodeName")
                    .ModelProperty("familystatuscodename", typeof(string)));

                this.CustomerSizeCodeName = group.Add(new VocabularyKey("CustomerSizeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CustomerSizeCodeName")
                    .ModelProperty("customersizecodename", typeof(string)));

                this.ShippingMethodCodeName = group.Add(new VocabularyKey("ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShippingMethodCodeName")
                    .ModelProperty("shippingmethodcodename", typeof(string)));

                this.Address1_FreightTermsCodeName = group.Add(new VocabularyKey("Address1_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address1_FreightTermsCodeName")
                    .ModelProperty("address1_freighttermscodename", typeof(string)));

                this.LeadSourceCodeName = group.Add(new VocabularyKey("LeadSourceCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeadSourceCodeName")
                    .ModelProperty("leadsourcecodename", typeof(string)));

                this.EducationCodeName = group.Add(new VocabularyKey("EducationCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EducationCodeName")
                    .ModelProperty("educationcodename", typeof(string)));

                this.Address2_ShippingMethodCodeName = group.Add(new VocabularyKey("Address2_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address2_ShippingMethodCodeName")
                    .ModelProperty("address2_shippingmethodcodename", typeof(string)));

                this.PreferredSystemUserId = group.Add(new VocabularyKey("PreferredSystemUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.")
                    .WithDisplayName("Preferred User")
                    .ModelProperty("preferredsystemuserid", typeof(string)));

                this.PreferredServiceId = group.Add(new VocabularyKey("PreferredServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the contact's preferred service to make sure services are scheduled correctly for the customer.")
                    .WithDisplayName("Preferred Service")
                    .ModelProperty("preferredserviceid", typeof(string)));

                this.MasterId = group.Add(new VocabularyKey("MasterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the master contact for merge.")
                    .WithDisplayName("Master ID")
                    .ModelProperty("masterid", typeof(string)));

                this.PreferredAppointmentDayCode = group.Add(new VocabularyKey("PreferredAppointmentDayCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred day of the week for service appointments.")
                    .WithDisplayName("Preferred Day")
                    .ModelProperty("preferredappointmentdaycode", typeof(string)));

                this.PreferredAppointmentTimeCode = group.Add(new VocabularyKey("PreferredAppointmentTimeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the preferred time of day for service appointments.")
                    .WithDisplayName("Preferred Time")
                    .ModelProperty("preferredappointmenttimecode", typeof(string)));

                this.DoNotSendMM = group.Add(new VocabularyKey("DoNotSendMM", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.")
                    .WithDisplayName("Send Marketing Materials")
                    .ModelProperty("donotsendmm", typeof(bool)));

                this.ParentCustomerId = group.Add(new VocabularyKey("ParentCustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.")
                    .WithDisplayName("Company Name")
                    .ModelProperty("parentcustomerid", typeof(string)));

                this.Merged = group.Add(new VocabularyKey("Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether the account has been merged with a master contact.")
                    .WithDisplayName("Merged")
                    .ModelProperty("merged", typeof(bool)));

                this.ExternalUserIdentifier = group.Add(new VocabularyKey("ExternalUserIdentifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Identifier for an external user.")
                    .WithDisplayName("External User Identifier")
                    .ModelProperty("externaluseridentifier", typeof(string)));

                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Subscription")
                    .ModelProperty("subscriptionid", typeof(Guid)));

                this.PreferredEquipmentId = group.Add(new VocabularyKey("PreferredEquipmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.")
                    .WithDisplayName("Preferred Facility/Equipment")
                    .ModelProperty("preferredequipmentid", typeof(string)));

                this.LastUsedInCampaign = group.Add(new VocabularyKey("LastUsedInCampaign", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date when the contact was last included in a marketing campaign or quick campaign.")
                    .WithDisplayName("Last Campaign Date")
                    .ModelProperty("lastusedincampaign", typeof(DateTime)));

                this.MasterContactIdName = group.Add(new VocabularyKey("MasterContactIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterContactIdName")
                    .ModelProperty("mastercontactidname", typeof(string)));

                this.PreferredSystemUserIdName = group.Add(new VocabularyKey("PreferredSystemUserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredSystemUserIdName")
                    .ModelProperty("preferredsystemuseridname", typeof(string)));

                this.MergedName = group.Add(new VocabularyKey("MergedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MergedName")
                    .ModelProperty("mergedname", typeof(string)));

                this.PreferredAppointmentTimeCodeName = group.Add(new VocabularyKey("PreferredAppointmentTimeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredAppointmentTimeCodeName")
                    .ModelProperty("preferredappointmenttimecodename", typeof(string)));

                this.PreferredEquipmentIdName = group.Add(new VocabularyKey("PreferredEquipmentIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredEquipmentIdName")
                    .ModelProperty("preferredequipmentidname", typeof(string)));

                this.ParentCustomerIdName = group.Add(new VocabularyKey("ParentCustomerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("ParentCustomerIdName")
                    .ModelProperty("parentcustomeridname", typeof(string)));

                this.PreferredAppointmentDayCodeName = group.Add(new VocabularyKey("PreferredAppointmentDayCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PreferredAppointmentDayCodeName")
                    .ModelProperty("preferredappointmentdaycodename", typeof(string)));

                this.PreferredServiceIdName = group.Add(new VocabularyKey("PreferredServiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredServiceIdName")
                    .ModelProperty("preferredserviceidname", typeof(string)));

                this.ParentCustomerIdType = group.Add(new VocabularyKey("ParentCustomerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Parent Customer Type")
                    .ModelProperty("parentcustomeridtype", typeof(string)));

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

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

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

                this.AnnualIncome_Base = group.Add(new VocabularyKey("AnnualIncome_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Annual Income (Base)")
                    .ModelProperty("annualincome_base", typeof(string)));

                this.CreditLimit_Base = group.Add(new VocabularyKey("CreditLimit_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Credit Limit (Base)")
                    .ModelProperty("creditlimit_base", typeof(string)));

                this.Aging60_Base = group.Add(new VocabularyKey("Aging60_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Aging 60 (Base)")
                    .ModelProperty("aging60_base", typeof(string)));

                this.Aging90_Base = group.Add(new VocabularyKey("Aging90_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Aging 90 (Base)")
                    .ModelProperty("aging90_base", typeof(string)));

                this.Aging30_Base = group.Add(new VocabularyKey("Aging30_Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.")
                    .WithDisplayName("Aging 30 (Base)")
                    .ModelProperty("aging30_base", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.OriginatingLeadIdYomiName = group.Add(new VocabularyKey("OriginatingLeadIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OriginatingLeadIdYomiName")
                    .ModelProperty("originatingleadidyominame", typeof(string)));

                this.ParentCustomerIdYomiName = group.Add(new VocabularyKey("ParentCustomerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(450))
                    .WithDescription(@"")
                    .WithDisplayName("ParentCustomerIdYomiName")
                    .ModelProperty("parentcustomeridyominame", typeof(string)));

                this.PreferredSystemUserIdYomiName = group.Add(new VocabularyKey("PreferredSystemUserIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreferredSystemUserIdYomiName")
                    .ModelProperty("preferredsystemuseridyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.MasterContactIdYomiName = group.Add(new VocabularyKey("MasterContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("MasterContactIdYomiName")
                    .ModelProperty("mastercontactidyominame", typeof(string)));

                this.AccountIdYomiName = group.Add(new VocabularyKey("AccountIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AccountIdYomiName")
                    .ModelProperty("accountidyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ParentContactIdYomiName = group.Add(new VocabularyKey("ParentContactIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentContactIdYomiName")
                    .ModelProperty("parentcontactidyominame", typeof(string)));

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
                    .WithDescription(@"Unique identifier of the team who owns the contact.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.IsAutoCreate = group.Add(new VocabularyKey("IsAutoCreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the contact was auto-created when promoting an email or an appointment.")
                    .WithDisplayName("Auto-created")
                    .ModelProperty("isautocreate", typeof(bool)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default image for the record.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
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

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the service level agreement (SLA) that you want to apply to the Contact record.")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last SLA that was applied to this case. This field is for internal use only.")
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
                    .WithDescription(@"Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.")
                    .WithDisplayName("Follow Email Activity")
                    .ModelProperty("followemail", typeof(bool)));

                this.FollowEmailName = group.Add(new VocabularyKey("FollowEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FollowEmailName")
                    .ModelProperty("followemailname", typeof(string)));

                this.TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey("TimeSpentByMeOnEmailAndMeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1250))
                    .WithDescription(@"Total time spent for emails (read and write) and meetings by me in relation to the contact record.")
                    .WithDisplayName("Time Spent by me")
                    .ModelProperty("timespentbymeonemailandmeetings", typeof(string)));

                this.Address3_Country = group.Add(new VocabularyKey("Address3_Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"the country or region for the 3rd address.")
                    .WithDisplayName("Address3: Country/Region")
                    .ModelProperty("address3_country", typeof(string)));

                this.Address3_Line1 = group.Add(new VocabularyKey("Address3_Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"the first line of the 3rd address.")
                    .WithDisplayName("Address3: Street 1")
                    .ModelProperty("address3_line1", typeof(string)));

                this.Address3_Line2 = group.Add(new VocabularyKey("Address3_Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"the second line of the 3rd address.")
                    .WithDisplayName("Address3: Street 2")
                    .ModelProperty("address3_line2", typeof(string)));

                this.Address3_Line3 = group.Add(new VocabularyKey("Address3_Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"the third line of the 3rd address.")
                    .WithDisplayName("Address 3: Street 3")
                    .ModelProperty("address3_line3", typeof(string)));

                this.Address3_PostalCode = group.Add(new VocabularyKey("Address3_PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"the ZIP Code or postal code for the 3rd address.")
                    .WithDisplayName("Address3: ZIP/Postal Code")
                    .ModelProperty("address3_postalcode", typeof(string)));

                this.Address3_PostOfficeBox = group.Add(new VocabularyKey("Address3_PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"the post office box number of the 3rd address.")
                    .WithDisplayName("Address 3: Post Office Box")
                    .ModelProperty("address3_postofficebox", typeof(string)));

                this.Address3_StateOrProvince = group.Add(new VocabularyKey("Address3_StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"the state or province of the third address.")
                    .WithDisplayName("Address3: State/Province")
                    .ModelProperty("address3_stateorprovince", typeof(string)));

                this.Address3_City = group.Add(new VocabularyKey("Address3_City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Type the city for the 3rd address.")
                    .WithDisplayName("Address 3: City")
                    .ModelProperty("address3_city", typeof(string)));

                this.Business2 = group.Add(new VocabularyKey("Business2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second business phone number for this contact.")
                    .WithDisplayName("Business Phone 2")
                    .ModelProperty("business2", typeof(string)));

                this.Callback = group.Add(new VocabularyKey("Callback", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a callback phone number for this contact.")
                    .WithDisplayName("Callback Number")
                    .ModelProperty("callback", typeof(string)));

                this.Company = group.Add(new VocabularyKey("Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the company phone of the contact.")
                    .WithDisplayName("Company Phone")
                    .ModelProperty("company", typeof(string)));

                this.Home2 = group.Add(new VocabularyKey("Home2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second home phone number for this contact.")
                    .WithDisplayName("Home Phone 2")
                    .ModelProperty("home2", typeof(string)));

                this.Address3_AddressId = group.Add(new VocabularyKey("Address3_AddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for address 3.")
                    .WithDisplayName("Address 3: ID")
                    .ModelProperty("address3_addressid", typeof(Guid)));

                this.Address3_AddressTypeCodeName = group.Add(new VocabularyKey("Address3_AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address3_AddressTypeCodeName")
                    .ModelProperty("address3_addresstypecodename", typeof(string)));

                this.Address3_Composite = group.Add(new VocabularyKey("Address3_Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Shows the complete third address.")
                    .WithDisplayName("Address 3")
                    .ModelProperty("address3_composite", typeof(string)));

                this.Address3_Fax = group.Add(new VocabularyKey("Address3_Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the fax number associated with the third address.")
                    .WithDisplayName("Address 3: Fax")
                    .ModelProperty("address3_fax", typeof(string)));

                this.Address3_FreightTermsCode = group.Add(new VocabularyKey("Address3_FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the freight terms for the third address to make sure shipping orders are processed correctly.")
                    .WithDisplayName("Address 3: Freight Terms")
                    .ModelProperty("address3_freighttermscode", typeof(string)));

                this.Address3_FreightTermsCodeName = group.Add(new VocabularyKey("Address3_FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address3_FreightTermsCodeName")
                    .ModelProperty("address3_freighttermscodename", typeof(string)));

                this.Address3_Latitude = group.Add(new VocabularyKey("Address3_Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the latitude value for the third address for use in mapping and other applications.")
                    .WithDisplayName("Address 3: Latitude")
                    .ModelProperty("address3_latitude", typeof(double)));

                this.Address3_Longitude = group.Add(new VocabularyKey("Address3_Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the longitude value for the third address for use in mapping and other applications.")
                    .WithDisplayName("Address 3: Longitude")
                    .ModelProperty("address3_longitude", typeof(double)));

                this.Address3_Name = group.Add(new VocabularyKey("Address3_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a descriptive name for the third address, such as Corporate Headquarters.")
                    .WithDisplayName("Address 3: Name")
                    .ModelProperty("address3_name", typeof(string)));

                this.Address3_PrimaryContactName = group.Add(new VocabularyKey("Address3_PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the name of the main contact at the account's third address.")
                    .WithDisplayName("Address 3: Primary Contact Name")
                    .ModelProperty("address3_primarycontactname", typeof(string)));

                this.Address3_ShippingMethodCode = group.Add(new VocabularyKey("Address3_ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select a shipping method for deliveries sent to this address.")
                    .WithDisplayName("Address 3: Shipping Method")
                    .ModelProperty("address3_shippingmethodcode", typeof(string)));

                this.Address3_ShippingMethodCodeName = group.Add(new VocabularyKey("Address3_ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Address3_ShippingMethodCodeName")
                    .ModelProperty("address3_shippingmethodcodename", typeof(string)));

                this.Address3_Telephone1 = group.Add(new VocabularyKey("Address3_Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the main phone number associated with the third address.")
                    .WithDisplayName("Address 3: Telephone1")
                    .ModelProperty("address3_telephone1", typeof(string)));

                this.Address3_Telephone2 = group.Add(new VocabularyKey("Address3_Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a second phone number associated with the third address.")
                    .WithDisplayName("Address 3: Telephone2")
                    .ModelProperty("address3_telephone2", typeof(string)));

                this.Address3_Telephone3 = group.Add(new VocabularyKey("Address3_Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type a third phone number associated with the primary address.")
                    .WithDisplayName("Address 3: Telephone3")
                    .ModelProperty("address3_telephone3", typeof(string)));

                this.Address3_UPSZone = group.Add(new VocabularyKey("Address3_UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.")
                    .WithDisplayName("Address 3: UPS Zone")
                    .ModelProperty("address3_upszone", typeof(string)));

                this.Address3_UTCOffset = group.Add(new VocabularyKey("Address3_UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.")
                    .WithDisplayName("Address 3: UTC Offset")
                    .ModelProperty("address3_utcoffset", typeof(long)));

                this.Address3_County = group.Add(new VocabularyKey("Address3_County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Type the county for the third address.")
                    .WithDisplayName("Address 3: County")
                    .ModelProperty("address3_county", typeof(string)));

                this.Address3_AddressTypeCode = group.Add(new VocabularyKey("Address3_AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the third address type.")
                    .WithDisplayName("Address 3: Address Type")
                    .ModelProperty("address3_addresstypecode", typeof(string)));

                this.CreatedByExternalParty = group.Add(new VocabularyKey("CreatedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the external party who created the record.")
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
                    .WithDescription(@"Shows the external party who modified the record.")
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

                this.MarketingOnly = group.Add(new VocabularyKey("MarketingOnly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether is only for marketing")
                    .WithDisplayName("Marketing Only")
                    .ModelProperty("marketingonly", typeof(bool)));

                this.MarketingOnlyName = group.Add(new VocabularyKey("MarketingOnlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MarketingOnlyName")
                    .ModelProperty("marketingonlyname", typeof(string)));

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

        public VocabularyKey ContactId { get; private set; }

        public VocabularyKey DefaultPriceLevelId { get; private set; }

        public VocabularyKey CustomerSizeCode { get; private set; }

        public VocabularyKey CustomerTypeCode { get; private set; }

        public VocabularyKey PreferredContactMethodCode { get; private set; }

        public VocabularyKey LeadSourceCode { get; private set; }

        public VocabularyKey OriginatingLeadId { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey PaymentTermsCode { get; private set; }

        public VocabularyKey ShippingMethodCode { get; private set; }

        public VocabularyKey AccountId { get; private set; }

        public VocabularyKey ParticipatesInWorkflow { get; private set; }

        public VocabularyKey IsBackofficeCustomer { get; private set; }

        public VocabularyKey Salutation { get; private set; }

        public VocabularyKey JobTitle { get; private set; }

        public VocabularyKey FirstName { get; private set; }

        public VocabularyKey Department { get; private set; }

        public VocabularyKey NickName { get; private set; }

        public VocabularyKey MiddleName { get; private set; }

        public VocabularyKey LastName { get; private set; }

        public VocabularyKey Suffix { get; private set; }

        public VocabularyKey YomiFirstName { get; private set; }

        public VocabularyKey FullName { get; private set; }

        public VocabularyKey YomiMiddleName { get; private set; }

        public VocabularyKey YomiLastName { get; private set; }

        public VocabularyKey Anniversary { get; private set; }

        public VocabularyKey BirthDate { get; private set; }

        public VocabularyKey GovernmentId { get; private set; }

        public VocabularyKey YomiFullName { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey EmployeeId { get; private set; }

        public VocabularyKey GenderCode { get; private set; }

        public VocabularyKey AnnualIncome { get; private set; }

        public VocabularyKey HasChildrenCode { get; private set; }

        public VocabularyKey EducationCode { get; private set; }

        public VocabularyKey WebSiteUrl { get; private set; }

        public VocabularyKey FamilyStatusCode { get; private set; }

        public VocabularyKey FtpSiteUrl { get; private set; }

        public VocabularyKey EMailAddress1 { get; private set; }

        public VocabularyKey SpousesName { get; private set; }

        public VocabularyKey AssistantName { get; private set; }

        public VocabularyKey EMailAddress2 { get; private set; }

        public VocabularyKey AssistantPhone { get; private set; }

        public VocabularyKey EMailAddress3 { get; private set; }

        public VocabularyKey DoNotPhone { get; private set; }

        public VocabularyKey ManagerName { get; private set; }

        public VocabularyKey ManagerPhone { get; private set; }

        public VocabularyKey DoNotFax { get; private set; }

        public VocabularyKey DoNotEMail { get; private set; }

        public VocabularyKey DoNotPostalMail { get; private set; }

        public VocabularyKey DoNotBulkEMail { get; private set; }

        public VocabularyKey DoNotBulkPostalMail { get; private set; }

        public VocabularyKey AccountRoleCode { get; private set; }

        public VocabularyKey TerritoryCode { get; private set; }

        public VocabularyKey IsPrivate { get; private set; }

        public VocabularyKey CreditLimit { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreditOnHold { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey NumberOfChildren { get; private set; }

        public VocabularyKey ChildrensNames { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey MobilePhone { get; private set; }

        public VocabularyKey Pager { get; private set; }

        public VocabularyKey Telephone1 { get; private set; }

        public VocabularyKey Telephone2 { get; private set; }

        public VocabularyKey Telephone3 { get; private set; }

        public VocabularyKey Fax { get; private set; }

        public VocabularyKey Aging30 { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey Aging60 { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey Aging90 { get; private set; }

        public VocabularyKey ParentContactId { get; private set; }

        public VocabularyKey OriginatingLeadIdName { get; private set; }

        public VocabularyKey ParentContactIdName { get; private set; }

        public VocabularyKey AccountIdName { get; private set; }

        public VocabularyKey DefaultPriceLevelIdName { get; private set; }

        public VocabularyKey Address1_AddressId { get; private set; }

        public VocabularyKey Address1_AddressTypeCode { get; private set; }

        public VocabularyKey Address1_Name { get; private set; }

        public VocabularyKey Address1_PrimaryContactName { get; private set; }

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

        public VocabularyKey Address1_FreightTermsCode { get; private set; }

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

        public VocabularyKey Address2_PrimaryContactName { get; private set; }

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

        public VocabularyKey Address2_FreightTermsCode { get; private set; }

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

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey IsPrivateName { get; private set; }

        public VocabularyKey DoNotFaxName { get; private set; }

        public VocabularyKey IsBackofficeCustomerName { get; private set; }

        public VocabularyKey ParticipatesInWorkflowName { get; private set; }

        public VocabularyKey DoNotPostalMailName { get; private set; }

        public VocabularyKey CreditOnHoldName { get; private set; }

        public VocabularyKey DoNotPhoneName { get; private set; }

        public VocabularyKey DoNotEMailName { get; private set; }

        public VocabularyKey DoNotBulkPostalMailName { get; private set; }

        public VocabularyKey DoNotBulkEMailName { get; private set; }

        public VocabularyKey Address1_AddressTypeCodeName { get; private set; }

        public VocabularyKey PreferredContactMethodCodeName { get; private set; }

        public VocabularyKey Address2_AddressTypeCodeName { get; private set; }

        public VocabularyKey CustomerTypeCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey AccountRoleCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey HasChildrenCodeName { get; private set; }

        public VocabularyKey TerritoryCodeName { get; private set; }

        public VocabularyKey Address1_ShippingMethodCodeName { get; private set; }

        public VocabularyKey PaymentTermsCodeName { get; private set; }

        public VocabularyKey GenderCodeName { get; private set; }

        public VocabularyKey Address2_FreightTermsCodeName { get; private set; }

        public VocabularyKey FamilyStatusCodeName { get; private set; }

        public VocabularyKey CustomerSizeCodeName { get; private set; }

        public VocabularyKey ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address1_FreightTermsCodeName { get; private set; }

        public VocabularyKey LeadSourceCodeName { get; private set; }

        public VocabularyKey EducationCodeName { get; private set; }

        public VocabularyKey Address2_ShippingMethodCodeName { get; private set; }

        public VocabularyKey PreferredSystemUserId { get; private set; }

        public VocabularyKey PreferredServiceId { get; private set; }

        public VocabularyKey MasterId { get; private set; }

        public VocabularyKey PreferredAppointmentDayCode { get; private set; }

        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }

        public VocabularyKey DoNotSendMM { get; private set; }

        public VocabularyKey ParentCustomerId { get; private set; }

        public VocabularyKey Merged { get; private set; }

        public VocabularyKey ExternalUserIdentifier { get; private set; }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey PreferredEquipmentId { get; private set; }

        public VocabularyKey LastUsedInCampaign { get; private set; }

        public VocabularyKey MasterContactIdName { get; private set; }

        public VocabularyKey PreferredSystemUserIdName { get; private set; }

        public VocabularyKey MergedName { get; private set; }

        public VocabularyKey PreferredAppointmentTimeCodeName { get; private set; }

        public VocabularyKey PreferredEquipmentIdName { get; private set; }

        public VocabularyKey ParentCustomerIdName { get; private set; }

        public VocabularyKey PreferredAppointmentDayCodeName { get; private set; }

        public VocabularyKey PreferredServiceIdName { get; private set; }

        public VocabularyKey ParentCustomerIdType { get; private set; }

        public VocabularyKey DoNotSendMarketingMaterialName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey AnnualIncome_Base { get; private set; }

        public VocabularyKey CreditLimit_Base { get; private set; }

        public VocabularyKey Aging60_Base { get; private set; }

        public VocabularyKey Aging90_Base { get; private set; }

        public VocabularyKey Aging30_Base { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey OriginatingLeadIdYomiName { get; private set; }

        public VocabularyKey ParentCustomerIdYomiName { get; private set; }

        public VocabularyKey PreferredSystemUserIdYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey MasterContactIdYomiName { get; private set; }

        public VocabularyKey AccountIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ParentContactIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey IsAutoCreate { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey Address2_Composite { get; private set; }

        public VocabularyKey Address1_Composite { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey FollowEmail { get; private set; }

        public VocabularyKey FollowEmailName { get; private set; }

        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }

        public VocabularyKey Address3_Country { get; private set; }

        public VocabularyKey Address3_Line1 { get; private set; }

        public VocabularyKey Address3_Line2 { get; private set; }

        public VocabularyKey Address3_Line3 { get; private set; }

        public VocabularyKey Address3_PostalCode { get; private set; }

        public VocabularyKey Address3_PostOfficeBox { get; private set; }

        public VocabularyKey Address3_StateOrProvince { get; private set; }

        public VocabularyKey Address3_City { get; private set; }

        public VocabularyKey Business2 { get; private set; }

        public VocabularyKey Callback { get; private set; }

        public VocabularyKey Company { get; private set; }

        public VocabularyKey Home2 { get; private set; }

        public VocabularyKey Address3_AddressId { get; private set; }

        public VocabularyKey Address3_AddressTypeCodeName { get; private set; }

        public VocabularyKey Address3_Composite { get; private set; }

        public VocabularyKey Address3_Fax { get; private set; }

        public VocabularyKey Address3_FreightTermsCode { get; private set; }

        public VocabularyKey Address3_FreightTermsCodeName { get; private set; }

        public VocabularyKey Address3_Latitude { get; private set; }

        public VocabularyKey Address3_Longitude { get; private set; }

        public VocabularyKey Address3_Name { get; private set; }

        public VocabularyKey Address3_PrimaryContactName { get; private set; }

        public VocabularyKey Address3_ShippingMethodCode { get; private set; }

        public VocabularyKey Address3_ShippingMethodCodeName { get; private set; }

        public VocabularyKey Address3_Telephone1 { get; private set; }

        public VocabularyKey Address3_Telephone2 { get; private set; }

        public VocabularyKey Address3_Telephone3 { get; private set; }

        public VocabularyKey Address3_UPSZone { get; private set; }

        public VocabularyKey Address3_UTCOffset { get; private set; }

        public VocabularyKey Address3_County { get; private set; }

        public VocabularyKey Address3_AddressTypeCode { get; private set; }

        public VocabularyKey CreatedByExternalParty { get; private set; }

        public VocabularyKey CreatedByExternalPartyName { get; private set; }

        public VocabularyKey CreatedByExternalPartyYomiName { get; private set; }

        public VocabularyKey ModifiedByExternalParty { get; private set; }

        public VocabularyKey ModifiedByExternalPartyName { get; private set; }

        public VocabularyKey ModifiedByExternalPartyYomiName { get; private set; }

        public VocabularyKey MarketingOnly { get; private set; }

        public VocabularyKey MarketingOnlyName { get; private set; }

        public VocabularyKey TeamsFollowed { get; private set; }

        public VocabularyKey BusinessCard { get; private set; }

        public VocabularyKey BusinessCardAttributes { get; private set; }


    }
}

