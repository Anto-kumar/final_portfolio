using Microsoft.AspNetCore.Mvc;
using portfolio.Data;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext _db;
        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact obj)
        {
            _db.Contacts.Add(obj);
            _db.SaveChanges();
            return View();
        }
    }
}
