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
    
    public partial class Sales_Invoice
    {
        public string Order_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string CP_Person_Name { get; set; }
        public string CP_MobileNo { get; set; }
        public Nullable<System.DateTime> Date_Of_Delivery { get; set; }
        public string Create_UserID { get; set; }
        public string Create_UserName { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.DateTime> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public string Invoice_ID { get; set; }
        public Nullable<long> EmployerID { get; set; }
        public string Customer_ID { get; set; }
        public string GrandTotal { get; set; }
        public string Status { get; set; }
        public string BranchID { get; set; }
    
        public virtual Sales_Order Sales_Order { get; set; }
    }
}
