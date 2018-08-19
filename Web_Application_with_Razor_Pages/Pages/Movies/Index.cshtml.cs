using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Application_with_Razor_Pages.Models;

namespace Web_Application_with_Razor_Pages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Web_Application_with_Razor_Pages.Models.Web_Application_with_Razor_PagesContext _context;

        public IndexModel(Web_Application_with_Razor_Pages.Models.Web_Application_with_Razor_PagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            var movies = from m in _context.Movie
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            Movie = await movies.ToListAsync();
        }
    }
}
