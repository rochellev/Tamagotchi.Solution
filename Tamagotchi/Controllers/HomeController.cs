using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        // routes go here

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}