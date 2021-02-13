using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcPersonne.Models
{
    public class Personne
    {
        public int idPersonne { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public bool sexe { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_naissance { get; set; }
        public bool isResident { get; set; }
    }
}
