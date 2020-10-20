using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Proveedor
{
    public class ConsultaProveedorResponseDTO
    {
        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; }
    }
    public class ConsultaProveedorRequestDTO
    {
        public string Descripcion { get; set; }
    }
}
