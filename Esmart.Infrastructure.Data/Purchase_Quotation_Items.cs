//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Esmart.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase_Quotation_Items
    {
        public string Quotation_ID { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Quantity { get; set; }
        public string Rate { get; set; }
        public string Discount { get; set; }
        public string TotalAmount { get; set; }
        public string RequisitionID { get; set; }
        public Nullable<decimal> CGST { get; set; }
        public Nullable<decimal> SGST { get; set; }
        public Nullable<decimal> IGST { get; set; }
        public string HSN_Code { get; set; }
    }
}
