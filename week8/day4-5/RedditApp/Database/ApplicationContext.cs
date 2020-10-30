using Microsoft.EntityFrameworkCore;
using RedditApp.Models;

namespace RedditApp.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}