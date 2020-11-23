using System;
using System.Collections.Generic;

namespace Proje
{
    class Program
    {

        public static Product psMenu = new Product("", 0, 0, "", Categories.Car);
        public static List<SaleItem> sislMenu = new List<SaleItem>();
        public static Sale ssMenu = new Sale(sislMenu);
        public static Market mMenu = new Market();

        static void Main(string[] args)
        {

            bool wantToContinue = true;
            while (wantToContinue)
            {
                Console.Clear();
                Console.WriteLine("Chose an option:");
                Console.WriteLine("1>> Carry out operations on products");
                Console.WriteLine("2>> Carry out operations on sales");
                Console.WriteLine("3>> Log out");
                Console.WriteLine("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        do
                        {
                            muEmeliyyat();

                        } while (YesNo());
                        break;

                    case "2":
                        do
                        {
                        } while (YesNo());
                        break;

                    case "3":
                        wantToContinue = false;
                        break;
                    default:
                        break;
                }

            }




        }


        public static void muEmeliyyat()
        {

            Console.Clear();
            Console.WriteLine("Chose an option:");
            Console.WriteLine("1.1) Add New Product");
            Console.WriteLine("1.2) Change Product");
            Console.WriteLine("1.3) Remove Product");
            Console.WriteLine("1.4) Show All Products");
            Console.WriteLine("1.5) Show Products by Category");
            Console.WriteLine("1.6) Show Proudcts by Price Range");
            Console.WriteLine("1.7) Search Products by Name");
            Console.WriteLine("1.8) Esas menyuya qayit");


            switch (Console.ReadLine())
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    ChangeProduct();
                    break;
                case "3":
                    RemoveProduct();
                    break;
                case "4":
                    ShowAllProducts();
                    break;
                case "5":
                    ShowProductsCategory();
                    break;
                case "6":
                    ShowProductsPrice();
                    break;
                case "7":
                    ShowProductsSearch();
                    break;
                case "8":
                    break;
                default:
                    break;
            }

        }

