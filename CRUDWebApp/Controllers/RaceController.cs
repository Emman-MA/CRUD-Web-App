﻿using CRUDWebApp.Data;
using CRUDWebApp.Interfaces;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRaceService _raceService;
        public RaceController(IRaceService raceService)
        {
            _raceService = raceService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> races = await _raceService.GetAll();
            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Race race = await _raceService.GetByIdAsync(id);
            return View(race);
        }
    }
}
