using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepWork2022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //Action Method 
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }


    }
}
