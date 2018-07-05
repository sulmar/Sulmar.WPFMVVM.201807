using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.MockServices
{
    public class MockOrdersService : IOrdersService
    {
        private ICollection<Order> orders = new List<Order>();

        public MockOrdersService(ICustomersService customersService, IProductsService productsService)
        {
            var order1 = new Order
            {
                CreateDate = DateTime.Now,
                OrderNumber = "ZAM 1/2018",
                Customer = customersService.Get(1),
                Details = new List<OrderDetail>
                {
                    new OrderDetail
                    {
                        Product = productsService.Get(1),
                        Quantity = 10,
                        UnitPrice = 100
                    },
                     new OrderDetail
                    {
                        Product = productsService.Get(2),
                        Quantity = 2,
                        UnitPrice = 400
                    }
                }
            };

            orders.Add(order1);

            var order2 = new Order
            {
                CreateDate = DateTime.Now,
                OrderNumber = "ZAM 2/2018",
                Customer = customersService.Get(2),
                Details = new List<OrderDetail>
                {
                    new OrderDetail
                    {
                        Product = productsService.Get(2),
                        Quantity = 10,
                        UnitPrice = 100
                    }
                }
            };

            orders.Add(order2);

        }

        public ICollection<Order> Get()
        {

            Thread.Sleep(TimeSpan.FromSeconds(5));

            return orders;
        }

        public Order Get(int id) => orders.SingleOrDefault(o => o.Id == id);

        public Task<ICollection<Order>> GetAsync()
        {
            return Task.Run(() => Get());
        }

        public Task<Order> GetAsync(int id)
        {
            return Task.Run(() => Get(id));
        }
    }
}
