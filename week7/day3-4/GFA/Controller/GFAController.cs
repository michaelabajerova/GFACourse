using DI.Services;
using GFA.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    [Route("gfa")]
    public class GFAController : Controller
    {
        private IStudentService Service { get; set; }

        public GFAController(IStudentService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View("ListStud", Service.FindAll());
        }

        [HttpGet("add")]
        public IActionResult AddStudent()
        {
            return View("AddStud");
        }

        [HttpGet("save")]
        public IActionResult SaveStudent(string name)
        {
            Service.Save(name);
            var model = new StudentViewModel(Service.FindAll());
            return View("add", model);
        }
    }
}