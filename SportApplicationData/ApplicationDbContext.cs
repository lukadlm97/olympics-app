using Microsoft.EntityFrameworkCore;
using SportApplicationData.Models;
using System;

namespace SportApplicationData
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public ApplicationDbContext()
        {

        }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Athlete> Athletes { get; set; }
        public virtual DbSet<Category> Categories{ get; set; }
    }
}
