using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSystemsApi.Models
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string DescTarea { get; set; }
        
        [Required]
        public string Duracion { get; set; }
        [Required]
        public DateTime FTarea { get; set; }
        public int EmpleadoID { get; set; }

        public enums.Prioridad Prioridad { get; set; }

    }


}
