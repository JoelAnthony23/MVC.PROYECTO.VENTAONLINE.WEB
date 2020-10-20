using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO;
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
    public class CategoriaQuery : ICategoriaQuery
    {
        public List<ConsultaCategoriaResponseDTO> ConsultaCategoria(ConsultaCategoriaRequestDTO request)
        {
            List<ConsultaCategoriaResponseDTO> lista = null;
            var paramNombre = string.IsNullOrWhiteSpace(request.Descripcion) ? null : $"%{request.Descripcion.Trim()}%";
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                lista = db.Query<ConsultaCategoriaResponseDTO>("USP_GETBUSQUEDACATEGORIAADMIN", new { descripcion = paramNombre },
                                 commandType: CommandType.StoredProcedure
                                 ).ToList();
            }
            return lista;
        }
    }
}
