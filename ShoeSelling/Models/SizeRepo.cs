using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSelling.Models
{
    public class SizeRepo : DbContext
    {
        public SizeRepo(DbContextOptions<SizeRepo> options) : base(options)
        {

        }

        public DbSet<Size> SizeTable { get; set; }

    }
}
