using System.Linq;
using ListingToDoDb.Models.Entities;
using ListingToDoDb.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ListingToDoDb.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }
        public DbSet<Assignee> Assignee { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public void ModelBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                    .HasOne<Assignee>(p => p.Assignees)
                    .WithOne(p => p.Id)
                    .HasForeignKey<ToDo>();           
        }
    }
}