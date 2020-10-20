using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries;
using MVC.PROYECTO.VENTAONLINE.WEB.filters;
using MVC.PROYECTO.VENTAONLINE.WEB.Helpers;
using MVC.PROYECTO.VENTAONLINE.WEB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;


namespace MVC.PROYECTO.VENTAONLINE.WEB.Controllers
{
    public class PrincipalController : Controller
    {
        private readonly IProductoQuery _productorQuery;
        public PrincipalController(IProductoQuery productorQuery)
        {
            _productorQuery = productorQuery;
        }
        [HttpPost]
        public string Detalle(int id)
        {
            string result = "";
            string model = "";      
            if (id > 0)
            {
                var producto = new DetalleProductoResponseDTO();
                producto = _productorQuery.DetalleProducto(id);         
                List<string> imagenesSrc = new List<string>();     
                foreach (var item in producto.ImagenesSrc)
                {
                    string pathCarpeta = System.IO.Path.Combine("../images/Productos/", item);
                    string response ="<img src='" + pathCarpeta + "'/>";
                    imagenesSrc.Add(response);
                }
                foreach (string vs in imagenesSrc)
                {
                    model += vs;
                }
                result = result + "<div>" +
                     "<h5>Categoria</h5><p>" + producto.NomCategoria + "</p>"
                     + "<h5>Nombre Producto</h5><p>" + producto.NomProducto + "</p>"
                     + "<h5>Marca</h5><p>" + producto.NomMarca + "</p>"
                     + "<h5>Precio</h5><p>" + producto.PrecioUnidad + "</p>"
                     + "<h5>Precio</h5><p>" + producto.UnidadesEnExistencia + "</p>"
                     + "</div>" 
                     + "<div style='float: right;border-radius: 13px 13px 13px 13px;-moz-border-radius: 13px 13px 13px 13px;-webkit-border-radius: 13px 13px 13px 13px;border: 9px solid #b9b9bf;'>" + model + "</div>";
            }   
            return result;
        }
    }
}