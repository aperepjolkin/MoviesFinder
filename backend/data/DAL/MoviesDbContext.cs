using data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.DAL
{
    public class MoviesDbContext : DbContext
    {

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
             : base(options)
        {

        }
        //entities
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
      

    }
}
