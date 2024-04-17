using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
