using Microsoft.AspNetCore.Mvc;

namespace GamerProfileWebApplication.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}