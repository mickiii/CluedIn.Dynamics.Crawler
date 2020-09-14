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
    public abstract class AuditClueProducer<T> : DynamicsClueProducer<T> where T : Audit
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AuditClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.AuditId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=audit&id={1}", _dynamics365CrawlJobData.Api, input.AuditId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.UserId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.UserId);

                         if (input.CallingUserId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CallingUserId);


            */
            data.Properties[Dynamics365Vocabulary.Audit.AttributeMask] = input.AttributeMask.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.TransactionId] = input.TransactionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.Action] = input.Action.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.UserId] = input.UserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.ChangeData] = input.ChangeData.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.Operation] = input.Operation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.AuditId] = input.AuditId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.CallingUserId] = input.CallingUserId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.ActionName] = input.ActionName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.OperationName] = input.OperationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.UserIdName] = input.UserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.ObjectIdName] = input.ObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.CallingUserIdName] = input.CallingUserIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Audit.UserAdditionalInfo] = input.UserAdditionalInfo.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

