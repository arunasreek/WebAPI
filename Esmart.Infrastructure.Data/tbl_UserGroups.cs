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
    
    public partial class tbl_UserGroups
    {
        public long UserGrp_id { get; set; }
        public string Group_Id { get; set; }
        public Nullable<bool> G_Status { get; set; }
        public string Group_name { get; set; }
        public string group_type { get; set; }
        public string Group_lang { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.DateTime> Sys_date { get; set; }
        public Nullable<System.TimeSpan> sys_time { get; set; }
    }
}
