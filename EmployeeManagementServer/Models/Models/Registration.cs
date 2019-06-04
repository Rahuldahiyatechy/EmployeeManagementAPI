using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    class Registration
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }


        public string Password { get; set; }

        public int RoleId { get; set; }

        public DateTime DateofJoining { get; set; }


        public string Designation { get; set; }
        public int Phone { get; set; }

        public DateTime DateOfBirth { get; set; }


        public string Hometown { get; set; }
        public string Disttrict { get; set; }

        public string State { get; set; }


        
        public int ZipCode { get; set; }

      

    }
}
