using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COnt.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Display(Name = "Please Enter your Name")]
        public string Name { get; set; }

        [Display(Name="Eamil Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool isEmployee { get; set; }

        [DataType(DataType.Date)]
        public DateTime dateTime { get; set; }
    }
}