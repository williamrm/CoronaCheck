using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MvcInjection.Models;

namespace MvcVaccin.Models
{
    public class Vaccin
    {
        [Key]
        public int idVaccin { get; set; }

        public string marque { get; set; }
        public int num_lot { get; set; }
        public virtual Injection Injection { get; set; }
    }
}
