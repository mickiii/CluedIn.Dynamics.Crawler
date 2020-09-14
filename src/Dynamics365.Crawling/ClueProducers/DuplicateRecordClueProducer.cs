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
    public abstract class DuplicateRecordClueProducer<T> : DynamicsClueProducer<T> where T : DuplicateRecord
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DuplicateRecordClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DuplicateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=duplicaterecord&id={1}", _dynamics365CrawlJobData.Api, input.DuplicateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodtrainingboundingbox, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodtrainingboundingbox, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisresultdetail, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisresultdetail, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommand, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommand, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointdocumentlocation, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointdocumentlocation, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_icebreakersconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_icebreakersconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_serviceconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_serviceconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solutioncomponentconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solutioncomponentconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerassetcategory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerassetcategory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetfile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetfile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivity, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivity, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardstataggregation, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardstataggregation, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_subverticalmarket, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_subverticalmarket, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axcompany, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axcompany, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goal, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goal, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisjob, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisjob, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetscontainer, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetscontainer, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_siconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_siconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticleimage, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticleimage, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_leadmodelconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_leadmodelconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotproviderinstance, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotproviderinstance, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_warpstatus, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_warpstatus, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointsite, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointsite, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_opportunityrevenue, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_opportunityrevenue, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.emailserverprofile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.emailserverprofile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_segmentation, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_segmentation, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_setting, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_setting, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ratingmodel, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ratingmodel, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_marketinglist_assignment_rule, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_marketinglist_assignment_rule, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connector, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connector, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_partnerauthorization, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_partnerauthorization, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_profile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_profile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_excludedemail, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_excludedemail, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.stagesolutionupload, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.stagesolutionupload, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialclick, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialclick, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_classification, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_classification, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastdefinition, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastdefinition, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialpost, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialpost, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.adminsettingsentity, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.adminsettingsentity, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotpropertydefinition, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotpropertydefinition, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqepr, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqepr, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_webforminfo, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_webforminfo, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_sector, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_sector, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_language, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_language, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_predictivemodelconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_predictivemodelconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicedatahistory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicedatahistory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_optionmapping, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_optionmapping, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookinstance, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookinstance, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresource, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresource, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqepraccountjt, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqepraccountjt, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_untrackedappointment, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_untrackedappointment, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goalrollupquery, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivityattribute, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivityattribute, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.publisher, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.publisher, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRuleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.duplicaterule, EntityEdgeType.Parent, input, input.DuplicateRuleId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_wkwconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_wkwconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_emailtemplate, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_emailtemplate, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicevisualizationconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicevisualizationconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_numberserie, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_numberserie, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_connector, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_connector, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axsalesgroup, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axsalesgroup, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevice, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevice, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_stateorprovince, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_stateorprovince, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthrule, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthrule, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_autocapturerule, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_autocapturerule, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticletemplate, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticletemplate, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_question, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_question, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotsettings, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotsettings, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.AsyncOperationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.asyncoperation, EntityEdgeType.Parent, input, input.AsyncOperationId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_statuscomment, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_statuscomment, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_channelsegment, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_channelsegment, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.environmentvariablevalue, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.environmentvariablevalue, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_relationshipinsightsunifiedconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_relationshipinsightsunifiedconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_autocapturesettings, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_autocapturesettings, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcegroup, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcegroup, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthruleset, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthruleset, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlemententityallocationtypemapping, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlemententityallocationtypemapping, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_verticalmarket, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_verticalmarket, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfileattacheddata, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfileattacheddata, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.apisettings, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.apisettings, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedincampaign, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedincampaign, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_area, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_area, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ratingvalue, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ratingvalue, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_dataflow, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_dataflow, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastinstance, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastinstance, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sales_linkedin_configuration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sales_linkedin_configuration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbooktemplate, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbooktemplate, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_jabramanagementlevel, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_jabramanagementlevel, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_account_planning_fact, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_account_planning_fact, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementchannel, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementchannel, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailstatistics, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailstatistics, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceregistrationhistory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceregistrationhistory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastrecurrence, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastrecurrence, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecategory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecategory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysiscomponent, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysiscomponent, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcegroup, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcegroup, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookcategory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookcategory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_loyaltyprogramowner, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_loyaltyprogramowner, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.characteristic, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.characteristic, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetrecord, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetrecord, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecharacteristic, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecharacteristic, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solutioncomponentattributeconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solutioncomponentattributeconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategoryassn, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategoryassn, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookingstatus, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookingstatus, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_modelpreviewstatus, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_modelpreviewstatus, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardregarding, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardregarding, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_subregion, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_subregion, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofile, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofile, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_survey, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_survey, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodtrainingimage, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodtrainingimage, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotprovider, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotprovider, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_opportunitymodelconfig, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_opportunitymodelconfig, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_questionresponse, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_questionresponse, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_salesinsightssettings, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_salesinsightssettings, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisresult, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisresult, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceproperty, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceproperty, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_callablecontext, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_callablecontext, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_slakpi, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_slakpi, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_communicationplatform, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_communicationplatform, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqquote, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqquote, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodimage, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodimage, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodlabel, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodlabel, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_leadentityfield, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_leadentityfield, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_unsubscribedrecipient, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_unsubscribedrecipient, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommanddefinition, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommanddefinition, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_lapsedtraderinfo, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_lapsedtraderinfo, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axtemplate, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axtemplate, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_datasync, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_datasync, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_productgroup, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_productgroup, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.feedback, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.feedback, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_country, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_country, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_anonymousvisitor, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_anonymousvisitor, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.category, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.category, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotfieldmapping, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotfieldmapping, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceplan, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceplan, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.environmentvariabledefinition, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.environmentvariabledefinition, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardactionstat, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardactionstat, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdataset, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdataset, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthruleargument, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthruleargument, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.BaseRecordId);

                         if (input.DuplicateRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_flowcardtype, EntityEdgeType.Parent, input, input.DuplicateRecordId);

                         if (input.BaseRecordId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_flowcardtype, EntityEdgeType.Parent, input, input.BaseRecordId);


            */
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.DuplicateRuleId] = input.DuplicateRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.BaseRecordId] = input.BaseRecordId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.DuplicateId] = input.DuplicateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.AsyncOperationId] = input.AsyncOperationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.DuplicateRecordId] = input.DuplicateRecordId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.BaseRecordIdTypeCode] = input.BaseRecordIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.BaseRecordIdName] = input.BaseRecordIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.DuplicateRecordIdName] = input.DuplicateRecordIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.DuplicateRecordIdYomiName] = input.DuplicateRecordIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.BaseRecordIdYomiName] = input.BaseRecordIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.DuplicateRecordIdTypeCode] = input.DuplicateRecordIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRecord.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

