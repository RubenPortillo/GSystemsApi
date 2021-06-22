
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSystemsApi.Models
{
    public class Incidencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string IncidenciaDesc { get; set; }

        [Required]
        public string Ubicacion { get; set; }
        [Required]
        public DateTime FIncidencia { get; set; }
        public int EmpleadoID { get; set; }

        public enums.Prioridad Prioridad { get; set; }
    }
}
