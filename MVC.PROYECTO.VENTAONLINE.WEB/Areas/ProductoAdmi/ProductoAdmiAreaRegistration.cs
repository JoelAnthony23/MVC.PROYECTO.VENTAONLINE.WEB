using System.Web.Mvc;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Areas.ProductoAdmi
{
    public class ProductoAdmiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ProductoAdmi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ProductoAdmi_default",
                "ProductoAdmi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}