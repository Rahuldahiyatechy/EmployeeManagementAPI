using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
   public class AdminDto
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime TotalTime { get; set; }
    }
}
