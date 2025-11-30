namespace StudentFeeManagement.UI
{
    partial class MainForm
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnManageFeePlans = new System.Windows.Forms.Button();
            this.btnAssignFee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(127, 76);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(240, 150);
            this.dgvStudents.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(291, 272);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnManageFeePlans
            // 
            this.btnManageFeePlans.Location = new System.Drawing.Point(522, 105);
            this.btnManageFeePlans.Name = "btnManageFeePlans";
            this.btnManageFeePlans.Size = new System.Drawing.Size(75, 23);
            this.btnManageFeePlans.TabIndex = 2;
            this.btnManageFeePlans.Text = "Manage Fee Plans";
            this.btnManageFeePlans.UseVisualStyleBackColor = true;
            this.btnManageFeePlans.Click += new System.EventHandler(this.btnManageFeePlans_Click);
            // 
            // btnAssignFee
            // 
            this.btnAssignFee.Location = new System.Drawing.Point(522, 168);
            this.btnAssignFee.Name = "btnAssignFee";
            this.btnAssignFee.Size = new System.Drawing.Size(75, 23);
            this.btnAssignFee.TabIndex = 3;
            this.btnAssignFee.Text = "Assign Fee";
            this.btnAssignFee.UseVisualStyleBackColor = true;
            this.btnAssignFee.Click += new System.EventHandler(this.btnAssignFee_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssignFee);
            this.Controls.Add(this.btnManageFeePlans);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dgvStudents);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnManageFeePlans;
        private System.Windows.Forms.Button btnAssignFee;
    }
}

