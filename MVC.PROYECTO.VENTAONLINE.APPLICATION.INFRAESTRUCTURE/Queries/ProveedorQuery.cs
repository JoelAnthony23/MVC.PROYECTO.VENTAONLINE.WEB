using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Proveedor;
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
    public class ProveedorQuery : IProveedorQuery
    {
        public List<ConsultaProveedorResponseDTO> ConsultaProveedor(ConsultaProveedorRequestDTO request)
        {
            List<ConsultaProveedorResponseDTO> lista = null;
            var paramNombre = string.IsNullOrWhiteSpace(request.Descripcion) ? null : $"%{request.Descripcion.Trim()}%";
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                lista = db.Query<ConsultaProveedorResponseDTO>("USP_GETBUSQUEDAPROVEEDORADMIN", new { descripcion = paramNombre },
                                 commandType: CommandType.StoredProcedure
                                 ).ToList();
            }
            return lista;
        }
    }
}
