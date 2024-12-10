using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bartha_Botond_Lab2.Data;
using Bartha_Botond_Lab2.Models;

namespace Bartha_Botond_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Bartha_Botond_Lab2.Data.Bartha_Botond_Lab2Context _context;

        public DetailsModel(Bartha_Botond_Lab2.Data.Bartha_Botond_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

      //      var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            Book = await _context.Book
              .Include(b => b.Author)  // Adăugăm Include pentru Author
              .Include(b => b.Publisher)  // Include pentru Publisher dacă e necesar
              .FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
        /*    else
            {
                Book = book;
            }*/
            return Page();
        }
    }
}
