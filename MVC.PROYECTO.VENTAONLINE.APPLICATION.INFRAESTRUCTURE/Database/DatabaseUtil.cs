
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Database
{
    public class DatabaseUtil
    {
        public static IDbConnection CreateDBConnection()
        {
        
            var connectionString = ConfigurationManager.ConnectionStrings["dbFerreteriaOnLine"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
