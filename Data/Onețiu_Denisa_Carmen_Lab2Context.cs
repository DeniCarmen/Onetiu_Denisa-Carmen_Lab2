
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onețiu_Denisa_Carmen_Lab2.Models;

namespace Onețiu_Denisa_Carmen_Lab2.Data
{
    public class Onețiu_Denisa_Carmen_Lab2Context : DbContext
    {
        public Onețiu_Denisa_Carmen_Lab2Context (DbContextOptions<Onețiu_Denisa_Carmen_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Onețiu_Denisa_Carmen_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Onețiu_Denisa_Carmen_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Onețiu_Denisa_Carmen_Lab2.Models.Category> Category { get; set; }
    }
}
