using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.MockServices
{
    public class MockProductsService : IProductsService
    {
        private IList<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", UnitPrice = 100},
            new Product { Id = 2, Name = "Product 2", UnitPrice = 100},
            new Product { Id = 3, Name = "Product 3", UnitPrice = 100},
        };

        public IList<Product> Get() => products;
        public Product Get(int id) => products.SingleOrDefault(p => p.Id == id);
    }
}
