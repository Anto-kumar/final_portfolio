using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
