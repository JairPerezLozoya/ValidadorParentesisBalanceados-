using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ValidarParentesisBalanceados_Exam_JairPerez.Models
{
    public class ValidationContext : DbContext
    {
        // Usa la cadena de conexión de Web.config
        public ValidationContext() : base("name=ValidationContext") { }

        // Tabla en la base de datos
        public DbSet<ValidationRequest> ValidationRequests { get; set; }
    }
}