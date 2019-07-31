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
            ProjectClass starterItem = new ProjectClass("Add first item to To Do List");
            return View(starterItem);
        }

    }
}