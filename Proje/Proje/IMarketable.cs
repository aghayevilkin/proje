using System;
using System.Collections.Generic;
using System.Text;

namespace Proje
{
    interface IMarketable
    {
        List<Sale> Sales { get; set; }
        List<Product> Products { get; set; }


        void Addsale(Product products, int count);
        void cancleSaleProduct(int salesNo, int salesItemsNo, int SalesItemsCount);
        void CancleSaleGeneral(int salesNo);
        List<Sale> GetSaleDate(DateTime datetime);
        List<Sale> GetSaleDates(DateTime startDate, DateTime endDate);
        List<Sale> GetSaleAmount(double startAmount, double endAmount);
        List<Sale> GetSaleNo(int no);



        void Addproduct(Product product);
        void ChangeProduct(string cod, string name);
        void ChangeProduct(string cod, int count);
        void ChangeProduct(string cod, double price);
        void ChangeProduct(string cod, Categories categories);

        List<Product> GetProuductCategory(Categories categories);
        List<Product> GetProuductPrice(double startPrice, double endPrice);
        List<Product> GetProductSearch(string name);


                                                                
    }
}
