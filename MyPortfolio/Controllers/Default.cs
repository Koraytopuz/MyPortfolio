using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
