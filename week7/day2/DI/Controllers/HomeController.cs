using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DI.Services;

namespace DI.Controllers
{
    [Route("useful")]
    public class UsefulController : Controller
    {
        UtilityService utilityService;

        public UsefulController(UtilityService utilityService)
        {
            this.utilityService = utilityService;
        }

        [HttpGet("")]
        public IActionResult Useful()
        {
            return View();
        }

        // GET: /<controller>/
        [HttpGet("colored")]
        public IActionResult Colored()
        {
            return View("Index", utilityService);
        }
        [HttpGet("email")]
        public IActionResult ValidateMail(string email)
        {
            var mail = utilityService.ValidateEmail(email);

            return View("Email", mail);
        }
        [HttpGet("encode")]
        public IActionResult Encode(string text, int shift)
        {
            var model = utilityService.Caesar(text, shift);
            return View("Caesar", model);
        }
        [HttpGet("decode")]
        public IActionResult Decode(string text, int shift)
        {
            var model = utilityService.Caesar(text, -shift);
            return View("Caesar", model);
        }       
    }
}
