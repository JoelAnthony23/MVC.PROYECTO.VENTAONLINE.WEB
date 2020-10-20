using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Marca;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi.Models
{
    public class BusquedaProductosViewModel 
    {
        public string Nombre { get; set; }
        public int? Categoria { get; set; }
        public List<ConsultaCategoriaResponseDTO> LCategoria { get; set; }
        public List<ConsultaMarcaResponseDTO> LMarca { get; set; }
        public List<ConsultaProductoAdminResponseDTO> LconsultaProductoAdmins { get; set; }
    }
}