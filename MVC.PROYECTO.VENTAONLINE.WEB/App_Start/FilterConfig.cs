﻿using System.Web;
using System.Web.Mvc;

namespace MVC.PROYECTO.VENTAONLINE.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
