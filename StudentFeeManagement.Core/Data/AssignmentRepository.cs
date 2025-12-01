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
        public List<StudentFeeAssignment> GetPendingAssignments()
        {
            var list = new List<StudentFeeAssignment>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"SELECT * FROM StudentFeeAssignments
                             WHERE DueDate < GETDATE()
                             AND Status = 'Pending'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new StudentFeeAssignment
                            {
                                StudentId = Convert.ToInt32(dr["StudentId"]),
                                FeePlanId = Convert.ToInt32(dr["FeePlanId"]),
                                DueDate = Convert.ToDateTime(dr["DueDate"]),
                                TotalAmount = Convert.ToDecimal(dr["TotalAmount"]),
                                Status = dr["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
