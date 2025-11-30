using System;
using System.Windows.Forms;
using StudentFeeManagement.Core.Data;
using StudentFeeManagement.Core.Models;

namespace StudentFeeManagement.UI
{
    public partial class FeePlanForm : Form
    {
        private readonly FeePlanRepository repo;

        public FeePlanForm()
        {
            InitializeComponent();
            repo = new FeePlanRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var plan = new FeePlan
            {
                FeeName = txtFeeName.Text,
                Amount = decimal.Parse(txtAmount.Text)
            };

            repo.AddFeePlan(plan);

            MessageBox.Show("Fee Plan Saved Successfully!");

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
