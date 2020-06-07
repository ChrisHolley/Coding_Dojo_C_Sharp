using Microsoft.AspNetCore.Mvc;

namespace projName
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Register()
        {
            //server will look for WellHelloThere.cshtml if the method name is WellHelloThere()
            //server will look in Views folder
            //then folder of controller name: Home
            //then the .cshtml file matching the method name: WellHelloThere() = WellHelloThere.cshtml
            //if the file can't be found in the above path, ASP will search in the other View folders
            return View();
            //you can also put in View("WellHelloThere")
            //ASP will look for WellHelloThere.cshtml in all the View directories
        }
        [HttpGet("contact")]
        public ViewResult Login()
        {
            return View();
        }


        [HttpPost("userregister")]
        public ViewResult UserRegister(string name, string dojoLoc, string favLang, string message)
        {
            ViewBag.Name = name;
            ViewBag.Dojo = dojoLoc;
            ViewBag.Lang = favLang;
            ViewBag.Message = message;
            return View();
        }
    }
}