using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
[assembly: OwinStartup(typeof(MVC.PROYECTO.VENTAONLINE.WEB.Startup))]

namespace MVC.PROYECTO.VENTAONLINE.WEB
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication
                (

                new CookieAuthenticationOptions
                {
                    AuthenticationType = "ApplicationCookie",
                    CookieName = "AuthVentaonLine",
                    ExpireTimeSpan = TimeSpan.FromSeconds(60),
                    LoginPath = new PathString("/Login/LogearUsuario")
                });
        }
    }
}