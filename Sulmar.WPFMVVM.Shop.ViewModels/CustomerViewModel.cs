using Sulmar.WPFMVVM.Common;
using Sulmar.WPFMVVM.Shop.DbServices;
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
    public class CustomerViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        private readonly ICustomersService customersService;

        //public CustomerViewModel()
        //    : this(new MockCustomersService())
        //{

        //}


        public CustomerViewModel()
            : this(new DbCustomersService())
        {

        }

        public CustomerViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            SaveCommand = new RelayCommand(p => Save());

            Load();
        }


        public void Load()
        {
            Customer = new Customer();
        }


        public ICommand SaveCommand { get; set; }

        public void Save()
        {
            customersService.Add(Customer);
        }
    }
}
