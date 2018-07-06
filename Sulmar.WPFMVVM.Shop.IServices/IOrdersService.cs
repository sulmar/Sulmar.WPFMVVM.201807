using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.IServices
{
    public interface IOrdersService
    {
        void Add(Order order);

        ICollection<Order> Get();
        Order Get(int id);

        Task<ICollection<Order>> GetAsync();
        Task<Order> GetAsync(int id);
    }
}
