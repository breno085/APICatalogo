using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Validations;

public class PrimeiraLetraMaisculaAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value,
        ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString()))
        {
            return ValidationResult.Success;
        }

        var primeiraLetra = value.ToString()[0].ToString();
        if (primeiraLetra != primeiraLetra.ToUpper())
        {
            return new ValidationResult("A primeira letra do nome do produto deve ser maiscula");
        }

        return ValidationResult.Success;
    }
}