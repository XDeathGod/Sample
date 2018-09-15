using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COnt.Models
{
    public class Valid
    {
        [Required]
        [VlaidationCustom(ErrorMessage ="sorry")]
        public String Name { get; set; }
        [Required]
        public string fuck { get; set; }
    }
}