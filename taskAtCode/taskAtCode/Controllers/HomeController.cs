using Microsoft.AspNetCore.Mvc;

namespace taskAtCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
