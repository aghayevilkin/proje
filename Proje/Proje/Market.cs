using System;
using System.Collections.Generic;
using System.Text;

namespace Proje
{
    class Market : IMarketable
    {
        public Market()
        {
            Sales = new List<Sale>();
            Products = new List<Product>();
        }

        public List<Sale> Sales { get; set; }
        public List<Product> Products { get; set; }



        public void Addproduct(Product product)
        {
            if (Products == null)
            {
                throw new NullReferenceException("Null Gonderile Bilmez");
            }
            if (!Products.Exists(p => p.Code == product.Code))
            {
                Products.Add(product);
            }
            
        }



        public void Addsale(Product products, int count)
        {
            Product product = new Product(products.Name, products.Price, products.Count, products.Code, products.Categories);
            if (count>0 && Products.Exists(p=>p.Code==product.Code))
            {
                SaleItem salesItems = new SaleItem(product) { Count = count };
                List<SaleItem> salesItemsList = new List<SaleItem>();
                salesItemsList.Add(salesItems);
                Sale sale = new Sale(salesItemsList) { SaleItems = salesItemsList, TotalAmount = product.Price * count };
                Sales.Add(sale);
                products.Count = products.Count - count;
            }
        }



        public void cancleSaleProduct(int salesNo, int salesItemsNo, int SalesItemsCount)
        {

            foreach (var saless in Sales)
            {
                if (saless.No == salesNo)
                {
                    foreach (var salesitems in saless.SaleItems)
                    {
                        if (salesitems.No == salesItemsNo)
                        {
                            if (SalesItemsCount<=salesitems.Count)
                            {
                                salesitems.Count -= SalesItemsCount;
                            }
                            else
                            {
                                Console.WriteLine("Max {0} Daxil ede bilersiniz",salesitems.Count);
                            }
                           
                        }
                    }
                }
            }

        }



        public void CancleSaleGeneral(int salesNo)
        {
            var sale = Sales.RemoveAll(s => s.No == salesNo);
        }

        public void ChangeProduct(string cod, string name)
        {
            Product product = Products.Find(p => p.Code == cod);
            if (product != null)
                product.Name = name;
        }

        public void ChangeProduct(string cod, int count)
        {
            Product product = Products.Find(p => p.Code == cod);
            if (product != null)
                product.Count = count;
        }
        public void ChangeProduct(string cod, double price)
        {
            Product product = Products.Find(p => p.Code == cod);
            if (product != null)
                product.Price = price;
        }
        public void ChangeProduct(string cod, Categories categories)
        {
            Product product = Products.Find(p => p.Code == cod);
            if (product != null)
                product.Categories = categories;
        }


        public string ChangedProductName(string cod)
        {
            Product product = Products.Find(p => p.Code == cod);
            string name = product.Name;
            return name;
        }

        public int ChangedCount(string cod)
        {
            Product product = Products.Find(p => p.Code ==cod);
            int i = product.Count;
            return i;
        }
        public double ChangedProductPrice(string cod)
        {
            Product product = Products.Find(p => p.Code == cod);
            double doub = product.Price;
            return doub;
        }
        public Categories ChangedProductCategory(string cod)
        {
            Product product = Products.Find(p => p.Code == cod);
            Categories categories = product.Categories;
            return categories;
        }



        public List<Product> GetProductSearch(string name)
        {
            var product = Products.FindAll(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            return product;
        }



        public List<Product> GetProuductCategory(Categories categories)
        {
            var products = Products.FindAll(p => p.Categories == categories);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine("Name: {0} Price: {1} Count: {2} Category{3}",item.Name,item.Price,item.Count,item.Categories);
            //}
            return products;
        }



        public List<Product> GetProuductPrice(double startPrice, double endPrice)
        {
                var prices = Products.FindAll(a => a.Price >= startPrice && a.Price <= endPrice);
                return prices;
 
        }



        public List<Sale> GetSaleAmount(double startAmount, double endAmount)
        {
            var amounts = Sales.FindAll(a =>Convert.ToDouble( a.TotalAmount) >= startAmount && Convert.ToDouble( a.TotalAmount) <= endAmount);
            return amounts;
        }



        public List<Sale> GetSaleDate(DateTime datetime)
        {
            var date = Sales.FindAll(d => d.SaleDate == datetime);
            return date;
        }



        public List<Sale> GetSaleDates(DateTime startDate, DateTime endDate)
        {
            var dates = Sales.FindAll(d => d.SaleDate >= startDate && d.SaleDate <= endDate);
            return dates    ;
        }

        public void AddSaleItems(Product product, int count)
        {
            SaleItem salesItems = new SaleItem(product) { Count = count };

            foreach (var item in Sales)
            {
                item.SaleItems.Add(salesItems);
            }
        }


        public List<Sale> GetSaleNo(int no)
        {
            var No = Sales.FindAll(n => n.No == no);
            return No;
        }
    }
}
