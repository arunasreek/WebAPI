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
    
    public partial class tbl_JobCatalouge
    {
        public long JCatalouge_id { get; set; }
        public string JobCode { get; set; }
        public string JobTitle { get; set; }
        public Nullable<long> JGroup_id { get; set; }
        public Nullable<long> jobclass_id { get; set; }
        public Nullable<long> Jobcat_id { get; set; }
        public Nullable<bool> SupervisorFlag { get; set; }
        public string GenderRestriction { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.DateTime> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public Nullable<bool> del_status { get; set; }
        public string JobClassID { get; set; }
        public string JobCategoryID { get; set; }
        public string JobGroupID { get; set; }
    
        public virtual tbl_JobCategory tbl_JobCategory { get; set; }
        public virtual tbl_JobClass tbl_JobClass { get; set; }
        public virtual tbl_JobGroup tbl_JobGroup { get; set; }
    }
}
