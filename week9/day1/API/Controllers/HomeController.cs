using System;
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
            service.AddLog("greeter", $"Name: {name}, Title: {title}");
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

            return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            service.AddLog("appena", $"{appendable}");
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
            service.AddLog("appena", $"Operation: {operation}, Until: {number}");
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
            service.AddLog("arrays", $"Operation: {input.What}, Array: {input.numbers}");
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

        [HttpGet("/log")]
        public IActionResult Log()
        {
            return Json(service.ReturnAllLogs());
        }
        [HttpPost("/sith")]
        public ActionResult SithReverser([FromBody] Sith sith)
        {
            if (sith.Text == null)
            {
                return Json(new { error = "Feed me some text you have to, padawan young you are. Hmmm.", status = 400 });
            }
            return Json(new { sith_text = service.SithReverser(sith.Text) });
        }
        [HttpPost("/translate")]
        public IActionResult Translation([FromBody]Gibberish gibberish)
        {
            if (gibberish == null)
            {
                return BadRequest(new { error = "I can't translate that!" });
            }
            service.AddLog("Giberrish", gibberish.Lang);
            return Json(service.Translate(gibberish.Text));
        }
    }
}