using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi.Models
{
    public class PaginationViewModel
    {
        public int PaginaActual { get; set; }
        public int TotaldeRegistros { get; set; }
        public int RegistrosPorPagina { get; set; }
    }
}