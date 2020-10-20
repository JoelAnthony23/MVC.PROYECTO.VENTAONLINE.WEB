using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Queries;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Queries;
using SimpleInjector.Integration.Web;
using SimpleInjector;
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.UsesCases;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Repositories;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.UsesCases;

namespace MVC.PROYECTO.VENTAONLINE.WEB.App_Start
{
    public class DIConfig
    {
        public static void Configure()
        {
            // Simple Injector set up
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            // Register your stuff here
            //===========================================================================
            // INJECTAR LAS DEPENDENCIAS      
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioUsesCases, UsuarioUseCase>(Lifestyle.Scoped);
            container.Register<IPrincipalQuery, PrincipalQuery>(Lifestyle.Scoped);
            container.Register<IProductoQuery, ProductoQuery>(Lifestyle.Scoped);
            container.Register<ICategoriaQuery, CategoriaQuery>(Lifestyle.Scoped);
            container.Register<ICategoriaRepository, CategoriaRepository>(Lifestyle.Scoped);
            container.Register<IMarcaQuery, MarcaQuery>(Lifestyle.Scoped);
            container.Register<IProductoRepository, ProductoRepository>(Lifestyle.Scoped);
            container.Register<IProductoUseCase, ProductoUseCase>(Lifestyle.Scoped);
            container.Register<IProveedorQuery, ProveedorQuery>(Lifestyle.Scoped);
            //===========================================================================
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterMvcIntegratedFilterProvider();
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}