using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico.Models
{
    public class Contacto
    {
        public int IdConctacto { get; set; }
        public DateTime FechaRegistro { get; set; }
        [MaxLength(10)]
        public string Telefono { get; set; }
        public string Nombre { get; set; }
    }
}
