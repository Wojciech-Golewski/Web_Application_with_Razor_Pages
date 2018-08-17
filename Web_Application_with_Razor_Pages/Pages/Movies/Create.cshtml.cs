using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_Application_with_Razor_Pages.Models;

namespace Web_Application_with_Razor_Pages.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Web_Application_with_Razor_Pages.Models.Web_Application_with_Razor_PagesContext _context;

        public CreateModel(Web_Application_with_Razor_Pages.Models.Web_Application_with_Razor_PagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}