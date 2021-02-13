using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models
{
    public class Type
    {
        public int idType { get; set; }
        public string maladie { get; set; }
        public virtual Vaccin Vaccin { get; set; }
    }
}
