using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcType.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcType.Data
{
    public class MvcTypeContext : DbContext
    {
        public MvcTypeContext(DbContextOptions<MvcTypeContext> options)
             : base(options)
        {
        }

        public DbSet<MvcTypeContext> Type { get; set; }
    }
}
