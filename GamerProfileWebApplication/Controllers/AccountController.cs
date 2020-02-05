using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace GamerProfileWebApplication.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            var pars = new Dictionary<string, string>
            {
                { "grant_type","client_credentials" }
            };
         
            return Challenge(new AuthenticationProperties(pars) { RedirectUri = returnUrl});
        }
    }
}