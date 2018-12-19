using ModelValidation.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        [Remote("ValidateDate", "Home")]
        public DateTime Date { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept ther terms.")]
        [MustBeTrue(ErrorMessage = "You must accept ther terms1.")]
        public bool TermsAccepted { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    List<ValidationResult> errors = new List<ValidationResult>();
        //    if (string.IsNullOrEmpty(ClientName))
        //    {
        //        errors.Add(new ValidationResult("Please enter yourname"));
        //    }
        //    return errors;
        //}
    }
}
