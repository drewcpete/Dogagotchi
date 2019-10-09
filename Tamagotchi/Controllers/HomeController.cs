using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThePound.Models;

namespace ThePound.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Dog> Dogs = new List<Dog>();
        BostonTerrier IceT = new BostonTerrier("Ice-T");
        GoldenRetriever Pete = new GoldenRetriever("Pete");
        KingCharlesCavalier Chuck = new KingCharlesCavalier("Chuck");
        GermanShepard Dolph = new GermanShepard("Dolph");
        return View();
      }
    }
} 