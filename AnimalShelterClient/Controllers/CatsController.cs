using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models;

namespace AnimalShelterClient.Controllers
{
  public class CatsController : Controller
  {
    public IActionResult Index()
    {
      var allCats = Cat.GetCats();
      return View(allCats);
    }
  }
}