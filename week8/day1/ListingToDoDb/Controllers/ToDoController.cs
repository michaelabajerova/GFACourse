using ListingToDoDb.Database;
using ListingToDoDb.Models.Entities;
using ListingToDoDb.Models.ViewModels;
using ListingToDoDb.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDoDb.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        public IAssignee serviceAss;
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
        [HttpGet("/listAssignee")]
        public IActionResult ListAssignees()
        {
            return View("listAssignee");
        }
        [HttpGet("/add")]
        public IActionResult RenderAdd()
        {
            return View("AddAssignee");
        }

        [HttpPost("/add")]
        public IActionResult Add(Assignee assignee)
        {
            serviceAss.AddAssignee(assignee);
            return RedirectToAction("listAssignee");
        }
        [HttpPost("/delete")]
        public IActionResult Delete(int id)
        {
            serviceAss.DeleteAssignee(id);
            return RedirectToAction("listAssignee");
        }
    }
}