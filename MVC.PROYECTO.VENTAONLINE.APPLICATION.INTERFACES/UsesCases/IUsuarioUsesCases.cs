using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases
{
    public interface IUsuarioUsesCases
    {
        ValidarUsarioResponseDTO VerficarPorLoginPassword(ValidarUsarioRequestDTO request);
    }
}
