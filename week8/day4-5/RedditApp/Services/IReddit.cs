using System.Collections.Generic;
using RedditApp.Models;

namespace RedditApp.Services
{
    public interface IReddit
    {
        void AddPost(Post newPost);

        void Upvote(Post votedPost);

        void DownVote(Post votedPost);

        Post GetPost(int postId);
        void DeletePost(int id);

        List<Post> GetAllPost();
    }
}