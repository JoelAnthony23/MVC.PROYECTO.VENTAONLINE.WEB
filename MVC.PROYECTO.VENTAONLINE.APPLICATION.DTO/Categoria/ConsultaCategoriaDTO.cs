using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO
{
    public class ConsultaCategoriaResponseDTO
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
    }
    public class ConsultaCategoriaRequestDTO
    {     
        public string Descripcion { get; set; }
    }
}
