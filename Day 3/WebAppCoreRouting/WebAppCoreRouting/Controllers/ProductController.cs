using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCoreRouting.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id, int catid)
        {
            return View();
        }
        
        [Route("product/{url}")]
        public IActionResult Details(string url)
        {
            return View();
        }
    }
}