        #region psMenu 1 AddProduct
        private static void AddProduct()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter Product Name:");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    if (!mMenu.Products.Exists(m => m.Name == name))
                    {
                        while (loop)
                        {
                            Console.WriteLine("Enter Product Price:");
                            double price = Convert.ToDouble(Console.ReadLine());
                            if (price > 0)
                            {
                                while (loop)
                                {
                                    Category();
                                    string category = Console.ReadLine();
                                    if (category.Length != 0 && CategoryValid(category))
                                    {
                                        while (loop)
                                        {
                                            Console.WriteLine("Enter Product Count:");
                                            int count = Convert.ToInt32(Console.ReadLine());
                                            if (count > 0)
                                            {
                                                while (loop)
                                                {
                                                    Console.WriteLine("Enter Product Code:");
                                                    string code = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(code))
                                                    {
                                                        if (!mMenu.Products.Exists(m => m.Code == code))
                                                        {
                                                            Product product = new Product(name, price, count, code, CategorySetter(category));
                                                            psMenu = product;
                                                            mMenu.Addproduct(psMenu);
                                                            Console.WriteLine("\nProduct Added !");
                                                            Console.WriteLine("Product Name: {0}\nCategory: {1}\nCount: {2}\nPrice: {3}", psMenu.Name, psMenu.Categories, psMenu.Count, psMenu.Price);
                                                            loop = false;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("The product is already available in this code!\n");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("The product code cannot be left blank!\n");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Enter the correct number!\n");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Section not selected!\n");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter the correct number!\n");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("A product with this name is already available!\n");
                    }
                }
                else
                {
                    Console.WriteLine("The name cannot be left blank!\n");
                }
            }

        }

        public static void Category()
        {
            Console.WriteLine("Select a new category: ");
            Console.WriteLine("1-Car");
            Console.WriteLine("2-Motorcycle");
            Console.WriteLine("Select an option");
        }

        public static bool CategoryValid(string categories)
        {
            string kateq = categories;
            Categories CategoryEnum = (Categories)Convert.ToInt32(categories);
            switch (kateq)
            {
                case "1":
                    CategoryEnum = Categories.Car;
                    return true;
                case "2":
                    CategoryEnum = Categories.Motorcycle;
                    return true;
                default:
                    return false;
            }
        }

        public static Categories CategorySetter(string category)
        {

            string categ = category;
            Categories CategoryEnum = (Categories)Convert.ToInt32(category);
            switch (categ)
            {
                case "1":
                    CategoryEnum = Categories.Car;
                    break;
                case "2":
                    CategoryEnum = Categories.Motorcycle;
                    break;
                default:
                    break;
            }
            return CategoryEnum;
        }


        #endregion


        #region ChangeProduct
        private static void ChangeProduct()
        {
            if (mMenu.Products.Count > 0)
            {
                Console.WriteLine("Chose an Option: ");
                Console.WriteLine("1-Change Product Name: ");
                Console.WriteLine("2-Change Product Price: ");
                Console.WriteLine("3-Change Product Count: ");
                Console.WriteLine("4-Change Product Category: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        changeProductName();
                        break;
                    case "2":
                        changeProductPrice();
                        break;
                    case "3":
                        changeProductCount();
                        break; 
                    case "4":
                        changeProductCategory();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("No products added\nAdd products!\n");
            }
        }
        private static void changeProductName()
        {
            Console.WriteLine("Enter the product code: ");
            string cod = Console.ReadLine();
            if (mMenu.Products.Exists(p => p.Code == cod))
            {
                Console.WriteLine("Add a new name: ");
                string name = Console.ReadLine();
                mMenu.ChangeProduct(cod, name);

                Console.WriteLine($"Name Changed\nThe new name of the product: {mMenu.ChangedProductName(cod)}");
            }
            else
            {
                Console.WriteLine("There is no product that fits this code");
            }
        }



        private static void changeProductPrice()
        {
            Console.WriteLine("Enter the product code: ");
            string cod = Console.ReadLine();
            if (mMenu.Products.Exists(p => p.Code == cod))
            {

                Console.WriteLine("Add a new price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                mMenu.ChangeProduct(cod, price);
                Console.WriteLine($"Price Changed\nNew price of the product: {mMenu.ChangedProductPrice(cod)}");
            }
            else
            {
                Console.WriteLine("There is no product that fits this code");
            }
        }

        private static void changeProductCount()
        {
            Console.WriteLine("Enter the product code: ");
            string cod = Console.ReadLine();
            if (mMenu.Products.Exists(p => p.Code == cod))
            {
                Console.WriteLine("Add a new count: ");
                int count = Convert.ToInt32(Console.ReadLine());
                mMenu.ChangeProduct(cod, count );
                Console.WriteLine($"Count Changed\nNew count of the product: {mMenu.ChangedCount(cod)}");
            }
            else
            {
                Console.WriteLine("There is no product that fits this code");
            }
        }


        private static void changeProductCategory()
        {
            Console.WriteLine("Enter the product code: ");
            string cod = Console.ReadLine();
            if (mMenu.Products.Exists(p => p.Code == cod))
            {

                Category();
                Console.WriteLine("Add a new category: ");
                string category =Console.ReadLine();
                mMenu.ChangeProduct(cod, CategorySetter(category));
                Console.WriteLine($"Category Changed\nNew category of the product: {mMenu.ChangedProductCategory(cod)}");
            }
            else
            {
                Console.WriteLine("There is no product that fits this code");
            }
        }






        #endregion


        #region RemoveProduct
        private static void RemoveProduct()
        {
            bool loop = true;
            if (mMenu.Products.Count == 0)
            {
                loop = false;
                Console.WriteLine("No products added\nAdd products!\n");
            }
            while (loop)
            {
                Console.WriteLine("Enter the product code to be deleted");
                string cod = Console.ReadLine();

                if (mMenu.Products.Exists(r => r.Code == cod))
                {
                    var removed = mMenu.Products.RemoveAll(r=>r.Code == cod);
                    Console.WriteLine("The product has been deleted");
                    loop = false;
                    foreach (var item in mMenu.Products)
                    {
                        Console.WriteLine($"The remaining products: {item.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("There is no product that fits this code");
                }
            }
        }

        #endregion

        #region ShowAllProducts
        private static void ShowAllProducts()
        {

            if (mMenu.Products.Count > 0)
            {
                foreach (var item in mMenu.Products)
                {
                    Console.WriteLine($"\nProduct Code: {item.Code}\nProduct Name: {item.Name}\nProduct Price: {item.Price}\nProduct Category: {item.Categories}\nProduct Count: {item.Count}");
                }
            }
            else
            {
                Console.WriteLine("No products added\nAdd products!\n");
            }

        }

        #endregion

        #region ShowProductCategory

        private static void ShowProductsCategory()
        {
            bool loop = true;
            if (mMenu.Products.Count == 0)
            {
                loop = false;
                Console.WriteLine("No products added\nAdd products!\n");
            }

            {
                while (loop)
                {
                    Category();
                    string categories = Console.ReadLine();
                    if (mMenu.Products.Exists(c => c.Categories == CategorySetter(categories)))
                    {
                        foreach (var item in mMenu.GetProuductCategory(CategorySetter(categories)))
                        {
                            Console.WriteLine($"\nProduct Code: {item.Code}\nProduct Name: {item.Name}\nProduct Price: {item.Price}\nProduct Category: {item.Categories}\nProduct Count: {item.Count}");
                        }
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("There are no products in this category\n");
                    }
                }
            }
        }
        #endregion


        #region ShowProductPrice
        private static void ShowProductsPrice()
        {
            Console.WriteLine("Enter the price range: ");
            Console.Write("Min. ");
            double min = Convert.ToDouble(Console.ReadLine());

            Console.Write("Max. ");
            double max = Convert.ToDouble(Console.ReadLine());
            if (mMenu.Products.Exists(m => m.Price >= min && m.Price <= max))
            {
                foreach (var item in mMenu.GetProuductPrice(min, max))
                {
                    Console.WriteLine($"\nProduct Code: {item.Code}\nProduct Name: {item.Name}\nProduct Price: {item.Price}\nProduct Category: {item.Categories}\nProduct Count: {item.Count}");
                }
            }
            else
            {
                Console.WriteLine("There is no product that fits this price range");
            }
        }
        #endregion

        #region ShowProductSearch
        private static void ShowProductsSearch()
        {
            Console.WriteLine("Enter the product you are looking for");
            string search = Console.ReadLine();
            search = search.ToLower();

            if (mMenu.Products.Exists(p => p.Name.Contains(search)) || mMenu.Products.Exists(p => p.Name.Contains(search = search.ToUpper())))
            {
                foreach (var item in mMenu.GetProductSearch(search))
                {
                    Console.WriteLine($"\nProduct Code: {item.Code}\nProduct Name: {item.Name}\nProduct Price: {item.Price}\nProduct Category: {item.Categories}\nProduct Count: {item.Count}");
                }
            }
            else
            {
                Console.WriteLine("No product found");
            }
        }

        #endregion

        public static bool YesNo(string text)
        {
            Console.Write($"{text}... [y] :\nGeri qayıtmaq üçün istenilen düymeye basın...");
            ConsoleKey response = Console.ReadKey(false).Key;
            Console.WriteLine();
            return (response == ConsoleKey.Y);
        }
        public static bool YesNo()
        {
            Console.Write("Bu menyuda davam etmek üçün... [y] :\nAna menyuya qayıtmaq üçün istenilen düymeye basın...");
            ConsoleKey response = Console.ReadKey(false).Key;
            Console.WriteLine();
            return (response == ConsoleKey.Y);
        }
    }
}
