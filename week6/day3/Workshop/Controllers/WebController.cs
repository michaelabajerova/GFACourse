using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int counter = 1;
        [HttpGet("greeting")]
        /*public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                ID = 1,
                Content = "from the model"
            };

            return View(greeting);
        }*/
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                ID = counter++,
                Content = name
            };

            return View(greeting);
        }
    }
}
