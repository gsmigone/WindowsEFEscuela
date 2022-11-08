using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Docente")]
    public class Profesor
    {
        [Required]
        [Column(TypeName = "int")]// tipo de datos de sql server

        public int ProfesorID { get; set; }

        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Apellido { get; set; }


        [Required]
        [Column(TypeName = "varchar")]// tipo de datos de sql server
        [StringLength(50)]
        public string Titulo { get; set; }
    }
}
