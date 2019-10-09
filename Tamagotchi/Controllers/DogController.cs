using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThePound.Models;

namespace ThePound.Controllers
{
    public class DogController : Controller
    {
      Home home = new Home();


      [HttpGet("/dog/new")]
      public ActionResult Adopt()
      {
        return View();
      }

      [HttpGet("/dog/new/GR")]
      public ActionResult AdoptGR()
      {
        return View("~/Views/Dog/Adopt.cshtml","Golden Retreiver");
      }

      [HttpGet("/dog/new/BT")]
      public ActionResult AdoptBT()
      {
        return View("~/Views/Dog/Adopt.cshtml", "Boston Terrier");
      }
      [HttpGet("/dog/new/GS")]
      public ActionResult AdoptGS()
      {
        return View("~/Views/Dog/Adopt.cshtml", "German Shepard");
      }
      [HttpGet("/dog/new/KCC")]
      public ActionResult AdoptKCC()
      {
        return View("~/Views/Dog/Adopt.cshtml", "King Charles Cavalier");
      }

      [HttpGet("/dog/house")]
      public ActionResult DogHouse()
      {
        return View(Home.home.Dogs);
      }

      [HttpPost("/dog")]
      public ActionResult Adopted(string newName, string type)
      {
        Dog newDog;
          if (type == "Golden Retreiver")
          {
              newDog = new GoldenRetriever(newName);
          }
          else if (type == "Boston Terrier")
          {
            newDog = new BostonTerrier(newName);
          }
          else if (type == "German Shephard")
          {
            newDog = new GermanShepard(newName);          
          }
          else if (type == "King Charles Cavalier")
          {
            newDog = new KingCharlesCavalier(newName);
          }
          else
          {
            newDog = new GermanShepard("dog");
          }
          Home.home.AdoptDog(newDog);
          return View(newDog);
      }
    }
} 