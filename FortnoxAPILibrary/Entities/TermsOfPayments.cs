﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class TermsOfPayments
	{

		private List<TermsOfPaymentSubset> termsOfPaymentSubsetField;

		private string totalResourcesField;

		private string totalPagesField;

		private string currentPageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TermsOfPaymentSubset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public List<TermsOfPaymentSubset> TermsOfPaymentSubset
		{
			get
			{
				return this.termsOfPaymentSubsetField;
			}
			set
			{
				this.termsOfPaymentSubsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalResources
		{
			get
			{
				return this.totalResourcesField;
			}
			set
			{
				this.totalResourcesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalPages
		{
			get
			{
				return this.totalPagesField;
			}
			set
			{
				this.totalPagesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CurrentPage
		{
			get
			{
				return this.currentPageField;
			}
			set
			{
				this.currentPageField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TermsOfPaymentSubset
	{

		private string codeField;

		private string descriptionField;

		private string urlField;

		/// <remarks/>
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
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
	}
}