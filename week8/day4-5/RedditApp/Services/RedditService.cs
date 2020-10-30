using System.Collections.Generic;
using System.Linq;
using RedditApp.Database;
using RedditApp.Models;

namespace RedditApp.Services
{
    public class RedditService : IReddit
    {
        private ApplicationContext redditContext;

        public RedditService(ApplicationContext context)
        {
            this.redditContext = context;
        }

        public List<Post> GetAllPost()
        {
            return redditContext.Posts.ToList();
        }

        public void AddPost(Post newPost)
        {
            redditContext.Posts.Add(newPost);
            redditContext.SaveChanges();
        }

        public void DownVote(Post votedPost)
        {
            votedPost.Votes--;
            redditContext.SaveChanges();
        }

        public Post GetPost(int postId)
        {
            return redditContext.Posts.Where(p => p.Id == postId).SingleOrDefault();
        }

        public void Upvote(Post votedPost)
        {
            votedPost.Votes++;
            redditContext.SaveChanges();
        }
        public void DeletePost(int id)
        {
            redditContext.Remove(GetPost(id));
            redditContext.SaveChanges();
        }
    }
}