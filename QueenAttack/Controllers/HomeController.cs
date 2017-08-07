using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using QueenAttack.Models;

namespace QueenAttack.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      
      [HttpPost("/queen/play")]
      public ActionResult Play()
      {
        Queen queen = new Queen (int.Parse(Request.Form["queen-position-x"]), int.Parse(Request.Form["queen-position-y"]));
        Queen target = new Queen (int.Parse(Request.Form["target-position-x"]), int.Parse(Request.Form["target-position-y"]));
        bool Attack = queen.CanAttack(queen.GetX(), queen.GetY(), target.GetX(), target.GetY());
        return View (Attack);
      }
    }
}
