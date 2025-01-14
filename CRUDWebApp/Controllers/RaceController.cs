using Microsoft.AspNetCore.Mvc;

namespace CRUDWebApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
