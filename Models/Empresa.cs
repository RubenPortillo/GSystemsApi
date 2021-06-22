using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSystemsApi.Models
{
    public class Empresa
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 3)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string Direccion { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public DateTime FActivo { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }

    }
}
