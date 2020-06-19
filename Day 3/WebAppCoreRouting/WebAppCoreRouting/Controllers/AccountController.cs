using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCoreRouting.Models;

namespace WebAppCoreRouting.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult Login(string[] Username, string Password, string Command)
        //{
        //    return View();
        //}

        //public IActionResult Login(LoginViewModel model) //model binding
        //{
        //    return View();
        //}

        public IActionResult Login(IFormCollection form) //model binding
        {
            string Username = form["Username"];
            string Password = form["Password"];
            return View();
        }
    }
}