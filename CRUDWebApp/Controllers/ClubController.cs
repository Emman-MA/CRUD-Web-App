using CRUDWebApp.Data;
using CRUDWebApp.Interfaces;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
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

    }
}
