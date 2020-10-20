using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Database;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories;
using MVC.PROYECTO.VENTAONLINE.DOMAIN.Usuarios;
using System.Data;


namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuarios>, IUsuarioRepository
    {
        public Usuarios Get(string usuario)
        {
            Usuarios result = null;
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                result = db.QuerySingleOrDefault<Usuarios>("usp_getLogeoUsuario", new { usuario = usuario },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }   
}
