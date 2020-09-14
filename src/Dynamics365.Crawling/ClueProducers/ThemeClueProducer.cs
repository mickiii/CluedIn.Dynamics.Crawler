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
    public abstract class ThemeClueProducer<T> : DynamicsClueProducer<T> where T : Theme
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ThemeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ThemeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=theme&id={1}", _dynamics365CrawlJobData.Api, input.ThemeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.LogoId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.webresource, EntityEdgeType.Parent, input, input.LogoId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.Theme.ThemeId] = input.ThemeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.GlobalLinkColor] = input.GlobalLinkColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.SelectedLinkEffect] = input.SelectedLinkEffect.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.HoverLinkEffect] = input.HoverLinkEffect.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.NavBarBackgroundColor] = input.NavBarBackgroundColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.NavBarShelfColor] = input.NavBarShelfColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.LogoToolTip] = input.LogoToolTip.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ControlShade] = input.ControlShade.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ControlBorder] = input.ControlBorder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.ProcessControlColor] = input.ProcessControlColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.Type] = input.Type.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.TypeName] = input.TypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.IsDefaultTheme] = input.IsDefaultTheme.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.IsDefaultThemeName] = input.IsDefaultThemeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.LogoId] = input.LogoId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.BackgroundColor] = input.BackgroundColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.DefaultEntityColor] = input.DefaultEntityColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.LogoIdName] = input.LogoIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.HeaderColor] = input.HeaderColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.DefaultCustomEntityColor] = input.DefaultCustomEntityColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.PageHeaderBackgroundColor] = input.PageHeaderBackgroundColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.PanelHeaderBackgroundColor] = input.PanelHeaderBackgroundColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.MainColor] = input.MainColor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Theme.AccentColor] = input.AccentColor.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

