using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web_Application_with_Razor_Pages.Models
{
    public class Web_Application_with_Razor_PagesContext : DbContext
    {
        public Web_Application_with_Razor_PagesContext (DbContextOptions<Web_Application_with_Razor_PagesContext> options)
            : base(options)
        {
        }

        public DbSet<Web_Application_with_Razor_Pages.Models.Movie> Movie { get; set; }
    }
}
