using AutoMapper;
using MVC.PROYECTO.VENTAONLINE.DOMAIN;
using MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Helpers
{
    public class Mappers
    {
        public static IMapper ProductoViewModelToProductoMappings()
        {
            var configuration = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ProductoCreateViewModel, Producto>();
                }
                );
            return configuration.CreateMapper();
        }
    }
}