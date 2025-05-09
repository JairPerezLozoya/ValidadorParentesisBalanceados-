using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ValidarParentesisBalanceados_Exam_JairPerez.Models
{
    public class ValidationRequest
    {
        // Clave primaria autoincremental
        public int Id { get; set; }

        [Required] // Validación: campo obligatorio

        // Cadena a validar (ej: "{[()]}")
        public string InputString { get; set; }

        // Resultado de la validación (true/false)
        public bool IsValid { get; set; }

        // Fecha automática
        public DateTime RequestDate { get; set; } = DateTime.Now;

    }
}

