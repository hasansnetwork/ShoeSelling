using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSelling.Models
{
    public class ColorRepo : DbContext
    {
        public ColorRepo(DbContextOptions<ColorRepo> options) :base(options)
        {

        }

        public DbSet<Color> ColorTable { get; set; }
    }
}
