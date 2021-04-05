using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductEntityframework.Models
{
    public class DateGreaterThanToday : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime d = Convert.ToDateTime(value);
                if (d != null)
                {
                    if (d >= DateTime.UtcNow)
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult(ErrorMessage ?? "Date should greater than Today");
        }

    }
}