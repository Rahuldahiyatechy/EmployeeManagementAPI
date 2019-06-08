using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
   public class TimeTrackerDto
    {

        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
