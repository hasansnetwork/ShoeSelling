using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoeSelling.Models
{
    public class ShoesContext : DbContext
    {
        public ShoesContext (DbContextOptions<ShoesContext> options)
            : base(options)
        {
        }

        public DbSet<ShoeSelling.Models.Size> Size { get; set; }
    }
}
