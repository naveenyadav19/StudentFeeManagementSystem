using StudentFeeManagement.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StudentFeeManagement.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            CheckDueFees();
        }
        public void StartDebug()
        {
            OnStart(null);
        }

        private void CheckDueFees()
        {
            var repo = new AssignmentRepository();

            var list = repo.GetPendingAssignments();

            foreach (var a in list)
            {
                File.AppendAllText(
    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\FeeReminders.txt",
    $"Reminder: StudentId {a.StudentId} has pending fee.\n");

            }
        }


        protected override void OnStop()
        {
        }
    }
}
