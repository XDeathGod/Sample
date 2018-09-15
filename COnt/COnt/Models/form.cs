using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COnt.Models
{
    public class form

    {
        [Required(ErrorMessage ="please enter your first name")]
        public string  first { get; set; }
        [Required(ErrorMessage = "please enter your last name")]
        public string  last { get; set; }
        [Required(ErrorMessage = "please enter youremail")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "please enter your Age")]
        [Range(18,100)]
        public int age { get; set; }
    }
}