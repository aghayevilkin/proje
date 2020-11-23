using System;
using System.Collections.Generic;
using System.Text;

namespace Proje
{
    class Sale
    {
        private static int _totalNo;
        private int _no;
        public int No { get => _no; }
        public double TotalAmount { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale(List<SaleItem> salesItems)
        {
            _totalNo++; 
            _no = _totalNo;

            SaleItems = new List<SaleItem>();
            SaleItems = salesItems;
            SaleDate = DateTime.Now;

            foreach (var item in salesItems)
            {
                TotalAmount += item.Count * item.Products.Price;
            }



        }
    }
}
