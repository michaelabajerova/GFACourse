using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Models;
using WebShop.Models.ViewModels;

namespace WebShop.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ShopServices services;

        public HomeController()
        {
            services = new ShopServices();
        }

        [HttpGet("webshop")]
        public IActionResult Index()
        {
            var model = new IndexViewModel(services.ShopItems);

            return View(model);
        }
        [HttpGet("only-available")]
         public IActionResult OnlyAvailable()
        {
            var model = new IndexViewModel(services.OnlyAvailable());
            return View("Index", model);
        }
        [HttpGet("cheapest-first")]
        public IActionResult CheapestFirst()
        {
            var model = new IndexViewModel(services.CheapestFirst());
            return View("Index", model);
        }
        [HttpGet("contains-magic")]
        public IActionResult Containsmagic()
        {
            var model = new IndexViewModel(services.ContainsMagic());
            return View("Index", model);
        }
        [HttpGet("average-stock")]
        public IActionResult AverageStock()
        {
            var list = new ShopServices();
            var averageStock = list.ShopItems.Average(i => i.Quantity);
            return View("AverageStock", averageStock);
        }
        [HttpGet("most-expensive")]
        public IActionResult MostExpensive()
        {
            var list = new ShopServices();
            var mostExpensive = list.ShopItems.OrderByDescending(i => i.Price).Select(i => i.Name).FirstOrDefault();
            return View("MostExpensive", mostExpensive);
        }
        [HttpPost("search")]
        public IActionResult Search(string search) 
        {
            var model = new IndexViewModel(services.Search(search));
            return View("Index", model);
        }
    }
}
