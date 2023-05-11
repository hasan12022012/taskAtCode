using Microsoft.AspNetCore.Mvc;

namespace taskAtCode.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
