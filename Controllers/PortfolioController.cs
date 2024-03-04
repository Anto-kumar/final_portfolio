using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
