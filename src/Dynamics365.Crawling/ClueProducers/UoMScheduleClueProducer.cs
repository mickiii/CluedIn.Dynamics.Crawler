//using System;
//using System.Linq;

//using CluedIn.Core;
//using CluedIn.Core.Agent.Jobs;
//using CluedIn.Core.Crawling;
//using CluedIn.Core.Data;
//using CluedIn.Crawling.Dynamics365.Core;
//using CluedIn.Crawling.Dynamics365.Core.Models;
//using CluedIn.Crawling.Dynamics365.Vocabularies;
//using CluedIn.Crawling.Factories;
//using CluedIn.Crawling.Helpers;

//namespace CluedIn.Crawling.Dynamics365.ClueProducers
//{
//  public abstract class UoMScheduleClueProducer<T> : DynamicsClueProducer<T> where T : UoMSchedule
//  {
//    private readonly IClueFactory _factory;

//        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

//    public UoMScheduleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
//    {
//      if (factory == null)
//                throw new ArgumentNullException(nameof(factory));

//            this._factory = factory;

//            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
//    }

//    protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
//    {
//      if (input == null)
//      throw new ArgumentNullException(nameof(input));

//      var clue = this._factory.Create(EntityType.Unknown, input.UoMScheduleId.ToString(), accountId);

//      var data = clue.Data.EntityData;

//       if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=uomschedule&id={1}", _dynamics365CrawlJobData.Api, input.UoMScheduleId.ToString()), UriKind.Absolute, out Uri uri))
//                data.Uri = uri;

//      data.Name = input.Name;
///*
// if (input.ModifiedByExternalParty != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.ModifiedByExternalParty);

//             if (input.CreatedByExternalParty != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.CreatedByExternalParty);

//             if (input.ModifiedOnBehalfBy != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

//             if (input.CreatedOnBehalfBy != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

//             if (input.CreatedBy != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

//             if (input.ModifiedBy != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

//             if (input.OrganizationId != null)
//                _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


//*/
//data.Properties[Dynamics365Vocabulary.UoMSchedule.UoMScheduleId] = input.UoMScheduleId.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.Name] = input.Name.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.Description] = input.Description.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.BaseUoMName] = input.BaseUoMName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.StateCode] = input.StateCode.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.StateCodeName] = input.StateCodeName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.StatusCode] = input.StatusCode.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
//            data.Properties[Dynamics365Vocabulary.UoMSchedule.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

//      this.Customize(clue, input);

//      if (!data.OutgoingEdges.Any())
//          this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

//       return clue;
//    }
//  }
//}  

