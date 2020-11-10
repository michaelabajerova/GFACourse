using ChatApp.Models;
using ChatApp.Models.Get;
using ChatApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [Route("json")]
    public class ChatController : Controller
    {
        private ChatService chatService;

        public ChatController(ChatService chatService)
        {
            this.chatService = chatService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(UserCredentials registerCredentials)
        {
            var registerRequest = chatService.Register(registerCredentials.Login, registerCredentials.Password);
            return RedirectToAction("Login", registerRequest);
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login(UserCredentials loginCredentials)
        {
            var loginRequest = chatService.Login(loginCredentials);

            return RedirectToAction("Index");
        }

    }
}