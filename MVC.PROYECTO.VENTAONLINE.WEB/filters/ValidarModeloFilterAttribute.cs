using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC.PROYECTO.VENTAONLINE.WEB.filters
{
    public class ValidarModeloFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var modelStates = filterContext.Controller.ViewData.ModelState;
            var isModelValid = modelStates.IsValid;
            if (!isModelValid)
            {
                var errors = new StringBuilder();
                foreach (ModelState modelState in modelStates.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errors.AppendLine(error.ErrorMessage);
                    }
                }
                filterContext.HttpContext.Response.StatusCode = HttpStatusCode.BadRequest.GetHashCode();
                filterContext.Result = new ContentResult() { Content = errors.ToString() };
            }
            base.OnActionExecuting(filterContext);
        }
    }
}