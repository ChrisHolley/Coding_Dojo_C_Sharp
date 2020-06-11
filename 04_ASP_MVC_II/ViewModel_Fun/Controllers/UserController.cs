using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;


namespace ViewModel_Fun.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            List<User> ListOfUsers = new List<User>
            {
                new User("Chris", "Holley"),
                new User("Kael", "Farstrider"),
                new User("Sandtorn", "Barbarian"),
                new User("Athel", "Staghorn")
            };
            return View(ListOfUsers);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
