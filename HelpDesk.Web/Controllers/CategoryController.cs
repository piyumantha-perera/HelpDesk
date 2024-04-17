using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
