using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;


namespace ViewModel_Fun.Controllers
{
    public class NumbersController : Controller
    {
        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            Numbers num = new Numbers()
            {
                SetofNumbers = new int[] {1,2,3,5,9,10,1324}
                
            };
            return View(num);
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
