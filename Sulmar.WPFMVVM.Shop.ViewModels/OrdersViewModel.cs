using Sulmar.WPFMVVM.Common;
using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.MockServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sulmar.WPFMVVM.Shop.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        public ICollection<Order> Orders { get; set; }

        public Order SelectedOrder { get; set; }

        private readonly IOrdersService ordersService;

        public OrdersViewModel()
            : this(new MockOrdersService(new MockCustomersService(), new MockProductsService()))
        {
        }


        public OrdersViewModel(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }


        private ICommand _LoadCommand;

        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new RelayCommand(p => LoadAsync());
                }

                return _LoadCommand;
            }
        }


        public void Load()
        {
            this.Orders = ordersService.Get();
        }

        public async void LoadAsync()
        {
            this.Orders = await ordersService.GetAsync();
        }
    }
}
