using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Database;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Queries
{
    public class ProductoQuery : IProductoQuery
    {
        public List<ConsultaProductoResponseDTO> ConsultaProductos(ConsultaProductoRequestDTO request)
        {
            List<ConsultaProductoResponseDTO> lista = null;
            var paramNombre = string.IsNullOrWhiteSpace(request.NomProducto) ? null : $"%{request.NomProducto.Trim()}%";
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                lista = db.Query<ConsultaProductoResponseDTO>("usp_getBusquedaProducto",
                                 new { NomProducto = paramNombre },
                                 commandType: CommandType.StoredProcedure
                                 ).ToList();
            }
            return lista;
        }

        public DetalleProductoResponseDTO DetalleProducto(int id)
        {
            DetalleProductoResponseDTO detalle = null;
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                using (var multiQuery = db.QueryMultiple("usp_getDetalleProducto", new { id = id },
                    commandType: CommandType.StoredProcedure))
                {
                    detalle = multiQuery.Read<DetalleProductoResponseDTO>().SingleOrDefault();
                    detalle.ImagenesSrc = multiQuery.Read<string>().ToList();
                }
            }
            return detalle;
        }

        public List<ConsultaProductoAdminResponseDTO> ConsultaProductoAdmin(ConsultaProductoAdminRequestDTO request)
        {
            List<ConsultaProductoAdminResponseDTO> lista = null;
            var paramNombre = string.IsNullOrWhiteSpace(request.Descripcion) ? null : $"%{request.Descripcion.Trim()}%";
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                lista = db.Query<ConsultaProductoAdminResponseDTO>("usp_getBusquedaProductosAdmin",
                                 new { Descripcion = paramNombre, IdCategoria = request.IdCategoria },
                                 commandType: CommandType.StoredProcedure
                                 ).ToList();
            }
            return lista;
        }
    }
}
