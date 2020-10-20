using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Principal
{
    public class ListadoProductoDTO
    {      
        public string IdProducto { get; set; }
        public string Nomproducto { get; set; }
        public string NomCategoria { get; set; }
        public string NomMarca { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int UnidadesenExistencia { get; set; }
        public string ImagenSrc { get; set; }
    }
}
