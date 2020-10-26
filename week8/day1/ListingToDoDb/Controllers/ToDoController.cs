using ListingToDoDb.Models.ViewModels;
using ListingToDoDb.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDoDb.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        public IToDoService service;

        public ToDoController(IToDoService service)
        {
            this.service = service;
        }

        [HttpGet("/list")]
        public IActionResult List()
        {
            var model = service.FirstTodo();
            return View("List", model);
        }

        [HttpGet("/active")]
        public IActionResult ActiveList()
        {
            var list = service.ActiveTasks();
            return View("List", list);
        }

        [HttpGet("/addTask")]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost("/addTask")]
        public IActionResult AddNewItem(ToDo todo)
        {
            service.AddTask(todo);
            return RedirectToAction("List");
        }
    }
}