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

        [HttpGet("/tamagotchi/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/tamagotchi")]
        public ActionResult Create(string tamaName)
        {
            TamagotchiAnimal newTama = new TamagotchiAnimal(tamaName);
            return RedirectToAction("Index");
        }

    }
}