using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Web.Controllers
{
    public class ContractorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
