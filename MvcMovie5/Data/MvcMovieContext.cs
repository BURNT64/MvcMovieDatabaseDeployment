using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie5.Data
{
    public class MvcMovieContext : DbContext
    {

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
    : base(options)
        {
        }

        public DbSet<MvcMovie5.Models.Movie> Movie { get; set; }

    }
}
