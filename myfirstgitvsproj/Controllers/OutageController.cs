using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myfirstgitvsproj.Controllers
{
    public class OutageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult getOutage()
        {
            return View();
        }
    }
}