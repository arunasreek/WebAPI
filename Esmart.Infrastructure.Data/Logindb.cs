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
    
    public partial class Logindb
    {
        public long E_id { get; set; }
        public string E_name { get; set; }
        public string user_id { get; set; }
        public string password { get; set; }
        public Nullable<long> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<long> modifiedby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public Nullable<bool> user_status { get; set; }
    }
}
