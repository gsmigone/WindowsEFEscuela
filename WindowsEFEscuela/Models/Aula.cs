using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Required]
        [Column(TypeName = "int")]// tipo de datos de sql server
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "int")]// tipo de datos de sql server
        public int Capacidad { get; set; }

        [Required]
        [Column(TypeName = "char")]// tipo de datos de sql server
        [StringLength(1)]
        public string Codigo { get; set; }
    }
}
