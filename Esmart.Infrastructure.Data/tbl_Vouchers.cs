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
    
    public partial class tbl_Vouchers
    {
        public long VoucherNo { get; set; }
        public string VoucherUserNo { get; set; }
        public Nullable<System.DateTime> VoucherDate { get; set; }
        public string AmountIn_Words { get; set; }
        public Nullable<System.DateTime> RecDate { get; set; }
        public string Currency { get; set; }
        public string Amount { get; set; }
        public string From { get; set; }
        public string TransactionType { get; set; }
        public string updateuser_id { get; set; }
        public string updateuser_name { get; set; }
        public Nullable<System.TimeSpan> sys_time { get; set; }
        public Nullable<System.DateTime> sys_date { get; set; }
        public bool IsApproved { get; set; }
        public string ApprovedBy { get; set; }
        public string RejectedBy { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string ChequeNo { get; set; }
        public string DateOfCheque { get; set; }
        public string ChequeAmount { get; set; }
        public Nullable<System.DateTime> DateApprovedBy { get; set; }
        public Nullable<System.DateTime> DateRejectedBy { get; set; }
        public string invoiceNo { get; set; }
        public string Status { get; set; }
        public string Narration { get; set; }
    }
}