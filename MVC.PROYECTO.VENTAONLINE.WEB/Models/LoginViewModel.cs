using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Models
{
    public class LoginViewModel
    {
        public string Usuario { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string MensajeValidacion { get; set; }
        public string ReturnUrl { get; set; }
    }
}