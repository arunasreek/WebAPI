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
    
    public partial class tbl_JobEducation
    {
        public long Education_id { get; set; }
        public Nullable<long> qual_id { get; set; }
        public Nullable<long> speci_id { get; set; }
        public Nullable<long> univer_id { get; set; }
        public string special_course { get; set; }
        public Nullable<System.DateTime> passed_year { get; set; }
        public string institue { get; set; }
        public Nullable<long> JCatalouge_id { get; set; }
    }
}
