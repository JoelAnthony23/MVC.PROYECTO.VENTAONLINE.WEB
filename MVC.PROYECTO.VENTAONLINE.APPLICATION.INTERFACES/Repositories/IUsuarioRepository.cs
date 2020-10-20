
using MVC.PROYECTO.VENTAONLINE.DOMAIN.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories
{
    public interface IUsuarioRepository : IGenericRepository<Usuarios>
    {
        Usuarios Get(string login);
    }
}
