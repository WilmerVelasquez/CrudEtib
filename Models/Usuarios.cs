using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEtib.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Primer Nombre")]
        public String PrimerNombre { get; set; }
        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
        [StringLength(10, ErrorMessage ="El {0} debe ser de {2}", MinimumLength =10)]
        public int Telefono { get; set; }
        [Display(Name = " Dirección")]
        public  char Direccion { get; set; }
        public char Correo { get; set; }
    }
}
