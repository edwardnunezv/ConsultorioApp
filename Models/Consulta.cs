using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioApp.Models
{
    public class Consulta
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de Consulta")]
        public DateTime FechaConsulta { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El motivo de la consulta es obligatorio.")]
        [StringLength(1000)]
        [Display(Name = "Motivo de Consulta")]
        public string MotivoConsulta { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Sintomas { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Diagnostico { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Tratamiento { get; set; } = string.Empty;

        [StringLength(500)]
        [Display(Name = "Observaciones / Indicaciones")]
        public string Observaciones { get; set; } = string.Empty;
    }
}