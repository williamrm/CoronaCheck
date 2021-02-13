using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vaccinator.Models.Data
{
    public class MvcPersonne : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
