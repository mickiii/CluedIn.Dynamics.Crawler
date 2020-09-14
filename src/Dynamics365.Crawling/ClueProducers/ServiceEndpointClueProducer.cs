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
    public abstract class ServiceEndpointClueProducer<T> : DynamicsClueProducer<T> where T : ServiceEndpoint
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ServiceEndpointClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ServiceEndpointId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=serviceendpoint&id={1}", _dynamics365CrawlJobData.Api, input.ServiceEndpointId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ServiceEndpointId] = input.ServiceEndpointId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.SolutionNamespace] = input.SolutionNamespace.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.Path] = input.Path.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.Contract] = input.Contract.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ContractName] = input.ContractName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ConnectionMode] = input.ConnectionMode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ConnectionModeName] = input.ConnectionModeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.UserClaim] = input.UserClaim.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.UserClaimName] = input.UserClaimName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.ServiceEndpointIdUnique] = input.ServiceEndpointIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IsManagedName] = input.IsManagedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IsCustomizable] = input.IsCustomizable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.AuthType] = input.AuthType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.AuthTypeName] = input.AuthTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.MessageFormat] = input.MessageFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.SASKey] = input.SASKey.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.SASKeyName] = input.SASKeyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.MessageFormatName] = input.MessageFormatName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.SASToken] = input.SASToken.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.NamespaceFormat] = input.NamespaceFormat.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.NamespaceFormatName] = input.NamespaceFormatName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.NamespaceAddress] = input.NamespaceAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IsSASTokenSet] = input.IsSASTokenSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IsSASKeySet] = input.IsSASKeySet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.AuthValue] = input.AuthValue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.Url] = input.Url.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ServiceEndpoint.IsAuthValueSet] = input.IsAuthValueSet.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

