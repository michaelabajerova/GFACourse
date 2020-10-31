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

        public UserController(IUser userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name, string password)
        {
            userRepository.Login(name, password);
            return RedirectToAction("Homepage", "Reddit");
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
            return RedirectToAction("Login");
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            userRepository.Logout();
            return RedirectToAction("Homepage");
        }
    }
}
