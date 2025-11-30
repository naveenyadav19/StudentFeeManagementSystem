using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeeManagement.Core.Models
{
    public class FeePlan
    {
        public int FeePlanId { get; set; }
        public string FeeName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int DefaultDueDays { get; set; }
        public bool IsActive { get; set; }
    }
}
