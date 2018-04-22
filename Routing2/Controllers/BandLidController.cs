using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Routing2.Controllers
{
    public class BandLidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}