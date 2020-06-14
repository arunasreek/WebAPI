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
    
    public partial class tbl_ChartOfAccount
    {
        public long Account_id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public Nullable<double> Opening_Bal { get; set; }
        public Nullable<double> Budget_Amount { get; set; }
        public Nullable<double> Actual_Amount { get; set; }
        public string Create_UserID { get; set; }
        public string Create_UserName { get; set; }
        public Nullable<System.TimeSpan> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public Nullable<long> Ep_id { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<long> b_id { get; set; }
        public Nullable<long> o_id { get; set; }
        public string ParentGroup { get; set; }
        public Nullable<double> CurrentLedgerBalance { get; set; }
        public Nullable<bool> default_status { get; set; }
        public Nullable<bool> del_status { get; set; }
        public Nullable<long> project_id { get; set; }
        public Nullable<double> Opening_Balance_Imported { get; set; }
        public Nullable<long> supp_id { get; set; }
        public Nullable<long> cust_id { get; set; }
        public Nullable<long> asset_id { get; set; }
        public string EnterpriseID { get; set; }
        public string EmployerID { get; set; }
        public string BranchId { get; set; }
        public string Org_ID { get; set; }
        public string ProjectID { get; set; }
    
        public virtual Enterprise Enterprise { get; set; }
        public virtual tbl_branches tbl_branches { get; set; }
        public virtual tbl_Employers tbl_Employers { get; set; }
    }
}