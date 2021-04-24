using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27032021.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Append("lastViewProducts", "", options);
            return View();
        }
    }
}
