using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoHAutomation.DAL.Entities;

namespace DemoHAutomation.BAL.Services
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Pen", Price = 1.50M },
                new Product { Id = 2, Name = "Notebook", Price = 3.00M },
                new Product { Id = 3, Name = "Backpack", Price = 15.00M }
            };
        }

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
    }

}
