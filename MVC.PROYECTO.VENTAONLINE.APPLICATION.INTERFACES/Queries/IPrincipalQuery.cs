using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries
{
    public interface IPrincipalQuery
    {
        List<ListadoProductoDTO> ListadoProducto();
    }
}
