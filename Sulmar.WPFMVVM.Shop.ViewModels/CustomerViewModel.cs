using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.MockServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        private readonly ICustomersService customersService;

        public CustomerViewModel()
            : this(new MockCustomersService())
        {

        }

        public CustomerViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }


        public void Load()
        {
            Customer = customersService.Get(3);
        }
    }
}
