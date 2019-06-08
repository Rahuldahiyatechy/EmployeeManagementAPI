using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
   public class TimeTracker
    {
        [Key]
        public int TimeTrackerId { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Registration Registration { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
                                
    }
}
