using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.DOMAIN
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }    
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public string NomProducto { get; set; }
        public string CantxUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int UnidadesenExistencia { get; set; }
        public int UnidadesenPedido { get; set; }
        public bool Estado { get; set; }
    }
}
