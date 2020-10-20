using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto
{
    public class ConsultaProductoResponseDTO
    {
        public int IdProducto { get; set; }
        public string NomProducto { get; set; }
        public string NomCategoria { get; set; }
        public string NomMarca { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int UnidadesenExistencia { get; set; }
        public string ImagenSrc { get; set; }
    }
    public class ConsultaProductoRequestDTO
    {
        [Required(ErrorMessage = "El campo Nombres es requerido")]
        public string NomProducto { get; set; }
    }
}
