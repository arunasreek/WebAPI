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
    
    public partial class tbl_Assets
    {
        public long asset_id { get; set; }
        public string AssetID { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<long> o_id { get; set; }
        public Nullable<long> b_id { get; set; }
        public string AssetType { get; set; }
        public string AssetDescription { get; set; }
        public Nullable<System.DateTime> AcquireDate { get; set; }
        public Nullable<System.DateTime> WarrentyExpiryDate { get; set; }
        public string VD_FirstName { get; set; }
        public string VD_MiddleName { get; set; }
        public string VD_LastName { get; set; }
        public string VD_Designation { get; set; }
        public string VD_Email { get; set; }
        public string VD_Phone { get; set; }
        public string VD_Fax { get; set; }
        public string VD_MobileNo { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.TimeSpan> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public string MethodOfDepreciation { get; set; }
        public Nullable<int> NoOfYearsDepreciationCompleted { get; set; }
        public Nullable<double> CostOfAsset { get; set; }
        public Nullable<double> SlavageValue { get; set; }
        public Nullable<int> NoOfYearsOfLife { get; set; }
        public string PurchaseType { get; set; }
        public Nullable<int> RelatedFixedAssetsAccountId { get; set; }
        public Nullable<int> RelatedAccumulatedDepreciation { get; set; }
        public Nullable<int> RelatedDepreciationExpense { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<bool> IsRejected { get; set; }
        public Nullable<bool> del_status { get; set; }
        public Nullable<long> supp_id { get; set; }
    
        public virtual tbl_branches tbl_branches { get; set; }
        public virtual tbl_Employers tbl_Employers { get; set; }
        public virtual tbl_OrganizationUnits tbl_OrganizationUnits { get; set; }
    }
}
