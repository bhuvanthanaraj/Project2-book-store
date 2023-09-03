using System;
using System.Collections.Generic;

namespace Stu_reg_API.Models
{
    public partial class StuReg
    {
        public string StudentName { get; set; } = null!;
        public string StudentCode { get; set; } = null!;
        public string? Department { get; set; }
        public string? Gender { get; set; }
        public string? EmailId { get; set; }
        public DateTime? Dob { get; set; }
    }
}
