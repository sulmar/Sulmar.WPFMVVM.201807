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
            new Customer { Id = 1, FirstName = "Marcin", LastName = "Sulecki", Birthday = DateTime.Parse("1975-01-01"), Sex = Sex.Male, EMail = "marcin.sulecki@sulmar.pl" },
            new Customer { Id = 2, FirstName = "Bartek", LastName = "Sulecki", Birthday = DateTime.Parse("2006-05-01"), Sex = Sex.Male },
            new Customer { Id = 3, FirstName = "Kasia", LastName = "Sulecka", Birthday = DateTime.Parse("2000-05-01"), Sex = Sex.Female },
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
