using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLocadora.Model;

namespace WebAppLocadora.Data
{
    public class WebAppLocadoraContext : DbContext
    {
        public WebAppLocadoraContext (DbContextOptions<WebAppLocadoraContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppLocadora.Model.Movie> Movie { get; set; }
    }
}
