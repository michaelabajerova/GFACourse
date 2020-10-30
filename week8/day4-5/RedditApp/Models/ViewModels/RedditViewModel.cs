using System.Collections.Generic;

namespace RedditApp.Models.ViewModels
{
    public class RedditViewModel
    {
        public List<Post> Posts { get; set; }
        public Post Post { get; set; }
        public List<User> Users { get; set; }
        public User User { get; set; }
        public RedditViewModel()
        {
            Posts = new List<Post>();
            Users = new List<User>();
        }

        public RedditViewModel(List<Post> posts)
        {
            Posts = posts;
        }
    }
}