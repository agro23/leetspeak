using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LeetSpeak.Models;

namespace LeetSpeak.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      // return View("Index", Request.Form["text"]);
      return View ("Index", LeetSpeaks.ToLeetSpeak(Request.Form["text"]));
    }
  }
}
