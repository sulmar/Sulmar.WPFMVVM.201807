using Sulmar.WPFMVVM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sulmar.WPFMVVM.Shop.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {

     //   public IList<BaseViewModel> ViewModels { get; set; }

        public BaseViewModel SelectedViewModel { get; set; }

        private readonly IViewModelLocator viewModelLocator;

        public ShellViewModel()
            : this(new ViewModelLocator())
        {

        }

        public ShellViewModel(IViewModelLocator viewModelLocator)
        {
            this.viewModelLocator = viewModelLocator;

            SelectedViewModel = viewModelLocator.Get("Customers");
        }


        #region ShowCustomersCommand

       

        #endregion

        #region ShowEntitiesCommand

        private ICommand _ShowEntitiesCommand;

        public ICommand ShowEntitiesCommmand
        {
            get
            {
                if (_ShowEntitiesCommand == null)
                {
                    _ShowEntitiesCommand = new RelayCommand(ShowEntities);
                }

                return _ShowEntitiesCommand;
            }
        }

        private void ShowEntities(object parameter)
        {
            SelectedViewModel = viewModelLocator.Get(parameter);
        }

        #endregion
    }
}
