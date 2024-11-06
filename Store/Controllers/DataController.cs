using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Date"] = DateTime.Now.ToString();
            ViewBag.Date=DateTime.Now.ToString();
            TempData["date"] = DateTime.Now.ToString();
            return View();
        }
    }
}
