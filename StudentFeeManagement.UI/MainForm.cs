using System;
using System.Windows.Forms;
using StudentFeeManagement.Core.Data;

namespace StudentFeeManagement.UI
{
    public partial class MainForm : Form
    {
        private readonly StudentRepository repo;

        public MainForm()
        {
            InitializeComponent();
            repo = new StudentRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            var list = repo.GetAllStudents();
            dgvStudents.DataSource = list;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (var f = new StudentForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }

        private void btnManageFeePlans_Click(object sender, EventArgs e)
        {
            using (var f = new FeePlanForm())
            {
                f.ShowDialog();
            }
        }

        private void btnAssignFee_Click(object sender, EventArgs e)
        {
            using (var f = new AssignFeeForm())
            {
                f.ShowDialog();
            }

        }
    }
}
