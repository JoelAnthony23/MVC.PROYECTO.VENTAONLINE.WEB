using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Marca;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Proveedor;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases;
using MVC.PROYECTO.VENTAONLINE.DOMAIN;
using MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi.Models;
using MVC.PROYECTO.VENTAONLINE.WEB.filters;
using MVC.PROYECTO.VENTAONLINE.WEB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi.Controllers
{
    public class AdminProductosController : Controller
    {
        private readonly ICategoriaQuery _categoriaQuery;
        private readonly IMarcaQuery _marcaQuery;
        private readonly IProductoQuery _productoQuery;
        private readonly IProductoUseCase _productoUseCase;
        private readonly IProveedorQuery _proveedorQuery;

        public AdminProductosController(ICategoriaQuery categoriaQuery, IProductoQuery productoQuery, IMarcaQuery marcaQuery, IProductoUseCase productoUseCase, IProveedorQuery proveedorQuery)
        {
            _categoriaQuery = categoriaQuery;
            _productoQuery = productoQuery;
            _marcaQuery = marcaQuery;
            _productoUseCase = productoUseCase;
            _proveedorQuery = proveedorQuery;
        }
        public ActionResult Index()
        {
            var model = new BusquedaProductosViewModel()
            {
                LCategoria = _categoriaQuery.ConsultaCategoria(new ConsultaCategoriaRequestDTO())
            };
            return View(model);
        }

        [HttpPost]

        public ActionResult Buscar(BusquedaProductosViewModel model)
        {
           
            model.LconsultaProductoAdmins = _productoQuery.ConsultaProductoAdmin(new ConsultaProductoAdminRequestDTO
            {
                Descripcion = model.Nombre,
                IdCategoria = model.Categoria??0
            });
          
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new ProductoCreateViewModel()
            {
                Categorias = _categoriaQuery.ConsultaCategoria(new ConsultaCategoriaRequestDTO()),
                Marca = _marcaQuery.ConsultaMarca(new ConsultaMarcaRequestDTO()),
                Proveedor = _proveedorQuery.ConsultaProveedor(new ConsultaProveedorRequestDTO())
            };

            return PartialView(model);
        }

        [HttpPost]
        [ValidarModeloFilter]
        public ActionResult Create(ProductoCreateViewModel model)
        {
            var producto = new Producto();
            producto = Mappers.ProductoViewModelToProductoMappings().Map(model, producto);
            bool response = _productoUseCase.Registrar(producto) > 0;
            return Json(response);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var obtener = _productoUseCase.Get(id);
            return PartialView(obtener);
        }
        [HttpPost]
        public ActionResult Edit(ProductoCreateViewModel model)
        {
            var producto = new Producto();
            producto = Mappers.ProductoViewModelToProductoMappings().Map(model, producto);
            if (producto != null) _productoUseCase.Actualizar(producto);           
            var obtener = _productoUseCase.Get(producto.IdProducto);
            return Json(obtener);
        }
    }
}