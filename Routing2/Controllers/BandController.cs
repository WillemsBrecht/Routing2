using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyClasses;

namespace Routing2.Controllers {
    [Route("[controller]")]
    public class BandController : Controller {
        [Route("[action]")]
        public IActionResult Index() {
            ViewBag.message = "Nothing to see here.";
            return View();
        }

        [Route("[action]/[controller]/{bandname:string}/{year:int}")]
        [Route("[action][controller]/Naam/{bandname:string}/Jaar/{year:int}]")]
        public IActionResult Maak(string bandname, int year) {
            ViewBag.Band = new Band { Name = bandname, Year = year };
            return View();
        }
    }
}