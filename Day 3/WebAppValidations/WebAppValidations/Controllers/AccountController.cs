using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppValidations.Models;

namespace WebAppValidations.Controllers
{
    public class AccountController : Controller
    {
        //Account/Index
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserViewModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Please Enter Name");
            }
            if (String.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Please Enter Email");
            }

            if (ModelState.IsValid)
            {
                //TO DO:
                return RedirectToAction("Message");
            }
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }
    }
}