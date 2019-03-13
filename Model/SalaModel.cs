using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DevWebBasico.Model
{
    public class SalaModel : ValidationAttribute
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            SalaModel eventView = (SalaModel)validationContext.ObjectInstance;

            return ValidationResult.Success;
        }

    }
}