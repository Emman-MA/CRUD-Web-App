using Microsoft.AspNetCore.Mvc;

namespace CRUDWebApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
