
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace Entities
{
   public class Registration
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public string Password { get; set; }

        public int roleid { get; set; }

        [ForeignKey("roleid")]

        public virtual Role Role { get; set; }


        public DateTime DateOfJoining { get; set; }


        public string Designation { get; set; }
        public int Phone { get; set; }

        public DateTime DateOfBirth { get; set; }


        public string AddressDescription1 { get; set; }

        public string AddressDescription2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
                       
        public int ZipCode { get; set; }
   }
}
