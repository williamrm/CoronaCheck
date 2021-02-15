using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MvcInjection.Models;

namespace MvcPersonne.Models
{
    public class Personne
    {
        public Personne ()
        {
            this.Injections = new HashSet<Injection>();
        }
        [Key]
        public int idPersonne { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public bool sexe { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_naissance { get; set; }
        public bool isResident { get; set; }
        public virtual ICollection<Injection> Injections { get; set; }
    }
}
