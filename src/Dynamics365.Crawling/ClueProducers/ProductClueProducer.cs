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
    public abstract class ProductClueProducer<T> : DynamicsClueProducer<T> where T : Product
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ProductClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ProductId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=product&id={1}", _dynamics365CrawlJobData.Api, input.ProductId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.PriceLevelId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.PriceLevelId);

                         if (input.CreatedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.CreatedByExternalParty);

                         if (input.ModifiedByExternalParty != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.externalparty, EntityEdgeType.Parent, input, input.ModifiedByExternalParty);

                         if (input.SubjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.subject, EntityEdgeType.Parent, input, input.SubjectId);

                         if (input.StageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.StageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.DefaultUoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.DefaultUoMId);

                         if (input.ParentProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ParentProductId);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.DefaultUoMScheduleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uomschedule, EntityEdgeType.Parent, input, input.DefaultUoMScheduleId);


            */
            data.Properties[Dynamics365Vocabulary.Product.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.DefaultUoMScheduleId] = input.DefaultUoMScheduleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.SubjectId] = input.SubjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.DefaultUoMId] = input.DefaultUoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProductTypeCode] = input.ProductTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProductUrl] = input.ProductUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.Price] = input.Price.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.IsKit] = input.IsKit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProductNumber] = input.ProductNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.Size] = input.Size.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CurrentCost] = input.CurrentCost.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StockVolume] = input.StockVolume.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StandardCost] = input.StandardCost.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StockWeight] = input.StockWeight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.QuantityDecimal] = input.QuantityDecimal.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.QuantityOnHand] = input.QuantityOnHand.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.IsStockItem] = input.IsStockItem.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.SupplierName] = input.SupplierName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.VendorName] = input.VendorName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.VendorPartNumber] = input.VendorPartNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.DefaultUoMIdName] = input.DefaultUoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.DefaultUoMScheduleIdName] = input.DefaultUoMScheduleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.SubjectIdName] = input.SubjectIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.IsStockItemName] = input.IsStockItemName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.IsKitName] = input.IsKitName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProductTypeCodeName] = input.ProductTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CurrentCost_Base] = input.CurrentCost_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.Price_Base] = input.Price_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StandardCost_Base] = input.StandardCost_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ParentProductId] = input.ParentProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ParentProductIdName] = input.ParentProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProductStructure] = input.ProductStructure.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ProductStructureName] = input.ProductStructureName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.VendorID] = input.VendorID.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ValidFromDate] = input.ValidFromDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ValidToDate] = input.ValidToDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.HierarchyPath] = input.HierarchyPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.DMTImportState] = input.DMTImportState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedByExternalParty] = input.CreatedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedByExternalPartyName] = input.CreatedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.CreatedByExternalPartyYomiName] = input.CreatedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedByExternalParty] = input.ModifiedByExternalParty.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedByExternalPartyName] = input.ModifiedByExternalPartyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.ModifiedByExternalPartyYomiName] = input.ModifiedByExternalPartyYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.IsReparented] = input.IsReparented.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Product.isreparentedName] = input.isreparentedName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

