using System;
using System.Collections.Generic;
using System.Text;

namespace Proje
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Code { get; set; }
        public Categories Categories { get; set; }


        public Product(string name,double price,int count,string code,Categories categories)
        {

            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.Code = code;
            this.Categories = categories;

        }

    }
}
