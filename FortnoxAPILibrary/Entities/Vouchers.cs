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


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Vouchers {
    
    private List<VoucherSubset> voucherSubsetField;

	private string totalResourcesField;

	private string totalPagesField;

	private string currentPageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("VoucherSubset")]
    public List<VoucherSubset> VoucherSubset {
        get {
            return this.voucherSubsetField;
        }
        set {
            this.voucherSubsetField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class VoucherSubset {

    private string referenceNumberField;

	private string referenceTypeField;
    
    private string voucherNumberField;
    
    private string voucherSeriesField;
    
    private string yearField;
    
    private string urlField;
    
    /// <remarks/>
	public string ReferenceNumber {
        get {
            return this.referenceNumberField;
        }
        set {
            this.referenceNumberField = value;
        }
    }
    
    /// <remarks/>
	public string ReferenceType
	{
        get {
            return this.referenceTypeField;
        }
        set {
            this.referenceTypeField = value;
        }
    }
    
    /// <remarks/>
    public string VoucherNumber {
        get {
            return this.voucherNumberField;
        }
        set {
            this.voucherNumberField = value;
        }
    }
    
    /// <remarks/>
    public string VoucherSeries {
        get {
            return this.voucherSeriesField;
        }
        set {
            this.voucherSeriesField = value;
        }
    }
    
    /// <remarks/>
    public string Year {
        get {
            return this.yearField;
        }
        set {
            this.yearField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url {
        get {
            return this.urlField;
        }
        set {
            this.urlField = value;
        }
    }
}
