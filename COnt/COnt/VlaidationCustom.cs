using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using COnt.Models;

namespace COnt
{
    public  class VlaidationCustom:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string message = value.ToString();
                if(message.Contains("vikas"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage??"fuck me yeah";
            return new ValidationResult("FIeld must contain vikas Name");
        }

    }
}