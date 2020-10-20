using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries
{
    public interface IProductoQuery
    {
        List<ConsultaProductoResponseDTO> ConsultaProductos(ConsultaProductoRequestDTO request);
        DetalleProductoResponseDTO DetalleProducto(int id);
        List<ConsultaProductoAdminResponseDTO> ConsultaProductoAdmin(ConsultaProductoAdminRequestDTO request);

    }
}
