using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingToDoDb.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ListingToDoDb.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
