﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vaccinator.Models
{
    public class Injection
    {
        public int idInjection { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public DateTime date_rappel { get; set; }
    }
}
