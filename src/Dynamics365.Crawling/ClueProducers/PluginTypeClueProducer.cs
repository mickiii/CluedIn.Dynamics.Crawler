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
    public abstract class PluginTypeClueProducer<T> : DynamicsClueProducer<T> where T : PluginType
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PluginTypeClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PluginTypeId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=plugintype&id={1}", _dynamics365CrawlJobData.Api, input.PluginTypeId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.PluginAssemblyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pluginassembly, EntityEdgeType.Parent, input, input.PluginAssemblyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.PluginType.FriendlyName] = input.FriendlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.PublicKeyToken] = input.PublicKeyToken.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.AssemblyName] = input.AssemblyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.PluginTypeId] = input.PluginTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.Culture] = input.Culture.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.Version] = input.Version.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.TypeName] = input.TypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.IsWorkflowActivity] = input.IsWorkflowActivity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.PluginTypeIdUnique] = input.PluginTypeIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.PluginAssemblyId] = input.PluginAssemblyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CustomizationLevel] = input.CustomizationLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.WorkflowActivityGroupName] = input.WorkflowActivityGroupName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.IsWorkflowActivityName] = input.IsWorkflowActivityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.PluginAssemblyIdName] = input.PluginAssemblyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.Major] = input.Major.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.Minor] = input.Minor.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PluginType.CustomWorkflowActivityInfo] = input.CustomWorkflowActivityInfo.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

