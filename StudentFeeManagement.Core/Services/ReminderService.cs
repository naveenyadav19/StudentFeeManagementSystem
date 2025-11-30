using System;
using StudentFeeManagement.Core.Data;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.Core.Services
{
    public class ReminderService
    {
        private ReminderRepository repo = new ReminderRepository();

        public void ProcessReminders(int daysBeforeDue = 7)
        {
            var items = repo.GetDueOrOverdueAssignments(daysBeforeDue);

            foreach (var a in items)
            {
                string type = a.DueDate < DateTime.Today ? "Overdue" : "BeforeDue";

                var reminder = new FeeReminder
                {
                    AssignmentId = a.AssignmentId,
                    ReminderDate = DateTime.Now,
                    ReminderType = type,
                    Message = $"Fee of Rs. {a.TotalAmount} is {type} on {a.DueDate:dd-MM-yyyy}",
                    Status = "Logged"
                };

                repo.InsertReminder(reminder);
            }
        }
    }
}
