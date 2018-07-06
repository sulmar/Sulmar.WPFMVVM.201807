using Sulmar.WPFMVVM.Common;
using Sulmar.WPFMVVM.Shop.DbServices;
using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.MockServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sulmar.WPFMVVM.Shop.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        private readonly ICustomersService customersService;

        public CustomersViewModel()
            : this(new DbCustomersService())
        {

        }

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            LoadCommand = new RelayCommand(p => LoadAsync());

        }

        public ICommand LoadCommand { get; set; }

        public async void LoadAsync()
        {
            Customers = new ObservableCollection<Customer>(await customersService.GetAsync());
        }


        public void Load()
        {
            Customers = new ObservableCollection<Customer>(customersService.Get());


            SelectedCustomer = Customers.First();
        }


        #region RemoveCommand

        private ICommand removeCommand;
        public ICommand RemoveCommand
        {
            get
            {
                if (removeCommand == null)
                {
                    removeCommand = new RelayCommand(p => Remove(), p => IsSelectedCustomer);
                }

                return removeCommand;
            }
        }

        public void Remove()
        {
            customersService.Remove(SelectedCustomer);
            Customers.Remove(SelectedCustomer);
        }

        #endregion


        #region 

        private ICommand _UpdateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (_UpdateCommand == null)
                {
                    _UpdateCommand = new RelayCommand(p => Update(), p => CanUpdate);
                }

                return _UpdateCommand;
            }
        }

        public void Update()
        {
            //   SelectedCustomer.FirstName = "XXXXXXX";

            customersService.Update(SelectedCustomer);
        }

        public bool CanUpdate => IsSelectedCustomer;

        #endregion


        #region SendCommand

        private ICommand _SendCommand;
        public ICommand SendCommand
        {
            get
            {
                if (_SendCommand == null)
                {
                    _SendCommand = new RelayCommand(p => Send(), p => CanSend());
                }

                return _SendCommand;
            }
        }

        public void Send()
        {
            Console.WriteLine($"Send email to {SelectedCustomer.FirstName}");
        }

        public bool CanSend()
        {

            return IsSelectedCustomer && !string.IsNullOrEmpty(SelectedCustomer.EMail);
        }


        #endregion

        public bool IsSelectedCustomer
        {
            get
            {
                return SelectedCustomer != null;
            }
        }

       
    }
}
