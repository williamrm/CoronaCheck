using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcVaccin.Models;

namespace MvcType.Models
{
    public class Type
    {
        public int idType { get; set; }
        public string maladie { get; set; }
        public virtual Vaccin Vaccin { get; set; }
    }
}
