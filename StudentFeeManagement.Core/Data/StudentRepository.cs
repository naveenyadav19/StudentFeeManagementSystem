using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.Core.Data
{
    public class StudentRepository
    {
        public void AddStudent(Student student)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = @"INSERT INTO Students
                                (EnrollmentNo, FullName, Class, ContactNo, Email, IsActive)
                                VALUES (@EnrollmentNo, @FullName, @Class, @ContactNo, @Email, @IsActive)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EnrollmentNo", student.EnrollmentNo);
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@Class", student.Class);
                    cmd.Parameters.AddWithValue("@ContactNo", student.ContactNo);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.AddWithValue("@IsActive", student.IsActive);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string query = "SELECT * FROM Students";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Student
                            {
                                StudentId = Convert.ToInt32(reader["StudentId"]),
                                EnrollmentNo = reader["EnrollmentNo"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Class = reader["Class"].ToString(),
                                ContactNo = reader["ContactNo"].ToString(),
                                Email = reader["Email"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
