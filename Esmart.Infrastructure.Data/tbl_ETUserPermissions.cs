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
    
    public partial class tbl_ETUserPermissions
    {
        public long EUPermission_id { get; set; }
        public Nullable<long> Eservice_Id { get; set; }
        public Nullable<bool> f_Add { get; set; }
        public Nullable<bool> f_Edit { get; set; }
        public Nullable<bool> f_View { get; set; }
        public Nullable<bool> f_Status { get; set; }
        public Nullable<bool> f_Delete { get; set; }
        public Nullable<bool> f_Print { get; set; }
        public Nullable<bool> f_Approve { get; set; }
        public Nullable<bool> f_Post { get; set; }
        public Nullable<long> User_id { get; set; }
        public Nullable<System.DateTime> Sys_date { get; set; }
        public Nullable<System.TimeSpan> sys_time { get; set; }
        public string UpdateUser_id { get; set; }
        public string UpdateUserName { get; set; }
        public Nullable<long> UserGrp_id { get; set; }
    }
}
