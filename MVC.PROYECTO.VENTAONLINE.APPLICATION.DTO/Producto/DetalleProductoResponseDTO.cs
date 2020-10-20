using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto
{
    public class DetalleProductoResponseDTO
    {
        public int IdProducto { get; set; }
        public string NomProducto { get; set; }
        public int IdCategoria { get; set; }
        public string NomCategoria { get; set; }
        public string NomMarca { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int UnidadesEnExistencia { get; set; }
        public List<string> ImagenesSrc { get; set; }
    }
    public class DetalleProductoRequestDTO
    {
        [Required(ErrorMessage = "El campo id es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id tiene que ser mayor que cero")]
        public int Id { get; set; }
    }
}