using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries
{
    public interface IProveedorQuery
    {
        List<ConsultaProveedorResponseDTO> ConsultaProveedor(ConsultaProveedorRequestDTO request);
    }
}
