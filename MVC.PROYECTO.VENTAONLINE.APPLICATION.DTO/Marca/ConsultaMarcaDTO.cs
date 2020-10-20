using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Marca
{
    public class ConsultaMarcaResponseDTO
    {
        public int IdMarca { get; set; }
        public string NomMarca { get; set; }
    }
    public class ConsultaMarcaRequestDTO
    {
        public string Descripcion { get; set; }
    }
}
