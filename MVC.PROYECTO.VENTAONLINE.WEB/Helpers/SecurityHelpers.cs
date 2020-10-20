using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace MVC.PROYECTO.VENTAONLINE.WEB.Helpers
{
    public class SecurityHelpers
    {
        //Claims Identity : permite guardar informacion perzonalizada del usuario logeado
        public static List<Claim> CrearClaimUsuario(string nombreCompletoUsuario, string login, string email, string usuarioId, string roles)
        {

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, nombreCompletoUsuario));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, login));
            claims.Add(new Claim(ClaimTypes.Email, email));
            claims.Add(new Claim("userId", usuarioId));
            string[] arrRoles = null;
            arrRoles = roles.Split(';');
            foreach (string rol in arrRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, rol));
            }

            return claims;
        }
        public static List<Claim> GetClaimByType(string type)
        {
            var identity = (ClaimsIdentity)HttpContext.Current.User.Identity;
            var claims = identity.Claims.Where(item => item.Type == type).ToList();
            return claims;
        }
        public static string GetUserFullName()
        {
            return GetClaimByType(ClaimTypes.Name).FirstOrDefault()?.Value;
        }
        public static string GetUser()
        {
            return GetClaimByType(ClaimTypes.NameIdentifier).FirstOrDefault()?.Value;
        }
        //public static int GetUserID()
        //{
        //    var claimUserId = int.Parse(GetClaimByType("userId").FirstOrDefault()?.Value);
        //    return claimUserId;
        //}
        public static string GetUserEmail()
        {
            return GetClaimByType(ClaimTypes.Email).FirstOrDefault()?.Value;
        }
        public static string GetUseRoles()
        {
            return GetClaimByType(ClaimTypes.Role).FirstOrDefault()?.Value;
        }
        public static bool IsLogged()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}