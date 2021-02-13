using Microsoft.EntityFrameworkCore;
using Vaccinator.Models;

namespace MvcTest.Data
{
    public class MvcTestContext : DbContext
    {
        public MvcTestContext(DbContextOptions<MvcTestContext> options)
            : base(options)
        {
        }

        public DbSet<test> test { get; set; }
    }
}