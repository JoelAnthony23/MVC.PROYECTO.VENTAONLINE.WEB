using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Usuario
{
   
        public class ValidarUsarioRequestDTO
        {
            [Required(ErrorMessage = "El campo Login es requerido")]
            public string Usuario { get; set; }
            [Required(ErrorMessage = "El campo Login es requerido")]
            public string Password { get; set; }
        }
        public class ValidarUsarioResponseDTO
        {
            public int UserId { get; set; }
            public string Usuario { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Perfil { get; set; }
            public string Email { get; set; }
        }
 
}
