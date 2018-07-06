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
    public class DbOrdersService : IOrdersService
    {
        private readonly ShopContext context;

        public DbOrdersService()
            : this(new ShopContext())
        {
        }

        public DbOrdersService(ShopContext context)
        {
            this.context = context;
        }

        public void Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public ICollection<Order> Get()
        {
            return context.Orders.ToList();
        }

        public Order Get(int id)
        {
            return context.Orders.Find(id);
        }

        public async Task<ICollection<Order>> GetAsync()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<Order> GetAsync(int id)
        {
            return await context.Orders.FindAsync(id);
        }
    }
}
