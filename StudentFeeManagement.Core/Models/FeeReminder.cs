using System;

namespace StudentFeeManagement.Core.Models
{
    public class FeeReminder
    {
        public int ReminderId { get; set; }
        public int AssignmentId { get; set; }
        public DateTime ReminderDate { get; set; }
        public string ReminderType { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
