using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Models.Entities;
using ListingToDoDb.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingToDoDb.Controllers
{
   /* [Route("assignee")]
    public class AssigneeController : Controller
    {
        
        private readonly IAssignee service;

        public AssigneeController(IAssignee service)
        {
            this.service = service;
        }

        [HttpGet("/list")]
        public IActionResult List()
        {
            var model = service.FindAssignees;
            return View("listAssignee", model);
        }

        [HttpGet("/add")]
        public IActionResult RenderAdd()
        {
            return View("AddAssignee");
        }

        [HttpPost("/add")]
        public IActionResult Add(Assignee assignee)
        {
            service.AddAssignee(assignee);
            return RedirectToAction("listAssignee");
        }
        [HttpPost("/delete")]
        public IActionResult Delete(int id)
        {
            service.DeleteAssignee(id);
            return RedirectToAction(nameof(AssigneeController.List), "listAssignee");
        }
    }*/
}
