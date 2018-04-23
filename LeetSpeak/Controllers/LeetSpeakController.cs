using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LeetSpeakApp.Models;

namespace LeetSpeakApp.Controllers
{
      public class LeetSpeakController : Controller
      {
            [HttpGet("/")]
            public ActionResult Index()
            {
              return View();
            }

      }
}
