using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models;
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

        public IActionResult validateRequestForm(Request request)
        {
            if (request.validateProperties())//if valid form data
            {
                Repository.AddToRepository(request);//add validated request to respository
                request.FormErrors.Clear();//remove all previous errors
                ViewBag.ErrorMessage = "";//do not display any errors
                return View("Confirmation");//go to confirmation
            }
            else
            {
                ViewBag.ErrorMessage = String.Concat(request.FormErrors);//if error, display all errors
                return View("RequestForm");//go back to RequestForm
            }
            
        }
        
        public IActionResult RequestForm()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult EquipmentListing()
        {
            return View("EquipmentListing", Repository.EquipmentList);
        }

        public IActionResult AvailableEquipment()
        {
            return View("AvailableEquipment", Repository.EquipmentList);
        }
    }
}