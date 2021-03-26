using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1Film1Song1Beverage.Models;

namespace _1Film1Song1Beverage.Data
{
    public class FilmsContext : DbContext
    {
        public FilmsContext (DbContextOptions<FilmsContext> options)
            : base(options)
        {
        }

        public DbSet<_1Film1Song1Beverage.Models.Films> Films { get; set; }
    }
}
