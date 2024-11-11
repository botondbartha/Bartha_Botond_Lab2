using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bartha_Botond_Lab2.Models;

namespace Bartha_Botond_Lab2.Data
{
    public class Bartha_Botond_Lab2Context : DbContext
    {
        public Bartha_Botond_Lab2Context (DbContextOptions<Bartha_Botond_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bartha_Botond_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Bartha_Botond_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
