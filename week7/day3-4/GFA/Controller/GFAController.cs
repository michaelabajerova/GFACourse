using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class GFAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
