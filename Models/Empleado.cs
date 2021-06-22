using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSystemsApi.Models
{

   

    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Apellido1 { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Apellido2 { get; set; }
        [Required]
        public string Mail { get; set; }
        public int EmpresaID { get; set; }
        public enums.Perfil Perfil { get; set; }
        public enums.Turno Turno { get; set; }


        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Incidencia> Incidencias { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }

    }
}
