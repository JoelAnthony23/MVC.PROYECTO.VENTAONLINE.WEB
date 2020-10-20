using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries
{
    public interface IMarcaQuery
    {
        List<ConsultaMarcaResponseDTO> ConsultaMarca(ConsultaMarcaRequestDTO request);
    }
}
