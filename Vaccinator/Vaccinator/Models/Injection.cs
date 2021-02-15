using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcInjection.Models
{
    public class Injection
    {
        [Key]
        public int idInjection { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public DateTime date_rappel { get; set; }
    }
}
