using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.Core.Data
{
    public class AssignmentRepository
    {
        public void AssignFee(StudentFeeAssignment a)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"INSERT INTO StudentFeeAssignments
                                (StudentId, FeePlanId, AssignedDate, DueDate, TotalAmount, Status)
                                VALUES (@StudentId, @FeePlanId, @AssignedDate, @DueDate, @TotalAmount, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", a.StudentId);
                    cmd.Parameters.AddWithValue("@FeePlanId", a.FeePlanId);
                    cmd.Parameters.AddWithValue("@AssignedDate", a.AssignedDate);
                    cmd.Parameters.AddWithValue("@DueDate", a.DueDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", a.TotalAmount);
                    cmd.Parameters.AddWithValue("@Status", a.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
