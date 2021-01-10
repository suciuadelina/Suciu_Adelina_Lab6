using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Suciu_Adelina_Lab6.Models;

namespace Suciu_Adelina_Lab6.Data
{
    public class Suciu_Adelina_Lab6Context : DbContext
    {
        public Suciu_Adelina_Lab6Context (DbContextOptions<Suciu_Adelina_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Suciu_Adelina_Lab6.Models.Book> Book { get; set; }
    }
}
