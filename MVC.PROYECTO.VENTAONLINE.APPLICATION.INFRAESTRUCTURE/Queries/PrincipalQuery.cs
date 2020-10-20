using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Principal;
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
    public class PrincipalQuery : IPrincipalQuery
    {
        public List<ListadoProductoDTO> ListadoProducto()
        {
            List<ListadoProductoDTO> lista = null;
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                lista = db.Query<ListadoProductoDTO>("usp_getListadoPrincipalProducto",                                
                                 commandType: CommandType.StoredProcedure
                                 ).ToList();
            }
            return lista;
        }
    }
}
