using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "FAST Equipment Tool";
            return View("HomePage");
        }
    }
}