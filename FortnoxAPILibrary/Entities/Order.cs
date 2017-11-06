﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5472
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;
using FortnoxAPILibrary.Connectors;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Order
	{

        private string administrationFeeField;

        private string administrationFeeVATField;

		private string address1Field;

		private string address2Field;

		private string basisTaxReductionField;

		private string cancelledField;

		private string cityField;

		private string commentsField;

		private string contributionPercentField;

		private string contributionValueField;

		private string copyRemarksField;

		private string countryField;

		private string costCenterField;

		private string currencyField;

		private string currencyRateField;

		private string currencyUnitField;

		private string customerNameField;

		private string customerNumberField;

		private string deliveryAddress1Field;

		private string deliveryAddress2Field;

		private string deliveryCityField;

		private string deliveryCountryField;

		private string deliveryDateField;

		private string deliveryNameField;

		private string deliveryZipCodeField;

		private string documentNumberField;

		private OrderEmailInformation emailInformationField;

		private string externalInvoiceReference1Field;

		private string externalInvoiceReference2Field;

        private string freightField;

        private string freightVATField;

		private string grossField;

		private string houseWorkField;

		private string invoiceReferenceField;

		private string languageField;

		private string netField;

		private string notCompletedField;

		private string offerReferenceField;

		private string orderDateField;

		private List<OrderRow> orderRowsField;

        private List<Label> labelsField;

		private string organisationNumberField;

		private string ourReferenceField;

		private string phone1Field;

		private string phone2Field;

		private string priceListField;

		private string printTemplateField;

		private string projectField;

		private string remarksField;

		private string roundOffField;

		private string sentField;

		private string taxReductionField;

		private string termsOfDeliveryField;

		private string termsOfPaymentField;

		private string totalField;

		private string totalToPayField;

		private string totalVATField;

		private string vATIncludedField;

		private string wayOfDeliveryField;

		private string yourReferenceField;

		private string yourOrderNumberField;

		private string zipCodeField;

		private string urlField;

		private string urlTaxReductionListField;

        /// <remarks/>
        public Order()
        {
            this.OrderRows = new List<OrderRow>();
            this.Labels = new List<Label>();
        }

		/// <remarks/>
		public string AdministrationFee
		{
			get
			{
				return this.administrationFeeField;
			}
			set
			{
				this.administrationFeeField = value;
			}
		}

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string AdministrationFeeVAT
        {
            get
            {
                return this.administrationFeeVATField;
            }
            set
            {
                this.administrationFeeVATField = value;
            }
        }

		/// <remarks/>
		public string Address1
		{
			get
			{
				return this.address1Field;
			}
			set
			{
				this.address1Field = value;
			}
		}

		/// <remarks/>
		public string Address2
		{
			get
			{
				return this.address2Field;
			}
			set
			{
				this.address2Field = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string BasisTaxReduction
		{
			get
			{
				return this.basisTaxReductionField;
			}
			set
			{
				this.basisTaxReductionField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Cancelled
		{
			get
			{
				return this.cancelledField;
			}
			set
			{
				this.cancelledField = value;
			}
		}

		/// <remarks/>
		public string City
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}

		/// <remarks/>
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string ContributionPercent
		{
			get
			{
				return this.contributionPercentField;
			}
			set
			{
				this.contributionPercentField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string ContributionValue
		{
			get
			{
				return this.contributionValueField;
			}
			set
			{
				this.contributionValueField = value;
			}
		}

		/// <remarks/>
		public string CopyRemarks
		{
			get
			{
				return this.copyRemarksField;
			}
			set
			{
				this.copyRemarksField = value;
			}
		}

		/// <remarks/>
		public string Country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}

		/// <remarks/>
		public string CostCenter
		{
			get
			{
				return this.costCenterField;
			}
			set
			{
				this.costCenterField = value;
			}
		}

		/// <remarks/>
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}

		/// <remarks/>
		public string CurrencyRate
		{
			get
			{
				return this.currencyRateField;
			}
			set
			{
				this.currencyRateField = value;
			}
		}

		/// <remarks/>
		public string CurrencyUnit
		{
			get
			{
				return this.currencyUnitField;
			}
			set
			{
				this.currencyUnitField = value;
			}
		}

		/// <remarks/>
		public string CustomerName
		{
			get
			{
				return this.customerNameField;
			}
			set
			{
				this.customerNameField = value;
			}
		}

		/// <remarks/>
		public string CustomerNumber
		{
			get
			{
				return this.customerNumberField;
			}
			set
			{
				this.customerNumberField = value;
			}
		}

		/// <remarks/>
		public string DeliveryAddress1
		{
			get
			{
				return this.deliveryAddress1Field;
			}
			set
			{
				this.deliveryAddress1Field = value;
			}
		}

		/// <remarks/>
		public string DeliveryAddress2
		{
			get
			{
				return this.deliveryAddress2Field;
			}
			set
			{
				this.deliveryAddress2Field = value;
			}
		}

		/// <remarks/>
		public string DeliveryCity
		{
			get
			{
				return this.deliveryCityField;
			}
			set
			{
				this.deliveryCityField = value;
			}
		}

		/// <remarks/>
		public string DeliveryCountry
		{
			get
			{
				return this.deliveryCountryField;
			}
			set
			{
				this.deliveryCountryField = value;
			}
		}

		/// <remarks/>
		public string DeliveryDate
		{
			get
			{
				return this.deliveryDateField;
			}
			set
			{
				this.deliveryDateField = value;
			}
		}

		/// <remarks/>
		public string DeliveryName
		{
			get
			{
				return this.deliveryNameField;
			}
			set
			{
				this.deliveryNameField = value;
			}
		}

		/// <remarks/>
		public string DeliveryZipCode
		{
			get
			{
				return this.deliveryZipCodeField;
			}
			set
			{
				this.deliveryZipCodeField = value;
			}
		}

		/// <remarks/>
		public string DocumentNumber
		{
			get
			{
				return this.documentNumberField;
			}
			set
			{
				this.documentNumberField = value;
			}
		}

		/// <remarks/>
		public OrderEmailInformation EmailInformation
		{
			get
			{
				return this.emailInformationField;
			}
			set
			{
				this.emailInformationField = value;
			}
		}

		/// <remarks/>
		public string ExternalInvoiceReference1
		{
			get
			{
				return this.externalInvoiceReference1Field;
			}
			set
			{
				this.externalInvoiceReference1Field = value;
			}
		}

		/// <remarks/>
		public string ExternalInvoiceReference2
		{
			get
			{
				return this.externalInvoiceReference2Field;
			}
			set
			{
				this.externalInvoiceReference2Field = value;
			}
		}

		/// <remarks/>
		public string Freight
		{
			get
			{
				return this.freightField;
			}
			set
			{
				this.freightField = value;
			}
		}

        /// <summary>This field is Read-Only in Fortnox</summary>
        [System.ComponentModel.ReadOnly(true)]
        public string FreightVAT
        {
            get
            {
                return this.freightVATField;
            }
            set
            {
                this.freightVATField = value;
            }
        }

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Gross
		{
			get
			{
				return this.grossField;
			}
			set
			{
				this.grossField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string HouseWork
		{
			get
			{
				return this.houseWorkField;
			}
			set
			{
				this.houseWorkField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string InvoiceReference
		{
			get
			{
				return this.invoiceReferenceField;
			}
			set
			{
				this.invoiceReferenceField = value;
			}
		}

		/// <remarks/>
		public string Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Net
		{
			get
			{
				return this.netField;
			}
			set
			{
				this.netField = value;
			}
		}

		/// <remarks/>
		public string NotCompleted
		{
			get
			{
				return this.notCompletedField;
			}
			set
			{
				this.notCompletedField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string OfferReference
		{
			get
			{
				return this.offerReferenceField;
			}
			set
			{
				this.offerReferenceField = value;
			}
		}

		/// <remarks/>
		public string OrderDate
		{
			get
			{
				return this.orderDateField;
			}
			set
			{
				this.orderDateField = value;
			}
		}

		/// <remarks/>
		public List<OrderRow> OrderRows
		{
			get
			{
				return this.orderRowsField;
			}
			set
			{
				this.orderRowsField = value;
			}
		}

        /// <remarks/>
        public List<Label> Labels {
            get {
                return this.labelsField;
            }
            set {
                this.labelsField = value;
            }
        }
        
		/// <remarks/>
		public string OrganisationNumber
		{
			get
			{
				return this.organisationNumberField;
			}
			set
			{
				this.organisationNumberField = value;
			}
		}

		/// <remarks/>
		public string OurReference
		{
			get
			{
				return this.ourReferenceField;
			}
			set
			{
				this.ourReferenceField = value;
			}
		}

		/// <remarks/>
		public string Phone1
		{
			get
			{
				return this.phone1Field;
			}
			set
			{
				this.phone1Field = value;
			}
		}

		/// <remarks/>
		public string Phone2
		{
			get
			{
				return this.phone2Field;
			}
			set
			{
				this.phone2Field = value;
			}
		}

		/// <remarks/>
		public string PriceList
		{
			get
			{
				return this.priceListField;
			}
			set
			{
				this.priceListField = value;
			}
		}

		/// <remarks/>
		public string PrintTemplate
		{
			get
			{
				return this.printTemplateField;
			}
			set
			{
				this.printTemplateField = value;
			}
		}

		/// <remarks/>
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}

		/// <remarks/>
		public string Remarks
		{
			get
			{
				return this.remarksField;
			}
			set
			{
				this.remarksField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string RoundOff
		{
			get
			{
				return this.roundOffField;
			}
			set
			{
				this.roundOffField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Sent
		{
			get
			{
				return this.sentField;
			}
			set
			{
				this.sentField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string TaxReduction
		{
			get
			{
				return this.taxReductionField;
			}
			set
			{
				this.taxReductionField = value;
			}
		}

		/// <remarks/>
		public string TermsOfDelivery
		{
			get
			{
				return this.termsOfDeliveryField;
			}
			set
			{
				this.termsOfDeliveryField = value;
			}
		}

		/// <remarks/>
		public string TermsOfPayment
		{
			get
			{
				return this.termsOfPaymentField;
			}
			set
			{
				this.termsOfPaymentField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Total
		{
			get
			{
				return this.totalField;
			}
			set
			{
				this.totalField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string TotalToPay
		{
			get
			{
				return this.totalToPayField;
			}
			set
			{
				this.totalToPayField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string TotalVAT
		{
			get
			{
				return this.totalVATField;
			}
			set
			{
				this.totalVATField = value;
			}
		}

		/// <remarks/>
		public string VATIncluded
		{
			get
			{
				return this.vATIncludedField;
			}
			set
			{
				this.vATIncludedField = value;
			}
		}

		/// <remarks/>
		public string WayOfDelivery
		{
			get
			{
				return this.wayOfDeliveryField;
			}
			set
			{
				this.wayOfDeliveryField = value;
			}
		}

		/// <remarks/>
		public string YourReference
		{
			get
			{
				return this.yourReferenceField;
			}
			set
			{
				this.yourReferenceField = value;
			}
		}

		/// <remarks/>
		public string YourOrderNumber
		{
			get
			{
				return this.yourOrderNumberField;
			}
			set
			{
				this.yourOrderNumberField = value;
			}
		}

		/// <remarks/>
		public string ZipCode
		{
			get
			{
				return this.zipCodeField;
			}
			set
			{
				this.zipCodeField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string urlTaxReductionList
		{
			get
			{
				return this.urlTaxReductionListField;
			}
			set
			{
				this.urlTaxReductionListField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class OrderEmailInformation
	{
		private string emailAddressFromField;

		private string emailAddressToField;

		private string emailAddressCCField;

		private string emailAddressBCCField;

		private string emailSubjectField;

		private string emailBodyField;

		/// <remarks/>
		public string EmailAddressFrom
		{
			get
			{
				return this.emailAddressFromField;
			}
			set
			{
				this.emailAddressFromField = value;
			}
		}

		/// <remarks/>
		public string EmailAddressTo
		{
			get
			{
				return this.emailAddressToField;
			}
			set
			{
				this.emailAddressToField = value;
			}
		}

		/// <remarks/>
		public string EmailAddressCC
		{
			get
			{
				return this.emailAddressCCField;
			}
			set
			{
				this.emailAddressCCField = value;
			}
		}

		/// <remarks/>
		public string EmailAddressBCC
		{
			get
			{
				return this.emailAddressBCCField;
			}
			set
			{
				this.emailAddressBCCField = value;
			}
		}

		/// <remarks/>
		public string EmailSubject
		{
			get
			{
				return this.emailSubjectField;
			}
			set
			{
				this.emailSubjectField = value;
			}
		}

		/// <remarks/>
		public string EmailBody
		{
			get
			{
				return this.emailBodyField;
			}
			set
			{
				this.emailBodyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class OrderRow
	{

		private string accountNumberField;

		private string articleNumberField;

		private string contributionPercentField;

		private string contributionValueField;

		private string costCenterField;

		private string deliveredQuantityField;

		private string descriptionField;

		private string discountField;

		private OrderConnector.DiscountType discountTypeField;

		private string houseWorkField;

		private string orderedQuantityField;

		private string priceField;

		private string projectField;

		private string totalField;

		private string unitField;

		private string vATField;

		/// <remarks/>
		public string AccountNumber
		{
			get
			{
				return this.accountNumberField;
			}
			set
			{
				this.accountNumberField = value;
			}
		}

		/// <remarks/>
		public string ArticleNumber
		{
			get
			{
				return this.articleNumberField;
			}
			set
			{
				this.articleNumberField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string ContributionPercent
		{
			get
			{
				return this.contributionPercentField;
			}
			set
			{
				this.contributionPercentField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string ContributionValue
		{
			get
			{
				return this.contributionValueField;
			}
			set
			{
				this.contributionValueField = value;
			}
		}

		/// <remarks/>
		public string CostCenter
		{
			get
			{
				return this.costCenterField;
			}
			set
			{
				this.costCenterField = value;
			}
		}

		/// <remarks/>
		public string DeliveredQuantity
		{
			get
			{
				return this.deliveredQuantityField;
			}
			set
			{
				this.deliveredQuantityField = value;
			}
		}

		/// <remarks/>
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string Discount
		{
			get
			{
				return this.discountField;
			}
			set
			{
				this.discountField = value;
			}
		}

		/// <remarks/>
		public OrderConnector.DiscountType DiscountType
		{
			get
			{
				return this.discountTypeField;
			}
			set
			{
				this.discountTypeField = value;
			}
		}

		/// <remarks/>
		public string HouseWork
		{
			get
			{
				return this.houseWorkField;
			}
			set
			{
				this.houseWorkField = value;
			}
		}

		/// <remarks/>
		public string OrderedQuantity
		{
			get
			{
				return this.orderedQuantityField;
			}
			set
			{
				this.orderedQuantityField = value;
			}
		}

		/// <remarks/>
		public string Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}

		/// <remarks/>
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Total
		{
			get
			{
				return this.totalField;
			}
			set
			{
				this.totalField = value;
			}
		}

		/// <remarks/>
		public string Unit
		{
			get
			{
				return this.unitField;
			}
			set
			{
				this.unitField = value;
			}
		}

		/// <remarks/>
		public string VAT
		{
			get
			{
				return this.vATField;
			}
			set
			{
				this.vATField = value;
			}
		}
	}
}