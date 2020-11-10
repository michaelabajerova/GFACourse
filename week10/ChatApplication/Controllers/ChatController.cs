using ChatApplication.Models;
using ChatApplication.Models.Get;
using ChatApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.Controllers
{
    [Route("api/user")]
    public class ChatController : Controller
    {
        private readonly ChatService chatService;

        public ChatController(ChatService chatService)
        {
            this.chatService = chatService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(GetChat input)
        {
            var registered = chatService.Register(input);
            return View("MainPage");
        }

        [HttpPost("/login")]
        public IActionResult LoginUser(GetChat input)
        {
            var loggedIn = chatService.Login(input);
            return View("MainPage");
        }

        [HttpGet("/update-user")]
        public IActionResult RenderUserUpdateView()
        {
            return View("Update");
        }

        [HttpPost("/update-user")]
        public IActionResult UpdateUser(UpdateChat inputData, [FromHeader] string apiKey)
        {
            var updated = chatService.UpdateUser(inputData, apiKey);
            return View("MainPage");
        }

        [HttpPost("/logout")]
        public IActionResult LogoutUser()
        {
            chatService.LogoutUser();
            return View();
        }
    }
}