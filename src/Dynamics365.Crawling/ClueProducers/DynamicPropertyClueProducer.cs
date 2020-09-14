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
    public abstract class DynamicPropertyClueProducer<T> : DynamicsClueProducer<T> where T : DynamicProperty
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DynamicPropertyClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DynamicPropertyId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=dynamicproperty&id={1}", _dynamics365CrawlJobData.Api, input.DynamicPropertyId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.BaseDynamicPropertyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicproperty, EntityEdgeType.Parent, input, input.BaseDynamicPropertyId);

                         if (input.DefaultValueOptionSet != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.dynamicpropertyoptionsetitem, EntityEdgeType.Parent, input, input.DefaultValueOptionSet);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productassociation, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DynamicPropertyId] = input.DynamicPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DataType] = input.DataType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DefaultValueInteger] = input.DefaultValueInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DefaultValueString] = input.DefaultValueString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DefaultValueDecimal] = input.DefaultValueDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.BaseDynamicPropertyId] = input.BaseDynamicPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.BaseDynamicPropertyIdName] = input.BaseDynamicPropertyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MinValueDecimal] = input.MinValueDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MaxValueDecimal] = input.MaxValueDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.Precision] = input.Precision.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.RegardingObjectIdName] = input.RegardingObjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DefaultValueDouble] = input.DefaultValueDouble.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MinValueDouble] = input.MinValueDouble.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MaxValueDouble] = input.MaxValueDouble.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MinValueInteger] = input.MinValueInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MaxValueInteger] = input.MaxValueInteger.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.IsReadOnly] = input.IsReadOnly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.IsHidden] = input.IsHidden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.IsRequired] = input.IsRequired.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.OverwrittenDynamicPropertyId] = input.OverwrittenDynamicPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.RootDynamicPropertyId] = input.RootDynamicPropertyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.MaxLengthString] = input.MaxLengthString.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DefaultValueOptionSet] = input.DefaultValueOptionSet.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DefaultValueOptionSetName] = input.DefaultValueOptionSetName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.RegardingObjectTypeCode] = input.RegardingObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DMTImportState] = input.DMTImportState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.IsReadOnlyName] = input.IsReadOnlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.IsHiddenName] = input.IsHiddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.IsRequiredName] = input.IsRequiredName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.DataTypeName] = input.DataTypeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DynamicProperty.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

