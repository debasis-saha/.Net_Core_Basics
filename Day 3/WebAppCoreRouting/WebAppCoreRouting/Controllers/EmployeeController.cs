using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCoreRouting.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Employee/Show-Details/{id}/{deptid}")]
        //[Route("~/index/{id:int}/{deptid:int}")]
        public IActionResult Index(int id, int deptid)
        {
            return View();
        }

    }
}