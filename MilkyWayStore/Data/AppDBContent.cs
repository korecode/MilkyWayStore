using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MilkyWayStore.Data.Models;

namespace MilkyWayStore.Data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        
        public DbSet<Book> Book { get; set;}
        public DbSet<Category> Category { get; set;}
        
    }
}
