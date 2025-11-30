using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.Core.Data
{
    public class FeePlanRepository
    {
        public void AddFeePlan(FeePlan plan)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"INSERT INTO FeePlans
                                (FeeName, Amount)
                                VALUES (@FeeName, @Amount)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FeeName", plan.FeeName);
                    cmd.Parameters.AddWithValue("@Amount", plan.Amount);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FeePlan> GetAll()
        {
            var list = new List<FeePlan>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT FeePlanId, FeeName, Amount FROM FeePlans";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new FeePlan
                            {
                                FeePlanId = Convert.ToInt32(reader["FeePlanId"]),
                                FeeName = reader["FeeName"].ToString(),
                                Amount = Convert.ToDecimal(reader["Amount"])
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
