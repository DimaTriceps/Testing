﻿namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        //public static Product[] GetProducts()
        //{
        //    Product kayak = new Product { Name = "Kayak", Price = 275M };
        //    Product lifejacket = new Product { Name = "lifejacket", Price = 49M };
        //    return new Product[] { kayak, lifejacket };
        //}
    }

    public class ProductDataSource : IDataSource
    {
        public IEnumerable<Product> Products => new Product[]
        {
            new Product{Name = "kayak", Price = 275M},
            new Product{Name = "Lifejacket", Price = 49M}
        };
    }
}
