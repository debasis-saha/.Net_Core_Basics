using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TagHelperDemo.Controllers
{
    public class Demo2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}