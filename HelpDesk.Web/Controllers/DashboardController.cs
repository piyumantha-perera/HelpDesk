using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
