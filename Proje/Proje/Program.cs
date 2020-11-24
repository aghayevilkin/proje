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


        #region Menu

            bool wantToContinue = true;
            while (wantToContinue)
            {
                Console.Clear();
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("*                              Chose an option:                               *");
                Console.WriteLine("*                     <1> Carry out operations on products                    *");
                Console.WriteLine("*                     <2> Carry out operations on sales                       *");
                Console.WriteLine("*                     <3>            Log out                                  *");
                Console.WriteLine("*******************************************************************************");
                Console.Write("\r\nSelect an option: ");

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
                            suEmeliyyat();
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

        #endregion

        #region Operations on Products


        public static void muEmeliyyat()
        {

            Console.Clear();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                              Chose an option                                *");
            Console.WriteLine("*                           1.1) Add New Product                              *");
            Console.WriteLine("*                           1.2) Change Product                               *");
            Console.WriteLine("*                           1.3) Remove Product                               *");
            Console.WriteLine("*                           1.4) Show All Products                            *");
            Console.WriteLine("*                           1.5) Show Products by Category                    *");
            Console.WriteLine("*                           1.6) Show Proudcts by Price Range                 *");
            Console.WriteLine("*                           1.7) Search Products by Name                      *");
            Console.WriteLine("*                           1.8) Return to the main menu                      *");
            Console.WriteLine("*******************************************************************************");
            Console.Write("\r\nSelect an option: ");

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



        #endregion


        #region ChangeProduct
        private static void ChangeProduct()
        {
            if (mMenu.Products.Count > 0)
            {
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("*                             Chose an option                                 *");
                Console.WriteLine("*                         1-Change Product Name:                              *");
                Console.WriteLine("*                         2-Change Product Price:                             *");
                Console.WriteLine("*                         3-Change Product Count:                             *");
                Console.WriteLine("*                         4-Change Product Category:                          *");
                Console.WriteLine("*******************************************************************************");
                Console.Write("\r\nSelect an option: ");

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
                mMenu.ChangeProduct(cod, count);
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
                string category = Console.ReadLine();
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
                    var removed = mMenu.Products.RemoveAll(r => r.Code == cod);
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

        #endregion



        #region Operations on Sales


        private static void suEmeliyyat()
        {

            Console.Clear();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                              Chose an option:                               *");
            Console.WriteLine("*                        1) Add new sales                                     *");
            Console.WriteLine("*                        2) Return of the product put up for sale             *");
            Console.WriteLine("*                        3) Remove Sale                                       *");
            Console.WriteLine("*                        4) Show All Sales                                    *");
            Console.WriteLine("*                        5) Show Sales Price                                  *");
            Console.WriteLine("*                        6) Show sales by date                                *");
            Console.WriteLine("*                        7) Show sales by date range                          *");
            Console.WriteLine("*                        8) Show sales information based on the number        *");
            Console.WriteLine("*******************************************************************************");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddSale();
                    break;
                case "2":
                    ReturnedProduct();
                    break;
                case "3":
                    RemoveSale();
                    break;
                case "4":
                    saSales();
                    break;
                case "5":
                    ssPrice();
                    break;
                case "6":
                    ssDate();
                    break;
                case "7":
                    ssDateRange();
                    break;
                case "8":
                    ssNo();
                    break;
                case "9":
                    Console.Write($"Esas menyuya qayitmaq ucun {ConsoleKey.N} secin: ");
                    break;
                default:
                    break;
            }
        }


        #region AddSale

        private static void AddSale()
        {
            if (ShowProductsCount() > 0)
            {
                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Enter the product code");
                    string cod = Console.ReadLine();

                    if (mMenu.Products.Exists(p => p.Code == cod))
                    {
                        Console.WriteLine("Enter the sales number of this product");
                        int count = Convert.ToInt32(Console.ReadLine());




                        if (FindProduct(cod).Count >= count && count > 0)
                        {
                            mMenu.Addsale(FindProduct(cod), count);
                            Console.WriteLine("\nProduct Added!");

                            while (YesNo("\nSelect to add another product..."))
                            {

                                if (ShowProductsCount() > 0)
                                {
                                    AddItems();
                                }
                                else
                                {
                                    Console.WriteLine("\nNo Product !");
                                    break;
                                }

                            }
                            Console.WriteLine("\nSales Added !");
                            Console.WriteLine("__________");
                            foreach (var salesitems in FindSales(FindSalesNo()).SaleItems)
                            {
                                Console.WriteLine($"\nproduct name: {salesitems.Products.Name}\nnumber products on sale: {salesitems.Count}");
                            }
                            loop = false;
                            Console.WriteLine("__________");


                        }
                        else
                        {
                            Console.WriteLine("there are not as many products as you enter");
                        }

                    }
                    else
                    {
                        Console.WriteLine("There is no product that fits this code");
                    }
                }

            }
            else
            {
                Console.WriteLine("No Product \nAdd the Product!\n");
            }


        }


        #region SalesFind
        public static Product FindProduct(string cod)
        {
            Product product = mMenu.Products.Find(p => p.Code == cod);
            return product;
        }

        public static Sale FindSales(int no)
        {
            Sale sale = mMenu.Sales.Find(s => s.No == no);
            return sale;
        }

        public static int FindSalesNo()
        {
            int No = 0;
            foreach (var item in mMenu.Sales)
            {
                No = item.No;
            }
            return No;
        }

        public static SaleItem FSItemNo(int no, int salesitemno)
        {

            Sale sales = mMenu.Sales.Find(n => n.No == no);

            SaleItem salesItems = sales.SaleItems.Find(n => n.No == salesitemno);
            return salesItems;
        }


        public static int FSIteamCountNo(int no, int sitemNO)
        {
            int count = 0;
            foreach (var item in FindSales(no).SaleItems)
            {
                if (item.No == sitemNO)
                {
                    count = item.Count;

                }
            }
            return count;
        }


        public static int FindSalesItemNo()
        {
            int number = 0;
            foreach (var sales in mMenu.Sales)
            {
                foreach (var item in sales.SaleItems)
                {
                    number = item.No;
                }
            }
            return number;
        }

        #endregion




        #endregion

        #region Return of the product put up for sale

        private static void ReturnedProduct()
        {
            Console.WriteLine("\nEnter the sales number");
            int no = 0;
            try
            {
                no = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nAn error occurred!\nOnly number must be entered!");
            }
            if (mMenu.Sales.Exists(s => s.No == no))
            {
                Console.WriteLine("\nProducts for sale");
                foreach (var sales in FindSales(no).SaleItems)
                {
                    Console.WriteLine($"\nThe number of the product for sale: {sales.No}\nThe product on sale is ordinary: {sales.Products.Name}\nNumber of products on sale: {sales.Count}");
                }
                Console.WriteLine("\nEnter the sales product number");

                int SitemNo = 0;
                try
                {
                    SitemNo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nAn error occurred!\nOnly number must be entered!");
                }
                if (FindSales(no).SaleItems.Exists(n => n.No == SitemNo) && SitemNo > 0)
                {
                    Console.WriteLine("Add the count you will return the product");
                    int count = 0;
                    try
                    {
                        count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The product was returned");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nAn error occurred!\nOnly number must be entered!");
                    }
                    if (FSIteamCountNo(no, SitemNo) >= count && count > 0)
                    {
                        mMenu.cancleSaleProduct(no, SitemNo, count);

                        Console.WriteLine("_________________________");
                        Console.WriteLine($"Number of products on sale: {FSItemNo(no, SitemNo).Count}");
                    }
                    else
                    {
                        Console.WriteLine("There are not as many products as you enter");
                    }

                }
                else
                {
                    Console.WriteLine("\nThere is no sales product that matches the count you entered");
                }
            }
            else
            {
                Console.WriteLine("\nThere are no sales for this number");
            }
        }

        #endregion

        #region RemoveSale

        private static void RemoveSale()
        {
            if (mMenu.Sales.Count > 0)
            {
                Console.WriteLine("Enter the sales number");
                int no = 0;
                try
                {
                    no = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nAn error occurred!\nOnly number must be entered!");
                    return;
                }
                if (no > 0 && mMenu.Sales.Exists(s => s.No == no))
                {
                    mMenu.CancleSaleGeneral(no);
                    Console.WriteLine("Sales deleted");
                }
                else
                {
                    Console.WriteLine("\nThere are no sales for this number");
                }
            }
            else
            {
                Console.WriteLine("\nNo Sales!");
            }
        }


        #endregion

        #region ShowAllSales

        private static void saSales()
        {
            if (mMenu.Sales.Count > 0)
            {
                foreach (var sales in mMenu.Sales)
                {
                    Console.WriteLine("____________________");
                    Console.WriteLine($"Sales number: { sales.No}\nThe total amount of sales: {sales.TotalAmount}\nSales date: {sales.SaleDate}");
                    if (FindSales(sales.No).SaleItems.Count > 0)
                    {
                        int count = 0;
                        foreach (var item in FindSales(sales.No).SaleItems)
                        {
                            count += item.Count;
                        }
                        Console.WriteLine($"Number of products on sale: {count}");
                    }
                    else
                    {
                        foreach (var item in sales.SaleItems)
                        {
                            Console.WriteLine($"Number of products on sale: {item.Count}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No Sales\nAdd sales!\n");
            }
        }


        #endregion

        #region ShowSalesPrice

        private static void ssPrice()
        {
            if (mMenu.Sales.Count > 0)
            {
                Console.WriteLine("Enter the price range: ");
                Console.Write("Min: ");
                double min = 0;
                try
                {
                    min = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nAn error occurred !\nShould be only one number!");
                    return;
                }
                if (min > 0)
                {
                    Console.Write("Max: ");
                    double max = 0;
                    try
                    {
                        max = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nAn error occurred !\nShould be only one number!");
                        return;
                    }
                    if (max > 0)
                    {
                        if (mMenu.Sales.Exists(p => p.TotalAmount >= min && p.TotalAmount <= max))
                        {
                            foreach (var sales in mMenu.GetSaleAmount(min, max))
                            {
                                Console.WriteLine($"Sales number: { sales.No}\nThe total amount of sales: {sales.TotalAmount}\nSales date: {sales.SaleDate}");
                                if (FindSales(sales.No).SaleItems.Count > 0)
                                {
                                    int count = 0;
                                    foreach (var item in FindSales(sales.No).SaleItems)
                                    {
                                        count += item.Count;
                                    }
                                    Console.WriteLine($"Number of products on sale:{count}");
                                }
                                else
                                {
                                    foreach (var item in sales.SaleItems)
                                    {

                                        Console.WriteLine($"Number of products on sale: {item.Count}");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no sales in this price range");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter the correct number!");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the correct number!");
                }
            }
            else
            {
                Console.WriteLine("No Sales\nAdd sales!\n");
            }
        }


        #endregion

        #region ShowSaleNo

        private static void ssNo()
        {
            Console.WriteLine("Enter the sales number: ");
            int No = 0;
            try
            {
                No = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nAn error occurred!\nOnly number must be entered!");
                return;
            }
            if (mMenu.Sales.Exists(p => p.No == No))
            {
                foreach (var sales in mMenu.GetSaleNo(No))
                {
                    Console.WriteLine($"Sales number: { sales.No}\nThe total amount of sales: {sales.TotalAmount}\nSales date: {sales.SaleDate}");
                    foreach (var item in sales.SaleItems)
                    {
                        Console.WriteLine($"Product name on sale: {item.Products.Name}\nThe number of the product on sale: {item.No}\nNumber of products on sale: {item.Count}");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no sales for this number");
            }
        }


        #endregion

        #region ShowSalesDate

        private static void ssDate()
        {
            if (mMenu.Sales.Count > 0)
            {
                Console.WriteLine("Enter date (day / month / year)");
                string Date = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Date))
                {
                    DateTime date;
                    if (DateTime.TryParse(Date, out date))
                    {
                        foreach (var sales in mMenu.GetSaleDate(date))
                        {
                            Console.WriteLine($"Sales number: { sales.No}\nThe total amount of sales: {sales.TotalAmount}\nSales date: {sales.SaleDate}");
                            if (FindSales(sales.No).SaleItems.Count > 0)
                            {
                                int count = 0;
                                foreach (var item in FindSales(sales.No).SaleItems)
                                {
                                    count += item.Count;
                                }
                                Console.WriteLine($"Number of products on sale: {count}");
                            }
                            else
                            {
                                foreach (var item in sales.SaleItems)
                                {
                                    Console.WriteLine($"Number of products on sale: {item.Count}");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Date entered incorrectly !");
                    }

                }
                else
                {
                    Console.WriteLine("The line cannot be left blank !");
                }
            }
            else
            {
                Console.WriteLine("No Sales !");
            }
        }


        #endregion

        #region Show sales by date range

        private static void ssDateRange()
        {
            if (mMenu.Sales.Count > 0)
            {
                Console.WriteLine("Enter start date (day / month / year)");
                string sD = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(sD))
                {
                    DateTime SD = new DateTime();
                    if (DateTime.TryParse(sD, out SD))
                    {
                        Console.WriteLine("Enter End date (day / month / year)");
                        string eD = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(eD))
                        {
                            DateTime enD = new DateTime();
                            if (DateTime.TryParse(eD, out enD))
                            {
                                foreach (var sales in mMenu.GetSaleDates(SD, enD))
                                {
                                    Console.WriteLine($"Sales number: { sales.No}\nThe total amount of sales: {sales.TotalAmount}\nSales date: {sales.SaleDate}");
                                    if (FindSales(sales.No).SaleItems.Count > 0)
                                    {
                                        int count = 0;
                                        foreach (var item in FindSales(sales.No).SaleItems)
                                        {
                                            count += item.Count;
                                        }
                                        Console.WriteLine($"Number of products on sale: {count}");
                                    }
                                    else
                                    {
                                        foreach (var item in sales.SaleItems)
                                        {

                                            Console.WriteLine($"Number of products on sale: {item.Count}");
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Date entered incorrectly!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The line cannot be left blank !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Date entered incorrectly!");
                    }
                }
                else
                {
                    Console.WriteLine("The line cannot be left blank !");
                }
            }
            else
            {
                Console.WriteLine("No Sales!");
            }
        }


        #endregion

        #endregion

        #region AuxiliaryMethods
        public static bool YesNo(string text)
        {
            Console.Write($"{text}... [y] :\nPress the desired button to return...");
            ConsoleKey response = Console.ReadKey(false).Key;
            Console.WriteLine();
            return (response == ConsoleKey.Y);
        }
        public static bool YesNo()
        {
            Console.Write("Bu menyuda davam etmək... [y] :\nPress any key to return to the main menu...");
            ConsoleKey response = Console.ReadKey(false).Key;
            Console.WriteLine();
            return (response == ConsoleKey.Y);
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


        public static int ShowSalesCount()
        {
            int count = 0;
            foreach (var sales in mMenu.Sales)
            {
                foreach (var item in sales.SaleItems)
                {
                    count = item.Count;
                }
            }
            return count;
        }

        public static int ShowProductsCount()
        {
            int count = 0;
            foreach (var item in mMenu.Products)
            {
                count = item.Count;
            }
            return count;
        }



        public static int ShowSalesItemsCount()
        {
            int count = 0;
            foreach (var item in mMenu.Sales)
            {
                foreach (var salesItems in item.SaleItems)
                {
                    count = salesItems.Count;
                }
            }

            return count;
        }


        public static void AddItems()
        {
            Console.WriteLine("Enter the product code");
            string cod = Console.ReadLine();

            if (mMenu.Products.Exists(p => p.Code == cod))
            {
                Console.WriteLine("Enter the sales number of this product");
                int count = Convert.ToInt32(Console.ReadLine());

                if (FindProduct(cod).Count >= count && count > 0)
                {
                    mMenu.AddSaleItems(FindProduct(cod), count);
                    FindProduct(cod).Count -= count;
                    foreach (var item in mMenu.Sales)
                    {
                        item.TotalAmount += count * FindProduct(cod).Price;
                    }
                    Console.WriteLine("\nProduct Added !");

                }
                else
                {
                    Console.WriteLine("There are no products you entered");
                }

            }
            else
            {
                Console.WriteLine("There is no product that fits this code");
            }

        }

        #endregion

    }
}