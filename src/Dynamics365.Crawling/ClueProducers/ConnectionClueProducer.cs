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
    public abstract class ConnectionClueProducer<T> : DynamicsClueProducer<T> where T : Connection
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ConnectionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ConnectionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=connection&id={1}", _dynamics365CrawlJobData.Api, input.ConnectionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailevent, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailevent, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.activitypointer, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailtemplate, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgearticle, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommand, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecommand, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesend, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesend, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinform, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialactivity, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.serviceappointment, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_core_activation, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_core_activation, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformanswer, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinleadmatchingstrategy, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotalert, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotalert, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goal, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.goal, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.list, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.position, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.position, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.fax, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.constraintbasedgroup, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.constraintbasedgroup, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.equipment, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sentemail, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sentemail, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_setting, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_setting, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.letter, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.phonecall, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsubscription, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsubscription, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_profile, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_profile, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_excludedemail, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_excludedemail, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialclick, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialclick, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_activity_request, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformquestion, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofilerule, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.channelaccessprofilerule, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionconfiguration, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.gnh_accountsegmentation, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialpost, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_socialpost, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_eventparticipation, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formfield, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formfield, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailcname, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_inmail, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_message, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyanswer, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.appointment, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_optionmapping, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_optionmapping, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_nurturebuilder, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_nurturebuilder, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.li_pointdrivepresentationviewed, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyinvite, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptionentityconfiguration, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontracking, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_postalbum, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.knowledgebaserecord, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevice, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevice, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_webcontent, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processsession, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processsession, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedfield, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_import, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_usersession, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_usersession, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_txtmessage, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.incident, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.task, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_automation, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinuserprofile, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_surveyquestion, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_notifyworkflowfailure, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_inogiclicensedetails, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_nameduser, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementchannel, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementchannel, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_customerasset, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_securitysession, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_securitysession, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinformsubmission, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_unsubscribe, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailstatistics, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailstatistics, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceregistrationhistory, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdeviceregistrationhistory, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecategory, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyn_iotdevicecategory, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.socialprofile, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_useradoptiontrackingdetails, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcegroup, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.resourcegroup, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapturefield, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapturefield, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sendemail, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_sendemail, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplatechannel, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplatechannel, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedsurvey, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1RoleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connectionrole, EntityEdgeType.Parent, input, input.Record1RoleId);

                         if (input.Record2RoleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connectionrole, EntityEdgeType.Parent, input, input.Record2RoleId);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_pageview, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_filter, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_filter, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msfp_surveyresponse, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.recurringappointmentmaster, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_visit, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_iporganization, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionlist, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinfieldmapping, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinactivity, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_bulktxtmessage, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_bulktxtmessage, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaignactivity, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_subscriptionpreference, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_importlog, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_domain, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_domain, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_category, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_category, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.RelatedConnectionId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.connection, EntityEdgeType.Parent, input, input.RelatedConnectionId);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.able_applicationconfiguration, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.ikl_monitoredusers, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_event, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.msdyncrm_linkedinaccount, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.territory, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_executesocialpost, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_anonymousvisitor, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_anonymousvisitor, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_postedform, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailsend, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_emailsend, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlement, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.cdi_formcapture, EntityEdgeType.Parent, input, input.Record2Id);

                         if (input.Record1Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.Record1Id);

                         if (input.Record2Id != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.email, EntityEdgeType.Parent, input, input.Record2Id);


            */
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ConnectionId] = input.ConnectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.EffectiveStart] = input.EffectiveStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.IsMaster] = input.IsMaster.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.RelatedConnectionId] = input.RelatedConnectionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2Id] = input.Record2Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2RoleId] = input.Record2RoleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.EffectiveEnd] = input.EffectiveEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1RoleId] = input.Record1RoleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1Id] = input.Record1Id.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1IdObjectTypeCode] = input.Record1IdObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1RoleIdName] = input.Record1RoleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2IdObjectTypeCode] = input.Record2IdObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2RoleIdName] = input.Record2RoleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1IdName] = input.Record1IdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2IdName] = input.Record2IdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2ObjectTypeCode] = input.Record2ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record2ObjectTypeCodeName] = input.Record2ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1ObjectTypeCode] = input.Record1ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Record1ObjectTypeCodeName] = input.Record1ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Connection.IsMasterName] = input.IsMasterName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

