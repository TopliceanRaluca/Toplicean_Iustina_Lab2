using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Toplicean_Iustina_Lab2.Models;

namespace Toplicean_Iustina_Lab2.Data
{
    public class Toplicean_Iustina_Lab2Context : DbContext
    {
        public Toplicean_Iustina_Lab2Context (DbContextOptions<Toplicean_Iustina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Toplicean_Iustina_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
