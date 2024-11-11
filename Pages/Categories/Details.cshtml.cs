using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bartha_Botond_Lab2.Data;
using Bartha_Botond_Lab2.Models;

namespace Bartha_Botond_Lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Bartha_Botond_Lab2.Data.Bartha_Botond_Lab2Context _context;

        public DetailsModel(Bartha_Botond_Lab2.Data.Bartha_Botond_Lab2Context context)
        {
            _context = context;
        }

        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
