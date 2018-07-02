using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.MockServices
{
    public class MockCustomersService : ICustomersService
    {
        private ICollection<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Marcin", LastName = "Sulecki" },
            new Customer { Id = 2, FirstName = "Bartek", LastName = "Sulecki" }
        };

        public Customer Get(int id)
        {
            return customers.SingleOrDefault(c => c.Id == id);
        }

        public ICollection<Customer> Get()
        {
            return customers;
        }
    }
}
