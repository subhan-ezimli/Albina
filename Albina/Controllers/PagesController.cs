using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albina.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }

}
