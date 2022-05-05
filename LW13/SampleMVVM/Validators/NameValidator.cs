using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SampleMVVM.Validators
{
    public class NameValidator: ValidationRule
    {
        
            public override ValidationResult Validate
              (object value, System.Globalization.CultureInfo cultureInfo)
            {
                if (value == null)
                    return new ValidationResult(false, "value cannot be empty.");
                else
                {
                    if (value.ToString().Length < 3)
                        return new ValidationResult
                        (false, "Value cannot be less than 3 characters long.");
                }
                return ValidationResult.ValidResult;
            }
        }
    }
