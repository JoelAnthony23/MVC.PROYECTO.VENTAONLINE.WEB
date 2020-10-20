using MVC.PROYECTO.VENTAONLINE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases
{
    public interface IProductoUseCase
    {
        int Registrar(Producto producto);
        Producto Get(int id);
        void Actualizar(Producto producto);
    }
}
