
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Usuario;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases;
using MVC.PROYECTO.VENTAONLINE.DOMAIN.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.UsesCases
{
    public class UsuarioUseCase : IUsuarioUsesCases
    {
        public readonly IUsuarioRepository _usuarioRepository;
        public UsuarioUseCase(IUsuarioRepository IUsuarioRepository)
        {
            _usuarioRepository = IUsuarioRepository;

        }

        public ValidarUsarioResponseDTO VerficarPorLoginPassword(ValidarUsarioRequestDTO request)
        {
            ValidarUsarioResponseDTO response = null;
            var usuario = _usuarioRepository.Get(request.Usuario);
            if (usuario != null)
            {
                if (usuario.Password == request.Password)
                {
                    response = LoginMapping(usuario);
                }
            }
            return response;
        }
        public ValidarUsarioResponseDTO LoginMapping(Usuarios usuario)
        {
            return new ValidarUsarioResponseDTO()
            {
                UserId = usuario.UserId,
                Nombre = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Email = usuario.Email,
                Perfil = usuario.Perfil,
                Usuario = usuario.Usuario
            };
        }
    }
}
