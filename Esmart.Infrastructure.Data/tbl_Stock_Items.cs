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
    
    public partial class tbl_Stock_Items
    {
        public long stockitem_id { get; set; }
        public string ItemCode { get; set; }
        public Nullable<long> itemgroup_id { get; set; }
        public string ItemName { get; set; }
        public decimal GSTRate { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string UnitOfMeasure { get; set; }
        public string SIStatus { get; set; }
        public string OpeningBalance { get; set; }
        public string ReorderLevelQuantity { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.TimeSpan> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public Nullable<System.DateTime> GST_Rate_Effective_Date { get; set; }
        public string Parent_Group { get; set; }
        public string HSN_Code { get; set; }
        public string GST_CESS { get; set; }
        public string Quantity { get; set; }
        public string StockValMethod { get; set; }
        public string Closing_Balance { get; set; }
        public Nullable<decimal> Purchase_Cost { get; set; }
        public Nullable<long> itemcat_id { get; set; }
        public Nullable<bool> del_status { get; set; }
    }
}
