using System;
using System.Windows.Forms;
using StudentFeeManagement.Core.Data;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.UI
{
    public partial class AssignFeeForm : Form
    {
        AssignmentRepository asRepo;
        StudentRepository sRepo;
        FeePlanRepository fRepo;

        public AssignFeeForm()
        {
            InitializeComponent();
            asRepo = new AssignmentRepository();
            sRepo = new StudentRepository();
            fRepo = new FeePlanRepository();
        }

        private void AssignFeeForm_Load(object sender, EventArgs e)
        {
            cmbStudents.DataSource = sRepo.GetAllStudents();
            cmbStudents.DisplayMember = "FullName";
            cmbStudents.ValueMember = "StudentId";

            cmbFeePlans.DataSource = fRepo.GetAll();
            cmbFeePlans.DisplayMember = "FeeName";
            cmbFeePlans.ValueMember = "FeePlanId";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var assignment = new StudentFeeAssignment
            {
                StudentId = (int)cmbStudents.SelectedValue,
                FeePlanId = (int)cmbFeePlans.SelectedValue,
                AssignedDate = DateTime.Now,
                DueDate = dtpDueDate.Value,
                TotalAmount = Convert.ToDecimal(txtAmount.Text),
                Status = "Pending"
            };

            asRepo.AssignFee(assignment);

            MessageBox.Show("Fee Assigned Successfully!");
            Close();
        }
    }
}
