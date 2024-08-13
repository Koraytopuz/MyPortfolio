using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
