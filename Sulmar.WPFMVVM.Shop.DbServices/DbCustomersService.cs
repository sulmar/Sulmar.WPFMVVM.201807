using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.DbServices
{
    public class DbCustomersService : ICustomersService
    {
        private readonly ShopContext context;


        public DbCustomersService(ShopContext context)
        {
            this.context = context;
        }

        public DbCustomersService()
            : this(new ShopContext())
        {
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public Customer Get(int id) => context.Customers.Find(id);

        public ICollection<Customer> Get() => context.Customers.ToList();

        public async Task<ICollection<Customer>> GetAsync() => await context.Customers.ToListAsync();

        public void Update(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
