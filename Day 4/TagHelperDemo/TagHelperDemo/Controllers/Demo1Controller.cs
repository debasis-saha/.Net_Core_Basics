using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel loginModelView)
        {
            ViewData["LoginName"] = loginModelView.Email;
            return RedirectToAction("Index", "Home");
        }
    }
}