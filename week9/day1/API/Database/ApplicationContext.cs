using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}