using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COnt.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Adress { get; set; }
    }
}