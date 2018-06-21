using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace VidPlace.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            // If customer chooses pay as you go --> no validation error
            if (customer.MembershipId == Membership.PayAsYouGo || customer.MembershipId == Membership.Unknown)
                return ValidationResult.Success;

            // Customer choose other plan(monthly, quaterly or annual)
            // When birthdate is not required
            if (customer.Birthday == null)
                return new ValidationResult("The birthdate is required for a paid plan.");

            // Calculate the age
            //DateTime base = DateTime.Now.AddYears(-18);
            //if(base < customer.Birthday)
            var age = DateTime.Now.Year - customer.Birthday.Value.Year;

            return (age >= 18) ?
                ValidationResult.Success :
                new ValidationResult("Customer has to be 18 years old.");
        }
    }
}