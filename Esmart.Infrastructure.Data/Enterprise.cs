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
    
    public partial class Enterprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enterprise()
        {
            this.tbl_ChartOfAccount = new HashSet<tbl_ChartOfAccount>();
        }
    
        public string EnterpriseID { get; set; }
        public string EnterpriseName { get; set; }
        public bool ParentEnterprise { get; set; }
        public string PermanentRegistration { get; set; }
        public string LoginID { get; set; }
        public string Password { get; set; }
        public System.DateTime DateOfInception { get; set; }
        public System.DateTime DateOfExpiry { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string PostBox { get; set; }
        public string ZipCode { get; set; }
        public string LandLine { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public string AR_EmployeeID { get; set; }
        public string AR_FirstName { get; set; }
        public string AR_MiddleName { get; set; }
        public string AR_LastName { get; set; }
        public string AR_Email { get; set; }
        public string AR_Designation { get; set; }
        public string AR_Phone { get; set; }
        public string AR_Fax { get; set; }
        public string AR_MobileNo { get; set; }
        public string AR_PreferredContactPerson { get; set; }
        public string OCP_EmployeeID { get; set; }
        public string OCP_FirstName { get; set; }
        public string OCP_MiddleName { get; set; }
        public string OCP_LastName { get; set; }
        public string OCP_Email { get; set; }
        public string OCP_Designation { get; set; }
        public string OCP_Phone { get; set; }
        public string OCP_Fax { get; set; }
        public string OCP_MobileNo { get; set; }
        public string OCP_PreferredContactPerson { get; set; }
        public string Create_UserID { get; set; }
        public string Create_UserName { get; set; }
        public string Update_UserID { get; set; }
        public string Update_UserName { get; set; }
        public Nullable<System.DateTime> Sys_Time { get; set; }
        public Nullable<System.DateTime> Sys_Date { get; set; }
        public string EnterpriseBanner { get; set; }
        public string EnterpriseLogo { get; set; }
        public string DBLocation { get; set; }
        public string ApplicationLocation { get; set; }
        public string BackupLocation { get; set; }
        public string MailIdLocation { get; set; }
        public string PrimaryFunctionalCurrency { get; set; }
        public string PayPeriodType { get; set; }
        public string EmployerTaxNo { get; set; }
        public string EmployerPanNo { get; set; }
        public string EmployerDinNo { get; set; }
        public string EmployerBinNo { get; set; }
        public Nullable<System.DateTime> FinancialYearStartDate { get; set; }
        public Nullable<System.DateTime> FinancialYearEndDate { get; set; }
        public string Ent_Status { get; set; }
        public long Ep_id { get; set; }
        public Nullable<long> country_id { get; set; }
        public Nullable<long> state_id { get; set; }
        public Nullable<long> city_id { get; set; }
        public Nullable<bool> del_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChartOfAccount> tbl_ChartOfAccount { get; set; }
    }
}
