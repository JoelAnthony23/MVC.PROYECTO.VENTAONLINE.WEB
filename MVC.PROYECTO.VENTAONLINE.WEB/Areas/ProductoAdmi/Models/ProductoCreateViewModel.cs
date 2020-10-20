using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Marca;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi.Models
{
    public class ProductoCreateViewModel
    {
        [Key]
        public int IdProducto { get; set; }
        [Display(Name = "Proveedor")]
        public int IdProveedor { get; set; }
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Marca")]
        public int IdMarca { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string NomProducto { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "Campo requerido")]
        public string CantxUnidad { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, 50000, ErrorMessage = "Valor fuera del rango")]
        public decimal PrecioUnidad { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, 50000, ErrorMessage = "Valor fuera del rango")]
        public int UnidadesenExistencia { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, 50000, ErrorMessage = "Valor fuera del rango")]
        public int UnidadesenPedido { get; set; }
        public List<ConsultaCategoriaResponseDTO> Categorias { get; set; }
        public List<ConsultaMarcaResponseDTO> Marca { get; set; }
        public List<ConsultaProveedorResponseDTO> Proveedor { get; set; }
    }
}