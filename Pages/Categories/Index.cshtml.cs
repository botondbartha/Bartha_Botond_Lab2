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
    public class IndexModel : PageModel
    {
        private readonly Bartha_Botond_Lab2.Data.Bartha_Botond_Lab2Context _context;

        public IndexModel(Bartha_Botond_Lab2.Data.Bartha_Botond_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
