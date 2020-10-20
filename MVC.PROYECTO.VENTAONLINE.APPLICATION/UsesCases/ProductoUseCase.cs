using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases;
using MVC.PROYECTO.VENTAONLINE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.UsesCases
{
    public class ProductoUseCase : IProductoUseCase
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoUseCase(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public void Actualizar(Producto producto)
        {
             _productoRepository.Update(producto);
        }

        public Producto Get(int id)
        {
            return _productoRepository.Get(id);
        }

        public int Registrar(Producto producto)
        {
            producto.Estado = true;
            return _productoRepository.Add<int>(producto);
        }
    }
}
