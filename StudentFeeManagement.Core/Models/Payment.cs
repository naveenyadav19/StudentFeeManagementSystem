using System;

namespace StudentFeeManagement.Core.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int AssignmentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMode { get; set; }
        public string Remarks { get; set; }
    }
}
