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
    public abstract class PrincipalObjectAttributeAccessClueProducer<T> : DynamicsClueProducer<T> where T : PrincipalObjectAttributeAccess
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PrincipalObjectAttributeAccessClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PrincipalObjectAttributeAccessId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=principalobjectattributeaccess&id={1}", _dynamics365CrawlJobData.Api, input.PrincipalObjectAttributeAccessId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quoteclose, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.customeropportunityrole, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodtrainingboundingbox, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailevent, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisresultdetail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ap_filterhelper, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.commitment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.flowsession, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incidentknowledgebaserecord, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodelexecutionhistory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_scribepublisherqueue, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicpropertyassociation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sales_linkedin_profileassociations, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_billinginfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommand, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.abdg_datagridcolumn, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointdocumentlocation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_icebreakersconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperationlog, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.discounttype, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_serviceconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesend, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_mostcontacted, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solutioncomponentconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerassetcategory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_core_activation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetfile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incidentresolution, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardstataggregation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_subverticalmarket, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axcompany, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotalert, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goal, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisjob, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.crowe_solutionsettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetscontainer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.position, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitoraddress, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_siconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.constraintbasedgroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.PrincipalId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.PrincipalId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sentemail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticleimage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_leadmodelconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_nps, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotproviderinstance, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_notesanalysisconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_warpstatus, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointsite, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contactleads, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_shareofwallet, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_quickfind, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postruleconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_opportunityrevenue, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodelconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticleviews, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_msteamssettingsv2, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_segmentation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_setting, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_activityanalysisconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_sample, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ratingmodel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_region, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_marketinglist_assignment_rule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorderdetail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connector, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingexchangesyncidmapping, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_partnerauthorization, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsubscription, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cobalt_iqeventhandler, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesprocessinstance, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstageparameter, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_profile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.listmember, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_excludedemail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicproperty, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.stagesolutionupload, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialclick, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_classification, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastdefinition, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonetocaseprocess, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productsubstitute, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.crowe_nameduser, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityclose, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialpost, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.adminsettingsentity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_lookupconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formfield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotpropertydefinition, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_opportunitykpiitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_upgradeversion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqepr, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_orginsightsuserdashboarddefinition, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementcontacts, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_webforminfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_sector, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_dataanalyticsreport, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitorproduct, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_language, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_predictivemodelconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queue, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicedatahistory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_optionmapping, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_nurturebuilder, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookinstance, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresource, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.abdg_datagridcriteriagroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqepraccountjt, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_untrackedappointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_msteamssetting, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitorsalesliterature, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topicmodel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookactivityattribute, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.leadtoopportunitysalesprocess, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountplanningbpf, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contactquotes, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_mostcontactedby, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contracttemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topic, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_productshelf, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.childincidentcount, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_wkwconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_databaseversion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_entityrankingrule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailmergetemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_emailtemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicevisualizationconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_wallsavedqueryusersettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_numberserie, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.servicecontractcontacts, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_connector, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axsalesgroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesliterature, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevice, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_processlog, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_stateorprovince, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthrule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_autocapturerule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_knowledgearticletemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_question, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_activityanalysiscleanupstate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.crowe_solutionactivation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotsettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_statuscomment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.leadaddress, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_channelsegment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.environmentvariablevalue, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.leadcompetitors, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_relationshipinsightsunifiedconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quotedetail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.abdg_datagrid, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_autocapturesettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcegroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.abdg_datagridcriteria, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_usersession, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcegroupexpansion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthruleset, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_0b7ea545de274ec3ba678109f8d9f28c, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlemententityallocationtypemapping, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesliteratureitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_7935ac28ccb54d34b25f4aa1f53c0111, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_verticalmarket, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibfileattacheddata, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicpropertyoptionsetitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_setactivestate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_leadkpiitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementproducts, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.apisettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedincampaign, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_accountkpiitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_contactkpiitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_onezone, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.PrincipalId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.PrincipalId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_teamscollaboration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_area, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.customeraddress, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contractdetail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ratingvalue, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_dataflow, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_upgraderun, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastinstance, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_productacquisition, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflowbinary, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sales_linkedin_configuration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productassociation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.orderclose, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbooktemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_wallsavedquery, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_jabramanagementlevel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_account_planning_fact, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementchannel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_securitysession, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resource, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountplan, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_deletedrecord, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productsalesliterature, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.attributeimageconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailstatistics, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunitycompetitors, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceregistrationhistory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_forecastrecurrence, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunitysalesprocess, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analyticsadminsettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecategory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysiscomponent, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.queueitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.accountleads, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.reportcategory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplateproducts, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analyticsforcs, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcespec, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcegroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookcategory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapturefield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_numbersequence, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sendemail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.leadproduct, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_loyaltyprogramowner, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.characteristic, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdatasetrecord, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecharacteristic, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.solutioncomponentattributeconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iottocaseprocess, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_collabgraphresource, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplatechannel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategoryassn, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookingstatus, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_modelpreviewstatus, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_upgradestep, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardregarding, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_subregion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_filter, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivityitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_survey, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodtrainingimage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotprovider, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_sikeyvalueconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_opportunitymodelconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_trace, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_bulktxtmessage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.topichistory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_mergeinfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_questionresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticleincident, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aitemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_salesinsightssettings, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_analysisresult, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceproperty, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_callablecontext, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_runnurture, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_quicksendprivilege, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_domain, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_slakpi, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicpropertyinstance, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_devicecaseproduct, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_engagementmodel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_category, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.site, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_communicationplatform, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cpq_cpqquote, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodimage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodlabel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connection, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_leadentityfield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_competitioninfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_leadstatuslog, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entityanalyticsconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_unsubscribedrecipient, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommanddefinition, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productpricelevel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aimodel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoicedetail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.discount, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_lapsedtraderinfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_axtemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uomschedule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_testentitycountemailpermission, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_datasync, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_productgroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.feedback, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_country, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_anonymousvisitor, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_dfc751aa1f3e47f583330ef7f904075e, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_helppage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_bpf_c99fcd1f78374f328ef2c6cf84983cff, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotfieldmapping, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aifptrainingdocument, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardrolesetting, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_opptyprod_clonecalculation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.holidaywrapper, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_zymeinfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contactorders, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_posdata, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_expression, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceplan, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.environmentvariabledefinition, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailsend, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contactinvoices, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityproduct, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_actioncardactionstat, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aibdataset, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entityimageconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhealthruleargument, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.new_scribechangehistory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_flowcardtype, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.abdg_datagridevent, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_integrationconfiguration, EntityEdgeType.Parent, input, input.ObjectId);


            */
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.PrincipalObjectAttributeAccessId] = input.PrincipalObjectAttributeAccessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.PrincipalId] = input.PrincipalId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.AttributeId] = input.AttributeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.ReadAccess] = input.ReadAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.UpdateAccess] = input.UpdateAccess.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.PrincipalIdType] = input.PrincipalIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PrincipalObjectAttributeAccess.PrincipalIdName] = input.PrincipalIdName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

