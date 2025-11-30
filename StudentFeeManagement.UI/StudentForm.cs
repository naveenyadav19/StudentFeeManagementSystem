using System;
using System.Windows.Forms;
using StudentFeeManagement.Core.Data;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.UI
{
    public partial class StudentForm : Form
    {
        private readonly StudentRepository repo;

        public StudentForm()
        {
            InitializeComponent();
            repo = new StudentRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                EnrollmentNo = txtEnrollmentNo.Text,
                FullName = txtFullName.Text,
                Class = txtClass.Text,
                ContactNo = txtContactNo.Text,
                Email = txtEmail.Text,
                IsActive = chkIsActive.Checked
            };

            repo.AddStudent(student);

            MessageBox.Show("Student Added Successfully!", "Success");

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
