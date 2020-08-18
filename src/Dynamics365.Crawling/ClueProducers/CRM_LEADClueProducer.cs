using System;

using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core.Models;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;
using CluedIn.Crawling.Factories;
using CluedIn.Core.Data;
using CluedIn.Core;
using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public class CRM_LEADClueProducer : BaseClueProducer<CRM_LEAD>
    {
        private readonly IClueFactory _factory;

        public CRM_LEADClueProducer(IClueFactory factory)
        {
            this._factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(CRM_LEAD input, Guid accountId)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            // TODO: Create clue specifying the type of entity it is and ID
            var clue = this._factory.Create(EntityType.Sales.Lead, input.leadid, accountId);

            // TODO: Populate clue data
            var data = clue.Data.EntityData;

            data.Name = input.fullname;

            if (string.IsNullOrWhiteSpace(data.Name))
                data.Name = input.lastname ?? input.firstname;

            data.Description = input.description;
            if (DateTimeOffset.TryParse(input.createdon, out DateTimeOffset date))
                data.CreatedDate = date;
            if (DateTimeOffset.TryParse(input.modifiedon, out DateTimeOffset mod))
                data.ModifiedDate = mod;


            //if (!string.IsNullOrWhiteSpace(input.accountid))
                //this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.accountid);

            //if (!string.IsNullOrWhiteSpace(input.address1_addressid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Location.Address, EntityEdgeType.Has, input, input.address1_addressid);

            //if (!string.IsNullOrWhiteSpace(input.address2_addressid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Location.Address, EntityEdgeType.Has, input, input.address2_addressid);

            if (!string.IsNullOrWhiteSpace(input.parentcontactid))
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.parentcontactid);

            //if (!string.IsNullOrWhiteSpace(input.processid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Process, EntityEdgeType.Parent, input, input.processid);

            //if (!string.IsNullOrWhiteSpace(input.owningteam))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.OwnedBy, input, input.owningteam);

            //if (!string.IsNullOrWhiteSpace(input.entityimageid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Images.Image, EntityEdgeType.Has, input, input.entityimageid);

            //if (!string.IsNullOrWhiteSpace(input.owningbusinessunit))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.owningbusinessunit);

            //if (!string.IsNullOrWhiteSpace(input.masterid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.masterid);

            //if (!string.IsNullOrWhiteSpace(input.ownerid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.ownerid);

            //if (!string.IsNullOrWhiteSpace(input.createdonbehalfby))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.createdonbehalfby);

            //if (!string.IsNullOrWhiteSpace(input.modifiedonbehalfby))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.modifiedonbehalfby);

            //if (!string.IsNullOrWhiteSpace(input.createdby))
            //{
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.createdby);

            //    if (!string.IsNullOrWhiteSpace(input.createdbyname))
            //        data.Authors.Add(new PersonReference(input.createdbyname, new EntityCode(EntityType.Infrastructure.User, Dynamics365Constants.CodeOrigin, input.createdby)));
            //    else
            //        data.Authors.Add(new PersonReference(new EntityCode(EntityType.Infrastructure.User, Dynamics365Constants.CodeOrigin, input.createdby)));
            //}

            //if (!string.IsNullOrWhiteSpace(input.owninguser))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.owninguser);

            //if (!string.IsNullOrWhiteSpace(input.modifiedby))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.modifiedby);

            //if (!string.IsNullOrWhiteSpace(input.stageid))
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.stageid);

            var vocab = new CRM_LEADVocabulary();
            data.Properties[vocab.accountid] = input.accountid;
            data.Properties[vocab.accountiddsc] = input.accountiddsc;
            data.Properties[vocab.accountidname] = input.accountidname;
            data.Properties[vocab.accountidyominame] = input.accountidyominame;
            data.Properties[vocab.address1_addressid] = input.address1_addressid;
            data.Properties[vocab.address1_addresstypecode] = input.address1_addresstypecode;
            data.Properties[vocab.address1_addresstypecodename] = input.address1_addresstypecodename;
            data.Properties[vocab.address1_city] = input.address1_city;
            data.Properties[vocab.address1_composite] = input.address1_composite;
            data.Properties[vocab.address1_country] = input.address1_country;
            data.Properties[vocab.address1_county] = input.address1_county;
            data.Properties[vocab.address1_fax] = input.address1_fax;
            data.Properties[vocab.address1_latitude] = input.address1_latitude;
            data.Properties[vocab.address1_line1] = input.address1_line1;
            data.Properties[vocab.address1_line2] = input.address1_line2;
            data.Properties[vocab.address1_line3] = input.address1_line3;
            data.Properties[vocab.address1_longitude] = input.address1_longitude;
            data.Properties[vocab.address1_name] = input.address1_name;
            data.Properties[vocab.address1_postalcode] = input.address1_postalcode;
            data.Properties[vocab.address1_postofficebox] = input.address1_postofficebox;
            data.Properties[vocab.address1_shippingmethodcode] = input.address1_shippingmethodcode;
            data.Properties[vocab.address1_shippingmethodcodename] = input.address1_shippingmethodcodename;
            data.Properties[vocab.address1_stateorprovince] = input.address1_stateorprovince;
            data.Properties[vocab.address1_telephone1] = input.address1_telephone1;
            data.Properties[vocab.address1_telephone2] = input.address1_telephone2;
            data.Properties[vocab.address1_telephone3] = input.address1_telephone3;
            data.Properties[vocab.address1_upszone] = input.address1_upszone;
            data.Properties[vocab.address1_utcoffset] = input.address1_utcoffset;
            data.Properties[vocab.address2_addressid] = input.address2_addressid;
            data.Properties[vocab.address2_addresstypecode] = input.address2_addresstypecode;
            data.Properties[vocab.address2_addresstypecodename] = input.address2_addresstypecodename;
            data.Properties[vocab.address2_city] = input.address2_city;
            data.Properties[vocab.address2_composite] = input.address2_composite;
            data.Properties[vocab.address2_country] = input.address2_country;
            data.Properties[vocab.address2_county] = input.address2_county;
            data.Properties[vocab.address2_fax] = input.address2_fax;
            data.Properties[vocab.address2_latitude] = input.address2_latitude;
            data.Properties[vocab.address2_line1] = input.address2_line1;
            data.Properties[vocab.address2_line2] = input.address2_line2;
            data.Properties[vocab.address2_line3] = input.address2_line3;
            data.Properties[vocab.address2_longitude] = input.address2_longitude;
            data.Properties[vocab.address2_name] = input.address2_name;
            data.Properties[vocab.address2_postalcode] = input.address2_postalcode;
            data.Properties[vocab.address2_postofficebox] = input.address2_postofficebox;
            data.Properties[vocab.address2_shippingmethodcode] = input.address2_shippingmethodcode;
            data.Properties[vocab.address2_shippingmethodcodename] = input.address2_shippingmethodcodename;
            data.Properties[vocab.address2_stateorprovince] = input.address2_stateorprovince;
            data.Properties[vocab.address2_telephone1] = input.address2_telephone1;
            data.Properties[vocab.address2_telephone2] = input.address2_telephone2;
            data.Properties[vocab.address2_telephone3] = input.address2_telephone3;
            data.Properties[vocab.address2_upszone] = input.address2_upszone;
            data.Properties[vocab.address2_utcoffset] = input.address2_utcoffset;
            data.Properties[vocab.ap_afslutlead] = input.ap_afslutlead;
            data.Properties[vocab.ap_afslutleadutc] = input.ap_afslutleadutc;
            data.Properties[vocab.ap_aftale] = input.ap_aftale;
            data.Properties[vocab.ap_aftalename] = input.ap_aftalename;
            data.Properties[vocab.ap_alder] = input.ap_alder;
            data.Properties[vocab.ap_alleredemedlem] = input.ap_alleredemedlem;
            data.Properties[vocab.ap_alleredemedlemname] = input.ap_alleredemedlemname;
            data.Properties[vocab.ap_ambassadoer] = input.ap_ambassadoer;
            data.Properties[vocab.ap_amb_ledig] = input.ap_amb_ledig;
            data.Properties[vocab.ap_amb_ledigname] = input.ap_amb_ledigname;
            data.Properties[vocab.ap_andetnr] = input.ap_andetnr;
            data.Properties[vocab.ap_andetnrname] = input.ap_andetnrname;
            data.Properties[vocab.ap_anmodacceptindmeldelse] = input.ap_anmodacceptindmeldelse;
            data.Properties[vocab.ap_anmodacceptindmeldelsename] = input.ap_anmodacceptindmeldelsename;
            data.Properties[vocab.ap_antaldageget] = input.ap_antaldageget;
            data.Properties[vocab.ap_antaldagegetint] = input.ap_antaldagegetint;
            data.Properties[vocab.ap_antalkontaktforsoegifase1] = input.ap_antalkontaktforsoegifase1;
            data.Properties[vocab.ap_antalkontaktforsoegifase3] = input.ap_antalkontaktforsoegifase3;
            data.Properties[vocab.ap_antalkontaktforsog] = input.ap_antalkontaktforsog;
            data.Properties[vocab.ap_birthday] = input.ap_birthday;
            data.Properties[vocab.ap_birthdayutc] = input.ap_birthdayutc;
            data.Properties[vocab.ap_branchekode] = input.ap_branchekode;
            data.Properties[vocab.ap_brevstatus] = input.ap_brevstatus;
            data.Properties[vocab.ap_brevstatusname] = input.ap_brevstatusname;
            data.Properties[vocab.ap_checkimodulus] = input.ap_checkimodulus;
            data.Properties[vocab.ap_checkimodulusname] = input.ap_checkimodulusname;
            data.Properties[vocab.ap_country] = input.ap_country;
            data.Properties[vocab.ap_countryname] = input.ap_countryname;
            data.Properties[vocab.ap_cpr6cifre] = input.ap_cpr6cifre;
            data.Properties[vocab.ap_cvrnummer] = input.ap_cvrnummer;
            data.Properties[vocab.ap_datoforfoersteopkaldifasen] = input.ap_datoforfoersteopkaldifasen;
            data.Properties[vocab.ap_datoforfoersteopkaldifasenutc] = input.ap_datoforfoersteopkaldifasenutc;
            data.Properties[vocab.ap_datoopkald] = input.ap_datoopkald;
            data.Properties[vocab.ap_datoopkaldutc] = input.ap_datoopkaldutc;
            data.Properties[vocab.ap_diverse] = input.ap_diverse;
            data.Properties[vocab.ap_diversename] = input.ap_diversename;
            data.Properties[vocab.ap_dybderesultat] = input.ap_dybderesultat;
            data.Properties[vocab.ap_dybderesultatname] = input.ap_dybderesultatname;
            data.Properties[vocab.ap_emailadmin] = input.ap_emailadmin;
            data.Properties[vocab.ap_emailadminname] = input.ap_emailadminname;
            data.Properties[vocab.ap_fejllead] = input.ap_fejllead;
            data.Properties[vocab.ap_fejlleadname] = input.ap_fejlleadname;
            data.Properties[vocab.ap_forening] = input.ap_forening;
            data.Properties[vocab.ap_foreningname] = input.ap_foreningname;
            data.Properties[vocab.ap_foreningsdomain] = input.ap_foreningsdomain;
            data.Properties[vocab.ap_googlesoegeord] = input.ap_googlesoegeord;
            data.Properties[vocab.ap_handling] = input.ap_handling;
            data.Properties[vocab.ap_handlingname] = input.ap_handlingname;
            data.Properties[vocab.ap_henvisendekonsulent] = input.ap_henvisendekonsulent;
            data.Properties[vocab.ap_henvisendekonsulentname] = input.ap_henvisendekonsulentname;
            data.Properties[vocab.ap_henvisendekonsulentyominame] = input.ap_henvisendekonsulentyominame;
            data.Properties[vocab.ap_henvisning] = input.ap_henvisning;
            data.Properties[vocab.ap_henvisningname] = input.ap_henvisningname;
            data.Properties[vocab.ap_hvervepakkeekstrainfo] = input.ap_hvervepakkeekstrainfo;
            data.Properties[vocab.ap_hvervepakkestatus] = input.ap_hvervepakkestatus;
            data.Properties[vocab.ap_hvervepakkestatusdato] = input.ap_hvervepakkestatusdato;
            data.Properties[vocab.ap_hvervepakkestatusdatoutc] = input.ap_hvervepakkestatusdatoutc;
            data.Properties[vocab.ap_hvervepakkestatusname] = input.ap_hvervepakkestatusname;
            data.Properties[vocab.ap_hvervepakketype] = input.ap_hvervepakketype;
            data.Properties[vocab.ap_hvervepakketypename] = input.ap_hvervepakketypename;
            data.Properties[vocab.ap_indmeldelseaccepteret] = input.ap_indmeldelseaccepteret;
            data.Properties[vocab.ap_indmeldelseaccepteretname] = input.ap_indmeldelseaccepteretname;
            data.Properties[vocab.ap_krydssalg] = input.ap_krydssalg;
            data.Properties[vocab.ap_krydssalgname] = input.ap_krydssalgname;
            data.Properties[vocab.ap_kundeemnetype] = input.ap_kundeemnetype;
            data.Properties[vocab.ap_kundeemnetypename] = input.ap_kundeemnetypename;
            data.Properties[vocab.ap_log] = input.ap_log;
            data.Properties[vocab.ap_ltdaekning] = input.ap_ltdaekning;
            data.Properties[vocab.ap_ltikraftdato] = input.ap_ltikraftdato;
            data.Properties[vocab.ap_ltikraftdatoutc] = input.ap_ltikraftdatoutc;
            data.Properties[vocab.ap_ltkarens] = input.ap_ltkarens;
            data.Properties[vocab.ap_ltperiode] = input.ap_ltperiode;
            data.Properties[vocab.ap_medlemindmeldelseid] = input.ap_medlemindmeldelseid;
            data.Properties[vocab.ap_medlemindmeldelseidname] = input.ap_medlemindmeldelseidname;
            data.Properties[vocab.ap_medlemsnummer] = input.ap_medlemsnummer;
            data.Properties[vocab.ap_member] = input.ap_member;
            data.Properties[vocab.ap_membername] = input.ap_membername;
            data.Properties[vocab.ap_mersalgforsikringerhelbred] = input.ap_mersalgforsikringerhelbred;
            data.Properties[vocab.ap_mersalgforsikringerhelbredname] = input.ap_mersalgforsikringerhelbredname;
            data.Properties[vocab.ap_mersalgforsikringerkritisk] = input.ap_mersalgforsikringerkritisk;
            data.Properties[vocab.ap_mersalgforsikringerkritiskname] = input.ap_mersalgforsikringerkritiskname;
            data.Properties[vocab.ap_mersalgforsikringerlak] = input.ap_mersalgforsikringerlak;
            data.Properties[vocab.ap_mersalgforsikringerlakname] = input.ap_mersalgforsikringerlakname;
            data.Properties[vocab.ap_mersalgforsikringerlt] = input.ap_mersalgforsikringerlt;
            data.Properties[vocab.ap_mersalgforsikringerltname] = input.ap_mersalgforsikringerltname;
            data.Properties[vocab.ap_mersalgforsikringerulykke] = input.ap_mersalgforsikringerulykke;
            data.Properties[vocab.ap_mersalgforsikringerulykkename] = input.ap_mersalgforsikringerulykkename;
            data.Properties[vocab.ap_mersalgjobrettetcoaching] = input.ap_mersalgjobrettetcoaching;
            data.Properties[vocab.ap_mersalgjobrettetcoachingname] = input.ap_mersalgjobrettetcoachingname;
            data.Properties[vocab.ap_mersalgjobrettetdigitalmarkedsfoering] = input.ap_mersalgjobrettetdigitalmarkedsfoering;
            data.Properties[vocab.ap_mersalgjobrettetdigitalmarkedsfoeringname] = input.ap_mersalgjobrettetdigitalmarkedsfoeringname;
            data.Properties[vocab.ap_mersalgjobrettetelearning] = input.ap_mersalgjobrettetelearning;
            data.Properties[vocab.ap_mersalgjobrettetelearningname] = input.ap_mersalgjobrettetelearningname;
            data.Properties[vocab.ap_mersalgjobrettethr] = input.ap_mersalgjobrettethr;
            data.Properties[vocab.ap_mersalgjobrettethrname] = input.ap_mersalgjobrettethrname;
            data.Properties[vocab.ap_mersalgjobrettetkommunikation] = input.ap_mersalgjobrettetkommunikation;
            data.Properties[vocab.ap_mersalgjobrettetkommunikationname] = input.ap_mersalgjobrettetkommunikationname;
            data.Properties[vocab.ap_mersalgjobrettetlean] = input.ap_mersalgjobrettetlean;
            data.Properties[vocab.ap_mersalgjobrettetleanname] = input.ap_mersalgjobrettetleanname;
            data.Properties[vocab.ap_mersalgjobrettetledelse] = input.ap_mersalgjobrettetledelse;
            data.Properties[vocab.ap_mersalgjobrettetledelsename] = input.ap_mersalgjobrettetledelsename;
            data.Properties[vocab.ap_mersalgjobrettetoekonomi] = input.ap_mersalgjobrettetoekonomi;
            data.Properties[vocab.ap_mersalgjobrettetoekonominame] = input.ap_mersalgjobrettetoekonominame;
            data.Properties[vocab.ap_mersalgjobrettetprojekt] = input.ap_mersalgjobrettetprojekt;
            data.Properties[vocab.ap_mersalgjobrettetprojektname] = input.ap_mersalgjobrettetprojektname;
            data.Properties[vocab.ap_mersalgjobrettetsalg] = input.ap_mersalgjobrettetsalg;
            data.Properties[vocab.ap_mersalgjobrettetsalgname] = input.ap_mersalgjobrettetsalgname;
            data.Properties[vocab.ap_mersalgnytleadkc] = input.ap_mersalgnytleadkc;
            data.Properties[vocab.ap_mersalgnytleadkcname] = input.ap_mersalgnytleadkcname;
            data.Properties[vocab.ap_mersalgnytleadmgm] = input.ap_mersalgnytleadmgm;
            data.Properties[vocab.ap_mersalgnytleadmgmname] = input.ap_mersalgnytleadmgmname;
            data.Properties[vocab.ap_mersalgnytleadnyhedsbrev] = input.ap_mersalgnytleadnyhedsbrev;
            data.Properties[vocab.ap_mersalgnytleadnyhedsbrevname] = input.ap_mersalgnytleadnyhedsbrevname;
            data.Properties[vocab.ap_mersalgnytleadpension] = input.ap_mersalgnytleadpension;
            data.Properties[vocab.ap_mersalgnytleadpensionname] = input.ap_mersalgnytleadpensionname;
            data.Properties[vocab.ap_mersalgnytleadprivatforsikringer] = input.ap_mersalgnytleadprivatforsikringer;
            data.Properties[vocab.ap_mersalgnytleadprivatforsikringername] = input.ap_mersalgnytleadprivatforsikringername;
            data.Properties[vocab.ap_mgm] = input.ap_mgm;
            data.Properties[vocab.ap_mgmar50] = input.ap_mgmar50;
            data.Properties[vocab.ap_mgmar50name] = input.ap_mgmar50name;
            data.Properties[vocab.ap_mgmforkertnummer] = input.ap_mgmforkertnummer;
            data.Properties[vocab.ap_mgmforkertnummername] = input.ap_mgmforkertnummername;
            data.Properties[vocab.ap_mgmformangekontaktforsog] = input.ap_mgmformangekontaktforsog;
            data.Properties[vocab.ap_mgmformangekontaktforsogname] = input.ap_mgmformangekontaktforsogname;
            data.Properties[vocab.ap_mgmhvervepakke] = input.ap_mgmhvervepakke;
            data.Properties[vocab.ap_mgmhvervepakkename] = input.ap_mgmhvervepakkename;
            data.Properties[vocab.ap_mgmikkeinteresseret] = input.ap_mgmikkeinteresseret;
            data.Properties[vocab.ap_mgmikkeinteresseretname] = input.ap_mgmikkeinteresseretname;
            data.Properties[vocab.ap_mgmikkeoptagelsesberettiget] = input.ap_mgmikkeoptagelsesberettiget;
            data.Properties[vocab.ap_mgmikkeoptagelsesberettigetname] = input.ap_mgmikkeoptagelsesberettigetname;
            data.Properties[vocab.ap_mgmlead] = input.ap_mgmlead;
            data.Properties[vocab.ap_mgmleadgave] = input.ap_mgmleadgave;
            data.Properties[vocab.ap_mgmleadname] = input.ap_mgmleadname;
            data.Properties[vocab.ap_mgmname] = input.ap_mgmname;
            data.Properties[vocab.ap_mgmoverflyt] = input.ap_mgmoverflyt;
            data.Properties[vocab.ap_mgmoverflytname] = input.ap_mgmoverflytname;
            data.Properties[vocab.ap_mgmstatus] = input.ap_mgmstatus;
            data.Properties[vocab.ap_mgmstatusname] = input.ap_mgmstatusname;
            data.Properties[vocab.ap_mgmvenderselvtilbage] = input.ap_mgmvenderselvtilbage;
            data.Properties[vocab.ap_mgmvenderselvtilbagename] = input.ap_mgmvenderselvtilbagename;
            data.Properties[vocab.ap_midlertidigphoner] = input.ap_midlertidigphoner;
            data.Properties[vocab.ap_midlertidigphonername] = input.ap_midlertidigphonername;
            data.Properties[vocab.ap_midlertidigphoneryominame] = input.ap_midlertidigphoneryominame;
            data.Properties[vocab.ap_moede] = input.ap_moede;
            data.Properties[vocab.ap_moedename] = input.ap_moedename;
            data.Properties[vocab.ap_nuvaerendeselskab] = input.ap_nuvaerendeselskab;
            data.Properties[vocab.ap_nuvaerendeselskabname] = input.ap_nuvaerendeselskabname;
            data.Properties[vocab.ap_omraade] = input.ap_omraade;
            data.Properties[vocab.ap_omraadename] = input.ap_omraadename;
            data.Properties[vocab.ap_onsker] = input.ap_onsker;
            data.Properties[vocab.ap_onskername] = input.ap_onskername;
            data.Properties[vocab.ap_opkaldskonfiguration] = input.ap_opkaldskonfiguration;
            data.Properties[vocab.ap_opkaldskonfigurationname] = input.ap_opkaldskonfigurationname;
            data.Properties[vocab.ap_partnerinitialer] = input.ap_partnerinitialer;
            data.Properties[vocab.ap_phonerresultat] = input.ap_phonerresultat;
            data.Properties[vocab.ap_phonerresultatname] = input.ap_phonerresultatname;
            data.Properties[vocab.ap_rating] = input.ap_rating;
            data.Properties[vocab.ap_ratingint] = input.ap_ratingint;
            data.Properties[vocab.ap_ratingname] = input.ap_ratingname;
            data.Properties[vocab.ap_renvask] = input.ap_renvask;
            data.Properties[vocab.ap_renvaskname] = input.ap_renvaskname;
            data.Properties[vocab.ap_resultatdimensionalleredemedlem] = input.ap_resultatdimensionalleredemedlem;
            data.Properties[vocab.ap_resultatdimensionalleredemedlemname] = input.ap_resultatdimensionalleredemedlemname;
            data.Properties[vocab.ap_resultatdimensionikkeoptagelsesberettiget] = input.ap_resultatdimensionikkeoptagelsesberettiget;
            data.Properties[vocab.ap_resultatdimensionikkeoptagelsesberettigetname] = input.ap_resultatdimensionikkeoptagelsesberettigetname;
            data.Properties[vocab.ap_resultatdimensioningeninteresse] = input.ap_resultatdimensioningeninteresse;
            data.Properties[vocab.ap_resultatdimensioningeninteressename] = input.ap_resultatdimensioningeninteressename;
            data.Properties[vocab.ap_resultatdimensionkrydssalg] = input.ap_resultatdimensionkrydssalg;
            data.Properties[vocab.ap_resultatdimensionkrydssalgname] = input.ap_resultatdimensionkrydssalgname;
            data.Properties[vocab.ap_resultatdimensionlead] = input.ap_resultatdimensionlead;
            data.Properties[vocab.ap_resultatdimensionleadname] = input.ap_resultatdimensionleadname;
            data.Properties[vocab.ap_resultatdimensionnytsalg] = input.ap_resultatdimensionnytsalg;
            data.Properties[vocab.ap_resultatdimensionnytsalgname] = input.ap_resultatdimensionnytsalgname;
            data.Properties[vocab.ap_resultofphonecall] = input.ap_resultofphonecall;
            data.Properties[vocab.ap_resultofphonecallname] = input.ap_resultofphonecallname;
            data.Properties[vocab.ap_saelger] = input.ap_saelger;
            data.Properties[vocab.ap_saelgername] = input.ap_saelgername;
            data.Properties[vocab.ap_salgskanal] = input.ap_salgskanal;
            data.Properties[vocab.ap_salgskanalname] = input.ap_salgskanalname;
            data.Properties[vocab.ap_salgsopkaldstype] = input.ap_salgsopkaldstype;
            data.Properties[vocab.ap_salgsopkaldstypename] = input.ap_salgsopkaldstypename;
            data.Properties[vocab.ap_segment] = input.ap_segment;
            data.Properties[vocab.ap_segmentname] = input.ap_segmentname;
            data.Properties[vocab.ap_sidstehandlingdato] = input.ap_sidstehandlingdato;
            data.Properties[vocab.ap_sidstehandlingdatoutc] = input.ap_sidstehandlingdatoutc;
            data.Properties[vocab.ap_slutdatoifasen] = input.ap_slutdatoifasen;
            data.Properties[vocab.ap_slutdatoifasenutc] = input.ap_slutdatoifasenutc;
            data.Properties[vocab.ap_slutdatoomfordeling] = input.ap_slutdatoomfordeling;
            data.Properties[vocab.ap_slutdatoomfordelingutc] = input.ap_slutdatoomfordelingutc;
            data.Properties[vocab.ap_sms] = input.ap_sms;
            data.Properties[vocab.ap_smsname] = input.ap_smsname;
            data.Properties[vocab.ap_status] = input.ap_status;
            data.Properties[vocab.ap_statusname] = input.ap_statusname;
            data.Properties[vocab.ap_talsmand] = input.ap_talsmand;
            data.Properties[vocab.ap_talsmandname] = input.ap_talsmandname;
            data.Properties[vocab.ap_telefonsvarer] = input.ap_telefonsvarer;
            data.Properties[vocab.ap_telefonsvarername] = input.ap_telefonsvarername;
            data.Properties[vocab.ap_tidtaeffesbedst] = input.ap_tidtaeffesbedst;
            data.Properties[vocab.ap_tidtaeffesbedstname] = input.ap_tidtaeffesbedstname;
            data.Properties[vocab.ap_tilbudsendt] = input.ap_tilbudsendt;
            data.Properties[vocab.ap_tilbudsendtname] = input.ap_tilbudsendtname;
            data.Properties[vocab.ap_tildel] = input.ap_tildel;
            data.Properties[vocab.ap_tildelname] = input.ap_tildelname;
            data.Properties[vocab.ap_tilfredshed] = input.ap_tilfredshed;
            data.Properties[vocab.ap_tilfredshedname] = input.ap_tilfredshedname;
            data.Properties[vocab.ap_typetelefon] = input.ap_typetelefon;
            data.Properties[vocab.ap_ulykkesforsikring] = input.ap_ulykkesforsikring;
            data.Properties[vocab.ap_ulykkesforsikringname] = input.ap_ulykkesforsikringname;
            data.Properties[vocab.ap_ventantaldage] = input.ap_ventantaldage;
            data.Properties[vocab.ap_ventantaldageint] = input.ap_ventantaldageint;
            data.Properties[vocab.ap_ventstatus] = input.ap_ventstatus;
            data.Properties[vocab.ap_ventstatusname] = input.ap_ventstatusname;
            data.Properties[vocab.ap_virksomhedstiftelsesdato] = input.ap_virksomhedstiftelsesdato;
            data.Properties[vocab.ap_virksomhedstiftelsesdatoutc] = input.ap_virksomhedstiftelsesdatoutc;
            data.Properties[vocab.ap_wbdagesidenoprettelse] = input.ap_wbdagesidenoprettelse;
            data.Properties[vocab.ap_wbmedlemskab] = input.ap_wbmedlemskab;
            data.Properties[vocab.ap_wbmedlemskabname] = input.ap_wbmedlemskabname;
            data.Properties[vocab.ap_wbnyakasse] = input.ap_wbnyakasse;
            data.Properties[vocab.ap_wbnystilling] = input.ap_wbnystilling;
            data.Properties[vocab.ap_wbnystillingmodulus] = input.ap_wbnystillingmodulus;
            data.Properties[vocab.ap_wbnystillingmodulusname] = input.ap_wbnystillingmodulusname;
            data.Properties[vocab.ap_wboprettelsedatoudmeldelse] = input.ap_wboprettelsedatoudmeldelse;
            data.Properties[vocab.ap_wboprettelsedatoudmeldelseutc] = input.ap_wboprettelsedatoudmeldelseutc;
            data.Properties[vocab.ap_wboprettetmodulus] = input.ap_wboprettetmodulus;
            data.Properties[vocab.ap_wboprettetmodulusname] = input.ap_wboprettetmodulusname;
            data.Properties[vocab.ap_wbudmeldesaf] = input.ap_wbudmeldesaf;
            data.Properties[vocab.ap_wbudmeldesafname] = input.ap_wbudmeldesafname;
            data.Properties[vocab.ap_winback] = input.ap_winback;
            data.Properties[vocab.ap_winbackname] = input.ap_winbackname;
            data.Properties[vocab.ap_workflowstatus] = input.ap_workflowstatus;
            data.Properties[vocab.ap_workflowstatusname] = input.ap_workflowstatusname;
            data.Properties[vocab.budgetamount] = input.budgetamount;
            data.Properties[vocab.budgetamount_base] = input.budgetamount_base;
            data.Properties[vocab.budgetstatus] = input.budgetstatus;
            data.Properties[vocab.budgetstatusname] = input.budgetstatusname;
            data.Properties[vocab.campaignid] = input.campaignid;
            data.Properties[vocab.campaigniddsc] = input.campaigniddsc;
            data.Properties[vocab.campaignidname] = input.campaignidname;
            data.Properties[vocab.companyname] = input.companyname;
            data.Properties[vocab.confirminterest] = input.confirminterest;
            data.Properties[vocab.confirminterestname] = input.confirminterestname;
            data.Properties[vocab.contactid] = input.contactid;
            data.Properties[vocab.contactiddsc] = input.contactiddsc;
            data.Properties[vocab.contactidname] = input.contactidname;
            data.Properties[vocab.contactidyominame] = input.contactidyominame;
            data.Properties[vocab.createdby] = input.createdby;
            data.Properties[vocab.createdbydsc] = input.createdbydsc;
            data.Properties[vocab.createdbyname] = input.createdbyname;
            data.Properties[vocab.createdbyyominame] = input.createdbyyominame;
            data.Properties[vocab.createdon] = input.createdon;
            data.Properties[vocab.createdonutc] = input.createdonutc;
            data.Properties[vocab.createdonbehalfby] = input.createdonbehalfby;
            data.Properties[vocab.createdonbehalfbydsc] = input.createdonbehalfbydsc;
            data.Properties[vocab.createdonbehalfbyname] = input.createdonbehalfbyname;
            data.Properties[vocab.createdonbehalfbyyominame] = input.createdonbehalfbyyominame;
            data.Properties[vocab.customerid] = input.customerid;
            data.Properties[vocab.customeriddsc] = input.customeriddsc;
            data.Properties[vocab.customeridname] = input.customeridname;
            data.Properties[vocab.customeridtype] = input.customeridtype;
            data.Properties[vocab.customeridyominame] = input.customeridyominame;
            data.Properties[vocab.decisionmaker] = input.decisionmaker;
            data.Properties[vocab.decisionmakername] = input.decisionmakername;
            data.Properties[vocab.description] = input.description;
            data.Properties[vocab.donotbulkemail] = input.donotbulkemail;
            data.Properties[vocab.donotbulkemailname] = input.donotbulkemailname;
            data.Properties[vocab.donotemail] = input.donotemail;
            data.Properties[vocab.donotemailname] = input.donotemailname;
            data.Properties[vocab.donotfax] = input.donotfax;
            data.Properties[vocab.donotfaxname] = input.donotfaxname;
            data.Properties[vocab.donotphone] = input.donotphone;
            data.Properties[vocab.donotphonename] = input.donotphonename;
            data.Properties[vocab.donotpostalmail] = input.donotpostalmail;
            data.Properties[vocab.donotpostalmailname] = input.donotpostalmailname;
            data.Properties[vocab.donotsendmarketingmaterialname] = input.donotsendmarketingmaterialname;
            data.Properties[vocab.donotsendmm] = input.donotsendmm;
            data.Properties[vocab.emailaddress1] = input.emailaddress1;
            data.Properties[vocab.emailaddress2] = input.emailaddress2;
            data.Properties[vocab.emailaddress3] = input.emailaddress3;
            data.Properties[vocab.entityimageid] = input.entityimageid;
            data.Properties[vocab.entityimage_timestamp] = input.entityimage_timestamp;
            data.Properties[vocab.entityimage_url] = input.entityimage_url;
            data.Properties[vocab.estimatedamount] = input.estimatedamount;
            data.Properties[vocab.estimatedamount_base] = input.estimatedamount_base;
            data.Properties[vocab.estimatedclosedate] = input.estimatedclosedate;
            data.Properties[vocab.estimatedclosedateutc] = input.estimatedclosedateutc;
            data.Properties[vocab.estimatedvalue] = input.estimatedvalue;
            data.Properties[vocab.evaluatefit] = input.evaluatefit;
            data.Properties[vocab.evaluatefitname] = input.evaluatefitname;
            data.Properties[vocab.exchangerate] = input.exchangerate;
            data.Properties[vocab.fax] = input.fax;
            data.Properties[vocab.firstname] = input.firstname;
            data.Properties[vocab.fullname] = input.fullname;
            data.Properties[vocab.importsequencenumber] = input.importsequencenumber;
            data.Properties[vocab.industrycode] = input.industrycode;
            data.Properties[vocab.industrycodename] = input.industrycodename;
            data.Properties[vocab.initialcommunication] = input.initialcommunication;
            data.Properties[vocab.initialcommunicationname] = input.initialcommunicationname;
            data.Properties[vocab.isprivatename] = input.isprivatename;
            data.Properties[vocab.jobtitle] = input.jobtitle;
            data.Properties[vocab.lastname] = input.lastname;
            data.Properties[vocab.lastusedincampaign] = input.lastusedincampaign;
            data.Properties[vocab.lastusedincampaignutc] = input.lastusedincampaignutc;
            data.Properties[vocab.lder_ekstra_information] = input.lder_ekstra_information;
            data.Properties[vocab.lder_intern_besked] = input.lder_intern_besked;
            data.Properties[vocab.lder_intern_beskedname] = input.lder_intern_beskedname;
            data.Properties[vocab.lder_intern_besked_fra_mr] = input.lder_intern_besked_fra_mr;
            data.Properties[vocab.lder_mersalg_forsikringer_ulykke_barn] = input.lder_mersalg_forsikringer_ulykke_barn;
            data.Properties[vocab.lder_mersalg_forsikringer_ulykke_barnname] = input.lder_mersalg_forsikringer_ulykke_barnname;
            data.Properties[vocab.lder_mersalg_forsikringer_ulykke_samlever] = input.lder_mersalg_forsikringer_ulykke_samlever;
            data.Properties[vocab.lder_mersalg_forsikringer_ulykke_samlevername] = input.lder_mersalg_forsikringer_ulykke_samlevername;
            data.Properties[vocab.lder_opret_aftale_i_outlook] = input.lder_opret_aftale_i_outlook;
            data.Properties[vocab.lder_opret_aftale_i_outlookname] = input.lder_opret_aftale_i_outlookname;
            data.Properties[vocab.lder_sidste_faktisk_slutning] = input.lder_sidste_faktisk_slutning;
            data.Properties[vocab.lder_sidste_faktisk_slutningutc] = input.lder_sidste_faktisk_slutningutc;
            data.Properties[vocab.lder_svar_til_mr] = input.lder_svar_til_mr;
            data.Properties[vocab.lder_teledata_navn] = input.lder_teledata_navn;
            data.Properties[vocab.lder_uddyb_dybderesultat] = input.lder_uddyb_dybderesultat;
            data.Properties[vocab.lder_uddyb_dybderesultat_winback] = input.lder_uddyb_dybderesultat_winback;
            data.Properties[vocab.lder_uddyb_dybderesult_ikkeoptagelseberettiget] = input.lder_uddyb_dybderesult_ikkeoptagelseberettiget;
            data.Properties[vocab.lder_uddyb_winbackaarsag] = input.lder_uddyb_winbackaarsag;
            data.Properties[vocab.lder_virksomhedstype] = input.lder_virksomhedstype;
            data.Properties[vocab.leadid] = input.leadid;
            data.Properties[vocab.leadqualitycode] = input.leadqualitycode;
            data.Properties[vocab.leadqualitycodename] = input.leadqualitycodename;
            data.Properties[vocab.leadsourcecode] = input.leadsourcecode;
            data.Properties[vocab.leadsourcecodename] = input.leadsourcecodename;
            data.Properties[vocab.lh_eksternid] = input.lh_eksternid;
            data.Properties[vocab.masterid] = input.masterid;
            data.Properties[vocab.masterleadiddsc] = input.masterleadiddsc;
            data.Properties[vocab.masterleadidname] = input.masterleadidname;
            data.Properties[vocab.masterleadidyominame] = input.masterleadidyominame;
            data.Properties[vocab.merged] = input.merged;
            data.Properties[vocab.mergedname] = input.mergedname;
            data.Properties[vocab.middlename] = input.middlename;
            data.Properties[vocab.mobilephone] = input.mobilephone;
            data.Properties[vocab.modifiedby] = input.modifiedby;
            data.Properties[vocab.modifiedbydsc] = input.modifiedbydsc;
            data.Properties[vocab.modifiedbyname] = input.modifiedbyname;
            data.Properties[vocab.modifiedbyyominame] = input.modifiedbyyominame;
            data.Properties[vocab.modifiedon] = input.modifiedon;
            data.Properties[vocab.modifiedonutc] = input.modifiedonutc;
            data.Properties[vocab.modifiedonbehalfby] = input.modifiedonbehalfby;
            data.Properties[vocab.modifiedonbehalfbydsc] = input.modifiedonbehalfbydsc;
            data.Properties[vocab.modifiedonbehalfbyname] = input.modifiedonbehalfbyname;
            data.Properties[vocab.modifiedonbehalfbyyominame] = input.modifiedonbehalfbyyominame;
            data.Properties[vocab.need] = input.need;
            data.Properties[vocab.needname] = input.needname;
            data.Properties[vocab.nn_lastupdated] = input.nn_lastupdated;
            data.Properties[vocab.nn_lastupdatedutc] = input.nn_lastupdatedutc;
            data.Properties[vocab.nn_links] = input.nn_links;
            data.Properties[vocab.nn_tdcid] = input.nn_tdcid;
            data.Properties[vocab.nn_updateprotected] = input.nn_updateprotected;
            data.Properties[vocab.nn_updateprotectedname] = input.nn_updateprotectedname;
            data.Properties[vocab.numberofemployees] = input.numberofemployees;
            data.Properties[vocab.originatingcaseid] = input.originatingcaseid;
            data.Properties[vocab.originatingcaseidname] = input.originatingcaseidname;
            data.Properties[vocab.overriddencreatedon] = input.overriddencreatedon;
            data.Properties[vocab.overriddencreatedonutc] = input.overriddencreatedonutc;
            data.Properties[vocab.ownerid] = input.ownerid;
            data.Properties[vocab.owneriddsc] = input.owneriddsc;
            data.Properties[vocab.owneridname] = input.owneridname;
            data.Properties[vocab.owneridtype] = input.owneridtype;
            data.Properties[vocab.owneridyominame] = input.owneridyominame;
            data.Properties[vocab.owningbusinessunit] = input.owningbusinessunit;
            data.Properties[vocab.owningteam] = input.owningteam;
            data.Properties[vocab.owninguser] = input.owninguser;
            data.Properties[vocab.pager] = input.pager;
            data.Properties[vocab.parentaccountid] = input.parentaccountid;
            data.Properties[vocab.parentaccountidname] = input.parentaccountidname;
            data.Properties[vocab.parentaccountidyominame] = input.parentaccountidyominame;
            data.Properties[vocab.parentcontactid] = input.parentcontactid;
            data.Properties[vocab.parentcontactidname] = input.parentcontactidname;
            data.Properties[vocab.parentcontactidyominame] = input.parentcontactidyominame;
            data.Properties[vocab.participatesinworkflow] = input.participatesinworkflow;
            data.Properties[vocab.participatesinworkflowname] = input.participatesinworkflowname;
            data.Properties[vocab.preferredcontactmethodcode] = input.preferredcontactmethodcode;
            data.Properties[vocab.preferredcontactmethodcodename] = input.preferredcontactmethodcodename;
            data.Properties[vocab.prioritycode] = input.prioritycode;
            data.Properties[vocab.prioritycodename] = input.prioritycodename;
            data.Properties[vocab.processid] = input.processid;
            data.Properties[vocab.purchaseprocess] = input.purchaseprocess;
            data.Properties[vocab.purchaseprocessname] = input.purchaseprocessname;
            data.Properties[vocab.purchasetimeframe] = input.purchasetimeframe;
            data.Properties[vocab.purchasetimeframename] = input.purchasetimeframename;
            data.Properties[vocab.qualificationcomments] = input.qualificationcomments;
            data.Properties[vocab.qualifyingopportunityid] = input.qualifyingopportunityid;
            data.Properties[vocab.qualifyingopportunityidname] = input.qualifyingopportunityidname;
            data.Properties[vocab.relatedobjectid] = input.relatedobjectid;
            data.Properties[vocab.relatedobjectidname] = input.relatedobjectidname;
            data.Properties[vocab.revenue] = input.revenue;
            data.Properties[vocab.revenue_base] = input.revenue_base;
            data.Properties[vocab.salesstage] = input.salesstage;
            data.Properties[vocab.salesstagecode] = input.salesstagecode;
            data.Properties[vocab.salesstagecodename] = input.salesstagecodename;
            data.Properties[vocab.salesstagename] = input.salesstagename;
            data.Properties[vocab.salutation] = input.salutation;
            data.Properties[vocab.schedulefollowup_prospect] = input.schedulefollowup_prospect;
            data.Properties[vocab.schedulefollowup_prospectutc] = input.schedulefollowup_prospectutc;
            data.Properties[vocab.schedulefollowup_qualify] = input.schedulefollowup_qualify;
            data.Properties[vocab.schedulefollowup_qualifyutc] = input.schedulefollowup_qualifyutc;
            data.Properties[vocab.sic] = input.sic;
            data.Properties[vocab.stageid] = input.stageid;
            data.Properties[vocab.statecode] = input.statecode;
            data.Properties[vocab.statecodename] = input.statecodename;
            data.Properties[vocab.statuscode] = input.statuscode;
            data.Properties[vocab.statuscodename] = input.statuscodename;
            data.Properties[vocab.subject] = input.subject;
            data.Properties[vocab.telephone1] = input.telephone1;
            data.Properties[vocab.telephone2] = input.telephone2;
            data.Properties[vocab.telephone3] = input.telephone3;
            data.Properties[vocab.timezoneruleversionnumber] = input.timezoneruleversionnumber;
            data.Properties[vocab.transactioncurrencyid] = input.transactioncurrencyid;
            data.Properties[vocab.transactioncurrencyiddsc] = input.transactioncurrencyiddsc;
            data.Properties[vocab.transactioncurrencyidname] = input.transactioncurrencyidname;
            data.Properties[vocab.traversedpath] = input.traversedpath;
            data.Properties[vocab.utcconversiontimezonecode] = input.utcconversiontimezonecode;
            data.Properties[vocab.versionnumber] = input.versionnumber;
            data.Properties[vocab.websiteurl] = input.websiteurl;
            data.Properties[vocab.yomicompanyname] = input.yomicompanyname;
            data.Properties[vocab.yomifirstname] = input.yomifirstname;
            data.Properties[vocab.yomifullname] = input.yomifullname;
            data.Properties[vocab.yomilastname] = input.yomilastname;
            data.Properties[vocab.yomimiddlename] = input.yomimiddlename;
            data.Properties[vocab.crm_moneyformatstring] = input.crm_moneyformatstring;
            data.Properties[vocab.crm_priceformatstring] = input.crm_priceformatstring;

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
          RuleConstants.DATA_001_File_MustBeIndexed,
          //TODO this should not be necessary - we are setting the URI
          RuleConstants.METADATA_002_Uri_MustBeSet,
          RuleConstants.METADATA_003_Author_Name_MustBeSet
      });

            return clue;
        }
    }
}
