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
    
    public partial class Sales_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sales_Order()
        {
            this.Delivery_Order_Note = new HashSet<Delivery_Order_Note>();
            this.Sales_Invoice = new HashSet<Sales_Invoice>();
        }
    
        public string Quotation_ID { get; set; }
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
        public string Order_ID { get; set; }
        public string Customer_ID { get; set; }
        public string EmployerID { get; set; }
        public string BranchID { get; set; }
        public string Status { get; set; }
        public string Name_Of_Rec_Comp { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string CPMobile { get; set; }
        public string CPLandline { get; set; }
        public string Fax { get; set; }
        public string ModeOfShipment { get; set; }
        public string PortOf_Origin { get; set; }
        public string PortOf_Destiny { get; set; }
        public string Shipment_Terms { get; set; }
        public string Delivery_Address { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> Delivery_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery_Order_Note> Delivery_Order_Note { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Invoice> Sales_Invoice { get; set; }
    }
}
