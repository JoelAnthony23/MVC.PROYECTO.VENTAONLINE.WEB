using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Marca;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Database;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Queries
{
    public class MarcaQuery : IMarcaQuery
    {
        public List<ConsultaMarcaResponseDTO> ConsultaMarca(ConsultaMarcaRequestDTO request)
        {
            List<ConsultaMarcaResponseDTO> lista = null;
            var paramNombre = string.IsNullOrWhiteSpace(request.Descripcion) ? null : $"%{request.Descripcion.Trim()}%";
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                lista = db.Query<ConsultaMarcaResponseDTO>("USP_GETMARCAADMIN", new { descripcion = paramNombre },
                                 commandType: CommandType.StoredProcedure
                                 ).ToList();
            }
            return lista;
        }
    }
}
