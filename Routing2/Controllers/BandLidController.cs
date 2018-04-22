using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyClasses;

namespace Routing2.Controllers {
    [Route("")]
    [Route("[controller]")]
    public class BandLidController : Controller {

        [Route("[action]")]
        public IActionResult Index() {
            ViewBag.message = "Nothing to see here.";
            return View();
        }

        //[Route("[action]/[controller]/{name}/{age:int}/{geslacht:GenderOptions}/{bandname}")]
        [Route("[action]/[controller]/{name}/{age:int}/{geslacht:GenderOptions}/{bandname}")]
        public IActionResult Maak(string name, int age, GenderOptions geslacht, string bandname) {
            ViewBag.Bandmember = new BandMember { Name = name, Age = age, Gender = geslacht };
            ViewBag.Band = bandname;
            return View();
        }
    }
}