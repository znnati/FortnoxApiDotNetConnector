﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FortnoxAPILibrary
{
    /// <remarks/>
    public class Contracts
    {
        /// <remarks/>
        [XmlElementAttribute("ContractSubset")]
        public List<ContractSubset> ContractSubset { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TotalResources { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TotalPages { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string CurrentPage { get; set; }
    }

    /// <remarks/>
    public class ContractSubset
    {
        /// <remarks/>
        [XmlAttributeAttribute]
        public string url { get; set; }

        /// <remarks/>
        public string Continuous { get; set; }

        /// <remarks/>
        public string ContractLength { get; set; }

        /// <remarks/>
        public string Currency { get; set; }

        /// <remarks/>
        public string CustomerName { get; set; }

        /// <remarks/>
        public string CustomerNumber { get; set; }

        /// <remarks/>
        public string DocumentNumber { get; set; }

        /// <remarks/>
        public string InvoiceInterval { get; set; }

        /// <remarks/>
        public string InvoicesRemaining { get; set; }

        /// <remarks/>
        public string LastInvoiceDate { get; set; }

        /// <remarks/>
        public string PeriodStart { get; set; }

        /// <remarks/>
        public string PeriodEnd { get; set; }

        /// <remarks/>
        public string Status { get; set; }

        /// <remarks/>
        public string TemplateNumber { get; set; }

        /// <remarks/>
        public string Total { get; set; }
    }
}