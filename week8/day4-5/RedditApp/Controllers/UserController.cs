using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Models;
using RedditApp.Services;

namespace RedditApp.Controllers
{
    [Route("/")]
    public class UserController : Controller
    {
        private IUser userRepository;
        private IReddit redditRepository;
        public UserController(IUser userRepository, IReddit redditRepository)
        {
            this.userRepository = userRepository;
            this.redditRepository = redditRepository;
        }
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(string name, string password, string email)
        {
            userRepository.Register(name, password, email);
            return RedirectToAction("Homepage");
        }
    }
}
