using System;
using System.Linq;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private LogService service;

        public HomeController(LogService service)
        {
            this.service = service;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            service.AddLog("/doubling", input.ToString());
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null && title == null)
            {
                return Json(new { error = "Please provide a name and a title!", status = 400 });
            }
            else if (name == null)
            {
                return Json(new { error = "Please provide a name!", status = 400 });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!", status = 400 });
            }
            service.AddLog(name, title);
            return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpGet("/appenda")]
        public IActionResult Appenda()
        {
            return StatusCode(404);
        }

        [HttpPost("/dountil/{operation}")]
        public IActionResult DoUntil(string operation, [FromBody] Number number)
        {
            if (operation.Equals("sum"))
            {
                int sum = 0;
                for (int i = number.Until; i > 0; i--)
                {
                    sum = sum + i;
                }
                return Json(new { result = sum });
            }
            else if (operation.Equals("factor"))
            {
                int factor = 1;
                for (int i = number.Until; i > 0; i--)
                {
                    factor = factor * i;
                }
                return Json(new { result = factor });
            }

            return Json(new { error = "Please provide a number!" });
        }

        [HttpPost("/arrays")]
        public IActionResult Arrays([FromBody] Arrays input)
        {
            if (input.What.Equals("sum"))
            {
                int number = 0;

                return Json(new { result = number });
            }
            else if (input.What.Equals("multiply"))
            {
                int number = 1;

                return Json(new { result = number });
            }
            else if (input.What.Equals("double"))
            {
                int[] doubledArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

                return Json(new { result = doubledArray });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }
    }
}