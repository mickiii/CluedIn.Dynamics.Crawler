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
    public abstract class OpportunityProductClueProducer<T> : DynamicsClueProducer<T> where T : OpportunityProduct
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public OpportunityProductClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.OpportunityProductId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=opportunityproduct&id={1}", _dynamics365CrawlJobData.Api, input.OpportunityProductId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.OpportunityProductName;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ProductAssociationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productassociation, EntityEdgeType.Parent, input, input.ProductAssociationId);

                         if (input.UoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.UoMId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.OpportunityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.OpportunityId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.ParentBundleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityproduct, EntityEdgeType.Parent, input, input.ParentBundleId);

                         if (input.ParentBundleIdRef != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunityproduct, EntityEdgeType.Parent, input, input.ParentBundleIdRef);


            */
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OpportunityProductId] = input.OpportunityProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.IsProductOverridden] = input.IsProductOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.IsPriceOverridden] = input.IsPriceOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.PricePerUnit] = input.PricePerUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.BaseAmount] = input.BaseAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ExtendedAmount] = input.ExtendedAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.UoMId] = input.UoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ManualDiscountAmount] = input.ManualDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.VolumeDiscountAmount] = input.VolumeDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.Tax] = input.Tax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductDescription] = input.ProductDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.UoMIdName] = input.UoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.IsPriceOverriddenName] = input.IsPriceOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.IsProductOverriddenName] = input.IsProductOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OpportunityStateCode] = input.OpportunityStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OpportunityStateCodeName] = input.OpportunityStateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.BaseAmount_Base] = input.BaseAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ManualDiscountAmount_Base] = input.ManualDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.VolumeDiscountAmount_Base] = input.VolumeDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.PricePerUnit_Base] = input.PricePerUnit_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.Tax_Base] = input.Tax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ExtendedAmount_Base] = input.ExtendedAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.LineItemNumber] = input.LineItemNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ParentBundleId] = input.ParentBundleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductTypeCode] = input.ProductTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductTypeCodeName] = input.ProductTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.PropertyConfigurationStatus] = input.PropertyConfigurationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.PropertyConfigurationStatusName] = input.PropertyConfigurationStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductAssociationId] = input.ProductAssociationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ProductName] = input.ProductName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.OpportunityProductName] = input.OpportunityProductName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.ParentBundleIdRef] = input.ParentBundleIdRef.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.OpportunityProduct.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

