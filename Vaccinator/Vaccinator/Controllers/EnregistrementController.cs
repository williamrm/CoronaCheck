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

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Enregistrement/bienvenue/ 

        public string bienvenue(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }


    }
}
