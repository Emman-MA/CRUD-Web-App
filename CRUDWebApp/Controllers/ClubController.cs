using CRUDWebApp.Data;
using CRUDWebApp.Interfaces;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using CRUDWebApp.Data.Enum;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubService _clubService;
        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubService.GetAll();
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubService.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid)
            {
                return View(club);
            }
            _clubService.Add(club);
            return RedirectToAction("Index");
        }
    }
}
