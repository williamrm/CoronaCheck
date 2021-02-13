using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcInjection.Models;

namespace MvcVaccin.Models
{
    public class Vaccin
    {
        public int idVaccin { get; set; }
        public string marque { get; set; }
        public int num_lot { get; set; }
        public virtual Injection Injection { get; set; }
    }
}
