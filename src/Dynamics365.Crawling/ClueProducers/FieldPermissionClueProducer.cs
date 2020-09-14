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
    public abstract class FieldPermissionClueProducer<T> : DynamicsClueProducer<T> where T : FieldPermission
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public FieldPermissionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.FieldPermissionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=fieldpermission&id={1}", _dynamics365CrawlJobData.Api, input.FieldPermissionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.SolutionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solution, EntityEdgeType.Parent, input, input.SolutionId);

                         if (input.FieldSecurityProfileId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fieldsecurityprofile, EntityEdgeType.Parent, input, input.FieldSecurityProfileId);


            */
            data.Properties[Dynamics365Vocabulary.FieldPermission.CanRead] = input.CanRead.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.CanReadName] = input.CanReadName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.CanUpdate] = input.CanUpdate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.CanUpdateName] = input.CanUpdateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.CanCreate] = input.CanCreate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.CanCreateName] = input.CanCreateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.FieldSecurityProfileId] = input.FieldSecurityProfileId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.FieldPermissionId] = input.FieldPermissionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.EntityName] = input.EntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.AttributeLogicalName] = input.AttributeLogicalName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.FieldPermissionIdUnique] = input.FieldPermissionIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.FieldPermission.IsManagedName] = input.IsManagedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

