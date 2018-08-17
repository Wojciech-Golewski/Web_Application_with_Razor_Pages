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
    public class DetailsModel : PageModel
    {
        private readonly Web_Application_with_Razor_Pages.Models.Web_Application_with_Razor_PagesContext _context;

        public DetailsModel(Web_Application_with_Razor_Pages.Models.Web_Application_with_Razor_PagesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
