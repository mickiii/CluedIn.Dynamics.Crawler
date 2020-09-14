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
    public abstract class PluginAssemblyClueProducer<T> : DynamicsClueProducer<T> where T : PluginAssembly
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PluginAssemblyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PluginAssemblyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=pluginassembly&id={1}", _dynamics365CrawlJobData.Api, input.PluginAssemblyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.PluginAssembly.SourceHash] = input.SourceHash.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Content] = input.Content.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Path] = input.Path.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.PluginAssemblyId] = input.PluginAssemblyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Culture] = input.Culture.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.SourceType] = input.SourceType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.PluginAssemblyIdUnique] = input.PluginAssemblyIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.PublicKeyToken] = input.PublicKeyToken.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsolationMode] = input.IsolationMode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsolationModeName] = input.IsolationModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.SourceTypeName] = input.SourceTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Major] = input.Major.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Minor] = input.Minor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsHidden] = input.IsHidden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.AuthType] = input.AuthType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.AuthTypeName] = input.AuthTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.UserName] = input.UserName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Password] = input.Password.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.IsPasswordSet] = input.IsPasswordSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginAssembly.Url] = input.Url.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

