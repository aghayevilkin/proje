using _27032021.Data;
using _27032021.Models;
using _27032021.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;

namespace _27032021.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(VmProduct filter, int page = 1)
        {
            ViewBag.Filter = new Dictionary<string, string>
            {
                {"minPrice",filter.minPrice+"" },
                {"maxPrice",filter.maxPrice+"" },
                {"catId",filter.catId+"" },
            };

            decimal pageItemCount = 3;

            List<Product> productsList = _context.Products.Include(c => c.ColorToProducts)
                                                     .ThenInclude(c => c.Color)
                                                     .Where(pr => (filter.minPrice != null ? pr.ColorToProducts.FirstOrDefault().Price >= filter.minPrice : true) &&
                                                                  (filter.maxPrice != null ? pr.ColorToProducts.FirstOrDefault().Price <= filter.maxPrice : true) &&
                                                                  (filter.catId != null ? pr.CategoryId == filter.catId : true))
                                                     .ToList();

            decimal b = Math.Ceiling(productsList.Count / pageItemCount);
            ViewBag.PageCount = Convert.ToInt32(b);
            ViewBag.ActivePage = page;

            List<Product> products = productsList.OrderBy(p => p.Id)
                                                     .Skip((page - 1) * (int)pageItemCount).Take((int)pageItemCount)
                                                     .ToList();

            VmProduct model = new VmProduct()
            {
                Products = products,
                ProductCategories = _context.ProductCategories.Include(p => p.Products).ToList(),
                Tags = _context.Tags.ToList(),
                Colors = _context.Colors.Include(p => p.ColorToProducts).ThenInclude(c => c.Product).ThenInclude(a => a.ColorToProducts).ToList(),
                Filter = filter
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VmProduct vmProduct = new VmProduct
            {
                Product = _context.Products.Include(p => p.ColorToProducts).ThenInclude(c => c.Color)
                                               .Include(i => i.ProductImages)
                                               .Include(f => f.ProductCategory)
                                               .Include(d => d.Features)
                                               .Include(r => r.Reviews)
                                               .ThenInclude(c => c.Customer)
                                               .FirstOrDefault(a => a.Id == id)
            };

            return View(vmProduct);
        }

        public JsonResult getPriceByColor(int? id)
        {
            if (id == null)
            {
                return Json(404);
            }

            ColorToProduct colorToProduct = _context.ColorToProducts.Find(id);
            if (colorToProduct == null)
            {
                return Json(404);
            }

            var model = _context.ColorToProducts.Select(p => new
            {
                p.Id,
                p.Price,
                p.DiscountPrice,
                IsDiscount = colorToProduct.DiscountDeadline > DateTime.Now ? true : false
            }).FirstOrDefault(i => i.Id == id);

            //VmGetPriceByColor model = new VmGetPriceByColor();
            //if (colorToProduct.DiscountDeadline > DateTime.Now)
            //{
            //    model.Price = colorToProduct.Price;
            //    model.DiscountPrice = colorToProduct.DiscountPrice;
            //    model.IsDiscount = true;
            //}
            //else
            //{
            //    model.Price = colorToProduct.Price;
            //    model.DiscountPrice = null;
            //    model.IsDiscount = false;
            //}

            //var myModel = JsonConvert.SerializeObject(model);
            return Json(model);
        }

        public JsonResult addToCart(int? id)
        {
            if (id == null)
            {
                return Json(404);
            }

            ColorToProduct colorToProduct = _context.ColorToProducts.Find(id);
            if (colorToProduct == null)
            {
                return Json(404);
            }

            decimal count = 1;
            bool isExist = false;

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(5)
            };

            if (Request.Cookies["cart"] != null)
            {
                string oldCart = Request.Cookies["cart"];
                List<string> prdList = oldCart.Split("/").ToList();
                foreach (var item in prdList)
                {
                    if (Convert.ToInt32(item.Split("-")[0]) == id)
                    {
                        isExist = true;
                        break;
                    }
                }

                if (!isExist)
                {
                    string newPrd = id + "-" + count;
                    string newCart = oldCart + "/" + newPrd;
                    Response.Cookies.Append("cart", newCart, options);
                }
            }
            else
            {
                Response.Cookies.Append("cart", "" + id + "-" + count + "", options);
            }

            return Json(200);
        }

        public JsonResult updateCart(int? id, int? quantity)
        {
            if (id == null || quantity == null)
            {
                return Json(404);
            }

            int indexOfPrd = 0;

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(5)
            };

            if (Request.Cookies["cart"] != null)
            {
                string oldCart = Request.Cookies["cart"];
                List<string> prdList = oldCart.Split("/").ToList();
                foreach (var item in prdList)
                {
                    if (Convert.ToInt32(item.Split("-")[0]) == id)
                    {
                        indexOfPrd = prdList.IndexOf(item);
                        break;
                    }
                }

                prdList[indexOfPrd] = id + "-" + quantity;

                string newCart = null;
                foreach (var item in prdList)
                {
                    if (item == prdList[prdList.Count - 1])
                    {
                        newCart += item;
                    }
                    else
                    {
                        newCart += item + "/";
                    }
                }

                if (newCart != null)
                {
                    Response.Cookies.Append("cart", newCart, options);
                }
            }
            else
            {
                return Json(404);
            }

            return Json(200);
        }

        public IActionResult Cart()
        {
            string cart = Request.Cookies["cart"];
            if (cart == null)
            {
                return View();
            }
            List<string> prdList = cart.Split("/").ToList();
            List<VmCart> products = new List<VmCart>();

            foreach (var item in prdList)
            {
                int prdId = Convert.ToInt32(item.Split("-")[0]);
                int prdQuantity = Convert.ToInt32(item.Split("-")[1]);
                VmCart prd = new VmCart();
                ColorToProduct product = _context.ColorToProducts.Include(i => i.Product).FirstOrDefault(c => c.Id == prdId);
                if (product == null)
                {
                    return NotFound();
                }

                prd.Id = product.Id;
                prd.MainImage = product.Product.MainImage;
                prd.Name = product.Product.Name;
                prd.Price = product.Price;
                prd.Quantity = prdQuantity;
                prd.MaxQuantity = product.Quantity;

                products.Add(prd);
            }

            return View(products);
        }

        public JsonResult removeFromCart(int? id)
        {
            if (id == null)
            {
                return Json(404);
            }

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(5)
            };

            if (Request.Cookies["cart"] != null)
            {
                string oldCart = Request.Cookies["cart"];
                List<string> prdList = oldCart.Split("/").ToList();
                string prd = null;

                foreach (var item in prdList)
                {
                    if (Convert.ToInt32(item.Split("-")[0]) == id)
                    {
                        prd = item;
                        break;
                    }
                }

                if (prd != null)
                {
                    prdList.Remove(prd);
                    string newCart = null;
                    foreach (var item in prdList)
                    {
                        if (item == prdList[prdList.Count - 1])
                        {
                            newCart += item;
                        }
                        else
                        {
                            newCart += item + "/";
                        }
                    }
                    if (newCart != null)
                    {
                        Response.Cookies.Append("cart", newCart, options);
                    }
                    else
                    {
                        options.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Append("cart", "", options);
                    }
                }
            }
            else
            {
                return Json(404);
            }

            return Json(200);
        }

        public IActionResult Checkout()
        {
            List<Country> countries = _context.Countries.ToList();
            countries.Insert(0, new Country { Id = 0, Name = "Coutry*" });
            ViewBag.Coutry = countries;

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(VmCustomerNotRegistered model)
        {
            if (ModelState.IsValid)
            {
                //Request to Bank API
                //
                //
                //
                //
                //Response
                bool cardIsOk = true;
                //End of API to Bank


                if (cardIsOk)
                {
                    Customer logedInCustomer = null;
                    string logedInCustomerStr = HttpContext.Session.GetString("ValidCustomer");
                    if (logedInCustomerStr != null)
                    {
                        logedInCustomer = JsonConvert.DeserializeObject<Customer>(logedInCustomerStr);
                    }

                    if (logedInCustomer == null)
                    {
                        Customer customer = _context.Customers.FirstOrDefault(c => c.Email == model.Email);
                        if (customer == null)
                        {
                            Customer newCustomer = new Customer();
                            newCustomer.Name = model.Name;
                            newCustomer.Surname = model.Surname;
                            newCustomer.Email = model.Email;
                            newCustomer.Phone = model.Phone;
                            newCustomer.CountryId = model.CountryId;
                            newCustomer.State = model.State;
                            newCustomer.ZipCode = model.ZipCode;
                            newCustomer.Company = model.Company;
                            newCustomer.Address = model.Address;
                            newCustomer.HasAccount = false;
                            newCustomer.AddedDate = DateTime.Now;
                            if (model.CreateAccount)
                            {
                                if (model.Password == model.ConfirmPassword)
                                {
                                    newCustomer.Password = Crypto.HashPassword(model.Password);
                                }
                                else
                                {
                                    ModelState.AddModelError("Password", "Password do not match");

                                    if (HttpContext.Session.GetString("ValidCustomer") == null)
                                    {
                                        List<Country> countries = _context.Countries.ToList();
                                        countries.Insert(0, new Country { Id = 0, Name = "Coutry*" });
                                        ViewBag.Coutry = countries;
                                    }
                                    return View(model);
                                }
                            }

                            _context.Customers.Add(newCustomer);
                            _context.SaveChanges();

                            logedInCustomer = newCustomer;
                        }
                        else
                        {

                            if (customer.Password == null)
                            {
                                if (model.CreateAccount)
                                {
                                    if (model.Password == model.ConfirmPassword)
                                    {
                                        customer.Password = Crypto.HashPassword(model.Password);
                                        _context.Update(customer);
                                        _context.SaveChanges();
                                    }
                                    else
                                    {
                                        ModelState.AddModelError("Password", "Password do not match");

                                        if (HttpContext.Session.GetString("ValidCustomer") == null)
                                        {
                                            List<Country> countries = _context.Countries.ToList();
                                            countries.Insert(0, new Country { Id = 0, Name = "Coutry*" });
                                            ViewBag.Coutry = countries;
                                        }
                                        return View(model);
                                    }
                                }

                                logedInCustomer = customer;
                            }
                            else
                            {
                                return RedirectToAction("Login", "Home", new { isCart = true });
                            }
                        }
                    }

                    Sale sale = new Sale();
                    string saleInvoice = "";
                    Sale lastSale = _context.Sales.OrderBy(s => s.Id).LastOrDefault();
                    if (lastSale != null)
                    {
                        saleInvoice = "AZ-" + (Convert.ToInt32(lastSale.InvoiceNo.Split("-")[1]) + 1);
                    }
                    else
                    {
                        saleInvoice = "AZ-100";
                    }

                    sale.InvoiceNo = saleInvoice;
                    sale.Date = DateTime.Now;
                    sale.CustomerId = logedInCustomer.Id;
                    _context.Sales.Add(sale);
                    _context.SaveChanges();



                    string cartCookie = Request.Cookies["cart"];
                    List<string> prdList = cartCookie.Split("/").ToList();
                    List<VmCartCookie> cartCookies = new List<VmCartCookie>();
                    foreach (var item in prdList)
                    {
                        VmCartCookie vmCartCookie = new VmCartCookie();
                        vmCartCookie.ColorToProductId = Convert.ToInt32(item.Split("-")[0]);
                        vmCartCookie.Quantity = Convert.ToDecimal(item.Split("-")[1]);
                        cartCookies.Add(vmCartCookie);
                    }

                    foreach (var item in cartCookies)
                    {
                        ColorToProduct colorToProduct = _context.ColorToProducts.Find(item.ColorToProductId);
                        SaleItem saleItem = new SaleItem();
                        saleItem.SaleId = sale.Id;
                        saleItem.ColorToProductId = item.ColorToProductId;
                        saleItem.Quantity = item.Quantity;
                        saleItem.Price = colorToProduct.Price;
                        _context.SaleItems.Add(saleItem);

                        colorToProduct.Quantity = colorToProduct.Quantity - item.Quantity;
                        _context.Entry(colorToProduct).State = EntityState.Modified;
                        _context.SaveChanges();
                    }

                    CookieOptions options = new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(-1)
                    };
                    Response.Cookies.Append("cart", "", options);

                    return RedirectToAction("index");
                }
                else
                {
                    ModelState.AddModelError("", "There is a problem with you card");
                }
            }

            if (HttpContext.Session.GetString("ValidCustomer") == null)
            {
                List<Country> countries = _context.Countries.ToList();
                countries.Insert(0, new Country { Id = 0, Name = "Coutry*" });
                ViewBag.Coutry = countries;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult AddReview(string Text, byte Rating, int productId)
        {
            string valid = HttpContext.Session.GetString("ValidCustomer");
            Customer customer = null;

            if (valid != null)
            {
                customer = JsonConvert.DeserializeObject<Customer>(valid);

                Review review = new Review()
                {
                    Text = Text,
                    ProductId = productId,
                    CustomerId = customer.Id,
                    Rating = Rating,
                    AddedDate=DateTime.Now
                };

                _context.Reviews.Add(review);
                _context.SaveChanges();

                return RedirectToAction("details", "shop", new { id = productId });
            }
            else
            {
                return RedirectToAction("login", "home", new { isCommentPrdId = productId });
            }
        }
    }
}
