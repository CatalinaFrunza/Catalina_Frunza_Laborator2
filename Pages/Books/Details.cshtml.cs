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
    public class DetailsModel : PageModel
    {
        private readonly Catalina_Frunza_Laborator2.Data.Catalina_Frunza_Laborator2Context _context;

        public DetailsModel(Catalina_Frunza_Laborator2.Data.Catalina_Frunza_Laborator2Context context)
        {
            _context = context;
        }

      public Models.Books Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
