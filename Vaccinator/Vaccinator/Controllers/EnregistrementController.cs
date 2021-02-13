using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace Vaccinator.Controllers
{
    public class EnregistrementController : Controller
    {
        // 
        // GET: /Enregistrement/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Enregistrement/bienvenue/ 

        public IActionResult bienvenue(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }


    }
}
