using Microsoft.AspNetCore.Mvc;
using RedditApp.Models;
using RedditApp.Services;
using RedditApp.Models.ViewModels;

namespace RedditApp.Controllers
{
    [Route("/")]
    public class RedditController : Controller
    {
        private IReddit redditRepository;

        public RedditController(IReddit repo)
        {
            redditRepository = repo;
        }

        [HttpGet("/")]
        public IActionResult Homepage()
        {
            return View(new RedditViewModel(redditRepository.GetAllPost()));
        }

        [HttpGet("submit")]
        public IActionResult SubmitNewPost()
        {
            return View("Submit");
        }

        [HttpPost("submit")]
        public IActionResult SubmitNewPost(string title, string url)
        {
            redditRepository.AddPost(new Post(title, url));
            return RedirectToAction("Homepage");
        }

        [HttpGet("Up/{id}")]
        public IActionResult UpVote(int id)
        {
            Post votedPost = redditRepository.GetPost(id);
            redditRepository.Upvote(votedPost);
            return RedirectToAction("Homepage");
        }

        [HttpGet("Down/{id}")]
        public IActionResult DownVote(int id)
        {
            Post votedPost = redditRepository.GetPost(id);
            redditRepository.DownVote(votedPost);
            return RedirectToAction("Homepage");
        }
        [HttpDelete("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            redditRepository.DeletePost(id);

            return RedirectToAction("Homepage");
        }

    }
}