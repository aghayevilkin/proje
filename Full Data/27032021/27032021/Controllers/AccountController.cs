using _27032021.Data;
using _27032021.Filters;
using _27032021.Models;
using _27032021.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;

namespace _27032021.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }


        [Auth]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("ValidCustomer");
            return RedirectToAction("index", "home");
        }

        public IActionResult ForgetPassword()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ForgetPassword(string email)
        {
            if (email != null)
            {
                Customer customer = _context.Customers.FirstOrDefault(c => c.Email == email);

                if (customer == null)
                {
                    HttpContext.Session.SetString("wrongMail", "true");
                    return View();
                }

                string token = "jsdfnvlsdbvklbfv";
                customer.Token = token;
                _context.Update(customer);
                _context.SaveChanges();


                //Sending mail
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("codegroupsp@gmail.com", "Code academy p509");
                mail.To.Add(email);
                mail.Body = "<h1>Salam ay qa</h1>" +
                    "<p>For resetting password please visit the link below</p>" +
                    "<a href='https://localhost:44363/account/resetpassword?email=" + email + "&token=" + token + "'>Reset password</a>";
                mail.IsBodyHtml = true;
                mail.Subject = "Reset password";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("codegroupsp@gmail.com", "codegroupsp2021");

                smtpClient.Send(mail);
                //End of sending mail


                HttpContext.Session.SetString("mailSent", "true");
                return RedirectToAction("login", "home");
            }
            else
            {
                HttpContext.Session.SetString("wrongMail", "true");
                return View();
            }
        }

        public IActionResult ResetPassword(string email, string token)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Email == email);
            if (customer == null)
            {
                return RedirectToAction("register", "home");
            }
            else
            {
                if (customer.Token != token)
                {
                    return RedirectToAction("register", "home");
                }

                HttpContext.Session.SetString("token", token);
                return View();
            }
        }


        [HttpPost]
        public IActionResult ResetPassword(VmResetpassword model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password!=model.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Password do not match!");
                    return View(model);
                }

                string token= HttpContext.Session.GetString("token");

                if (token==null)
                {
                    return RedirectToAction("register", "home");
                }

                Customer customer = _context.Customers.FirstOrDefault(c => c.Token == token);
                customer.Password = Crypto.HashPassword(model.Password);
                customer.Token = null;
                _context.Update(customer);
                _context.SaveChanges();
                return RedirectToAction("login", "home");
            }
            else
            {
                return View(model);
            }
        }
    }
}
