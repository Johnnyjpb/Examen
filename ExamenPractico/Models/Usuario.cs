using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        [Required]
        public string Nickname { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Contrasena { get; set; }
        public bool Estatus { get; set; }
    }
}
