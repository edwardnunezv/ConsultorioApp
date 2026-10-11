using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioApp.Models
{
    public class AntecedenteGinecologico
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

        [Display(Name = "Edad de Menarquia")]
        public int Menarquia { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Última Regla (FUM)")]
        public DateTime? Fum { get; set; }

        [StringLength(50)]
        [Display(Name = "Ritmo Menstrual (ej. 28x5)")]
        public string RitmoMenstrual { get; set; } = string.Empty;

        public int Gestas { get; set; }
        public int Partos { get; set; }
        public int Cesareas { get; set; }
        public int Abortos { get; set; }

        [StringLength(255)]
        [Display(Name = "Método Anticonceptivo")]
        public string MetodoAnticonceptivo { get; set; } = string.Empty;

        [StringLength(500)]
        public string Observaciones { get; set; } = string.Empty;
    }
}