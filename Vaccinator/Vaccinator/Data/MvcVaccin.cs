using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcVaccin.Models;

namespace MvcVaccin.Data
{
    public class MvcVaccinContext : DbContext
    {
        public MvcVaccinContext(DbContextOptions<MvcVaccinContext> options)
             : base(options)
        {
        }

        public DbSet<Vaccin> Vaccin { get; set; }
    }
}
