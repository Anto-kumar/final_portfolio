using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
