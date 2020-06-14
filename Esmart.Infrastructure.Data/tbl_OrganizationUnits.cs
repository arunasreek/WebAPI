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
    
    public partial class tbl_OrganizationUnits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OrganizationUnits()
        {
            this.tbl_Assets = new HashSet<tbl_Assets>();
            this.tbl_Stock_Items_Transactions = new HashSet<tbl_Stock_Items_Transactions>();
        }
    
        public long o_id { get; set; }
        public string Org_ID { get; set; }
        public string OrganizationName { get; set; }
        public Nullable<bool> CostCenter { get; set; }
        public Nullable<long> emp_id { get; set; }
        public string ReportingDepartmentID { get; set; }
        public string MD_FirstName { get; set; }
        public string MD_MiddleName { get; set; }
        public string MD_LastName { get; set; }
        public string MD_Email { get; set; }
        public string MD_Designation { get; set; }
        public string MD_Phone { get; set; }
        public string MD_Fax { get; set; }
        public string MD_MobileNo { get; set; }
        public string MD_PreferredContactPerson { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.TimeSpan> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public string Org_Status { get; set; }
        public Nullable<long> b_id { get; set; }
        public Nullable<bool> del_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Assets> tbl_Assets { get; set; }
        public virtual tbl_branches tbl_branches { get; set; }
        public virtual tbl_Employers tbl_Employers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Stock_Items_Transactions> tbl_Stock_Items_Transactions { get; set; }
    }
}
