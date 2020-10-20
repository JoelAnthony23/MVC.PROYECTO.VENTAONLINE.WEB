using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries
{
    public interface ICategoriaQuery
    {
        List<ConsultaCategoriaResponseDTO> ConsultaCategoria(ConsultaCategoriaRequestDTO request);
    }
}
