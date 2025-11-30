namespace StudentFeeManagement.UI
{
    partial class AssignFeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbFeePlans = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(124, 89);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(121, 21);
            this.cmbStudents.TabIndex = 0;
            // 
            // cmbFeePlans
            // 
            this.cmbFeePlans.FormattingEnabled = true;
            this.cmbFeePlans.Location = new System.Drawing.Point(124, 143);
            this.cmbFeePlans.Name = "cmbFeePlans";
            this.cmbFeePlans.Size = new System.Drawing.Size(121, 21);
            this.cmbFeePlans.TabIndex = 1;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(124, 189);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(124, 229);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(148, 310);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Fee";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // AssignFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.cmbFeePlans);
            this.Controls.Add(this.cmbStudents);
            this.Name = "AssignFeeForm";
            this.Text = "AssignFeeForm";
            this.Load += new System.EventHandler(this.AssignFeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbFeePlans;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAssign;
    }
}