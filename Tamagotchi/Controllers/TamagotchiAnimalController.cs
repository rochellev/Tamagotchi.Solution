using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class TamagotchiAnimalController : Controller
    {
        [HttpGet("/tamagotchi")]
        public ActionResult Index()
        {
            return View();
        }

    }
}