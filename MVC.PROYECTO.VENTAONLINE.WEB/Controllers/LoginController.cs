using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Principal;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Usuario;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases;
using MVC.PROYECTO.VENTAONLINE.WEB.filters;
using MVC.PROYECTO.VENTAONLINE.WEB.Helpers;
using MVC.PROYECTO.VENTAONLINE.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.DTO.Producto;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Controllers
{
    public class LoginController : Controller
    {
       // private readonly ILoginQuery _loginsQuery;
        private readonly IUsuarioUsesCases _usuarioUsesCases;
        private readonly IPrincipalQuery _principalQuery;
        private readonly IProductoQuery _productorQuery;
        public LoginController(IUsuarioUsesCases usuarioUsesCases, IPrincipalQuery principalQuery, IProductoQuery productorQuery)
        {
            _usuarioUsesCases = usuarioUsesCases;
            _principalQuery = principalQuery;
            _productorQuery = productorQuery;
        }

        public ActionResult LogearUsuario()
        {          
            return View();
        }
        [HttpPost]
        //[ValidarModeloFilter]
        public ActionResult LogearUsuario(LoginViewModel model)
        {
            var loginResponse = _usuarioUsesCases.VerficarPorLoginPassword(new ValidarUsarioRequestDTO() { Usuario = model.Usuario, Password = model.Password });

            if (loginResponse != null)
            {
                var claims = SecurityHelpers.CrearClaimUsuario(
                 $"{loginResponse.Nombre}{loginResponse.Apellidos}", model.Usuario, loginResponse.Email, loginResponse.UserId.ToString(), loginResponse.Perfil);
                var identity = new ClaimsIdentity(claims, "ApplicationCookie");
                var context = Request.GetOwinContext();
                var autManager = context.Authentication;
                //Se realiza el proceso de creacion de las cookies de seguridad
                autManager.SignIn(identity);
                return Redirect(model.ReturnUrl ?? "~/Login/Principal");
            }
            else
            {
                return View(model);
            }
        }
        public ActionResult Principal()
        {
            var model = _principalQuery.ListadoProducto();
            return View(model);
        }
        [HttpPost]
        [ValidarModeloFilter]
        public ActionResult BuscarProducto(ConsultaProductoRequestDTO request)
        {
            var model = _productorQuery.ConsultaProductos(request);
            return PartialView("_ResultadoBusquedaProducto", model);

        }

       
    }
}