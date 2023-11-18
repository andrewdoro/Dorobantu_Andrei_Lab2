using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dorobantu_Andrei_Lab2.Models;

namespace Dorobantu_Andrei_Lab2.Data
{
    public class Dorobantu_Andrei_Lab2Context : DbContext
    {
        public Dorobantu_Andrei_Lab2Context (DbContextOptions<Dorobantu_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dorobantu_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dorobantu_Andrei_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
