using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fschool.Models;
using Microsoft.AspNetCore.Http;

namespace fschool.Controllers
{  
    public class HomeController : Controller
    {
        int x = 0;
        
        public IActionResult Index()
          
        {
            var  y = HttpContext.Session.GetInt32("value of x");
             
            x++;
            HttpContext.Session.SetInt32("value of x", x);
            return View();
        }

        public IActionResult About()
        {
            
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
