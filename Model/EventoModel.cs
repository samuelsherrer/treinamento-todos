using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevWebBasico.Model {
    public class EventoModel : IValidatableObject {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data inicio obrigatória")]
        [DataType (DataType.DateTime)]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Data inicio obrigatória")]
        [DataType (DataType.DateTime)]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "Favor informar uma sala.")]
        public int SalaId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DataFim < DataInicio)
                yield return new ValidationResult("Código do sistema inválido", new[] { nameof(DataFim), nameof(DataInicio) });
        }
    }
}