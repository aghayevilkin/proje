using _27032021.Data;
using _27032021.Models;
using _27032021.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;


namespace _27032021.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.data = "Viewbag is alive!";
            ViewData["data2"] = "Viewdata is alive!";
            TempData["data3"] = "Tempdata is alive!";
            TempData.Keep();

            //HttpContext.Session.SetString("Username", "rasimabbas");


            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(5)
            };

            Response.Cookies.Append("lastViewProducts", "1-5", options);

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(VmCustomer model)
        {
            if (ModelState.IsValid)
            {
                if (model.ConfirmPassword == null)
                {
                    ModelState.AddModelError("ConfirmPassword", "Required");
                    return View(model);
                }

                if (model.Password == model.ConfirmPassword)
                {
                    Customer customer = new Customer();
                    customer.Name = model.Name;
                    customer.Email = model.Email;
                    customer.CountryId = 1;
                    customer.AddedDate = DateTime.Now;
                    customer.Password = Crypto.HashPassword(model.Password);
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                }
                else
                {
                    ModelState.AddModelError("ConfirmPassword", "Password not match!");
                    return View(model);
                }
            }
            return RedirectToAction("index", "home");
        }

        public IActionResult Login(bool? isCart, int? isCommentPrdId)
        {
            VmCustomer model = new VmCustomer()
            {
                isCart = isCart,
                isCommentPrdId = isCommentPrdId
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Login(VmCustomer model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = _context.Customers.FirstOrDefault(c => c.Email == model.Email);
                if (customer != null)
                {
                    if (Crypto.Verify(model.Password, customer.Password))
                    {
                        string customerObj = JsonConvert.SerializeObject(customer);
                        HttpContext.Session.SetString("ValidCustomer", customerObj);
                        if (model.isCart == true)
                        {
                            return RedirectToAction("checkout", "shop");
                        }

                        if (model.isCommentPrdId != null)
                        {
                            return RedirectToAction("details", "shop", new { id = model.isCommentPrdId });
                        }

                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password duzgun deyil!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email movcud deyil!");
                }

            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Subscribe(Subscribe model)
        {
            if (ModelState.IsValid)
            {
                model.AddedDate = DateTime.Now;
                _context.Subscribes.Add(model);
                _context.SaveChanges();
            }

            return RedirectToAction("index");
        }
    }
}
