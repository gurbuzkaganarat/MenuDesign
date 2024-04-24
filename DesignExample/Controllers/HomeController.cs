using Microsoft.AspNetCore.Mvc;

namespace DesignExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
       
    }
}
