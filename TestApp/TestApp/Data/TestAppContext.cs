using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Models
{
    public class TestAppContext : DbContext
    {
        public TestAppContext (DbContextOptions<TestAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestApp.Models.Product> Product { get; set; }
    }
}
