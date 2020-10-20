using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto
{
    public class ConsultaProductoAdminResponseDTO
    {
        public int IdProducto { get; set; }
        public string Nomproducto { get; set; }
        public string NomProveedor { get; set; }
        public string NomCategoria { get; set; }
        public string NomMarca { get; set; }
        public string Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

    }
    public class ConsultaProductoAdminRequestDTO
    {
        [Required(ErrorMessage = "El campo Nombres es requerido")]
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
    }
}
