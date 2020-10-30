using System.ComponentModel.DataAnnotations;

namespace RedditApp.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Url { get; set; }
        public int Votes { get; set; }

        public Post()
        {
        }

        public Post(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}