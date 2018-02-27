using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwaggerApiDemo.Tools
{
    /// <summary>
    /// RFIDValidation
    /// </summary>
    public class RFIDValidation : ValidationAttribute
    {
        /// <summary>
        /// override IsValid
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Please Provide RFID");
            }
            else
            {
                if(value.ToString().Contains("@"))
                {
                    return new ValidationResult("Can't contain @");
                }
            }
            return ValidationResult.Success;
        }        
    }
    public class NameValidation : ValidationAttribute
    {
        /// <summary>
        /// override IsValid
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Please Provide RFID");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("Can't contain @");
                }
            }
            return ValidationResult.Success;
        }
    }
}