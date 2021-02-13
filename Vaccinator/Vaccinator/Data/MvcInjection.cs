using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcInjection.Data
{
    public class MvcInjectionContext : DbContext
    {
        public MvcInjectionContext(DbContextOptions<MvcInjectionContext> options)
             : base(options)
        {
        }

        public DbSet<Injection> Injection { get; set; }
    }
}
