using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.Core.Data
{
    public class ReminderRepository
    {
        public List<StudentFeeAssignment> GetDueOrOverdueAssignments(int daysBeforeDue)
        {
            var list = new List<StudentFeeAssignment>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"
                SELECT AssignmentId, StudentId, FeePlanId, AssignedDate, DueDate, TotalAmount, Status
                FROM StudentFeeAssignments
                WHERE Status <> 'Paid'
                AND (DueDate <= GETDATE()
                OR DATEDIFF(DAY, GETDATE(), DueDate) <= @DaysBeforeDue)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DaysBeforeDue", daysBeforeDue);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new StudentFeeAssignment
                            {
                                AssignmentId = Convert.ToInt32(reader["AssignmentId"]),
                                StudentId = Convert.ToInt32(reader["StudentId"]),
                                FeePlanId = Convert.ToInt32(reader["FeePlanId"]),
                                AssignedDate = Convert.ToDateTime(reader["AssignedDate"]),
                                DueDate = Convert.ToDateTime(reader["DueDate"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        public void InsertReminder(FeeReminder reminder)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"INSERT INTO FeeReminders
                                (AssignmentId, ReminderDate, ReminderType, Message, Status)
                                VALUES (@AssignmentId, @ReminderDate, @ReminderType, @Message, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AssignmentId", reminder.AssignmentId);
                    cmd.Parameters.AddWithValue("@ReminderDate", reminder.ReminderDate);
                    cmd.Parameters.AddWithValue("@ReminderType", reminder.ReminderType);
                    cmd.Parameters.AddWithValue("@Message", reminder.Message);
                    cmd.Parameters.AddWithValue("@Status", reminder.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
