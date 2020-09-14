using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ThemeVocabulary : SimpleVocabulary
    {
        public ThemeVocabulary()
        {
            VocabularyName = "Dynamics365 Theme";
            KeyPrefix = "dynamics365.theme";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Theme", group =>
            {
                this.ThemeId = group.Add(new VocabularyKey("ThemeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Theme")
                    .ModelProperty("themeid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

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
                    .WithDescription(@"Unique identifier for the organization")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status of the Theme")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.statecodeName = group.Add(new VocabularyKey("statecodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("statecodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the Theme")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.statuscodeName = group.Add(new VocabularyKey("statuscodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("statuscodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

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

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The name of the Theme Entity.")
                    .WithDisplayName("Theme Name")
                    .ModelProperty("name", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the Theme with respect to the base currency.")
                    .WithDisplayName("ExchangeRate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Exchange rate for the currency associated with the Theme with respect to the base currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.GlobalLinkColor = group.Add(new VocabularyKey("GlobalLinkColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the color for all links, such as e-mail address and lookup links, and for all buttons that are in focus")
                    .WithDisplayName("Link and Button Text Color")
                    .ModelProperty("globallinkcolor", typeof(string)));

                this.SelectedLinkEffect = group.Add(new VocabularyKey("SelectedLinkEffect", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the color that commands or lists will use to indicate selected items")
                    .WithDisplayName("Selected Link Color")
                    .ModelProperty("selectedlinkeffect", typeof(string)));

                this.HoverLinkEffect = group.Add(new VocabularyKey("HoverLinkEffect", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the color that commands or lists will use to indicate hovered over items")
                    .WithDisplayName("Hover Link Color")
                    .ModelProperty("hoverlinkeffect", typeof(string)));

                this.NavBarBackgroundColor = group.Add(new VocabularyKey("NavBarBackgroundColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the primary Navigation Bar background color")
                    .WithDisplayName("Navigation Bar Fill Color")
                    .ModelProperty("navbarbackgroundcolor", typeof(string)));

                this.NavBarShelfColor = group.Add(new VocabularyKey("NavBarShelfColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the secondary Navigation Bar background color")
                    .WithDisplayName("Navigation Bar Shelf Fill Color")
                    .ModelProperty("navbarshelfcolor", typeof(string)));

                this.LogoToolTip = group.Add(new VocabularyKey("LogoToolTip", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Enter text that will be used as the tooltip and alt text for the logo.")
                    .WithDisplayName("Logo Tooltip")
                    .ModelProperty("logotooltip", typeof(string)));

                this.ControlShade = group.Add(new VocabularyKey("ControlShade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the background color for controls to use to indicate when you hover over items")
                    .WithDisplayName("Control Hover Fill Color")
                    .ModelProperty("controlshade", typeof(string)));

                this.ControlBorder = group.Add(new VocabularyKey("ControlBorder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the color that controls will use for borders")
                    .WithDisplayName("Control Hover Border Color")
                    .ModelProperty("controlborder", typeof(string)));

                this.ProcessControlColor = group.Add(new VocabularyKey("ProcessControlColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the primary background color for process controls")
                    .WithDisplayName("Legacy Accent Color")
                    .ModelProperty("processcontrolcolor", typeof(string)));

                this.Type = group.Add(new VocabularyKey("Type", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Define type of theme.")
                    .WithDisplayName("Type")
                    .ModelProperty("type", typeof(bool)));

                this.TypeName = group.Add(new VocabularyKey("TypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TypeName")
                    .ModelProperty("typename", typeof(string)));

                this.IsDefaultTheme = group.Add(new VocabularyKey("IsDefaultTheme", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Default status of theme.")
                    .WithDisplayName("Default Theme")
                    .ModelProperty("isdefaulttheme", typeof(bool)));

                this.IsDefaultThemeName = group.Add(new VocabularyKey("IsDefaultThemeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDefaultThemeName")
                    .ModelProperty("isdefaultthemename", typeof(string)));

                this.LogoId = group.Add(new VocabularyKey("LogoId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Upload a web resource to use as a logo. Recommended dimensions are a height of 50 pixels and a maximum width of 400 pixels.")
                    .WithDisplayName("Logo")
                    .ModelProperty("logoid", typeof(string)));

                this.BackgroundColor = group.Add(new VocabularyKey("BackgroundColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Background Color")
                    .ModelProperty("backgroundcolor", typeof(string)));

                this.DefaultEntityColor = group.Add(new VocabularyKey("DefaultEntityColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the default color for system entities if no color is assigned")
                    .WithDisplayName("Default Entity Color")
                    .ModelProperty("defaultentitycolor", typeof(string)));

                this.LogoIdName = group.Add(new VocabularyKey("LogoIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("LogoIdName")
                    .ModelProperty("logoidname", typeof(string)));

                this.HeaderColor = group.Add(new VocabularyKey("HeaderColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the color for title text, such as form tab labels")
                    .WithDisplayName("Title Text Color")
                    .ModelProperty("headercolor", typeof(string)));

                this.DefaultCustomEntityColor = group.Add(new VocabularyKey("DefaultCustomEntityColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the default custom entity color if no color is assigned")
                    .WithDisplayName("Default Custom Entity Color")
                    .ModelProperty("defaultcustomentitycolor", typeof(string)));

                this.PageHeaderBackgroundColor = group.Add(new VocabularyKey("PageHeaderBackgroundColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the page header background color")
                    .WithDisplayName("Page Header Fill Color")
                    .ModelProperty("pageheaderbackgroundcolor", typeof(string)));

                this.PanelHeaderBackgroundColor = group.Add(new VocabularyKey("PanelHeaderBackgroundColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the panel header background color")
                    .WithDisplayName("Panel Header Fill Color")
                    .ModelProperty("panelheaderbackgroundcolor", typeof(string)));

                this.MainColor = group.Add(new VocabularyKey("MainColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the Unified Interface primary theme color to be used on main command bar, buttons and tabs")
                    .WithDisplayName("Main Color")
                    .ModelProperty("maincolor", typeof(string)));

                this.AccentColor = group.Add(new VocabularyKey("AccentColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(7))
                    .WithDescription(@"Choose the Unified Interface secondary theme color to be used on the process control")
                    .WithDisplayName("Accent Color")
                    .ModelProperty("accentcolor", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ThemeId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey statecode { get; private set; }

        public VocabularyKey statecodeName { get; private set; }

        public VocabularyKey statuscode { get; private set; }

        public VocabularyKey statuscodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey GlobalLinkColor { get; private set; }

        public VocabularyKey SelectedLinkEffect { get; private set; }

        public VocabularyKey HoverLinkEffect { get; private set; }

        public VocabularyKey NavBarBackgroundColor { get; private set; }

        public VocabularyKey NavBarShelfColor { get; private set; }

        public VocabularyKey LogoToolTip { get; private set; }

        public VocabularyKey ControlShade { get; private set; }

        public VocabularyKey ControlBorder { get; private set; }

        public VocabularyKey ProcessControlColor { get; private set; }

        public VocabularyKey Type { get; private set; }

        public VocabularyKey TypeName { get; private set; }

        public VocabularyKey IsDefaultTheme { get; private set; }

        public VocabularyKey IsDefaultThemeName { get; private set; }

        public VocabularyKey LogoId { get; private set; }

        public VocabularyKey BackgroundColor { get; private set; }

        public VocabularyKey DefaultEntityColor { get; private set; }

        public VocabularyKey LogoIdName { get; private set; }

        public VocabularyKey HeaderColor { get; private set; }

        public VocabularyKey DefaultCustomEntityColor { get; private set; }

        public VocabularyKey PageHeaderBackgroundColor { get; private set; }

        public VocabularyKey PanelHeaderBackgroundColor { get; private set; }

        public VocabularyKey MainColor { get; private set; }

        public VocabularyKey AccentColor { get; private set; }


    }
}

