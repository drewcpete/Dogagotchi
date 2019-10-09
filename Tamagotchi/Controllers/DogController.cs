using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThePound.Models;

namespace ThePound.Controllers
{
    public class DogController : Controller
    {

      [HttpGet("/dog/new")]
      public ActionResult Adopt()
      {
        return View();
      }

      [HttpPost("/dog/new")]
      public ActionResult Adopted(string newName, string type)
      {
        Dog newDog;
          if (type == "GoldenRetriever")
          {
              newDog = new GoldenRetriever(newName);
          }
          else if (type == "BostonTerrier")
          {
            newDog = new BostonTerrier(newName);
          }
          else if (type == "GermanShephard")
          {
            newDog = new GermanShepard(newName);
          
          }
          else if (type == "KingCharlesCavalier")
          {
            newDog = new KingCharlesCavalier(newName);
          }
          else
          {
            newDog = new GermanShepard("dog");
          }
          return View(newDog);
      }
    }
} 