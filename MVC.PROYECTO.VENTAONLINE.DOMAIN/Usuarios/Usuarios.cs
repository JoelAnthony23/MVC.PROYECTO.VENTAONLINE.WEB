using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.DOMAIN.Usuarios
{
    public class Usuarios
    {
        public int UserId { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
    }
}
