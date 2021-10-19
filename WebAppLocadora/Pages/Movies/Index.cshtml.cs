using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppLocadora.Data;
using WebAppLocadora.Model;

namespace WebAppLocadora.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebAppLocadora.Data.WebAppLocadoraContext _context;

        public IndexModel(WebAppLocadora.Data.WebAppLocadoraContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
