using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPersonne.Models;

namespace MvcPersonne.Data
{
    public class MvcPersonneContext : DbContext
    {
        public MvcPersonneContext(DbContextOptions<MvcPersonneContext> options)
            : base(options)
        {
        }

        public DbSet<Personne> Personne { get; set; }
    }
}
