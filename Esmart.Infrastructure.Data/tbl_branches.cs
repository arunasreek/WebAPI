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
    
    public partial class tbl_branches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_branches()
        {
            this.tbl_Assets = new HashSet<tbl_Assets>();
            this.tbl_ChartOfAccount = new HashSet<tbl_ChartOfAccount>();
            this.tbl_Employees = new HashSet<tbl_Employees>();
            this.tbl_OrganizationUnits = new HashSet<tbl_OrganizationUnits>();
            this.tbl_Stock_Items_Transactions = new HashSet<tbl_Stock_Items_Transactions>();
        }
    
        public string BranchId { get; set; }
        public Nullable<long> emp_id { get; set; }
        public string BranchName { get; set; }
        public string BranchCountry { get; set; }
        public string BranchCurrency { get; set; }
        public string BranchState { get; set; }
        public long b_id { get; set; }
        public Nullable<bool> cost_center { get; set; }
        public Nullable<bool> sales_outlet { get; set; }
        public Nullable<bool> warehouse { get; set; }
        public Nullable<bool> stock_point { get; set; }
        public string branch_taxid { get; set; }
        public string manager_name { get; set; }
        public Nullable<long> city_id { get; set; }
        public Nullable<long> state_id { get; set; }
        public Nullable<long> country_id { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string landline_no { get; set; }
        public string fax { get; set; }
        public string mobile_no { get; set; }
        public string website { get; set; }
        public string BranchCity { get; set; }
        public Nullable<bool> del_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Assets> tbl_Assets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChartOfAccount> tbl_ChartOfAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Employees> tbl_Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OrganizationUnits> tbl_OrganizationUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Stock_Items_Transactions> tbl_Stock_Items_Transactions { get; set; }
    }
}