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
        public IActionResult Index()//redirect to homepage
        {
            ViewBag.Title = "FAST Equipment Tool";
            return View("HomePage");
        }

        public IActionResult validateRequestForm(Request request)//validates form data
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
        
        public IActionResult RequestForm()//returns request form
        {
            return View();
        }

        public IActionResult Confirmation()//return confirmation page
        {
            return View();
        }

        public IActionResult EquipmentListing()//returns with list of equipment
        {
            return View("EquipmentListing", Repository.EquipmentList);
        }

        public IActionResult AvailableEquipment()//returns with list of available equipment
        {
            return View("AvailableEquipment", Repository.EquipmentList);
        }

        public IActionResult Requests()//return all requests currently
        {
            return View("Requests", Repository.Requests);
        }

        public IActionResult RequestDetails(int id)//returns request details of specific requestID
        {
            foreach (var item in Repository.Requests)//go through all requests
            {
                if(item.RequestID == id)//if matched, return details
                {
                    return View("RequestDetails", item.RequestDetails);
                }
            }
            return NotFound();//request not found
        }


    }
}