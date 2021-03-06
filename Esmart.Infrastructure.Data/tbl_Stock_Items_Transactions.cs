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
    
    public partial class tbl_Stock_Items_Transactions
    {
        public long stocktrans_id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> unit_id { get; set; }
        public string Stock_IN { get; set; }
        public string Batch_No { get; set; }
        public Nullable<System.DateTime> Date_Of_Manufacture { get; set; }
        public Nullable<System.DateTime> Date_Of_Packing { get; set; }
        public Nullable<System.DateTime> Date_Of_Expiry { get; set; }
        public Nullable<long> b_id { get; set; }
        public Nullable<long> floor_id { get; set; }
        public Nullable<long> rack_id { get; set; }
        public Nullable<long> row_id { get; set; }
        public string Stock_OUT { get; set; }
        public string Current_Balance { get; set; }
        public string VoucherNumber { get; set; }
        public Nullable<System.DateTime> trans_date { get; set; }
        public Nullable<bool> del_status { get; set; }
        public string bar_code { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<long> o_id { get; set; }
        public Nullable<long> project_id { get; set; }
        public string Narration { get; set; }
        public Nullable<double> stock_value { get; set; }
    
        public virtual tbl_branches tbl_branches { get; set; }
        public virtual tbl_Employers tbl_Employers { get; set; }
        public virtual tbl_Floors tbl_Floors { get; set; }
        public virtual tbl_OrganizationUnits tbl_OrganizationUnits { get; set; }
        public virtual tbl_Projects tbl_Projects { get; set; }
        public virtual tbl_Racks tbl_Racks { get; set; }
        public virtual tbl_Rows tbl_Rows { get; set; }
        public virtual tbl_UnitOfMeasure tbl_UnitOfMeasure { get; set; }
    }
}
