using Microsoft.AspNetCore.Mvc;

namespace PortfolioII
{
    public class ProjectsController : Controller
    {
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            //server will look for WellHelloThere.cshtml
            //server will look in Views folder
            //then folder of controller name: Home
            //then the .cshtml file matching the method name: WellHelloThere() = WellHelloThere.cshtml
            //if the file can't be found in the above path, ASP will search in the other View folders
            return View();
            //you can also put in View("WellHelloThere")
            //ASP will look for WellHelloThere.cshtml in all the View directories
        }
    }
}