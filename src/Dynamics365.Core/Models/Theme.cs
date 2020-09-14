using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Theme : DynamicsModel
    {
        [JsonProperty("themeid")]
        public Guid? ThemeId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("statecode")]
        public string statecode { get; set; }

        [JsonProperty("statecodename")]
        public string statecodeName { get; set; }

        [JsonProperty("statuscode")]
        public string statuscode { get; set; }

        [JsonProperty("statuscodename")]
        public string statuscodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("globallinkcolor")]
        public string GlobalLinkColor { get; set; }

        [JsonProperty("selectedlinkeffect")]
        public string SelectedLinkEffect { get; set; }

        [JsonProperty("hoverlinkeffect")]
        public string HoverLinkEffect { get; set; }

        [JsonProperty("navbarbackgroundcolor")]
        public string NavBarBackgroundColor { get; set; }

        [JsonProperty("navbarshelfcolor")]
        public string NavBarShelfColor { get; set; }

        [JsonProperty("logotooltip")]
        public string LogoToolTip { get; set; }

        [JsonProperty("controlshade")]
        public string ControlShade { get; set; }

        [JsonProperty("controlborder")]
        public string ControlBorder { get; set; }

        [JsonProperty("processcontrolcolor")]
        public string ProcessControlColor { get; set; }

        [JsonProperty("type")]
        public bool? Type { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("isdefaulttheme")]
        public bool? IsDefaultTheme { get; set; }

        [JsonProperty("isdefaultthemename")]
        public string IsDefaultThemeName { get; set; }

        [JsonProperty("logoid")]
        public string LogoId { get; set; }

        [JsonProperty("backgroundcolor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("defaultentitycolor")]
        public string DefaultEntityColor { get; set; }

        [JsonProperty("logoidname")]
        public string LogoIdName { get; set; }

        [JsonProperty("headercolor")]
        public string HeaderColor { get; set; }

        [JsonProperty("defaultcustomentitycolor")]
        public string DefaultCustomEntityColor { get; set; }

        [JsonProperty("pageheaderbackgroundcolor")]
        public string PageHeaderBackgroundColor { get; set; }

        [JsonProperty("panelheaderbackgroundcolor")]
        public string PanelHeaderBackgroundColor { get; set; }

        [JsonProperty("maincolor")]
        public string MainColor { get; set; }

        [JsonProperty("accentcolor")]
        public string AccentColor { get; set; }


    }
}

