using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.username = HttpContext.Session.GetString("Username");

            ViewBag.cookie = Request.Cookies["lastViewProducts"];
            return View();
        }
    }
}
