using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Routing2.Controllers {
    [Route("")]
    [Route("[controller]")]
    public class BandLidController : Controller {

        [Route("[action]")]
        public IActionResult Index() {
            ViewBag.message = "Nothing to see here.";
            return View();
        }
    }
}