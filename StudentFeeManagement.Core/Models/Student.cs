namespace StudentFeeManagement.Core.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string EnrollmentNo { get; set; }
        public string FullName { get; set; }
        public string Class { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
