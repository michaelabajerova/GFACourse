using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_Of_Simba.Models;
using Microsoft.AspNetCore.Mvc;
using Bank_Of_Simba.Models.ViewModel;

namespace Bank_Of_Simba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private BankAccounts services;
        public static BankViewModel viewModel = new BankViewModel();

        public HomeController()
        {
            services = new BankAccounts();
        }

        [HttpGet("show")]
        public IActionResult Home()
        {
            var model = new BankViewModel();

            return View(model);
        }
        [HttpGet("htmlception")]
        public IActionResult Htmlception()
        {
            var htmlText = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View(htmlText as Object);
        }
        [HttpGet("accounts")]
        public IActionResult MultipleAccounts()
        {
            var model = new BankViewModel();

            return View("Home", model);
        }
    }
}
