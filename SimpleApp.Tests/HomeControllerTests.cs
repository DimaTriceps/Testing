using Microsoft.AspNetCore.Mvc;
using Xunit;
using System.Collections.Generic;
using SimpleApp.Controllers;
using SimpleApp.Models;

namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        class FakeDataSource : IDataSource
        {
            public IEnumerable<Product> Products { get; set; }
            public FakeDataSource(Product[] data)
            {
                Products = data;
            }
        }
        [Fact]
        public void IndexActionModelIsComplete()
        {
            //Arrange
            var controller = new HomeController();
            Product[] products = new Product[]
            {
                new Product{Name="kayak", Price=275M },
                new Product {Name="lifejacket", Price = 49M}
            };

            //Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;
            //Assert
            Assert.Equal(products, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name &&
                    p1.Price == p2.Price));
        }
    }
}
