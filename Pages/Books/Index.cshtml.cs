using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalina_Frunza_Laborator2.Data;
using Catalina_Frunza_Laborator2.Models;

namespace Catalina_Frunza_Laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Catalina_Frunza_Laborator2.Data.Catalina_Frunza_Laborator2Context _context;

        public IndexModel(Catalina_Frunza_Laborator2.Data.Catalina_Frunza_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Models.Books> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
