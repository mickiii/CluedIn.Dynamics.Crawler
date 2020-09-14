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
    public abstract class AnnotationClueProducer<T> : DynamicsClueProducer<T> where T : Annotation
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public AnnotationClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.AnnotationId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=annotation&id={1}", _dynamics365CrawlJobData.Api, input.AnnotationId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Subject;
            /*
             if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quoteclose, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailevent, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ap_filterhelper, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.commitment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.routingrule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommand, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incidentresolution, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotalert, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goal, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.kbarticle, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sentemail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_quickfind, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutionhistorydatasource, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.emailserverprofile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_sample, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.calendar, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsubscription, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialclick, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofilerule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityclose, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialpost, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_lookupconfig, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formfield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofileruleitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_nurturebuilder, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbookinstance, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresource, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.duplicaterule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bulkoperation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevice, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_solutioncomponentdatasource, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcegroup, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_usersession, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebookingheader, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_setactivestate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contractdetail, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.orderclose, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_playbooktemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcebooking, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementchannel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_securitysession, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountplan, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailstatistics, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceregistrationhistory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.mailbox, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecategory, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcespec, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapturefield, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_numbersequence, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecharacteristic, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.bookableresourcecategoryassn, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofile, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.workflow, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.convertrule, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.routingruleitem, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_trace, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_bulktxtmessage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sharepointdocument, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_category, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_communicationplatform, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aiodimage, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_competitioninfo, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.service, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aimodel, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_aifptrainingdocument, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.tcs_expression, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailsend, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.ObjectId);

                         if (input.ObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.ObjectId);


            */
            data.Properties[Dynamics365Vocabulary.Annotation.AnnotationId] = input.AnnotationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.IsDocument] = input.IsDocument.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.NoteText] = input.NoteText.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.MimeType] = input.MimeType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.LangId] = input.LangId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.DocumentBody] = input.DocumentBody.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.FileSize] = input.FileSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.FileName] = input.FileName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.IsPrivate] = input.IsPrivate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.IsPrivateName] = input.IsPrivateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.IsDocumentName] = input.IsDocumentName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.StepId] = input.StepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ObjectIdTypeCode] = input.ObjectIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.Prefix] = input.Prefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.StoragePointer] = input.StoragePointer.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Annotation.FilePointer] = input.FilePointer.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

