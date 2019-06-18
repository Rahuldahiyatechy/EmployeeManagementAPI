using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class RegistrationDto
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string Password { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string Designation { get; set; }

        public int Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string AddressDescription1 { get; set; }

        public string AddressDescription2 { get; set; }
        //public string Hometown { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }
        //below field belongs from the Role Table
        public int roleid { get; set; }
        public string RoleType { get; set; }
    }
}
