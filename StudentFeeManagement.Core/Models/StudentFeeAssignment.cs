using System;

namespace StudentFeeManagement.Core.Models
{
    public class StudentFeeAssignment
    {
        public int AssignmentId { get; set; }
        public int StudentId { get; set; }
        public int FeePlanId { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
