using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Services;

namespace FoxClub.Controllers
{

    [Route("")]
    public class HomeController : Controller
    {
        private FoxService foxService;

        public HomeController(FoxService foxService)
        {
            this.foxService = foxService;
        }
        [HttpGet("")]
        public IActionResult Index(string name)
        {
            if (name == null)
            {
                return RedirectToAction("Login");
            }
            return View(foxService.FindByName(name));
        }
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login(string name)
        {
            foxService.Foxes.Add(new Fox(name));
            return RedirectToAction("Index", new { name });
        }
        [HttpGet("nutritionstore")]

        public IActionResult NutritionStore(string name)
        {
            ViewBag.foodTypes = foxService.Food;
            ViewBag.drinkTypes = foxService.Drink;

            return View(foxService.FindByName(name));
        }

        [HttpPost("nutritionstore")]
        public IActionResult NutritionStore(string name, string food, string drink)
        {
            foxService.FindByName(name).Drink = drink;
            foxService.FindByName(name).Food = food;
            return RedirectToAction("Information", new { name });
        }
    }
}