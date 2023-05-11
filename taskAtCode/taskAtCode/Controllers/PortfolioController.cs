using Microsoft.AspNetCore.Mvc;

namespace taskAtCode.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
